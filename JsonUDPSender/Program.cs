using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonUDPSender
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonSender jsonSender = new JsonSender();
            jsonSender.Start();
        }
    }
}
