namespace Playthrough2
{
    public class WavePipeConfiguration : IWavePipeConfiguration
    {
        public IWaveInDevice WaveInDevice { get; set; }
        public IWaveOutDevice WaveOutDevice { get; set; }
        public int? InputBufferCount { get; set; }
        public int? InputBufferLength { get; set; }
        public int? OutputBufferCount { get; set; }
        public int? OutputLatency { get; set; }
    }
}
