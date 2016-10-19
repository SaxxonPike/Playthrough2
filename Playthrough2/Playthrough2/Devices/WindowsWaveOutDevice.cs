using System;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    internal class WindowsWaveOutDevice : IWaveOutDevice
    {
        private readonly int _index;
        public string Name => _capabilities.ProductName;
        public WaveApi Api => WaveApi.Windows;
        public Guid Id => WaveDeviceGuidRepository.OutputGuids[_index];
        private WaveOutCapabilities _capabilities;
        public bool SupportsBufferCount => true;
        public bool SupportsBufferSize => true;
        public bool SupportsFormat => false;

        public WindowsWaveOutDevice(int index)
        {
            _index = index;
            _capabilities = WaveOut.GetCapabilities(index);
        }

        public IWavePlayer Create(IWavePipeConfiguration config)
        {
            return new WaveOut
            {
                DesiredLatency = config.OutputLatency ?? 100,
                DeviceNumber = _index,
                NumberOfBuffers = config.OutputBufferCount ?? 3,
                Volume = 1
            };
        }

        public override string ToString()
        {
            return $"{Name} [Wave]";
        }
    }
}
