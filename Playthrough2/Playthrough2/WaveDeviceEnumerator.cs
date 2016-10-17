using System.Collections.Generic;
using NAudio.Wave;

namespace Playthrough2
{
    public class WaveDeviceEnumerator
    {
        public IEnumerable<IWaveInDevice> GetWaveInDevices()
        {
            var count = WaveIn.DeviceCount;
            for (var i = 0; i < count; i++)
                yield return new WindowsWaveInDevice(i);
        }

        public IEnumerable<IWaveOutDevice> GetWaveOutDevices()
        {
            var count = WaveOut.DeviceCount;
            for (var i = 0; i < count; i++)
                yield return new WindowsWaveOutDevice(i);
        }
    }
}
