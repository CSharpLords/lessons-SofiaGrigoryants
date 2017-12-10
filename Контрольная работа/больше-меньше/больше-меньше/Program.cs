using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первый игрок вводит число");
            int number = int.Parse(Console.ReadLine());
            if (number > 999)
            {
                Console.WriteLine("Введите число меньше 999");
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Теперь второй игрок попробует угадать его!");
            int attempt = 0;
            while (true)
            {
                int answer = int.Parse(Console.ReadLine());
                if (answer > number)
                {
                    Console.WriteLine("Давай поменьше!");
                    attempt = attempt + 1;
                }
                else if (answer < number)
                {
                    Console.WriteLine("Давай побольше");
                    attempt = attempt + 1;
                }
                else if (answer == number)
                {
                    Console.WriteLine("Верно! Число попыток: " + attempt);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
