using System;
using System.Collections.Generic;
using NAudio.Wave;

namespace Playthrough2.Adapters
{
    public class BufferedFloatSampleProvider : ISampleProvider
    {
        public BufferedFloatSampleProvider(WaveFormat waveFormat)
        {
            WaveFormat = waveFormat;
        }
        
        private readonly List<float> _buffer = new List<float>();
        
        public int Read(float[] buffer, int offset, int count)
        {
            var length = Math.Min(_buffer.Count, count);
            var remaining = length;
            var index = 0;
            while (remaining > 0)
            {
                buffer[offset] = _buffer[index];
                index++;
                offset++;
                remaining--;
            }
            _buffer.RemoveRange(0, length);
            return length;
        }

        public void Write(IEnumerable<float> buffer)
        {
            _buffer.AddRange(buffer);
        }

        public WaveFormat WaveFormat { get; }
    }
}