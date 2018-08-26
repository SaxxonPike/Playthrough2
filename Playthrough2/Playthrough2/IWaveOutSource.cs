using NAudio.Wave;

namespace Playthrough2
{
    public interface IWaveOutSource : IWaveSource
    {
        IWavePlayer Open(IWavePipeConfiguration config);
        IWaveOutDevice Device { get; }
    }
}