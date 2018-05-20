using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cats
{
    class Cat
    {
        public int colour = 0;
        Leg[] legs = new Leg[4];

        public Cat()
        {
            for (int i = 0; i < legs.Length; i++)
                legs[i] = new Leg();
        }

        public void Walk()
        {
            for (int i = 0; i < legs.Length; i++)
            {
                legs[i].Move();
            }
            Console.WriteLine("Move!");
        }
    }
}
