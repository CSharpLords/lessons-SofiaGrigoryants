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
            int[] wins = { 6, 2, 9, 15, 8, 20, 7, 4, 1, 5, 18, 14, 12, 19, 21, 27, 24, 23, 29, 24 };

            for (int i = 0; i < wins.Length; i++)
            {
                if (wins[i] < 3)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
