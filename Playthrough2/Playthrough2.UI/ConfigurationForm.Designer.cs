namespace Playthrough2.UI
{
    partial class ConfigurationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.routesTabPage = new System.Windows.Forms.TabPage();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.routeList = new System.Windows.Forms.ListBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.inputFormatPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inputFormatChLabel = new System.Windows.Forms.Label();
            this.inputFormatEnable = new System.Windows.Forms.CheckBox();
            this.inputFormatFrequency = new System.Windows.Forms.TextBox();
            this.inputFormatHzLabel = new System.Windows.Forms.Label();
            this.inputFormatChannels = new System.Windows.Forms.TextBox();
            this.inputDeviceBufferCountPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inputBufferCountValueLabel = new System.Windows.Forms.Label();
            this.inputBufferCountLabel = new System.Windows.Forms.Label();
            this.inputBufferCountSlider = new System.Windows.Forms.TrackBar();
            this.inputDeviceBufferSizePanel = new System.Windows.Forms.TableLayoutPanel();
            this.inputBufferSizeValueLabel = new System.Windows.Forms.Label();
            this.inputBufferSizeLabel = new System.Windows.Forms.Label();
            this.inputBufferSizeSlider = new System.Windows.Forms.TrackBar();
            this.inputDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputDeviceBufferSizePanel = new System.Windows.Forms.TableLayoutPanel();
            this.outputLatencySlider = new System.Windows.Forms.TrackBar();
            this.outputLatencyValueLabel = new System.Windows.Forms.Label();
            this.outputTargetLatencyLabel = new System.Windows.Forms.Label();
            this.outputDeviceBufferCountPanel = new System.Windows.Forms.TableLayoutPanel();
            this.outputBufferCountSlider = new System.Windows.Forms.TrackBar();
            this.outputBufferCountValueLabel = new System.Windows.Forms.Label();
            this.outputBufferCountLabel = new System.Windows.Forms.Label();
            this.outputDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.configurationTabPage = new System.Windows.Forms.TabPage();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.discardDataCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundThreadCheckBox = new System.Windows.Forms.CheckBox();
            this.devicesTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deviceInfoTreeView = new System.Windows.Forms.TreeView();
            this.deviceInfoTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.routesTabPage.SuspendLayout();
            this.actionsGroupBox.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.inputFormatPanel.SuspendLayout();
            this.inputDeviceBufferCountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputBufferCountSlider)).BeginInit();
            this.inputDeviceBufferSizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputBufferSizeSlider)).BeginInit();
            this.outputGroupBox.SuspendLayout();
            this.outputDeviceBufferSizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputLatencySlider)).BeginInit();
            this.outputDeviceBufferCountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputBufferCountSlider)).BeginInit();
            this.configurationTabPage.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.devicesTabPage.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.routesTabPage);
            this.tabControl1.Controls.Add(this.configurationTabPage);
            this.tabControl1.Controls.Add(this.devicesTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(414, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // routesTabPage
            // 
            this.routesTabPage.Controls.Add(this.actionsGroupBox);
            this.routesTabPage.Controls.Add(this.inputGroupBox);
            this.routesTabPage.Controls.Add(this.outputGroupBox);
            this.routesTabPage.Location = new System.Drawing.Point(4, 25);
            this.routesTabPage.Name = "routesTabPage";
            this.routesTabPage.Size = new System.Drawing.Size(406, 302);
            this.routesTabPage.TabIndex = 0;
            this.routesTabPage.Text = "Routing";
            this.routesTabPage.UseVisualStyleBackColor = true;
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Controls.Add(this.clearButton);
            this.actionsGroupBox.Controls.Add(this.routeList);
            this.actionsGroupBox.Controls.Add(this.stopButton);
            this.actionsGroupBox.Controls.Add(this.startButton);
            this.actionsGroupBox.Location = new System.Drawing.Point(0, 195);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(406, 107);
            this.actionsGroupBox.TabIndex = 7;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "Active &Routes";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(303, 77);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "&Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // routeList
            // 
            this.routeList.FormattingEnabled = true;
            this.routeList.IntegralHeight = false;
            this.routeList.Location = new System.Drawing.Point(6, 19);
            this.routeList.Name = "routeList";
            this.routeList.Size = new System.Drawing.Size(291, 81);
            this.routeList.TabIndex = 0;
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(303, 48);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(97, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "S&top";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(303, 19);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(97, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "&Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.inputFormatPanel);
            this.inputGroupBox.Controls.Add(this.inputDeviceBufferCountPanel);
            this.inputGroupBox.Controls.Add(this.inputDeviceBufferSizePanel);
            this.inputGroupBox.Controls.Add(this.inputDeviceComboBox);
            this.inputGroupBox.Location = new System.Drawing.Point(0, 0);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(200, 189);
            this.inputGroupBox.TabIndex = 4;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "&Input";
            // 
            // inputFormatPanel
            // 
            this.inputFormatPanel.ColumnCount = 5;
            this.inputFormatPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inputFormatPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.inputFormatPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inputFormatPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.inputFormatPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inputFormatPanel.Controls.Add(this.inputFormatChLabel, 4, 0);
            this.inputFormatPanel.Controls.Add(this.inputFormatEnable, 0, 0);
            this.inputFormatPanel.Controls.Add(this.inputFormatFrequency, 1, 0);
            this.inputFormatPanel.Controls.Add(this.inputFormatHzLabel, 2, 0);
            this.inputFormatPanel.Controls.Add(this.inputFormatChannels, 3, 0);
            this.inputFormatPanel.Location = new System.Drawing.Point(6, 46);
            this.inputFormatPanel.Name = "inputFormatPanel";
            this.inputFormatPanel.RowCount = 1;
            this.inputFormatPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputFormatPanel.Size = new System.Drawing.Size(188, 26);
            this.inputFormatPanel.TabIndex = 1;
            // 
            // inputFormatChLabel
            // 
            this.inputFormatChLabel.AutoSize = true;
            this.inputFormatChLabel.Location = new System.Drawing.Point(141, 8);
            this.inputFormatChLabel.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.inputFormatChLabel.Name = "inputFormatChLabel";
            this.inputFormatChLabel.Size = new System.Drawing.Size(46, 13);
            this.inputFormatChLabel.TabIndex = 5;
            this.inputFormatChLabel.Text = "Channel";
            // 
            // inputFormatEnable
            // 
            this.inputFormatEnable.AutoSize = true;
            this.inputFormatEnable.Checked = true;
            this.inputFormatEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inputFormatEnable.Location = new System.Drawing.Point(3, 3);
            this.inputFormatEnable.Name = "inputFormatEnable";
            this.inputFormatEnable.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.inputFormatEnable.Size = new System.Drawing.Size(15, 19);
            this.inputFormatEnable.TabIndex = 0;
            this.toolTip.SetToolTip(this.inputFormatEnable, "If checked, override the default sampling rate.");
            this.inputFormatEnable.UseVisualStyleBackColor = true;
            // 
            // inputFormatFrequency
            // 
            this.inputFormatFrequency.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputFormatFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFormatFrequency.Location = new System.Drawing.Point(24, 3);
            this.inputFormatFrequency.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.inputFormatFrequency.Name = "inputFormatFrequency";
            this.inputFormatFrequency.Size = new System.Drawing.Size(62, 21);
            this.inputFormatFrequency.TabIndex = 1;
            this.inputFormatFrequency.Text = "44100";
            this.inputFormatFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.inputFormatFrequency, "Frequency (in Hz) at which to record. Common values are 44100 and 48000.");
            // 
            // inputFormatHzLabel
            // 
            this.inputFormatHzLabel.AutoSize = true;
            this.inputFormatHzLabel.Location = new System.Drawing.Point(86, 8);
            this.inputFormatHzLabel.Margin = new System.Windows.Forms.Padding(0, 8, 3, 0);
            this.inputFormatHzLabel.Name = "inputFormatHzLabel";
            this.inputFormatHzLabel.Size = new System.Drawing.Size(20, 13);
            this.inputFormatHzLabel.TabIndex = 3;
            this.inputFormatHzLabel.Text = "Hz";
            // 
            // inputFormatChannels
            // 
            this.inputFormatChannels.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputFormatChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFormatChannels.Location = new System.Drawing.Point(112, 3);
            this.inputFormatChannels.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.inputFormatChannels.Name = "inputFormatChannels";
            this.inputFormatChannels.Size = new System.Drawing.Size(29, 21);
            this.inputFormatChannels.TabIndex = 2;
            this.inputFormatChannels.Text = "2";
            this.inputFormatChannels.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.inputFormatChannels, "Number of channels to record. Use 1 for mono or 2 for stereo.");
            // 
            // inputDeviceBufferCountPanel
            // 
            this.inputDeviceBufferCountPanel.ColumnCount = 2;
            this.inputDeviceBufferCountPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputDeviceBufferCountPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputDeviceBufferCountPanel.Controls.Add(this.inputBufferCountValueLabel, 1, 0);
            this.inputDeviceBufferCountPanel.Controls.Add(this.inputBufferCountLabel, 0, 0);
            this.inputDeviceBufferCountPanel.Controls.Add(this.inputBufferCountSlider, 0, 1);
            this.inputDeviceBufferCountPanel.Location = new System.Drawing.Point(6, 132);
            this.inputDeviceBufferCountPanel.Name = "inputDeviceBufferCountPanel";
            this.inputDeviceBufferCountPanel.RowCount = 2;
            this.inputDeviceBufferCountPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputDeviceBufferCountPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputDeviceBufferCountPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputDeviceBufferCountPanel.Size = new System.Drawing.Size(188, 48);
            this.inputDeviceBufferCountPanel.TabIndex = 3;
            // 
            // inputBufferCountValueLabel
            // 
            this.inputBufferCountValueLabel.AutoSize = true;
            this.inputBufferCountValueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.inputBufferCountValueLabel.Location = new System.Drawing.Point(172, 0);
            this.inputBufferCountValueLabel.Name = "inputBufferCountValueLabel";
            this.inputBufferCountValueLabel.Size = new System.Drawing.Size(13, 13);
            this.inputBufferCountValueLabel.TabIndex = 11;
            this.inputBufferCountValueLabel.Text = "0";
            // 
            // inputBufferCountLabel
            // 
            this.inputBufferCountLabel.AutoSize = true;
            this.inputBufferCountLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputBufferCountLabel.Location = new System.Drawing.Point(3, 0);
            this.inputBufferCountLabel.Name = "inputBufferCountLabel";
            this.inputBufferCountLabel.Size = new System.Drawing.Size(66, 13);
            this.inputBufferCountLabel.TabIndex = 9;
            this.inputBufferCountLabel.Text = "Buffer Count";
            // 
            // inputBufferCountSlider
            // 
            this.inputBufferCountSlider.AutoSize = false;
            this.inputDeviceBufferCountPanel.SetColumnSpan(this.inputBufferCountSlider, 2);
            this.inputBufferCountSlider.LargeChange = 3;
            this.inputBufferCountSlider.Location = new System.Drawing.Point(3, 16);
            this.inputBufferCountSlider.Minimum = 1;
            this.inputBufferCountSlider.Name = "inputBufferCountSlider";
            this.inputBufferCountSlider.Size = new System.Drawing.Size(182, 27);
            this.inputBufferCountSlider.TabIndex = 8;
            this.inputBufferCountSlider.Value = 2;
            // 
            // inputDeviceBufferSizePanel
            // 
            this.inputDeviceBufferSizePanel.ColumnCount = 2;
            this.inputDeviceBufferSizePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputDeviceBufferSizePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputDeviceBufferSizePanel.Controls.Add(this.inputBufferSizeValueLabel, 1, 0);
            this.inputDeviceBufferSizePanel.Controls.Add(this.inputBufferSizeLabel, 0, 0);
            this.inputDeviceBufferSizePanel.Controls.Add(this.inputBufferSizeSlider, 0, 1);
            this.inputDeviceBufferSizePanel.Location = new System.Drawing.Point(6, 78);
            this.inputDeviceBufferSizePanel.Name = "inputDeviceBufferSizePanel";
            this.inputDeviceBufferSizePanel.RowCount = 2;
            this.inputDeviceBufferSizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputDeviceBufferSizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputDeviceBufferSizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputDeviceBufferSizePanel.Size = new System.Drawing.Size(188, 48);
            this.inputDeviceBufferSizePanel.TabIndex = 2;
            // 
            // inputBufferSizeValueLabel
            // 
            this.inputBufferSizeValueLabel.AutoSize = true;
            this.inputBufferSizeValueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.inputBufferSizeValueLabel.Location = new System.Drawing.Point(159, 0);
            this.inputBufferSizeValueLabel.Name = "inputBufferSizeValueLabel";
            this.inputBufferSizeValueLabel.Size = new System.Drawing.Size(26, 13);
            this.inputBufferSizeValueLabel.TabIndex = 11;
            this.inputBufferSizeValueLabel.Text = "0ms";
            // 
            // inputBufferSizeLabel
            // 
            this.inputBufferSizeLabel.AutoSize = true;
            this.inputBufferSizeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputBufferSizeLabel.Location = new System.Drawing.Point(3, 0);
            this.inputBufferSizeLabel.Name = "inputBufferSizeLabel";
            this.inputBufferSizeLabel.Size = new System.Drawing.Size(58, 13);
            this.inputBufferSizeLabel.TabIndex = 9;
            this.inputBufferSizeLabel.Text = "Buffer Size";
            // 
            // inputBufferSizeSlider
            // 
            this.inputBufferSizeSlider.AutoSize = false;
            this.inputDeviceBufferSizePanel.SetColumnSpan(this.inputBufferSizeSlider, 2);
            this.inputBufferSizeSlider.Location = new System.Drawing.Point(3, 16);
            this.inputBufferSizeSlider.Maximum = 300;
            this.inputBufferSizeSlider.Minimum = 1;
            this.inputBufferSizeSlider.Name = "inputBufferSizeSlider";
            this.inputBufferSizeSlider.Size = new System.Drawing.Size(182, 27);
            this.inputBufferSizeSlider.TabIndex = 8;
            this.inputBufferSizeSlider.TickFrequency = 10;
            this.inputBufferSizeSlider.Value = 50;
            // 
            // inputDeviceComboBox
            // 
            this.inputDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDeviceComboBox.DropDownWidth = 300;
            this.inputDeviceComboBox.FormattingEnabled = true;
            this.inputDeviceComboBox.Location = new System.Drawing.Point(6, 19);
            this.inputDeviceComboBox.Name = "inputDeviceComboBox";
            this.inputDeviceComboBox.Size = new System.Drawing.Size(188, 21);
            this.inputDeviceComboBox.Sorted = true;
            this.inputDeviceComboBox.TabIndex = 0;
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outputDeviceBufferSizePanel);
            this.outputGroupBox.Controls.Add(this.outputDeviceBufferCountPanel);
            this.outputGroupBox.Controls.Add(this.outputDeviceComboBox);
            this.outputGroupBox.Location = new System.Drawing.Point(206, 0);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(200, 189);
            this.outputGroupBox.TabIndex = 5;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "&Output";
            // 
            // outputDeviceBufferSizePanel
            // 
            this.outputDeviceBufferSizePanel.ColumnCount = 2;
            this.outputDeviceBufferSizePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.outputDeviceBufferSizePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.outputDeviceBufferSizePanel.Controls.Add(this.outputLatencyValueLabel, 1, 0);
            this.outputDeviceBufferSizePanel.Controls.Add(this.outputTargetLatencyLabel, 0, 0);
            this.outputDeviceBufferSizePanel.Controls.Add(this.outputLatencySlider, 0, 1);
            this.outputDeviceBufferSizePanel.Location = new System.Drawing.Point(6, 78);
            this.outputDeviceBufferSizePanel.Name = "outputDeviceBufferSizePanel";
            this.outputDeviceBufferSizePanel.RowCount = 2;
            this.outputDeviceBufferSizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outputDeviceBufferSizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outputDeviceBufferSizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outputDeviceBufferSizePanel.Size = new System.Drawing.Size(188, 48);
            this.outputDeviceBufferSizePanel.TabIndex = 1;
            // 
            // outputLatencySlider
            // 
            this.outputLatencySlider.AutoSize = false;
            this.outputDeviceBufferSizePanel.SetColumnSpan(this.outputLatencySlider, 2);
            this.outputLatencySlider.Location = new System.Drawing.Point(3, 16);
            this.outputLatencySlider.Maximum = 300;
            this.outputLatencySlider.Minimum = 1;
            this.outputLatencySlider.Name = "outputLatencySlider";
            this.outputLatencySlider.Size = new System.Drawing.Size(182, 27);
            this.outputLatencySlider.TabIndex = 8;
            this.outputLatencySlider.TickFrequency = 10;
            this.outputLatencySlider.Value = 50;
            // 
            // outputLatencyValueLabel
            // 
            this.outputLatencyValueLabel.AutoSize = true;
            this.outputLatencyValueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.outputLatencyValueLabel.Location = new System.Drawing.Point(159, 0);
            this.outputLatencyValueLabel.Name = "outputLatencyValueLabel";
            this.outputLatencyValueLabel.Size = new System.Drawing.Size(26, 13);
            this.outputLatencyValueLabel.TabIndex = 11;
            this.outputLatencyValueLabel.Text = "0ms";
            // 
            // outputTargetLatencyLabel
            // 
            this.outputTargetLatencyLabel.AutoSize = true;
            this.outputTargetLatencyLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.outputTargetLatencyLabel.Location = new System.Drawing.Point(3, 0);
            this.outputTargetLatencyLabel.Name = "outputTargetLatencyLabel";
            this.outputTargetLatencyLabel.Size = new System.Drawing.Size(58, 13);
            this.outputTargetLatencyLabel.TabIndex = 9;
            this.outputTargetLatencyLabel.Text = "Buffer Size";
            // 
            // outputDeviceBufferCountPanel
            // 
            this.outputDeviceBufferCountPanel.ColumnCount = 2;
            this.outputDeviceBufferCountPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.outputDeviceBufferCountPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.outputDeviceBufferCountPanel.Controls.Add(this.outputBufferCountSlider, 0, 1);
            this.outputDeviceBufferCountPanel.Controls.Add(this.outputBufferCountValueLabel, 1, 0);
            this.outputDeviceBufferCountPanel.Controls.Add(this.outputBufferCountLabel, 0, 0);
            this.outputDeviceBufferCountPanel.Location = new System.Drawing.Point(6, 132);
            this.outputDeviceBufferCountPanel.Name = "outputDeviceBufferCountPanel";
            this.outputDeviceBufferCountPanel.RowCount = 2;
            this.outputDeviceBufferCountPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outputDeviceBufferCountPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outputDeviceBufferCountPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outputDeviceBufferCountPanel.Size = new System.Drawing.Size(188, 48);
            this.outputDeviceBufferCountPanel.TabIndex = 2;
            // 
            // outputBufferCountSlider
            // 
            this.outputBufferCountSlider.AutoSize = false;
            this.outputDeviceBufferCountPanel.SetColumnSpan(this.outputBufferCountSlider, 2);
            this.outputBufferCountSlider.LargeChange = 3;
            this.outputBufferCountSlider.Location = new System.Drawing.Point(3, 16);
            this.outputBufferCountSlider.Minimum = 1;
            this.outputBufferCountSlider.Name = "outputBufferCountSlider";
            this.outputBufferCountSlider.Size = new System.Drawing.Size(182, 27);
            this.outputBufferCountSlider.TabIndex = 12;
            this.outputBufferCountSlider.Value = 2;
            // 
            // outputBufferCountValueLabel
            // 
            this.outputBufferCountValueLabel.AutoSize = true;
            this.outputBufferCountValueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.outputBufferCountValueLabel.Location = new System.Drawing.Point(172, 0);
            this.outputBufferCountValueLabel.Name = "outputBufferCountValueLabel";
            this.outputBufferCountValueLabel.Size = new System.Drawing.Size(13, 13);
            this.outputBufferCountValueLabel.TabIndex = 11;
            this.outputBufferCountValueLabel.Text = "0";
            // 
            // outputBufferCountLabel
            // 
            this.outputBufferCountLabel.AutoSize = true;
            this.outputBufferCountLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.outputBufferCountLabel.Location = new System.Drawing.Point(3, 0);
            this.outputBufferCountLabel.Name = "outputBufferCountLabel";
            this.outputBufferCountLabel.Size = new System.Drawing.Size(66, 13);
            this.outputBufferCountLabel.TabIndex = 9;
            this.outputBufferCountLabel.Text = "Buffer Count";
            // 
            // outputDeviceComboBox
            // 
            this.outputDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputDeviceComboBox.DropDownWidth = 300;
            this.outputDeviceComboBox.FormattingEnabled = true;
            this.outputDeviceComboBox.Location = new System.Drawing.Point(6, 19);
            this.outputDeviceComboBox.Name = "outputDeviceComboBox";
            this.outputDeviceComboBox.Size = new System.Drawing.Size(188, 21);
            this.outputDeviceComboBox.Sorted = true;
            this.outputDeviceComboBox.TabIndex = 0;
            // 
            // configurationTabPage
            // 
            this.configurationTabPage.Controls.Add(this.groupBox2);
            this.configurationTabPage.Controls.Add(this.groupBox1);
            this.configurationTabPage.Controls.Add(this.optionsGroupBox);
            this.configurationTabPage.Location = new System.Drawing.Point(4, 25);
            this.configurationTabPage.Name = "configurationTabPage";
            this.configurationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.configurationTabPage.Size = new System.Drawing.Size(406, 302);
            this.configurationTabPage.TabIndex = 1;
            this.configurationTabPage.Text = "Configuration";
            this.configurationTabPage.UseVisualStyleBackColor = true;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.discardDataCheckBox);
            this.optionsGroupBox.Controls.Add(this.backgroundThreadCheckBox);
            this.optionsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(200, 68);
            this.optionsGroupBox.TabIndex = 0;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "&Performance Options";
            // 
            // discardDataCheckBox
            // 
            this.discardDataCheckBox.AutoSize = true;
            this.discardDataCheckBox.Location = new System.Drawing.Point(6, 42);
            this.discardDataCheckBox.Name = "discardDataCheckBox";
            this.discardDataCheckBox.Size = new System.Drawing.Size(148, 17);
            this.discardDataCheckBox.TabIndex = 1;
            this.discardDataCheckBox.Text = "&Discard Data to Catch Up";
            this.toolTip.SetToolTip(this.discardDataCheckBox, "If checked, when output falls behind input, start discarding samples to catch up." +
        "");
            this.discardDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // backgroundThreadCheckBox
            // 
            this.backgroundThreadCheckBox.AutoSize = true;
            this.backgroundThreadCheckBox.Checked = true;
            this.backgroundThreadCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backgroundThreadCheckBox.Location = new System.Drawing.Point(6, 19);
            this.backgroundThreadCheckBox.Name = "backgroundThreadCheckBox";
            this.backgroundThreadCheckBox.Size = new System.Drawing.Size(143, 17);
            this.backgroundThreadCheckBox.TabIndex = 0;
            this.backgroundThreadCheckBox.Text = "Use &Background Thread";
            this.toolTip.SetToolTip(this.backgroundThreadCheckBox, "If checked, record on a background thread. This generally performs better, but is" +
        " less compatible.");
            this.backgroundThreadCheckBox.UseVisualStyleBackColor = true;
            // 
            // devicesTabPage
            // 
            this.devicesTabPage.Controls.Add(this.splitContainer1);
            this.devicesTabPage.Location = new System.Drawing.Point(4, 25);
            this.devicesTabPage.Name = "devicesTabPage";
            this.devicesTabPage.Size = new System.Drawing.Size(406, 302);
            this.devicesTabPage.TabIndex = 2;
            this.devicesTabPage.Text = "Devices";
            this.devicesTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.deviceInfoTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.deviceInfoTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(406, 302);
            this.splitContainer1.SplitterDistance = 135;
            this.splitContainer1.TabIndex = 0;
            // 
            // deviceInfoTreeView
            // 
            this.deviceInfoTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceInfoTreeView.Location = new System.Drawing.Point(0, 0);
            this.deviceInfoTreeView.Name = "deviceInfoTreeView";
            this.deviceInfoTreeView.Size = new System.Drawing.Size(135, 302);
            this.deviceInfoTreeView.TabIndex = 0;
            // 
            // deviceInfoTextBox
            // 
            this.deviceInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceInfoTextBox.Location = new System.Drawing.Point(0, 0);
            this.deviceInfoTextBox.Multiline = true;
            this.deviceInfoTextBox.Name = "deviceInfoTextBox";
            this.deviceInfoTextBox.ReadOnly = true;
            this.deviceInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.deviceInfoTextBox.Size = new System.Drawing.Size(267, 302);
            this.deviceInfoTextBox.TabIndex = 0;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "Passthrough2";
            this.notifyIcon.Visible = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(206, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Local Folder Configuration";
            this.groupBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(0, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "&User Profile Configuration (Primary)";
            this.groupBox2.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Load";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 337);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConfigurationForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInTaskbar = false;
            this.Text = "Passthrough2";
            this.tabControl1.ResumeLayout(false);
            this.routesTabPage.ResumeLayout(false);
            this.actionsGroupBox.ResumeLayout(false);
            this.inputGroupBox.ResumeLayout(false);
            this.inputFormatPanel.ResumeLayout(false);
            this.inputFormatPanel.PerformLayout();
            this.inputDeviceBufferCountPanel.ResumeLayout(false);
            this.inputDeviceBufferCountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputBufferCountSlider)).EndInit();
            this.inputDeviceBufferSizePanel.ResumeLayout(false);
            this.inputDeviceBufferSizePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputBufferSizeSlider)).EndInit();
            this.outputGroupBox.ResumeLayout(false);
            this.outputDeviceBufferSizePanel.ResumeLayout(false);
            this.outputDeviceBufferSizePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputLatencySlider)).EndInit();
            this.outputDeviceBufferCountPanel.ResumeLayout(false);
            this.outputDeviceBufferCountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputBufferCountSlider)).EndInit();
            this.configurationTabPage.ResumeLayout(false);
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.devicesTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage routesTabPage;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox routeList;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TableLayoutPanel inputFormatPanel;
        private System.Windows.Forms.Label inputFormatChLabel;
        private System.Windows.Forms.CheckBox inputFormatEnable;
        private System.Windows.Forms.TextBox inputFormatFrequency;
        private System.Windows.Forms.Label inputFormatHzLabel;
        private System.Windows.Forms.TextBox inputFormatChannels;
        private System.Windows.Forms.TableLayoutPanel inputDeviceBufferCountPanel;
        private System.Windows.Forms.Label inputBufferCountValueLabel;
        private System.Windows.Forms.Label inputBufferCountLabel;
        private System.Windows.Forms.TrackBar inputBufferCountSlider;
        private System.Windows.Forms.TableLayoutPanel inputDeviceBufferSizePanel;
        private System.Windows.Forms.Label inputBufferSizeValueLabel;
        private System.Windows.Forms.Label inputBufferSizeLabel;
        private System.Windows.Forms.TrackBar inputBufferSizeSlider;
        private System.Windows.Forms.ComboBox inputDeviceComboBox;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.TableLayoutPanel outputDeviceBufferSizePanel;
        private System.Windows.Forms.Label outputLatencyValueLabel;
        private System.Windows.Forms.Label outputTargetLatencyLabel;
        private System.Windows.Forms.TrackBar outputLatencySlider;
        private System.Windows.Forms.TableLayoutPanel outputDeviceBufferCountPanel;
        private System.Windows.Forms.TrackBar outputBufferCountSlider;
        private System.Windows.Forms.Label outputBufferCountValueLabel;
        private System.Windows.Forms.Label outputBufferCountLabel;
        private System.Windows.Forms.ComboBox outputDeviceComboBox;
        private System.Windows.Forms.TabPage configurationTabPage;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.CheckBox discardDataCheckBox;
        private System.Windows.Forms.CheckBox backgroundThreadCheckBox;
        private System.Windows.Forms.TabPage devicesTabPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView deviceInfoTreeView;
        private System.Windows.Forms.TextBox deviceInfoTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

