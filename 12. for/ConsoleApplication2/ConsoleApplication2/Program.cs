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
            for (int number = 10; number <= 25; number = number + 1)
            {
                double numb = .4;
                double n = number + numb;
                Console.WriteLine(number + " " + n);
                Thread.Sleep(1000);
            }
            Console.Read();
        }
    }
}