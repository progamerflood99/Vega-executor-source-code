using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using WeAreDevs_API;

namespace ns0
{
	public class ScriptHub3 : Form
	{
		private ExploitAPI exploitAPI_0 = new ExploitAPI();

		private Point point_0;

		private IContainer icontainer_0 = null;

		private Panel panel1;

		private Panel panel2;

		private Label label1;

		private Button button2;

		private Button button11;

		private Button button12;

		private Button button13;

		private Button button19;

		private Button button20;

		private Button button21;

		private Button button91;

		private Button button92;

		private Button button93;

		private Panel panel3;

		private Panel panel5;

		private Label label4;

		private Label label3;

		private Label label2;

		private Button button17;

		private Button button18;

		private Button button9;

		private Button button1;

		private Button button3;

		private Button button4;

		private Button button5;

		private Button button6;

		private Button button7;

		private Button button8;

		private Button button10;

		private Button button14;

		private Button button15;

		private Button button16;

		private Button button22;

		private Button button23;

		private Button button24;

		private Button button25;

		private Panel panel4;

		private Label label5;

		private Button button26;

		private Button button27;

		private Button button28;

		private Button button29;

		private Button button30;

		private Button button31;

		private Button button32;

		private Button button33;

		private Button button34;

		private Button button35;

		private Button button36;

		private Button button37;

		private Button button38;

		private Button button39;

		private Button button40;

		private Button button41;

		private Panel panel6;

		private Label label6;

		private Button button42;

		private Button button43;

		private Button button44;

		private Button button45;

		private Button button46;

		private Button button47;

		private Button button48;

		private Button button49;

		private Button button50;

		private Button button51;

		private Button button52;

		private Button button53;

		private Button button54;

		private Button button55;

		private Button button56;

		private Button button57;

		private Button button58;

		private Button button59;

		private Button button60;

		private Button button61;

		private Button button62;

		private Button button63;

		private Button button64;

		private Button button65;

		private Button button66;

		private Button button67;

		private Panel panel7;

		private Label label7;

		private Button button68;

		private Button button69;

		private Button button70;

		private Button button71;

		private Button button72;

		private Button button73;

		private Button button74;

		private Button button75;

		private Button button76;

		private Button button77;

		private Button button78;

		private Button button79;

		private Button button80;

		private Button button81;

		private Button button82;

		private Button button83;

		private Button button84;

		private Button button85;

		private Button button86;

		private Button button87;

		private Button button88;

		private Button button89;

		private Button button90;

		private Button button94;

		private Button button95;

		private Button button96;

		private Button button97;

		private Button button98;

		private Button button99;

		private Button button100;

		private Button button101;

		private Button button102;

		private Button button103;

		private Button button104;

		private Button button105;

		private Button button106;

		private Button button107;

		private Button button108;

		private Button button109;

		private Button button110;

		private Button button111;

		private Button button112;

		private Button button113;

		private Button button114;

		private Panel panel8;

		private Label label8;

		private Button button115;

		private Button button116;

		private Label label9;

		public ScriptHub3()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void ScriptHub3_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void method_0(object sender, EventArgs e)
		{
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Close();
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

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Hide();
			ScriptHub2 scriptHub = new ScriptHub2();
			scriptHub.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Hide();
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
		}

