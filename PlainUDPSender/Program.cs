﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainUDPSender
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPSender udpSender = new UDPSender();
            udpSender.Start();
        }
    }
}
