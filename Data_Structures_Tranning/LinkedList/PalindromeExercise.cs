using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public class PalindromeExercise
    {
        public static bool isListPalindrome(ListNode<int> l)
        {
            bool result;
            List<int> a = new List<int>();
            List<int> b = new List<int>();

            int half = l.Count/2;

            var node1 = l.Head;
            var node2 = l.Tail;
            ListNode<int> nextNode;
            ListNode<int> previousNode;

            if (l.Count <= 2)
                return false;

            for (int i = 0; i < half; i++)
            {
                nextNode = node1.next;
                a.Add(node1.value);
                node1 = nextNode;
            }

            //reverse doesn't work
            for (int i = 0; i < half; i++)
            {
                previousNode = node2.previous;
                b.Add(node2.value);
                node2 = previousNode;
            }

            result = (a.Count == b.Count) && !a.Except(b).Any();
            return result;
        }

    }
}
