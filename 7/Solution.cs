using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Solution
    {
        public int Reverse(int x)
        {
            var a = x>0? x.ToString():(-x).ToString();
            char[] temp2 = new char[a.Length];
            int i = a.Length - 1;
            foreach (var c in a)
            {
                temp2[i--] = c;
            }
            int y = 0;
            try
            {
                y = Convert.ToInt32(new string(temp2));
            }
            catch
            {

            }
            if (x > 0)
                return y;
            else
                return -y;
        }
    }
}
