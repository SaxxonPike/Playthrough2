namespace Playthrough2
{
    public interface IWavePipeConfiguration : IWavePipeDeviceInfo
    {
        int? InputBufferCount { get; }
        int? InputBufferLength { get; }
        int? OutputBufferCount { get; }
        int? OutputLatency { get; }
    }
}