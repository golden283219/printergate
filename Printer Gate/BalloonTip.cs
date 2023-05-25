using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PrinterGateXP.Properties;

namespace PrinterGateXP
{
	public partial class BalloonTip : Form
	{
		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		
		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		
		public BalloonTip(MainForm form = null)
		{
			this.InitializeComponent();
			this.form = form;
			Screen primaryScreen = Screen.PrimaryScreen;
			int num = 100;
			int num2 = 100;
			int x = primaryScreen.Bounds.X + primaryScreen.Bounds.Width - num;
			int y = primaryScreen.Bounds.Y + primaryScreen.Bounds.Height - num2;
			y = num2 - base.Height;
			base.Location = new Point(x, y);
		}

		public BalloonTip(MainFormAdvanced form = null)
		{
			this.InitializeComponent();
			this.form = form;
			Screen primaryScreen = Screen.PrimaryScreen;
			int num = 100;
			int num2 = 100;
			int x = primaryScreen.Bounds.X + primaryScreen.Bounds.Width - num;
			int y = primaryScreen.Bounds.Y + primaryScreen.Bounds.Height - num2;
			y = num2 - base.Height;
			base.Location = new Point(x, y);
		}
		private void BalloonTip_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this._mouseLoc = e.Location;
			}
		}

		private void BalloonTip_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this._isDragging = true;
				int num = e.Location.X - this._mouseLoc.X;
				int num2 = e.Location.Y - this._mouseLoc.Y;
				base.Location = new Point(base.Location.X + num, base.Location.Y + num2);
			}
		}

		private void BalloonTip_MouseUp(object sender, MouseEventArgs e)
		{
			if (!this._isDragging)
			{
				this.form.Show();
				base.Hide();
			}
			this._isDragging = false;
		}

		private const int WM_NCLBUTTONDOWN = 161;

		private const int HT_CAPTION = 2;

		private Point _mouseLoc;

		private bool _isDragging;

		private Form form;//private MainForm form;

	}
}
