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
            Console.WriteLine("Хэй, рыцарь! Посмотри сюда! Я-твой наставник, считай так. Твоё первое задание-сразиться с драконом. Но берегись! Ты сможешь одолеть его, только если он ещё молодой и ему до 150 лет, либо если у него менее 50 из 100 ХП. Подойди у нему и посмотри, сколько ему лет, сколько ХП и отправь мне.");
            Console.WriteLine("Ну и сколько ему лет?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("И сколько ХП?");
            int health = int.Parse(Console.ReadLine());
            
            int old = 150;
            int mhealth = 100;
            if (age < old)
            {
                Console.WriteLine("Бей!");
            }
            else
            {
                if (health < mhealth)
                {
                    Console.WriteLine("Бей!");
                }
                else
                {
                    Console.WriteLine("Отступай!");
                }
            }
            Console.ReadLine();
            
        }
    }
}

