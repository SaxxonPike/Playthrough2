using System;
using System.Collections.Generic;
using Playthrough2.Devices;

namespace Playthrough2
{
    public interface IWaveDevice
    {
        Guid Id { get; }
        string Name { get; }
    }
}
