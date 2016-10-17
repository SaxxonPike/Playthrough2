using System;
using System.Collections.Generic;
using System.Linq;

namespace Playthrough2
{
    public class WavePipeManager : IDisposable
    {
        private readonly IList<WavePipeInfo> _pipes = new List<WavePipeInfo>();

        private WavePipeInfo GetExistingPipe(IWavePipeDeviceInfo wavePipeConfiguration)
        {
            return _pipes.FirstOrDefault(p => 
                p.WaveInDevice.Index == wavePipeConfiguration.WaveInDevice.Index &&
                p.WaveOutDevice.Index == wavePipeConfiguration.WaveOutDevice.Index);
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

        public IEnumerable<WavePipeInfo> Pipes => _pipes;

        public void Dispose()
        {
            foreach (var pipe in _pipes)
                pipe.Dispose();
        }
    }
}
