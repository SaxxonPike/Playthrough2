namespace Playthrough2
{
    public class WavePipeDeviceInfo : IWavePipeDeviceInfo
    {
        public WaveInDevice WaveInDevice { get; set; }
        public WaveOutDevice WaveOutDevice { get; set; }
    }
}
