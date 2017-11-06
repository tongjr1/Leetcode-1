using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 2, 3,2 };
            int[] num = new int[nums.Length-1];
            Array.Copy(nums, 1, num, 0, 3);
            var a = nums.Contains(1);
            var b = Array.IndexOf(nums,2);
            Console.WriteLine(nums.Max());
            Console.ReadKey();
        }
    }
}
