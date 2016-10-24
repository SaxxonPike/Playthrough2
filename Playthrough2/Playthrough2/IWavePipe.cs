using System;

namespace Playthrough2
{
    public interface IWavePipe : IDisposable
    {
        void Start();
        void Stop();
        bool Running { get; }
    }
}