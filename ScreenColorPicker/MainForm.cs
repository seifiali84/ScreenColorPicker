using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScreenColorPicker
{
	public partial class MainForm : Form
	{
		[DllImport("user32.dll")]
		private static extern IntPtr GetDC(IntPtr hwnd);
		[DllImport("user32.dll")]
		private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);
		[DllImport("gdi32.dll")]
		private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);
		[DllImport("user32.dll")]
		private static extern int GetAsyncKeyState(Keys vkeys);

		private bool keypressed = false;
		private bool locked = false;

		public MainForm()
		{
			InitializeComponent();
		}

		private Color GetPixelColor(int x, int y)
		{
			IntPtr hdc = GetDC(IntPtr.Zero);
			uint pixel = GetPixel(hdc, x, y);
			ReleaseDC(IntPtr.Zero, hdc);
			Color c = Color.FromArgb((int)(pixel & 0x000000FF),
						 (int)(pixel & 0x0000FF00) >> 8,
						 (int)(pixel & 0x00FF0000) >> 16);
			return c;
		}

		#region Timers
		private void KeysTimer_Tick(object sender, EventArgs e)
		{
			if (!keypressed && GetAsyncKeyState(Keys.F10) != 0)
			{
				keypressed = true;
				
				if (locked)
					mousePositionTimer.Start();
				else
					mousePositionTimer.Stop();

				locked = !locked;
			}
			else if (GetAsyncKeyState(Keys.F10) == 0)
			{
				keypressed = false;
			}
		}

		private void MousePositionTimer_Tick(object sender, EventArgs e)
		{
			Color color = GetPixelColor(MousePosition.X, MousePosition.Y);

			//Sample Color
			sampleColorPictureBox.BackColor = color;

			//RGB Color
			textBoxRgbR.Text = color.R.ToString();
			textBoxRgbG.Text = color.G.ToString();
			textBoxRgbB.Text = color.B.ToString();

			//HSL Color
			textBoxHslH.Text = color.GetHue().ToString("F0");
			textBoxHslS.Text = (color.GetSaturation() * 100).ToString("F0");
			textBoxHslL.Text = (color.GetBrightness() * 100).ToString("F0");

			//Hex Color
			textBoxHEX.Text = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
		}
		#endregion
	}
}
