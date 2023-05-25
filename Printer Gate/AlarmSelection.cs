using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media;
using PrinterGateXP.Properties;

namespace PrinterGateXP
{
	
	public class AlarmSelection : UserControl
	{
		public AlarmSelection()
		{
			this.InitializeComponent();
			this.Dock = DockStyle.Fill;
			this.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			base.Margin = new Padding(0, 0, 0, 0);
		}

		
		public void DisableEnableOption()
		{
			this.checkBoxEnableAlarm.Visible = false;
		}

		
		public void Localize()
		{
			this.checkBoxEnableAlarm.Text = Localization.Translation("enable_alarm");
		}

		
		public void SetData(bool bEnabled, int volume, int alarmIndex, string alarmPath)
		{
			for (int i = 0; i < AppConfig.DEFAULT_ALARM_COUNT; i++)
			{
				this.comboBoxAlarms.Items.Add(string.Format("Alarm {0:00}", i + 1));
			}
			this.checkBoxEnableAlarm.Checked = bEnabled;
			this.comboBoxAlarms.Enabled = bEnabled;
			this.comboBoxAlarms.Items.Add("Custom Alarm");
			this.comboBoxAlarms.SelectedIndex = alarmIndex;
			this.trackBarVolume.Value = volume;
			this.textBoxCustomAlarm.Text = alarmPath;
			this.alarmEnabled = bEnabled;
			this.alarmVolume = volume;
			this.alarmIndex = alarmIndex;
			this.alarmPath = alarmPath;
		}

