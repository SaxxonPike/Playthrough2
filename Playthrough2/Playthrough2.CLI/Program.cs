using System;
using Playthrough2.Devices;

namespace Playthrough2.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var deviceEnumerator = new WaveDeviceEnumerator();

            Console.WriteLine("\nInput devices\n");

            foreach (var inputDevice in deviceEnumerator.GetWaveInDevices())
                Console.WriteLine(inputDevice.ToString());

            Console.WriteLine("\nOutput devices\n");

            foreach (var outputDevice in deviceEnumerator.GetWaveOutDevices())
                Console.WriteLine(outputDevice.ToString());
        }
    }
}
