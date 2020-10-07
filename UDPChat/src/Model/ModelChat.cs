using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace UDPChat
{
    public class ModelChat
    {
        private string userName;
        public int Localport;
        public int Remoteport;
        IPAddress GroupAdress;
        UdpClient client;
        bool alive;

        public void UserLogIn(string username)
        {
            alive = true;
            this.userName = username;
            GroupAdress = IPAddress.Parse(Properties.Settings.Default.Host);
            client = new UdpClient(Localport);
            client.JoinMulticastGroup(GroupAdress, Properties.Settings.Default.TTL);
        }
        public void SendMessage(string message)
        {
            message = userName + message;
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, Properties.Settings.Default.Host, Remoteport);
        }
        public string ReceiveMessage()
        {
            if (alive)
            {
                IPEndPoint remoteIp = null;
                byte[] data = client.Receive(ref remoteIp);
                return Encoding.Unicode.GetString(data) + "\r\n";
            }
            return null;
        }
        public void Disconnect()
        {
            alive = false;
            SendMessage(" покинул чат");
            client.DropMulticastGroup(GroupAdress);
            client.Dispose();
            client.Close();
            Environment.Exit(0);
        }
    }
}
