using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace ns0
{
	public class UserControl1 : UserControl
	{
		private IContainer icontainer_0 = null;

		private FastColoredTextBox fastColoredTextBox1;

		private ContextMenuStrip contextMenuStrip1;

		public UserControl1()
		{
			InitializeComponent();
		}

		private void fastColoredTextBox1_Load(object sender, EventArgs e)
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
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Expected O, but got Unknown
			icontainer_0 = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns0.UserControl1));
			fastColoredTextBox1 = new FastColoredTextBox();
			contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(icontainer_0);
			((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).BeginInit();
			SuspendLayout();
			fastColoredTextBox1.set_AutoCompleteBracketsList(new char[10] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
			fastColoredTextBox1.set_AutoIndentCharsPatterns("\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n");
			fastColoredTextBox1.set_AutoScrollMinSize(new System.Drawing.Size(675, 126));
			fastColoredTextBox1.set_BackBrush((System.Drawing.Brush)null);
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
			fastColoredTextBox1.set_BracketsHighlightStrategy((BracketsHighlightStrategy)1);
			fastColoredTextBox1.set_CharHeight(14);
			fastColoredTextBox1.set_CharWidth(8);
			fastColoredTextBox1.set_CommentPrefix("--");
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).Cursor = System.Windows.Forms.Cursors.IBeam;
			fastColoredTextBox1.set_DisabledColor(System.Drawing.Color.FromArgb(100, 180, 180, 180));
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).Dock = System.Windows.Forms.DockStyle.Fill;
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).Font = new System.Drawing.Font("Courier New", 9.75f);
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).ForeColor = System.Drawing.Color.White;
			fastColoredTextBox1.set_IndentBackColor(System.Drawing.Color.FromArgb(45, 45, 45));
			fastColoredTextBox1.set_IsReplaceMode(false);
			fastColoredTextBox1.set_Language((Language)8);
			fastColoredTextBox1.set_LeftBracket('(');
			fastColoredTextBox1.set_LeftBracket2('{');
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).Location = new System.Drawing.Point(0, 0);
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).Name = "fastColoredTextBox1";
			fastColoredTextBox1.set_Paddings(new System.Windows.Forms.Padding(0));
			fastColoredTextBox1.set_RightBracket(')');
			fastColoredTextBox1.set_RightBracket2('}');
			fastColoredTextBox1.set_SelectionColor(System.Drawing.Color.FromArgb(60, 0, 0, 255));
			fastColoredTextBox1.set_ServiceColors((ServiceColors)resources.GetObject("fastColoredTextBox1.ServiceColors"));
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).Size = new System.Drawing.Size(669, 251);
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).TabIndex = 24;
			((System.Windows.Forms.Control)(object)fastColoredTextBox1).Text = resources.GetString("fastColoredTextBox1.Text");
			fastColoredTextBox1.set_Zoom(100);
			((System.Windows.Forms.UserControl)(object)fastColoredTextBox1).Load += new System.EventHandler(fastColoredTextBox1_Load);
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add((System.Windows.Forms.Control)(object)fastColoredTextBox1);
			base.Name = "UserControl1";
			base.Size = new System.Drawing.Size(669, 251);
			((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).EndInit();
			ResumeLayout(false);
		}
	}
}
