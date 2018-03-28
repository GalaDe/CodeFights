using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public class TwoHugeNumbersExercise_4
    {

        public static ListNode1<int> addTwoHugeNumbers(ListNode1<int> a, ListNode1<int> b)
        {
            ListNode1<int> ar = Reverse(a);
            ListNode1<int> br = Reverse(b);
            ListNode1<int> sum = Sum(ar, br);

            return sum;
        }

        static ListNode1<int> Sum(ListNode1<int> a, ListNode1<int> b)
        {
            int carry = 0;
            ListNode1<int> current = null;
            ListNode1<int> head = null;
            while (a != null || b != null || carry > 0)
            {
                int sum = 0;

                /*if (a != null)
                    sum += a.value;
                  else
                    sum += 0;*/

                sum += a != null ? a.value : 0;
                sum += b != null ? b.value : 0;
                sum += carry;

                /*if (sum > 9999)
                    carry = 1;
                else
                    carry = 0;*/
                 
                carry = sum > 9999 ? 1 : 0;

                /*if (sum > 9999)
                    sum = sum - 10000;
                else
                    sum = sum;*/
                sum = sum > 9999 ? sum - 10000 : sum;

                // Add the value to the new sum.
                var next = current;
                current = new ListNode1<int>();
                current.value = sum;
                current.next = next;
                head = current;

                // Move to the next values.
                /*if (a != null)
                    a = a.next;
                else
                    a = a;*/
                a = a != null ? a.next : a;
                b = b != null ? b.next : b;
            }

            return head;
        }

        static ListNode1<int> Reverse(ListNode1<int> listNode)
        {
            ListNode1<int> previous = null;
            ListNode1<int> next = null;
            while (listNode != null)
            {
                next = listNode.next;
                listNode.next = previous;
                previous = listNode;
                listNode = next;
            }

            return previous;
        }
    }
}
