using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        IPAddress broadcast = IPAddress.Parse("192.168.1.157");
        Console.WriteLine("Enter the message to be sent");
        var message = Console.ReadLine();
        while (message != String.Empty)
        {
            byte[] sendbuf = Encoding.UTF8.GetBytes(message);
            IPEndPoint ep = new IPEndPoint(broadcast, 27015);

            s.SendTo(sendbuf, ep);
            Console.WriteLine("Message sent");
            message = Console.ReadLine();
        }
        Console.ReadLine();
    }
}