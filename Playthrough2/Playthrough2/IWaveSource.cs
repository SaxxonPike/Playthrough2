using System;

namespace Playthrough2
{
    public interface IWaveSource
    {
        string Name { get; }
        Guid Id { get; }
    }
}