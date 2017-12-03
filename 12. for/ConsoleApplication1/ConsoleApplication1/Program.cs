using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int time = 1; time <= 9; time = time + 1)
            {
                int result = 7 * time;
                Console.WriteLine(time + " х 7 = " + result);
                Thread.Sleep(1000);
            }
            Console.Read();
        }
    }
}
