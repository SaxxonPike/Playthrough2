using NAudio.Wave;

namespace Playthrough2
{
    public interface IWaveOutDevice : IWaveDevice
    {
        IWavePlayer Create(IWavePipeConfiguration config);
        int OutputCount { get; }
    }
}