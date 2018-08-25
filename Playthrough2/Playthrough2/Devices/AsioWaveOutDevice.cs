using System;
using System.Collections.Generic;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public class AsioWaveOutDevice : IWaveOutDevice
    {
        private static readonly Dictionary<string, Guid> Repository = new Dictionary<string, Guid>();

        public AsioWaveOutDevice(string device)
        {
            Name = device;

            if (!Repository.ContainsKey(device))
                Repository[device] = DeviceGuidService.CreateGuid(WaveApi.AsioOut, Repository.Count);
        }

        public string Name { get; }
        public Guid Id => Repository[Name];
        public WaveApi Api => WaveApi.AsioOut;
        public bool SupportsBufferCount => false;
        public bool SupportsBufferSize => true;
        public bool SupportsFormat => false;

        public IWavePlayer Create(IWavePipeConfiguration config)
        {
            return new AsioOut(Name) {ChannelOffset = config.OutputSource};
        }

        public int OutputCount
        {
            get
            {
                using (var driver = new AsioOut(Name))
                    return driver.DriverOutputChannelCount;
            }
        }

        public override string ToString() => $"{Name} [Asio]";
    }
}