using System.Collections.Generic;
using NAudio.Wave;

namespace Playthrough2.Pipes
{
    internal class WavePipeThreadInfo : IWavePipeThreadInfo
    {
        private readonly IWaveInDevice _waveInDevice;
        private readonly IWaveOutDevice _waveOutDevice;
        private readonly IWavePipeConfiguration _configuration;

        public WavePipeThreadInfo(IWaveInDevice waveIn, IWaveOutDevice waveOut, IWavePipeConfiguration configuration)
        {
            _waveInDevice = waveIn;
            _waveOutDevice = waveOut;
            _configuration = configuration;
        }

        private IWaveProvider Stream { get; set; }
        public Queue<WavePipeThreadCommand> CommandQueue { get; } = new Queue<WavePipeThreadCommand>();
        private IWaveIn WaveIn { get; set; }
        private IWavePlayer WaveOut { get; set; }

        public void Initialize()
        {
            WaveIn = _waveInDevice.Create(_configuration);
            WaveOut = _waveOutDevice.Create(_configuration);
            Stream = new WaveInBufferedStreamProvider(WaveIn, _configuration);
        }

        public void Start()
        {
            if (Running)
                return;

            Running = true;
            WaveIn.StartRecording();
            WaveOut.Init(Stream);
            WaveOut.Play();
        }

        public void Stop()
        {
            if (!Running)
                return;

            WaveIn.StopRecording();
            if (WaveOut.PlaybackState == PlaybackState.Playing)
                WaveOut.Stop();
            Running = false;
        }

        public bool Running { get; private set; }
    }
}
