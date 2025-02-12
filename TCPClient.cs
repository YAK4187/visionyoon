using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class TCPClient
{
    private TcpClient client; // Client connection
    private NetworkStream ns; // Data stream
    private Thread receiveThread; // Thread for receiving data
    private Action<string> onDataReceived; // Callback for received data
    public bool IsConnected { get; private set; }

    // Constructor
    public TCPClient(Action<string> onDataReceived)
    {
        this.onDataReceived = onDataReceived;
    }

    // Connect to the server
    public bool Connect(string host, int port)
    {
        try
        {
            client = new TcpClient(host, port);
            ns = client.GetStream();

            // Start the thread to receive data
            receiveThread = new Thread(ReceiveData);
            receiveThread.IsBackground = true;
            receiveThread.Start();

            IsConnected = true;
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[TCPClient] Connection error: {ex.Message}");
            return false;
        }
    }

    // Disconnect from the server
    public void Disconnect()
    {
        try
        {
            if (receiveThread != null && receiveThread.IsAlive)
            {
                receiveThread.Abort(); // Stop the receiving thread
            }
            ns?.Close();
            client?.Close();

            IsConnected = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[TCPClient] Disconnection error: {ex.Message}");
        }
    }

    // Send data to the server
    public void SendData(string data)
    {
        try
        {
            if (IsConnected && ns != null)
            {
                byte[] byteData = Encoding.ASCII.GetBytes(data);
                ns.Write(byteData, 0, byteData.Length);
            }
            else
            {
                Console.WriteLine("[TCPClient] Not connected to the server.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[TCPClient] Sending error: {ex.Message}");
        }
    }

    // Receive data from the server
    private void ReceiveData()
    {
        try
        {
            byte[] buffer = new byte[1024];
            while (IsConnected)
            {
                int bytesRead = ns.Read(buffer, 0, buffer.Length);
                if (bytesRead > 0)
                {
                    string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    // Invoke the callback for received data
                    onDataReceived?.Invoke(receivedData);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[TCPClient] Receiving error: {ex.Message}");
            Disconnect();
        }
    }
}
