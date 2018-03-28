using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public class MergeTwoLinkedListsExercise_Recursive
    {
       public static ListNode1<int> mergeTwoLinkedLists(ListNode1<int> l1, ListNode1<int> l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            if (l1.value > l2.value)
            {
                l2.next = mergeTwoLinkedLists(l1, l2.next);
                return l2;
            }
            else
            {
                l1.next = mergeTwoLinkedLists(l2, l1.next);
                return l1;
            }

        }
    }
}
