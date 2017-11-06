using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string ransomNote = "acc";
            string magazine = "fasfwfvadcwef";
            var result = solution.CanConstruct(ransomNote, magazine);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
