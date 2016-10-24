namespace Playthrough2.Pipes
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
