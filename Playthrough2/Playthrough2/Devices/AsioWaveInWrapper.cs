using System;
using System.Runtime.InteropServices;
using NAudio.Wave;
using NAudio.Wave.Asio;
using NAudio.Wave.SampleProviders;

namespace Playthrough2.Devices
{
    public class AsioWaveInWrapper : IWaveIn
    {
        private readonly AsioOut _asioOut;
        private WaveFormat _waveFormat;
        private float[] _inBuffer;
        private byte[] _outBuffer;

        public AsioWaveInWrapper(AsioOut asioOut)
        {
            _asioOut = asioOut;
            _asioOut.AudioAvailable += OnAudioAvailable;
        }

        private void OnAudioAvailable(object sender, AsioAudioAvailableEventArgs e)
        {
            var size = e.SamplesPerBuffer * e.InputBuffers.Length;
            if (_inBuffer == null || _inBuffer.Length < size)
            {
                _inBuffer = new float[size];
                _outBuffer = new byte[size * 4];
            }
            var samples = e.GetAsInterleavedSamples(_inBuffer);
            Buffer.BlockCopy(_inBuffer, 0, _outBuffer, 0, samples * 4);
            DataAvailable?.Invoke(this, new WaveInEventArgs(_outBuffer, samples * 4));
        }

        public void Dispose()
        {
            _asioOut?.Stop();
        }

        public void StartRecording()
        {
            _asioOut?.InitRecordAndPlayback(null, _waveFormat.Channels, _waveFormat.SampleRate);
            _asioOut?.Play();
        }

        public void StopRecording()
        {
            _asioOut?.Stop();
            RecordingStopped?.Invoke(this, new StoppedEventArgs());
        }

        private static WaveFormat GetWaveFormat(WaveFormat format)
        {
            return WaveFormat.CreateIeeeFloatWaveFormat(format.SampleRate, format.Channels);
        }

        public WaveFormat WaveFormat
        {
            get => _waveFormat;
            set => _waveFormat = GetWaveFormat(value);
        }

        public event EventHandler<WaveInEventArgs> DataAvailable;

        public event EventHandler<StoppedEventArgs> RecordingStopped;
    }
}