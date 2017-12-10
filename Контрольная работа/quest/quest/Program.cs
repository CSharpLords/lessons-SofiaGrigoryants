using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("У тебя есть компьютер?");
            Console.WriteLine("1. Да");
            Console.WriteLine("2. Нет");

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Да":
                    Console.WriteLine("Сколько часов в неделю ты проводишь за ним?");
                    break;
                case "Нет":
                    Console.WriteLine("Ок, тогда нам не о чем говорить");
                    break;
                default:
                    Console.WriteLine("???");
                    break;
            }

            int time = int.Parse(Console.ReadLine());

            if (time < 14)
            {
                Console.WriteLine("А большую часть этого времени ты работаешь или отдыхаешь?");
                Console.WriteLine("1. Отдыхаю");
                Console.WriteLine("2. Работаю");
            }
            if (time > 14)
            {
                Console.WriteLine("А большую часть этого времени ты работаешь или отдыхаешь?");
                Console.WriteLine("3. Отдыхаю");
                Console.WriteLine("4. Работаю");
            }

            int answer2 = int.Parse(Console.ReadLine());

            switch (answer2)
            {
                case 1:
                    Console.WriteLine("Хорошо, что ты знаешь меру");
                    break;
                case 2:
                    Console.WriteLine("Ты и отдохнуть не забывай");
                    break;
                case 3:
                    Console.WriteLine("Ты портишь своё здоровье!!!");
                    break;
                case 4:
                    Console.WriteLine("Пожалей себя!");
                    break;
                default:
                    Console.WriteLine("???");
                    break;
            }
            Console.ReadLine();
        }
    }
}
