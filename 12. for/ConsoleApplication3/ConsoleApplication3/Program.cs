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
            for (int dollar = 1; dollar <= 20; dollar = dollar + 1)
            {
                int rub = dollar * 58;
                Console.WriteLine("В долларах: " + dollar + ". В рублях: " + rub);
                Thread.Sleep(1000);
            }
            Console.Read();
        }
    }
}