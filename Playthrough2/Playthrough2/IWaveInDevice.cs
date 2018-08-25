using NAudio.Wave;

namespace Playthrough2
{
    public interface IWaveInDevice : IWaveDevice
    {
        IWaveIn Create(IWavePipeConfiguration config);
        int InputCount { get; }
    }
}