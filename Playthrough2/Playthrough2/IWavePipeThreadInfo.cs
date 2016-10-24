using System.Collections.Generic;
using Playthrough2.Pipes;

namespace Playthrough2
{
    internal interface IWavePipeThreadInfo
    {
        Queue<WavePipeThreadCommand> CommandQueue { get; }
        bool Running { get; }

        void Initialize();
        void Start();
        void Stop();
    }
}