using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSharpx.Collections;

namespace Data_Structures_Tranning.LinkedList
{
    public class PalindromeExercise_2
    {
        public static bool isListPalindrome(ListNode<int> l)
        {
            List<int> list = new List<int>();
            ListNode<int> cur = l;

            while (null != cur)
            {
                list.Add(cur.value);
                cur = cur.next;
            }

            int n = (list.Count + 1) / 2;

            for (int i = 0; i < n; i++)
            {
                if (list[i] != list[list.Count - i - 1])
                {
                    return false;
                }
            }
            return true;

            /*var s = new List<int>();
            while (l != null)
            {
                s.Add(l.value);
                l = l.next;
            }

            for (int i = 0, j = s.Count - 1; i < j; ++i, j--)
                if (s[i] != s[j]) return false;

            return true;*/
        }

    }
}
