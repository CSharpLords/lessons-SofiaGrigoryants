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
            float[] nums = { 34, 675, 22, -1, 0, 23 };
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * 2;
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }
    }
}
