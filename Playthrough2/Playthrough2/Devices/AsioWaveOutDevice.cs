using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public class AsioWaveOutDevice : IWaveOutDevice
    {
        private readonly IEnumerable<IWaveOutSource> _sources;

        public AsioWaveOutDevice(string device)
        {
            Name = device;
            _sources = InitSources(device);
        }

        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; }

        public IEnumerable<IWaveOutSource> GetSources()
        {
            return _sources;
        }

        private IEnumerable<IWaveOutSource> InitSources(string device)
        {
            try
            {
                using (var driver = new AsioOut(device))
                    return new ReadOnlyCollection<IWaveOutSource>(Enumerable
                        .Range(0, driver.DriverOutputChannelCount)
                        .Select(i => new AsioWaveOutSource(this, i, driver.AsioOutputChannelName(i)))
                        .Cast<IWaveOutSource>()
                        .ToList());
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return Enumerable.Empty<IWaveOutSource>();
            }            
        }

        public override string ToString() => $"Asio: {Name}";
    }
}