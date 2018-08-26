using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using NAudio.Wave;
using Playthrough2.Devices;
using Playthrough2.Pipes;
using Playthrough2.UI.Properties;

namespace Playthrough2.UI
{
    public partial class ConfigurationForm : Form
    {
        private readonly WavePipeManager _wavePipeManager = new WavePipeManager();
        private readonly WaveDeviceRepository _waveDeviceRepository = new WaveDeviceRepository();
        private readonly ConfigurationRepository _configurationRepository = new ConfigurationRepository();

        public ConfigurationForm()
        {
            InitializeComponent();
            SetDefaultValues();
            SetHighPriority();

            Shown += OnFirstShown;
            Closed += OnClosed;
            notifyIcon.Click += OnNotifyIconClicked;
        }

        private static void SetHighPriority()
        {
            try
            {
                Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            }
            catch (Exception)
            {
                // Swallow any exceptions here; this is optional functionality.
            }
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

        private int GetClampedValueForTrackBar(TrackBar trackBar, int? value)
        {
            if (value == null)
                return trackBar.Value;
            if (value > trackBar.Maximum)
                return trackBar.Maximum;
            if (value < trackBar.Minimum)
                return trackBar.Minimum;
            return value.Value;
        }

        private void SetConfiguration(IWavePipeConfiguration configuration)
        {
            inputBufferCountSlider.Value = GetClampedValueForTrackBar(inputBufferCountSlider,
                configuration.InputBufferCount);
            inputBufferSizeSlider.Value = GetClampedValueForTrackBar(inputBufferSizeSlider,
                configuration.InputBufferCount);
            outputBufferCountSlider.Value = GetClampedValueForTrackBar(outputBufferCountSlider,
                configuration.OutputBufferCount);
            outputLatencySlider.Value = GetClampedValueForTrackBar(outputLatencySlider,
                configuration.OutputLatency);
            inputFormatFrequency.Text = (configuration.InputFormat?.SampleRate ?? 44100).ToString();
            inputFormatEnable.Checked = configuration.InputFormat == null;
            backgroundThreadCheckBox.Checked = configuration.UseBackgroundThread;
            discardDataCheckBox.Checked = configuration.DiscardSamplesIfLagging;
        }

        private IWavePipeConfiguration GetConfiguration()
        {
            return new WavePipeConfiguration
            {
                InputBufferCount = inputBufferCountSlider.Value,
                InputBufferLength = inputBufferSizeSlider.Value,
                OutputBufferCount = outputBufferCountSlider.Value,
                OutputLatency = outputLatencySlider.Value,
                InputFormat = inputFormatEnable.Checked &&
                              int.TryParse(inputFormatFrequency.Text, out var frequency) &&
                              int.TryParse(inputFormatChannels.Text, out var channels)
                    ? new WaveFormat(frequency, channels)
                    : null,
                UseBackgroundThread = backgroundThreadCheckBox.Checked,
                DiscardSamplesIfLagging = discardDataCheckBox.Checked,
                InputSource = inputSourceComboBox.SelectedItem as IWaveInSource,
                OutputSource = outputSourceComboBox.SelectedItem as IWaveOutSource
            };
        }

        private void OnClosed(object sender, EventArgs eventArgs)
        {
            try
            {
                _wavePipeManager.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(Resources.WavePipeManagerShutdownFailure, ex.Message));
            }
            notifyIcon.Visible = false;
        }

        private void OnFirstShown(object sender, EventArgs e)
        {
            SetFormTitle();

            var icon = Resources.Logo16.ToIcon();

            Shown -= OnFirstShown;

            PopulateDevices();

            notifyIcon.Text = Text;
            notifyIcon.Icon = icon;
            notifyIcon.Visible = true;

            Icon = icon;

            SetupFormEvents();
            SetConfiguration(_configurationRepository.LoadCombined());
        }

        private void SetFormTitle()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            Text = string.Format(Resources.ConfigurationFormTitle, Application.ProductName, version.Major, version.Minor);
        }

        private void SetupFormEvents()
        {
            inputBufferSizeSlider.Scroll += OnInputBufferSizeScroll;
            inputBufferCountSlider.Scroll += OnInputBufferCountScroll;
            inputDeviceComboBox.SelectedIndexChanged += OnInputDeviceChanged;
            inputFormatEnable.CheckedChanged += OnInputFormatEnableChanged;
            outputBufferCountSlider.Scroll += OnOutputBufferCountScroll;
            outputLatencySlider.Scroll += OnOutputLatencyScroll;
            outputDeviceComboBox.SelectedIndexChanged += OnOutputDeviceChanged;
            inputSourceComboBox.SelectedIndexChanged += OnInputSourceChanged;
            outputSourceComboBox.SelectedIndexChanged += OnOutputSourceChanged;

            startButton.Click += OnStartClicked;
            stopButton.Click += OnStopClicked;
            clearButton.Click += OnClearButtonClick;
            routeList.Click += OnRouteListClicked;
            routeList.SelectedIndexChanged += OnRouteListSelectedIndexChanged;
        }

