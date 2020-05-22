using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using ServerData;
using System.Net;

namespace Server
{
	class Server
	{
		static Socket listenerSocket;
		static List<ClientInformation> _clients;
		static void Main(string[] args)
		{
			Console.WriteLine($"IP Address of the server {Request.GetIpAddress()}");

			listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			_clients = new List<ClientInformation>();

			var ipEndpoint = new IPEndPoint(IPAddress.Parse(Request.GetIpAddress()), 4242);
			listenerSocket.Bind(ipEndpoint);

			Thread listenThread = new Thread(ListenThread);
			listenThread.Start();
		}

		static void ListenThread()
		{
			while(true)
			{
				listenerSocket.Listen(0);
				_clients.Add(new ClientInformation(listenerSocket.Accept()));
			}
		}

		public static void ReceivedMessage(object cSocket)
		{
			Socket clientSocket = cSocket as Socket;

			byte[] buffer;
			int readBytes;

			try
			{
				while(true)
				{
					buffer = new byte[clientSocket.SendBufferSize];
					readBytes = clientSocket.Receive(buffer);

					if(readBytes > 0)
					{
						ManageData(new Request(buffer));
					}
				}
			}
			catch(SocketException e)
			{
				Console.WriteLine($"A client has disconnected.");
			}
		}

		public static void ManageData(Request p)
		{
			switch (p._requestMethod)
			{
				case "Confirmation":
					break;
				case "Message":
					foreach ( ClientInformation c in _clients)
					{
						c.ClientSocket.Send(p.ToBytes());
					}
					break;
				default:
					break;
			}
		}
	}
}
