using System;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    internal class DirectSoundWaveOutDevice : IWaveOutDevice
    {
        private readonly DirectSoundDeviceInfo _device;

        public string Name => _device.Description;
        public Guid Id => _device.Guid;
        public WaveApi Api => WaveApi.DirectSound;
        public bool SupportsBufferCount => false;
        public bool SupportsBufferSize => true;
        public bool SupportsFormat => false;

        public DirectSoundWaveOutDevice(DirectSoundDeviceInfo deviceInfo)
        {
            _device = deviceInfo;
        }

        public IWavePlayer Create(IWavePipeConfiguration config)
        {
            return new DirectSoundOut(_device.Guid, config.OutputLatency ?? 40);
        }

        public override string ToString()
        {
            return $"{Name} [DirectSound]";
        }
    }
}
