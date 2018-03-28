using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public class TwoHugeNumbersExercise_3
    {
        public static ListNode1<int> addTwoHugeNumbers(ListNode1<int> a, ListNode1<int> b)
        {
            var list1 = ReverseList(a);
            var list2 = ReverseList(b);
            var carry = false;
            ListNode1<int> prev = null;

            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    list1 = new ListNode1<int>();
                }
                if (list2 == null)
                {
                    list2 = new ListNode1<int>();
                }
                var node = new ListNode1<int>();

                var res = list1.value + list2.value;
                if (carry)
                    res++;

                if (res < 10000)
                {
                    carry = false;
                }
                else
                {
                    carry = true;
                    res = res - 10000;
                }
                node.value = res;
                node.next = prev;
                list1 = list1.next;
                list2 = list2.next;
                prev = node;
            }

            if (carry)
            {
                var node = new ListNode1<int>();
                node.next = prev;
                node.value = 1;
                prev = node;
            }

            return prev;
        }

        public static ListNode1<int> ReverseList(ListNode1<int> l)
        {
            if (l == null) return null;

            ListNode1<int> prev = null;
            var curr = l;
            var next = l.next;

            while (curr != null)
            {
                curr.next = prev;
                prev = curr;
                curr = next;
                next = next == null ? null : next.next;
            }
            return prev;
        }

    }
}
