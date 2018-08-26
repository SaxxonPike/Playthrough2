using System;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public class WindowsWaveInSource : IWaveInSource
    {
        private readonly int _index;

        public WindowsWaveInSource(IWaveInDevice waveInDevice, int index)
        {
            Device = waveInDevice;
            _index = index;
        }
        
        public string Name => "Default";
        public Guid Id { get; } = Guid.NewGuid();
        
        public IWaveIn Open(IWavePipeConfiguration config)
        {
            IWaveIn result;
            var bufferMilliseconds = config.InputBufferLength ?? 50;
            var numberOfBuffers = config.InputBufferCount ?? 3;

            if (config.IsThreadCompatible)
            {
                result = new WaveInEvent
                {
                    DeviceNumber = _index,
                    BufferMilliseconds = bufferMilliseconds,
                    NumberOfBuffers = numberOfBuffers
                };
            }
            else
            {
                result = new WaveIn
                {
                    DeviceNumber = _index,
                    BufferMilliseconds = bufferMilliseconds,
                    NumberOfBuffers = numberOfBuffers
                };
            }


            if (config.InputFormat != null)
                result.WaveFormat = config.InputFormat;
            return result;
        }

        public IWaveInDevice Device { get; }

        public override string ToString() => Name;
    }
}