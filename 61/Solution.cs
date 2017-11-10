using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            ListNode newBottom = head;
            List<int> b = new List<int>();
            int i = 0;
            ListNode bottom = head;
            while (i<k)
            {
                bottom = bottom.next;
                i++;
            }
            while(bottom != null||bottom.next != null)
            {
                bottom = bottom.next;
                newBottom = newBottom.next;
            }
            var newHead = newBottom.next;
            newBottom.next = null;
            bottom.next = head;
            return newHead;
        }
    }
}
