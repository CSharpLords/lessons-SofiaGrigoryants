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
            Console.WriteLine("Введите 1 число");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2 число");
            int s = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите 3 число");
            int t = int.Parse(Console.ReadLine());


            if (f > s)
            {
                if (f > t)
                {
                    Console.WriteLine("Самое большое " + f);
                }
                else
                {
                    Console.WriteLine("Самое большое " + t);
                }
            }
            else
            {
                if (s > t)
                {
                    Console.WriteLine("Самое большое " + s);
                }
                else
                {
                    Console.WriteLine("Самое большое " + t);
                }
                Console.ReadLine();
            }
        }
    }
}