using System;

namespace Playthrough2
{
    public interface IWaveSource
    {
        string Name { get; }
        Guid Id { get; }
        bool SupportsBufferCount { get; }
        bool SupportsBufferSize { get; }
        bool SupportsFormat { get; }
        bool SupportsThread { get; }
    }
}