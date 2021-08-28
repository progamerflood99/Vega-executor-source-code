using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using WeAreDevs_API;

namespace ns0
{
	public class VegaX : Form
	{
		private ExploitAPI exploitAPI_0 = new ExploitAPI();

		private Point point_0;

		private IContainer icontainer_0 = null;

		private Panel panel1;

		private Label label1;

		private Panel panel2;

		private Button button1;

		private Button button2;

		private Button button3;

		private ListBox listBox1;

		private Button button4;

		private Button button5;

		private Button button6;

		private Button button7;

		private Button button8;

		private Button button11;

		private Button button9;

		private TabControl TabControl1;

		private Button ATab;

		private Button RTab;

		private Label label2;

		private Button button10;

		private Button button12;

		private ToolStripMenuItem lightThemeToolStripMenuItem;

		private ToolStripMenuItem dEFAULTTHEMEToolStripMenuItem;

		private ContextMenuStrip contextMenuStrip1;

		private PictureBox pictureBox1;

		private ToolStripSeparator toolStripSeparator11;

		private ToolStripMenuItem cUSTOMTHEMEToolStripMenuItem;

		private ToolStripMenuItem rEMOVECUSTOMTHEMEToolStripMenuItem;

		private CheckBox checkBox1;

		private TrackBar trackBar1;

		private TrackBar trackBar2;

		private System.Windows.Forms.Timer timer_0;

		private ToolStripSeparator toolStripSeparator14;

		private ToolStripSeparator toolStripSeparator15;

		private ToolStripSeparator toolStripSeparator16;

		private ToolStripMenuItem topBarPanelColorsToolStripMenuItem;

		private ToolStripMenuItem lightBlueToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator10;

		private ToolStripMenuItem deepRedToolStripMenuItem;

		private ToolStripMenuItem lightGreenToolStripMenuItem;

		private Button button13;

		private ToolStripSeparator toolStripSeparator17;

		private ToolStripMenuItem dimRedToolStripMenuItem;

		private ToolStripMenuItem brightPurpleToolStripMenuItem;

		private ToolStripMenuItem grayThemeToolStripMenuItem;

		private ToolStripMenuItem redToolStripMenuItem;

		private ToolStripMenuItem orangeToolStripMenuItem;

		private ToolStripMenuItem yellowToolStripMenuItem;

		private ToolStripMenuItem greenToolStripMenuItem;

		private ToolStripMenuItem blueToolStripMenuItem;

		private ToolStripMenuItem purpleToolStripMenuItem;

		private ToolStripMenuItem darkGreenToolStripMenuItem;

		private ToolStripMenuItem lightBlueToolStripMenuItem1;

		private ToolStripMenuItem blackToolStripMenuItem;

		private ToolStripMenuItem pinkToolStripMenuItem;

		private ToolStripMenuItem tanToolStripMenuItem;

		private ToolStripMenuItem whiteToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator1;

		private ToolStripMenuItem tRANSPARENTTEXTBOXToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator2;

		private ToolStripMenuItem onToolStripMenuItem;

		private ToolStripMenuItem offToolStripMenuItem;

		private Button button14;

		private ToolStripSeparator toolStripSeparator3;

		private ToolStripSeparator toolStripSeparator4;

		private ToolStripSeparator toolStripSeparator5;

		private ToolStripSeparator toolStripSeparator6;