		private void checkBoxEnableAlarm_CheckedChanged(object sender, EventArgs e)
		{
			this.updateComponents();
			this.alarmEnabled = this.checkBoxEnableAlarm.Checked;
		}

		
		private void updateComponents()
		{
			this.trackBarVolume.Enabled = this.checkBoxEnableAlarm.Checked;
			this.comboBoxAlarms.Enabled = this.checkBoxEnableAlarm.Checked;
			this.buttonPlay.Enabled = this.checkBoxEnableAlarm.Checked;
			this.textBoxCustomAlarm.Enabled = (this.checkBoxEnableAlarm.Checked && this.comboBoxAlarms.SelectedIndex == AppConfig.DEFAULT_ALARM_COUNT);
			this.buttonBrowseCustomAlarm.Enabled = (this.checkBoxEnableAlarm.Checked && this.comboBoxAlarms.SelectedIndex == AppConfig.DEFAULT_ALARM_COUNT);
		}

		
		private void comboBoxAlarms_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.textBoxCustomAlarm.Enabled = (this.checkBoxEnableAlarm.Checked && this.comboBoxAlarms.SelectedIndex == AppConfig.DEFAULT_ALARM_COUNT);
			this.buttonBrowseCustomAlarm.Enabled = (this.checkBoxEnableAlarm.Checked && this.comboBoxAlarms.SelectedIndex == AppConfig.DEFAULT_ALARM_COUNT);
			this.alarmIndex = this.comboBoxAlarms.SelectedIndex;
		}

		
		private void trackBarVolume_Scroll(object sender, EventArgs e)
		{
			this.alarmVolume = this.trackBarVolume.Value;
		}

		
		private void buttonBrowseCustomAlarm_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "All Media Files|*.wav;*.mp3";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.alarmPath = openFileDialog.FileName;
				this.textBoxCustomAlarm.Text = this.alarmPath;
			}
		}

		
		private void buttonPlay_Click(object sender, EventArgs e)
		{
			MediaPlayer mediaPlayer = new MediaPlayer();
			string path = (this.alarmIndex == AppConfig.DEFAULT_ALARM_COUNT) ? this.alarmPath : string.Format("./alarm/Alarm{0:00}.mp3", this.alarmIndex + 1);
			mediaPlayer.Open(new Uri(Path.GetFullPath(path)));
			mediaPlayer.Volume = (double)((float)this.alarmVolume / 100f);
			mediaPlayer.Play();
		}

		
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		
		private void InitializeComponent()
		{
            this.tableLayoutPanelAlarm = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxEnableAlarm = new System.Windows.Forms.CheckBox();
            this.textBoxCustomAlarm = new System.Windows.Forms.TextBox();
            this.buttonBrowseCustomAlarm = new System.Windows.Forms.Button();
            this.comboBoxAlarms = new System.Windows.Forms.ComboBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.tableLayoutPanelAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAlarm
            // 
            this.tableLayoutPanelAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAlarm.ColumnCount = 3;
            this.tableLayoutPanelAlarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanelAlarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAlarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelAlarm.Controls.Add(this.checkBoxEnableAlarm, 0, 0);
            this.tableLayoutPanelAlarm.Controls.Add(this.textBoxCustomAlarm, 1, 1);
            this.tableLayoutPanelAlarm.Controls.Add(this.buttonBrowseCustomAlarm, 2, 1);
            this.tableLayoutPanelAlarm.Controls.Add(this.comboBoxAlarms, 0, 1);
            this.tableLayoutPanelAlarm.Controls.Add(this.trackBarVolume, 1, 0);
            this.tableLayoutPanelAlarm.Controls.Add(this.buttonPlay, 2, 0);
            this.tableLayoutPanelAlarm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelAlarm.Name = "tableLayoutPanelAlarm";
            this.tableLayoutPanelAlarm.RowCount = 2;
            this.tableLayoutPanelAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAlarm.Size = new System.Drawing.Size(490, 65);
            this.tableLayoutPanelAlarm.TabIndex = 0;
            // 
            // checkBoxEnableAlarm
            // 
            this.checkBoxEnableAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEnableAlarm.AutoSize = true;
            this.checkBoxEnableAlarm.Location = new System.Drawing.Point(3, 4);
            this.checkBoxEnableAlarm.Name = "checkBoxEnableAlarm";
            this.checkBoxEnableAlarm.Size = new System.Drawing.Size(134, 24);
            this.checkBoxEnableAlarm.TabIndex = 0;
            this.checkBoxEnableAlarm.Text = "Enable Alarm";
            this.checkBoxEnableAlarm.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomAlarm
            // 
            this.textBoxCustomAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomAlarm.Location = new System.Drawing.Point(140, 36);
            this.textBoxCustomAlarm.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.textBoxCustomAlarm.Name = "textBoxCustomAlarm";
            this.textBoxCustomAlarm.ReadOnly = true;
            this.textBoxCustomAlarm.Size = new System.Drawing.Size(320, 27);
            this.textBoxCustomAlarm.TabIndex = 2;
            // 
            // buttonBrowseCustomAlarm
            // 
            this.buttonBrowseCustomAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrowseCustomAlarm.Location = new System.Drawing.Point(462, 34);
            this.buttonBrowseCustomAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowseCustomAlarm.Name = "buttonBrowseCustomAlarm";
            this.buttonBrowseCustomAlarm.Size = new System.Drawing.Size(26, 29);
            this.buttonBrowseCustomAlarm.TabIndex = 3;
            this.buttonBrowseCustomAlarm.Text = "...";
            this.buttonBrowseCustomAlarm.UseVisualStyleBackColor = true;
            // 
            // comboBoxAlarms
            // 
            this.comboBoxAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAlarms.FormattingEnabled = true;
            this.comboBoxAlarms.Location = new System.Drawing.Point(0, 35);
            this.comboBoxAlarms.Margin = new System.Windows.Forms.Padding(0, 3, 10, 0);
            this.comboBoxAlarms.Name = "comboBoxAlarms";
            this.comboBoxAlarms.Size = new System.Drawing.Size(130, 28);
            this.comboBoxAlarms.TabIndex = 1;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVolume.Location = new System.Drawing.Point(140, 0);
            this.trackBarVolume.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(320, 32);
            this.trackBarVolume.TabIndex = 5;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Image = global::PrinterGateXP.Properties.Resources.play;
            this.buttonPlay.Location = new System.Drawing.Point(460, 2);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(30, 27);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.UseVisualStyleBackColor = true;
            // 
            // AlarmSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelAlarm);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AlarmSelection";
            this.Size = new System.Drawing.Size(490, 65);
            this.tableLayoutPanelAlarm.ResumeLayout(false);
            this.tableLayoutPanelAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);

		}

		public bool alarmEnabled;

		public int alarmVolume = 100;

		public int alarmIndex;

		public string alarmPath = "";

		private IContainer components;

		private TableLayoutPanel tableLayoutPanelAlarm;

		private CheckBox checkBoxEnableAlarm;

		private ComboBox comboBoxAlarms;

		private TextBox textBoxCustomAlarm;

		private Button buttonBrowseCustomAlarm;

		private Button buttonPlay;

		private TrackBar trackBarVolume;
	}
}
