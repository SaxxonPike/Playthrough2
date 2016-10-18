using System;
using NAudio.Wave;

namespace Playthrough2
{
    internal class WindowsWaveInDevice : IWaveInDevice
    {
        private readonly int _index;
        public string Name => Capabilities.ProductName;
        public Guid Id => WaveDeviceGuidRepository.InputGuids[_index];
        public WaveApi Api => WaveApi.Windows;
        public bool SupportsBufferCount => true;
        public bool SupportsBufferSize => true;

        private WaveInCapabilities Capabilities { get; }

        public WindowsWaveInDevice(int index)
        {
            _index = index;
            Capabilities = WaveIn.GetCapabilities(index);
        }

        public IWaveIn Create(IWavePipeConfiguration config)
        {
            return new WaveIn
            {
                DeviceNumber = _index,
                BufferMilliseconds = config.InputBufferLength ?? 50,
                NumberOfBuffers = config.InputBufferCount ?? 3
            };
        }

        public override string ToString()
        {
            return $"{Name} [Wave]";
        }
    }
}
