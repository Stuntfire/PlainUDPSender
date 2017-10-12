using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModelLib;

namespace XmlUDPSender
{
    public class UdpXmlSender
    {
        private int Port = 10002;

        public void Start()
        {
            Car newCar = new Car() { Color = "Blue", Model = "Tesla", RegNo = "XMLCar23" };

            using (UdpClient client = new UdpClient())
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, Port);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Car));

                StringWriter stringWriter = new StringWriter();

                xmlSerializer.Serialize(stringWriter, newCar);

                byte[] dataGram = Encoding.ASCII.GetBytes(stringWriter.ToString());

                try
                {
                    client.Send(dataGram, dataGram.Length, endPoint);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                Console.WriteLine($"Prøver at sende: \n{dataGram} \nvia {endPoint}");

                //byte[] recievedBytes = senderClient.Receive(ref reseiversEndPoint);

                //Console.WriteLine($"Afsenders adr : {reseiversEndPoint.Address} og port : {reseiversEndPoint.Port}");

                //String recievedString = Encoding.ASCII.GetString(recievedBytes);
                //Console.WriteLine(recievedString);
            }


        }
    }
}
