using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace CompressionStocking
{
    public interface ITimer
    {
        void SetTimer(int ms);
    }

    public class Timer : ITimer
    {
        //private static System.Timers.Timer Timer_;

        public void SetTimer(int ms)
        {
            Console.WriteLine($"Timer for {ms} ms started.");

            System.Threading.Thread.Sleep(ms);

            /*
            Timer_ = new System.Timers.Timer(ms);

            Timer_.Start();
            */

            Console.WriteLine($"Timer for {ms} ms stopped.");
        }
    }
}
