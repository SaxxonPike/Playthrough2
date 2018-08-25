using NAudio.Wave;

namespace Playthrough2.Pipes
{
    public class WavePipeConfiguration : IWavePipeConfiguration
    {
        public IWaveInDevice WaveInDevice { get; set; }
        public IWaveOutDevice WaveOutDevice { get; set; }
        public int? InputBufferCount { get; set; }
        public int? InputBufferLength { get; set; }
        public int? OutputBufferCount { get; set; }
        public int? OutputLatency { get; set; }
        public WaveFormat InputFormat { get; set; }
        public WaveFormat OutputFormat { get; set; }
        public bool UseBackgroundThread { get; set; }
        public bool DiscardSamplesIfLagging { get; set; }
        public int InputSource { get; set; }
        public int OutputSource { get; set; }
    }
}
