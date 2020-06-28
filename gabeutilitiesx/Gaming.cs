using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace gabeutilitiesx
{
	public class Gaming : Form
	{
		private Point lastPoint;

		private IContainer components;

		private Panel panel1;

		private Label label1;

		private Guna2GradientButton guna2GradientButton4;

		private PictureBox pictureBox8;

		private PictureBox pictureBox7;

		private Guna2GradientButton guna2GradientButton9;

		private Guna2GradientButton guna2GradientButton1;

		private PictureBox pictureBox3;

		private Guna2GradientButton guna2GradientButton2;

		private PictureBox pictureBox1;

		private Guna2GradientButton guna2GradientButton3;

		private PictureBox pictureBox2;

		public Gaming()
		{
			InitializeComponent();
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - lastPoint.X;
				base.Top += e.Y - lastPoint.Y;
			}
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void guna2GradientButton4_Click(object sender, EventArgs e)
		{
			Close();
			new dashboard().Show();
		}

		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://launcher.mojang.com/download/Minecraft.exe", "b:\\idontlikeniggers\\Minceraft.exe");
			Process.Start("B:\\\\idontlikeniggers\\\\Minceraft.exe");
		}

		private void guna2GradientButton9_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://picteon.dev/files/TwitchStudioSetup.exe", "b:\\idontlikeniggers\\Twitch-1.exe");
			Process.Start("B:\\\\idontlikeniggers\\\\Twitch-1.exe");
		}

		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			Close();
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			if (Directory.Exists("c:\\Users\\kiosk\\AppData\\Roaming\\.minecraft"))
			{
				new MinecraftOptions().Show();
			}
			else
			{
				MessageBox.Show("Install Minecraft first to enable options");
			}
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void pictureBox1_Click_2(object sender, EventArgs e)
		{
		}

		private void guna2GradientButton2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not implemented");
		}

		private void guna2GradientButton3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not implemented");
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gabeutilitiesx.Gaming));
			panel1 = new System.Windows.Forms.Panel();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			label1 = new System.Windows.Forms.Label();
			guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox8 = new System.Windows.Forms.PictureBox();
			pictureBox7 = new System.Windows.Forms.PictureBox();
			guna2GradientButton9 = new Guna.UI2.WinForms.Guna2GradientButton();
			guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
			guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			panel1.BackColor = System.Drawing.Color.Orchid;
			panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			panel1.Controls.Add(pictureBox3);
			panel1.Controls.Add(label1);
			panel1.Dock = System.Windows.Forms.DockStyle.Top;
			panel1.ImeMode = System.Windows.Forms.ImeMode.On;
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(800, 28);
			panel1.TabIndex = 2;
			panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(panel1_MouseDown);
			panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(panel1_MouseMove);
			pictureBox3.BackColor = System.Drawing.Color.Transparent;
			pictureBox3.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox3.BackgroundImage");
			pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			pictureBox3.Location = new System.Drawing.Point(770, 0);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new System.Drawing.Size(27, 29);
			pictureBox3.TabIndex = 49;
			pictureBox3.TabStop = false;
			pictureBox3.Click += new System.EventHandler(pictureBox3_Click);
			label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			label1.AutoSize = true;
			label1.BackColor = System.Drawing.Color.Transparent;
			label1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(8, 6);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(84, 22);
			label1.TabIndex = 0;
			label1.Text = "Gaming";
			guna2GradientButton4.Animated = true;
			guna2GradientButton4.AutoRoundedCorners = true;
			guna2GradientButton4.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton4.BorderRadius = 22;
			guna2GradientButton4.CheckedState.Parent = guna2GradientButton4;
			guna2GradientButton4.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton4.CustomImages.Parent = guna2GradientButton4;
			guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton4.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton4.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 11.25f, System.Drawing.FontStyle.Bold);
			guna2GradientButton4.ForeColor = System.Drawing.Color.White;
			guna2GradientButton4.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton4.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton4.HoverState.Parent = guna2GradientButton4;
			guna2GradientButton4.Location = new System.Drawing.Point(12, 391);
			guna2GradientButton4.Name = "guna2GradientButton4";
			guna2GradientButton4.PressedDepth = 3;
			guna2GradientButton4.ShadowDecoration.Parent = guna2GradientButton4;
			guna2GradientButton4.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton4.TabIndex = 45;
			guna2GradientButton4.Text = "Back";
			guna2GradientButton4.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton4.UseTransparentBackground = true;
			guna2GradientButton4.Click += new System.EventHandler(guna2GradientButton4_Click);
			pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox8.BackColor = System.Drawing.Color.Transparent;
			pictureBox8.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox8.BackgroundImage");
			pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox8.Location = new System.Drawing.Point(26, 50);
			pictureBox8.Name = "pictureBox8";
			pictureBox8.Size = new System.Drawing.Size(110, 69);
			pictureBox8.TabIndex = 19;
			pictureBox8.TabStop = false;
			pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox7.BackColor = System.Drawing.Color.Transparent;
			pictureBox7.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox7.BackgroundImage");
			pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox7.Location = new System.Drawing.Point(142, 50);
			pictureBox7.Name = "pictureBox7";
			pictureBox7.Size = new System.Drawing.Size(110, 69);
			pictureBox7.TabIndex = 46;
			pictureBox7.TabStop = false;
			pictureBox7.Click += new System.EventHandler(pictureBox7_Click);
			guna2GradientButton9.Animated = true;
			guna2GradientButton9.AutoRoundedCorners = true;
			guna2GradientButton9.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton9.BorderRadius = 22;
			guna2GradientButton9.CheckedState.Parent = guna2GradientButton9;
			guna2GradientButton9.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton9.CustomImages.Parent = guna2GradientButton9;
			guna2GradientButton9.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton9.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton9.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton9.ForeColor = System.Drawing.Color.White;
			guna2GradientButton9.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton9.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton9.HoverState.Parent = guna2GradientButton9;
			guna2GradientButton9.Location = new System.Drawing.Point(26, 125);
			guna2GradientButton9.Name = "guna2GradientButton9";
			guna2GradientButton9.PressedDepth = 3;
			guna2GradientButton9.ShadowDecoration.Parent = guna2GradientButton9;
			guna2GradientButton9.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton9.TabIndex = 47;
			guna2GradientButton9.Text = "Twitch Studio";
			guna2GradientButton9.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton9.UseTransparentBackground = true;
			guna2GradientButton9.Click += new System.EventHandler(guna2GradientButton9_Click);
			guna2GradientButton1.Animated = true;
			guna2GradientButton1.AutoRoundedCorners = true;
			guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton1.BorderRadius = 22;
			guna2GradientButton1.CheckedState.Parent = guna2GradientButton1;
			guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton1.CustomImages.Parent = guna2GradientButton1;
			guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton1.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton1.ForeColor = System.Drawing.Color.White;
			guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton1.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton1.HoverState.Parent = guna2GradientButton1;
			guna2GradientButton1.Location = new System.Drawing.Point(142, 125);
			guna2GradientButton1.Name = "guna2GradientButton1";
			guna2GradientButton1.PressedDepth = 3;
			guna2GradientButton1.ShadowDecoration.Parent = guna2GradientButton1;
			guna2GradientButton1.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton1.TabIndex = 48;
			guna2GradientButton1.Text = "Minecraft";
			guna2GradientButton1.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton1.UseTransparentBackground = true;
			guna2GradientButton1.Click += new System.EventHandler(guna2GradientButton1_Click);
			guna2GradientButton2.Animated = true;
			guna2GradientButton2.AutoRoundedCorners = true;
			guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton2.BorderRadius = 22;
			guna2GradientButton2.CheckedState.Parent = guna2GradientButton2;
			guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton2.CustomImages.Parent = guna2GradientButton2;
			guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton2.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton2.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton2.ForeColor = System.Drawing.Color.White;
			guna2GradientButton2.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton2.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton2.HoverState.Parent = guna2GradientButton2;
			guna2GradientButton2.Location = new System.Drawing.Point(258, 125);
			guna2GradientButton2.Name = "guna2GradientButton2";
			guna2GradientButton2.PressedDepth = 3;
			guna2GradientButton2.ShadowDecoration.Parent = guna2GradientButton2;
			guna2GradientButton2.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton2.TabIndex = 50;
			guna2GradientButton2.Text = "Battle.net";
			guna2GradientButton2.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton2.UseTransparentBackground = true;
			guna2GradientButton2.Click += new System.EventHandler(guna2GradientButton2_Click);
			pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox1.BackColor = System.Drawing.Color.Transparent;
			pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox1.Location = new System.Drawing.Point(258, 50);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(110, 69);
			pictureBox1.TabIndex = 49;
			pictureBox1.TabStop = false;
			pictureBox1.Click += new System.EventHandler(pictureBox1_Click_2);
			guna2GradientButton3.Animated = true;
			guna2GradientButton3.AutoRoundedCorners = true;
			guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton3.BorderRadius = 22;
			guna2GradientButton3.CheckedState.Parent = guna2GradientButton3;
			guna2GradientButton3.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton3.CustomImages.Parent = guna2GradientButton3;
			guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton3.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton3.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton3.ForeColor = System.Drawing.Color.White;
			guna2GradientButton3.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton3.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton3.HoverState.Parent = guna2GradientButton3;
			guna2GradientButton3.Location = new System.Drawing.Point(374, 125);
			guna2GradientButton3.Name = "guna2GradientButton3";
			guna2GradientButton3.PressedDepth = 3;
			guna2GradientButton3.ShadowDecoration.Parent = guna2GradientButton3;
			guna2GradientButton3.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton3.TabIndex = 52;
			guna2GradientButton3.Text = "Epic Games";
			guna2GradientButton3.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton3.UseTransparentBackground = true;
			guna2GradientButton3.Click += new System.EventHandler(guna2GradientButton3_Click);
			pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox2.BackColor = System.Drawing.Color.Transparent;
			pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
			pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox2.Location = new System.Drawing.Point(374, 50);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(110, 69);
			pictureBox2.TabIndex = 51;
			pictureBox2.TabStop = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			base.ClientSize = new System.Drawing.Size(800, 450);
			base.Controls.Add(guna2GradientButton3);
			base.Controls.Add(pictureBox2);
			base.Controls.Add(guna2GradientButton2);
			base.Controls.Add(pictureBox1);
			base.Controls.Add(guna2GradientButton1);
			base.Controls.Add(guna2GradientButton9);
			base.Controls.Add(pictureBox7);
			base.Controls.Add(pictureBox8);
			base.Controls.Add(guna2GradientButton4);
			base.Controls.Add(panel1);
			DoubleBuffered = true;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Gaming";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Gaming";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}
	}
}
