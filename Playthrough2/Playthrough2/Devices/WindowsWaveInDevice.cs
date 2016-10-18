using NAudio.Wave;

namespace Playthrough2
{
    internal class WindowsWaveInDevice : IWaveInDevice
    {
        public string Name => Capabilities.ProductName;
        public WaveApi Api => WaveApi.Windows;

        public int Index { get; }
        private WaveInCapabilities Capabilities { get; }

        public WindowsWaveInDevice(int index)
        {
            Index = index;
            Capabilities = WaveIn.GetCapabilities(index);
        }

        public IWaveIn Create(IWavePipeConfiguration config)
        {
            return new WaveIn
            {
                DeviceNumber = Index,
                BufferMilliseconds = config.InputBufferLength ?? 50,
                NumberOfBuffers = config.InputBufferCount ?? 3
            };
        }

        public override string ToString()
        {
            return $"WI:{Name}";
        }
    }
}
