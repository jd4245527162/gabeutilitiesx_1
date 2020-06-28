using Guna.UI2.WinForms;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace gabeutilitiesx
{
	public class dashboard : Form
	{
		private Point lastPoint;

		private IContainer components;

		private Panel panel1;

		private Label label1;

		private PictureBox pictureBox1;

		private Label label2;

		private PictureBox UserProfile;

		private Label welcome;

		private Guna2GradientButton guna2GradientButton1;

		private Guna2GradientButton guna2GradientButton2;

		private Guna2GradientButton guna2GradientButton3;

		private Label label3;

		private Guna2GradientButton guna2GradientButton4;

		public dashboard()
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

		public static void sendWebHook(string URL, string msg, string username)
		{
			Http.Post(URL, new NameValueCollection
			{
				{
					"username",
					username
				},
				{
					"content",
					msg
				}
			});
		}

		private void dashboard_Load(object sender, EventArgs e)
		{
			if (!Directory.Exists("b:\\idontlikeniggersutilityx\\info"))
			{
				new WebClient().DownloadFile("https://gabeutilityx.imfast.io/" + MyGlobals.userdefine + ".png", "b:\\\\idontlikeniggersutilityx\\\\profilePicture.png");
				Directory.CreateDirectory("b:\\idontlikeniggersutilityx\\info");
			}
			UserProfile.Image = Image.FromFile("B:\\idontlikeniggersutilityx\\profilePicture.png");
			UserProfile.SizeMode = PictureBoxSizeMode.Zoom;
			welcome.Text = "Welcome, " + MyGlobals.userdefine + ".";
		}

		private void button3_Click(object sender, EventArgs e)
		{
		}

		private void button4_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://dl.discordapp.net/apps/win/0.0.306/DiscordSetup.exe", "b:\\idontlikeniggers\\twitch\\twitch.exe");
			Process.Start("B:\\\\idontlikeniggers\\\\twitch\\\\twitch.exe");
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
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

		private void guna2GradientButton4_Click(object sender, EventArgs e)
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

		private void guna2GradientButton4_Click_1(object sender, EventArgs e)
		{
			Close();
			new Cheats().Show();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gabeutilitiesx.dashboard));
			panel1 = new System.Windows.Forms.Panel();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			UserProfile = new System.Windows.Forms.PictureBox();
			welcome = new System.Windows.Forms.Label();
			guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
			guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
			guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
			label3 = new System.Windows.Forms.Label();
			guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)UserProfile).BeginInit();
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
			label1.Size = new System.Drawing.Size(104, 18);
			label1.TabIndex = 0;
			label1.Text = "gabeutilityx";
			label1.Click += new System.EventHandler(label1_Click);
			label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			label2.AutoSize = true;
			label2.BackColor = System.Drawing.Color.Transparent;
			label2.Font = new System.Drawing.Font("Yu Gothic UI Light", 26.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
			label2.ForeColor = System.Drawing.Color.White;
			label2.Location = new System.Drawing.Point(642, 362);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(94, 47);
			label2.TabIndex = 2;
			label2.Text = "v1.1.0";
			label2.Click += new System.EventHandler(label2_Click);
			UserProfile.BackColor = System.Drawing.Color.Transparent;
			UserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			UserProfile.Location = new System.Drawing.Point(12, 298);
			UserProfile.Name = "UserProfile";
			UserProfile.Size = new System.Drawing.Size(95, 94);
			UserProfile.TabIndex = 23;
			UserProfile.TabStop = false;
			UserProfile.Click += new System.EventHandler(pictureBox10_Click);
			welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
			welcome.AutoSize = true;
			welcome.BackColor = System.Drawing.Color.Transparent;
			welcome.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			welcome.ForeColor = System.Drawing.Color.White;
			welcome.Location = new System.Drawing.Point(12, 404);
			welcome.Name = "welcome";
			welcome.Size = new System.Drawing.Size(91, 18);
			welcome.TabIndex = 24;
			welcome.Text = "Loading...";
			welcome.Click += new System.EventHandler(label3_Click);
			guna2GradientButton1.Animated = true;
			guna2GradientButton1.AutoRoundedCorners = true;
			guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton1.BorderRadius = 29;
			guna2GradientButton1.CheckedState.Parent = guna2GradientButton1;
			guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton1.CustomImages.Parent = guna2GradientButton1;
			guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton1.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton1.ForeColor = System.Drawing.Color.White;
			guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton1.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton1.HoverState.Parent = guna2GradientButton1;
			guna2GradientButton1.Location = new System.Drawing.Point(12, 57);
			guna2GradientButton1.Name = "guna2GradientButton1";
			guna2GradientButton1.PressedDepth = 3;
			guna2GradientButton1.ShadowDecoration.Parent = guna2GradientButton1;
			guna2GradientButton1.Size = new System.Drawing.Size(223, 60);
			guna2GradientButton1.TabIndex = 35;
			guna2GradientButton1.Text = "Essentials";
			guna2GradientButton1.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton1.UseTransparentBackground = true;
			guna2GradientButton1.Click += new System.EventHandler(guna2GradientButton1_Click_1);
			guna2GradientButton2.Animated = true;
			guna2GradientButton2.AutoRoundedCorners = true;
			guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton2.BorderRadius = 29;
			guna2GradientButton2.CheckedState.Parent = guna2GradientButton2;
			guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton2.CustomImages.Parent = guna2GradientButton2;
			guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton2.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton2.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton2.ForeColor = System.Drawing.Color.White;
			guna2GradientButton2.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton2.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton2.HoverState.Parent = guna2GradientButton2;
			guna2GradientButton2.Location = new System.Drawing.Point(249, 57);
			guna2GradientButton2.Name = "guna2GradientButton2";
			guna2GradientButton2.PressedDepth = 3;
			guna2GradientButton2.ShadowDecoration.Parent = guna2GradientButton2;
			guna2GradientButton2.Size = new System.Drawing.Size(223, 60);
			guna2GradientButton2.TabIndex = 36;
			guna2GradientButton2.Text = "Gaming";
			guna2GradientButton2.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton2.UseTransparentBackground = true;
			guna2GradientButton2.Click += new System.EventHandler(guna2GradientButton2_Click_1);
			guna2GradientButton3.Animated = true;
			guna2GradientButton3.AutoRoundedCorners = true;
			guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton3.BorderRadius = 29;
			guna2GradientButton3.CheckedState.Parent = guna2GradientButton3;
			guna2GradientButton3.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton3.CustomImages.Parent = guna2GradientButton3;
			guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton3.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton3.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton3.ForeColor = System.Drawing.Color.White;
			guna2GradientButton3.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton3.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton3.HoverState.Parent = guna2GradientButton3;
			guna2GradientButton3.Location = new System.Drawing.Point(12, 161);
			guna2GradientButton3.Name = "guna2GradientButton3";
			guna2GradientButton3.PressedDepth = 3;
			guna2GradientButton3.ShadowDecoration.Parent = guna2GradientButton3;
			guna2GradientButton3.Size = new System.Drawing.Size(223, 60);
			guna2GradientButton3.TabIndex = 37;
			guna2GradientButton3.Text = "Download Hub";
			guna2GradientButton3.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton3.UseTransparentBackground = true;
			guna2GradientButton3.Click += new System.EventHandler(guna2GradientButton3_Click_1);
			label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			label3.AutoSize = true;
			label3.BackColor = System.Drawing.Color.Transparent;
			label3.Font = new System.Drawing.Font("Yu Gothic UI Light", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
			label3.ForeColor = System.Drawing.Color.White;
			label3.Location = new System.Drawing.Point(651, 407);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(85, 13);
			label3.TabIndex = 38;
			label3.Text = "Pink Clouds build";
			guna2GradientButton4.Animated = true;
			guna2GradientButton4.AutoRoundedCorners = true;
			guna2GradientButton4.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton4.BorderRadius = 29;
			guna2GradientButton4.CheckedState.Parent = guna2GradientButton4;
			guna2GradientButton4.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton4.CustomImages.Parent = guna2GradientButton4;
			guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton4.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton4.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton4.ForeColor = System.Drawing.Color.White;
			guna2GradientButton4.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton4.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton4.HoverState.Parent = guna2GradientButton4;
			guna2GradientButton4.Location = new System.Drawing.Point(478, 57);
			guna2GradientButton4.Name = "guna2GradientButton4";
			guna2GradientButton4.PressedDepth = 3;
			guna2GradientButton4.ShadowDecoration.Parent = guna2GradientButton4;
			guna2GradientButton4.Size = new System.Drawing.Size(223, 60);
			guna2GradientButton4.TabIndex = 39;
			guna2GradientButton4.Text = "Cheats";
			guna2GradientButton4.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton4.UseTransparentBackground = true;
			guna2GradientButton4.Click += new System.EventHandler(guna2GradientButton4_Click_1);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new System.Drawing.Size(736, 431);
			base.Controls.Add(guna2GradientButton4);
			base.Controls.Add(label3);
			base.Controls.Add(guna2GradientButton3);
			base.Controls.Add(guna2GradientButton2);
			base.Controls.Add(guna2GradientButton1);
			base.Controls.Add(welcome);
			base.Controls.Add(UserProfile);
			base.Controls.Add(label2);
			base.Controls.Add(panel1);
			DoubleBuffered = true;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "dashboard";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "gabeutilityx dashboard";
			base.Load += new System.EventHandler(dashboard_Load);
			base.MouseDown += new System.Windows.Forms.MouseEventHandler(dashboard_MouseDown);
			base.MouseMove += new System.Windows.Forms.MouseEventHandler(dashboard_MouseMove);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)UserProfile).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
