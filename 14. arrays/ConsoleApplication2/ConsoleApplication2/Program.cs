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
            float[] nums = { 2, 1, 2, -1, 0, 1 };
            float sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
