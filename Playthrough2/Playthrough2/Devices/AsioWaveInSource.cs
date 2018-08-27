using System;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public class AsioWaveInSource : IWaveInSource
    {
        private readonly int _index;

        public AsioWaveInSource(IWaveInDevice asioWaveInDevice, int index, string name)
        {
            _index = index;
            Device = asioWaveInDevice;
            Name = name;
        }

        public string Name { get; }
        public Guid Id { get; } = Guid.NewGuid();
        public bool SupportsBufferCount => false;
        public bool SupportsBufferSize => false;
        public bool SupportsFormat => true;
        public bool SupportsThread => false;

        public IWaveIn Open(IWavePipeConfiguration config)
        {
            return new AsioWaveInWrapper(new AsioOut(Device.Name) {InputChannelOffset = _index})
                {WaveFormat = config.InputFormat};
        }

        public IWaveInDevice Device { get; }

        public override string ToString() => Name;
    }
}