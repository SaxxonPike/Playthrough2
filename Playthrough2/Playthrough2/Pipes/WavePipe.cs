﻿using System.Threading;

namespace Playthrough2.Pipes
{
    internal class WavePipe : IWavePipe
    {
        private readonly IWavePipeConfiguration _configuration;
        private readonly WavePipeThreadInfo _threadInfo;

        public WavePipe(IWaveInSource waveIn, IWaveOutSource waveOut, IWavePipeConfiguration configuration)
        {
            _configuration = configuration;
            _threadInfo = new WavePipeThreadInfo(waveIn, waveOut, _configuration);
            var thread = new Thread(WavePipeThreadProc);

            if (!_configuration.IsThreadCompatible)
                _threadInfo.Initialize();
            else
                thread.Priority = ThreadPriority.AboveNormal;

            thread.Start(_threadInfo);
        }

        private void WavePipeThreadProc(object threadInfo)
        {
            var info = (WavePipeThreadInfo)threadInfo;

            if (_configuration.IsThreadCompatible)
                info.Initialize();

            try
            {
                while (true)
                {
                    while (info.CommandQueue.Count > 0)
                    {
                        var command = info.CommandQueue.Dequeue();
                        switch (command.Type)
                        {
                            case WavePipeThreadCommandType.Dispose:
                                return;
                            case WavePipeThreadCommandType.Start:
                                info.Start();
                                break;
                            case WavePipeThreadCommandType.Stop:
                                info.Stop();
                                break;
                        }
                    }
                    Thread.Sleep(1);
                }
            }
            catch (ThreadAbortException)
            {
                // Abort gracefully.
            }
        }

        private void Enqueue(WavePipeThreadCommandType type)
        {
            _threadInfo?.CommandQueue.Enqueue(new WavePipeThreadCommand(type));
        }

        public void Dispose()
        {
            Enqueue(WavePipeThreadCommandType.Dispose);
        }

        public void Start()
        {
            Enqueue(WavePipeThreadCommandType.Start);
        }

        public void Stop()
        {
            Enqueue(WavePipeThreadCommandType.Stop);
        }

        public bool Running => _threadInfo?.Running ?? false;
    }
}
