namespace Playthrough2
{
    public interface IWavePipeDeviceInfo
    {
        IWaveInDevice WaveInDevice { get; }
        IWaveOutDevice WaveOutDevice { get; }
    }
}