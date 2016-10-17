using NAudio.Wave;

namespace Playthrough2
{
    public interface IWavePipe
    {
        IWaveIn WaveIn { get; }
        IWavePlayer WaveOut { get; }

        void Start();
        void Stop();
        bool Running { get; }
    }
}