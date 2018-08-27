using System;
using NAudio.Wave;

namespace Playthrough2.Pipes
{
    internal class WaveInBufferedStreamProvider : IWaveProvider
    {
        private readonly IWaveIn _waveIn;
        private readonly BufferedWaveProvider _bufferedWaveProvider;

        public WaveInBufferedStreamProvider(IWaveIn waveIn, IWavePipeConfiguration configuration)
        {
            _waveIn = waveIn;
            waveIn.DataAvailable += OnWaveInDataAvailable;
            _bufferedWaveProvider = new BufferedWaveProvider(WaveFormat)
            {
                DiscardOnBufferOverflow = configuration.DiscardSamplesIfLagging,
            };

            if (configuration.DiscardSamplesIfLagging && configuration.InputSource.SupportsBufferSize && configuration.OutputSource.SupportsBufferSize)
            {
                var totalInputLatency = (configuration.InputSource.SupportsBufferCount ? configuration.InputBufferCount ?? 1 : 1) * (configuration.InputBufferLength ?? 20);
                var totalOutputLatency = (configuration.OutputSource.SupportsBufferCount ? configuration.OutputBufferCount ?? 1 : 1) * (configuration.OutputLatency ?? 40);
                _bufferedWaveProvider.BufferLength = waveIn.WaveFormat.ConvertLatencyToByteSize(totalInputLatency + totalOutputLatency);
            }
            else
            {
                _bufferedWaveProvider.BufferLength = waveIn.WaveFormat.AverageBytesPerSecond*10;
            }
        }

        private void OnWaveInDataAvailable(object sender, WaveInEventArgs e)
        {
            try
            {
                _bufferedWaveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
            }
            catch (InvalidOperationException)
            {
                // Make the buffer larger in hopes it'll fix the problem. The current buffer is completely lost however.
                _bufferedWaveProvider.BufferLength += _waveIn.WaveFormat.AverageBytesPerSecond;
            }
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            return _bufferedWaveProvider.Read(buffer, 0, count);
        }

        public WaveFormat WaveFormat => _waveIn.WaveFormat;
    }
}
