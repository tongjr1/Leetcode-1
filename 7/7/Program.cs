using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int result = solution.Reverse(-2147483648);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
