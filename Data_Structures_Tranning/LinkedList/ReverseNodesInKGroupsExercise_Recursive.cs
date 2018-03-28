using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    class ReverseNodesInKGroupsExercise_Recursive
    {
        public static ListNode1<int> reverseNodesInKGroups(ListNode1<int> l, int k)
        {

            if (l == null) return l;

            var beyond = l;
            //The loop eat nodes one by one, until k not == 0
            //1st iteration we have in beyond: 1, 2, 3, 4
            //2nd iteration we have in beyond: 5, 6, 7, 8
            //3rd iteration we have in beyond: 9, 10, 11, 12
            //Where all of these nodes are going to and where are their location????
            for (int i = 0; i < k; i++)
            {
                if (beyond == null) return l;
                else beyond = beyond.next;
            }

            //The recursion is over when the l == null
            var attach = reverseNodesInKGroups(beyond, k);

            ListNode1<int> prev = null;
            //1st round: l contains: 9, 10, 11, 12 -- ????
            //2nd round: l contains: 5, 6, 7, 8 -- ????
            //3nd round: l contains: 1, 2, 3, 4 -- ????
            var curr = l;

            //Loop will reverse the nodes, basic swap logic
            for (int i = 0; i < k; i++)
            {
                var temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            l.next = attach;
            return prev;
        }
    }
}
