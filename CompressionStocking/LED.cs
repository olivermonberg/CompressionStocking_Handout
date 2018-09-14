using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking
{
    public interface ILED
    {
        void GreenLedOn();
        void GreenLedOff();
        void RedLedOn();

        void RedLedOff();
    }

    public class LED : ILED
    {
        public void GreenLedOn()
        {
            Console.WriteLine("Green LED is on.");
        }

        public void GreenLedOff()
        {
            Console.WriteLine("Green LED is off.");
        }

        public void RedLedOn()
        {
            Console.WriteLine("Red LED is on.");
        }

        public void RedLedOff()
        {
            Console.WriteLine("Red LED is off.");
        }
    }
}
