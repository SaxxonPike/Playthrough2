namespace Playthrough2
{
    public interface IWavePipeDeviceInfo
    {
        IWaveInDevice WaveInDevice { get; }
        IWaveOutDevice WaveOutDevice { get; }
        int InputSource { get; }
        int OutputSource { get; }
    }
}