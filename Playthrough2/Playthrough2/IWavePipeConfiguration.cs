using NAudio.Wave;

namespace Playthrough2
{
    public interface IWavePipeConfiguration
    {
        int? InputBufferCount { get; }
        int? InputBufferLength { get; }
        int? OutputBufferCount { get; }
        int? OutputLatency { get; }
        WaveFormat InputFormat { get; }
        WaveFormat OutputFormat { get; }
        bool UseBackgroundThread { get; }
        bool DiscardSamplesIfLagging { get; }
        IWaveInSource InputSource { get; }
        IWaveOutSource OutputSource { get; }
        bool IsThreadCompatible { get; }
    }
}