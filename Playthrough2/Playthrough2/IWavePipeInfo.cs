using System;

namespace Playthrough2
{
    public interface IWavePipeInfo : IDisposable
    {
        IWaveInDevice WaveInDevice { get; }
        IWaveOutDevice WaveOutDevice { get; }
        void Start();
        void Stop();
    }
}