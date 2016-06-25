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
	public partial class JoinRoomForm : Form
	{
		Stream stream;

		public JoinRoomForm(Stream stream, string username)
		{
			InitializeComponent();

			this.stream = stream;

			user.Text = "Hello " + username + " !";

			string msg = "205";

			ASCIIEncoding asciiEncoding = new ASCIIEncoding();
			byte[] ba = asciiEncoding.GetBytes(msg);

			Console.WriteLine("Sending: " + msg);

			stream.Write(ba, 0, ba.Length);

			GetRooms();
		}

		void GetRooms()
		{
			byte[] bb = new byte[3];
			int k = stream.Read(bb, 0, bb.Length);
			string response = Encoding.Default.GetString(bb);

			if (response.Equals("106"))
			{
				bb = new byte[4];
				k = stream.Read(bb, 0, bb.Length);
				response = Encoding.Default.GetString(bb);

				int roomCount = Convert.ToInt32(response);

				List<string> _items = new List<string>();

				for (int i = 0; i < roomCount; i++)
				{
					bb = new byte[4];
					k = stream.Read(bb, 0, bb.Length);
					response = Encoding.Default.GetString(bb);

					int roomId = Convert.ToInt32(response);

					bb = new byte[2];
					k = stream.Read(bb, 0, bb.Length);
					response = Encoding.Default.GetString(bb);

					bb = new byte[Convert.ToInt32(response)];
					k = stream.Read(bb, 0, bb.Length);
					response = Encoding.Default.GetString(bb);

					_items.Add(response + " - ID: " + roomId);
				}

				list.DataSource = _items;
			}
		}

		private void refreshBtn_Click(object sender, EventArgs e)
		{
			list.Items.Clear();

			GetRooms();
		}

		private void joinBtn_Click(object sender, EventArgs e)
		{

		}
	}
}
