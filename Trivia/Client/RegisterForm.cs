using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class RegisterForm : Form
	{
		Stream stream;

		Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, Helper._); } }
		Rectangle Left { get { return new Rectangle(0, 0, Helper._, this.ClientSize.Height); } }
		Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - Helper._, this.ClientSize.Width, Helper._); } }
		Rectangle Right { get { return new Rectangle(this.ClientSize.Width - Helper._, 0, Helper._, this.ClientSize.Height); } }
		Rectangle TopLeft { get { return new Rectangle(0, 0, Helper._, Helper._); } }
		Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - Helper._, 0, Helper._, Helper._); } }
		Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - Helper._, Helper._, Helper._); } }
		Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - Helper._, this.ClientSize.Height - Helper._, Helper._, Helper._); } }

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.FillRectangle(Brushes.Transparent, Top);
			e.Graphics.FillRectangle(Brushes.Transparent, Left);
			e.Graphics.FillRectangle(Brushes.Transparent, Right);
			e.Graphics.FillRectangle(Brushes.Transparent, Bottom);
		}

		protected override void WndProc(ref Message message)
		{
			base.WndProc(ref message);

			if (message.Msg == 0x84) // WM_NCHITTEST
			{
				var cursor = this.PointToClient(Cursor.Position);

				if (TopLeft.Contains(cursor)) message.Result = (IntPtr)Helper.HTTOPLEFT;
				else if (TopRight.Contains(cursor)) message.Result = (IntPtr)Helper.HTTOPRIGHT;
				else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)Helper.HTBOTTOMLEFT;
				else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)Helper.HTBOTTOMRIGHT;

				else if (Top.Contains(cursor)) message.Result = (IntPtr)Helper.HTTOP;
				else if (Left.Contains(cursor)) message.Result = (IntPtr)Helper.HTLEFT;
				else if (Right.Contains(cursor)) message.Result = (IntPtr)Helper.HTRIGHT;
				else if (Bottom.Contains(cursor)) message.Result = (IntPtr)Helper.HTBOTTOM;
			}
		}

		private void RegisterForm_SizeChanged(object sender, EventArgs e)
		{
			Region = System.Drawing.Region.FromHrgn(Helper.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
		}

		private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Helper.ReleaseCapture();
				Helper.SendMessage(Handle, Helper.WM_NCLBUTTONDOWN, Helper.HT_CAPTION, 0);
			}
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Helper.ReleaseCapture();
				Helper.SendMessage(Handle, Helper.WM_NCLBUTTONDOWN, Helper.HT_CAPTION, 0);
			}
		}

		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Helper.ReleaseCapture();
				Helper.SendMessage(Handle, Helper.WM_NCLBUTTONDOWN, Helper.HT_CAPTION, 0);
			}
		}

		public RegisterForm(Stream stream)
		{
			InitializeComponent();

			this.SetStyle(ControlStyles.ResizeRedraw, true);
			Region = System.Drawing.Region.FromHrgn(Helper.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

			this.stream = stream;
		}

		private void registerBtn_Click(object sender, EventArgs e)
		{
			errorLbl.Text = "";

			try
			{
				Helper.Send("203" + username.TextLength.ToString().PadLeft(2, '0') + username.Text + password.TextLength.ToString().PadLeft(2, '0') + password.Text + email.TextLength.ToString().PadLeft(2, '0') + email.Text, stream);

				string response = Helper.Read(4, stream);

				if (response.Equals("1040"))
				{
					MessageBox.Show("You have registered successfully!");

					this.Close();
				}
				else if (response.Equals("1041"))
					errorLbl.Text = "[ERROR]: Illegal password!";
				else if (response.Equals("1042"))
					errorLbl.Text = "[ERROR]: Username already exists!";
				else if (response.Equals("1043"))
					errorLbl.Text = "[ERROR]: Illegal username!";
				else if (response.Equals("1044"))
					errorLbl.Text = "[ERROR]: Other!";
			}
			catch (Exception ex)
			{
				errorLbl.Text = "[Exception]: " + ex.Message;
			}
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void expandBtn_Click(object sender, EventArgs e)
		{
			if (this.WindowState != FormWindowState.Maximized)
				this.WindowState = FormWindowState.Maximized;
			else
				this.WindowState = FormWindowState.Normal;
		}

		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
