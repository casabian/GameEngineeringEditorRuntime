using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Text;
using System;

namespace ToolNativeRuntimeCommunication
{
	public class Server
	{
		public string MessageToSend { set; get; }

		private TcpListener tcpListener;
		private Thread listenerThread;

		public Server()
		{
			MessageToSend = "";
		}

		public void Start()
		{
			tcpListener = new TcpListener(IPAddress.Any, 50000);
			listenerThread = new Thread(new ThreadStart(ListenForClients));
			listenerThread.IsBackground = true; //thread doesn't prevent the application from closing
			listenerThread.Start();
		}

		private void ListenForClients()
		{
			tcpListener.Start();
			ASCIIEncoding asciiEncoding = new ASCIIEncoding();
			
			while (true)
			{
				TcpClient client = tcpListener.AcceptTcpClient();
				while (client.Connected)
				{
					if (MessageToSend.Length > 0)
					{
						string message;
						lock (MessageToSend)
						{
							message = MessageToSend;
							MessageToSend = "";
						}
						Console.WriteLine(message);
						byte[] buffer = asciiEncoding.GetBytes(message + "\r\n");
						NetworkStream stream = client.GetStream();
						stream.Write(buffer, 0, buffer.Length);
						stream.Flush();
					}
				}
			}
		}
	}
}