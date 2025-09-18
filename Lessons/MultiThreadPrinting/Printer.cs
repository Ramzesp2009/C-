using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadPrinting;

public class Printer
{
    private object threadLock = new object();
    public void PrintNumbers()
    {
        lock (threadLock)
        {
            Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");

            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                Thread.Sleep(500 * r.Next(5));
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
        }
    }
}
