using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ModelLib;
using Newtonsoft.Json;

namespace JsonUDPSender
{
    class JsonSender
    {
        public int Port = 10003;

        public JsonSender()
        {

        }

        public void Start()
        {
            Car jsonCar = new Car() { Model = "Tesla", Color = "Green", RegNo = "JsonCar4" };

            using (UdpClient client = new UdpClient())
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, Port);

                String jsonString = JsonConvert.SerializeObject(jsonCar, Formatting.Indented);

                byte[] dataGram = Encoding.ASCII.GetBytes(jsonString);

                Console.WriteLine($"Prøver at sende : \n\n{jsonString} \n\nvia : {endPoint}");

                try
                {
                    client.Send(dataGram, dataGram.Length, endPoint);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
