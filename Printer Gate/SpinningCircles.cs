using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace PrinterGateXP
{
	public class SpinningCircles : Control
	{
		public SpinningCircles()
		{
			this.timer = new Timer();
			base.Size = new Size(80, 80);
			this.timer.Tick += delegate(object s, EventArgs e)
			{
				base.Invalidate();
			};
			if (!base.DesignMode)
			{
				this.timer.Enabled = true;
			}
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.BackColor = Color.Transparent;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			if (base.Parent != null && this.BackColor == Color.Transparent)
			{
				using (Bitmap bmp = new Bitmap(base.Parent.Width, base.Parent.Height))
				{
					(from Control c in base.Parent.Controls
					where base.Parent.Controls.GetChildIndex(c) > base.Parent.Controls.GetChildIndex(this)
					where c.Bounds.IntersectsWith(base.Bounds)
					orderby base.Parent.Controls.GetChildIndex(c) descending
					select c).ToList<Control>().ForEach(delegate(Control c)
					{
						c.DrawToBitmap(bmp, c.Bounds);
					});
					e.Graphics.DrawImage(bmp, -base.Left, -base.Top);
				}
			}
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			int num = Math.Min(base.Width, base.Height);
			PointF pointF = new PointF((float)(num / 2), (float)(num / 2));
			int num2 = num / 2 - this.radius - (this.n - 1) * this.increment;
			float num3 = (float)(360 / this.n);
			if (!base.DesignMode)
			{
				this.next++;
			}
			this.next = ((this.next >= this.n) ? 0 : this.next);
			int num4 = 0;
			for (int i = this.next; i < this.next + this.n; i++)
			{
				int num5 = i % this.n;
				float num6 = pointF.X + (float)((double)num2 * Math.Cos((double)(num3 * (float)num5) * 3.141592653589793 / 180.0));
				float num7 = pointF.Y + (float)((double)num2 * Math.Sin((double)(num3 * (float)num5) * 3.141592653589793 / 180.0));
				int num8 = this.radius + num4 * this.increment;
				PointF pointF2 = new PointF(num6 - (float)num8, num7 - (float)num8);
				e.Graphics.FillEllipse(Brushes.White, pointF2.X, pointF2.Y, (float)(2 * num8), (float)(2 * num8));
				num4++;
			}
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			this.timer.Enabled = base.Visible;
			base.OnVisibleChanged(e);
		}

		private int increment = 1;

		private int radius = 1;

		private int n = 8;

		private int next;

		private Timer timer;
	}
}
