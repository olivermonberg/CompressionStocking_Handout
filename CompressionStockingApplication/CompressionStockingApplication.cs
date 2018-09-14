using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompressionStocking;

namespace CompressionStockingApplication
{

    class CompressionStockingApplication
    {
        static void Main(string[] args)
        {
            StockingCtrl compressionStockingstocking = new StockingCtrl();

            //var compressionStockingstocking = new StockingCtrl(new CompressionCtrlForLaces());
            ConsoleKeyInfo consoleKeyInfo;
            
            Console.WriteLine("Compression Stocking Control User Interface");
            Console.WriteLine("Choose compress mode. Q for Pumpmode. W for Lacesmode.");
            consoleKeyInfo = Console.ReadKey(true);

            if (consoleKeyInfo.Key == ConsoleKey.Q) compressionStockingstocking = new StockingCtrl(new CompressionCtrlForPump());
            if (consoleKeyInfo.Key == ConsoleKey.W) compressionStockingstocking = new StockingCtrl(new CompressionCtrlForLaces());

            Console.WriteLine("A:   Compress");
            Console.WriteLine("Z:   Decompress");
            Console.WriteLine("ESC: Terminate application");

            do
            {
                consoleKeyInfo = Console.ReadKey(true); // true = do not echo character
                if (consoleKeyInfo.Key == ConsoleKey.A)  compressionStockingstocking.StartBtnPushed();
                if (consoleKeyInfo.Key == ConsoleKey.Z)  compressionStockingstocking.StopBtnPushed();

            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
        }
    }
}
