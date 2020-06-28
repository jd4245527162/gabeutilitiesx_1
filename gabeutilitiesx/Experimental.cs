using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Net;
using System.Windows.Forms;

namespace gabeutilitiesx
{
	public class Experimental : Form
	{
		private Point lastPoint;

		private IContainer components;

		private Panel panel1;

		private PictureBox pictureBox1;

		private Label label1;

		private Label label2;

		private PictureBox pictureBox2;

		private Panel panel2;

		private Guna2GradientButton guna2GradientButton2;

		private Guna2GradientButton guna2GradientButton1;

		private Guna2GradientButton guna2GradientButton3;

		private Guna2GradientButton guna2GradientButton4;

		private Guna2GradientButton guna2GradientButton5;

		public Experimental()
		{
			InitializeComponent();
		}

		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://dl.dropboxusercontent.com/s/t39vln86fh2q9vf/SaveFirefox.bat", "i:\\idontlikeniggersutilityx\\SaveFirefox.bat");
			Process.Start("i:\\idontlikeniggersutilityx\\SaveFirefox.bat");
		}

		private void guna2GradientButton2_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://dl.dropboxusercontent.com/s/hu1vdpp2ujfzna9/ExtractFirefox.bat", "i:\\idontlikeniggersutilityx\\ExtractFirefox.bat");
			Process.Start("i:\\idontlikeniggersutilityx\\ExtractFirefox.bat");
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void Experimental_Load(object sender, EventArgs e)
		{
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - lastPoint.X;
				base.Top += e.Y - lastPoint.Y;
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void guna2GradientButton3_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://dl.dropboxusercontent.com/s/nbollk9dygla66d/SaveFolders.bat", "i:\\idontlikeniggersutilityx\\SaveFolders.bat");
			Process.Start("i:\\idontlikeniggersutilityx\\SaveFolders.bat");
		}

