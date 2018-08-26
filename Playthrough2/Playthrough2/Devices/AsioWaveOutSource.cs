using System;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public class AsioWaveOutSource : IWaveOutSource
    {
        private readonly int _index;

        public AsioWaveOutSource(IWaveOutDevice asioWaveOutDevice, int index, string name)
        {
            Name = name;
            Device = asioWaveOutDevice;
            _index = index;
        }

        public string Name { get; }
        
        public Guid Id { get; } = Guid.NewGuid();
        
        public IWavePlayer Open(IWavePipeConfiguration config)
        {
            return new AsioOut(Device.Name)
            {
                ChannelOffset = _index
            };
        }

        public IWaveOutDevice Device { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}