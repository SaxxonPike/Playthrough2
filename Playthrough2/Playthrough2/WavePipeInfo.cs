using System;
using NAudio.Wave;

namespace Playthrough2
{
    public class WavePipeInfo : IWavePipeInfo
    {
        public WavePipeInfo(IWavePipeConfiguration wavePipeConfiguration)
        {
            WaveInDevice = wavePipeConfiguration.WaveInDevice;
            WaveOutDevice = wavePipeConfiguration.WaveOutDevice;
            WaveIn = new WaveIn();
            WaveOut = new WaveOut();
            WaveIn.DeviceNumber = WaveInDevice.Index;
            WaveOut.DeviceNumber = WaveOutDevice.Index;

            if (wavePipeConfiguration.InputBufferCount.HasValue)
                WaveIn.NumberOfBuffers = wavePipeConfiguration.InputBufferCount.Value;
            if (wavePipeConfiguration.InputBufferLength.HasValue)
                WaveIn.BufferMilliseconds = wavePipeConfiguration.InputBufferLength.Value;
            if (wavePipeConfiguration.OutputBufferCount.HasValue)
                WaveOut.NumberOfBuffers = wavePipeConfiguration.OutputBufferCount.Value;
            if (wavePipeConfiguration.OutputLatency.HasValue)
                WaveOut.DesiredLatency = wavePipeConfiguration.OutputLatency.Value;

            WavePipe = new WavePipe(WaveIn, WaveOut);
        }

        private IWavePipe WavePipe { get; }
        private WaveOut WaveOut { get; }
        private WaveIn WaveIn { get; }
        public IWaveInDevice WaveInDevice { get; }
        public IWaveOutDevice WaveOutDevice { get; }

        public void Start()
        {
            WavePipe.Start();
        }

        public void Stop()
        {
            WavePipe.Stop();
        }

        public void Dispose()
        {
            WaveOut.Stop();
            WaveIn.StopRecording();
            WaveOut.Dispose();
            WaveIn.Dispose();
        }
    }
}
