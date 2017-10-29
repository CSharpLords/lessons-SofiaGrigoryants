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

            Console.WriteLine("Введите Ваше имя");
            string name = Console.ReadLine();
            SayHello(name);
            SayHello("София"); 

            Console.ReadLine();
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Привет, " + name);
        }
    }
}
