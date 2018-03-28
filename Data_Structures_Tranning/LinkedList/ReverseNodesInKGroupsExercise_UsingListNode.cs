using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public static class ReverseNodesInKGroupsExercise_UsingListNode
    {
        public static ListNode1<int> reverseNodesInKGroups(ListNode1<int> l, int k)
        {
            //c is the copy of l
            var c = l;
            ListNode1<int> prev = null;

            while (c != null)
            {
                //s is another copy of l
                var s = c;
                var j = 1;
                for (int i = 0; i < k - 1 && c.next != null; i++, j++)// k=3
                    c = c.next;
                var n = c.next;

                c.next = null;

                if (j == k)
                    s = reverseList(s);

                if (prev == null)
                    l = s;
                else
                    prev.next = s;

                while (s.next != null) s = s.next;
                s.next = n;

                prev = s;
                c = s.next;
            }

            return l;
        }

        public static ListNode1<int> reverseList(ListNode1<int> l)
        {
            ListNode1<int> prev = null, tmp;
            while (l != null)
            {
                tmp = l.next;
                l.next = prev;
                prev = l;
                l = tmp;
            }
            return prev;
        }
    }
}
