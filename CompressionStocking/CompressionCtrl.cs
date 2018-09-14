using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking
{
    public interface ICompressionCtrl
    {
        void Compress();
        void Decompress();
    }

    public class CompressionCtrlForPump : ICompressionCtrl
    {
        /*private readonly Pump pump_;

        public CompressionCtrl(Pump pump)
        {
            pump_ = pump;
        }*/

        IPumpCtrlForStockings _pumpForStocking = new PumpCtrlForStockings();
        ILED _LED = new LED();

       

        public void Compress()
        {
            _LED.GreenLedOn();
            _pumpForStocking.PumpCompress();
            
            _LED.GreenLedOff();
        }

        public void Decompress()
        {
            _LED.RedLedOn();
            _pumpForStocking.PumpDecompress();
            
            _LED.RedLedOff();
        }
    }

    public class CompressionCtrlForLaces : ICompressionCtrl
    {
        /*private readonly Pump pump_;

        public CompressionCtrl(Pump pump)
        {
            pump_ = pump;
        }*/

        
        ILED _LED = new LED();

        ILacesCtrlForStockings _LacesForStocking = new LacesCtrlForStockings();

        public void Compress()
        {
            _LED.GreenLedOn();
            
            _LacesForStocking.CompressLaces();
            _LED.GreenLedOff();
        }

        public void Decompress()
        {
            _LED.RedLedOn();
            
            _LacesForStocking.DecompressLaces();
            _LED.RedLedOff();
        }
    }
}
