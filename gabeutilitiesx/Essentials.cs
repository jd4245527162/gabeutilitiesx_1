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
	public class Essentials : Form
	{
		private Point lastPoint;

		private IContainer components;

		private Panel panel1;

		private Label label1;

		private PictureBox pictureBox5;

		private Guna2GradientButton guna2GradientButton9;

		private PictureBox pictureBox4;

		private Guna2GradientButton guna2GradientButton1;

		private PictureBox pictureBox2;

		private Guna2GradientButton guna2GradientButton2;

		private PictureBox pictureBox9;

		private Guna2GradientButton guna2GradientButton3;

		private Guna2GradientButton guna2GradientButton4;

		private PictureBox pictureBox3;

		private Guna2GradientButton guna2GradientButton5;

		private PictureBox pictureBox1;

		private Guna2GradientButton guna2GradientButton6;

		private PictureBox pictureBox6;

		private PictureBox pictureBox7;

		private Guna2GradientButton guna2GradientButton7;

		private Guna2GradientButton guna2GradientButton8;

		private PictureBox pictureBox8;

		public Essentials()
		{
			InitializeComponent();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
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

		private void guna2GradientButton9_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/qs28nio8mjnsgyz/fdgdfgfghgf.exe", "b:\\idontlikeniggers\\idontlikeniggers.exe");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/d2m2xhrrsijqql4/7z.dll", "b:\\idontlikeniggers\\7z.dll");
			Process.Start("B:\\\\idontlikeniggers\\\\idontlikeniggers.exe");
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
		}

		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://dl.discordapp.net/apps/win/0.0.306/DiscordSetup.exe", "b:\\idontlikeniggers\\dsicord.exe");
			Process.Start("b:\\\\idontlikeniggers\\\\dsicord.exe");
		}

		private void guna2GradientButton2_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/olfabfupaxduy6p/Firefox.zip", "b:\\idontlikeniggers\\Firefox.zip");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/uip3o05lxavunb7/ConsoleHelper3.bat", "b:\\idontlikeniggers\\ConsoleHelper3.bat");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/mboz56tx1vpa6qu/ConsoleHelper4.bat", "b:\\idontlikeniggers\\ConsoleHelper4.bat");
			Process.Start("B:\\\\idontlikeniggers\\\\ConsoleHelper3.bat");
			Process.Start("B:\\\\idontlikeniggers\\\\ConsoleHelper4.bat");
		}

		private void guna2GradientButton3_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/599361190291832832/698232081678991371/explorer.zip", "b:\\idontlikeniggers\\explorer.zip");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/l8pgl2ooiucxfrl/ConsoleHelper1.bat", "b:\\idontlikeniggers\\ConsoleHelper1.bat");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/sho6jwyi6jvc06k/ConsoleHelper2.bat", "b:\\idontlikeniggers\\ConsoleHelper2.bat");
			Process.Start("B:\\\\idontlikeniggers\\\\ConsoleHelper1.bat");
			Process.Start("B:\\\\idontlikeniggers\\\\ConsoleHelper2.bat");
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

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void guna2GradientButton5_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://cdn-01.anonfiles.com/rc1eI0A0ob/f9909bc6-1592441887/purcasshakor.exe", "b:\\idontlikeniggers\\purcasshakor.exe");
			Process.Start("b:\\\\idontlikeniggers\\\\purcasshakor.exe");
		}

		private void guna2GradientButton7_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/722995893858730066/HxD.exe", "b:\\idontlikeniggers\\haxd.exe");
			Process.Start("b:\\\\idontlikeniggers\\\\haxd.exe");
		}

		private void guna2GradientButton6_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/722995919062171698/Notepad2x64.exe", "b:\\idontlikeniggers\\notpade.exe");
			Process.Start("b:\\\\idontlikeniggers\\\\notpade.exe");
		}

		private void guna2GradientButton8_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/722998499322363914/Explorer.exe", "b:\\idontlikeniggers\\Exploraae.exe");
			Process.Start("b:\\\\idontlikeniggers\\\\Exploraae.exe");
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gabeutilitiesx.Essentials));
			panel1 = new System.Windows.Forms.Panel();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			label1 = new System.Windows.Forms.Label();
			pictureBox5 = new System.Windows.Forms.PictureBox();
			guna2GradientButton9 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox9 = new System.Windows.Forms.PictureBox();
			guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
			guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
			guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox6 = new System.Windows.Forms.PictureBox();
			pictureBox7 = new System.Windows.Forms.PictureBox();
			guna2GradientButton7 = new Guna.UI2.WinForms.Guna2GradientButton();
			guna2GradientButton8 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox8 = new System.Windows.Forms.PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
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
			panel1.TabIndex = 1;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(panel1_MouseDown);
			panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(panel1_MouseMove);
			pictureBox3.BackColor = System.Drawing.Color.Transparent;
			pictureBox3.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox3.BackgroundImage");
			pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			pictureBox3.Location = new System.Drawing.Point(773, -1);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new System.Drawing.Size(27, 29);
			pictureBox3.TabIndex = 3;
			pictureBox3.TabStop = false;
			pictureBox3.Click += new System.EventHandler(pictureBox3_Click);
			label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			label1.AutoSize = true;
			label1.BackColor = System.Drawing.Color.Transparent;
			label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(1, 6);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(109, 22);
			label1.TabIndex = 0;
			label1.Text = "Essentials";
			pictureBox5.BackColor = System.Drawing.Color.Transparent;
			pictureBox5.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox5.BackgroundImage");
			pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox5.Location = new System.Drawing.Point(12, 46);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new System.Drawing.Size(110, 72);
			pictureBox5.TabIndex = 10;
			pictureBox5.TabStop = false;
			pictureBox5.Click += new System.EventHandler(pictureBox5_Click);
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
			guna2GradientButton9.Location = new System.Drawing.Point(12, 124);
			guna2GradientButton9.Name = "guna2GradientButton9";
			guna2GradientButton9.PressedDepth = 3;
			guna2GradientButton9.ShadowDecoration.Parent = guna2GradientButton9;
			guna2GradientButton9.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton9.TabIndex = 37;
			guna2GradientButton9.Text = "7-Zip";
			guna2GradientButton9.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton9.UseTransparentBackground = true;
			guna2GradientButton9.Click += new System.EventHandler(guna2GradientButton9_Click);
			pictureBox4.BackColor = System.Drawing.Color.Transparent;
			pictureBox4.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox4.BackgroundImage");
			pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox4.Location = new System.Drawing.Point(153, 46);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new System.Drawing.Size(110, 72);
			pictureBox4.TabIndex = 38;
			pictureBox4.TabStop = false;
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
			guna2GradientButton1.Location = new System.Drawing.Point(153, 124);
			guna2GradientButton1.Name = "guna2GradientButton1";
			guna2GradientButton1.PressedDepth = 3;
			guna2GradientButton1.ShadowDecoration.Parent = guna2GradientButton1;
			guna2GradientButton1.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton1.TabIndex = 39;
			guna2GradientButton1.Text = "Discord";
			guna2GradientButton1.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton1.UseTransparentBackground = true;
			guna2GradientButton1.Click += new System.EventHandler(guna2GradientButton1_Click);
			pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox2.BackColor = System.Drawing.Color.Transparent;
			pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
			pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox2.Location = new System.Drawing.Point(299, 46);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(110, 72);
			pictureBox2.TabIndex = 40;
			pictureBox2.TabStop = false;
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
			guna2GradientButton2.Location = new System.Drawing.Point(299, 124);
			guna2GradientButton2.Name = "guna2GradientButton2";
			guna2GradientButton2.PressedDepth = 3;
			guna2GradientButton2.ShadowDecoration.Parent = guna2GradientButton2;
			guna2GradientButton2.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton2.TabIndex = 41;
			guna2GradientButton2.Text = "Firefox";
			guna2GradientButton2.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton2.UseTransparentBackground = true;
			guna2GradientButton2.Click += new System.EventHandler(guna2GradientButton2_Click);
			pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox9.BackColor = System.Drawing.Color.Transparent;
			pictureBox9.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox9.BackgroundImage");
			pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox9.Location = new System.Drawing.Point(445, 46);
			pictureBox9.Name = "pictureBox9";
			pictureBox9.Size = new System.Drawing.Size(110, 72);
			pictureBox9.TabIndex = 42;
			pictureBox9.TabStop = false;
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
			guna2GradientButton3.Location = new System.Drawing.Point(445, 124);
			guna2GradientButton3.Name = "guna2GradientButton3";
			guna2GradientButton3.PressedDepth = 3;
			guna2GradientButton3.ShadowDecoration.Parent = guna2GradientButton3;
			guna2GradientButton3.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton3.TabIndex = 43;
			guna2GradientButton3.Text = "Taskbar";
			guna2GradientButton3.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton3.UseTransparentBackground = true;
			guna2GradientButton3.Click += new System.EventHandler(guna2GradientButton3_Click);
			guna2GradientButton4.Animated = true;
			guna2GradientButton4.AutoRoundedCorners = true;
			guna2GradientButton4.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton4.BorderRadius = 22;
			guna2GradientButton4.CheckedState.Parent = guna2GradientButton4;
			guna2GradientButton4.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton4.CustomImages.Parent = guna2GradientButton4;
			guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton4.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton4.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton4.ForeColor = System.Drawing.Color.White;
			guna2GradientButton4.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton4.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton4.HoverState.Parent = guna2GradientButton4;
			guna2GradientButton4.Location = new System.Drawing.Point(-2, 401);
			guna2GradientButton4.Name = "guna2GradientButton4";
			guna2GradientButton4.PressedDepth = 3;
			guna2GradientButton4.ShadowDecoration.Parent = guna2GradientButton4;
			guna2GradientButton4.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton4.TabIndex = 44;
			guna2GradientButton4.Text = "Back";
			guna2GradientButton4.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton4.UseTransparentBackground = true;
			guna2GradientButton4.Click += new System.EventHandler(guna2GradientButton4_Click);
			guna2GradientButton5.Animated = true;
			guna2GradientButton5.AutoRoundedCorners = true;
			guna2GradientButton5.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton5.BorderRadius = 22;
			guna2GradientButton5.CheckedState.Parent = guna2GradientButton5;
			guna2GradientButton5.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton5.CustomImages.Parent = guna2GradientButton5;
			guna2GradientButton5.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton5.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton5.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton5.ForeColor = System.Drawing.Color.White;
			guna2GradientButton5.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton5.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton5.HoverState.Parent = guna2GradientButton5;
			guna2GradientButton5.Location = new System.Drawing.Point(572, 124);
			guna2GradientButton5.Name = "guna2GradientButton5";
			guna2GradientButton5.PressedDepth = 3;
			guna2GradientButton5.ShadowDecoration.Parent = guna2GradientButton5;
			guna2GradientButton5.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton5.TabIndex = 45;
			guna2GradientButton5.Text = "Process Hacker";
			guna2GradientButton5.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton5.UseTransparentBackground = true;
			guna2GradientButton5.Click += new System.EventHandler(guna2GradientButton5_Click);
			pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox1.BackColor = System.Drawing.Color.Transparent;
			pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox1.Location = new System.Drawing.Point(572, 46);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(110, 72);
			pictureBox1.TabIndex = 46;
			pictureBox1.TabStop = false;
			guna2GradientButton6.Animated = true;
			guna2GradientButton6.AutoRoundedCorners = true;
			guna2GradientButton6.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton6.BorderRadius = 22;
			guna2GradientButton6.CheckedState.Parent = guna2GradientButton6;
			guna2GradientButton6.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton6.CustomImages.Parent = guna2GradientButton6;
			guna2GradientButton6.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton6.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton6.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton6.ForeColor = System.Drawing.Color.White;
			guna2GradientButton6.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton6.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton6.HoverState.Parent = guna2GradientButton6;
			guna2GradientButton6.Location = new System.Drawing.Point(12, 255);
			guna2GradientButton6.Name = "guna2GradientButton6";
			guna2GradientButton6.PressedDepth = 3;
			guna2GradientButton6.ShadowDecoration.Parent = guna2GradientButton6;
			guna2GradientButton6.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton6.TabIndex = 47;
			guna2GradientButton6.Text = "Notepad";
			guna2GradientButton6.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton6.UseTransparentBackground = true;
			guna2GradientButton6.Click += new System.EventHandler(guna2GradientButton6_Click);
			pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox6.BackColor = System.Drawing.Color.Transparent;
			pictureBox6.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox6.BackgroundImage");
			pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox6.Location = new System.Drawing.Point(12, 177);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new System.Drawing.Size(110, 72);
			pictureBox6.TabIndex = 48;
			pictureBox6.TabStop = false;
			pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox7.BackColor = System.Drawing.Color.Transparent;
			pictureBox7.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox7.BackgroundImage");
			pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox7.Location = new System.Drawing.Point(153, 177);
			pictureBox7.Name = "pictureBox7";
			pictureBox7.Size = new System.Drawing.Size(110, 72);
			pictureBox7.TabIndex = 49;
			pictureBox7.TabStop = false;
			guna2GradientButton7.Animated = true;
			guna2GradientButton7.AutoRoundedCorners = true;
			guna2GradientButton7.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton7.BorderRadius = 22;
			guna2GradientButton7.CheckedState.Parent = guna2GradientButton7;
			guna2GradientButton7.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton7.CustomImages.Parent = guna2GradientButton7;
			guna2GradientButton7.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton7.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton7.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton7.ForeColor = System.Drawing.Color.White;
			guna2GradientButton7.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton7.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton7.HoverState.Parent = guna2GradientButton7;
			guna2GradientButton7.Location = new System.Drawing.Point(153, 255);
			guna2GradientButton7.Name = "guna2GradientButton7";
			guna2GradientButton7.PressedDepth = 3;
			guna2GradientButton7.ShadowDecoration.Parent = guna2GradientButton7;
			guna2GradientButton7.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton7.TabIndex = 50;
			guna2GradientButton7.Text = "HxD";
			guna2GradientButton7.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton7.UseTransparentBackground = true;
			guna2GradientButton7.Click += new System.EventHandler(guna2GradientButton7_Click);
			guna2GradientButton8.Animated = true;
			guna2GradientButton8.AutoRoundedCorners = true;
			guna2GradientButton8.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton8.BorderRadius = 22;
			guna2GradientButton8.CheckedState.Parent = guna2GradientButton8;
			guna2GradientButton8.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton8.CustomImages.Parent = guna2GradientButton8;
			guna2GradientButton8.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton8.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton8.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton8.ForeColor = System.Drawing.Color.White;
			guna2GradientButton8.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton8.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton8.HoverState.Parent = guna2GradientButton8;
			guna2GradientButton8.Location = new System.Drawing.Point(299, 255);
			guna2GradientButton8.Name = "guna2GradientButton8";
			guna2GradientButton8.PressedDepth = 3;
			guna2GradientButton8.ShadowDecoration.Parent = guna2GradientButton8;
			guna2GradientButton8.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton8.TabIndex = 51;
			guna2GradientButton8.Text = "Explorer++";
			guna2GradientButton8.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton8.UseTransparentBackground = true;
			guna2GradientButton8.Click += new System.EventHandler(guna2GradientButton8_Click);
			pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
			pictureBox8.BackColor = System.Drawing.Color.Transparent;
			pictureBox8.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox8.BackgroundImage");
			pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox8.Location = new System.Drawing.Point(299, 177);
			pictureBox8.Name = "pictureBox8";
			pictureBox8.Size = new System.Drawing.Size(110, 72);
			pictureBox8.TabIndex = 52;
			pictureBox8.TabStop = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			base.ClientSize = new System.Drawing.Size(800, 450);
			base.Controls.Add(pictureBox8);
			base.Controls.Add(guna2GradientButton8);
			base.Controls.Add(guna2GradientButton7);
			base.Controls.Add(pictureBox7);
			base.Controls.Add(pictureBox6);
			base.Controls.Add(guna2GradientButton6);
			base.Controls.Add(pictureBox1);
			base.Controls.Add(guna2GradientButton5);
			base.Controls.Add(guna2GradientButton4);
			base.Controls.Add(guna2GradientButton3);
			base.Controls.Add(pictureBox9);
			base.Controls.Add(guna2GradientButton2);
			base.Controls.Add(pictureBox2);
			base.Controls.Add(guna2GradientButton1);
			base.Controls.Add(pictureBox4);
			base.Controls.Add(guna2GradientButton9);
			base.Controls.Add(pictureBox5);
			base.Controls.Add(panel1);
			DoubleBuffered = true;
			ForeColor = System.Drawing.Color.Transparent;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Essentials";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Browsers";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
			ResumeLayout(false);
		}
	}
}
