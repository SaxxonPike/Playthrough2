using NAudio.Wave;

namespace Playthrough2
{
    public interface IWaveInSource : IWaveSource
    {
        IWaveIn Open(IWavePipeConfiguration config);
        IWaveInDevice Device { get; }
    }
}