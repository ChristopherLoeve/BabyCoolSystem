using BabyLibrary;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BabyAlarmReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            var udpClient = new UdpClient(7000);

            while (true)
            {
                IPEndPoint remoteEP = null;

                byte[] data = udpClient.Receive(ref remoteEP);
                Console.WriteLine($"Received data from {remoteEP.Address}:{remoteEP.Port}");

                string msg = DecodeBytes(data);
                Console.WriteLine(msg);
            }
        }

        public static string DecodeBytes(byte[] data)
        {
            var msg = Encoding.UTF8.GetString(data);
            var splitMsg = msg.Split(',');
            int unitNo = Convert.ToInt32(splitMsg[0]);
            int breath = Convert.ToInt32(splitMsg[1]);
            int cry = Convert.ToInt32(splitMsg[2]);

            var bpm = BabyCool.AlarmBreath(breath);
            var crying = BabyCool.AlarmCry(cry);

            string consoleMsg = $"Babyalarm data fra unit {unitNo}:";
            consoleMsg += $"\nVejtrækninger per minut er {bpm} og babyen græder";
            if (!crying) consoleMsg += " ikke";

            return consoleMsg;
        }
    }
}
