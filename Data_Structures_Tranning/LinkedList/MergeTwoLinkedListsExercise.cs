using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public class MergeTwoLinkedListsExercise
    {
        public static ListNode1<int> mergeTwoLinkedLists(ListNode1<int> l1, ListNode1<int> l2)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();
            var mergeList = new List<int>();
            var newNodeList = new ListNode1<int>();

            if (l1 != null)
                list1 = ConvertToList(l1);

            if(l2 != null)
                list2 = ConvertToList(l2);

            if((l1 != null) && (l2 != null))
            {
                mergeList = list1.Concat(list2).ToList();
                mergeList.Sort();
                newNodeList = ConvertToListNode(mergeList);
            }
            else if ((l1 != null) && (l2 == null))
            {
                list1.Sort();
                newNodeList = ConvertToListNode(list1);
            }
            else
            {
                list2.Sort();
                newNodeList = ConvertToListNode(list2);
            }

            return newNodeList;
        }

        static List<int> ConvertToList(ListNode1<int> listNode)
        {
            var list = new List<int>();

            while (listNode != null)
            {
                list.Add(listNode.value);
                listNode = listNode.next;
            }

            return list;
        }

        static ListNode1<int> ConvertToListNode(List<int> list)
        {
            list.Reverse();
            ListNode1<int> newNodeList = null;
            ListNode1<int> connector = null;

            for (int i = 0; i < list.Count; i++)
            {
                connector = newNodeList;
                newNodeList = new ListNode1<int>();
                newNodeList.value = list[i];
                newNodeList.next = connector;
            }

            return newNodeList;
        }
    }
}
