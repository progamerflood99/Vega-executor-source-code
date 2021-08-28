using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using WeAreDevs_API;

namespace ns0
{
	public class SimpleUI : Form
	{
		private ExploitAPI exploitAPI_0 = new ExploitAPI();

		private Point point_0;

		private IContainer icontainer_0 = null;

		private Panel panel1;

		private Label label1;

		private Panel panel2;

		private Button button10;

		private Button button1;

		private FastColoredTextBox fastColoredTextBox1;

		private Button button3;

		private Button button2;

		private Button button4;

		private Button button5;

		private Button button6;

		public SimpleUI()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			exploitAPI_0.LaunchExploit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				openFileDialog.Title = "Open";
				((Control)(object)fastColoredTextBox1).Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			exploitAPI_0.SendLuaScript(((Control)(object)fastColoredTextBox1).Text);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			fastColoredTextBox1.Clear();
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

		private void SimpleUI_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		private void label1_MouseUp(object sender, MouseEventArgs e)
		{
		}

		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - point_0.X;
				base.Top += e.Y - point_0.Y;
			}
		}

		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			point_0 = new Point(e.X, e.Y);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
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
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_0661: Unknown result type (might be due to invalid IL or missing references)
			//IL_066b: Expected O, but got Unknown
			icontainer_0 = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns0.SimpleUI));
			panel1 = new System.Windows.Forms.Panel();
			button1 = new System.Windows.Forms.Button();
			button10 = new System.Windows.Forms.Button();
			panel2 = new System.Windows.Forms.Panel();
			label1 = new System.Windows.Forms.Label();
			fastColoredTextBox1 = new FastColoredTextBox();
			button3 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			button4 = new System.Windows.Forms.Button();
			button5 = new System.Windows.Forms.Button();
			button6 = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).BeginInit();
			SuspendLayout();
			panel1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(button10);
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(label1);
			panel1.Location = new System.Drawing.Point(0, -1);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(543, 41);
			panel1.TabIndex = 0;
			panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(panel1_MouseDown);
			panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(panel1_MouseMove);
			button1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			button1.Location = new System.Drawing.Point(509, 5);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(30, 27);
			button1.TabIndex = 15;
			button1.Text = "X";
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(button1_Click);
			button10.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			button10.Location = new System.Drawing.Point(475, 5);
			button10.Name = "button10";
			button10.Size = new System.Drawing.Size(28, 27);
			button10.TabIndex = 14;
			button10.Text = "—";
			button10.UseVisualStyleBackColor = false;
			button10.Click += new System.EventHandler(button10_Click);
			panel2.BackColor = System.Drawing.Color.Transparent;
			panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
			panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			panel2.Location = new System.Drawing.Point(0, 1);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(44, 40);
			panel2.TabIndex = 11;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.SystemColors.Window;
			label1.Location = new System.Drawing.Point(203, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(144, 21);
			label1.TabIndex = 4;
			label1.Text = "Vega X - Simple UI";
			label1.MouseDown += new System.Windows.Forms.MouseEventHandler(label1_MouseDown);
			label1.MouseMove += new System.Windows.Forms.MouseEventHandler(label1_MouseMove);
			label1.MouseUp += new System.Windows.Forms.MouseEventHandler(label1_MouseUp);
			fastColoredTextBox1.set_AutoCompleteBracketsList(new char[10] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
			fastColoredTextBox1.set_AutoIndentCharsPatterns("\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n");
			fastColoredTextBox1.set_AutoScrollMinSize(new System.Drawing.Size(195, 70));
			fastColoredTextBox1.set_BackBrush((System.Drawing.Brush)null);
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
			fastColoredTextBox1.set_BracketsHighlightStrategy((BracketsHighlightStrategy)1);
			fastColoredTextBox1.set_CharHeight(14);
			fastColoredTextBox1.set_CharWidth(8);
			fastColoredTextBox1.set_CommentPrefix("--");
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).Cursor = System.Windows.Forms.Cursors.IBeam;
			fastColoredTextBox1.set_DisabledColor(System.Drawing.Color.FromArgb(100, 180, 180, 180));
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).Font = new System.Drawing.Font("Courier New", 9.75f);
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).ForeColor = System.Drawing.Color.White;
			fastColoredTextBox1.set_IndentBackColor(System.Drawing.Color.FromArgb(40, 40, 40));
			fastColoredTextBox1.set_IsReplaceMode(false);
			fastColoredTextBox1.set_Language((Language)8);
			fastColoredTextBox1.set_LeftBracket('(');
			fastColoredTextBox1.set_LeftBracket2('{');
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).Location = new System.Drawing.Point(6, 46);
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).Name = "fastColoredTextBox1";
			fastColoredTextBox1.set_Paddings(new System.Windows.Forms.Padding(0));
			fastColoredTextBox1.set_RightBracket(')');
			fastColoredTextBox1.set_RightBracket2('}');
			fastColoredTextBox1.set_SelectionColor(System.Drawing.Color.FromArgb(60, 0, 0, 255));
			fastColoredTextBox1.set_ServiceColors((ServiceColors)resources.GetObject("fastColoredTextBox1.ServiceColors"));
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).Size = new System.Drawing.Size(525, 154);
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).TabIndex = 25;
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).Text = "-- Vega X - Simple UI\r\n\r\n-- Full-LUA Execution\r\n\r\n-- Made By 1_F0";
			fastColoredTextBox1.set_Zoom(100);
			button3.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button3.ForeColor = System.Drawing.SystemColors.Control;
			button3.Location = new System.Drawing.Point(12, 206);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(89, 30);
			button3.TabIndex = 26;
			button3.Text = "Execute";
			button3.UseVisualStyleBackColor = false;
			button3.Click += new System.EventHandler(button3_Click);
			button2.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button2.ForeColor = System.Drawing.SystemColors.Control;
			button2.Location = new System.Drawing.Point(202, 206);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(89, 30);
			button2.TabIndex = 27;
			button2.Text = "Open File";
			button2.UseVisualStyleBackColor = false;
			button2.Click += new System.EventHandler(button2_Click);
			button4.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button4.ForeColor = System.Drawing.SystemColors.Control;
			button4.Location = new System.Drawing.Point(107, 206);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(89, 30);
			button4.TabIndex = 28;
			button4.Text = "Clear";
			button4.UseVisualStyleBackColor = false;
			button4.Click += new System.EventHandler(button4_Click);
			button5.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button5.ForeColor = System.Drawing.SystemColors.Control;
			button5.Location = new System.Drawing.Point(442, 206);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(89, 30);
			button5.TabIndex = 29;
			button5.Text = "Attach";
			button5.UseVisualStyleBackColor = false;
			button5.Click += new System.EventHandler(button5_Click);
			button6.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button6.ForeColor = System.Drawing.SystemColors.Control;
			button6.Location = new System.Drawing.Point(297, 206);
			button6.Name = "button6";
			button6.Size = new System.Drawing.Size(89, 30);
			button6.TabIndex = 30;
			button6.Text = "Script Hub";
			button6.UseVisualStyleBackColor = false;
			button6.Click += new System.EventHandler(button6_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
			base.ClientSize = new System.Drawing.Size(543, 245);
			base.Controls.Add(button6);
			base.Controls.Add(button5);
			base.Controls.Add(button4);
			base.Controls.Add(button2);
			base.Controls.Add(button3);
			base.Controls.Add((System.Windows.Forms.Control)(object)fastColoredTextBox1);
			base.Controls.Add(panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "SimpleUI";
			Text = "SimpleUI";
			base.Load += new System.EventHandler(SimpleUI_Load);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).EndInit();
			ResumeLayout(false);
		}
	}
}
