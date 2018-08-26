using NAudio.Wave;

namespace Playthrough2.Pipes
{
    internal class WavePipeInfo : IWavePipeInfo
    {
        public WavePipeInfo(IWavePipeConfiguration wavePipeConfiguration)
        {
            Configuration = wavePipeConfiguration;
            InputSource = wavePipeConfiguration.InputSource;
            OutputSource = wavePipeConfiguration.OutputSource;
            Configure(wavePipeConfiguration);
        }

        private IWavePipe WavePipe { get; set; }
        private IWavePlayer WaveOut { get; set; }
        private IWaveIn WaveIn { get; set; }
        private IWaveInSource InputSource { get; }
        private IWaveOutSource OutputSource { get; }
        public IWavePipeConfiguration Configuration { get; private set; }

        private void Configure(IWavePipeConfiguration configuration)
        {
            WavePipe?.Dispose();
            WaveIn?.Dispose();
            WaveOut?.Dispose();

            WaveIn = InputSource.Open(configuration);
            WaveOut = OutputSource.Open(configuration);
            WavePipe = new WavePipe(InputSource, OutputSource, configuration);
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
            return $"{InputSource.Device.Name}:{InputSource.Name} -> {OutputSource.Device.Name}:{OutputSource.Name}";
        }
    }
}
