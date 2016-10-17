namespace Playthrough2
{
    public interface IWavePipeDeviceInfo
    {
        WaveInDevice WaveInDevice { get; }
        WaveOutDevice WaveOutDevice { get; }
    }
}