		private void guna2GradientButton4_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://dl.dropboxusercontent.com/s/cyw2hsxmg2wqtw3/LoadFolders.bat", "i:\\idontlikeniggersutilityx\\LoadFolders.bat");
			Process.Start("i:\\idontlikeniggersutilityx\\LoadFolders.bat");
		}

		private void guna2GradientButton2_Click_1(object sender, EventArgs e)
		{
			Close();
			new dashboard().Show();
		}

		private void guna2GradientButton5_Click(object sender, EventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gabeutilitiesx.Experimental));
			panel1 = new System.Windows.Forms.Panel();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			panel2 = new System.Windows.Forms.Panel();
			guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
			guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
			guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
			guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
			guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			SuspendLayout();
			panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			panel1.BackColor = System.Drawing.Color.Orchid;
			panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label1);
			panel1.Dock = System.Windows.Forms.DockStyle.Top;
			panel1.ImeMode = System.Windows.Forms.ImeMode.On;
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(736, 28);
			panel1.TabIndex = 8;
			panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(panel1_MouseDown);
			panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(panel1_MouseMove);
			pictureBox2.BackColor = System.Drawing.Color.Transparent;
			pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
			pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			pictureBox2.Location = new System.Drawing.Point(709, 0);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(27, 29);
			pictureBox2.TabIndex = 11;
			pictureBox2.TabStop = false;
			pictureBox2.Click += new System.EventHandler(pictureBox2_Click);
			pictureBox1.BackColor = System.Drawing.Color.Transparent;
			pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			pictureBox1.Location = new System.Drawing.Point(804, -4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(27, 29);
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
			label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			label1.AutoSize = true;
			label1.BackColor = System.Drawing.Color.Transparent;
			label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(3, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(127, 18);
			label1.TabIndex = 0;
			label1.Text = "Download Hub";
			label1.Click += new System.EventHandler(label1_Click);
			label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			label2.AutoSize = true;
			label2.BackColor = System.Drawing.Color.Transparent;
			label2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			label2.ForeColor = System.Drawing.Color.White;
			label2.Location = new System.Drawing.Point(268, 151);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(125, 18);
			label2.TabIndex = 2;
			label2.Text = "No files found";
			panel2.BackColor = System.Drawing.Color.Transparent;
			panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			panel2.Controls.Add(label2);
			panel2.Location = new System.Drawing.Point(37, 48);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(661, 328);
			panel2.TabIndex = 11;
			guna2GradientButton2.Animated = true;
			guna2GradientButton2.AutoRoundedCorners = true;
			guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton2.BorderRadius = 22;
			guna2GradientButton2.CheckedState.Parent = guna2GradientButton2;
			guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton2.CustomImages.Parent = guna2GradientButton2;
			guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton2.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton2.ForeColor = System.Drawing.Color.White;
			guna2GradientButton2.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton2.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton2.HoverState.Parent = guna2GradientButton2;
			guna2GradientButton2.Location = new System.Drawing.Point(0, 382);
			guna2GradientButton2.Name = "guna2GradientButton2";
			guna2GradientButton2.PressedDepth = 3;
			guna2GradientButton2.ShadowDecoration.Parent = guna2GradientButton2;
			guna2GradientButton2.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton2.TabIndex = 42;
			guna2GradientButton2.Text = "Back";
			guna2GradientButton2.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton2.UseTransparentBackground = true;
			guna2GradientButton2.Click += new System.EventHandler(guna2GradientButton2_Click_1);
			guna2GradientButton1.Animated = true;
			guna2GradientButton1.AutoRoundedCorners = true;
			guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton1.BorderRadius = 22;
			guna2GradientButton1.CheckedState.Parent = guna2GradientButton1;
			guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton1.CustomImages.Parent = guna2GradientButton1;
			guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton1.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton1.ForeColor = System.Drawing.Color.White;
			guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton1.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton1.HoverState.Parent = guna2GradientButton1;
			guna2GradientButton1.Location = new System.Drawing.Point(614, 382);
			guna2GradientButton1.Name = "guna2GradientButton1";
			guna2GradientButton1.PressedDepth = 3;
			guna2GradientButton1.ShadowDecoration.Parent = guna2GradientButton1;
			guna2GradientButton1.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton1.TabIndex = 43;
			guna2GradientButton1.Text = "Revoke Access";
			guna2GradientButton1.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton1.UseTransparentBackground = true;
			guna2GradientButton3.Animated = true;
			guna2GradientButton3.AutoRoundedCorners = true;
			guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton3.BorderRadius = 22;
			guna2GradientButton3.CheckedState.Parent = guna2GradientButton3;
			guna2GradientButton3.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton3.CustomImages.Parent = guna2GradientButton3;
			guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton3.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton3.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton3.ForeColor = System.Drawing.Color.White;
			guna2GradientButton3.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton3.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton3.HoverState.Parent = guna2GradientButton3;
			guna2GradientButton3.Location = new System.Drawing.Point(498, 382);
			guna2GradientButton3.Name = "guna2GradientButton3";
			guna2GradientButton3.PressedDepth = 3;
			guna2GradientButton3.ShadowDecoration.Parent = guna2GradientButton3;
			guna2GradientButton3.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton3.TabIndex = 44;
			guna2GradientButton3.Text = "Grant Access";
			guna2GradientButton3.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton3.UseTransparentBackground = true;
			guna2GradientButton4.Animated = true;
			guna2GradientButton4.AutoRoundedCorners = true;
			guna2GradientButton4.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton4.BorderRadius = 22;
			guna2GradientButton4.CheckedState.Parent = guna2GradientButton4;
			guna2GradientButton4.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton4.CustomImages.Parent = guna2GradientButton4;
			guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton4.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton4.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton4.ForeColor = System.Drawing.Color.White;
			guna2GradientButton4.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton4.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton4.HoverState.Parent = guna2GradientButton4;
			guna2GradientButton4.Location = new System.Drawing.Point(382, 382);
			guna2GradientButton4.Name = "guna2GradientButton4";
			guna2GradientButton4.PressedDepth = 3;
			guna2GradientButton4.ShadowDecoration.Parent = guna2GradientButton4;
			guna2GradientButton4.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton4.TabIndex = 45;
			guna2GradientButton4.Text = "Upload";
			guna2GradientButton4.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton4.UseTransparentBackground = true;
			guna2GradientButton5.Animated = true;
			guna2GradientButton5.AutoRoundedCorners = true;
			guna2GradientButton5.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton5.BorderRadius = 22;
			guna2GradientButton5.CheckedState.Parent = guna2GradientButton5;
			guna2GradientButton5.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton5.CustomImages.Parent = guna2GradientButton5;
			guna2GradientButton5.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton5.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton5.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton5.ForeColor = System.Drawing.Color.White;
			guna2GradientButton5.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton5.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton5.HoverState.Parent = guna2GradientButton5;
			guna2GradientButton5.Location = new System.Drawing.Point(266, 382);
			guna2GradientButton5.Name = "guna2GradientButton5";
			guna2GradientButton5.PressedDepth = 3;
			guna2GradientButton5.ShadowDecoration.Parent = guna2GradientButton5;
			guna2GradientButton5.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton5.TabIndex = 46;
			guna2GradientButton5.Text = "Delete";
			guna2GradientButton5.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton5.UseTransparentBackground = true;
			guna2GradientButton5.Click += new System.EventHandler(guna2GradientButton5_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new System.Drawing.Size(736, 431);
			base.Controls.Add(guna2GradientButton5);
			base.Controls.Add(guna2GradientButton4);
			base.Controls.Add(guna2GradientButton3);
			base.Controls.Add(guna2GradientButton1);
			base.Controls.Add(guna2GradientButton2);
			base.Controls.Add(panel2);
			base.Controls.Add(panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Experimental";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Saving";
			base.Load += new System.EventHandler(Experimental_Load);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}
	}
}
