using System;
using NAudio.Wave;

namespace Playthrough2
{
    public class WavePipeInfo : IWavePipeInfo
    {
        public WavePipeInfo(IWavePipeConfiguration wavePipeConfiguration)
        {
            WaveInDevice = wavePipeConfiguration.WaveInDevice;
            WaveOutDevice = wavePipeConfiguration.WaveOutDevice;
            WaveIn = WaveInDevice.Create(wavePipeConfiguration);
            WaveOut = WaveOutDevice.Create(wavePipeConfiguration);
            WavePipe = new WavePipe(WaveIn, WaveOut);
        }

        private IWavePipe WavePipe { get; }
        private IWavePlayer WaveOut { get; }
        private IWaveIn WaveIn { get; }
        public IWaveInDevice WaveInDevice { get; }
        public IWaveOutDevice WaveOutDevice { get; }

        public void Start()
        {
            WavePipe.Start();
        }

        public void Stop()
        {
            WavePipe.Stop();
        }

        public void Dispose()
        {
            WaveOut.Stop();
            WaveIn.StopRecording();
            WaveOut.Dispose();
            WaveIn.Dispose();
        }
    }
}
