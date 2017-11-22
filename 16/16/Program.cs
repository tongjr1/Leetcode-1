using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var result = solution.ThreeSumClosest();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
