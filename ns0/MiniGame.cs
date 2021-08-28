using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	public class MiniGame : Form
	{
		private Graphics graphics_0;

		private int int_0 = 150;

		private int int_1 = 100;

		private int int_2 = 3;

		private int int_3 = 2;

		private IContainer icontainer_0 = null;

		private Timer timer_0;

		public MiniGame()
		{
			InitializeComponent();
			base.Paint += MiniGame_Paint;
			DoubleBuffered = true;
		}

		private void MiniGame_Paint(object sender, PaintEventArgs e)
		{
			graphics_0 = e.Graphics;
			SolidBrush brush = new SolidBrush(Color.Blue);
			graphics_0.FillEllipse(brush, int_0, int_1, 10, 10);
		}

		private void method_0()
		{
			int num = int_0 + int_2;
			int num2 = int_1 + int_3;
			if (num < -5 || num > base.ClientSize.Width)
			{
				int_2 = -int_2;
			}
			if (num2 < 0 || num2 > base.ClientSize.Height)
			{
				int_3 = -int_3;
			}
			int_0 += int_2;
			int_1 += int_3;
			Invalidate();
		}

		private void MiniGame_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
			method_0();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			icontainer_0 = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns0.MiniGame));
			timer_0 = new System.Windows.Forms.Timer(icontainer_0);
			SuspendLayout();
			timer_0.Enabled = true;
			timer_0.Interval = 10;
			timer_0.Tick += new System.EventHandler(timer_0_Tick);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			base.ClientSize = new System.Drawing.Size(800, 450);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "MiniGame";
			Text = "MiniGame (Re-Size Window To Move)";
			base.Load += new System.EventHandler(MiniGame_Load);
			ResumeLayout(false);
		}
	}
}
