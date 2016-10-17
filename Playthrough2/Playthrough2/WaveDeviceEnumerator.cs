using System.Collections.Generic;
using NAudio.Wave;

namespace Playthrough2
{
    public class WaveDeviceEnumerator
    {
        public IEnumerable<WaveInDevice> GetWaveInDevices()
        {
            var count = WaveIn.DeviceCount;
            for (var i = 0; i < count; i++)
                yield return new WaveInDevice(i);
        }

        public IEnumerable<WaveOutDevice> GetWaveOutDevices()
        {
            var count = WaveOut.DeviceCount;
            for (var i = 0; i < count; i++)
                yield return new WaveOutDevice(i);
        }
    }
}
