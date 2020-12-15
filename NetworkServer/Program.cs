using System;

namespace NetworkServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TCPServer server = new TCPServer("127.0.0.1", 5000);
            server.Start();
        }
    }
}
