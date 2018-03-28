using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public class ReverseNodesInKGroupsExercise_UsingTempArray
    {
        public static ListNode1<int> reverseNodesInKGroups(ListNode1<int> l, int k)
        {
            ListNode1<int> result = null;
            List<int> lstValue = new List<int>();
            int[] temp = new int[k];
            int index = 0;
            while (l != null)
            {
                if (index < k)
                {
                    temp[index] = l.value;
                    index++;
                }
                if (index == k)
                {
                    for (int i = k - 1; i >= 0; i--)
                    {
                        lstValue.Add(temp[i]);
                    }
                    temp = new int[k];
                    index = 0;
                }
                l = l.next;
                if (l == null && index < k)
                {
                    for (int i = 0; i < index; i++)
                    {
                        lstValue.Add(temp[i]);
                    }
                }
            }

            for (int i = lstValue.Count - 1; i >= 0; i--)
            {
                ListNode1<int> n = new ListNode1<int>();
                n.value = lstValue[i];
                n.next = result;
                result = n;
            }

            return result;
        }

    }
}