        private void PopulateDevices()
        {
            var waveInDevices = _waveDeviceRepository.GetWaveInDevices().Where(d => d.GetSources().Any()).ToList();
            var waveOutDevices = _waveDeviceRepository.GetWaveOutDevices().Where(d => d.GetSources().Any()).ToList();

            inputDeviceComboBox.Items.AddRange(waveInDevices.Cast<object>().ToArray());
            inputDeviceComboBox.SelectedIndex = inputDeviceComboBox.Items.Count > 0 ? 0 : -1;
            UpdateInputSources();

            outputDeviceComboBox.Items.AddRange(waveOutDevices.Cast<object>().ToArray());
            outputDeviceComboBox.SelectedIndex = outputDeviceComboBox.Items.Count > 0 ? 0 : -1;
            UpdateOutputSources();

            var deviceTreeController = new DeviceTreeController(deviceInfoTreeView, deviceInfoTextBox);
            deviceTreeController.Populate(
                waveInDevices
                    .SelectMany(wid => wid.GetSources())
                    .Concat<IWaveSource>(waveOutDevices.SelectMany(wod => wod.GetSources())));
        }

        private void OnStartClicked(object sender, EventArgs e)
        {
            if (inputDeviceComboBox.SelectedItem == null || outputDeviceComboBox.SelectedItem == null)
                return;

            try
            {
                _wavePipeManager.Start(GetConfiguration());
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(Resources.WavePipeManagerStartFailure, ex.Message));
            }

