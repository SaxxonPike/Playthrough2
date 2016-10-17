using NAudio.Wave;

namespace Playthrough2
{
    public interface IWaveInDevice
    {
        string Name { get; }
        int Index { get; }
        WaveApi Api { get; }
    }
}