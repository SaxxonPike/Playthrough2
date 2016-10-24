using System.Collections.Generic;

namespace Playthrough2
{
    public interface IWaveDeviceEnumerator
    {
        IEnumerable<IWaveInDevice> GetWaveInDevices();
        IEnumerable<IWaveOutDevice> GetWaveOutDevices();
    }
}