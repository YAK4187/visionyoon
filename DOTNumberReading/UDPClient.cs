using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace DOT_Number_Reading
{
    public class UDPClient : IDisposable
    {
        private UdpClient udpClient;
        private IPEndPoint remoteEndPoint;

        // Initialise UDP Client
        public UDPClient(string ipAddress, int port)
        {
            udpClient = new UdpClient();
            remoteEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
        }

        // Send command to EyeVision
        public void SendCommand(string command)
        {
            var data = Encoding.ASCII.GetBytes(command);
            udpClient.Send(data, data.Length, remoteEndPoint);
        }

        public void Dispose()
        {
            if (udpClient != null)
            {
                udpClient.Close();
                udpClient = null; // Ensure the client is set to null after closing
            }
        }
    }
}