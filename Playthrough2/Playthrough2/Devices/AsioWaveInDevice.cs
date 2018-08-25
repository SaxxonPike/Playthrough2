using System;
using NAudio.Wave;

namespace Playthrough2.Devices
{
    public class AsioWaveInDevice : IWaveInDevice
    {
        public string Name { get; }
        public Guid Id { get; }
        public WaveApi Api => WaveApi.AsioIn;
        public bool SupportsBufferCount => false;
        public bool SupportsBufferSize => false;
        public bool SupportsFormat => true;
        
        public IWaveIn Create(IWavePipeConfiguration config)
        {
            throw new NotImplementedException();
        }

        public int InputCount
        {
            get
            {
                using (var driver = new AsioOut(Name))
                    return driver.DriverInputChannelCount;
            }
        }
    }
}