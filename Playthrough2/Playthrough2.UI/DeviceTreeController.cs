using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Playthrough2.Devices;

namespace Playthrough2.UI
{
    public class DeviceTreeController
    {
        private readonly TreeView _deviceTreeView;
        private readonly TextBox _deviceTreeInfoTextBox;

        public DeviceTreeController(TreeView deviceTreeView, TextBox deviceTreeInfoTextBox)
        {
            _deviceTreeView = deviceTreeView;
            _deviceTreeInfoTextBox = deviceTreeInfoTextBox;
            deviceTreeView.NodeMouseClick += OnDeviceTreeDeviceClicked;
        }

        public void Populate(IEnumerable<IWaveInDevice> waveInDevices, IEnumerable<IWaveOutDevice> waveOutDevices)
        {
            var inputNodes = new Dictionary<WaveApi, TreeNode>();
            var outputNodes = new Dictionary<WaveApi, TreeNode>();

            foreach (var device in waveInDevices)
            {
                if (!inputNodes.ContainsKey(device.Api))
                    inputNodes[device.Api] = new TreeNode(device.Api.ToString()) { Tag = device.Api };
                inputNodes[device.Api].Nodes.Add(new TreeNode(device.ToString()) { Tag = device });
            }

            foreach (var device in waveOutDevices)
            {
                if (!outputNodes.ContainsKey(device.Api))
                    outputNodes[device.Api] = new TreeNode(device.Api.ToString()) { Tag = device.Api };
                outputNodes[device.Api].Nodes.Add(new TreeNode(device.ToString()) { Tag = device });
            }

            var inputNode = new TreeNode("Input APIs");
            inputNode.Nodes.AddRange(inputNodes.Select(kv => kv.Value).ToArray());
            var outputNode = new TreeNode("Output APIs");
            outputNode.Nodes.AddRange(outputNodes.Select(kv => kv.Value).ToArray());
            _deviceTreeView.Nodes.AddRange(new[] { inputNode, outputNode });
        }

        private static string SerializeToJson(object input)
        {
            return JsonConvert.SerializeObject(input, Formatting.Indented);
        }

        private void OnDeviceTreeDeviceClicked(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!(e.Node.Tag is IWaveDevice))
                return;

            var device = e.Node.Tag as IWaveDevice;
            _deviceTreeInfoTextBox.Text = SerializeToJson(device);
        }
    }
}
