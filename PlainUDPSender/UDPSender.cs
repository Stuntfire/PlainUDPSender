using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ModelLib;

namespace PlainUDPSender
{
    public class UDPSender
    {
        private int Port = 11001;

        public void Start()
        {
            Car newCar = new Car() { Color = "Red", Model = "Teasla P100", RegNo = "TA 56007" };

            UdpClient client = new UdpClient();

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, Port);

            byte[] dataGram = Encoding.ASCII.GetBytes(newCar.ToString());

            try
            {
                client.Send(dataGram, dataGram.Length, endPoint);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            //byte[] recievedBytes = senderClient.Receive(ref reseiversEndPoint);

            //Console.WriteLine($"Afsenders adr : {reseiversEndPoint.Address} og port : {reseiversEndPoint.Port}");

            //String recievedString = Encoding.ASCII.GetString(recievedBytes);
            //Console.WriteLine(recievedString);
        }
    }
}
