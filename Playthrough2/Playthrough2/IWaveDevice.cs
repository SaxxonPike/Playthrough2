using System;

namespace Playthrough2
{
    public interface IWaveDevice
    {
        string Name { get; }
        Guid Id { get; }
        WaveApi Api { get; }
        bool SupportsBufferCount { get; }
        bool SupportsBufferSize { get; }
    }
}
