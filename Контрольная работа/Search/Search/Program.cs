using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какую вещь ты хочешь найти?");

            Console.WriteLine("1. Носки");
            Console.WriteLine("2. Портфель");
            Console.WriteLine("3. Тапочки");
            Console.WriteLine("4. XBox");
            Console.WriteLine("5. Телефон");
            Console.WriteLine("6. Записка с паролем от Dota2");

            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("Они в комоде");
            }
            else if (answer == 2)
            {
                Console.WriteLine("Посмотри в коридоре");
            }
            else if (answer == 3)
            {
                Console.WriteLine("Они под кроватью");
            }
            else if (answer == 4)
            {
                Console.WriteLine("Он в твоей папке");
            }
            else if (answer == 5)
            {
                Console.WriteLine("Он лежит на тумбочке");
            }
            else if (answer == 6)
            {
                Console.WriteLine("Она прикреплена к твоему столу");
            }
            else
            {
                Console.WriteLine("Я не знаю такую вещь!");
            }
            Console.ReadLine();
        }
    }
}
