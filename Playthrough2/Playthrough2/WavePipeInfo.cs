using NAudio.Wave;

namespace Playthrough2
{
    public class WavePipeInfo : IWavePipeInfo
    {
        public WavePipeInfo(IWavePipeConfiguration wavePipeConfiguration)
        {
            Configuration = wavePipeConfiguration;
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
        public IWavePipeConfiguration Configuration { get; private set; }

        public void Start()
        {
            WavePipe.Start();
        }

        public void Reconfigure(IWavePipeConfiguration configuration)
        {
            Configuration = configuration;
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

        public override string ToString()
        {
            return $"{WaveInDevice.Name} -> {WaveOutDevice.Name}";
        }
    }
}
