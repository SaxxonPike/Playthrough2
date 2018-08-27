# Playthrough2

An audio passthrough tool.

[Get the latest installer on the Releases tab](https://github.com/SaxxonPike/Playthrough2/releases).

### Features

- Route audio from any input to any output.
- Customizable buffer and latency settings.
- Minimizes to the notification area.
- Multithreading support for boosted performance.
- Multiple simultaneous routes are supported.

### Supported Operating Systems

Any Windows platform you can install .NET 4.6.1 on. It's been tested on
Windows 10 x64, but I imagine it will work on other operating systems.

Because NAudio hooks into the Windows API quite deep in order to access
the audio hardware, the chances of getting this running on any other
operating system are slim to none, unfortunately.

### Supported I/O

- WaveIn/WaveOut (input and output)
- DirectSound (output only)
- ASIO (input and output)

### Development

Pull code, open in Visual Studio 2017 or Jetbrains Rider, build.
Targets .NET Framework 4.6.1.

The solution also contains an installer project. You may need to download
the [installer extensions found here](https://visualstudiogallery.msdn.microsoft.com/f1cc3f3e-c300-40a7-8797-c509fb8933b9)
if you want to build the MSI. This is the process used to make releases.

### Libraries

This project would not be possible without these wonderful NuGet packages:

- [NAudio](https://github.com/naudio/NAudio) for audio routing
- [Json.NET](http://www.newtonsoft.com/json) for configuration serialization support