		private void button93_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/7Dvxr2WN");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button92_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/50Fx94Mf");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button13_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/HxiEuLU0");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button91_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/Ki9MdWhp");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/jv68vmUE");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/WzykCZ3f");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button21_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/BJR0qrVt");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button20_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/nXjKtdvk");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button19_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://raw.githubusercontent.com/BunnySalf/Hentai/main/MHEEHUB");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button18_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/BGu7tyrg");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button12_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/y2mXFhC0");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button11_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/g9g9H95T");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/xd4p5qQN");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button14_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/KmjuMx3m");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/e4KvBszD");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button10_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://paste.ee/r/I20HH/0");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button28_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/YpEXtdJy");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button29_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/KpaR8t5M");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button25_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/U29siiLB");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button24_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/mpZiCUsi");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button23_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/jDCpKDyV");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button27_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/Mq4FTHB1");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button22_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/LH2hH9Ru");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button16_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/ArgFS8v5");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button15_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/ygwcfXck");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button26_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/t6Wg9jkL");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button31_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://paste.ee/r/qbfoU/0");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button32_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/3zUavF4g");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button33_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/6YQ8YmB4");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button30_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/JTR8eQQE");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button44_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/F2kjkhip");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button45_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/7xVaeDvQ");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button46_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/8gyLj9mx");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button43_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/VECiYAqd");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button41_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/uzjXFG6u");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button40_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/GsnRLKgE");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button39_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/efukZQnW");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button38_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/SatDWeF6");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button37_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/4dJtXW7T");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button36_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/YNkWWyAu");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button35_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/y2yFfXw3");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button34_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/yxv9CbfX");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button42_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/LVRZBuES");
			exploitAPI_0.SendLuaScript(text);
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		private void button49_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/W9WFjykQ");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button51_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/QzaGGr3B");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button48_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/S7g4vVH6");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button47_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/cD8eWK4K");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button50_Click(object sender, EventArgs e)
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

		private void button54_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button55_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button56_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button53_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button52_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button67_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/hPxNj094");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button66_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button65_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/Tg7VZkDm");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button62_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button61_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button60_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button59_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button58_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button57_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button63_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button64_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button71_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/ZAjeQsqV");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button73_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button70_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button69_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button68_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button72_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button77_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button79_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button76_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button75_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button74_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button83_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button85_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button82_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button81_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/itwzEm75");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button80_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button78_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/GCPUsDzh");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button84_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/vY3eMhzX");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button89_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/mHHWDbbz");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button90_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/VjVT44dh");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button94_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button88_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button87_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button86_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button98_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/ycrDXnRU");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button100_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/WgnTh2Js");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button99_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/LRJjFxZE");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button97_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/n4HbYaBg");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button96_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/0QWEisXk");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button95_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/LH2hH9Ru");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button114_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/RCYV2fTq");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button115_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/BSAWq4B7");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button116_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/RECwMzDZ");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button113_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/sQa24JwK");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button112_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/NuJkRZU8");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button111_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/L75chtXt");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button110_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://raw.githubusercontent.com/Historia00012/HISTORIAHUB/main/BSS%20FREE");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button109_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/hhXLbMSj");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button108_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/M1ycsJvj");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button107_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/Jbwm8cHr");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button106_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/2B87nBmn");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button105_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/k5TJREte");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button104_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/i7eC3vXy");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button103_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/5cPi1vG2");
			exploitAPI_0.SendLuaScript(text);
		}

		private void button102_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/5uJMZRGn");
			exploitAPI_0.SendLuaScript(text);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns0.ScriptHub3));
			panel1 = new System.Windows.Forms.Panel();
			button9 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			panel2 = new System.Windows.Forms.Panel();
			button11 = new System.Windows.Forms.Button();
			button12 = new System.Windows.Forms.Button();
			button13 = new System.Windows.Forms.Button();
			button19 = new System.Windows.Forms.Button();
			button20 = new System.Windows.Forms.Button();
			button21 = new System.Windows.Forms.Button();
			button91 = new System.Windows.Forms.Button();
			button92 = new System.Windows.Forms.Button();
			button93 = new System.Windows.Forms.Button();
			panel3 = new System.Windows.Forms.Panel();
			panel5 = new System.Windows.Forms.Panel();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			button17 = new System.Windows.Forms.Button();
			button18 = new System.Windows.Forms.Button();
			button1 = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			button4 = new System.Windows.Forms.Button();
			button5 = new System.Windows.Forms.Button();
			button6 = new System.Windows.Forms.Button();
			button7 = new System.Windows.Forms.Button();
			button8 = new System.Windows.Forms.Button();
			button10 = new System.Windows.Forms.Button();
			button14 = new System.Windows.Forms.Button();
			button15 = new System.Windows.Forms.Button();
			button16 = new System.Windows.Forms.Button();
			button22 = new System.Windows.Forms.Button();
			button23 = new System.Windows.Forms.Button();
			button24 = new System.Windows.Forms.Button();
			button25 = new System.Windows.Forms.Button();
			panel4 = new System.Windows.Forms.Panel();
			label5 = new System.Windows.Forms.Label();
			button26 = new System.Windows.Forms.Button();
			button27 = new System.Windows.Forms.Button();
			button28 = new System.Windows.Forms.Button();
			button29 = new System.Windows.Forms.Button();
			button30 = new System.Windows.Forms.Button();
			button31 = new System.Windows.Forms.Button();
			button32 = new System.Windows.Forms.Button();
			button33 = new System.Windows.Forms.Button();
			button34 = new System.Windows.Forms.Button();
			button35 = new System.Windows.Forms.Button();
			button36 = new System.Windows.Forms.Button();
			button37 = new System.Windows.Forms.Button();
			button38 = new System.Windows.Forms.Button();
			button39 = new System.Windows.Forms.Button();
			button40 = new System.Windows.Forms.Button();
			button41 = new System.Windows.Forms.Button();
			panel6 = new System.Windows.Forms.Panel();
			label6 = new System.Windows.Forms.Label();
			button42 = new System.Windows.Forms.Button();
			button43 = new System.Windows.Forms.Button();
			button44 = new System.Windows.Forms.Button();
			button45 = new System.Windows.Forms.Button();
			button46 = new System.Windows.Forms.Button();
			button47 = new System.Windows.Forms.Button();
			button48 = new System.Windows.Forms.Button();
			button49 = new System.Windows.Forms.Button();
			button50 = new System.Windows.Forms.Button();
			button51 = new System.Windows.Forms.Button();
			button52 = new System.Windows.Forms.Button();
			button53 = new System.Windows.Forms.Button();
			button54 = new System.Windows.Forms.Button();
			button55 = new System.Windows.Forms.Button();
			button56 = new System.Windows.Forms.Button();
			button57 = new System.Windows.Forms.Button();
			button58 = new System.Windows.Forms.Button();
			button59 = new System.Windows.Forms.Button();
			button60 = new System.Windows.Forms.Button();
			button61 = new System.Windows.Forms.Button();
			button62 = new System.Windows.Forms.Button();
			button63 = new System.Windows.Forms.Button();
			button64 = new System.Windows.Forms.Button();
			button65 = new System.Windows.Forms.Button();
			button66 = new System.Windows.Forms.Button();
			button67 = new System.Windows.Forms.Button();
			panel7 = new System.Windows.Forms.Panel();
			label7 = new System.Windows.Forms.Label();
			button68 = new System.Windows.Forms.Button();
			button69 = new System.Windows.Forms.Button();
			button70 = new System.Windows.Forms.Button();
			button71 = new System.Windows.Forms.Button();
			button72 = new System.Windows.Forms.Button();
			button73 = new System.Windows.Forms.Button();
			button74 = new System.Windows.Forms.Button();
			button75 = new System.Windows.Forms.Button();
			button76 = new System.Windows.Forms.Button();
			button77 = new System.Windows.Forms.Button();
			button78 = new System.Windows.Forms.Button();
			button79 = new System.Windows.Forms.Button();
			button80 = new System.Windows.Forms.Button();
			button81 = new System.Windows.Forms.Button();
			button82 = new System.Windows.Forms.Button();
			button83 = new System.Windows.Forms.Button();
			button84 = new System.Windows.Forms.Button();
			button85 = new System.Windows.Forms.Button();
			button86 = new System.Windows.Forms.Button();
			button87 = new System.Windows.Forms.Button();
			button88 = new System.Windows.Forms.Button();
			button89 = new System.Windows.Forms.Button();
			button90 = new System.Windows.Forms.Button();
			button94 = new System.Windows.Forms.Button();
			button95 = new System.Windows.Forms.Button();
			button96 = new System.Windows.Forms.Button();
			button97 = new System.Windows.Forms.Button();
			button98 = new System.Windows.Forms.Button();
			button99 = new System.Windows.Forms.Button();
			button100 = new System.Windows.Forms.Button();
			button101 = new System.Windows.Forms.Button();
			button102 = new System.Windows.Forms.Button();
			button103 = new System.Windows.Forms.Button();
			button104 = new System.Windows.Forms.Button();
			button105 = new System.Windows.Forms.Button();
			button106 = new System.Windows.Forms.Button();
			button107 = new System.Windows.Forms.Button();
			button108 = new System.Windows.Forms.Button();
			button109 = new System.Windows.Forms.Button();
			button110 = new System.Windows.Forms.Button();
			button111 = new System.Windows.Forms.Button();
			button112 = new System.Windows.Forms.Button();
			button113 = new System.Windows.Forms.Button();
			button114 = new System.Windows.Forms.Button();
			panel8 = new System.Windows.Forms.Panel();
			label8 = new System.Windows.Forms.Label();
			button115 = new System.Windows.Forms.Button();
			button116 = new System.Windows.Forms.Button();
			label9 = new System.Windows.Forms.Label();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			panel1.Controls.Add(button9);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(panel2);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(1205, 44);
			panel1.TabIndex = 0;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(panel1_MouseDown);
			panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(panel1_MouseMove);
			button9.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			button9.Location = new System.Drawing.Point(1167, 7);
			button9.Name = "button9";
			button9.Size = new System.Drawing.Size(30, 27);
			button9.TabIndex = 16;
			button9.Text = "X";
			button9.UseVisualStyleBackColor = false;
			button9.Click += new System.EventHandler(button9_Click);
			button2.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			button2.Location = new System.Drawing.Point(1134, 7);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(30, 27);
			button2.TabIndex = 15;
			button2.Text = "—";
			button2.UseVisualStyleBackColor = false;
			button2.Click += new System.EventHandler(button2_Click);
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.SystemColors.Window;
			label1.Location = new System.Drawing.Point(486, 10);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(213, 21);
			label1.TabIndex = 14;
			label1.Text = "Vega X - Script Hub | Page 3";
			label1.Click += new System.EventHandler(label1_Click);
			label1.MouseDown += new System.Windows.Forms.MouseEventHandler(label1_MouseDown);
			label1.MouseMove += new System.Windows.Forms.MouseEventHandler(label1_MouseMove);
			panel2.BackColor = System.Drawing.Color.Transparent;
			panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
			panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			panel2.Location = new System.Drawing.Point(2, 1);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(46, 41);
			panel2.TabIndex = 13;
			button11.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button11.ForeColor = System.Drawing.SystemColors.Control;
			button11.Location = new System.Drawing.Point(184, 160);
			button11.Name = "button11";
			button11.Size = new System.Drawing.Size(143, 30);
			button11.TabIndex = 218;
			button11.Text = "Frost Console Remote Spy";
			button11.UseVisualStyleBackColor = false;
			button11.Click += new System.EventHandler(button11_Click);
			button12.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button12.ForeColor = System.Drawing.SystemColors.Control;
			button12.Location = new System.Drawing.Point(184, 124);
			button12.Name = "button12";
			button12.Size = new System.Drawing.Size(143, 30);
			button12.TabIndex = 217;
			button12.Text = "Infinite Yield";
			button12.UseVisualStyleBackColor = false;
			button12.Click += new System.EventHandler(button12_Click);
			button13.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button13.ForeColor = System.Drawing.SystemColors.Control;
			button13.Location = new System.Drawing.Point(184, 88);
			button13.Name = "button13";
			button13.Size = new System.Drawing.Size(143, 30);
			button13.TabIndex = 216;
			button13.Text = "R6 Replication GUI";
			button13.UseVisualStyleBackColor = false;
			button13.Click += new System.EventHandler(button13_Click);
			button19.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button19.ForeColor = System.Drawing.SystemColors.Control;
			button19.Location = new System.Drawing.Point(353, 160);
			button19.Name = "button19";
			button19.Size = new System.Drawing.Size(147, 30);
			button19.TabIndex = 215;
			button19.Text = "Blox Fruits GUI";
			button19.UseVisualStyleBackColor = false;
			button19.Click += new System.EventHandler(button19_Click);
			button20.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button20.ForeColor = System.Drawing.SystemColors.Control;
			button20.Location = new System.Drawing.Point(353, 124);
			button20.Name = "button20";
			button20.Size = new System.Drawing.Size(147, 30);
			button20.TabIndex = 214;
			button20.Text = "Tank Warefare Arcade | 'E'";
			button20.UseVisualStyleBackColor = false;
			button20.Click += new System.EventHandler(button20_Click);
			button21.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button21.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button21.ForeColor = System.Drawing.SystemColors.Control;
			button21.Location = new System.Drawing.Point(353, 88);
			button21.Name = "button21";
			button21.Size = new System.Drawing.Size(147, 30);
			button21.TabIndex = 213;
			button21.Text = "Survive The Killer";
			button21.UseVisualStyleBackColor = false;
			button21.Click += new System.EventHandler(button21_Click);
			button91.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button91.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button91.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button91.ForeColor = System.Drawing.SystemColors.Control;
			button91.Location = new System.Drawing.Point(10, 160);
			button91.Name = "button91";
			button91.Size = new System.Drawing.Size(147, 30);
			button91.TabIndex = 212;
			button91.Text = "Loomian Legacy";
			button91.UseVisualStyleBackColor = false;
			button91.Click += new System.EventHandler(button91_Click);
			button92.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button92.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button92.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button92.ForeColor = System.Drawing.SystemColors.Control;
			button92.Location = new System.Drawing.Point(10, 124);
			button92.Name = "button92";
			button92.Size = new System.Drawing.Size(147, 30);
			button92.TabIndex = 211;
			button92.Text = "A Bizarre Day GUI";
			button92.UseVisualStyleBackColor = false;
			button92.Click += new System.EventHandler(button92_Click);
			button93.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button93.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button93.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button93.ForeColor = System.Drawing.SystemColors.Control;
			button93.Location = new System.Drawing.Point(10, 88);
			button93.Name = "button93";
			button93.Size = new System.Drawing.Size(147, 30);
			button93.TabIndex = 210;
			button93.Text = "Car Crushers 2 GUI";
			button93.UseVisualStyleBackColor = false;
			button93.Click += new System.EventHandler(button93_Click);
			panel3.BackColor = System.Drawing.Color.Transparent;
			panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			panel3.Location = new System.Drawing.Point(164, 88);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(14, 568);
			panel3.TabIndex = 207;
			panel3.Paint += new System.Windows.Forms.PaintEventHandler(panel3_Paint);
			panel5.BackColor = System.Drawing.Color.Transparent;
			panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			panel5.Location = new System.Drawing.Point(333, 88);
			panel5.Name = "panel5";
			panel5.Size = new System.Drawing.Size(14, 568);
			panel5.TabIndex = 205;
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label4.ForeColor = System.Drawing.SystemColors.Control;
			label4.Location = new System.Drawing.Point(571, 57);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(57, 25);
			label4.TabIndex = 209;
			label4.Text = "Misc.";
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.SystemColors.Control;
			label3.Location = new System.Drawing.Point(209, 56);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(91, 25);
			label3.TabIndex = 208;
			label3.Text = "Universal";
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.SystemColors.Control;
			label2.Location = new System.Drawing.Point(46, 55);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(70, 25);
			label2.TabIndex = 206;
			label2.Text = "Games";
			button17.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button17.ForeColor = System.Drawing.SystemColors.Control;
			button17.Location = new System.Drawing.Point(353, 232);
			button17.Name = "button17";
			button17.Size = new System.Drawing.Size(147, 30);
			button17.TabIndex = 220;
			button17.Text = "Typical Colors 2 HBE";
			button17.UseVisualStyleBackColor = false;
			button18.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button18.ForeColor = System.Drawing.SystemColors.Control;
			button18.Location = new System.Drawing.Point(353, 196);
			button18.Name = "button18";
			button18.Size = new System.Drawing.Size(147, 30);
			button18.TabIndex = 219;
			button18.Text = "Blox Fruits GUI #2";
			button18.UseVisualStyleBackColor = false;
			button18.Click += new System.EventHandler(button18_Click);
			button1.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.ForeColor = System.Drawing.SystemColors.Control;
			button1.Location = new System.Drawing.Point(184, 232);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(143, 30);
			button1.TabIndex = 222;
			button1.Text = "FE Hat Orb Tools";
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(button1_Click);
			button3.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button3.ForeColor = System.Drawing.SystemColors.Control;
			button3.Location = new System.Drawing.Point(184, 196);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(143, 30);
			button3.TabIndex = 221;
			button3.Text = "Console Output Copy Tool";
			button3.UseVisualStyleBackColor = false;
			button3.Click += new System.EventHandler(button3_Click);
			button4.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button4.ForeColor = System.Drawing.SystemColors.Control;
			button4.Location = new System.Drawing.Point(10, 232);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(147, 30);
			button4.TabIndex = 224;
			button4.Text = "Ragdoll Engine Break Map";
			button4.UseVisualStyleBackColor = false;
			button4.Click += new System.EventHandler(button4_Click);
			button5.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button5.ForeColor = System.Drawing.SystemColors.Control;
			button5.Location = new System.Drawing.Point(10, 196);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(147, 30);
			button5.TabIndex = 223;
			button5.Text = "Loomian Legacy Heal";
			button5.UseVisualStyleBackColor = false;
			button5.Click += new System.EventHandler(button5_Click);
			button6.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button6.ForeColor = System.Drawing.SystemColors.Control;
			button6.Location = new System.Drawing.Point(605, 662);
			button6.Name = "button6";
			button6.Size = new System.Drawing.Size(588, 36);
			button6.TabIndex = 225;
			button6.Text = "Script Hub | Page 1";
			button6.UseVisualStyleBackColor = false;
			button6.Click += new System.EventHandler(button6_Click);
			button7.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button7.ForeColor = System.Drawing.SystemColors.Control;
			button7.Location = new System.Drawing.Point(10, 662);
			button7.Name = "button7";
			button7.Size = new System.Drawing.Size(589, 36);
			button7.TabIndex = 226;
			button7.Text = "Script Hub | Page 2";
			button7.UseVisualStyleBackColor = false;
			button7.Click += new System.EventHandler(button7_Click);
			button8.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button8.ForeColor = System.Drawing.SystemColors.Control;
			button8.Location = new System.Drawing.Point(10, 268);
			button8.Name = "button8";
			button8.Size = new System.Drawing.Size(147, 30);
			button8.TabIndex = 231;
			button8.Text = "Jailbreak Auto-Drive";
			button8.UseVisualStyleBackColor = false;
			button8.Click += new System.EventHandler(button8_Click);
			button10.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button10.ForeColor = System.Drawing.SystemColors.Control;
			button10.Location = new System.Drawing.Point(184, 268);
			button10.Name = "button10";
			button10.Size = new System.Drawing.Size(143, 30);
			button10.TabIndex = 230;
			button10.Text = "Delux Hub | Script Hub";
			button10.UseVisualStyleBackColor = false;
			button10.Click += new System.EventHandler(button10_Click);
			button14.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button14.ForeColor = System.Drawing.SystemColors.Control;
			button14.Location = new System.Drawing.Point(353, 268);
			button14.Name = "button14";
			button14.Size = new System.Drawing.Size(147, 30);
			button14.TabIndex = 229;
			button14.Text = "Texting Simulator Autofarm";
			button14.UseVisualStyleBackColor = false;
			button14.Click += new System.EventHandler(button14_Click);
			button15.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button15.ForeColor = System.Drawing.SystemColors.Control;
			button15.Location = new System.Drawing.Point(526, 268);
			button15.Name = "button15";
			button15.Size = new System.Drawing.Size(147, 30);
			button15.TabIndex = 239;
			button15.Text = "FE Hat Hax GUI";
			button15.UseVisualStyleBackColor = false;
			button15.Click += new System.EventHandler(button15_Click);
			button16.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button16.ForeColor = System.Drawing.SystemColors.Control;
			button16.Location = new System.Drawing.Point(526, 232);
			button16.Name = "button16";
			button16.Size = new System.Drawing.Size(147, 30);
			button16.TabIndex = 238;
			button16.Text = "Kill All Sounds Semi-FE";
			button16.UseVisualStyleBackColor = false;
			button16.Click += new System.EventHandler(button16_Click);
			button22.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button22.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button22.ForeColor = System.Drawing.SystemColors.Control;
			button22.Location = new System.Drawing.Point(526, 196);
			button22.Name = "button22";
			button22.Size = new System.Drawing.Size(147, 30);
			button22.TabIndex = 237;
			button22.Text = "Streamer Mode";
			button22.UseVisualStyleBackColor = false;
			button22.Click += new System.EventHandler(button22_Click);
			button23.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button23.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button23.ForeColor = System.Drawing.SystemColors.Control;
			button23.Location = new System.Drawing.Point(526, 160);
			button23.Name = "button23";
			button23.Size = new System.Drawing.Size(147, 30);
			button23.TabIndex = 236;
			button23.Text = "FE Drop All Accessories";
			button23.UseVisualStyleBackColor = false;
			button23.Click += new System.EventHandler(button23_Click);
			button24.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button24.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button24.ForeColor = System.Drawing.SystemColors.Control;
			button24.Location = new System.Drawing.Point(526, 124);
			button24.Name = "button24";
			button24.Size = new System.Drawing.Size(147, 30);
			button24.TabIndex = 235;
			button24.Text = "R6 Remove Arms FE";
			button24.UseVisualStyleBackColor = false;
			button24.Click += new System.EventHandler(button24_Click);
			button25.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button25.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button25.ForeColor = System.Drawing.SystemColors.Control;
			button25.Location = new System.Drawing.Point(526, 88);
			button25.Name = "button25";
			button25.Size = new System.Drawing.Size(147, 30);
			button25.TabIndex = 234;
			button25.Text = "R6 Remove Legs FE";
			button25.UseVisualStyleBackColor = false;
			button25.Click += new System.EventHandler(button25_Click);
			panel4.BackColor = System.Drawing.Color.Transparent;
			panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			panel4.Location = new System.Drawing.Point(506, 88);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(14, 568);
			panel4.TabIndex = 232;
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label5.ForeColor = System.Drawing.SystemColors.Control;
			label5.Location = new System.Drawing.Point(388, 57);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(70, 25);
			label5.TabIndex = 233;
			label5.Text = "Games";
			button26.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button26.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button26.ForeColor = System.Drawing.SystemColors.Control;
			button26.Location = new System.Drawing.Point(526, 304);
			button26.Name = "button26";
			button26.Size = new System.Drawing.Size(147, 30);
			button26.TabIndex = 246;
			button26.Text = "Punch Fling GUI";
			button26.UseVisualStyleBackColor = false;
			button26.Click += new System.EventHandler(button26_Click);
			button27.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button27.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button27.ForeColor = System.Drawing.SystemColors.Control;
			button27.Location = new System.Drawing.Point(10, 304);
			button27.Name = "button27";
			button27.Size = new System.Drawing.Size(147, 30);
			button27.TabIndex = 244;
			button27.Text = "Tower Of Hell Tool Giver";
			button27.UseVisualStyleBackColor = false;
			button27.Click += new System.EventHandler(button27_Click);
			button28.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button28.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button28.ForeColor = System.Drawing.SystemColors.Control;
			button28.Location = new System.Drawing.Point(184, 304);
			button28.Name = "button28";
			button28.Size = new System.Drawing.Size(143, 30);
			button28.TabIndex = 243;
			button28.Text = "FE Trolling GUI #2";
			button28.UseVisualStyleBackColor = false;
			button28.Click += new System.EventHandler(button28_Click);
			button29.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button29.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button29.ForeColor = System.Drawing.SystemColors.Control;
			button29.Location = new System.Drawing.Point(872, 160);
			button29.Name = "button29";
			button29.Size = new System.Drawing.Size(147, 30);
			button29.TabIndex = 242;
			button29.Text = "Click Teleport Method 2";
			button29.UseVisualStyleBackColor = false;
			button29.Click += new System.EventHandler(button29_Click);
			button30.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button30.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button30.ForeColor = System.Drawing.SystemColors.Control;
			button30.Location = new System.Drawing.Point(526, 340);
			button30.Name = "button30";
			button30.Size = new System.Drawing.Size(147, 30);
			button30.TabIndex = 253;
			button30.Text = "Force Kick Player";
			button30.UseVisualStyleBackColor = false;
			button30.Click += new System.EventHandler(button30_Click);
			button31.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button31.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button31.ForeColor = System.Drawing.SystemColors.Control;
			button31.Location = new System.Drawing.Point(10, 340);
			button31.Name = "button31";
			button31.Size = new System.Drawing.Size(147, 30);
			button31.TabIndex = 252;
			button31.Text = "Islands OP GUI";
			button31.UseVisualStyleBackColor = false;
			button31.Click += new System.EventHandler(button31_Click);
			button32.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button32.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button32.ForeColor = System.Drawing.SystemColors.Control;
			button32.Location = new System.Drawing.Point(184, 340);
			button32.Name = "button32";
			button32.Size = new System.Drawing.Size(143, 30);
			button32.TabIndex = 251;
			button32.Text = "Tool Searcher / Grabber";
			button32.UseVisualStyleBackColor = false;
			button32.Click += new System.EventHandler(button32_Click);
			button33.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button33.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button33.ForeColor = System.Drawing.SystemColors.Control;
			button33.Location = new System.Drawing.Point(872, 124);
			button33.Name = "button33";
			button33.Size = new System.Drawing.Size(147, 30);
			button33.TabIndex = 250;
			button33.Text = "'B' To Toggle ESP";
			button33.UseVisualStyleBackColor = false;
			button33.Click += new System.EventHandler(button33_Click);
			button34.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button34.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button34.ForeColor = System.Drawing.SystemColors.Control;
			button34.Location = new System.Drawing.Point(699, 340);
			button34.Name = "button34";
			button34.Size = new System.Drawing.Size(147, 30);
			button34.TabIndex = 263;
			button34.Text = "Mount Of The Gods GUI";
			button34.UseVisualStyleBackColor = false;
			button34.Click += new System.EventHandler(button34_Click);
			button35.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button35.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button35.ForeColor = System.Drawing.SystemColors.Control;
			button35.Location = new System.Drawing.Point(699, 304);
			button35.Name = "button35";
			button35.Size = new System.Drawing.Size(147, 30);
			button35.TabIndex = 262;
			button35.Text = "Unanchored To Player GUI";
			button35.UseVisualStyleBackColor = false;
			button35.Click += new System.EventHandler(button35_Click);
			button36.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button36.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button36.ForeColor = System.Drawing.SystemColors.Control;
			button36.Location = new System.Drawing.Point(699, 268);
			button36.Name = "button36";
			button36.Size = new System.Drawing.Size(147, 30);
			button36.TabIndex = 261;
			button36.Text = "Trolling / Flinging GUI";
			button36.UseVisualStyleBackColor = false;
			button36.Click += new System.EventHandler(button36_Click);
			button37.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button37.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button37.ForeColor = System.Drawing.SystemColors.Control;
			button37.Location = new System.Drawing.Point(699, 232);
			button37.Name = "button37";
			button37.Size = new System.Drawing.Size(147, 30);
			button37.TabIndex = 260;
			button37.Text = "Vehicle Simulator Crate TP";
			button37.UseVisualStyleBackColor = false;
			button37.Click += new System.EventHandler(button37_Click);
			button38.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button38.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button38.ForeColor = System.Drawing.SystemColors.Control;
			button38.Location = new System.Drawing.Point(699, 196);
			button38.Name = "button38";
			button38.Size = new System.Drawing.Size(147, 30);
			button38.TabIndex = 259;
			button38.Text = "BABFT Infinite Blocks";
			button38.UseVisualStyleBackColor = false;
			button38.Click += new System.EventHandler(button38_Click);
			button39.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button39.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button39.ForeColor = System.Drawing.SystemColors.Control;
			button39.Location = new System.Drawing.Point(699, 160);
			button39.Name = "button39";
			button39.Size = new System.Drawing.Size(147, 30);
			button39.TabIndex = 258;
			button39.Text = "Fortress Tycoon Script";
			button39.UseVisualStyleBackColor = false;
			button39.Click += new System.EventHandler(button39_Click);
			button40.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button40.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button40.ForeColor = System.Drawing.SystemColors.Control;
			button40.Location = new System.Drawing.Point(699, 124);
			button40.Name = "button40";
			button40.Size = new System.Drawing.Size(147, 30);
			button40.TabIndex = 257;
			button40.Text = "Islands Inventory Viewer";
			button40.UseVisualStyleBackColor = false;
			button40.Click += new System.EventHandler(button40_Click);
			button41.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button41.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button41.ForeColor = System.Drawing.SystemColors.Control;
			button41.Location = new System.Drawing.Point(699, 88);
			button41.Name = "button41";
			button41.Size = new System.Drawing.Size(147, 30);
			button41.TabIndex = 256;
			button41.Text = "Arsenal Auto-Win Script";
			button41.UseVisualStyleBackColor = false;
			button41.Click += new System.EventHandler(button41_Click);
			panel6.BackColor = System.Drawing.Color.Transparent;
			panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			panel6.Location = new System.Drawing.Point(679, 88);
			panel6.Name = "panel6";
			panel6.Size = new System.Drawing.Size(14, 568);
			panel6.TabIndex = 254;
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label6.ForeColor = System.Drawing.SystemColors.Control;
			label6.Location = new System.Drawing.Point(739, 57);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(64, 25);
			label6.TabIndex = 255;
			label6.Text = "Extras";
			button42.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button42.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button42.ForeColor = System.Drawing.SystemColors.Control;
			button42.Location = new System.Drawing.Point(699, 375);
			button42.Name = "button42";
			button42.Size = new System.Drawing.Size(147, 30);
			button42.TabIndex = 272;
			button42.Text = "Sharkbite Auto Farm";
			button42.UseVisualStyleBackColor = false;
			button42.Click += new System.EventHandler(button42_Click);
			button43.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button43.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button43.ForeColor = System.Drawing.SystemColors.Control;
			button43.Location = new System.Drawing.Point(526, 375);
			button43.Name = "button43";
			button43.Size = new System.Drawing.Size(147, 30);
			button43.TabIndex = 270;
			button43.Text = "Lumber Tycoon 2 GUI #3";
			button43.UseVisualStyleBackColor = false;
			button43.Click += new System.EventHandler(button43_Click);
			button44.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button44.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button44.ForeColor = System.Drawing.SystemColors.Control;
			button44.Location = new System.Drawing.Point(10, 375);
			button44.Name = "button44";
			button44.Size = new System.Drawing.Size(147, 30);
			button44.TabIndex = 269;
			button44.Text = "Assassin GUI";
			button44.UseVisualStyleBackColor = false;
			button44.Click += new System.EventHandler(button44_Click);
			button45.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button45.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button45.ForeColor = System.Drawing.SystemColors.Control;
			button45.Location = new System.Drawing.Point(184, 375);
			button45.Name = "button45";
			button45.Size = new System.Drawing.Size(143, 30);
			button45.TabIndex = 268;
			button45.Text = "Suicide Gun Script";
			button45.UseVisualStyleBackColor = false;
			button45.Click += new System.EventHandler(button45_Click);
			button46.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button46.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button46.ForeColor = System.Drawing.SystemColors.Control;
			button46.Location = new System.Drawing.Point(353, 375);
			button46.Name = "button46";
			button46.Size = new System.Drawing.Size(147, 30);
			button46.TabIndex = 267;
			button46.Text = "Lumber Tycoon 2 Break All";
			button46.UseVisualStyleBackColor = false;
			button46.Click += new System.EventHandler(button46_Click);
			button47.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button47.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button47.ForeColor = System.Drawing.SystemColors.Control;
			button47.Location = new System.Drawing.Point(699, 411);
			button47.Name = "button47";
			button47.Size = new System.Drawing.Size(147, 30);
			button47.TabIndex = 281;
			button47.Text = "Money Factory Tycoon";
			button47.UseVisualStyleBackColor = false;
			button47.Click += new System.EventHandler(button47_Click);
			button48.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button48.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button48.ForeColor = System.Drawing.SystemColors.Control;
			button48.Location = new System.Drawing.Point(526, 411);
			button48.Name = "button48";
			button48.Size = new System.Drawing.Size(147, 30);
			button48.TabIndex = 280;
			button48.Text = "Tapping Simulator GUI";
			button48.UseVisualStyleBackColor = false;
			button48.Click += new System.EventHandler(button48_Click);
			button49.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button49.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button49.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button49.ForeColor = System.Drawing.SystemColors.Control;
			button49.Location = new System.Drawing.Point(10, 411);
			button49.Name = "button49";
			button49.Size = new System.Drawing.Size(147, 30);
			button49.TabIndex = 279;
			button49.Text = "SlipBlox OP GUI";
			button49.UseVisualStyleBackColor = false;
			button49.Click += new System.EventHandler(button49_Click);
			button50.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button50.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button50.ForeColor = System.Drawing.SystemColors.Control;
			button50.Location = new System.Drawing.Point(184, 411);
			button50.Name = "button50";
			button50.Size = new System.Drawing.Size(143, 30);
			button50.TabIndex = 278;
			button50.Text = "Close ROBLOX";
			button50.UseVisualStyleBackColor = false;
			button50.Click += new System.EventHandler(button50_Click);
			button51.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button51.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button51.ForeColor = System.Drawing.SystemColors.Control;
			button51.Location = new System.Drawing.Point(353, 411);
			button51.Name = "button51";
			button51.Size = new System.Drawing.Size(147, 30);
			button51.TabIndex = 277;
			button51.Text = "Craftwars GUI";
			button51.UseVisualStyleBackColor = false;
			button51.Click += new System.EventHandler(button51_Click);
			button52.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button52.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button52.ForeColor = System.Drawing.SystemColors.Control;
			button52.Location = new System.Drawing.Point(699, 447);
			button52.Name = "button52";
			button52.Size = new System.Drawing.Size(147, 30);
			button52.TabIndex = 290;
			button52.Text = "Saber Simulator";
			button52.UseVisualStyleBackColor = false;
			button52.Click += new System.EventHandler(button52_Click);
			button53.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button53.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button53.ForeColor = System.Drawing.SystemColors.Control;
			button53.Location = new System.Drawing.Point(526, 447);
			button53.Name = "button53";
			button53.Size = new System.Drawing.Size(147, 30);
			button53.TabIndex = 289;
			button53.Text = "Magnet Simulator";
			button53.UseVisualStyleBackColor = false;
			button53.Click += new System.EventHandler(button53_Click);
			button54.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button54.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button54.ForeColor = System.Drawing.SystemColors.Control;
			button54.Location = new System.Drawing.Point(10, 447);
			button54.Name = "button54";
			button54.Size = new System.Drawing.Size(147, 30);
			button54.TabIndex = 288;
			button54.Text = "Tapping Simulator GUI #2";
			button54.UseVisualStyleBackColor = false;
			button54.Click += new System.EventHandler(button54_Click);
			button55.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button55.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button55.ForeColor = System.Drawing.SystemColors.Control;
			button55.Location = new System.Drawing.Point(184, 447);
			button55.Name = "button55";
			button55.Size = new System.Drawing.Size(143, 30);
			button55.TabIndex = 287;
			button55.Text = "Universal ESP GUI";
			button55.UseVisualStyleBackColor = false;
			button55.Click += new System.EventHandler(button55_Click);
			button56.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button56.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button56.ForeColor = System.Drawing.SystemColors.Control;
			button56.Location = new System.Drawing.Point(353, 447);
			button56.Name = "button56";
			button56.Size = new System.Drawing.Size(147, 30);
			button56.TabIndex = 286;
			button56.Text = "Miners Haven Script";
			button56.UseVisualStyleBackColor = false;
			button56.Click += new System.EventHandler(button56_Click);
			button57.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button57.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button57.ForeColor = System.Drawing.SystemColors.Control;
			button57.Location = new System.Drawing.Point(872, 447);
			button57.Name = "button57";
			button57.Size = new System.Drawing.Size(147, 30);
			button57.TabIndex = 303;
			button57.Text = "Apocalypse Rising";
			button57.UseVisualStyleBackColor = false;
			button57.Click += new System.EventHandler(button57_Click);
			button58.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button58.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button58.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button58.ForeColor = System.Drawing.SystemColors.Control;
			button58.Location = new System.Drawing.Point(872, 411);
			button58.Name = "button58";
			button58.Size = new System.Drawing.Size(147, 30);
			button58.TabIndex = 302;
			button58.Text = "Lifting Simulator GUI #2";
			button58.UseVisualStyleBackColor = false;
			button58.Click += new System.EventHandler(button58_Click);
			button59.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button59.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button59.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button59.ForeColor = System.Drawing.SystemColors.Control;
			button59.Location = new System.Drawing.Point(872, 375);
			button59.Name = "button59";
			button59.Size = new System.Drawing.Size(147, 30);
			button59.TabIndex = 301;
			button59.Text = "Zombie Rush GUI";
			button59.UseVisualStyleBackColor = false;
			button59.Click += new System.EventHandler(button59_Click);
			button60.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button60.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button60.ForeColor = System.Drawing.SystemColors.Control;
			button60.Location = new System.Drawing.Point(872, 340);
			button60.Name = "button60";
			button60.Size = new System.Drawing.Size(147, 30);
			button60.TabIndex = 300;
			button60.Text = "Clicking Champions";
			button60.UseVisualStyleBackColor = false;
			button60.Click += new System.EventHandler(button60_Click);
			button61.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button61.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button61.ForeColor = System.Drawing.SystemColors.Control;
			button61.Location = new System.Drawing.Point(872, 304);
			button61.Name = "button61";
			button61.Size = new System.Drawing.Size(147, 30);
			button61.TabIndex = 299;
			button61.Text = "Impulse Script Hub";
			button61.UseVisualStyleBackColor = false;
			button61.Click += new System.EventHandler(button61_Click);
			button62.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button62.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button62.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button62.ForeColor = System.Drawing.SystemColors.Control;
			button62.Location = new System.Drawing.Point(872, 268);
			button62.Name = "button62";
			button62.Size = new System.Drawing.Size(147, 30);
			button62.TabIndex = 298;
			button62.Text = "Fart Simulator GUI";
			button62.UseVisualStyleBackColor = false;
			button62.Click += new System.EventHandler(button62_Click);
			button63.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button63.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button63.ForeColor = System.Drawing.SystemColors.Control;
			button63.Location = new System.Drawing.Point(872, 232);
			button63.Name = "button63";
			button63.Size = new System.Drawing.Size(147, 30);
			button63.TabIndex = 297;
			button63.Text = "Back Flip Simulator OP GUI";
			button63.UseVisualStyleBackColor = false;
			button63.Click += new System.EventHandler(button63_Click);
			button64.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button64.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button64.ForeColor = System.Drawing.SystemColors.Control;
			button64.Location = new System.Drawing.Point(872, 196);
			button64.Name = "button64";
			button64.Size = new System.Drawing.Size(147, 30);
			button64.TabIndex = 296;
			button64.Text = "Vacuum Simulator GUI";
			button64.UseVisualStyleBackColor = false;
			button64.Click += new System.EventHandler(button64_Click);
			button65.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button65.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button65.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button65.ForeColor = System.Drawing.SystemColors.Control;
			button65.Location = new System.Drawing.Point(872, 88);
			button65.Name = "button65";
			button65.Size = new System.Drawing.Size(147, 30);
			button65.TabIndex = 295;
			button65.Text = "Universal Aimbot + ESP";
			button65.UseVisualStyleBackColor = false;
			button65.Click += new System.EventHandler(button65_Click);
			button66.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button66.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button66.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button66.ForeColor = System.Drawing.SystemColors.Control;
			button66.Location = new System.Drawing.Point(353, 340);
			button66.Name = "button66";
			button66.Size = new System.Drawing.Size(147, 30);
			button66.TabIndex = 294;
			button66.Text = "Big Paintball GUI";
			button66.UseVisualStyleBackColor = false;
			button66.Click += new System.EventHandler(button66_Click);
			button67.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button67.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button67.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button67.ForeColor = System.Drawing.SystemColors.Control;
			button67.Location = new System.Drawing.Point(353, 304);
			button67.Name = "button67";
			button67.Size = new System.Drawing.Size(147, 30);
			button67.TabIndex = 293;
			button67.Text = "Pick A Side AutoFarm";
			button67.UseVisualStyleBackColor = false;
			button67.Click += new System.EventHandler(button67_Click);
			panel7.BackColor = System.Drawing.Color.Transparent;
			panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			panel7.Location = new System.Drawing.Point(852, 88);
			panel7.Name = "panel7";
			panel7.Size = new System.Drawing.Size(14, 568);
			panel7.TabIndex = 291;
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label7.ForeColor = System.Drawing.SystemColors.Control;
			label7.Location = new System.Drawing.Point(915, 57);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(57, 25);
			label7.TabIndex = 292;
			label7.Text = "Misc.";
			button68.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button68.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button68.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button68.ForeColor = System.Drawing.SystemColors.Control;
			button68.Location = new System.Drawing.Point(872, 482);
			button68.Name = "button68";
			button68.Size = new System.Drawing.Size(147, 30);
			button68.TabIndex = 314;
			button68.Text = "Murder Mystery 2 GUI #2";
			button68.UseVisualStyleBackColor = false;
			button68.Click += new System.EventHandler(button68_Click);
			button69.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button69.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button69.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button69.ForeColor = System.Drawing.SystemColors.Control;
			button69.Location = new System.Drawing.Point(699, 482);
			button69.Name = "button69";
			button69.Size = new System.Drawing.Size(147, 30);
			button69.TabIndex = 312;
			button69.Text = "Magnet Simulator GUI #2";
			button69.UseVisualStyleBackColor = false;
			button69.Click += new System.EventHandler(button69_Click);
			button70.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button70.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button70.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button70.ForeColor = System.Drawing.SystemColors.Control;
			button70.Location = new System.Drawing.Point(526, 482);
			button70.Name = "button70";
			button70.Size = new System.Drawing.Size(147, 30);
			button70.TabIndex = 311;
			button70.Text = "Resurrection GUI";
			button70.UseVisualStyleBackColor = false;
			button70.Click += new System.EventHandler(button70_Click);
			button71.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button71.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button71.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button71.ForeColor = System.Drawing.SystemColors.Control;
			button71.Location = new System.Drawing.Point(10, 482);
			button71.Name = "button71";
			button71.Size = new System.Drawing.Size(147, 30);
			button71.TabIndex = 310;
			button71.Text = "Jailbreak Auto-Rob";
			button71.UseVisualStyleBackColor = false;
			button71.Click += new System.EventHandler(button71_Click);
			button72.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button72.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button72.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button72.ForeColor = System.Drawing.SystemColors.Control;
			button72.Location = new System.Drawing.Point(184, 482);
			button72.Name = "button72";
			button72.Size = new System.Drawing.Size(143, 30);
			button72.TabIndex = 309;
			button72.Text = "Moon Hub Script Hub";
			button72.UseVisualStyleBackColor = false;
			button72.Click += new System.EventHandler(button72_Click);
			button73.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button73.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button73.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button73.ForeColor = System.Drawing.SystemColors.Control;
			button73.Location = new System.Drawing.Point(353, 482);
			button73.Name = "button73";
			button73.Size = new System.Drawing.Size(147, 30);
			button73.TabIndex = 308;
			button73.Text = "Super Power Fighting Sim";
			button73.UseVisualStyleBackColor = false;
			button73.Click += new System.EventHandler(button73_Click);
			button74.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button74.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button74.ForeColor = System.Drawing.SystemColors.Control;
			button74.Location = new System.Drawing.Point(872, 518);
			button74.Name = "button74";
			button74.Size = new System.Drawing.Size(147, 30);
			button74.TabIndex = 325;
			button74.Text = "Speedrun 4 GUI";
			button74.UseVisualStyleBackColor = false;
			button74.Click += new System.EventHandler(button74_Click);
			button75.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button75.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button75.ForeColor = System.Drawing.SystemColors.Control;
			button75.Location = new System.Drawing.Point(699, 518);
			button75.Name = "button75";
			button75.Size = new System.Drawing.Size(147, 30);
			button75.TabIndex = 324;
			button75.Text = "Soldier Simulator Script";
			button75.UseVisualStyleBackColor = false;
			button75.Click += new System.EventHandler(button75_Click);
			button76.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button76.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button76.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button76.ForeColor = System.Drawing.SystemColors.Control;
			button76.Location = new System.Drawing.Point(526, 518);
			button76.Name = "button76";
			button76.Size = new System.Drawing.Size(147, 30);
			button76.TabIndex = 323;
			button76.Text = "Treacherous Tower";
			button76.UseVisualStyleBackColor = false;
			button76.Click += new System.EventHandler(button76_Click);
			button77.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button77.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button77.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button77.ForeColor = System.Drawing.SystemColors.Control;
			button77.Location = new System.Drawing.Point(10, 518);
			button77.Name = "button77";
			button77.Size = new System.Drawing.Size(147, 30);
			button77.TabIndex = 322;
			button77.Text = "MM2 GUI #3";
			button77.UseVisualStyleBackColor = false;
			button77.Click += new System.EventHandler(button77_Click);
			button78.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button78.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button78.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button78.ForeColor = System.Drawing.SystemColors.Control;
			button78.Location = new System.Drawing.Point(184, 518);
			button78.Name = "button78";
			button78.Size = new System.Drawing.Size(143, 30);
			button78.TabIndex = 321;
			button78.Text = "Fake Admin Join Message";
			button78.UseVisualStyleBackColor = false;
			button78.Click += new System.EventHandler(button78_Click);
			button79.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button79.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button79.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button79.ForeColor = System.Drawing.SystemColors.Control;
			button79.Location = new System.Drawing.Point(353, 518);
			button79.Name = "button79";
			button79.Size = new System.Drawing.Size(147, 30);
			button79.TabIndex = 320;
			button79.Text = "A Bizarre Day GUI #2";
			button79.UseVisualStyleBackColor = false;
			button79.Click += new System.EventHandler(button79_Click);
			button80.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button80.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button80.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button80.ForeColor = System.Drawing.SystemColors.Control;
			button80.Location = new System.Drawing.Point(872, 554);
			button80.Name = "button80";
			button80.Size = new System.Drawing.Size(147, 30);
			button80.TabIndex = 336;
			button80.Text = "Horrific Housing Script";
			button80.UseVisualStyleBackColor = false;
			button80.Click += new System.EventHandler(button80_Click);
			button81.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button81.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button81.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button81.ForeColor = System.Drawing.SystemColors.Control;
			button81.Location = new System.Drawing.Point(699, 554);
			button81.Name = "button81";
			button81.Size = new System.Drawing.Size(147, 30);
			button81.TabIndex = 335;
			button81.Text = "Jailbreak GUI";
			button81.UseVisualStyleBackColor = false;
			button81.Click += new System.EventHandler(button81_Click);
			button82.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button82.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button82.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button82.ForeColor = System.Drawing.SystemColors.Control;
			button82.Location = new System.Drawing.Point(526, 554);
			button82.Name = "button82";
			button82.Size = new System.Drawing.Size(147, 30);
			button82.TabIndex = 334;
			button82.Text = "Prison Life GUI #4";
			button82.UseVisualStyleBackColor = false;
			button82.Click += new System.EventHandler(button82_Click);
			button83.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button83.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button83.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button83.ForeColor = System.Drawing.SystemColors.Control;
			button83.Location = new System.Drawing.Point(10, 554);
			button83.Name = "button83";
			button83.Size = new System.Drawing.Size(147, 30);
			button83.TabIndex = 333;
			button83.Text = "Tower Of Hell GUI #2";
			button83.UseVisualStyleBackColor = false;
			button83.Click += new System.EventHandler(button83_Click);
			button84.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button84.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button84.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button84.ForeColor = System.Drawing.SystemColors.Control;
			button84.Location = new System.Drawing.Point(184, 554);
			button84.Name = "button84";
			button84.Size = new System.Drawing.Size(143, 30);
			button84.TabIndex = 332;
			button84.Text = "Semi-Universal GUI";
			button84.UseVisualStyleBackColor = false;
			button84.Click += new System.EventHandler(button84_Click);
			button85.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button85.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button85.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button85.ForeColor = System.Drawing.SystemColors.Control;
			button85.Location = new System.Drawing.Point(353, 554);
			button85.Name = "button85";
			button85.Size = new System.Drawing.Size(147, 30);
			button85.TabIndex = 331;
			button85.Text = "Arsenal Simple GUI";
			button85.UseVisualStyleBackColor = false;
			button85.Click += new System.EventHandler(button85_Click);
			button86.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button86.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button86.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button86.ForeColor = System.Drawing.SystemColors.Control;
			button86.Location = new System.Drawing.Point(872, 590);
			button86.Name = "button86";
			button86.Size = new System.Drawing.Size(147, 30);
			button86.TabIndex = 347;
			button86.Text = "Mayday Script";
			button86.UseVisualStyleBackColor = false;
			button86.Click += new System.EventHandler(button86_Click);
			button87.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button87.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button87.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button87.ForeColor = System.Drawing.SystemColors.Control;
			button87.Location = new System.Drawing.Point(699, 590);
			button87.Name = "button87";
			button87.Size = new System.Drawing.Size(147, 30);
			button87.TabIndex = 346;
			button87.Text = "Unit: Classified GUI";
			button87.UseVisualStyleBackColor = false;
			button87.Click += new System.EventHandler(button87_Click);
			button88.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button88.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button88.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button88.ForeColor = System.Drawing.SystemColors.Control;
			button88.Location = new System.Drawing.Point(526, 590);
			button88.Name = "button88";
			button88.Size = new System.Drawing.Size(147, 30);
			button88.TabIndex = 345;
			button88.Text = "Marble Mania GUI";
			button88.UseVisualStyleBackColor = false;
			button88.Click += new System.EventHandler(button88_Click);
			button89.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button89.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button89.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button89.ForeColor = System.Drawing.SystemColors.Control;
			button89.Location = new System.Drawing.Point(10, 590);
			button89.Name = "button89";
			button89.Size = new System.Drawing.Size(147, 30);
			button89.TabIndex = 344;
			button89.Text = "Bubble Gum Simulator GUI";
			button89.UseVisualStyleBackColor = false;
			button89.Click += new System.EventHandler(button89_Click);
			button90.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button90.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button90.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button90.ForeColor = System.Drawing.SystemColors.Control;
			button90.Location = new System.Drawing.Point(184, 590);
			button90.Name = "button90";
			button90.Size = new System.Drawing.Size(143, 30);
			button90.TabIndex = 343;
			button90.Text = "Impulse IY Admin";
			button90.UseVisualStyleBackColor = false;
			button90.Click += new System.EventHandler(button90_Click);
			button94.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button94.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button94.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button94.ForeColor = System.Drawing.SystemColors.Control;
			button94.Location = new System.Drawing.Point(353, 590);
			button94.Name = "button94";
			button94.Size = new System.Drawing.Size(147, 30);
			button94.TabIndex = 342;
			button94.Text = "No Scope Sniping";
			button94.UseVisualStyleBackColor = false;
			button94.Click += new System.EventHandler(button94_Click);
			button95.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button95.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button95.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button95.ForeColor = System.Drawing.SystemColors.Control;
			button95.Location = new System.Drawing.Point(872, 626);
			button95.Name = "button95";
			button95.Size = new System.Drawing.Size(147, 30);
			button95.TabIndex = 358;
			button95.Text = "Streamer Mode V2";
			button95.UseVisualStyleBackColor = false;
			button95.Click += new System.EventHandler(button95_Click);
			button96.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button96.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button96.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button96.ForeColor = System.Drawing.SystemColors.Control;
			button96.Location = new System.Drawing.Point(699, 626);
			button96.Name = "button96";
			button96.Size = new System.Drawing.Size(147, 30);
			button96.TabIndex = 357;
			button96.Text = "Among Blox Instant Win";
			button96.UseVisualStyleBackColor = false;
			button96.Click += new System.EventHandler(button96_Click);
			button97.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button97.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button97.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button97.ForeColor = System.Drawing.SystemColors.Control;
			button97.Location = new System.Drawing.Point(526, 626);
			button97.Name = "button97";
			button97.Size = new System.Drawing.Size(147, 30);
			button97.TabIndex = 356;
			button97.Text = "Among Blox No Cooldown";
			button97.UseVisualStyleBackColor = false;
			button97.Click += new System.EventHandler(button97_Click);
			button98.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button98.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button98.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button98.ForeColor = System.Drawing.SystemColors.Control;
			button98.Location = new System.Drawing.Point(10, 626);
			button98.Name = "button98";
			button98.Size = new System.Drawing.Size(147, 30);
			button98.TabIndex = 355;
			button98.Text = "Blox Hunt Autofarm";
			button98.UseVisualStyleBackColor = false;
			button98.Click += new System.EventHandler(button98_Click);
			button99.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button99.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button99.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button99.ForeColor = System.Drawing.SystemColors.Control;
			button99.Location = new System.Drawing.Point(184, 626);
			button99.Name = "button99";
			button99.Size = new System.Drawing.Size(143, 30);
			button99.TabIndex = 354;
			button99.Text = "Waist Accessory Troll R6";
			button99.UseVisualStyleBackColor = false;
			button99.Click += new System.EventHandler(button99_Click);
			button100.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button100.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button100.ForeColor = System.Drawing.SystemColors.Control;
			button100.Location = new System.Drawing.Point(353, 626);
			button100.Name = "button100";
			button100.Size = new System.Drawing.Size(147, 30);
			button100.TabIndex = 353;
			button100.Text = "MadCity Unclaimed Codes";
			button100.UseVisualStyleBackColor = false;
			button100.Click += new System.EventHandler(button100_Click);
			button101.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button101.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button101.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button101.ForeColor = System.Drawing.SystemColors.Control;
			button101.Location = new System.Drawing.Point(1046, 626);
			button101.Name = "button101";
			button101.Size = new System.Drawing.Size(147, 30);
			button101.TabIndex = 377;
			button101.Text = "Streamer Mode V3";
			button101.UseVisualStyleBackColor = false;
			button102.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button102.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button102.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button102.ForeColor = System.Drawing.SystemColors.Control;
			button102.Location = new System.Drawing.Point(1046, 590);
			button102.Name = "button102";
			button102.Size = new System.Drawing.Size(147, 30);
			button102.TabIndex = 376;
			button102.Text = "Pet Simulator X GUI #2";
			button102.UseVisualStyleBackColor = false;
			button102.Click += new System.EventHandler(button102_Click);
			button103.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button103.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button103.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button103.ForeColor = System.Drawing.SystemColors.Control;
			button103.Location = new System.Drawing.Point(1046, 554);
			button103.Name = "button103";
			button103.Size = new System.Drawing.Size(147, 30);
			button103.TabIndex = 375;
			button103.Text = "Horrific Housing Inf. Coins";
			button103.UseVisualStyleBackColor = false;
			button103.Click += new System.EventHandler(button103_Click);
			button104.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button104.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button104.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button104.ForeColor = System.Drawing.SystemColors.Control;
			button104.Location = new System.Drawing.Point(1046, 518);
			button104.Name = "button104";
			button104.Size = new System.Drawing.Size(147, 30);
			button104.TabIndex = 374;
			button104.Text = "Anime Fighters GUI #3";
			button104.UseVisualStyleBackColor = false;
			button104.Click += new System.EventHandler(button104_Click);
			button105.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button105.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button105.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button105.ForeColor = System.Drawing.SystemColors.Control;
			button105.Location = new System.Drawing.Point(1046, 482);
			button105.Name = "button105";
			button105.Size = new System.Drawing.Size(147, 30);
			button105.TabIndex = 373;
			button105.Text = "Anime Fighters GUI #2";
			button105.UseVisualStyleBackColor = false;
			button105.Click += new System.EventHandler(button105_Click);
			button106.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button106.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button106.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button106.ForeColor = System.Drawing.SystemColors.Control;
			button106.Location = new System.Drawing.Point(1046, 447);
			button106.Name = "button106";
			button106.Size = new System.Drawing.Size(147, 30);
			button106.TabIndex = 372;
			button106.Text = "Epic Minigames GUI #2";
			button106.UseVisualStyleBackColor = false;
			button106.Click += new System.EventHandler(button106_Click);
			button107.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button107.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button107.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button107.ForeColor = System.Drawing.SystemColors.Control;
			button107.Location = new System.Drawing.Point(1046, 411);
			button107.Name = "button107";
			button107.Size = new System.Drawing.Size(147, 30);
			button107.TabIndex = 371;
			button107.Text = "Epic Minigames NEW GUI";
			button107.UseVisualStyleBackColor = false;
			button107.Click += new System.EventHandler(button107_Click);
			button108.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button108.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button108.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button108.ForeColor = System.Drawing.SystemColors.Control;
			button108.Location = new System.Drawing.Point(1046, 375);
			button108.Name = "button108";
			button108.Size = new System.Drawing.Size(147, 30);
			button108.TabIndex = 370;
			button108.Text = "Anime Fighters Simulator";
			button108.UseVisualStyleBackColor = false;
			button108.Click += new System.EventHandler(button108_Click);
			button109.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button109.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button109.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button109.ForeColor = System.Drawing.SystemColors.Control;
			button109.Location = new System.Drawing.Point(1046, 340);
			button109.Name = "button109";
			button109.Size = new System.Drawing.Size(147, 30);
			button109.TabIndex = 369;
			button109.Text = "Car Crushers 2 Auto Farm";
			button109.UseVisualStyleBackColor = false;
			button109.Click += new System.EventHandler(button109_Click);
			button110.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button110.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button110.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button110.ForeColor = System.Drawing.SystemColors.Control;
			button110.Location = new System.Drawing.Point(1046, 304);
			button110.Name = "button110";
			button110.Size = new System.Drawing.Size(147, 30);
			button110.TabIndex = 368;
			button110.Text = "Bee Swarm Simulator GUI";
			button110.UseVisualStyleBackColor = false;
			button110.Click += new System.EventHandler(button110_Click);
			button111.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button111.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button111.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button111.ForeColor = System.Drawing.SystemColors.Control;
			button111.Location = new System.Drawing.Point(1046, 268);
			button111.Name = "button111";
			button111.Size = new System.Drawing.Size(147, 30);
			button111.TabIndex = 367;
			button111.Text = "King Legacy Script";
			button111.UseVisualStyleBackColor = false;
			button111.Click += new System.EventHandler(button111_Click);
			button112.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button112.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button112.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button112.ForeColor = System.Drawing.SystemColors.Control;
			button112.Location = new System.Drawing.Point(1046, 232);
			button112.Name = "button112";
			button112.Size = new System.Drawing.Size(147, 30);
			button112.TabIndex = 366;
			button112.Text = "ZOぞ Alternate GUI";
			button112.UseVisualStyleBackColor = false;
			button112.Click += new System.EventHandler(button112_Click);
			button113.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button113.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button113.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button113.ForeColor = System.Drawing.SystemColors.Control;
			button113.Location = new System.Drawing.Point(1046, 196);
			button113.Name = "button113";
			button113.Size = new System.Drawing.Size(147, 30);
			button113.TabIndex = 365;
			button113.Text = "ZOぞ ESP / Speed GUI";
			button113.UseVisualStyleBackColor = false;
			button113.Click += new System.EventHandler(button113_Click);
			button114.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button114.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button114.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button114.ForeColor = System.Drawing.SystemColors.Control;
			button114.Location = new System.Drawing.Point(1046, 88);
			button114.Name = "button114";
			button114.Size = new System.Drawing.Size(147, 30);
			button114.TabIndex = 364;
			button114.Text = "Pet Simulator X GUI";
			button114.UseVisualStyleBackColor = false;
			button114.Click += new System.EventHandler(button114_Click);
			panel8.BackColor = System.Drawing.Color.Transparent;
			panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			panel8.Location = new System.Drawing.Point(1026, 88);
			panel8.Name = "panel8";
			panel8.Size = new System.Drawing.Size(14, 568);
			panel8.TabIndex = 362;
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label8.ForeColor = System.Drawing.SystemColors.Control;
			label8.Location = new System.Drawing.Point(1082, 57);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(70, 25);
			label8.TabIndex = 363;
			label8.Text = "Games";
			button115.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button115.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button115.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button115.ForeColor = System.Drawing.SystemColors.Control;
			button115.Location = new System.Drawing.Point(1046, 124);
			button115.Name = "button115";
			button115.Size = new System.Drawing.Size(147, 30);
			button115.TabIndex = 361;
			button115.Text = "Bedwars Script";
			button115.UseVisualStyleBackColor = false;
			button115.Click += new System.EventHandler(button115_Click);
			button116.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button116.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button116.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button116.ForeColor = System.Drawing.SystemColors.Control;
			button116.Location = new System.Drawing.Point(1046, 160);
			button116.Name = "button116";
			button116.Size = new System.Drawing.Size(147, 30);
			button116.TabIndex = 360;
			button116.Text = "Bedwars Aimbot GUI";
			button116.UseVisualStyleBackColor = false;
			button116.Click += new System.EventHandler(button116_Click);
			label9.AutoSize = true;
			label9.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label9.ForeColor = System.Drawing.Color.Red;
			label9.Location = new System.Drawing.Point(1149, 70);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(42, 13);
			label9.TabIndex = 378;
			label9.Text = "*NEW*";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
			base.ClientSize = new System.Drawing.Size(1205, 706);
			base.Controls.Add(label9);
			base.Controls.Add(button101);
			base.Controls.Add(button102);
			base.Controls.Add(button103);
			base.Controls.Add(button104);
			base.Controls.Add(button105);
			base.Controls.Add(button106);
			base.Controls.Add(button107);
			base.Controls.Add(button108);
			base.Controls.Add(button109);
			base.Controls.Add(button110);
			base.Controls.Add(button111);
			base.Controls.Add(button112);
			base.Controls.Add(button113);
			base.Controls.Add(button114);
			base.Controls.Add(panel8);
			base.Controls.Add(label8);
			base.Controls.Add(button115);
			base.Controls.Add(button116);
			base.Controls.Add(button95);
			base.Controls.Add(button96);
			base.Controls.Add(button97);
			base.Controls.Add(button98);
			base.Controls.Add(button99);
			base.Controls.Add(button100);
			base.Controls.Add(button86);
			base.Controls.Add(button87);
			base.Controls.Add(button88);
			base.Controls.Add(button89);
			base.Controls.Add(button90);
			base.Controls.Add(button94);
			base.Controls.Add(button80);
			base.Controls.Add(button81);
			base.Controls.Add(button82);
			base.Controls.Add(button83);
			base.Controls.Add(button84);
			base.Controls.Add(button85);
			base.Controls.Add(button74);
			base.Controls.Add(button75);
			base.Controls.Add(button76);
			base.Controls.Add(button77);
			base.Controls.Add(button78);
			base.Controls.Add(button79);
			base.Controls.Add(button68);
			base.Controls.Add(button69);
			base.Controls.Add(button70);
			base.Controls.Add(button71);
			base.Controls.Add(button72);
			base.Controls.Add(button73);
			base.Controls.Add(button57);
			base.Controls.Add(button58);
			base.Controls.Add(button59);
			base.Controls.Add(button60);
			base.Controls.Add(button61);
			base.Controls.Add(button62);
			base.Controls.Add(button63);
			base.Controls.Add(button64);
			base.Controls.Add(button65);
			base.Controls.Add(button66);
			base.Controls.Add(button67);
			base.Controls.Add(panel7);
			base.Controls.Add(label7);
			base.Controls.Add(button52);
			base.Controls.Add(button53);
			base.Controls.Add(button54);
			base.Controls.Add(button55);
			base.Controls.Add(button56);
			base.Controls.Add(button47);
			base.Controls.Add(button48);
			base.Controls.Add(button49);
			base.Controls.Add(button50);
			base.Controls.Add(button51);
			base.Controls.Add(button42);
			base.Controls.Add(button43);
			base.Controls.Add(button44);
			base.Controls.Add(button45);
			base.Controls.Add(button46);
			base.Controls.Add(button34);
			base.Controls.Add(button35);
			base.Controls.Add(button36);
			base.Controls.Add(button37);
			base.Controls.Add(button38);
			base.Controls.Add(button39);
			base.Controls.Add(button40);
			base.Controls.Add(button41);
			base.Controls.Add(panel6);
			base.Controls.Add(label6);
			base.Controls.Add(button30);
			base.Controls.Add(button31);
			base.Controls.Add(button32);
			base.Controls.Add(button33);
			base.Controls.Add(button26);
			base.Controls.Add(button27);
			base.Controls.Add(button28);
			base.Controls.Add(button29);
			base.Controls.Add(button15);
			base.Controls.Add(button16);
			base.Controls.Add(button22);
			base.Controls.Add(button23);
			base.Controls.Add(button24);
			base.Controls.Add(button25);
			base.Controls.Add(panel4);
			base.Controls.Add(label5);
			base.Controls.Add(button8);
			base.Controls.Add(button10);
			base.Controls.Add(button14);
			base.Controls.Add(button7);
			base.Controls.Add(button6);
			base.Controls.Add(button4);
			base.Controls.Add(button5);
			base.Controls.Add(button1);
			base.Controls.Add(button3);
			base.Controls.Add(button17);
			base.Controls.Add(button18);
			base.Controls.Add(button11);
			base.Controls.Add(button12);
			base.Controls.Add(button13);
			base.Controls.Add(button19);
			base.Controls.Add(button20);
			base.Controls.Add(button21);
			base.Controls.Add(button91);
			base.Controls.Add(button92);
			base.Controls.Add(button93);
			base.Controls.Add(panel3);
			base.Controls.Add(panel5);
			base.Controls.Add(label4);
			base.Controls.Add(label3);
			base.Controls.Add(label2);
			base.Controls.Add(panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "ScriptHub3";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "ScriptHub3";
			base.Load += new System.EventHandler(ScriptHub3_Load);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
