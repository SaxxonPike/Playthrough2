using System;
using NAudio.Wave;
using NAudio.Wave.Asio;
using NAudio.Wave.SampleProviders;
using Playthrough2.Adapters;

namespace Playthrough2.Devices
{
    public class AsioWaveInWrapper : IWaveIn
    {
        private readonly AsioOut _asioOut;
        private WaveFormat _waveFormat;
        private BufferedFloatSampleProvider _sampleProvider;
        private byte[] _buffer;

        public AsioWaveInWrapper(AsioOut asioOut)
        {
            _asioOut = asioOut;
            _asioOut.AudioAvailable += OnAudioAvailable;
        }

        private AsioChannelInfo ChannelInfo =>
            AsioDriver.GetAsioDriverByName(_asioOut.DriverName).GetChannelInfo(_asioOut.ChannelOffset, true);

        private void OnAudioAvailable(object sender, AsioAudioAvailableEventArgs e)
        {
            var size = e.SamplesPerBuffer;
            if (size > _buffer.Length)
                _buffer = new byte[_buffer.Length];

            DataAvailable?.Invoke(this, new WaveInEventArgs());
        }

        public void Dispose()
        {
            _asioOut?.Dispose();
        }

        public void StartRecording()
        {
            _asioOut?.InitRecordAndPlayback(null, 2, _waveFormat.SampleRate);
        }

        public void StopRecording()
        {
            _asioOut?.Stop();
        }

        public WaveFormat WaveFormat
        {
            get
            {
                var info = ChannelInfo;
                switch (info.type)
                {
                    case AsioSampleType.Float32LSB:
                        return WaveFormat.CreateIeeeFloatWaveFormat(_waveFormat.SampleRate, 2);
                    case AsioSampleType.Int16LSB:
                        return new WaveFormat(_waveFormat.SampleRate, 2);
                    default:
                        throw new Exception("Unknown wave format?");
                }
            }
            set => _waveFormat = value;
        }
        
        public event EventHandler<WaveInEventArgs> DataAvailable;
        
        public event EventHandler<StoppedEventArgs> RecordingStopped;
    }
}