		public VegaX()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			InitializeComponent();
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

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("Do You Really Want To Close Vega X?", "Vega X | Execution", MessageBoxButtons.YesNo))
			{
			case DialogResult.Yes:
				Application.Exit();
				break;
			}
		}

		private void panel2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("AŪɮ\u036cШՅٿܥ࠵ड़\u0a44\u0b31", "Credits", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
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

		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Control control = TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", searchAllChildren: true).FirstOrDefault();
			FastColoredTextBox val = (FastColoredTextBox)(object)((control is FastColoredTextBox) ? control : null);
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			using Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew);
			using StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.Write(((Control)(object)val).Text);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Control control = TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", searchAllChildren: true).FirstOrDefault();
			FastColoredTextBox val = (FastColoredTextBox)(object)((control is FastColoredTextBox) ? control : null);
			((Control)(object)val).Text = "";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Control control = TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", searchAllChildren: true).FirstOrDefault();
			FastColoredTextBox val = (FastColoredTextBox)(object)((control is FastColoredTextBox) ? control : null);
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				openFileDialog.Title = "Open";
				((Control)(object)val).Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Options options = new Options();
			options.Show();
		}

		private void VegaX_Load(object sender, EventArgs e)
		{
			timer_0.Start();
			string text = "Scriptbox " + (TabControl1.TabCount + 1);
			UserControl1 userControl = new UserControl1();
			userControl.Dock = DockStyle.Fill;
			TabPage tabPage = new TabPage(text);
			tabPage.Controls.Add(userControl);
			TabControl1.TabPages.Add(tabPage);
			base.TopMost = true;
			listBox1.Items.Clear();
			Class0.smethod_0(listBox1, "./Scripts", "*.txt");
			Class0.smethod_0(listBox1, "./Scripts", "*.lua");
			pictureBox1.AllowDrop = true;
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Class0.smethod_0(listBox1, "./Scripts", "*.txt");
			Class0.smethod_0(listBox1, "./Scripts", "*.lua");
			ScriptManager scriptManager = new ScriptManager();
			scriptManager.Show();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Control control = TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", searchAllChildren: true).FirstOrDefault();
			FastColoredTextBox val = (FastColoredTextBox)(object)((control is FastColoredTextBox) ? control : null);
			((Control)(object)val).Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Control control = TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", searchAllChildren: true).FirstOrDefault();
			FastColoredTextBox val = (FastColoredTextBox)(object)((control is FastColoredTextBox) ? control : null);
			exploitAPI_0.SendLuaScript(((Control)(object)val).Text);
			exploitAPI_0.SendLuaCScript(((Control)(object)val).Text);
		}

		private void button11_Click(object sender, EventArgs e)
		{
			label1.Text = "Vega X - v2.1.4a | Loading...";
			exploitAPI_0.LaunchExploit();
			Thread.Sleep(500);
			label1.Text = "Vega X - v2.1.4a";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			contextMenuStrip1.Show(button10, 0, button10.Height);
		}

		private void ATab_Click(object sender, EventArgs e)
		{
			string text = "Zūɵ\u036fѵհ١ݭ\u0879" + (TabControl1.TabCount + 1);
			UserControl1 userControl = new UserControl1();
			userControl.Dock = DockStyle.Fill;
			TabPage tabPage = new TabPage(text);
			tabPage.Controls.Add(userControl);
			TabControl1.TabPages.Add(tabPage);
		}

		private void RTab_Click(object sender, EventArgs e)
		{
			TabControl1.TabPages.Remove(TabControl1.SelectedTab);
		}

		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void method_0(object sender, EventArgs e)
		{
		}

		private void TabControl1_Click(object sender, EventArgs e)
		{
		}

		private void panel1_Click(object sender, EventArgs e)
		{
		}

		private void listBox1_Click(object sender, EventArgs e)
		{
		}

		private void VegaX_Click(object sender, EventArgs e)
		{
		}

		private void method_1(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex != -1)
			{
				exploitAPI_0.SendLuaScript(File.ReadAllText("scripts\\" + listBox1.SelectedItem.ToString()));
				exploitAPI_0.SendLuaCScript(File.ReadAllText("scripts\\" + listBox1.SelectedItem.ToString()));
			}
		}

		private void method_2(object sender, EventArgs e)
		{
			Control control = TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", searchAllChildren: true).FirstOrDefault();
			FastColoredTextBox val = (FastColoredTextBox)(object)((control is FastColoredTextBox) ? control : null);
			if (listBox1.SelectedIndex != -1)
			{
				((Control)(object)val).Text = File.ReadAllText("scripts\\" + listBox1.SelectedItem.ToString());
			}
			else
			{
				MessageBox.Show("Please select a script from the list before trying to loading it in tab.", "Name");
			}
		}

		private void method_3(object sender, EventArgs e)
		{
		}

		private void VegaX_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		private void method_4(object sender, EventArgs e)
		{
		}

		private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void method_5(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.DarkRed;
		}

		private void method_6(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Orange;
		}

		private void method_7(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Yellow;
		}

		private void method_8(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Green;
		}

		private void method_9(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Blue;
		}

		private void method_10(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Purple;
		}

		private void method_11(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Black;
		}

		private void method_12(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Pink;
		}

		private void method_13(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.White;
		}

		private void dEFAULTTHEMEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = button12.BackColor;
			panel1.BackColor = button13.BackColor;
		}

		private void method_14(object sender, EventArgs e)
		{
		}

		private void method_15(object sender, EventArgs e)
		{
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		private void pictureBox1_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		private void pictureBox1_DragDrop(object sender, DragEventArgs e)
		{
			object data = e.Data.GetData(DataFormats.FileDrop);
			if (data != null)
			{
				string[] array = data as string[];
				if (array.Length != 0)
				{
					pictureBox1.Image = Image.FromFile(array[0]);
				}
			}
		}

		private void rEMOVECUSTOMTHEMEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("Do You Really Want To Remove Your Custom Theme?", "Vega X | Themes", MessageBoxButtons.YesNo))
			{
			case DialogResult.Yes:
				pictureBox1.Image = null;
				break;
			}
		}

		private void method_16(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.LightBlue;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.CheckState == CheckState.Checked)
			{
				Form.ActiveForm.Opacity = (double)trackBar1.Value / 10.0;
			}
			if (checkBox1.CheckState == CheckState.Unchecked)
			{
				Form.ActiveForm.Opacity = (double)trackBar2.Value / 10.0;
			}
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (base.Opacity < 1.0)
			{
				base.Opacity += 0.15;
			}
			else
			{
				timer_0.Stop();
			}
		}

		private void toolStripSeparator15_Click(object sender, EventArgs e)
		{
		}

		private void lightBlueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel1.BackColor = Color.CornflowerBlue;
		}

		private void deepRedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel1.BackColor = Color.OrangeRed;
		}

		private void lightGreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel1.BackColor = Color.DarkSeaGreen;
		}

		private void method_17(object sender, EventArgs e)
		{
			panel1.BackColor = button13.BackColor;
		}

		private void dimRedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel1.BackColor = Color.IndianRed;
		}

		private void brightPurpleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel1.BackColor = Color.MediumPurple;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void grayThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Gray;
		}

		private void redToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Red;
		}

		private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Orange;
		}

		private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Yellow;
		}

		private void greenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Green;
		}

		private void blueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Blue;
		}

		private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Purple;
		}

		private void darkGreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.DarkGreen;
		}

		private void lightBlueToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.LightBlue;
		}

		private void blackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Black;
		}

		private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Pink;
		}

		private void tanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Tan;
		}

		private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.White;
		}

		private void method_18(object sender, EventArgs e)
		{
		}

		private void cUSTOMTHEMEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Èǹ\u02ebϮҨ׆\u06e8ߡࢤ\u09c7૰௮\u0cf0ൟ฿༓စᅛቝፗᐿᔾᘰ\u1752ᡘᥓ\u1a55᭟\u1c3aᴿḫἪ⁋ⅇ≊⍎⑆┷☨✢⡃⥏⩂⬎Ⱂ\u2d7f\u2e79⽳〖ㄋ㈝㍾㑸㔑㘿㜹㠱㥳㨛㬿㱽㴍㸫㼹䀻䄮䈯䌧䑨䔓䘮䜠䡤䥤䨍䬱䰴䵖乑体偏儜刚卻呍啃噂坚塚夓婳孟屔崏幺彅恉愋戍捺摋敕晏杕桐椃橪歔求洸渾潟灩煯牮獶瑶男療睺破祆穡筴簰絎縮罎聹腸艾荦葥蔧虒蝭衡襮詧謯");
		}

		private void tRANSPARENTTEXTBOXToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void onToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TabControl1.SendToBack();
		}

		private void offToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TabControl1.BringToFront();
		}

		private void button14_Click(object sender, EventArgs e)
		{
			Control control = TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", searchAllChildren: true).FirstOrDefault();
			FastColoredTextBox val = (FastColoredTextBox)(object)((control is FastColoredTextBox) ? control : null);
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				openFileDialog.Title = "Open";
				((Control)(object)val).Text = File.ReadAllText(openFileDialog.FileName);
				exploitAPI_0.SendLuaScript(((Control)(object)val).Text);
				exploitAPI_0.SendLuaCScript(((Control)(object)val).Text);
			}
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns0.VegaX));
			panel1 = new System.Windows.Forms.Panel();
			checkBox1 = new System.Windows.Forms.CheckBox();
			label2 = new System.Windows.Forms.Label();
			button10 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			button1 = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			panel2 = new System.Windows.Forms.Panel();
			button3 = new System.Windows.Forms.Button();
			listBox1 = new System.Windows.Forms.ListBox();
			button4 = new System.Windows.Forms.Button();
			button5 = new System.Windows.Forms.Button();
			button6 = new System.Windows.Forms.Button();
			button7 = new System.Windows.Forms.Button();
			button8 = new System.Windows.Forms.Button();
			button11 = new System.Windows.Forms.Button();
			button9 = new System.Windows.Forms.Button();
			TabControl1 = new System.Windows.Forms.TabControl();
			ATab = new System.Windows.Forms.Button();
			RTab = new System.Windows.Forms.Button();
			button12 = new System.Windows.Forms.Button();
			lightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			grayThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			darkGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			lightBlueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			tanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			dEFAULTTHEMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(icontainer_0);
			toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
			topBarPanelColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			lightBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			deepRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			lightGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			dimRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			brightPurpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
			cUSTOMTHEMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			rEMOVECUSTOMTHEMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
			tRANSPARENTTEXTBOXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			trackBar1 = new System.Windows.Forms.TrackBar();
			trackBar2 = new System.Windows.Forms.TrackBar();
			timer_0 = new System.Windows.Forms.Timer(icontainer_0);
			button13 = new System.Windows.Forms.Button();
			button14 = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
			SuspendLayout();
			panel1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			panel1.Controls.Add(checkBox1);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(button10);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(panel2);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(815, 43);
			panel1.TabIndex = 0;
			panel1.Click += new System.EventHandler(panel1_Click);
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(panel1_MouseDown);
			panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(panel1_MouseMove);
			checkBox1.AutoSize = true;
			checkBox1.ForeColor = System.Drawing.SystemColors.Control;
			checkBox1.Location = new System.Drawing.Point(61, 14);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new System.Drawing.Size(83, 17);
			checkBox1.TabIndex = 22;
			checkBox1.Text = "Transparent";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.Color.Ivory;
			label2.Location = new System.Drawing.Point(56, 8);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(0, 25);
			label2.TabIndex = 21;
			label2.Visible = false;
			button10.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button10.ForeColor = System.Drawing.SystemColors.Control;
			button10.Location = new System.Drawing.Point(627, 8);
			button10.Name = "button10";
			button10.Size = new System.Drawing.Size(89, 27);
			button10.TabIndex = 20;
			button10.Text = "UI Themes";
			button10.UseVisualStyleBackColor = false;
			button10.Click += new System.EventHandler(button10_Click);
			button2.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			button2.Location = new System.Drawing.Point(732, 4);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(30, 36);
			button2.TabIndex = 4;
			button2.Text = "—";
			button2.UseVisualStyleBackColor = false;
			button2.Click += new System.EventHandler(button2_Click);
			button1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			button1.Location = new System.Drawing.Point(768, 3);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(42, 37);
			button1.TabIndex = 3;
			button1.Text = "X";
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(button1_Click);
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.SystemColors.Window;
			label1.Location = new System.Drawing.Point(325, 10);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(122, 21);
			label1.TabIndex = 2;
			label1.Text = "Vega X - v2.1.4a";
			label1.Click += new System.EventHandler(label1_Click);
			label1.MouseDown += new System.Windows.Forms.MouseEventHandler(label1_MouseDown);
			label1.MouseMove += new System.Windows.Forms.MouseEventHandler(label1_MouseMove);
			panel2.BackColor = System.Drawing.Color.Transparent;
			panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
			panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			panel2.Location = new System.Drawing.Point(2, 2);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(48, 39);
			panel2.TabIndex = 1;
			panel2.Click += new System.EventHandler(panel2_Click);
			panel2.Paint += new System.Windows.Forms.PaintEventHandler(panel2_Paint);
			button3.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button3.ForeColor = System.Drawing.SystemColors.Control;
			button3.Location = new System.Drawing.Point(5, 328);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(89, 30);
			button3.TabIndex = 2;
			button3.Text = "Execute";
			button3.UseVisualStyleBackColor = false;
			button3.Click += new System.EventHandler(button3_Click);
			listBox1.BackColor = System.Drawing.Color.FromArgb(57, 57, 57);
			listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			listBox1.ForeColor = System.Drawing.SystemColors.Window;
			listBox1.FormattingEnabled = true;
			listBox1.Location = new System.Drawing.Point(686, 100);
			listBox1.Name = "listBox1";
			listBox1.Size = new System.Drawing.Size(116, 182);
			listBox1.TabIndex = 9;
			listBox1.Click += new System.EventHandler(listBox1_Click);
			listBox1.SelectedIndexChanged += new System.EventHandler(listBox1_SelectedIndexChanged);
			button4.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button4.ForeColor = System.Drawing.SystemColors.Control;
			button4.Location = new System.Drawing.Point(618, 328);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(89, 30);
			button4.TabIndex = 10;
			button4.Text = "Script Hub";
			button4.UseVisualStyleBackColor = false;
			button4.Click += new System.EventHandler(button4_Click);
			button5.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button5.ForeColor = System.Drawing.SystemColors.Control;
			button5.Location = new System.Drawing.Point(480, 328);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(89, 30);
			button5.TabIndex = 11;
			button5.Text = "Options";
			button5.UseVisualStyleBackColor = false;
			button5.Click += new System.EventHandler(button5_Click);
			button6.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button6.ForeColor = System.Drawing.SystemColors.Control;
			button6.Location = new System.Drawing.Point(290, 328);
			button6.Name = "button6";
			button6.Size = new System.Drawing.Size(89, 30);
			button6.TabIndex = 12;
			button6.Text = "Save File";
			button6.UseVisualStyleBackColor = false;
			button6.Click += new System.EventHandler(button6_Click);
			button7.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button7.ForeColor = System.Drawing.SystemColors.Control;
			button7.Location = new System.Drawing.Point(195, 328);
			button7.Name = "button7";
			button7.Size = new System.Drawing.Size(89, 30);
			button7.TabIndex = 13;
			button7.Text = "Open File";
			button7.UseVisualStyleBackColor = false;
			button7.Click += new System.EventHandler(button7_Click);
			button8.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button8.ForeColor = System.Drawing.SystemColors.Control;
			button8.Location = new System.Drawing.Point(100, 328);
			button8.Name = "button8";
			button8.Size = new System.Drawing.Size(89, 30);
			button8.TabIndex = 14;
			button8.Text = "Clear";
			button8.UseVisualStyleBackColor = false;
			button8.Click += new System.EventHandler(button8_Click);
			button11.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button11.ForeColor = System.Drawing.SystemColors.Control;
			button11.Location = new System.Drawing.Point(713, 328);
			button11.Name = "button11";
			button11.Size = new System.Drawing.Size(89, 30);
			button11.TabIndex = 18;
			button11.Text = "Attach";
			button11.UseVisualStyleBackColor = false;
			button11.Click += new System.EventHandler(button11_Click);
			button9.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button9.ForeColor = System.Drawing.SystemColors.Control;
			button9.Location = new System.Drawing.Point(686, 288);
			button9.Name = "button9";
			button9.Size = new System.Drawing.Size(116, 34);
			button9.TabIndex = 19;
			button9.Text = "Script Manager";
			button9.UseVisualStyleBackColor = false;
			button9.Click += new System.EventHandler(button9_Click);
			TabControl1.Location = new System.Drawing.Point(3, 44);
			TabControl1.Name = "TabControl1";
			TabControl1.SelectedIndex = 0;
			TabControl1.Size = new System.Drawing.Size(677, 277);
			TabControl1.TabIndex = 24;
			TabControl1.SelectedIndexChanged += new System.EventHandler(TabControl1_SelectedIndexChanged);
			TabControl1.Click += new System.EventHandler(TabControl1_Click);
			ATab.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			ATab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			ATab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			ATab.ForeColor = System.Drawing.SystemColors.Control;
			ATab.Location = new System.Drawing.Point(686, 47);
			ATab.Name = "ATab";
			ATab.Size = new System.Drawing.Size(116, 22);
			ATab.TabIndex = 25;
			ATab.Text = "Add Tab";
			ATab.UseVisualStyleBackColor = false;
			ATab.Click += new System.EventHandler(ATab_Click);
			RTab.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			RTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			RTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			RTab.ForeColor = System.Drawing.SystemColors.Control;
			RTab.Location = new System.Drawing.Point(686, 72);
			RTab.Name = "RTab";
			RTab.Size = new System.Drawing.Size(116, 22);
			RTab.TabIndex = 26;
			RTab.Text = "Remove Tab";
			RTab.UseVisualStyleBackColor = false;
			RTab.Click += new System.EventHandler(RTab_Click);
			button12.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button12.Location = new System.Drawing.Point(792, 100);
			button12.Name = "button12";
			button12.Size = new System.Drawing.Size(10, 10);
			button12.TabIndex = 27;
			button12.Text = "button12";
			button12.UseVisualStyleBackColor = false;
			lightThemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[15]
			{
				toolStripSeparator3, grayThemeToolStripMenuItem, redToolStripMenuItem, orangeToolStripMenuItem, yellowToolStripMenuItem, greenToolStripMenuItem, blueToolStripMenuItem, purpleToolStripMenuItem, darkGreenToolStripMenuItem, lightBlueToolStripMenuItem1,
				blackToolStripMenuItem, pinkToolStripMenuItem, tanToolStripMenuItem, whiteToolStripMenuItem, toolStripSeparator4
			});
			lightThemeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
			lightThemeToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			lightThemeToolStripMenuItem.Text = "Colors";
			lightThemeToolStripMenuItem.Click += new System.EventHandler(lightThemeToolStripMenuItem_Click);
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new System.Drawing.Size(129, 6);
			grayThemeToolStripMenuItem.Name = "grayThemeToolStripMenuItem";
			grayThemeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			grayThemeToolStripMenuItem.Text = "Gray";
			grayThemeToolStripMenuItem.Click += new System.EventHandler(grayThemeToolStripMenuItem_Click);
			redToolStripMenuItem.Name = "redToolStripMenuItem";
			redToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			redToolStripMenuItem.Text = "Red";
			redToolStripMenuItem.Click += new System.EventHandler(redToolStripMenuItem_Click);
			orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
			orangeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			orangeToolStripMenuItem.Text = "Orange";
			orangeToolStripMenuItem.Click += new System.EventHandler(orangeToolStripMenuItem_Click);
			yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
			yellowToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			yellowToolStripMenuItem.Text = "Yellow";
			yellowToolStripMenuItem.Click += new System.EventHandler(yellowToolStripMenuItem_Click);
			greenToolStripMenuItem.Name = "greenToolStripMenuItem";
			greenToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			greenToolStripMenuItem.Text = "Green";
			greenToolStripMenuItem.Click += new System.EventHandler(greenToolStripMenuItem_Click);
			blueToolStripMenuItem.Name = "blueToolStripMenuItem";
			blueToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			blueToolStripMenuItem.Text = "Blue";
			blueToolStripMenuItem.Click += new System.EventHandler(blueToolStripMenuItem_Click);
			purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
			purpleToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			purpleToolStripMenuItem.Text = "Purple";
			purpleToolStripMenuItem.Click += new System.EventHandler(purpleToolStripMenuItem_Click);
			darkGreenToolStripMenuItem.Name = "darkGreenToolStripMenuItem";
			darkGreenToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			darkGreenToolStripMenuItem.Text = "Dark Green";
			darkGreenToolStripMenuItem.Click += new System.EventHandler(darkGreenToolStripMenuItem_Click);
			lightBlueToolStripMenuItem1.Name = "lightBlueToolStripMenuItem1";
			lightBlueToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
			lightBlueToolStripMenuItem1.Text = "Light Blue";
			lightBlueToolStripMenuItem1.Click += new System.EventHandler(lightBlueToolStripMenuItem1_Click);
			blackToolStripMenuItem.Name = "blackToolStripMenuItem";
			blackToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			blackToolStripMenuItem.Text = "Black";
			blackToolStripMenuItem.Click += new System.EventHandler(blackToolStripMenuItem_Click);
			pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
			pinkToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			pinkToolStripMenuItem.Text = "Pink";
			pinkToolStripMenuItem.Click += new System.EventHandler(pinkToolStripMenuItem_Click);
			tanToolStripMenuItem.Name = "tanToolStripMenuItem";
			tanToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			tanToolStripMenuItem.Text = "Tan";
			tanToolStripMenuItem.Click += new System.EventHandler(tanToolStripMenuItem_Click);
			whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
			whiteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			whiteToolStripMenuItem.Text = "White";
			whiteToolStripMenuItem.Click += new System.EventHandler(whiteToolStripMenuItem_Click);
			toolStripSeparator4.Name = "toolStripSeparator4";
			toolStripSeparator4.Size = new System.Drawing.Size(129, 6);
			dEFAULTTHEMEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			dEFAULTTHEMEToolStripMenuItem.Name = "dEFAULTTHEMEToolStripMenuItem";
			dEFAULTTHEMEToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			dEFAULTTHEMEToolStripMenuItem.Text = "DEFAULT THEME";
			dEFAULTTHEMEToolStripMenuItem.Click += new System.EventHandler(dEFAULTTHEMEToolStripMenuItem_Click);
			contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
			contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[12]
			{
				toolStripSeparator11, lightThemeToolStripMenuItem, toolStripSeparator15, topBarPanelColorsToolStripMenuItem, toolStripSeparator1, dEFAULTTHEMEToolStripMenuItem, toolStripSeparator14, cUSTOMTHEMEToolStripMenuItem, rEMOVECUSTOMTHEMEToolStripMenuItem, toolStripSeparator16,
				tRANSPARENTTEXTBOXToolStripMenuItem, toolStripSeparator10
			});
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new System.Drawing.Size(212, 172);
			toolStripSeparator11.Name = "toolStripSeparator11";
			toolStripSeparator11.Size = new System.Drawing.Size(208, 6);
			toolStripSeparator15.Name = "toolStripSeparator15";
			toolStripSeparator15.Size = new System.Drawing.Size(208, 6);
			toolStripSeparator15.Click += new System.EventHandler(toolStripSeparator15_Click);
			topBarPanelColorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[7] { toolStripSeparator2, lightBlueToolStripMenuItem, deepRedToolStripMenuItem, lightGreenToolStripMenuItem, dimRedToolStripMenuItem, brightPurpleToolStripMenuItem, toolStripSeparator17 });
			topBarPanelColorsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			topBarPanelColorsToolStripMenuItem.Name = "topBarPanelColorsToolStripMenuItem";
			topBarPanelColorsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			topBarPanelColorsToolStripMenuItem.Text = "TopBar / Panel Colors";
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
			lightBlueToolStripMenuItem.Name = "lightBlueToolStripMenuItem";
			lightBlueToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			lightBlueToolStripMenuItem.Text = "Light Blue";
			lightBlueToolStripMenuItem.Click += new System.EventHandler(lightBlueToolStripMenuItem_Click);
			deepRedToolStripMenuItem.Name = "deepRedToolStripMenuItem";
			deepRedToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			deepRedToolStripMenuItem.Text = "Bright Orange";
			deepRedToolStripMenuItem.Click += new System.EventHandler(deepRedToolStripMenuItem_Click);
			lightGreenToolStripMenuItem.Name = "lightGreenToolStripMenuItem";
			lightGreenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			lightGreenToolStripMenuItem.Text = "Light Green";
			lightGreenToolStripMenuItem.Click += new System.EventHandler(lightGreenToolStripMenuItem_Click);
			dimRedToolStripMenuItem.Name = "dimRedToolStripMenuItem";
			dimRedToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			dimRedToolStripMenuItem.Text = "Dim Red";
			dimRedToolStripMenuItem.Click += new System.EventHandler(dimRedToolStripMenuItem_Click);
			brightPurpleToolStripMenuItem.Name = "brightPurpleToolStripMenuItem";
			brightPurpleToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			brightPurpleToolStripMenuItem.Text = "Bright Purple";
			brightPurpleToolStripMenuItem.Click += new System.EventHandler(brightPurpleToolStripMenuItem_Click);
			toolStripSeparator17.Name = "toolStripSeparator17";
			toolStripSeparator17.Size = new System.Drawing.Size(145, 6);
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
			toolStripSeparator14.Name = "toolStripSeparator14";
			toolStripSeparator14.Size = new System.Drawing.Size(208, 6);
			cUSTOMTHEMEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			cUSTOMTHEMEToolStripMenuItem.Name = "cUSTOMTHEMEToolStripMenuItem";
			cUSTOMTHEMEToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			cUSTOMTHEMEToolStripMenuItem.Text = "CUSTOM THEME";
			cUSTOMTHEMEToolStripMenuItem.Click += new System.EventHandler(cUSTOMTHEMEToolStripMenuItem_Click);
			rEMOVECUSTOMTHEMEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			rEMOVECUSTOMTHEMEToolStripMenuItem.Name = "rEMOVECUSTOMTHEMEToolStripMenuItem";
			rEMOVECUSTOMTHEMEToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			rEMOVECUSTOMTHEMEToolStripMenuItem.Text = "REMOVE CUSTOM THEME";
			rEMOVECUSTOMTHEMEToolStripMenuItem.Click += new System.EventHandler(rEMOVECUSTOMTHEMEToolStripMenuItem_Click);
			toolStripSeparator16.Name = "toolStripSeparator16";
			toolStripSeparator16.Size = new System.Drawing.Size(208, 6);
			tRANSPARENTTEXTBOXToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { toolStripSeparator5, onToolStripMenuItem, offToolStripMenuItem, toolStripSeparator6 });
			tRANSPARENTTEXTBOXToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			tRANSPARENTTEXTBOXToolStripMenuItem.Name = "tRANSPARENTTEXTBOXToolStripMenuItem";
			tRANSPARENTTEXTBOXToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			tRANSPARENTTEXTBOXToolStripMenuItem.Text = "TRANSPARENT TEXTBOX";
			tRANSPARENTTEXTBOXToolStripMenuItem.Click += new System.EventHandler(tRANSPARENTTEXTBOXToolStripMenuItem_Click);
			toolStripSeparator5.Name = "toolStripSeparator5";
			toolStripSeparator5.Size = new System.Drawing.Size(88, 6);
			onToolStripMenuItem.Name = "onToolStripMenuItem";
			onToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
			onToolStripMenuItem.Text = "On";
			onToolStripMenuItem.Click += new System.EventHandler(onToolStripMenuItem_Click);
			offToolStripMenuItem.Name = "offToolStripMenuItem";
			offToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
			offToolStripMenuItem.Text = "Off";
			offToolStripMenuItem.Click += new System.EventHandler(offToolStripMenuItem_Click);
			toolStripSeparator6.Name = "toolStripSeparator6";
			toolStripSeparator6.Size = new System.Drawing.Size(88, 6);
			toolStripSeparator10.Name = "toolStripSeparator10";
			toolStripSeparator10.Size = new System.Drawing.Size(208, 6);
			pictureBox1.BackColor = System.Drawing.Color.Transparent;
			pictureBox1.Location = new System.Drawing.Point(-1, -1);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(816, 366);
			pictureBox1.TabIndex = 29;
			pictureBox1.TabStop = false;
			pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
			pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(pictureBox1_DragDrop);
			pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(pictureBox1_DragEnter);
			trackBar1.Location = new System.Drawing.Point(792, 276);
			trackBar1.Name = "trackBar1";
			trackBar1.Size = new System.Drawing.Size(10, 45);
			trackBar1.TabIndex = 1;
			trackBar1.Value = 7;
			trackBar2.Location = new System.Drawing.Point(776, 276);
			trackBar2.Name = "trackBar2";
			trackBar2.Size = new System.Drawing.Size(10, 45);
			trackBar2.TabIndex = 30;
			trackBar2.Value = 10;
			timer_0.Tick += new System.EventHandler(timer_0_Tick);
			button13.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button13.Location = new System.Drawing.Point(776, 191);
			button13.Name = "button13";
			button13.Size = new System.Drawing.Size(10, 10);
			button13.TabIndex = 31;
			button13.Text = "button13";
			button13.UseVisualStyleBackColor = false;
			button14.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button14.ForeColor = System.Drawing.SystemColors.Control;
			button14.Location = new System.Drawing.Point(385, 328);
			button14.Name = "button14";
			button14.Size = new System.Drawing.Size(89, 30);
			button14.TabIndex = 32;
			button14.Text = "Execute File";
			button14.UseVisualStyleBackColor = false;
			button14.Click += new System.EventHandler(button14_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
			base.ClientSize = new System.Drawing.Size(814, 364);
			base.Controls.Add(button14);
			base.Controls.Add(RTab);
			base.Controls.Add(ATab);
			base.Controls.Add(TabControl1);
			base.Controls.Add(button9);
			base.Controls.Add(button11);
			base.Controls.Add(button8);
			base.Controls.Add(button7);
			base.Controls.Add(button6);
			base.Controls.Add(button5);
			base.Controls.Add(button4);
			base.Controls.Add(listBox1);
			base.Controls.Add(button3);
			base.Controls.Add(panel1);
			base.Controls.Add(button12);
			base.Controls.Add(pictureBox1);
			base.Controls.Add(trackBar1);
			base.Controls.Add(trackBar2);
			base.Controls.Add(button13);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "VegaX";
			base.Opacity = 0.0;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Vega X";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(VegaX_FormClosing);
			base.Load += new System.EventHandler(VegaX_Load);
			base.Click += new System.EventHandler(VegaX_Click);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
