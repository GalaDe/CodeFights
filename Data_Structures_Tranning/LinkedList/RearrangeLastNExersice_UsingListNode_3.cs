using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public static class RearrangeLastNExersice_UsingListNode_3
    {
        public static ListNode1<int> rearrangeLastN(ListNode1<int> l, int n)
        {
            var current = l;
            //checking n
            if (n == 0) return l;

            //removing first nodes from the list until n
            for (int i = 0; i < n; i++)
            {
                if (current == null) return l;
                current = current.next;
            }
            //checking list node l
            if (current == null) return l;

            //head will have full list
            var head = l;

            //going through current and head
            //current contais leftover after the first for loop
            //head will have l
            while (current.next != null)
            {
                current = current.next;
                head = head.next;
            }
            var result = head.next;
            head.next = null;
            current.next = l;

            //current and resul contains same items
            return result;
        }
    }
}
