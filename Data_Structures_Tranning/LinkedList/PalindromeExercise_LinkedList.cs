using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public class PalindromeExercise_LinkedList
    {
        public static bool isListPalindrome(LinkedList<int> l)
        {
            bool result;
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            int half = l.Count/2;
            var node1 = l.First;
            var node2 = l.Last;
            LinkedListNode<int> nextNode;

            if (l.Count <= 2)
                return false;

            for (int i = 0; i < half; i++)
            {
                nextNode = node1.Next;
                a.Add(node1.Value);
                node1 = nextNode;
            }

            for (int j = l.Count - 1; j > half; j--)
            {
                nextNode = node2.Previous;
                b.Add(node2.Value);
                node2 = nextNode;
            }

            result = (a.Count == b.Count) && !a.Except(b).Any();
            return result;

        }

    }
}
