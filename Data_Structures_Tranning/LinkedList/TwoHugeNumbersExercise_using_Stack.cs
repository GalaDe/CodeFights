using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public class TwoHugeNumbersExercise_using_Stack
    {
        public static ListNode1<int> addTwoHugeNumbers(ListNode1<int> a, ListNode1<int> b)
        {
            ListNode1<int> r = null;
            Stack<int> ast = new Stack<int>();
            Stack<int> bst = new Stack<int>();
            while (a != null)
            {
                ast.Push(a.value);
                a = a.next;
            }
            while (b != null)
            {
                bst.Push(b.value);
                b = b.next;
            }
            int carry = 0;
            while (ast.Count > 0 || bst.Count > 0 || carry > 0)
            {
                /*int num1;
                if(ast.count > 0)
                {num1 = ast.pop();}
                else
                {num1 = 0;}*/

                int num1 = ast.Count > 0 ? ast.Pop() : 0;
                int num2 = bst.Count > 0 ? bst.Pop() : 0;
                int sum = num1 + num2 + carry;
                int rem = sum % 10000;
                carry = sum / 10000;

                ListNode1<int> newNode = new ListNode1<int>();
                newNode.value = rem;
                newNode.next = r;
                r = newNode;
            }

            return r;
        }
    }
}
