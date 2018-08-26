using System;
using System.Collections.Generic;
using NAudio.Wave;

namespace Playthrough2
{
    public interface IWaveInDevice : IWaveDevice
    {
        IEnumerable<IWaveInSource> GetSources();
    }
}