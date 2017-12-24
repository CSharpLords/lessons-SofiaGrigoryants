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
            int[] nums = { 1, 6, 10, 15, 5, 8, 0 };
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 5)
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
