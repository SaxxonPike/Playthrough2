using NAudio.Wave;

namespace Playthrough2
{
    public interface IWaveOutDevice
    {
        string Name { get; }
        int Index { get; }
        WaveApi Api { get; }
        IWavePlayer Create(IWavePipeConfiguration config);
    }
}