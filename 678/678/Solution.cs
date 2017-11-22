using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _678
{
    class Solution
    {
        public bool CheckValidString(string s)
        {
            Stack strStack = new Stack();
            Stack starStack = new Stack();
            int i = 0;
            foreach (var temp in s)
            {                
                if (temp == '(')
                    strStack.Push(i);
                else if (temp == '*')
                    starStack.Push(i);
                else if (temp == ')')
                {
                    if (strStack.Count != 0)
                        strStack.Pop();
                    else
                    {
                        if (starStack.Count != 0)
                        {
                            starStack.Pop();
                        }
                        else
                            return false;
                    }
                }
                i++;
            }
            while (strStack.Count != 0)
            {
                if (starStack.Count==0|| Convert.ToInt16(strStack.Peek().ToString()) > Convert.ToInt16(starStack.Peek().ToString()))
                    return false;
                else
                {
                    strStack.Pop();
                    starStack.Pop();
                }
            }
            return true;
        }
    }
}
