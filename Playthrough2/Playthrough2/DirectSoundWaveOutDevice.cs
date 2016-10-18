using System.Linq;
using NAudio.Wave;

namespace Playthrough2
{
    internal class DirectSoundWaveOutDevice : IWaveOutDevice
    {
        private readonly DirectSoundDeviceInfo _device;

        public string Name => _device.Description;
        public int Index { get; }
        public WaveApi Api => WaveApi.DirectSound;

        public DirectSoundWaveOutDevice(int index, DirectSoundDeviceInfo deviceInfo)
        {
            Index = index;
            _device = deviceInfo;
        }

        public IWavePlayer Create(IWavePipeConfiguration config)
        {
            return new DirectSoundOut(_device.Guid, config.OutputLatency ?? 40);
        }

        public override string ToString()
        {
            return $"DS:{Name}";
        }
    }
}
