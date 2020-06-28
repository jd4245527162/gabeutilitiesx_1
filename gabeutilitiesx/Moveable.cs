using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace gabeutilitiesx
{
	internal class Moveable
	{
		public const int WM_NCLBUTTONDOWN = 161;

		public const int HT_CAPTION = 2;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		public Moveable(params Control[] controls)
		{
			foreach (Control ctrl in controls)
			{
				ctrl.MouseDown += delegate(object s, MouseEventArgs e)
				{
					if (e.Button == MouseButtons.Left)
					{
						ReleaseCapture();
						SendMessage(ctrl.FindForm().Handle, 161, 2, 0);
						if (ctrl.FindForm().Location.Y == 0)
						{
							ctrl.FindForm().WindowState = FormWindowState.Maximized;
						}
					}
				};
			}
		}
	}
}
