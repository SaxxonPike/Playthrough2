using System;

namespace Playthrough2
{
    public interface IWavePipeInfo : IDisposable
    {
        IWavePipeConfiguration Configuration { get; }
        IWaveInDevice WaveInDevice { get; }
        IWaveOutDevice WaveOutDevice { get; }
        void Start();
        void Reconfigure(IWavePipeConfiguration configuration);
        void Stop();
    }
}