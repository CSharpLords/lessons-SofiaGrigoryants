﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ты у входа в пещеру, которую охраняет огр");
            Console.WriteLine("1. Вступить в бой");
            Console.WriteLine("2. Отступить");
            Console.WriteLine("3. Подкупить");
            Console.WriteLine("4. Найти обходной путь");

            int answer = int.Parse(Console.ReadLine());

            switch (answer) {
                case 1:
                    Console.WriteLine("Ты погибаешь, так как огр сильнее");
                    break;
                case 2:
                    Console.WriteLine("Переносишься в соседнюю локацию");
                    break;
                case 3:
                    Console.WriteLine("Огр пропускает тебя в пещеру");
                    break;
                case 4:
                    Console.WriteLine("По пути тебя грабят бандиты");
                    break;

                default:
                    Console.WriteLine("Answer is incorrect");
                    break;
            }


            if (answer == 1)
            {
                
            }
            else if (answer == 2)
            {
                Console.WriteLine("Переносишься в соседнюю локацию");
            }
            else if (answer == 3)
            {
                Console.WriteLine("Огр пропускает тебя в пещеру");
            }
            else if (answer == 4)
            {
                Console.WriteLine("По пути тебя грабят бандиты");
            }
            Console.ReadLine();
        }
    }
}
