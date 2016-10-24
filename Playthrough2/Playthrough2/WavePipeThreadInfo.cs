using System;
using System.Collections.Generic;
using System.Text;
using NAudio.Wave;

namespace Playthrough2
{
    internal class WavePipeThreadInfo
    {
        public WavePipeThreadInfo(IWaveIn waveIn, IWavePlayer waveOut)
        {
            WaveIn = waveIn;
            WaveOut = waveOut;
            Stream = new WaveInProvider(waveIn);
        }

        public WaveInProvider Stream { get; }
        public Queue<WavePipeThreadCommand> CommandQueue { get; } = new Queue<WavePipeThreadCommand>();
        public IWaveIn WaveIn { get; }
        public IWavePlayer WaveOut { get; }

        public void Start()
        {
            if (Running)
                return;

            Running = true;
            WaveIn.StartRecording();
            WaveOut.Init(Stream);
            WaveOut.Play();
        }

        public void Stop()
        {
            if (!Running)
                return;

            WaveIn.StopRecording();
            if (WaveOut.PlaybackState == PlaybackState.Playing)
                WaveOut.Stop();
            Running = false;
        }

        public bool Running { get; private set; }
    }
}
