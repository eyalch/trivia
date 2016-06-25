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
	public partial class RoomAsPlayerForm : Form
	{
		Stream stream;
		int roomId;

		public RoomAsPlayerForm(Stream stream, string username, int roomId)
		{
			InitializeComponent();

			this.stream = stream;

			user.Text = "Hello " + username + " !";

			this.roomId = roomId;

			string msg = "207" + roomId;

			ASCIIEncoding asciiEncoding = new ASCIIEncoding();
			byte[] ba = asciiEncoding.GetBytes(msg);

			Console.WriteLine("Sending: " + msg);

			stream.Write(ba, 0, ba.Length);
		}

		void GetUsers()
		{
			byte[] bb = new byte[3];
			int k = stream.Read(bb, 0, bb.Length);
			string response = Encoding.Default.GetString(bb);

			if (response.Equals("108"))
			{
				bb = new byte[1];
				k = stream.Read(bb, 0, bb.Length);
				response = Encoding.Default.GetString(bb);

				int numberOfUsers = Convert.ToInt32(response);

				List<string> _items = new List<string>();

				for (int i = 0; i < numberOfUsers; i++)
				{
					bb = new byte[2];
					k = stream.Read(bb, 0, bb.Length);
					response = Encoding.Default.GetString(bb);

					bb = new byte[Convert.ToInt32(response)];
					k = stream.Read(bb, 0, bb.Length);
					response = Encoding.Default.GetString(bb);

					_items.Add(response);
				}

				list.DataSource = _items;
			}
		}
	}
}
