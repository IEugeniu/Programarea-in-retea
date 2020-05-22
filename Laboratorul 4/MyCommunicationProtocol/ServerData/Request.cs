using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace ServerData
{
	[Serializable]
	public class Request
	{

		public List<string> _message;
		public int _requestInt;
		public bool _requestBool;
		public string _senderId;
		public string _requestMethod;

		public Request(string requestMethod, string senderId)
		{
			_message = new List<string>();
			_senderId = senderId;
			_requestMethod = requestMethod;
		}

		public Request(byte[] requestBytes)
		{
			var bf = new BinaryFormatter();
			var ms = new MemoryStream(requestBytes);
			Request p = bf.Deserialize(ms) as Request;
			ms.Close();
			_message = p._message;
			_requestInt = p._requestInt;
			_requestBool = p._requestBool;
			_senderId = p._senderId;
			_requestMethod = p._requestMethod;
		}

		public byte[] ToBytes()
		{
			BinaryFormatter bf = new BinaryFormatter();
			MemoryStream ms = new MemoryStream();

			bf.Serialize(ms, this);
			byte[] bytes = ms.ToArray();
			ms.Close();

			return bytes;
		}

		public static string GetIpAddress()
		{
			IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
			foreach (IPAddress iP in ips)
			{
				if(iP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
				{
					return iP.ToString();
				}
			}
			
			return "127.0.0.1";
		}
	}
}
