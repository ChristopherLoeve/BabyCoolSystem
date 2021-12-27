using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace BabyAlarmSender
{
    class Program
    {
        static void Main(string[] args)
        {
            var udpClient = new UdpClient();
            udpClient.Connect(new IPEndPoint(IPAddress.Broadcast, 7000));

            while (true)
            {
                var msg = GetRandomData();
                Console.WriteLine($"Sending: {msg}");
                byte[] bytes = Encoding.UTF8.GetBytes(msg);

                udpClient.Send(bytes, bytes.Length); // send msg as bytes


                Thread.Sleep(5000); // lower delay for testing purposes
                //Thread.Sleep(15000); // sleep for 15 seconds
            }
        }

        public static string GetRandomData()
        {
            Random random = new Random();
            int unitNo = 1;
            int breath = random.Next(8, 25);
            int cry = random.Next(0, 2);

            return $"{unitNo},{breath},{cry}";
        }
    }
}
