using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using WeAreDevs_API;

namespace ns0
{
	public class Options : Form
	{
		private ExploitAPI exploitAPI_0 = new ExploitAPI();

		private Point point_0;

		private IContainer icontainer_0 = null;

		private Panel panel1;

		private Button button1;

		private Button button2;

		private Label label1;

		private Panel panel2;

		private Button button4;

		private CheckBox checkBox1;

		private CheckBox checkBox2;

		private Button button5;

		private Button button8;

		private Button button9;

		private Button button10;

		private Button button11;

		private Button button12;

		private CheckBox checkBox3;

		private Button button3;

		private Button button13;

		private Panel panel5;

		private Label label2;

		private Label label3;

		private RichTextBox richTextBox1;

		private Button button15;

		private Button button16;

		private Button button7;

		private Button button17;

		private Button button6;

		private Button button18;

		private Button button19;

		private RichTextBox richTextBox2;

		private Label label4;

		private Button button20;

		private Button button21;

		private Button button14;

		public Options()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			Process[] array = processes;
			foreach (Process process in array)
			{
				if (process.ProcessName == "RobloxPlayerBeta")
				{
					process.Kill();
				}
			}
		}

		private void method_0(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		private void method_1(object sender, EventArgs e)
		{
			base.TopMost = false;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("Lŗɖ\u0351ѓԥر\u0732\u0868ॳ\u0a7f\u0b34౫ൿ\u0e73\u0f71\u103aᅷቷ፧ᐿᕼ᙭\u177fᡥ\u197b\u1a7e᭺\u1c27ᵴṤή\u202aⅯ≷⍠");
			exploitAPI_0.SendLuaScript(text);
			exploitAPI_0.SendLuaCScript(text);
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

		private void panel1_Paint(object sender, PaintEventArgs e)
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

		private void button2_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("IŔɫ\u036eѮԦش\u0735\u0869ॹ\u0a64\u0b62\u0c70\u0d76\u0e7a\u0f7cဿᅳበ፣ᐢᕾᙪ\u177dᠦ\u197bᩑ\u1b7e᱁ᴷḲὴ‰");
			exploitAPI_0.SendLuaScript(text);
			exploitAPI_0.SendLuaCScript(text);
		}

		private void Options_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("IŔɫ\u036eѮԦش\u0735\u0869ॹ\u0a64\u0b62\u0c70\u0d76\u0e7a\u0f7cဿᅳበ፣ᐢᕾᙪ\u177dᠦ\u1978\u1a56\u1b40\u1c33ᵶṛ\u1f4f\u206c");
			exploitAPI_0.SendLuaScript(text);
			exploitAPI_0.SendLuaCScript(text);
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void button5_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("IŔɫ\u036eѮԦش\u0735\u0869ॹ\u0a64\u0b62\u0c70\u0d76\u0e7a\u0f7cဿᅳበ፣ᐢᕾᙪ\u177dᠦᥛ\u1a6e᭷᱖ᵧṧὶ⁖");
			exploitAPI_0.SendLuaScript(text);
		}

		private void method_2(object sender, EventArgs e)
		{
		}

		private void method_3(object sender, EventArgs e)
		{
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCPnCsR8_hY_z7tceY5-0KSA?sub_confirmation=1");
			Process.Start("https://www.roblox.com/groups/3872274/Pr0Ph3cy#!/about");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Process.Start("https://obfuscator.aztupscripts.xyz/");
		}

		private void method_4(object sender, EventArgs e)
		{
		}

