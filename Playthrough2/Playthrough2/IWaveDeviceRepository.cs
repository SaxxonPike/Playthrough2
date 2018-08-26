using System.Collections.Generic;

namespace Playthrough2
{
    public interface IWaveDeviceRepository
    {
        IEnumerable<IWaveInDevice> GetWaveInDevices();
        IEnumerable<IWaveOutDevice> GetWaveOutDevices();
    }
}