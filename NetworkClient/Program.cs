using System;

namespace NetworkClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TCPClient client = new TCPClient("127.0.0.1", 5000);
            client.Start();
        }
    }
}
