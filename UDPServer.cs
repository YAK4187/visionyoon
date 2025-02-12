using System;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace DOT_Number_Reading
{
    public class UDPServer
    {
        private UdpClient udpClient;
        private readonly int port;
        private bool isReceiving;
        private Thread receiveThread;
        private Logger logger;

        // Delegate for updating UI with received data
        public delegate void SetTextCallback(string text);
        private SetTextCallback setTextDelegate;

        public UDPServer(int port, SetTextCallback setTextCallback, Logger logger)
        {
            this.port = port;
            udpClient = new UdpClient(port);
            setTextDelegate = setTextCallback;
            this.logger = logger;
        }

        // Start receiving data
        public void StartReceiving()
        {
            if (isReceiving)
                return;

            isReceiving = true;
            receiveThread = new Thread(DoReceive)
            {
                IsBackground = true
            };
            receiveThread.Start();
        }

        // Main loop for receiving data
        private void DoReceive()
        {
            try
            {
                while (isReceiving)
                {
                    ReceiveData();
                }
            }
            catch (Exception ex)
            {
                logger.LogMessage($"Receiving loop stopped due to error: {ex.Message}", true);
            }
        }

        // Receive data and update UI
        private void ReceiveData()
        {
            try
            {
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, port);
                byte[] receivedBytes = udpClient.Receive(ref remoteEndPoint);
                string receivedData = Encoding.UTF8.GetString(receivedBytes);

                if (setTextDelegate != null)
                {
                    setTextDelegate(receivedData);
                }
            }
            catch (Exception ex)
            {
                if (logger != null)
                {
                    logger.LogMessage($"Receive Error: {ex.Message}", true);
                }
            }
        }

        // Stop receiving data
        public void StopReceiving()
        {
            if (!isReceiving)
                return;

            isReceiving = false;

            if (receiveThread != null)
            {
                receiveThread.Join(); // Wait for the receive thread to finish
            }

            udpClient.Dispose();
        }
    }
}