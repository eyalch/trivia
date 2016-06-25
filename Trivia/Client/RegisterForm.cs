using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class RegisterForm : Form
	{
		Stream stream;

		public RegisterForm(Stream stream)
		{
			InitializeComponent();

			this.stream = stream;
		}

		private void registerBtn_Click(object sender, EventArgs e)
		{
			error.Text = "";

			string msg = "203" + username.TextLength.ToString().PadLeft(2, '0') + username.Text + password.TextLength.ToString().PadLeft(2, '0') + password.Text + email.TextLength.ToString().PadLeft(2, '0') + email.Text;

			ASCIIEncoding asciiEncoding = new ASCIIEncoding();
			byte[] ba = asciiEncoding.GetBytes(msg);

			Console.WriteLine("Sending: " + msg);

			stream.Write(ba, 0, ba.Length);

			byte[] bb = new byte[4];
			int k = stream.Read(bb, 0, 4);

			string response = Encoding.Default.GetString(bb);

			if (response.Equals("1040"))
			{
				MessageBox.Show("You have registered successfully!");

				this.Close();
			}
			else if (response.Equals("1041"))
				error.Text = "[ERROR]: Illegal password!";
			else if (response.Equals("1042"))
				error.Text = "[ERROR]: Username already exists!";
			else if (response.Equals("1043"))
				error.Text = "[ERROR]: Illegal username!";
			else if (response.Equals("1044"))
				error.Text = "[ERROR]: Other!";
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
