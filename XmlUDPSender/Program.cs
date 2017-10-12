using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlUDPSender
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpXmlSender udpXmlSender = new UdpXmlSender();

            udpXmlSender.Start();
        }
    }
}
