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
            Console.WriteLine("Ваш возраст");
            int age = int.Parse(Console.ReadLine());

            if (age >= 20 || age <= 10)
            {
                Console.WriteLine("Вы не подросток");
            }
            else
            {
                Console.WriteLine("Вы подросток");
            }

            Console.ReadLine();
        }
    }
}
