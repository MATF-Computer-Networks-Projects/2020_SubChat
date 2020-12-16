using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NetworkClient
{
    // Message object for receiving data from remote device.
    public class Message
    {
        // Size of receive buffer.
        public const int bufferSize = 1024;

        // Receive buffer.
        private byte[] _buffer = new byte[bufferSize];
        public byte[] Buffer
        {
            get => _buffer;
        }

        // Received data string.
        private StringBuilder _store = new StringBuilder();
        public StringBuilder Store
        {
            get => _store;
            set => _store = value;
        }


        // Client socket.
        private Socket _workSocket = null;
        public Socket WorkSocket
        {
            get => _workSocket;
            set => _workSocket = value;
        }
    }

    class TCPClient
    {

        // ManualResetEvent instances signal completion.
        private ManualResetEvent _connectionSignaler;
        private ManualResetEvent _sendSignaler;
        private ManualResetEvent _receiveSignaler;

        // The port number for the remote device.
        private int _port;

        // The IP adress of host.
        private String _host;

        // The response from the remote device.
        private String _response = String.Empty;

        public TCPClient(String host, int port)
        {
            _connectionSignaler = new ManualResetEvent(false);
            _sendSignaler = new ManualResetEvent(false);
            _receiveSignaler = new ManualResetEvent(false);
            _host = host;
            _port = port;
        }

        public void Start()
        {
            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.
                // Currently using localhost.
                IPHostEntry ipHostInfo = Dns.GetHostEntry(IPAddress.Loopback);
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, _port);

                // Create a TCP/IP socket.
                Socket client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                // Connect to the remote endpoint.
                client.BeginConnect(remoteEP, new AsyncCallback(ConnectCallback), client);
                _connectionSignaler.WaitOne();

                // Send test data to the remote device.
                Send(client, "Some random text.<EOF>");
                _sendSignaler.WaitOne();

                // Receive the _response from the remote device.
                Receive(client);
                _receiveSignaler.WaitOne();

                // Write the response to the console.
                Console.WriteLine("Response received : {0}", _response);

                // Release the socket.
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the Message object.
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.
                client.EndConnect(ar);

                Console.WriteLine("Socket connected to {0}", client.RemoteEndPoint.ToString());

                // Signal that the connection has been made.
                _connectionSignaler.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Receive(Socket client)
        {
            try
            {
                Message msg = new Message();
                msg.WorkSocket = client;

                // Begin receiving the data from the remote device.
                client.BeginReceive(msg.Buffer, 0, Message.bufferSize, 0, new AsyncCallback(ReceiveCallback), msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the message and the client socket from the async Message object.
                Message msg = (Message)ar.AsyncState;
                Socket client = msg.WorkSocket;

                // Read data from the remote device.
                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.
                    msg.Store.Append(Encoding.ASCII.GetString(msg.Buffer, 0, bytesRead));

                    // Get the rest of the data.
                    client.BeginReceive(msg.Buffer, 0, Message.bufferSize, 0, new AsyncCallback(ReceiveCallback), msg);
                }
                else
                {
                    // All the data has arrived; put it in _response.
                    if (msg.Store.Length > 1)
                    {
                        _response = msg.Store.ToString();
                    }

                    // Signal that all bytes have been received.
                    _receiveSignaler.Set();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Send(Socket client, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.
            client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), client);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the Message object.
                Socket client = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = client.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to server.", bytesSent);

                // Signal that all bytes have been sent.
                _sendSignaler.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
