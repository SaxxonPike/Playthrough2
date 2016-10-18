﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Playthrough2
{
    public class WavePipeManager : IDisposable
    {
        private readonly IList<IWavePipeInfo> _pipes = new List<IWavePipeInfo>();

        private IWavePipeInfo GetExistingPipe(IWavePipeDeviceInfo wavePipeConfiguration)
        {
            return _pipes.FirstOrDefault(p => 
                p.WaveInDevice.Index == wavePipeConfiguration.WaveInDevice.Index &&
                p.WaveInDevice.Api == wavePipeConfiguration.WaveInDevice.Api &&
                p.WaveOutDevice.Index == wavePipeConfiguration.WaveOutDevice.Index &&
                p.WaveOutDevice.Api == wavePipeConfiguration.WaveOutDevice.Api);
        }

        public void Start(IWavePipeConfiguration wavePipeConfiguration)
        {
            var existingPipe = GetExistingPipe(wavePipeConfiguration);
            if (existingPipe != null)
                return;

            var newPipe = new WavePipeInfo(wavePipeConfiguration);
            _pipes.Add(newPipe);
            newPipe.Start();
        }

        public void Stop(IWavePipeDeviceInfo wavePipeDeviceInfo)
        {
            var existingPipe = GetExistingPipe(wavePipeDeviceInfo);
            if (existingPipe == null)
                return;

            existingPipe.Stop();
            _pipes.Remove(existingPipe);
            existingPipe.Dispose();
        }

        public IEnumerable<IWavePipeInfo> Pipes => _pipes;

        public void Dispose()
        {
            foreach (var pipe in _pipes)
                pipe.Dispose();
        }
    }
}
