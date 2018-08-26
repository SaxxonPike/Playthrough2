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
        
        public IWaveIn Open(IWavePipeConfiguration config)
        {
            throw new NotImplementedException();
        }

        public IWaveInDevice Device { get; }

        public override string ToString() => Name;
    }
}