using System;
using System.Collections.Generic;
using System.Linq;

namespace Playthrough2.Pipes
{
    public class WavePipeManager : IDisposable
    {
        private readonly IList<IWavePipeInfo> _pipes = new List<IWavePipeInfo>();

        private IWavePipeInfo GetExistingPipe(IWavePipeConfiguration wavePipeConfiguration)
        {
            return _pipes.FirstOrDefault(p => 
                p.Configuration.InputSource?.Id == wavePipeConfiguration.InputSource?.Id &&
                p.Configuration.OutputSource?.Id == wavePipeConfiguration.OutputSource?.Id);
        }

        public void Start(IWavePipeConfiguration wavePipeConfiguration)
        {
            var existingPipe = GetExistingPipe(wavePipeConfiguration);
            if (existingPipe != null)
            {
                existingPipe.Reconfigure(wavePipeConfiguration);
                return;
            }

            var newPipe = new WavePipeInfo(wavePipeConfiguration);
            newPipe.Start();
            _pipes.Add(newPipe);
        }

        public void Stop(IWavePipeConfiguration wavePipeDeviceInfo)
        {
            var existingPipe = GetExistingPipe(wavePipeDeviceInfo);
            if (existingPipe == null)
                return;

            existingPipe.Stop();
            _pipes.Remove(existingPipe);
            existingPipe.Dispose();
        }

        public IEnumerable<IWavePipeInfo> Pipes => _pipes;

        public bool ContainsPipeWithDevices(IWavePipeConfiguration wavePipeDeviceInfo)
        {
            return GetExistingPipe(wavePipeDeviceInfo) != null;
        }

        public void Dispose()
        {
            foreach (var pipe in _pipes)
                pipe.Dispose();
        }
    }
}
