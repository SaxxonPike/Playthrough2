using NAudio.Wave;

namespace Playthrough2
{
    public class WindowsWaveInDevice : IWaveInDevice
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

        public override string ToString()
        {
            return $"[WIN{Index:D2}] {Capabilities.ProductName}";
        }
    }
}
