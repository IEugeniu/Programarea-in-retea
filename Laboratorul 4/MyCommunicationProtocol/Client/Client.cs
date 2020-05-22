using System;
using ServerData;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using static System.Console;

namespace Client
{
	class Client
	{
		public static Socket socket;
		public static string username;
		public static string id;
		static void Main(string[] args)
		{
			Write("Choose your username: ");
			username = ReadLine().Trim();
			bool connected = false;

			while (!connected)
			{
				Clear();
				Write($"Server ip address: ");
				string ip = ReadLine().Trim();

				socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				IPEndPoint ipEndpoint = new IPEndPoint(IPAddress.Parse(ip), 4242);

				try
				{
					socket.Connect(ipEndpoint);
					connected = true;
				}
				catch (Exception)
				{
					WriteLine($"Could not connect to host.");
					connected = false;
					Thread.Sleep(2000);
				}
			}

			Thread th = new Thread(ReceiveData);
			th.Start();

			while (true)
			{
				string input = ReadLine().Trim();

				var request = new Request("Message", id);
				request._message.Add(username);
				request._message.Add(input);
				socket.Send(request.ToBytes());
			}
		}

		static void ReceiveData()
		{
			byte[] buffer;
			int readBytes;

			try
			{
				while (true)
				{
					buffer = new byte[socket.SendBufferSize];
					readBytes = socket.Receive(buffer);
					if (readBytes > 0)
					{
						ManageData(new Request(buffer));
					}
				}
			}
			catch (SocketException ex)
			{
				WriteLine("Server has disconnected.");
				ReadLine();
				Environment.Exit(0);
			}
		}

		static void ManageData(Request r)
		{
			switch (r._requestMethod)
			{
				case "Confirmation":
					WriteLine($"Confirmation received.");
					id = r._message[0];
					WriteLine();
					break;
				case "Message":
					WriteLine($"{r._message[0]} : {r._message[1]}");
					break;
				default:
					break;
			}
		}
	}
}
