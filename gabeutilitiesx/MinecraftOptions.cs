using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace gabeutilitiesx
{
	public class MinecraftOptions : Form
	{
		private IContainer components = null;

		private Guna2GradientButton guna2GradientButton1;

		private Label lag;

		private PictureBox pictureBox1;

		public MinecraftOptions()
		{
			InitializeComponent();
		}

		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			lag.Show();
			Directory.CreateDirectory("c:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\versions");
			Directory.CreateDirectory("c:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\versions\\1.12.2");
			Directory.CreateDirectory("c:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\versions\\1.12.2-forge1.12.2-14.23.5.2768");
			Directory.CreateDirectory("c:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\mods");
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/hpvv0e5snhty1fz/BiomesOPlenty-1.12.2-7.0.1.2444-universal.jar", "c:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\mods\\BiomesOPlenty-1.12.2-7.0.1.2444-universal.jar");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/h89c05kdoisu18c/BOP-Patch-1.0.jar", "c:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\mods\\BOP-Patch-1.0.jar");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/af856ivpptu5mjn/Gameshark-1.12.2-6.0.0-universal.jar", "c:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\mods\\Gameshark-1.12.2-6.0.0-universal.jar");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/hho86vse13rp140/journeymap-1.12.2-5.7.0.jar", "c:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\mods\\journeymap-1.12.2-5.7.0.jar");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/0yra0lfi3tu4wyw/OptiFine_1.12.2_HD_U_F5.jar", "c:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\mods\\OptiFine_1.12.2_HD_U_F5.jar");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/sbl9sj4syi02787/pixelExtras-1.12.2-2.5.4-universal.jar", "c:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\mods\\pixelExtras-1.12.2-2.5.4-universal.jar");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/j8ii3pbfvm9pdcf/1.12.2-forge1.12.2-14.23.5.2768.json", "c:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\\\versions\\1.12.2-forge1.12.2-14.23.5.2768\\1.12.2-forge1.12.2-14.23.5.2768.json");
			webClient.DownloadFile("https://dl.dropboxusercontent.com/s/u79fqmck3lhgtha/1.12.2.jar", "c:\\Users\\kiosk\\AppData\\Roaming\\.minecraft\\versions\\1.12.2-forge1.12.2-14.23.5.2768\\1.12.2.jar");
			lag.Hide();
			MessageBox.Show("Done. Go and open Minecraft and make a new profile and scroll all the way down in versions and select Forge.");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gabeutilitiesx.MinecraftOptions));
			guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
			lag = new System.Windows.Forms.Label();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			guna2GradientButton1.Animated = true;
			guna2GradientButton1.AutoRoundedCorners = true;
			guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
			guna2GradientButton1.BorderRadius = 21;
			guna2GradientButton1.CheckedState.Parent = guna2GradientButton1;
			guna2GradientButton1.CustomImages.Parent = guna2GradientButton1;
			guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(255, 192, 128);
			guna2GradientButton1.FillColor2 = System.Drawing.Color.Orchid;
			guna2GradientButton1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			guna2GradientButton1.ForeColor = System.Drawing.Color.White;
			guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.Black;
			guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.Silver;
			guna2GradientButton1.HoverState.Parent = guna2GradientButton1;
			guna2GradientButton1.Location = new System.Drawing.Point(22, 22);
			guna2GradientButton1.Name = "guna2GradientButton1";
			guna2GradientButton1.ShadowDecoration.Parent = guna2GradientButton1;
			guna2GradientButton1.Size = new System.Drawing.Size(180, 45);
			guna2GradientButton1.TabIndex = 0;
			guna2GradientButton1.Text = "Pixelmon";
			guna2GradientButton1.Click += new System.EventHandler(guna2GradientButton1_Click);
			lag.Anchor = System.Windows.Forms.AnchorStyles.None;
			lag.AutoSize = true;
			lag.BackColor = System.Drawing.Color.Transparent;
			lag.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
			lag.ForeColor = System.Drawing.Color.White;
			lag.Location = new System.Drawing.Point(18, 287);
			lag.Name = "lag";
			lag.Size = new System.Drawing.Size(196, 18);
			lag.TabIndex = 1;
			lag.Text = "Downloading (may lag)";
			lag.Visible = false;
			pictureBox1.BackColor = System.Drawing.Color.Transparent;
			pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			pictureBox1.Location = new System.Drawing.Point(673, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(27, 29);
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new System.Drawing.Size(699, 364);
			base.Controls.Add(pictureBox1);
			base.Controls.Add(lag);
			base.Controls.Add(guna2GradientButton1);
			DoubleBuffered = true;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "MinecraftOptions";
			Text = "Minecraft Options";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
