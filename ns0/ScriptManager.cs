using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeAreDevs_API;

namespace ns0
{
	public class ScriptManager : Form
	{
		private ExploitAPI exploitAPI_0 = new ExploitAPI();

		private DataTable dataTable_0;

		private Point point_0;

		private IContainer icontainer_0 = null;

		private Panel panel1;

		private Label label2;

		private Label label1;

		private Panel panel2;

		private Button button107;

		private Button button2;

		private DataGridView dataGridView1;

		private RichTextBox richTextBox2;

		private Button button8;

		private Button button1;

		private Button button3;

		private Button button4;

		private Label label3;

		private Label label4;

		private RichTextBox richTextBox1;

		private Button button5;

		private Button button6;

		private Label label5;

		private Label label6;

		private Button button7;

		private Button button9;

		public ScriptManager()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			InitializeComponent();
		}

		private void ScriptManager_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
			dataTable_0 = new DataTable();
			dataTable_0.Columns.Add("Title", typeof(string));
			dataTable_0.Columns.Add("Scripts", typeof(string));
			dataGridView1.DataSource = dataTable_0;
			dataGridView1.Columns["Scripts"].Visible = false;
		}

		private void label6_Click(object sender, EventArgs e)
		{
		}

		private void button8_Click(object sender, EventArgs e)
		{
			dataTable_0.Rows.Add(richTextBox1.Text, richTextBox2.Text);
			richTextBox1.Clear();
			richTextBox2.Clear();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("uŏȿ\u036bѮչػݮ\u0871ॽ\u0a37\u0b65\u0c76൦\u0e7aརၥᄰቢ፯ᑣᕭᙬᝯ\u187b\u1924ᨧ᭠ᱬᵶṰὶ‡Ⅱ⊛⎚ⓝ▝⛛⟐⢪⦻⪥⮿ⲥⶠ⻓⾦ジㆤ㊣㎫㓇㗌㚊㞄㢍㧈㪆㯆㳏㶷㺠㾰䂨䆰䊋䏴䓳䗼䚏䞲䢼䦶䫷䮦䲧䶱亠価僱出劜厏咛喉囡埤壩妑媨害岷巤庰御悳憩拏揊撝旋曒柖棕榘櫄毗泃淑溓濆烞熐狛珆瓈疌皁矹磪秺竮篶糱綄绯翫胲致芵莰蒽藈蛴螺裫觽諣诤購跱軥迷邱釱銯鏽铮闾離韺飽馤骧鯵鳠鷨黦\u9fe1ꃵꆠꈖꌊꑝꔚꘉ\ua715ꠔ\ua958ꨃ\uab1e감굔깙꼡뀲넢눦댾됹때똧뜣렺뤼멍뭆밄봊븇뽂쀑섒숺쌭쐮야옯윲젼쥸쩽쬙찅촑츝콲퀂턓툝팇퐝픘홡흪\ud82b\ud93d\uda33\udb32\udc2a\udd2a\ude6d\udf62\ue015\ue128\ue25a\ue350\ue41d\ue545\ue654\ue74f\ue819\ue95b\uea56\ueb58\uec15\ued51\uee4b\uef57\uf052\uf145\uf25b\uf34b\uf40d\uf545\uf65f\uf70a\uf85e論禎פֿﰅﵐ﹋ｇ\u0001Ċɚ\u0346ј՟\u064eݎ\u085cस\u0a44\u0b55\u0c47\u0d5dใཆ\u103bᄰቭ፻ᑹᕸᙤᝤᠧ\u1928ᩂ᭨ᱯᵫṺἣ‡");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			exploitAPI_0.SendLuaScript(richTextBox2.Text);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			using Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew);
			using StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.Write(richTextBox2.Text);
		}

		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			richTextBox2.Clear();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			int rowIndex = dataGridView1.CurrentCell.RowIndex;
			if (rowIndex > -1)
			{
				richTextBox1.Text = dataTable_0.Rows[rowIndex].ItemArray[0].ToString();
				richTextBox2.Text = dataTable_0.Rows[rowIndex].ItemArray[1].ToString();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int rowIndex = dataGridView1.CurrentCell.RowIndex;
			dataTable_0.Rows[rowIndex].Delete();
		}

		private void button107_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
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

		private void button9_Click(object sender, EventArgs e)
		{
			exploitAPI_0.LaunchExploit();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns0.ScriptManager));
			panel1 = new System.Windows.Forms.Panel();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			panel2 = new System.Windows.Forms.Panel();
			button107 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			dataGridView1 = new System.Windows.Forms.DataGridView();
			richTextBox2 = new System.Windows.Forms.RichTextBox();
			button8 = new System.Windows.Forms.Button();
			button1 = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			button4 = new System.Windows.Forms.Button();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			richTextBox1 = new System.Windows.Forms.RichTextBox();
			button5 = new System.Windows.Forms.Button();
			button6 = new System.Windows.Forms.Button();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			button7 = new System.Windows.Forms.Button();
			button9 = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			panel1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			panel1.Controls.Add(button107);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(panel2);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(779, 44);
			panel1.TabIndex = 1;
			panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(panel1_MouseDown);
			panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(panel1_MouseMove);
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.Color.Ivory;
			label2.Location = new System.Drawing.Point(56, 8);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(0, 25);
			label2.TabIndex = 21;
			label2.Visible = false;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.SystemColors.Window;
			label1.Location = new System.Drawing.Point(309, 11);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(186, 21);
			label1.TabIndex = 2;
			label1.Text = "Vega X - Script Manager";
			panel2.BackColor = System.Drawing.Color.Transparent;
			panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
			panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			panel2.Location = new System.Drawing.Point(2, 2);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(48, 39);
			panel2.TabIndex = 1;
			button107.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button107.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button107.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button107.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button107.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			button107.Location = new System.Drawing.Point(744, 8);
			button107.Name = "button107";
			button107.Size = new System.Drawing.Size(30, 27);
			button107.TabIndex = 23;
			button107.Text = "X";
			button107.UseVisualStyleBackColor = false;
			button107.Click += new System.EventHandler(button107_Click);
			button2.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
			button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			button2.Location = new System.Drawing.Point(711, 8);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(30, 27);
			button2.TabIndex = 22;
			button2.Text = "—";
			button2.UseVisualStyleBackColor = false;
			button2.Click += new System.EventHandler(button2_Click);
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new System.Drawing.Point(511, 108);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.Size = new System.Drawing.Size(246, 240);
			dataGridView1.TabIndex = 5;
			richTextBox2.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
			richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			richTextBox2.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			richTextBox2.ForeColor = System.Drawing.Color.ForestGreen;
			richTextBox2.Location = new System.Drawing.Point(135, 144);
			richTextBox2.Name = "richTextBox2";
			richTextBox2.Size = new System.Drawing.Size(350, 204);
			richTextBox2.TabIndex = 137;
			richTextBox2.Text = "-- Paste Your Script Here";
			richTextBox2.TextChanged += new System.EventHandler(richTextBox2_TextChanged);
			button8.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button8.ForeColor = System.Drawing.SystemColors.Control;
			button8.Location = new System.Drawing.Point(135, 354);
			button8.Name = "button8";
			button8.Size = new System.Drawing.Size(83, 30);
			button8.TabIndex = 138;
			button8.Text = "Save";
			button8.UseVisualStyleBackColor = false;
			button8.Click += new System.EventHandler(button8_Click);
			button1.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.ForeColor = System.Drawing.SystemColors.Control;
			button1.Location = new System.Drawing.Point(402, 354);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(83, 30);
			button1.TabIndex = 139;
			button1.Text = "Clear";
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(button1_Click);
			button3.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button3.ForeColor = System.Drawing.SystemColors.Control;
			button3.Location = new System.Drawing.Point(313, 354);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(83, 30);
			button3.TabIndex = 140;
			button3.Text = "File";
			button3.UseVisualStyleBackColor = false;
			button3.Click += new System.EventHandler(button3_Click);
			button4.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button4.ForeColor = System.Drawing.SystemColors.Control;
			button4.Location = new System.Drawing.Point(224, 354);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(83, 30);
			button4.TabIndex = 141;
			button4.Text = "Execute";
			button4.UseVisualStyleBackColor = false;
			button4.Click += new System.EventHandler(button4_Click);
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.SystemColors.Window;
			label3.Location = new System.Drawing.Point(50, 104);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(68, 32);
			label3.TabIndex = 24;
			label3.Text = "Title:";
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label4.ForeColor = System.Drawing.SystemColors.Window;
			label4.Location = new System.Drawing.Point(35, 144);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(83, 32);
			label4.TabIndex = 142;
			label4.Text = "Script:";
			richTextBox1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
			richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			richTextBox1.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			richTextBox1.ForeColor = System.Drawing.Color.ForestGreen;
			richTextBox1.Location = new System.Drawing.Point(135, 108);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			richTextBox1.Size = new System.Drawing.Size(350, 28);
			richTextBox1.TabIndex = 143;
			richTextBox1.Text = "-- Script Name Here";
			button5.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button5.ForeColor = System.Drawing.SystemColors.Control;
			button5.Location = new System.Drawing.Point(644, 354);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(113, 30);
			button5.TabIndex = 144;
			button5.Text = "Delete Script";
			button5.UseVisualStyleBackColor = false;
			button5.Click += new System.EventHandler(button5_Click);
			button6.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button6.ForeColor = System.Drawing.SystemColors.Control;
			button6.Location = new System.Drawing.Point(511, 354);
			button6.Name = "button6";
			button6.Size = new System.Drawing.Size(127, 30);
			button6.TabIndex = 145;
			button6.Text = "Open Script";
			button6.UseVisualStyleBackColor = false;
			button6.Click += new System.EventHandler(button6_Click);
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label5.ForeColor = System.Drawing.SystemColors.Window;
			label5.Location = new System.Drawing.Point(212, 65);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(182, 32);
			label5.TabIndex = 146;
			label5.Text = "Script Manager";
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label6.ForeColor = System.Drawing.SystemColors.Window;
			label6.Location = new System.Drawing.Point(574, 66);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(121, 32);
			label6.TabIndex = 147;
			label6.Text = "Script List";
			label6.Click += new System.EventHandler(label6_Click);
			button7.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button7.ForeColor = System.Drawing.SystemColors.Control;
			button7.Location = new System.Drawing.Point(22, 318);
			button7.Name = "button7";
			button7.Size = new System.Drawing.Size(96, 66);
			button7.TabIndex = 148;
			button7.Text = "How To Use The Script Manager";
			button7.UseVisualStyleBackColor = false;
			button7.Click += new System.EventHandler(button7_Click);
			button9.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
			button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
			button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button9.ForeColor = System.Drawing.SystemColors.Control;
			button9.Location = new System.Drawing.Point(22, 267);
			button9.Name = "button9";
			button9.Size = new System.Drawing.Size(96, 45);
			button9.TabIndex = 149;
			button9.Text = "Attach";
			button9.UseVisualStyleBackColor = false;
			button9.Click += new System.EventHandler(button9_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
			base.ClientSize = new System.Drawing.Size(780, 404);
			base.Controls.Add(button9);
			base.Controls.Add(button7);
			base.Controls.Add(label6);
			base.Controls.Add(label5);
			base.Controls.Add(button6);
			base.Controls.Add(button5);
			base.Controls.Add(richTextBox1);
			base.Controls.Add(label4);
			base.Controls.Add(label3);
			base.Controls.Add(button4);
			base.Controls.Add(button3);
			base.Controls.Add(button1);
			base.Controls.Add(button8);
			base.Controls.Add(richTextBox2);
			base.Controls.Add(dataGridView1);
			base.Controls.Add(panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "ScriptManager";
			Text = "ScriptManager";
			base.Load += new System.EventHandler(ScriptManager_Load);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
