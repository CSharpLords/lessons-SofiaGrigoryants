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
            Comp(5, 3);
        }

        static void Comp(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(">");
            }
            else if (b > a)
            {
                Console.WriteLine("<");
            }
            else if (b == a)
            {
                Console.WriteLine("=");
            }
            Console.ReadLine();
        }
    }
}