            UpdateRoutes();
        }

        private void UpdateRoutes()
        {
            var routes = routeList.Items.Cast<IWavePipeInfo>().ToList();
            foreach (var newRoute in _wavePipeManager.Pipes.Except(routes))
                routeList.Items.Add(newRoute);
            foreach (var deadRoute in routes.Except(_wavePipeManager.Pipes))
                routeList.Items.Remove(deadRoute);
            OnDeviceChanged();
        }

        private void OnStopClicked(object sender, EventArgs e)
        {
            if (inputDeviceComboBox.SelectedItem == null || outputDeviceComboBox.SelectedItem == null)
                return;

            try
            {
                _wavePipeManager.Stop(GetConfiguration());
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(Resources.WavePipeManagerStopFailure, ex.Message));
            }
            UpdateRoutes();
        }

        private void SetTrackbarValue(TrackBar trackBar, Control valueLabel, int? value, string format)
        {
            SuspendLayout();
            valueLabel.Text = string.Format(format, value);
            if (value.HasValue && trackBar.Value != value)
                trackBar.Value = value.Value;
            ResumeLayout();
        }

        private void SetMillisecondValue(TrackBar trackBar, Control valueLabel, int? value)
        {
            SetTrackbarValue(trackBar, valueLabel, value, "{0}ms");
        }

        private void SetIntegerValue(TrackBar trackBar, Control valueLabel, int? value)
        {
            SetTrackbarValue(trackBar, valueLabel, value, "{0}");
        }

        private void SetInputBufferSize(int? value)
        {
            SetMillisecondValue(inputBufferSizeSlider, inputBufferSizeValueLabel, value);
        }

        private void SetInputBufferCount(int? value)
        {
            SetIntegerValue(inputBufferCountSlider, inputBufferCountValueLabel, value);
        }

        private void SetOutputBufferCount(int? value)
        {
            SetIntegerValue(outputBufferCountSlider, outputBufferCountValueLabel, value);
        }

        private void SetOutputLatency(int? value)
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

        private void OnRouteListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(routeList.SelectedItem is IWavePipeInfo pipeInfo))
                return;

            SuspendLayout();
            UpdateInterfaceForPipe(pipeInfo);
            ResumeLayout();
        }

        private void UpdateInterfaceForPipe(IWavePipeInfo pipeInfo)
        {
            if (pipeInfo.Configuration.InputSource?.Device?.SupportsBufferSize ?? false)
                SetInputBufferSize(pipeInfo.Configuration.InputBufferLength);
            if (pipeInfo.Configuration.InputSource?.Device?.SupportsBufferCount ?? false)
                SetInputBufferCount(pipeInfo.Configuration.InputBufferCount);
            if (pipeInfo.Configuration.OutputSource?.Device?.SupportsBufferSize ?? false)
                SetOutputLatency(pipeInfo.Configuration.OutputLatency);
            if (pipeInfo.Configuration.OutputSource?.Device?.SupportsBufferCount ?? false)
                SetOutputBufferCount(pipeInfo.Configuration.OutputBufferCount);

            if (inputDeviceComboBox.SelectedItem != pipeInfo.Configuration.InputSource.Device ||
                outputDeviceComboBox.SelectedItem != pipeInfo.Configuration.OutputSource.Device)
            {
                if (inputDeviceComboBox.SelectedItem != pipeInfo.Configuration.InputSource.Device)
                {
                    inputDeviceComboBox.SelectedItem = pipeInfo.Configuration.InputSource.Device;
                    UpdateInputSources();
                    inputSourceComboBox.SelectedItem = pipeInfo.Configuration.InputSource;
                }

                if (outputDeviceComboBox.SelectedItem != pipeInfo.Configuration.OutputSource.Device)
                {
                    outputDeviceComboBox.SelectedItem = pipeInfo.Configuration.OutputSource.Device;
                    UpdateOutputSources();
                    outputSourceComboBox.SelectedItem = pipeInfo.Configuration.OutputSource;
                }
            }
            else
            {
                OnDeviceChanged();
            }
        }

        private void UpdateInputSources()
        {
            inputSourceComboBox.Items.Clear();
            inputSourceComboBox.Items.AddRange(((IWaveInDevice)inputDeviceComboBox.SelectedItem).GetSources().Cast<object>().ToArray());
            var config = GetConfiguration();
            if (config.InputSource == null)
                inputSourceComboBox.SelectedIndex = inputSourceComboBox.Items.Count > 0 ? 0 : -1;
            else
                inputSourceComboBox.SelectedItem = config.InputSource;
        }

        private void UpdateOutputSources()
        {
            outputSourceComboBox.Items.Clear();
            outputSourceComboBox.Items.AddRange(((IWaveOutDevice)outputDeviceComboBox.SelectedItem).GetSources().Cast<object>().ToArray());
            var config = GetConfiguration();
            if (config.OutputSource == null)
                outputSourceComboBox.SelectedIndex = outputSourceComboBox.Items.Count > 0 ? 0 : -1;
            else
                outputSourceComboBox.SelectedItem = config.OutputSource;
        }

        private void OnDeviceChanged()
        {
            var selectedRoute = GetConfiguration();
            var routeExists = _wavePipeManager.ContainsPipeWithDevices(selectedRoute);
            startButton.Text = routeExists ? Resources.StartButtonRestartText : Resources.StartButtonStartText;
            stopButton.Enabled = routeExists;

            inputDeviceBufferSizePanel.Enabled = selectedRoute.InputSource?.Device?.SupportsBufferSize ?? false;
            inputDeviceBufferCountPanel.Enabled = selectedRoute.InputSource?.Device?.SupportsBufferCount ?? false;
            inputFormatPanel.Enabled = selectedRoute.InputSource?.Device?.SupportsFormat ?? false;

            if (selectedRoute.InputFormat != null)
            {
                inputFormatEnable.Checked = true;
                var format = selectedRoute.InputFormat;
                inputFormatFrequency.Text = format.SampleRate.ToString();
                inputFormatChannels.Text = format.Channels.ToString();
            }
            else
            {
                inputFormatEnable.Checked = false;
            }

            outputDeviceBufferSizePanel.Enabled = selectedRoute.OutputSource?.Device?.SupportsBufferSize ?? false;
            outputDeviceBufferCountPanel.Enabled = selectedRoute.OutputSource?.Device?.SupportsBufferCount ?? false;
        }

        private void OnInputDeviceChanged(object sender, EventArgs e)
        {
            UpdateInputSources();
            OnDeviceChanged();
        }

        private void OnOutputDeviceChanged(object sender, EventArgs e)
        {
            UpdateOutputSources();
            OnDeviceChanged();
        }

        private void OnInputFormatEnableChanged(object sender, EventArgs e)
        {
            inputFormatChannels.Enabled = inputFormatFrequency.Enabled = inputFormatEnable.Checked;
        }

        private void OnRouteListClicked(object sender, EventArgs e)
        {
            OnRouteListSelectedIndexChanged(sender, e);
        }

        private void OnClearButtonClick(object sender, EventArgs e)
        {
            foreach (var pipe in _wavePipeManager.Pipes.ToList())
                _wavePipeManager.Stop(pipe.Configuration);
            UpdateRoutes();
        }

        private void OnInputSourceChanged(object sender, EventArgs e)
        {
            OnDeviceChanged();
        }

        private void OnOutputSourceChanged(object sender, EventArgs e)
        {
            OnDeviceChanged();
        }
    }
}
