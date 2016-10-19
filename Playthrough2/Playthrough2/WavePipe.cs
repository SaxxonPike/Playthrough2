using NAudio.Wave;

namespace Playthrough2
{
    public class WavePipe : IWavePipe
    {
        private readonly IWaveProvider _stream;

        public WavePipe(IWaveIn waveIn, IWavePlayer waveOut)
        {
            _stream = new WaveInProvider(waveIn);
            WaveIn = waveIn;
            WaveOut = waveOut;
        }

        public void Start()
        {
            if (Running)
                return;

            Running = true;
            WaveIn.StartRecording();
            WaveOut.Init(_stream);
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

        public IWaveIn WaveIn { get; }
        public IWavePlayer WaveOut { get; }
        public bool Running { get; private set; }
    }
}
