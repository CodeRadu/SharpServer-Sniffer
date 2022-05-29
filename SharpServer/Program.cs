using Server;
public class SharpServer
{
    static void Main(string[] args)
    {
        int port = 3000;
        if (args.Length > 0) port = int.Parse(args[0]);
        else Console.WriteLine("You can specify a port: SharpServer.exe <port>");
        WebServer server = new WebServer(port);
    }
}