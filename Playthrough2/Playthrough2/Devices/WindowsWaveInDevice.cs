using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public class WindowsWaveInDevice : IWaveInDevice
    {
        private readonly ReadOnlyCollection<IWaveInSource> _sources;
        private readonly IWaveInSource _source;

        public Guid Id { get; } = Guid.NewGuid();
        public string Name => Capabilities.ProductName;
        public bool SupportsBufferCount => true;
        public bool SupportsBufferSize => true;
        public bool SupportsFormat => true;
        public bool SupportsThread => true;

        public IEnumerable<IWaveInSource> GetSources()
        {
            yield return _source;
        }

        private WaveInCapabilities Capabilities { get; }

        public WindowsWaveInDevice(int index)
        {
            Capabilities = WaveInEvent.GetCapabilities(index);
            _source = new WindowsWaveInSource(this, index);
        }

        public override string ToString()
        {
            return $"Wave: {Name}";
        }
    }
}
