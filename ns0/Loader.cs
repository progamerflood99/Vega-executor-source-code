using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	public class Loader : Form
	{
		private int int_0 = 0;

		private IContainer icontainer_0 = null;

		private ProgressBar progressBar1;

		private Label label2;

		private System.Windows.Forms.Timer timer_0;

		private Label label1;

		private Panel panel2;

		private Label label3;

		private Button button5;

		public Loader()
		{
			InitializeComponent();
		}

		private void Loader_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
			timer_0.Enabled = true;
			timer_0.Interval = 100;
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
			int_0 += 50;
			if (int_0 >= 1000)
			{
				timer_0.Enabled = false;
				timer_0.Stop();
				Hide();
				Thread.Sleep(500);
				VegaX vegaX = new VegaX();
				vegaX.Show();
				MessageBox.Show("Check The Options Tab For Updates & Patch Notes!", "Made By 1_F0", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
			}
			if (int_0 >= 650)
			{
				label3.Visible = true;
				label2.Visible = false;
			}
			progressBar1.Value = int_0;
		}

		private void progressBar1_Click(object sender, EventArgs e)
		{
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void button5_Click(object sender, EventArgs e)
		{
			timer_0.Interval = 10;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns0.Loader));
			progressBar1 = new System.Windows.Forms.ProgressBar();
			label2 = new System.Windows.Forms.Label();
			timer_0 = new System.Windows.Forms.Timer(icontainer_0);
			label1 = new System.Windows.Forms.Label();
			panel2 = new System.Windows.Forms.Panel();
			label3 = new System.Windows.Forms.Label();
			button5 = new System.Windows.Forms.Button();
			SuspendLayout();
			progressBar1.Location = new System.Drawing.Point(26, 56);
			progressBar1.Maximum = 1000;
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new System.Drawing.Size(344, 23);
			progressBar1.TabIndex = 4;
			progressBar1.Click += new System.EventHandler(progressBar1_Click);
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.Color.White;
			label2.Location = new System.Drawing.Point(116, 90);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(165, 21);
			label2.TabIndex = 5;
			label2.Text = "Loading apis . . . ";
			label2.Click += new System.EventHandler(label2_Click);
			timer_0.Tick += new System.EventHandler(timer_0_Tick);
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(114, 12);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(165, 30);
			label1.TabIndex = 3;
			label1.Text = "Vega X - Loader";
			label1.Click += new System.EventHandler(label1_Click);
			panel2.BackColor = System.Drawing.Color.Transparent;
			panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
			panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			panel2.Location = new System.Drawing.Point(3, 2);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(48, 40);
			panel2.TabIndex = 12;
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.Color.White;
			label3.Location = new System.Drawing.Point(145, 90);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(97, 21);
			label3.TabIndex = 13;
			label3.Text = "Opening . . .";
			label3.Visible = false;
			button5.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button5.ForeColor = System.Drawing.SystemColors.Control;
			button5.Location = new System.Drawing.Point(299, 95);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(86, 30);
			button5.TabIndex = 14;
			button5.Text = "Skip Loading";
			button5.UseVisualStyleBackColor = false;
			button5.Click += new System.EventHandler(button5_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			base.ClientSize = new System.Drawing.Size(399, 138);
			base.Controls.Add(button5);
			base.Controls.Add(panel2);
			base.Controls.Add(label1);
			base.Controls.Add(label2);
			base.Controls.Add(progressBar1);
			base.Controls.Add(label3);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Loader";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Loader";
			base.Load += new System.EventHandler(Loader_Load);
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
