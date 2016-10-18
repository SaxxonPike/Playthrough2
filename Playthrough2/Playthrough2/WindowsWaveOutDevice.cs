using NAudio.Wave;

namespace Playthrough2
{
    internal class WindowsWaveOutDevice : IWaveOutDevice
    {
        public string Name => Capabilities.ProductName;
        public WaveApi Api => WaveApi.Windows;

        public int Index { get; }
        private WaveOutCapabilities Capabilities { get; }

        public WindowsWaveOutDevice(int index)
        {
            Index = index;
            Capabilities = WaveOut.GetCapabilities(index);
        }

        public IWavePlayer Create(IWavePipeConfiguration config)
        {
            return new WaveOut
            {
                DesiredLatency = config.OutputLatency ?? 100,
                DeviceNumber = Index,
                NumberOfBuffers = config.OutputBufferCount ?? 3
            };
        }

        public override string ToString()
        {
            return $"WI:{Name}";
        }
    }
}
