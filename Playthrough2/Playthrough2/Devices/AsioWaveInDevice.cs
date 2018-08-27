using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public class AsioWaveInDevice : IWaveInDevice
    {
        private readonly IEnumerable<IWaveInSource> _sources;
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; }

        public AsioWaveInDevice(string device)
        {
            Name = device;
            _sources = InitSources(device);
        }
        
        public IEnumerable<IWaveInSource> GetSources()
        {
            return _sources;
        }

        private IEnumerable<IWaveInSource> InitSources(string device)
        {
            try
            {
                using (var driver = new AsioOut(device))
                    return new ReadOnlyCollection<IWaveInSource>(Enumerable
                        .Range(0, driver.DriverInputChannelCount)
                        .Select(i => new AsioWaveInSource(this, i, driver.AsioInputChannelName(i)))
                        .Cast<IWaveInSource>()
                        .ToList());
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return Enumerable.Empty<IWaveInSource>();
            }            
        }

        public override string ToString() => $"Asio: {Name}";
    }
}