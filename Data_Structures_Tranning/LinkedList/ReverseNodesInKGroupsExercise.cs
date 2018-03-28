using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public class ReverseNodesInKGroupsExercise
    {
        public static ListNode1<int> reverseNodesInKGroups(ListNode1<int> l, int k)
        {
            var list = new List<int>();
            var newLlistNode = new ListNode1<int>();
            int index = 0;

            if (k < 0)
                return l;

            if (l != null)
            {
                list = ConvertToList(l);
            }

            if (list.Contains(k))
            {
                if (list.Count%k == 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i]%k == 0)
                        {
                            int temp = list[index];
                            list[index] = list[i];
                            list[i] = temp;
                            index += k;

                            if (k > 3)
                            {
                                int m = i - 1;
                                for (int j = index - k + 1; j < index; j++)
                                {
                                    if (list[j] > list[m])
                                    {
                                        int temp2 = list[j];
                                        list[j] = list[m];
                                        list[m] = temp2;
                                    }
                                    m--;
                                }
                            }
                        }
                    }
                }
                list.Reverse();
                newLlistNode = ConverToListNode(list);
            }
            else
                return l;

            return newLlistNode;
        }


        public static List<int> ConvertToList(ListNode1<int> listNode)
        {
            List<int> list = new List<int>();

            while (listNode != null)
            {
                list.Add(listNode.value);
                listNode = listNode.next;
            }
            return list;
        }

        public static ListNode1<int> ConverToListNode(List<int> list)
        {
            ListNode1<int> newListNode = null;
            ListNode1<int> connector = null;

            for (int i = 0; i < list.Count; i++)
            {
                connector = newListNode;
                newListNode = new ListNode1<int>();
                newListNode.value = list[i];
                newListNode.next = connector;
            }

            return newListNode;
        }

        public static List<int> Swap(List<int> list, int k)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < list[i + 1])
                {
                    int temp = list[i];
                    list[i] = list[i + 1];
                    list[i + 1] = temp;
                    i++;
                }
            }
            return list;
        }
    }
}
