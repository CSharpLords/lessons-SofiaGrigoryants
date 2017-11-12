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
            Random rand = new Random();

            while (true)
            {
                int number = rand.Next(0, 100);

                Console.WriteLine("Запомните число: " + number);
                Thread.Sleep(300);
                Console.Clear();

                Console.WriteLine("Введите число:");
                int guess = int.Parse(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("Верно :)");
                }
                else
                {
                    Console.WriteLine("Неверно :(");
                }
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
