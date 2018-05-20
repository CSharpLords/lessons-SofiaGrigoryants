using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cats
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Console.WriteLine(cat.colour);
            cat.Walk();
            Console.ReadLine();
        }
    }
}
