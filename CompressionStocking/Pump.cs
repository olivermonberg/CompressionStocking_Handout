using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking
{
    public interface IPumpCtrlForStockings
    {
        void PumpCompress();

        void PumpDecompress();
    }

    public class PumpCtrlForStockings : IPumpCtrlForStockings
    {
        private readonly IPump pump_ = new Pump();

        private bool IsCompressed = false;

        public void PumpCompress()
        {
            if (IsCompressed == false)
            {
                pump_.PumpForward();

                ITimer t = new Timer();
                t.SetTimer(2000);

                pump_.StopPump();

                Console.WriteLine("Compression complete.");
                Console.WriteLine("");

                IsCompressed = true;
            }
        }

        public void PumpDecompress()
        {
            if (IsCompressed == true)
            {
                pump_.PumpBackward();

                ITimer t = new Timer();
                t.SetTimer(2000);

                pump_.StopPump();

                Console.WriteLine("Decompression complete.");
                Console.WriteLine("");

                IsCompressed = false;
            }
        }
    }

    public interface IPump
    {
        void PumpForward();

        void PumpBackward();

        void StopPump();
    }

    public class Pump : IPump
    {
        public void PumpForward()
        {
            Console.WriteLine("Pump started, pumping forward.");
        }

        public void PumpBackward()
        {
            Console.WriteLine("Pump started, pumping backward.");
        }

        public void StopPump()
        {
            Console.WriteLine("Pump stopped.");
        }
    }
}
