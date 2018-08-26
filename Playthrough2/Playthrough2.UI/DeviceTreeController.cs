using System;
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

        public void Populate(IEnumerable<IWaveSource> waveSources)
        {
            var inputNodes = new Dictionary<IWaveInDevice, TreeNode>();
            var outputNodes = new Dictionary<IWaveOutDevice, TreeNode>();

            foreach (var source in waveSources)
            {
                if (source is IWaveInSource wis)
                {
                    if (!inputNodes.ContainsKey(wis.Device))
                        inputNodes[wis.Device] = new TreeNode(wis.Device.ToString()) {Tag = wis.Device};
                    inputNodes[wis.Device].Nodes.Add(new TreeNode(wis.ToString()) {Tag = wis});                    
                }
                else if (source is IWaveOutSource wos)
                {
                    if (!outputNodes.ContainsKey(wos.Device))
                        outputNodes[wos.Device] = new TreeNode(wos.Device.ToString()) {Tag = wos.Device};
                    outputNodes[wos.Device].Nodes.Add(new TreeNode(wos.ToString()) {Tag = wos});                    
                }
            }

            var inputNode = new TreeNode("Input APIs");
            inputNode.Nodes.AddRange(inputNodes.Select(kv => kv.Value).ToArray());
            var outputNode = new TreeNode("Output APIs");
            outputNode.Nodes.AddRange(outputNodes.Select(kv => kv.Value).ToArray());
            _deviceTreeView.Nodes.AddRange(new[] {inputNode, outputNode});
        }

        private static string SerializeToJson(object input)
        {
            try
            {
                return JsonConvert.SerializeObject(input, Formatting.Indented);
            }
            catch (Exception e)
            {
                return JsonConvert.SerializeObject(e, Formatting.Indented);
            }
        }

        private void OnDeviceTreeDeviceClicked(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!(e.Node.Tag is IWaveDevice))
                return;

            var device = (IWaveDevice) e.Node.Tag;
            _deviceTreeInfoTextBox.Text = SerializeToJson(device);
        }
    }
}