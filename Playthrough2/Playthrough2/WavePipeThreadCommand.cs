using System;
using System.Collections.Generic;
using System.Text;

namespace Playthrough2
{
    internal class WavePipeThreadCommand
    {
        public WavePipeThreadCommand(WavePipeThreadCommandType type, object data = null)
        {
            Type = type;
            Data = data;
        }

        public WavePipeThreadCommandType Type { get; }
        public object Data { get; }
    }
}