		private void button10_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			SimpleUI simpleUI = new SimpleUI();
			simpleUI.Show();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("IŔɫ\u036eѮԦش\u0735\u0869ॹ\u0a64\u0b62\u0c70\u0d76\u0e7a\u0f7cဿᅳበ፣ᐢᕾᙪ\u177dᠦ᥌ᨳ᭢᱒ᵷḱὔ\u2062");
			exploitAPI_0.SendLuaScript(text);
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			VegaX vegaX = Application.OpenForms.OfType<VegaX>().FirstOrDefault();
			if (vegaX != null)
			{
				vegaX.TopMost = checkBox3.Checked;
				base.TopMost = false;
			}
		}

		private void method_5(object sender, EventArgs e)
		{
		}

		private void method_6(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCPnCsR8_hY_z7tceY5-0KSA?sub_confirmation=1");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MiniGame miniGame = new MiniGame();
			miniGame.Show();
		}

		private void button13_Click(object sender, EventArgs e)
		{
			Process.Start("https://pastebin.com/raw/cFWfNhmW");
		}

		private void method_7(object sender, EventArgs e)
		{
			Close();
		}

		private void button14_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Kill Roblox: Closes Roblox | Attach Method 2: A Faster Attaching Method | Boost FPS: Limits Graphics | Bypass AC: Bypasses *SOME* Anti-Cheats | TopMost: Puts Vega On Top Of Other Programs | Anti-AFK: Prevents Getting Kicked For Inactivity");
		}

		private void button16_Click(object sender, EventArgs e)
		{
			Process.Start("https://up-to-down.net/82375/VegaExecutor");
		}

		private void button15_Click(object sender, EventArgs e)
		{
			MessageBox.Show("1_F0 - Making The Exploit", "Vega X | Credits", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button17_Click(object sender, EventArgs e)
		{
			Process.Start("https://1f0discordlink.weebly.com/");
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void button6_Click(object sender, EventArgs e)
		{
			FlappyVega flappyVega = new FlappyVega();
			flappyVega.Show();
		}

		private void button18_Click(object sender, EventArgs e)
		{
			AdjustableScripts adjustableScripts = new AdjustableScripts();
			adjustableScripts.Show();
		}

		private void button19_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Everything Seems To Be Working Fine.", "Vega X | Status", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
		}

		private void button20_Click(object sender, EventArgs e)
		{
			exploitAPI_0.SendLuaScript(richTextBox2.Text);
		}

		private void button21_Click(object sender, EventArgs e)
		{
			richTextBox2.Clear();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns0.Options));
			panel1 = new System.Windows.Forms.Panel();
			button7 = new System.Windows.Forms.Button();
			button10 = new System.Windows.Forms.Button();
			panel2 = new System.Windows.Forms.Panel();
			label1 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			button4 = new System.Windows.Forms.Button();
			checkBox1 = new System.Windows.Forms.CheckBox();
			checkBox2 = new System.Windows.Forms.CheckBox();
			button5 = new System.Windows.Forms.Button();
			button8 = new System.Windows.Forms.Button();
			button9 = new System.Windows.Forms.Button();
			button11 = new System.Windows.Forms.Button();
			button12 = new System.Windows.Forms.Button();
			checkBox3 = new System.Windows.Forms.CheckBox();
			button3 = new System.Windows.Forms.Button();
			button13 = new System.Windows.Forms.Button();
			panel5 = new System.Windows.Forms.Panel();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			richTextBox1 = new System.Windows.Forms.RichTextBox();
			button15 = new System.Windows.Forms.Button();
			button16 = new System.Windows.Forms.Button();
			button17 = new System.Windows.Forms.Button();
			button6 = new System.Windows.Forms.Button();
			button18 = new System.Windows.Forms.Button();
			button19 = new System.Windows.Forms.Button();
			richTextBox2 = new System.Windows.Forms.RichTextBox();
			label4 = new System.Windows.Forms.Label();
			button20 = new System.Windows.Forms.Button();
			button21 = new System.Windows.Forms.Button();
			button14 = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			panel1.Controls.Add(button7);
			panel1.Controls.Add(button10);
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(label1);
			panel1.Location = new System.Drawing.Point(-1, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(744, 40);
			panel1.TabIndex = 0;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(panel1_MouseDown);
			panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(panel1_MouseMove);
			button7.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			button7.Location = new System.Drawing.Point(709, 5);
			button7.Name = "button7";
			button7.Size = new System.Drawing.Size(30, 27);
			button7.TabIndex = 14;
			button7.Text = "X";
			button7.UseVisualStyleBackColor = false;
			button7.Click += new System.EventHandler(button7_Click);
			button10.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			button10.Location = new System.Drawing.Point(676, 5);
			button10.Name = "button10";
			button10.Size = new System.Drawing.Size(30, 27);
			button10.TabIndex = 13;
			button10.Text = "—";
			button10.UseVisualStyleBackColor = false;
			button10.Click += new System.EventHandler(button10_Click);
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
			label1.Location = new System.Drawing.Point(305, 8);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(132, 21);
			label1.TabIndex = 3;
			label1.Text = "Vega X - Options";
			label1.Click += new System.EventHandler(label1_Click);
			label1.MouseDown += new System.Windows.Forms.MouseEventHandler(label1_MouseDown);
			label1.MouseMove += new System.Windows.Forms.MouseEventHandler(label1_MouseMove);
			button1.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.ForeColor = System.Drawing.SystemColors.Control;
			button1.Location = new System.Drawing.Point(12, 82);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(128, 30);
			button1.TabIndex = 4;
			button1.Text = "Kill Roblox";
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(button1_Click);
			button2.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button2.ForeColor = System.Drawing.SystemColors.Control;
			button2.Location = new System.Drawing.Point(146, 118);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(123, 30);
			button2.TabIndex = 5;
			button2.Text = "Unlock / Boost FPS";
			button2.UseVisualStyleBackColor = false;
			button2.Click += new System.EventHandler(button2_Click);
			button4.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button4.ForeColor = System.Drawing.SystemColors.Control;
			button4.Location = new System.Drawing.Point(12, 280);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(258, 38);
			button4.TabIndex = 13;
			button4.Text = "Chat Bypass Script";
			button4.UseVisualStyleBackColor = false;
			button4.Click += new System.EventHandler(button4_Click);
			checkBox1.AutoSize = true;
			checkBox1.ForeColor = System.Drawing.SystemColors.Control;
			checkBox1.Location = new System.Drawing.Point(18, 154);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new System.Drawing.Size(67, 17);
			checkBox1.TabIndex = 23;
			checkBox1.Text = "Anti-AFK";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
			checkBox2.AutoSize = true;
			checkBox2.ForeColor = System.Drawing.SystemColors.Control;
			checkBox2.Location = new System.Drawing.Point(186, 155);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new System.Drawing.Size(77, 17);
			checkBox2.TabIndex = 24;
			checkBox2.Text = "Bypass AC";
			checkBox2.UseVisualStyleBackColor = true;
			checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
			button5.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button5.ForeColor = System.Drawing.SystemColors.Control;
			button5.Location = new System.Drawing.Point(12, 118);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(128, 29);
			button5.TabIndex = 26;
			button5.Text = "Force Reset Character";
			button5.UseVisualStyleBackColor = false;
			button5.Click += new System.EventHandler(button5_Click);
			button8.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button8.ForeColor = System.Drawing.SystemColors.Control;
			button8.Location = new System.Drawing.Point(12, 245);
			button8.Name = "button8";
			button8.Size = new System.Drawing.Size(258, 30);
			button8.TabIndex = 28;
			button8.Text = "YouTube Channel / Roblox Group Links";
			button8.UseVisualStyleBackColor = false;
			button8.Click += new System.EventHandler(button8_Click);
			button9.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button9.ForeColor = System.Drawing.SystemColors.Control;
			button9.Location = new System.Drawing.Point(12, 207);
			button9.Name = "button9";
			button9.Size = new System.Drawing.Size(128, 32);
			button9.TabIndex = 29;
			button9.Text = "Obfuscate Script";
			button9.UseVisualStyleBackColor = false;
			button9.Click += new System.EventHandler(button9_Click);
			button11.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button11.ForeColor = System.Drawing.SystemColors.Control;
			button11.Location = new System.Drawing.Point(146, 207);
			button11.Name = "button11";
			button11.Size = new System.Drawing.Size(124, 32);
			button11.TabIndex = 30;
			button11.Text = "Simple UI";
			button11.UseVisualStyleBackColor = false;
			button11.Click += new System.EventHandler(button11_Click);
			button12.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button12.ForeColor = System.Drawing.SystemColors.Control;
			button12.Location = new System.Drawing.Point(12, 177);
			button12.Name = "button12";
			button12.Size = new System.Drawing.Size(259, 24);
			button12.TabIndex = 31;
			button12.Text = "Disable Respawn";
			button12.UseVisualStyleBackColor = false;
			button12.Click += new System.EventHandler(button12_Click);
			checkBox3.AutoSize = true;
			checkBox3.ForeColor = System.Drawing.SystemColors.Control;
			checkBox3.Location = new System.Drawing.Point(103, 154);
			checkBox3.Name = "checkBox3";
			checkBox3.Size = new System.Drawing.Size(68, 17);
			checkBox3.TabIndex = 32;
			checkBox3.Text = "TopMost";
			checkBox3.UseVisualStyleBackColor = true;
			checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
			button3.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button3.ForeColor = System.Drawing.SystemColors.Control;
			button3.Location = new System.Drawing.Point(12, 324);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(128, 30);
			button3.TabIndex = 33;
			button3.Text = "Easy Minigame";
			button3.UseVisualStyleBackColor = false;
			button3.Click += new System.EventHandler(button3_Click);
			button13.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button13.ForeColor = System.Drawing.SystemColors.Control;
			button13.Location = new System.Drawing.Point(146, 324);
			button13.Name = "button13";
			button13.Size = new System.Drawing.Size(124, 30);
			button13.TabIndex = 35;
			button13.Text = "Version Checker";
			button13.UseVisualStyleBackColor = false;
			button13.Click += new System.EventHandler(button13_Click);
			panel5.BackColor = System.Drawing.Color.Transparent;
			panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			panel5.Location = new System.Drawing.Point(277, 82);
			panel5.Name = "panel5";
			panel5.Size = new System.Drawing.Size(15, 315);
			panel5.TabIndex = 125;
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.SystemColors.Window;
			label2.Location = new System.Drawing.Point(75, 52);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(134, 21);
			label2.TabIndex = 14;
			label2.Text = "Vega X - Settings";
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.SystemColors.Window;
			label3.Location = new System.Drawing.Point(365, 52);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(117, 21);
			label3.TabIndex = 126;
			label3.Text = "Vega X - Extras";
			richTextBox1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
			richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
			richTextBox1.ImeMode = System.Windows.Forms.ImeMode.On;
			richTextBox1.Location = new System.Drawing.Point(298, 82);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ReadOnly = true;
			richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			richTextBox1.Size = new System.Drawing.Size(262, 146);
			richTextBox1.TabIndex = 127;
			richTextBox1.Text = resources.GetString("richTextBox1.Text");
			richTextBox1.TextChanged += new System.EventHandler(richTextBox1_TextChanged);
			button15.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button15.ForeColor = System.Drawing.SystemColors.Control;
			button15.Location = new System.Drawing.Point(298, 324);
			button15.Name = "button15";
			button15.Size = new System.Drawing.Size(123, 30);
			button15.TabIndex = 130;
			button15.Text = "Credits";
			button15.UseVisualStyleBackColor = false;
			button15.Click += new System.EventHandler(button15_Click);
			button16.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button16.ForeColor = System.Drawing.SystemColors.Control;
			button16.Location = new System.Drawing.Point(427, 324);
			button16.Name = "button16";
			button16.Size = new System.Drawing.Size(133, 30);
			button16.TabIndex = 131;
			button16.Text = "Newest Verison";
			button16.UseVisualStyleBackColor = false;
			button16.Click += new System.EventHandler(button16_Click);
			button17.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button17.ForeColor = System.Drawing.SystemColors.Control;
			button17.Location = new System.Drawing.Point(298, 360);
			button17.Name = "button17";
			button17.Size = new System.Drawing.Size(262, 37);
			button17.TabIndex = 132;
			button17.Text = "Join My Community Discord Server";
			button17.UseVisualStyleBackColor = false;
			button17.Click += new System.EventHandler(button17_Click);
			button6.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button6.ForeColor = System.Drawing.SystemColors.Control;
			button6.Location = new System.Drawing.Point(146, 82);
			button6.Name = "button6";
			button6.Size = new System.Drawing.Size(123, 30);
			button6.TabIndex = 133;
			button6.Text = "Flappy Bird";
			button6.UseVisualStyleBackColor = false;
			button6.Click += new System.EventHandler(button6_Click);
			button18.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button18.ForeColor = System.Drawing.SystemColors.Control;
			button18.Location = new System.Drawing.Point(298, 234);
			button18.Name = "button18";
			button18.Size = new System.Drawing.Size(262, 41);
			button18.TabIndex = 134;
			button18.Text = "Adjustable Scripts Menu";
			button18.UseVisualStyleBackColor = false;
			button18.Click += new System.EventHandler(button18_Click);
			button19.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button19.ForeColor = System.Drawing.SystemColors.Control;
			button19.Location = new System.Drawing.Point(298, 280);
			button19.Name = "button19";
			button19.Size = new System.Drawing.Size(262, 38);
			button19.TabIndex = 135;
			button19.Text = "Troubleshoot Tester";
			button19.UseVisualStyleBackColor = false;
			button19.Click += new System.EventHandler(button19_Click);
			richTextBox2.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
			richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			richTextBox2.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			richTextBox2.ForeColor = System.Drawing.Color.ForestGreen;
			richTextBox2.Location = new System.Drawing.Point(566, 82);
			richTextBox2.Name = "richTextBox2";
			richTextBox2.Size = new System.Drawing.Size(165, 221);
			richTextBox2.TabIndex = 136;
			richTextBox2.Text = "-- Vega X - Alternative Execution Method\n\n-- Full LUA Compatible\n\n-- Made By 1_F0#6252\n";
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label4.ForeColor = System.Drawing.SystemColors.Window;
			label4.Location = new System.Drawing.Point(574, 52);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(146, 21);
			label4.TabIndex = 137;
			label4.Text = "Alternate Executor";
			button20.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button20.ForeColor = System.Drawing.SystemColors.Control;
			button20.Location = new System.Drawing.Point(566, 309);
			button20.Name = "button20";
			button20.Size = new System.Drawing.Size(165, 45);
			button20.TabIndex = 138;
			button20.Text = "Execute";
			button20.UseVisualStyleBackColor = false;
			button20.Click += new System.EventHandler(button20_Click);
			button21.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button21.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button21.ForeColor = System.Drawing.SystemColors.Control;
			button21.Location = new System.Drawing.Point(566, 360);
			button21.Name = "button21";
			button21.Size = new System.Drawing.Size(165, 36);
			button21.TabIndex = 139;
			button21.Text = "Clear";
			button21.UseVisualStyleBackColor = false;
			button21.Click += new System.EventHandler(button21_Click);
			button14.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button14.ForeColor = System.Drawing.SystemColors.Control;
			button14.Location = new System.Drawing.Point(12, 360);
			button14.Name = "button14";
			button14.Size = new System.Drawing.Size(258, 37);
			button14.TabIndex = 129;
			button14.Text = "Options Menu Button Explainations";
			button14.UseVisualStyleBackColor = false;
			button14.Click += new System.EventHandler(button14_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
			base.ClientSize = new System.Drawing.Size(743, 408);
			base.Controls.Add(button21);
			base.Controls.Add(button20);
			base.Controls.Add(label4);
			base.Controls.Add(richTextBox2);
			base.Controls.Add(button19);
			base.Controls.Add(button18);
			base.Controls.Add(button6);
			base.Controls.Add(button17);
			base.Controls.Add(button16);
			base.Controls.Add(button15);
			base.Controls.Add(button14);
			base.Controls.Add(richTextBox1);
			base.Controls.Add(label3);
			base.Controls.Add(label2);
			base.Controls.Add(panel5);
			base.Controls.Add(button13);
			base.Controls.Add(button3);
			base.Controls.Add(checkBox3);
			base.Controls.Add(button12);
			base.Controls.Add(button11);
			base.Controls.Add(button9);
			base.Controls.Add(button8);
			base.Controls.Add(button5);
			base.Controls.Add(checkBox2);
			base.Controls.Add(checkBox1);
			base.Controls.Add(button4);
			base.Controls.Add(button2);
			base.Controls.Add(button1);
			base.Controls.Add(panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Options";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Load += new System.EventHandler(Options_Load);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
