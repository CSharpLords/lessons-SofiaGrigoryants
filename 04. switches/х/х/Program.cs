using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число х");

            int x = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                Console.WriteLine("х = 1");
            }
            else if (x < 0)
            {
                Console.WriteLine("x = -1");
            }
            else if (x == 0)
            {
                Console.WriteLine("х = 0");
            }
            Console.ReadLine();
        }
    }
}
