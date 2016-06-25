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
	public partial class MainForm : Form
	{
		Stream stream;
		string username;

		public MainForm(Stream stream, string username)
		{
			InitializeComponent();

			this.stream = stream;

			this.username = username;
			user.Text = "Hello " + username + " !";
		}

		private void joinRoomBtn_Click(object sender, EventArgs e)
		{
			JoinRoomForm joinRoomForm = new JoinRoomForm(stream, username);

			this.Hide();

			joinRoomForm.ShowDialog();

			this.Show();
		}
	}
}
