using System.Collections.Generic;
using NAudio.Wave;

namespace Playthrough2
{
    public interface IWaveOutDevice : IWaveDevice
    {
        IEnumerable<IWaveOutSource> GetSources();
    }
}