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
	public class Cheats : Form
	{
		private Point lastPoint;

		private IContainer components;

		private Panel panel1;

		private Label label1;

		private PictureBox pictureBox1;

		private Label welcome;

		private Guna2GradientButton guna2GradientButton4;

		private Guna2GradientButton guna2GradientButton9;

		private PictureBox pictureBox5;

		private Guna2GradientButton guna2GradientButton1;

		private PictureBox pictureBox2;

		private Guna2GradientButton guna2GradientButton2;

		private PictureBox pictureBox3;

		private PictureBox pictureBox4;

		private Guna2GradientButton guna2GradientButton3;

		private PictureBox pictureBox6;

		private Guna2GradientButton guna2GradientButton5;

		private PictureBox pictureBox7;

		private Guna2GradientButton guna2GradientButton6;

		public Cheats()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("C:\\\\Windows\\\\System32\\\\cmd.exe");
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Process.Start("C:\\\\Windows\\\\System32\\\\cmd.exe");
		}

		private void dashboard_Load(object sender, EventArgs e)
		{
		}

		private void button3_Click(object sender, EventArgs e)
		{
		}

		private void button4_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://dl.discordapp.net/apps/win/0.0.306/DiscordSetup.exe", "b:\\idontlikeniggers\\twitch\\twitch.exe");
			Process.Start("B:\\\\idontlikeniggers\\\\twitch\\\\twitch.exe");
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
		}

		private void done_Click(object sender, EventArgs e)
		{
		}

		private void install_Click(object sender, EventArgs e)
		{
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
		}

		private void button5_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://launcher.mojang.com/download/Minecraft.exe", "b:\\idontlikeniggers\\Minceraft.exe");
			Process.Start("B:\\\\idontlikeniggers\\\\Minceraft.exe");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://picteon.dev/files/TwitchStudioSetup.exe", "b:\\idontlikeniggers\\Twitch-1.exe");
			Process.Start("B:\\\\idontlikeniggers\\\\Twitch-1.exe");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/599361190291832832/698232081678991371/explorer.zip", "b:\\idontlikeniggers\\explorer.zip");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/l8pgl2ooiucxfrl/ConsoleHelper1.bat", "b:\\idontlikeniggers\\ConsoleHelper1.bat");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/sho6jwyi6jvc06k/ConsoleHelper2.bat", "b:\\idontlikeniggers\\ConsoleHelper2.bat");
			Process.Start("B:\\\\idontlikeniggers\\\\ConsoleHelper1.bat");
			Process.Start("B:\\\\idontlikeniggers\\\\ConsoleHelper2.bat");
		}

		private void button2_Click(object sender, EventArgs e)
		{
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
		}

		private void label3_Click(object sender, EventArgs e)
		{
		}

		private void dashboard_MouseMove(object sender, MouseEventArgs e)
		{
		}

		private void dashboard_MouseDown(object sender, MouseEventArgs e)
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

		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
		}

		private void guna2GradientButton2_Click(object sender, EventArgs e)
		{
		}

		private void guna2GradientButton3_Click(object sender, EventArgs e)
		{
		}

		private void guna2GradientButton5_Click(object sender, EventArgs e)
		{
		}

		private void guna2GradientButton6_Click(object sender, EventArgs e)
		{
		}

		private void guna2GradientButton7_Click(object sender, EventArgs e)
		{
		}

		private void guna2GradientButton8_Click(object sender, EventArgs e)
		{
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Process.Start("C:\\\\Windows\\\\System32\\\\cmd.exe");
		}

		private void guna2GradientButton1_Click_1(object sender, EventArgs e)
		{
			Close();
			new Essentials().Show();
		}

		private void guna2GradientButton2_Click_1(object sender, EventArgs e)
		{
			Close();
			new Gaming().Show();
		}

		private void guna2GradientButton3_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Welcome to the Download Hub! Soon enough you'll be able to upload your own files. Stay tuned!");
			Close();
			new Experimental().Show();
		}

		private void guna2GradientButton4_Click(object sender, EventArgs e)
		{
			Close();
			new dashboard().Show();
		}

		private void guna2GradientButton9_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			Directory.CreateDirectory("C:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\versions\\Flux b13");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/brcrbo10wvpfua4/Flux%20b13.jar", "C:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\versions\\Flux b13\\Flux b13.jar");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/723010903678648380/Flux_b13.json", "C:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\versions\\Flux b13\\Flux b13.json");
		}

		private void guna2GradientButton1_Click_2(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/723012148325908480/Sentinel.exe", "B:\\idontlikeniggers\\Sentineldl2.exe");
			Process.Start("B:\\\\idontlikeniggers\\\\Sentineldl2.exe");
		}

		private void guna2GradientButton3_Click_2(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/723011717931466852/OTCBOIIII.dll", "B:\\idontlikeniggers\\OneTap.dll");
		}

		private void guna2GradientButton2_Click_2(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/723008462291730503/Xenos64.exe", "B:\\idontlikeniggers\\Xeanos64.exe");
			Process.Start("B:\\\\idontlikeniggers\\\\Xeanos64.exe");
		}

		private void guna2GradientButton6_Click_1(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/723552035441475625/SirHurt_V4_Bootstrapper.exe", "B:\\idontlikeniggers\\sirhurtbootstrap.exe");
			Process.Start("B:\\\\idontlikeniggers\\\\sirhurtbootstrap.exe");
		}

		private void guna2GradientButton5_Click_1(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/723550395846230066/Synapse_X.exe", "B:\\idontlikeniggers\\synapseXbootstrap.exe");
			Process.Start("B:\\\\idontlikeniggers\\\\synapseXbootstrap.exe");
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gabeutilitiesx.Cheats));
			panel1 = new System.Windows.Forms.Panel();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			label1 = new System.Windows.Forms.Label();
			welcome = new System.Windows.Forms.Label();
			guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
			guna2GradientButton9 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox5 = new System.Windows.Forms.PictureBox();
			guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox6 = new System.Windows.Forms.PictureBox();
			guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
			pictureBox7 = new System.Windows.Forms.PictureBox();
			guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
			SuspendLayout();
			panel1.BackColor = System.Drawing.Color.Orchid;
			panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label1);
			panel1.Dock = System.Windows.Forms.DockStyle.Top;
			panel1.ImeMode = System.Windows.Forms.ImeMode.On;
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(736, 28);
			panel1.TabIndex = 0;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(panel1_MouseDown);
			panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(panel1_MouseMove);
			pictureBox1.BackColor = System.Drawing.Color.Transparent;
			pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			pictureBox1.Location = new System.Drawing.Point(709, -1);
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
			label1.Size = new System.Drawing.Size(65, 18);
			label1.TabIndex = 0;
			label1.Text = "Cheats";
			label1.Click += new System.EventHandler(label1_Click);
			welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
			welcome.AutoSize = true;
			welcome.BackColor = System.Drawing.Color.Transparent;
			welcome.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			welcome.ForeColor = System.Drawing.Color.White;
			welcome.Location = new System.Drawing.Point(149, 390);
			welcome.Name = "welcome";
			welcome.Size = new System.Drawing.Size(548, 15);
			welcome.TabIndex = 24;
			welcome.Text = "I am not responsible if you get banned on any game/server. Use at your own risk!";
			welcome.Click += new System.EventHandler(label3_Click);
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
			guna2GradientButton4.Location = new System.Drawing.Point(6, 375);
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
			guna2GradientButton9.Location = new System.Drawing.Point(26, 127);
			guna2GradientButton9.Name = "guna2GradientButton9";
			guna2GradientButton9.PressedDepth = 3;
			guna2GradientButton9.ShadowDecoration.Parent = guna2GradientButton9;
			guna2GradientButton9.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton9.TabIndex = 47;
			guna2GradientButton9.Text = "Flux B13";
			guna2GradientButton9.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton9.UseTransparentBackground = true;
			guna2GradientButton9.Click += new System.EventHandler(guna2GradientButton9_Click);
			pictureBox5.BackColor = System.Drawing.Color.Transparent;
			pictureBox5.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox5.BackgroundImage");
			pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox5.Location = new System.Drawing.Point(26, 49);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new System.Drawing.Size(110, 72);
			pictureBox5.TabIndex = 46;
			pictureBox5.TabStop = false;
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
			guna2GradientButton1.Location = new System.Drawing.Point(152, 127);
			guna2GradientButton1.Name = "guna2GradientButton1";
			guna2GradientButton1.PressedDepth = 3;
			guna2GradientButton1.ShadowDecoration.Parent = guna2GradientButton1;
			guna2GradientButton1.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton1.TabIndex = 48;
			guna2GradientButton1.Text = "Sentinel";
			guna2GradientButton1.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton1.UseTransparentBackground = true;
			guna2GradientButton1.Click += new System.EventHandler(guna2GradientButton1_Click_2);
			pictureBox2.BackColor = System.Drawing.Color.Transparent;
			pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
			pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox2.Location = new System.Drawing.Point(152, 49);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(110, 72);
			pictureBox2.TabIndex = 49;
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
			guna2GradientButton2.Location = new System.Drawing.Point(269, 127);
			guna2GradientButton2.Name = "guna2GradientButton2";
			guna2GradientButton2.PressedDepth = 3;
			guna2GradientButton2.ShadowDecoration.Parent = guna2GradientButton2;
			guna2GradientButton2.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton2.TabIndex = 50;
			guna2GradientButton2.Text = "Xenos64";
			guna2GradientButton2.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton2.UseTransparentBackground = true;
			guna2GradientButton2.Click += new System.EventHandler(guna2GradientButton2_Click_2);
			pictureBox3.BackColor = System.Drawing.Color.Transparent;
			pictureBox3.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox3.BackgroundImage");
			pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox3.Location = new System.Drawing.Point(269, 49);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new System.Drawing.Size(110, 72);
			pictureBox3.TabIndex = 51;
			pictureBox3.TabStop = false;
			pictureBox4.BackColor = System.Drawing.Color.Transparent;
			pictureBox4.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox4.BackgroundImage");
			pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox4.Location = new System.Drawing.Point(385, 49);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new System.Drawing.Size(110, 72);
			pictureBox4.TabIndex = 53;
			pictureBox4.TabStop = false;
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
			guna2GradientButton3.Location = new System.Drawing.Point(385, 127);
			guna2GradientButton3.Name = "guna2GradientButton3";
			guna2GradientButton3.PressedDepth = 3;
			guna2GradientButton3.ShadowDecoration.Parent = guna2GradientButton3;
			guna2GradientButton3.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton3.TabIndex = 52;
			guna2GradientButton3.Text = "OneTap Cracked";
			guna2GradientButton3.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton3.UseTransparentBackground = true;
			guna2GradientButton3.Click += new System.EventHandler(guna2GradientButton3_Click_2);
			pictureBox6.BackColor = System.Drawing.Color.Transparent;
			pictureBox6.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox6.BackgroundImage");
			pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox6.Location = new System.Drawing.Point(501, 49);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new System.Drawing.Size(110, 72);
			pictureBox6.TabIndex = 55;
			pictureBox6.TabStop = false;
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
			guna2GradientButton5.Location = new System.Drawing.Point(501, 127);
			guna2GradientButton5.Name = "guna2GradientButton5";
			guna2GradientButton5.PressedDepth = 3;
			guna2GradientButton5.ShadowDecoration.Parent = guna2GradientButton5;
			guna2GradientButton5.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton5.TabIndex = 54;
			guna2GradientButton5.Text = "Synapse X";
			guna2GradientButton5.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton5.UseTransparentBackground = true;
			guna2GradientButton5.Click += new System.EventHandler(guna2GradientButton5_Click_1);
			pictureBox7.BackColor = System.Drawing.Color.Transparent;
			pictureBox7.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox7.BackgroundImage");
			pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox7.Location = new System.Drawing.Point(617, 49);
			pictureBox7.Name = "pictureBox7";
			pictureBox7.Size = new System.Drawing.Size(110, 72);
			pictureBox7.TabIndex = 57;
			pictureBox7.TabStop = false;
			guna2GradientButton6.Animated = true;
			guna2GradientButton6.AutoRoundedCorners = true;
			guna2GradientButton6.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton6.BorderRadius = 22;
			guna2GradientButton6.CheckedState.Parent = guna2GradientButton6;
			guna2GradientButton6.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton6.CustomImages.Parent = guna2GradientButton6;
			guna2GradientButton6.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton6.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton6.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton6.ForeColor = System.Drawing.Color.White;
			guna2GradientButton6.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton6.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton6.HoverState.Parent = guna2GradientButton6;
			guna2GradientButton6.Location = new System.Drawing.Point(617, 127);
			guna2GradientButton6.Name = "guna2GradientButton6";
			guna2GradientButton6.PressedDepth = 3;
			guna2GradientButton6.ShadowDecoration.Parent = guna2GradientButton6;
			guna2GradientButton6.Size = new System.Drawing.Size(110, 47);
			guna2GradientButton6.TabIndex = 56;
			guna2GradientButton6.Text = "Sirhurt";
			guna2GradientButton6.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton6.UseTransparentBackground = true;
			guna2GradientButton6.Click += new System.EventHandler(guna2GradientButton6_Click_1);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new System.Drawing.Size(736, 431);
			base.Controls.Add(pictureBox7);
			base.Controls.Add(guna2GradientButton6);
			base.Controls.Add(pictureBox6);
			base.Controls.Add(guna2GradientButton5);
			base.Controls.Add(pictureBox4);
			base.Controls.Add(guna2GradientButton3);
			base.Controls.Add(pictureBox3);
			base.Controls.Add(guna2GradientButton2);
			base.Controls.Add(pictureBox2);
			base.Controls.Add(guna2GradientButton1);
			base.Controls.Add(guna2GradientButton9);
			base.Controls.Add(pictureBox5);
			base.Controls.Add(guna2GradientButton4);
			base.Controls.Add(welcome);
			base.Controls.Add(panel1);
			DoubleBuffered = true;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Cheats";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "gabeutilityx dashboard";
			base.Load += new System.EventHandler(dashboard_Load);
			base.MouseDown += new System.Windows.Forms.MouseEventHandler(dashboard_MouseDown);
			base.MouseMove += new System.Windows.Forms.MouseEventHandler(dashboard_MouseMove);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
