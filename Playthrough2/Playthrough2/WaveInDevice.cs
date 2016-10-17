using NAudio.Wave;

namespace Playthrough2
{
    public class WaveInDevice
    {
        public int Index { get; }
        public WaveInCapabilities Capabilities { get; }

        public WaveInDevice(int index)
        {
            Index = index;
            Capabilities = WaveIn.GetCapabilities(index);
        }

        public override string ToString()
        {
            return $"[{Index:D2}] {Capabilities.ProductName}";
        }
    }
}
