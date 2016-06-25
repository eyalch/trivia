using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class LogInForm : Form
    {
		string IP = "10.0.0.7";
		int PORT = 8820;

		TcpClient tcpClient;
		Stream stream;

		public LogInForm()
        {
            InitializeComponent();

			try
			{
				tcpClient = new TcpClient();
				Console.WriteLine("Connecting to {0}:{1}...", IP, PORT);
				tcpClient.Connect(IP, PORT);

				Console.WriteLine("Connected!");

				stream = tcpClient.GetStream();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.StackTrace);
			}
		}

		private void logInBtn_Click(object sender, EventArgs e)
		{
			error.Text = "";

			string msg = "200" + username.TextLength.ToString().PadLeft(2, '0') + username.Text + password.TextLength.ToString().PadLeft(2, '0') + password.Text;

			ASCIIEncoding asciiEncoding = new ASCIIEncoding();
			byte[] ba = asciiEncoding.GetBytes(msg);

			Console.WriteLine("Sending: " + msg);

			stream.Write(ba, 0, ba.Length);

			byte[] bb = new byte[4];
			int k = stream.Read(bb, 0, bb.Length);

			string response = Encoding.Default.GetString(bb);

			if (response.Equals("1020"))
			{
				MainForm mainForm = new MainForm(stream, username.Text);

				this.Hide();

				mainForm.ShowDialog();

				this.Show();
			}
			else if (response.Equals("1021"))
				error.Text = "[ERROR]: Wrong Details!";
			else if (response.Equals("1022"))
				error.Text = "[ERROR]: User is already connected!";
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			string msg = "299";

			ASCIIEncoding asciiEncoding = new ASCIIEncoding();
			byte[] ba = asciiEncoding.GetBytes(msg);

			Console.WriteLine("Sending: " + msg);

			stream.Write(ba, 0, ba.Length);
		}

		private void registerBtn_Click(object sender, EventArgs e)
		{
			error.Text = "";

			RegisterForm registerForm = new RegisterForm(stream);

			this.Hide();

			registerForm.ShowDialog();

			this.Show();
		}
	}
}
