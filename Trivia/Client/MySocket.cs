using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
	class MySocket
	{
		private TcpClient tcpClient;
		private NetworkStream stream;
		private string IP;
		private uint PORT;

		public MySocket(string IP = "", uint PORT = 0)
		{
			this.IP = IP;
			this.PORT = PORT;
			
			try
			{
				tcpClient = new TcpClient();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.StackTrace);
			}
		}

		public void Connect(int timeout = 3)
		{
			Connect(IP, PORT, timeout);
		}

		public void Connect(string IP = "", uint PORT = 0, int timeout = 3)
		{
			Console.WriteLine("Connecting to {0}:{1}...", IP, PORT);

			try
			{
				if (tcpClient.ConnectAsync(IP, (int)PORT).Wait(TimeSpan.FromSeconds(timeout)))
				{
					stream = tcpClient.GetStream();
					Console.WriteLine("Connected!");
				}
				else
					throw new Exception("Could not connect!");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.StackTrace);

				if (MessageBox.Show("No running server was found at " + IP + ':' + PORT + "\nWould you like to try again?", "[ERROR]: No running server!", MessageBoxButtons.YesNo) == DialogResult.Yes)
					SocketConnect();
				else
					Environment.Exit(1);
			}
		}

		public void Send(string msg)
		{
			try
			{
				ASCIIEncoding asciiEncoding = new ASCIIEncoding();
				byte[] ba = asciiEncoding.GetBytes(msg);

				Console.WriteLine("Sending: " + msg);

				stream.Write(ba, 0, ba.Length);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public string Read(int numOfBytes)
		{
			string response = "";

			try
			{
				byte[] bb = new byte[numOfBytes];
				int k = stream.Read(bb, 0, bb.Length);

				response = Encoding.Default.GetString(bb);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return response;
		}
	}
}
