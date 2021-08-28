using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WeAreDevs_API;

namespace ns0
{
	public class AdjustableScripts : Form
	{
		private ExploitAPI exploitAPI_0 = new ExploitAPI();

		private Point point_0;

		private IContainer icontainer_0 = null;

		private Panel panel1;

		private Label label1;

		private Panel panel2;

		private Button button9;

		private Button button2;

		private Label label2;

		private Label label3;

		private Label label4;

		private TextBox textBox1;

		private TextBox textBox2;

		private TextBox textBox4;

		private Label label6;

		private Button button1;

		private Button button3;

		private Button button4;

		private Button button5;

		public AdjustableScripts()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			InitializeComponent();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			string text = textBox1.Text;
			if (e.KeyChar == Convert.ToChar(Keys.Return))
			{
				exploitAPI_0.SendLuaScript("_Ŗɛ\u0350Кգ\u065eݐࡉ\u094aੜ\u0b5e\u0c02൧ๅཊ၉ᅋቶፉᑅᕚᙇ\u1753\u180eᥜ\u1a76᭼ᱮᵺṹὭ⁽Ⅵ∸⍝②╾♳❿⡿⥦⩪⬣ⱛ\u2d6a\u2e66⽢せㅷ㉣㍠㑠㔣㘿㜡" + text);
				textBox1.Clear();
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void AdjustableScripts_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			string text = textBox2.Text;
			if (e.KeyChar == Convert.ToChar(Keys.Return))
			{
				exploitAPI_0.SendLuaScript("_Ŗɛ\u0350Кգ\u065eݐࡉ\u094aੜ\u0b5e\u0c02൧ๅཊ၉ᅋቶፉᑅᕚᙇ\u1753\u180eᥜ\u1a76᭼ᱮᵺṹὭ⁽Ⅵ∸⍝②╾♳❿⡿⥦⩪⬣ⱆ\u2d7e\u2e67⽹じㅨ㉱㍠㑶㔣㘿㜡" + text);
				textBox2.Clear();
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}

		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			string text = textBox4.Text;
			if (e.KeyChar == Convert.ToChar(Keys.Return))
			{
				exploitAPI_0.SendLuaScript("~ŹɺͳлՃټݠ\u087a\u0963\u0a7f୯౮൩ลཌྷၻᅩቱ፯ᑱᕽᘣ\u173fᠡ" + text);
				textBox4.Clear();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			exploitAPI_0.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = 16");
			Console.Beep();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			exploitAPI_0.SendLuaScript("game.Workspace.Gravity = 196.2");
			Console.Beep();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			exploitAPI_0.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.JumpPower = 50");
			Console.Beep();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			exploitAPI_0.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.JumpPower = 50");
			exploitAPI_0.SendLuaScript("game.Workspace.Gravity = 196.2");
			exploitAPI_0.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = 16");
			MessageBox.Show("All Character Modifications Have Been Reset.");
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - point_0.X;
				base.Top += e.Y - point_0.Y;
			}
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			point_0 = new Point(e.X, e.Y);
		}

		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			point_0 = new Point(e.X, e.Y);
		}

		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - point_0.X;
				base.Top += e.Y - point_0.Y;
			}
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns0.AdjustableScripts));
			panel1 = new System.Windows.Forms.Panel();
			button9 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			panel2 = new System.Windows.Forms.Panel();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			textBox1 = new System.Windows.Forms.TextBox();
			textBox2 = new System.Windows.Forms.TextBox();
			textBox4 = new System.Windows.Forms.TextBox();
			label6 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			button4 = new System.Windows.Forms.Button();
			button5 = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			panel1.Controls.Add(button9);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(label1);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(393, 44);
			panel1.TabIndex = 0;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(panel1_MouseDown);
			panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(panel1_MouseMove);
			button9.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			button9.Location = new System.Drawing.Point(360, 5);
			button9.Name = "button9";
			button9.Size = new System.Drawing.Size(30, 27);
			button9.TabIndex = 18;
			button9.Text = "X";
			button9.UseVisualStyleBackColor = false;
			button9.Click += new System.EventHandler(button9_Click);
			button2.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			button2.Location = new System.Drawing.Point(327, 5);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(30, 27);
			button2.TabIndex = 17;
			button2.Text = "—";
			button2.UseVisualStyleBackColor = false;
			button2.Click += new System.EventHandler(button2_Click);
			panel2.BackColor = System.Drawing.Color.Transparent;
			panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
			panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			panel2.Location = new System.Drawing.Point(3, 3);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(47, 37);
			panel2.TabIndex = 12;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.SystemColors.Window;
			label1.Location = new System.Drawing.Point(127, 10);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(124, 21);
			label1.TabIndex = 4;
			label1.Text = "Vega X - Scripts";
			label1.MouseDown += new System.Windows.Forms.MouseEventHandler(label1_MouseDown);
			label1.MouseMove += new System.Windows.Forms.MouseEventHandler(label1_MouseMove);
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.SystemColors.Control;
			label2.Location = new System.Drawing.Point(90, 53);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(218, 25);
			label2.TabIndex = 207;
			label2.Text = "Character Modifications";
			label2.Click += new System.EventHandler(label2_Click);
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.SystemColors.Window;
			label3.Location = new System.Drawing.Point(12, 86);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(93, 21);
			label3.TabIndex = 208;
			label3.Text = "Walkspeed:";
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label4.ForeColor = System.Drawing.SystemColors.Window;
			label4.Location = new System.Drawing.Point(262, 87);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(103, 21);
			label4.TabIndex = 209;
			label4.Text = "Jump Power:";
			textBox1.Location = new System.Drawing.Point(15, 111);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(100, 20);
			textBox1.TabIndex = 210;
			textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
			textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBox1_KeyPress);
			textBox2.Location = new System.Drawing.Point(265, 111);
			textBox2.Name = "textBox2";
			textBox2.Size = new System.Drawing.Size(100, 20);
			textBox2.TabIndex = 211;
			textBox2.TextChanged += new System.EventHandler(textBox2_TextChanged);
			textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBox2_KeyPress);
			textBox4.Location = new System.Drawing.Point(139, 111);
			textBox4.Name = "textBox4";
			textBox4.Size = new System.Drawing.Size(100, 20);
			textBox4.TabIndex = 230;
			textBox4.TextChanged += new System.EventHandler(textBox4_TextChanged);
			textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBox4_KeyPress);
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label6.ForeColor = System.Drawing.SystemColors.Window;
			label6.Location = new System.Drawing.Point(136, 86);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(65, 21);
			label6.TabIndex = 228;
			label6.Text = "Gravity:";
			button1.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.ForeColor = System.Drawing.SystemColors.Control;
			button1.Location = new System.Drawing.Point(15, 136);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(100, 23);
			button1.TabIndex = 232;
			button1.Text = "RESET";
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(button1_Click);
			button3.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button3.ForeColor = System.Drawing.SystemColors.Control;
			button3.Location = new System.Drawing.Point(139, 136);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(100, 23);
			button3.TabIndex = 233;
			button3.Text = "RESET";
			button3.UseVisualStyleBackColor = false;
			button3.Click += new System.EventHandler(button3_Click);
			button4.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button4.ForeColor = System.Drawing.SystemColors.Control;
			button4.Location = new System.Drawing.Point(265, 136);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(100, 23);
			button4.TabIndex = 234;
			button4.Text = "RESET";
			button4.UseVisualStyleBackColor = false;
			button4.Click += new System.EventHandler(button4_Click);
			button5.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button5.ForeColor = System.Drawing.SystemColors.Control;
			button5.Location = new System.Drawing.Point(12, 167);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(370, 40);
			button5.TabIndex = 235;
			button5.Text = "RESET ALL SETTINGS TO DEFAULT";
			button5.UseVisualStyleBackColor = false;
			button5.Click += new System.EventHandler(button5_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
			base.ClientSize = new System.Drawing.Size(394, 218);
			base.Controls.Add(button5);
			base.Controls.Add(button4);
			base.Controls.Add(button3);
			base.Controls.Add(button1);
			base.Controls.Add(textBox4);
			base.Controls.Add(label6);
			base.Controls.Add(textBox2);
			base.Controls.Add(textBox1);
			base.Controls.Add(label4);
			base.Controls.Add(label3);
			base.Controls.Add(label2);
			base.Controls.Add(panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "AdjustableScripts";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "AdjustableScripts";
			base.Load += new System.EventHandler(AdjustableScripts_Load);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
