using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Playthrough2.Pipes;

namespace Playthrough2.UI
{
    public class ConfigurationRepository
    {
        public string ConfigurationFileName { get; } = $"{Application.ProductName}.json";

        private string GetUserProfileFileName()
        {
            var basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName);
            return Path.Combine(basePath, ConfigurationFileName);
        }

        private string GetLocalConfigurationFileName()
        {
            return Path.Combine(Application.ExecutablePath, ConfigurationFileName);
        }

        private IWavePipeConfiguration LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                return null;

            var fileData = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<WavePipeConfiguration>(fileData);
        }

        public IWavePipeConfiguration LoadFromUserProfile()
        {
            try
            {
                return LoadFromFile(GetUserProfileFileName());
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IWavePipeConfiguration LoadFromLocalFile()
        {
            try
            {
                return LoadFromFile(GetLocalConfigurationFileName());
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IWavePipeConfiguration LoadCombined()
        {
            var baseConfiguration = LoadFromUserProfile();
            var localConfiguration = LoadFromLocalFile();

            return new WavePipeConfiguration
            {
                DiscardSamplesIfLagging = localConfiguration?.DiscardSamplesIfLagging ?? baseConfiguration?.DiscardSamplesIfLagging ?? false,
                InputBufferCount = localConfiguration?.InputBufferCount ?? baseConfiguration?.InputBufferCount,
                InputBufferLength = localConfiguration?.InputBufferLength ?? baseConfiguration?.InputBufferLength,
                InputFormat = localConfiguration?.InputFormat ?? baseConfiguration?.InputFormat,
                OutputBufferCount = localConfiguration?.OutputBufferCount ?? baseConfiguration?.OutputBufferCount,
                OutputFormat = localConfiguration?.OutputFormat ?? baseConfiguration?.OutputFormat,
                OutputLatency = localConfiguration?.OutputLatency ?? baseConfiguration?.OutputLatency,
                UseBackgroundThread = localConfiguration?.UseBackgroundThread ?? baseConfiguration?.UseBackgroundThread ?? false
            };
        }

        private void SaveToFile(string fileName, IWavePipeConfiguration configuration)
        {
            var data = JsonConvert.SerializeObject(configuration, Formatting.Indented);
            File.WriteAllText(fileName, data);
        }

        public void SaveToUserProfile(IWavePipeConfiguration configuration)
        {
            SaveToFile(GetUserProfileFileName(), configuration);
        }

        public void SaveToLocalFile(IWavePipeConfiguration configuration)
        {
            SaveToFile(GetLocalConfigurationFileName(), configuration);
        }
    }
}
