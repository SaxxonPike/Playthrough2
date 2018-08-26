using NAudio.Wave;

namespace Playthrough2.Pipes
{
    public class WavePipeConfiguration : IWavePipeConfiguration
    {
        public int? InputBufferCount { get; set; }
        public int? InputBufferLength { get; set; }
        public int? OutputBufferCount { get; set; }
        public int? OutputLatency { get; set; }
        public WaveFormat InputFormat { get; set; }
        public WaveFormat OutputFormat { get; set; }
        public bool UseBackgroundThread { get; set; }
        public bool DiscardSamplesIfLagging { get; set; }
        public IWaveInSource InputSource { get; set; }
        public IWaveOutSource OutputSource { get; set; }

        public bool IsThreadCompatible => UseBackgroundThread &&
                                          (InputSource?.Device?.SupportsThread ?? false) &&
                                          (OutputSource?.Device?.SupportsThread ?? false);
    }
}
