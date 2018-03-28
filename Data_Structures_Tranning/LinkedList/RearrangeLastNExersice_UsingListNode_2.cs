using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public static class RearrangeLastNExersice_UsingListNode_2
    {
        public static ListNode1<int> rearrangeLastN(ListNode1<int> l, int n)
        {
            if (n == 0) return l;
            ListNode1<int> head = l, finalhead = l, tail = null, tolink = null;

            int size = 0;

            //First loop to get the size
            while (l != null)
            {
                if (l.next == null)
                    tail = l;
                l = l.next;
                size++;
            }

            l = head;
            size = size - n;

            while (size > 0)
            {
                size--;
                if (size == 0)
                {
                    tolink = l;
                    finalhead = l.next;
                    tail.next = head;
                    /* After updating the nodes we set the new tail.next to null to avoid a looping list */
                    tolink.next = null;
                }
                l = l.next;
            }
            return finalhead;
        }

    }
}
