using System.Collections.Generic;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public class WaveDeviceEnumerator : IWaveDeviceEnumerator
    {
        public IEnumerable<IWaveInDevice> GetWaveInDevices()
        {
            var windowsDeviceCount = WaveIn.DeviceCount;
            for (var i = 0; i < windowsDeviceCount; i++)
                yield return new WindowsWaveInDevice(i);
        }

        public IEnumerable<IWaveOutDevice> GetWaveOutDevices()
        {
            var windowsDeviceCount = WaveOut.DeviceCount;
            for (var i = 0; i < windowsDeviceCount; i++)
                yield return new WindowsWaveOutDevice(i);

            foreach (var directSoundDevice in DirectSoundOut.Devices)
                yield return new DirectSoundWaveOutDevice(directSoundDevice);
        }
    }
}
