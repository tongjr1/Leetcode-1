using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _678
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "(*()";
            var a = solution.CheckValidString(s);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
