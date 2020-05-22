using ServerData;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
	class ClientInformation
	{
		public Socket ClientSocket { get; }
		public Thread ClientThread { get; }
		public string Id { get; set; }

		public ClientInformation()
		{
			Id = Guid.NewGuid().ToString();
			ClientThread = new Thread(Server.ReceivedMessage);
			ClientThread.Start(ClientSocket);
			SendRegistrationPacket();
		}

		public ClientInformation(Socket clientSocket)
		{
			ClientSocket = clientSocket;
			Id = Guid.NewGuid().ToString();
			ClientThread = new Thread(Server.ReceivedMessage);
			ClientThread.Start(ClientSocket);
			SendRegistrationPacket();
		}

		public void SendRegistrationPacket()
		{
			Request p = new Request("Confirmation", "server");
			p._message.Add(Id);
			ClientSocket.Send(p.ToBytes());
		}
	}
}
