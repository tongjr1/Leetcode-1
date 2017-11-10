using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            ListNode head;
            int k = 2;
            var result = solution.RotateRight(head,k);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
