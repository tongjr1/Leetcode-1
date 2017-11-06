using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] num = new int[26];
            foreach(var note in magazine)
            {
                num[Convert.ToInt32(note) - 97] = num[Convert.ToInt32(note) - 97] + 1;
            }
            foreach (var note in ransomNote)
            {
                num[Convert.ToInt32(note) - 97] = num[Convert.ToInt32(note) - 97] - 1;
            }
            foreach(var temp in num)
            {
                if (temp < 0)
                {
                    return false;
                }
            }
            return true;
        }    
    }
}
