using System;

namespace Playthrough2
{
    internal interface IWavePipe : IDisposable
    {
        void Start();
        void Stop();
        bool Running { get; }
    }
}