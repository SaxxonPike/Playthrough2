using System;
using System.Collections.Generic;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public class WindowsWaveOutDevice : IWaveOutDevice
    {
        public string Name => _capabilities.ProductName;

        private readonly WaveOutCapabilities _capabilities;
        private readonly WindowsWaveOutSource _source;

        public Guid Id { get; } = Guid.NewGuid();
        public bool SupportsBufferCount => true;
        public bool SupportsBufferSize => true;
        public bool SupportsFormat => false;
        public bool SupportsThread => true;

        public IEnumerable<IWaveOutSource> GetSources()
        {
            yield return _source;
        }

        public WindowsWaveOutDevice(int index)
        {
            _capabilities = WaveOut.GetCapabilities(index);
            _source = new WindowsWaveOutSource(this, index);
        }

        public override string ToString()
        {
            return $"Wave: {Name}";
        }
    }
}