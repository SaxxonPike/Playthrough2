using NAudio.Wave;

namespace Playthrough2
{
    public class WaveOutDevice
    {
        public int Index { get; }
        public WaveOutCapabilities Capabilities { get; }

        public WaveOutDevice(int index)
        {
            Index = index;
            Capabilities = WaveOut.GetCapabilities(index);
        }

        public override string ToString()
        {
            return $"[{Index:D2}] {Capabilities.ProductName}";
        }
    }
}
