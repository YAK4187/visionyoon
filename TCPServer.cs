using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class TCPServer
{
    private TcpListener listener; // Server socket
    private TcpClient client; // Client connection
    private NetworkStream ns; // Data stream
    private Thread listenerThread; // Thread for waiting for client connections
    private Thread receiveThread; // Thread for receiving data
    private Action<string> onDataReceived; // Callback invoked when data is received
    private Action<string> onServerMessage; // Callback for server messages

    public bool IsRunning { get; private set; } = false;

    // Constructor
    public TCPServer(Action<string> onDataReceived, Action<string> onServerMessage)
    {
        this.onDataReceived = onDataReceived;
        this.onServerMessage = onServerMessage;
    }

    // Start the server
    public void Start(string ipAddress, int port)
    {
        try
        {
            listener = new TcpListener(IPAddress.Parse(ipAddress), port);
            listener.Start();
            IsRunning = true;

            onServerMessage?.Invoke($"Server started on {ipAddress}:{port}. Waiting for client...");

            // Start the thread to wait for client connections
            listenerThread = new Thread(AcceptClient);
            listenerThread.IsBackground = true;
            listenerThread.Start();
        }
        catch (Exception ex)
        {
            onServerMessage?.Invoke($"Server start error: {ex.Message}");
        }
    }

    // Stop the server
    public void Stop()
    {
        try
        {
            IsRunning = false;
            listener?.Stop();
            client?.Close();
            ns?.Close();

            listenerThread?.Abort();
            receiveThread?.Abort();

            onServerMessage?.Invoke("Server stopped.");
        }
        catch (Exception ex)
        {
            onServerMessage?.Invoke($"Server stop error: {ex.Message}");
        }
    }

    // Wait for client connections
    private void AcceptClient()
    {
        try
        {
            client = listener.AcceptTcpClient(); // Accept client connection
            ns = client.GetStream(); // Initialize the stream
            onServerMessage?.Invoke("Client connected.");

            // Start the thread to receive data
            receiveThread = new Thread(ReceiveData);
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }
        catch (Exception ex)
        {
            onServerMessage?.Invoke($"Client accept error: {ex.Message}");
        }
    }

    // Receive data
    private void ReceiveData()
    {
        try
        {
            byte[] buffer = new byte[1024];
            while (IsRunning)
            {
                int bytesRead = ns.Read(buffer, 0, buffer.Length);
                if (bytesRead > 0)
                {
                    string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    onDataReceived?.Invoke(receivedData); // Invoke the data received callback
                }
            }
        }
        catch (Exception ex)
        {
            onServerMessage?.Invoke($"Receiving error: {ex.Message}");
            Stop(); // Stop the server on error
        }
    }

    // Send data
    public void SendData(string message)
    {
        try
        {
            if (client != null && client.Connected && ns != null)
            {
                byte[] byteData = Encoding.ASCII.GetBytes(message);
                ns.Write(byteData, 0, byteData.Length);
                onServerMessage?.Invoke($"Sent: {message}");
            }
            else
            {
                onServerMessage?.Invoke("No client connected.");
            }
        }
        catch (Exception ex)
        {
            onServerMessage?.Invoke($"Sending error: {ex.Message}");
        }
    }
}
