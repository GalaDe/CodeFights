using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public class RearrangeLastNExersice
    {
        /// <summary>
        /// This solution is not a good one. Also didn't pass all 24 tests
        /// </summary>

        public static ListNode1<int> rearrangeLastN(ListNode1<int> l, int n)
        {
            var copyOf_l = l;
            ListNode1<int> afterN = copyOf_l;
            ListNode1<int> beforeN = null;
            ListNode1<int> connector = null;
            ListNode1<int> tail = null;
            ListNode1<int> head = l;
            ListNode1<int> finalhead = l;
            bool flag = false;


            if (l == null)
                return l;
            if (n == 0)
                return l;

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

            if (n == 1)
            {
                while (size > 0)
                {
                    size--;
                    if (size == 0)
                    {
                        var tolink = l;
                        finalhead = l.next;
                        tail.next = head;
                        /* After updating the nodes we set the new tail.next to null to avoid a looping list */
                        tolink.next = null;
                    }
                    l = l.next;
                }
                return finalhead;
            }

            while (copyOf_l != null)
            {
                if (copyOf_l.value == n)
                {
                    flag = true;
                    for (int i = 0; i < n && copyOf_l.next != null; i++)
                    {
                        afterN.value = copyOf_l.value;
                        copyOf_l = copyOf_l.next;
                        afterN = afterN.next;
                    }
                    break;
                }
                else
                {
                    connector = beforeN;
                    beforeN = new ListNode1<int>();
                    beforeN.value = copyOf_l.value;
                    beforeN.next = connector;
                    copyOf_l = copyOf_l.next;
                }
            }

            if (!flag)
                return l;

            //After a while loop, we have 2 List: afterN and beforeN 
            //Reverse afterN 
            beforeN = ReverseListNode(beforeN);
            afterN = ReverseListNode(afterN);

            //Now we need to combine 2 lists into one
            var result = Merge(beforeN, afterN, size);


            return result;
        }

        public static ListNode1<int> ReverseListNode(ListNode1<int> l)
        {
            /*Doesn't matter how to write even ListNode1<int> temp = null 
             * or ListNode1<int> prev = null, temp;*/
            ListNode1<int> prev = null, temp;

            while (l != null)
            {
                //temp holds the node
                temp = l.next;
                l.next = prev;
                prev = l;
                l = temp;
            }
            return prev;
        }

        public static ListNode1<int> Merge(ListNode1<int> a, ListNode1<int> b, int size)
        {
            ListNode1<int> tail = a;
            ListNode1<int> head = b;

            while (head != null)
            {
                var next = head.next;
                head.next = tail;
                tail = head;
                head = next;
            }
            return tail;
        }
    }
}
