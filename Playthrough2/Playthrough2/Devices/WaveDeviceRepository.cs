using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public sealed class WaveDeviceRepository : IWaveDeviceRepository
    {
        private readonly Lazy<IEnumerable<IWaveInDevice>> _waveInDevices;
        private readonly Lazy<IEnumerable<IWaveOutDevice>> _waveOutDevices;
        
        public WaveDeviceRepository()
        {
            _waveInDevices = new Lazy<IEnumerable<IWaveInDevice>>(InitWaveInDevices);
            _waveOutDevices = new Lazy<IEnumerable<IWaveOutDevice>>(InitWaveOutDevices);
        }
        
        private static IEnumerable<IWaveInDevice> InitWaveInDevices()
        {
            var waveDevices = Enumerable
                .Range(0, WaveIn.DeviceCount)
                .Select(i => new WindowsWaveInDevice(i))
                .Cast<IWaveInDevice>();
            
            var asioDevices = AsioOut.isSupported()
                ? AsioOut.GetDriverNames()
                    .Select(d => new AsioWaveInDevice(d))
                : Enumerable.Empty<IWaveInDevice>();
            
            return new ReadOnlyCollection<IWaveInDevice>(waveDevices.Concat(asioDevices).ToList());
        }

        private static IEnumerable<IWaveOutDevice> InitWaveOutDevices()
        {
            var waveDevices = Enumerable
                .Range(0, WaveOut.DeviceCount)
                .Select(i => new WindowsWaveOutDevice(i))
                .Cast<IWaveOutDevice>();

            var dsDevices = DirectSoundOut.Devices
                .Select(d => new DirectSoundWaveOutDevice(d))
                .Cast<IWaveOutDevice>();

            var asioDevices = AsioOut.isSupported()
                ? AsioOut.GetDriverNames()
                    .Select(d => new AsioWaveOutDevice(d))
                : Enumerable.Empty<IWaveOutDevice>();

            return new ReadOnlyCollection<IWaveOutDevice>(waveDevices.Concat(dsDevices).Concat(asioDevices).ToList());
        }

        public IEnumerable<IWaveInDevice> GetWaveInDevices() => _waveInDevices.Value;
        public IEnumerable<IWaveOutDevice> GetWaveOutDevices() => _waveOutDevices.Value;
    }
}