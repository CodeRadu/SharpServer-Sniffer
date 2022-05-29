namespace Server
{
    using System;
    using System.Net.Sockets;
    using System.Threading;


    class WebServer
    {
        private TcpListener _listener;
        public WebServer(int port)
        {
            _listener = new TcpListener(port);
            try
            {
                _listener.Start();
                Console.WriteLine("Listening on: http://localhost:" + port);
                Console.WriteLine("Connections made to the server will hang.");
                Thread th = new Thread(new ThreadStart(Listen));
                th.Start();

            } catch(Exception e)
            {
                Console.WriteLine("Could not start server: " + e.ToString());
            }

        }
        public void Listen()
        {
            while(true)
            {
                Socket socket = _listener.AcceptSocket();
                if(socket.Connected)
                {
                    Console.WriteLine(socket.RemoteEndPoint);
                }
            }
        }
    }
}
