using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Playthrough2.UI.Properties;

namespace Playthrough2.UI
{
    public partial class ConfigurationForm : Form
    {
        private readonly WavePipeManager _wavePipeManager = new WavePipeManager();
        private readonly WaveDeviceEnumerator _waveDeviceEnumerator = new WaveDeviceEnumerator();

        public ConfigurationForm()
        {
            InitializeComponent();
            SetDefaultValues();

            Shown += OnFirstShown;
            Closed += OnClosed;
            notifyIcon.Click += OnNotifyIconClicked;
        }

        private void OnNotifyIconClicked(object sender, EventArgs e)
        {
            ShowAndBringToFront();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Win32.WM_SHOWME)
                ShowAndBringToFront();
            base.WndProc(ref m);
        }

        private void ShowAndBringToFront()
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;

            var top = TopMost;
            TopMost = true;
            TopMost = top;
        }

        private void SetDefaultValues()
        {
            SetInputBufferSize(20);
            SetInputBufferCount(2);
            SetOutputLatency(50);
            SetOutputBufferCount(3);
        }

        private IWavePipeConfiguration GetConfiguration()
        {
            return new WavePipeConfiguration
            {
                WaveInDevice = inputDeviceComboBox.SelectedItem as IWaveInDevice,
                WaveOutDevice = outputDeviceComboBox.SelectedItem as IWaveOutDevice,
                InputBufferCount = inputBufferCountSlider.Value,
                InputBufferLength = inputBufferSizeSlider.Value,
                OutputBufferCount = outputBufferCountSlider.Value,
                OutputLatency = outputLatencySlider.Value
            };
        }

        private void OnClosed(object sender, EventArgs eventArgs)
        {
            _wavePipeManager.Dispose();
            notifyIcon.Visible = false;
        }

        private void OnFirstShown(object sender, EventArgs e)
        {
            Shown -= OnFirstShown;

            PopulateDevices();

            notifyIcon.Text = Text;
            notifyIcon.Icon = Resources.Logo16.ToIcon();
            notifyIcon.Visible = true;
        }

        private void PopulateDevices()
        {
            inputDeviceComboBox.Items.AddRange(_waveDeviceEnumerator.GetWaveInDevices().Cast<object>().ToArray());
            inputDeviceComboBox.SelectedIndex = inputDeviceComboBox.Items.Count > 0 ? 0 : -1;

            outputDeviceComboBox.Items.AddRange(_waveDeviceEnumerator.GetWaveOutDevices().Cast<object>().ToArray());
            outputDeviceComboBox.SelectedIndex = outputDeviceComboBox.Items.Count > 0 ? 0 : -1;

            inputGroupBox.Enabled = outputGroupBox.Enabled = actionsGroupBox.Enabled =
                inputDeviceComboBox.Items.Count > 0 && outputDeviceComboBox.Items.Count > 0;
        }

        private void OnStartClicked(object sender, EventArgs e)
        {
            if (inputDeviceComboBox.SelectedItem == null || outputDeviceComboBox.SelectedItem == null)
                return;

            _wavePipeManager.Start(GetConfiguration());
        }

        private void OnStopClicked(object sender, EventArgs e)
        {
            if (inputDeviceComboBox.SelectedItem == null || outputDeviceComboBox.SelectedItem == null)
                return;

            _wavePipeManager.Stop(GetConfiguration());
        }

        private void SetTrackbarValue(TrackBar trackBar, Control valueLabel, int value, string format)
        {
            SuspendLayout();
            valueLabel.Text = string.Format(format, value);
            if (trackBar.Value != value)
                trackBar.Value = value;
            ResumeLayout();
        }

        private void SetMillisecondValue(TrackBar trackBar, Control valueLabel, int value)
        {
            SetTrackbarValue(trackBar, valueLabel, value, "{0}ms");
        }

        private void SetIntegerValue(TrackBar trackBar, Control valueLabel, int value)
        {
            SetTrackbarValue(trackBar, valueLabel, value, "{0}");
        }

        private void SetInputBufferSize(int value)
        {
            SetMillisecondValue(inputBufferSizeSlider, inputBufferSizeValueLabel, value);
        }

        private void SetInputBufferCount(int value)
        {
            SetIntegerValue(inputBufferCountSlider, inputBufferCountValueLabel, value);
        }

        private void SetOutputBufferCount(int value)
        {
            SetIntegerValue(outputBufferCountSlider, outputBufferCountValueLabel, value);
        }

        private void SetOutputLatency(int value)
        {
            SetMillisecondValue(outputLatencySlider, outputLatencyValueLabel, value);
        }

        private void OnInputBufferSizeScroll(object sender, EventArgs e)
        {
            SetInputBufferSize(inputBufferSizeSlider.Value);
        }

        private void OnInputBufferCountScroll(object sender, EventArgs e)
        {
            SetInputBufferCount(inputBufferCountSlider.Value);
        }

        private void OnOutputBufferCountScroll(object sender, EventArgs e)
        {
            SetOutputBufferCount(outputBufferCountSlider.Value);
        }

        private void OnOutputLatencyScroll(object sender, EventArgs e)
        {
            SetOutputLatency(outputLatencySlider.Value);
        }
    }
}
