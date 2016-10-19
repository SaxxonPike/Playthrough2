namespace Playthrough2
{
    public class WavePipeDeviceInfo : IWavePipeDeviceInfo
    {
        public IWaveInDevice WaveInDevice { get; set; }
        public IWaveOutDevice WaveOutDevice { get; set; }
    }
}
