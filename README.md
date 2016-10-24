# Playthrough2

An audio passthrough tool. Route audio from any input to any output.
Customizable buffer and latency settings.

## Supported I/O

- WaveIn/WaveOut (input and output)
- DirectSound (output only)

## Development

Pull code, open in Visual Studio 2015, build. (It should automatically pull
packages.) Targets .NET Framework 2.0.

The solution also contains an installer project. You may need to download
the [installer extensions found here](https://visualstudiogallery.msdn.microsoft.com/f1cc3f3e-c300-40a7-8797-c509fb8933b9)
if you want to build the MSI. This is the process used to make releases.
