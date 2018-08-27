using System;
using System.Collections.Generic;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public class DirectSoundWaveOutDevice : IWaveOutDevice
    {
        private readonly DirectSoundDeviceInfo _device;
        private readonly IEnumerable<IWaveOutSource> _sources;

        public Guid Id { get; } = Guid.NewGuid();
        public string Name => _device.Description;

        public IEnumerable<IWaveOutSource> GetSources()
        {
            return _sources;
        }

        private IEnumerable<IWaveOutSource> InitSources(DirectSoundDeviceInfo deviceInfo)
        {
            yield return new DirectSoundWaveOutSource(this, deviceInfo.Guid);
        }

        public DirectSoundWaveOutDevice(DirectSoundDeviceInfo deviceInfo)
        {
            _device = deviceInfo;
            _sources = InitSources(deviceInfo);
        }

        public override string ToString()
        {
            return $"DS: {Name}";
        }
    }
}
