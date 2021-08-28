using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	public class FlappyVega : Form
	{
		private int int_0 = 5;

		private int int_1 = 7;

		private int int_2 = 0;

		private Point point_0;

		private IContainer icontainer_0 = null;

		private Panel panel1;

		private Panel panel2;

		private Label label1;

		private PictureBox ground;

		private PictureBox pipedown;

		private PictureBox bird;

		private PictureBox pipeup;

		private Label Score;

		private System.Windows.Forms.Timer timer_0;

		private Label label2;

		private Label label3;

		private Label label4;

		private Label label5;

		private Label label6;

		private Label label7;

		public FlappyVega()
		{
			InitializeComponent();
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
			bird.Top += int_1;
			pipedown.Left -= int_0;
			pipeup.Left -= int_0;
			Score.Text = int_2.ToString();
			if (pipedown.Left < -600)
			{
				pipedown.Left = 800;
				int_2++;
			}
			if (pipeup.Left < -650)
			{
				pipeup.Left = 800;
				int_2++;
			}
			if (bird.Bounds.IntersectsWith(pipedown.Bounds) || bird.Bounds.IntersectsWith(pipeup.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds) || bird.Bounds.IntersectsWith(panel1.Bounds))
			{
				method_0();
			}
		}

		private void FlappyVega_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F)
			{
				Close();
			}
			if (e.KeyCode == Keys.A)
			{
				timer_0.Interval = 20;
				Score.Text += " ";
				Thread.Sleep(50);
				Score.Text += "Current Mode = EASY";
			}
			if (e.KeyCode == Keys.Z)
			{
				timer_0.Interval = 3;
				Score.Text += " ";
				Thread.Sleep(50);
				Score.Text += "Current Mode = EXPERT";
			}
			if (e.KeyCode == Keys.Q)
			{
				timer_0.Interval = 10;
				Score.Text += " ";
				Thread.Sleep(50);
				Score.Text += "Current Mode = HARD";
			}
			if (e.KeyCode == Keys.E)
			{
				timer_0.Enabled = true;
				label2.Visible = false;
				label3.Visible = false;
				label4.Visible = false;
				label5.Visible = false;
				label6.Visible = false;
			}
			if (e.KeyCode == Keys.Space)
			{
				int_1 = -7;
			}
		}

		private void method_0()
		{
			timer_0.Stop();
			Score.Text += "Game Over";
			Close();
		}

		private void FlappyVega_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				int_1 = 7;
			}
		}

		private void FlappyVega_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			point_0 = new Point(e.X, e.Y);
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - point_0.X;
				base.Top += e.Y - point_0.Y;
			}
		}

		private void method_1(object sender, EventArgs e)
		{
			Close();
		}

		private void method_2(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void label5_Click(object sender, EventArgs e)
		{
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns0.FlappyVega));
			panel1 = new System.Windows.Forms.Panel();
			panel2 = new System.Windows.Forms.Panel();
			label1 = new System.Windows.Forms.Label();
			ground = new System.Windows.Forms.PictureBox();
			pipedown = new System.Windows.Forms.PictureBox();
			bird = new System.Windows.Forms.PictureBox();
			pipeup = new System.Windows.Forms.PictureBox();
			Score = new System.Windows.Forms.Label();
			timer_0 = new System.Windows.Forms.Timer(icontainer_0);
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ground).BeginInit();
			((System.ComponentModel.ISupportInitialize)pipedown).BeginInit();
			((System.ComponentModel.ISupportInitialize)bird).BeginInit();
			((System.ComponentModel.ISupportInitialize)pipeup).BeginInit();
			SuspendLayout();
			panel1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(label1);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(800, 40);
			panel1.TabIndex = 1;
			panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(panel1_MouseDown);
			panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(panel1_MouseMove);
			panel2.BackColor = System.Drawing.Color.Transparent;
			panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
			panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			panel2.Location = new System.Drawing.Point(1, 0);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(44, 40);
			panel2.TabIndex = 10;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.SystemColors.Window;
			label1.Location = new System.Drawing.Point(324, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(162, 21);
			label1.TabIndex = 3;
			label1.Text = "Vega X - Flappy Vega";
			ground.Image = (System.Drawing.Image)resources.GetObject("ground.Image");
			ground.Location = new System.Drawing.Point(-1, 404);
			ground.Name = "ground";
			ground.Size = new System.Drawing.Size(800, 144);
			ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			ground.TabIndex = 2;
			ground.TabStop = false;
			pipedown.Image = (System.Drawing.Image)resources.GetObject("pipedown.Image");
			pipedown.Location = new System.Drawing.Point(564, 281);
			pipedown.Name = "pipedown";
			pipedown.Size = new System.Drawing.Size(99, 123);
			pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pipedown.TabIndex = 3;
			pipedown.TabStop = false;
			bird.Image = (System.Drawing.Image)resources.GetObject("bird.Image");
			bird.Location = new System.Drawing.Point(96, 178);
			bird.Name = "bird";
			bird.Size = new System.Drawing.Size(49, 50);
			bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			bird.TabIndex = 4;
			bird.TabStop = false;
			pipeup.Image = (System.Drawing.Image)resources.GetObject("pipeup.Image");
			pipeup.Location = new System.Drawing.Point(630, 40);
			pipeup.Name = "pipeup";
			pipeup.Size = new System.Drawing.Size(91, 118);
			pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pipeup.TabIndex = 5;
			pipeup.TabStop = false;
			Score.AutoSize = true;
			Score.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			Score.ForeColor = System.Drawing.SystemColors.Window;
			Score.Location = new System.Drawing.Point(12, 418);
			Score.Name = "Score";
			Score.Size = new System.Drawing.Size(0, 21);
			Score.TabIndex = 15;
			timer_0.Interval = 20;
			timer_0.Tick += new System.EventHandler(timer_0_Tick);
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.SystemColors.Window;
			label2.Location = new System.Drawing.Point(12, 55);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(208, 32);
			label2.TabIndex = 11;
			label2.Text = "Press 'E' To START";
			label2.Click += new System.EventHandler(label2_Click);
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.SystemColors.Window;
			label3.Location = new System.Drawing.Point(11, 348);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(196, 21);
			label3.TabIndex = 16;
			label3.Text = "Press 'Q' For HARD Mode";
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label4.ForeColor = System.Drawing.SystemColors.Window;
			label4.Location = new System.Drawing.Point(11, 372);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(217, 21);
			label4.TabIndex = 17;
			label4.Text = "Press 'Z' For EXTREME Mode";
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label5.ForeColor = System.Drawing.SystemColors.Window;
			label5.Location = new System.Drawing.Point(11, 324);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(188, 21);
			label5.TabIndex = 18;
			label5.Text = "Press 'A' For EASY Mode";
			label5.Click += new System.EventHandler(label5_Click);
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label6.ForeColor = System.Drawing.Color.Red;
			label6.Location = new System.Drawing.Point(110, 226);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(203, 21);
			label6.TabIndex = 19;
			label6.Text = "Tip: Press 'Space' To Jump!";
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Segoe UI Semibold", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label7.ForeColor = System.Drawing.SystemColors.Window;
			label7.Location = new System.Drawing.Point(241, 363);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(317, 32);
			label7.TabIndex = 20;
			label7.Text = "Press 'F' To Close The Game";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
			base.ClientSize = new System.Drawing.Size(800, 450);
			base.Controls.Add(label7);
			base.Controls.Add(label6);
			base.Controls.Add(label5);
			base.Controls.Add(label4);
			base.Controls.Add(label3);
			base.Controls.Add(label2);
			base.Controls.Add(Score);
			base.Controls.Add(pipeup);
			base.Controls.Add(bird);
			base.Controls.Add(pipedown);
			base.Controls.Add(ground);
			base.Controls.Add(panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "FlappyVega";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Flappy Vega Minigame";
			base.Load += new System.EventHandler(FlappyVega_Load);
			base.KeyDown += new System.Windows.Forms.KeyEventHandler(FlappyVega_KeyDown);
			base.KeyUp += new System.Windows.Forms.KeyEventHandler(FlappyVega_KeyUp);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ground).EndInit();
			((System.ComponentModel.ISupportInitialize)pipedown).EndInit();
			((System.ComponentModel.ISupportInitialize)bird).EndInit();
			((System.ComponentModel.ISupportInitialize)pipeup).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
