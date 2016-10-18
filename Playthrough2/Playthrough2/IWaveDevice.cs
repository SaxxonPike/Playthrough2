using System;
using System.Collections.Generic;
using System.Text;

namespace Playthrough2
{
    public interface IWaveDevice
    {
        string Name { get; }
        int Index { get; }
        WaveApi Api { get; }
    }
}
