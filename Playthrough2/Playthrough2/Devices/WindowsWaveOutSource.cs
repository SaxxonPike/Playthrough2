using System;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public class WindowsWaveOutSource : IWaveOutSource
    {
        private readonly int _index;

        public WindowsWaveOutSource(IWaveOutDevice waveOutDevice, int index)
        {
            _index = index;
            Device = waveOutDevice;
            Id = Guid.NewGuid();
        }

        public string Name => "Default";
        public Guid Id { get; }
        
        public IWavePlayer Open(IWavePipeConfiguration config)
        {
            return new WaveOutEvent
            {
                DesiredLatency = config.OutputLatency ?? 100,
                DeviceNumber = _index,
                NumberOfBuffers = config.OutputBufferCount ?? 3
            };
        }

        public IWaveOutDevice Device { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}