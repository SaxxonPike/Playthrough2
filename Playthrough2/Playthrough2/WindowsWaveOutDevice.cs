using NAudio.Wave;

namespace Playthrough2
{
    public class WindowsWaveOutDevice : IWaveOutDevice
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

        public override string ToString()
        {
            return $"[WIN{Index:D2}] {Capabilities.ProductName}";
        }
    }
}
