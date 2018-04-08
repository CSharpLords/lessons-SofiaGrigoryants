using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PairSymbols {
    class Program {
        static void Main(string[] args) {
            CheckPairs("namespace ConsoleApplication1 {class Program {static void Main(string[] args) {}", "{", "}");
            CheckPairs("graphics = e.Graphics;graphics.SmoothingMode = SmoothingMode.AntiAlias;graphics.Clear(Color.FromArgb(0x44444400));DrawCar(carX, 200);", "(", ")");

            Console.ReadLine();
        }

        private static void CheckPairs(string code, string open, string closed)
        {
            throw new NotImplementedException();
            int nums = 0;
            int nums1 = 0;
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i].ToString() == open)
                {
                    nums = nums + 1;
                }
                if (code[i].ToString() == closed)
                {
                    nums1 = nums1 + 1;
                }
                if (nums == nums1)
                {
                    Console.WriteLine("Всё верно");
                }
                else
                {
                    Console.WriteLine("Не верно");
                }
            }
        }
    }
}
