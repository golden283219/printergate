namespace PrinterGateXP
{
	
	public partial class BalloonTip : global::System.Windows.Forms.Form
	{
		
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
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::PrinterGateXP.Properties.Resources.printer_gate;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(50, 50);
			base.ControlBox = false;
			this.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(50, 50);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(50, 50);
			base.Name = "BalloonTip";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "BalloonTip";
			base.TopMost = true;
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.BalloonTip_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.BalloonTip_MouseMove);
			base.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.BalloonTip_MouseUp);
			base.ResumeLayout(false);
		}

		
		private global::System.ComponentModel.IContainer components;
	}
}
