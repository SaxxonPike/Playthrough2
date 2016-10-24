using NAudio.Wave;

namespace Playthrough2.Pipes
{
    internal class WavePipeInfo : IWavePipeInfo
    {
        public WavePipeInfo(IWavePipeConfiguration wavePipeConfiguration)
        {
            Configuration = wavePipeConfiguration;
            WaveInDevice = wavePipeConfiguration.WaveInDevice;
            WaveOutDevice = wavePipeConfiguration.WaveOutDevice;
            Configure(wavePipeConfiguration);
        }

        private IWavePipe WavePipe { get; set; }
        private IWavePlayer WaveOut { get; set; }
        private IWaveIn WaveIn { get; set; }
        public IWaveInDevice WaveInDevice { get; }
        public IWaveOutDevice WaveOutDevice { get; }
        public IWavePipeConfiguration Configuration { get; private set; }

        private void Configure(IWavePipeConfiguration configuration)
        {
            WavePipe?.Dispose();
            WaveIn?.Dispose();
            WaveOut?.Dispose();

            WaveIn = WaveInDevice.Create(configuration);
            WaveOut = WaveOutDevice.Create(configuration);
            WavePipe = new WavePipe(WaveIn, WaveOut);
        }

        public void Start()
        {
            WavePipe.Start();
        }

        public void Reconfigure(IWavePipeConfiguration configuration)
        {
            Configuration = configuration;
            Stop();
            Configure(configuration);
            Start();
        }

        public void Stop()
        {
            WavePipe.Stop();
        }

        public void Dispose()
        {
            WavePipe.Dispose();
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
