using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures_Tranning.LinkedList;

namespace Data_Structures_Tranning.LinkedList
{

    #region Definition
    //C# Remove K From List - Code Fights

    /*
    Note: Try to solve this task in O(n) time using O(1) additional space, 
    where n is the number of elements in the list, since this is what you'll 
    be asked to do during an interview.

    Given a singly linked list of integers l and an integer k, remove all 
    elements from list l that have a value equal to k.

    Example
    For l = [3, 1, 2, 3, 4, 5] and k = 3, the output should be
    removeKFromList(l, k) = [1, 2, 4, 5];
    For l = [1, 2, 3, 4, 5, 6, 7] and k = 10, the output should be
    removeKFromList(l, k) = [1, 2, 3, 4, 5, 6, 7].*/

    // Definition for singly-linked list:
    // class ListNode<T> {
    //   public T value { get; set; }
    //   public ListNode<T> next { get; set; }
    // }
    //
    #endregion

    public class RemoveKFromListExercise_2
    {
        public static ListNode<int> removeKFromList(ListNode<int> l, int k)
        {
            List<int> list = new List<int>();

            while (true)
            {
                if (l == null)
                    break;
                if (l.value != k)
                    list.Add(l.value);
                l = l.next;
            }

            ListNode<int> t = new ListNode<int>();

            for (int i = list.Count - 1; i > 0; i--)
            {
                t.Add(list[i]);
            }
            return t;
        }
    }
}
