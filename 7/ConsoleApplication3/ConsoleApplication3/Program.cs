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
            Comp(-15, +20);
        }

        static void Comp(int a, int b)
        {
            if (a > 0 && b < 0 || a < 0 && b > 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
            Console.ReadLine();
        }
    }
}
