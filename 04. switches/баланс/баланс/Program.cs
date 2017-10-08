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
            Console.WriteLine("Введите Ваш баланс");
            int cash = int.Parse(Console.ReadLine());

            int price = 500;
            int age = 10;
            int discount = 200;
            if (age < 9)
            {
                price = price - discount;
            }
            else
            {
                Console.WriteLine("У Вас нет скидки");
            }

            Console.WriteLine("Ваш баланс " + (cash - price) + " рублей");
            Console.ReadLine();
        }
    }
}
