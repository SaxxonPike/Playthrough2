using System;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public class DirectSoundWaveOutSource : IWaveOutSource
    {
        private readonly Guid _guid;

        public DirectSoundWaveOutSource(IWaveOutDevice dsWaveOutDevice, Guid guid)
        {
            _guid = guid;
            Device = dsWaveOutDevice;
        }

        public string Name => "Default";
        public Guid Id { get; } = Guid.NewGuid();
        public bool SupportsBufferCount => false;
        public bool SupportsBufferSize => true;
        public bool SupportsFormat => false;
        public bool SupportsThread => true;
        
        public IWavePlayer Open(IWavePipeConfiguration config)
        {
            return new DirectSoundOut(_guid, config.OutputLatency ?? 40);
        }

        public IWaveOutDevice Device { get; }

        public override string ToString() => Name;
    }
}