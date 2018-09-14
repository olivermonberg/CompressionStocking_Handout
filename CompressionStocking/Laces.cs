using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking
{
    public interface ILacesCtrlForStockings
    {
        void CompressLaces();
        void DecompressLaces();
    }

    public class LacesCtrlForStockings : ILacesCtrlForStockings
    {
        ILaces _Laces = new Laces();
        ITimer _Timer = new Timer();

        public void CompressLaces()
        {
            for(int i = 0; i < 40; i++)
            {
                _Laces.Tighten();
                _Timer.SetTimer(100);
            }

            Console.WriteLine("Laces compressed by 40 clicks.");            
        }

        public void DecompressLaces()
        {
            for (int i = 0; i < 40; i++)
            {
                _Laces.Loosen();
                _Timer.SetTimer(100);
            }

            Console.WriteLine("Laces decompressed by 40 clicks.");
        }
    }

    public interface ILaces
    {
        void Tighten();
        void Loosen();
    }

    public class Laces : ILaces
    {
        public void Tighten()
        {
            Console.WriteLine("Tightening laces one click.");
        }

        public void Loosen()
        {
            Console.WriteLine("Loosening laces one click.");
        }
    }
}
