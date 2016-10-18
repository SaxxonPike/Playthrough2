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
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inputBufferCountValueLabel = new System.Windows.Forms.Label();
            this.inputBufferCountLabel = new System.Windows.Forms.Label();
            this.inputBufferCountSlider = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputBufferSizeValueLabel = new System.Windows.Forms.Label();
            this.inputBufferSizeLabel = new System.Windows.Forms.Label();
            this.inputBufferSizeSlider = new System.Windows.Forms.TrackBar();
            this.inputDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.outputLatencyValueLabel = new System.Windows.Forms.Label();
            this.outputTargetLatencyLabel = new System.Windows.Forms.Label();
            this.outputLatencySlider = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.outputBufferCountSlider = new System.Windows.Forms.TrackBar();
            this.outputBufferCountValueLabel = new System.Windows.Forms.Label();
            this.outputBufferCountLabel = new System.Windows.Forms.Label();
            this.outputDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.routeList = new System.Windows.Forms.ListBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.inputGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputBufferCountSlider)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputBufferSizeSlider)).BeginInit();
            this.outputGroupBox.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputLatencySlider)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputBufferCountSlider)).BeginInit();
            this.actionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.inputGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.inputGroupBox.Controls.Add(this.inputDeviceComboBox);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(200, 157);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.inputBufferCountValueLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.inputBufferCountLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.inputBufferCountSlider, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(188, 48);
            this.tableLayoutPanel2.TabIndex = 5;
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
            this.tableLayoutPanel2.SetColumnSpan(this.inputBufferCountSlider, 2);
            this.inputBufferCountSlider.LargeChange = 3;
            this.inputBufferCountSlider.Location = new System.Drawing.Point(3, 16);
            this.inputBufferCountSlider.Minimum = 1;
            this.inputBufferCountSlider.Name = "inputBufferCountSlider";
            this.inputBufferCountSlider.Size = new System.Drawing.Size(182, 27);
            this.inputBufferCountSlider.TabIndex = 8;
            this.inputBufferCountSlider.Value = 2;
            this.inputBufferCountSlider.Scroll += new System.EventHandler(this.OnInputBufferCountScroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.inputBufferSizeValueLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputBufferSizeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputBufferSizeSlider, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(188, 48);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.tableLayoutPanel1.SetColumnSpan(this.inputBufferSizeSlider, 2);
            this.inputBufferSizeSlider.Location = new System.Drawing.Point(3, 16);
            this.inputBufferSizeSlider.Maximum = 300;
            this.inputBufferSizeSlider.Minimum = 1;
            this.inputBufferSizeSlider.Name = "inputBufferSizeSlider";
            this.inputBufferSizeSlider.Size = new System.Drawing.Size(182, 27);
            this.inputBufferSizeSlider.TabIndex = 8;
            this.inputBufferSizeSlider.TickFrequency = 10;
            this.inputBufferSizeSlider.Value = 50;
            this.inputBufferSizeSlider.Scroll += new System.EventHandler(this.OnInputBufferSizeScroll);
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
            this.inputDeviceComboBox.TabIndex = 3;
            this.inputDeviceComboBox.SelectedIndexChanged += new System.EventHandler(this.OnInputDeviceChanged);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.tableLayoutPanel5);
            this.outputGroupBox.Controls.Add(this.tableLayoutPanel4);
            this.outputGroupBox.Controls.Add(this.outputDeviceComboBox);
            this.outputGroupBox.Location = new System.Drawing.Point(218, 12);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(200, 157);
            this.outputGroupBox.TabIndex = 1;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.outputLatencyValueLabel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.outputTargetLatencyLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.outputLatencySlider, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 46);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(188, 48);
            this.tableLayoutPanel5.TabIndex = 7;
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
            this.outputTargetLatencyLabel.Size = new System.Drawing.Size(45, 13);
            this.outputTargetLatencyLabel.TabIndex = 9;
            this.outputTargetLatencyLabel.Text = "Latency";
            // 
            // outputLatencySlider
            // 
            this.outputLatencySlider.AutoSize = false;
            this.tableLayoutPanel5.SetColumnSpan(this.outputLatencySlider, 2);
            this.outputLatencySlider.Location = new System.Drawing.Point(3, 16);
            this.outputLatencySlider.Maximum = 300;
            this.outputLatencySlider.Minimum = 1;
            this.outputLatencySlider.Name = "outputLatencySlider";
            this.outputLatencySlider.Size = new System.Drawing.Size(182, 27);
            this.outputLatencySlider.TabIndex = 8;
            this.outputLatencySlider.TickFrequency = 10;
            this.outputLatencySlider.Value = 50;
            this.outputLatencySlider.Scroll += new System.EventHandler(this.OnOutputLatencyScroll);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.outputBufferCountSlider, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.outputBufferCountValueLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.outputBufferCountLabel, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 100);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(188, 48);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // outputBufferCountSlider
            // 
            this.outputBufferCountSlider.AutoSize = false;
            this.tableLayoutPanel4.SetColumnSpan(this.outputBufferCountSlider, 2);
            this.outputBufferCountSlider.LargeChange = 3;
            this.outputBufferCountSlider.Location = new System.Drawing.Point(3, 16);
            this.outputBufferCountSlider.Minimum = 1;
            this.outputBufferCountSlider.Name = "outputBufferCountSlider";
            this.outputBufferCountSlider.Size = new System.Drawing.Size(182, 27);
            this.outputBufferCountSlider.TabIndex = 12;
            this.outputBufferCountSlider.Value = 2;
            this.outputBufferCountSlider.Scroll += new System.EventHandler(this.OnOutputBufferCountScroll);
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
            this.outputDeviceComboBox.SelectedIndexChanged += new System.EventHandler(this.OnOutputDeviceChanged);
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Controls.Add(this.button1);
            this.actionsGroupBox.Controls.Add(this.routeList);
            this.actionsGroupBox.Controls.Add(this.stopButton);
            this.actionsGroupBox.Controls.Add(this.startButton);
            this.actionsGroupBox.Location = new System.Drawing.Point(12, 175);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(406, 107);
            this.actionsGroupBox.TabIndex = 2;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "Routes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // routeList
            // 
            this.routeList.FormattingEnabled = true;
            this.routeList.IntegralHeight = false;
            this.routeList.Location = new System.Drawing.Point(6, 19);
            this.routeList.Name = "routeList";
            this.routeList.Size = new System.Drawing.Size(291, 81);
            this.routeList.TabIndex = 3;
            this.routeList.SelectedIndexChanged += new System.EventHandler(this.OnRouteListSelectedIndexChanged);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(303, 48);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(97, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Remove";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.OnStopClicked);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(303, 19);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(97, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Add";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.OnStartClicked);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "Passthrough2";
            this.notifyIcon.Visible = true;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 294);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConfigurationForm";
            this.ShowInTaskbar = false;
            this.Text = "Passthrough2";
            this.inputGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputBufferCountSlider)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputBufferSizeSlider)).EndInit();
            this.outputGroupBox.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputLatencySlider)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputBufferCountSlider)).EndInit();
            this.actionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.ComboBox inputDeviceComboBox;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.ComboBox outputDeviceComboBox;
        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label inputBufferSizeLabel;
        private System.Windows.Forms.TrackBar inputBufferSizeSlider;
        private System.Windows.Forms.Label inputBufferSizeValueLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label inputBufferCountValueLabel;
        private System.Windows.Forms.Label inputBufferCountLabel;
        private System.Windows.Forms.TrackBar inputBufferCountSlider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label outputLatencyValueLabel;
        private System.Windows.Forms.Label outputTargetLatencyLabel;
        private System.Windows.Forms.TrackBar outputLatencySlider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label outputBufferCountValueLabel;
        private System.Windows.Forms.Label outputBufferCountLabel;
        private System.Windows.Forms.TrackBar outputBufferCountSlider;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox routeList;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

