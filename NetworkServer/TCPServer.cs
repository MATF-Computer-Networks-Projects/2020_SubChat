using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace NetworkServer
{
    // Message object for sending data from remote device.
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

    class TCPServer
    {
        // Thread signal.
        private ManualResetEvent _connectionSignaler;

        // The port number for the remote device.
        private int _port { get; }

        // The IP adress of host.
        private String _host { get; }

        public TCPServer(String host, int port)
        {
            _connectionSignaler = new ManualResetEvent(false);
            _host = host;
            _port = port;
        }

        public void Start()
        {
            // Establish the local endpoint for the socket.
            // Currently using localhost.
            IPHostEntry ipHostInfo = Dns.GetHostEntry(IPAddress.Loopback);
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, _port);

            // Create a TCP/IP socket.
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections.
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);

                while (true)
                {
                    // Set the event to nonsignaled state.
                    _connectionSignaler.Reset();

                    // Start an asynchronous socket to listen for connections.
                    Console.WriteLine("Waiting for a connection...");
                    listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);

                    // Wait until a connection is made before continuing.
                    _connectionSignaler.WaitOne();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("Press ENTER to continue...");
            Console.Read();
        }

        public void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.
            _connectionSignaler.Set();

            // Get the socket that handles the client request.
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Receiving message from client.
            Message msg = new Message();
            msg.WorkSocket = handler;
            handler.BeginReceive(msg.Buffer, 0, Message.bufferSize, 0, new AsyncCallback(ReadCallback), msg);
        }

        public void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // Retrieve the message and the handler socket from the async Message object.
            Message msg = (Message)ar.AsyncState;
            Socket handler = msg.WorkSocket;

            // Read data from the client socket.
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // There might be more data, so store the data received so far.
                msg.Store.Append(Encoding.ASCII.GetString(msg.Buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read more data.
                content = msg.Store.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // All the data has been read from the client.
                    Console.WriteLine("Read {0} bytes from socket.", content.Length);
                    Console.WriteLine("Data: {0}", content);

                    // Echo the data back to the client.
                    Send(handler, content);
                }
                else
                {
                    // Not all data received. Get more.
                    handler.BeginReceive(msg.Buffer, 0, Message.bufferSize, 0, new AsyncCallback(ReadCallback), msg);
                }
            }
        }

        private void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.
            handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), handler);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
