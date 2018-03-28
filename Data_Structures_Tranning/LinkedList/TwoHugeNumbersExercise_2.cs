using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public class TwoHugeNumbersExercise_2
    {
        public static ListNode1<int> addTwoHugeNumbers(ListNode1<int> a, ListNode1<int> b)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> result = new List<int>();
            List<int> temp = new List<int>();

            int x = 0;
            int y = 0;
            int sum = 0;

            list1 = ConvertToList(a);
            list2 = ConvertToList(b);

            int lengthlist1 = list1.Count;
            int lengthlist2 = list2.Count;

            //If the lenght of both list are the same
            while (lengthlist1 > 0 && lengthlist2 > 0)
            {
                //sum = list1[2] + list2[2] + 0 = 5 + 100 + 0 = 105 -- 1
                //sum = list1[1] + list2[1] + 0 = 4 + 100 + 0 = 104 -- 2
                sum = list1[lengthlist1 - 1] + list2[lengthlist2 - 1] + x;
                //x = 105/10000 = 0
                x = sum / 10000;
                //y = 105%10000 = 0
                y = sum % 10000;
                temp.Add(y);
                lengthlist1--;
                lengthlist2--;
            }
            // temp contains 0, 104, 223

            //If lenght of lists are different
            while (lengthlist1 > 0)
            {
                sum = list1[lengthlist1 - 1] + x;
                if (sum > 9999)
                {
                    temp.Add(sum % 10000);
                    x = sum / 10000;
                }
                else
                {
                    temp.Add(sum);
                    x = 0;
                }

                lengthlist1--;
            }
            while (lengthlist2 > 0)
            {
                sum = list2[lengthlist2 - 1] + x;
                if (sum > 9999)
                {
                    temp.Add(sum % 10000);
                    x = sum / 10000;
                }
                else
                {
                    temp.Add(sum);
                    x = 0;
                }

                lengthlist2--;
            }

            if (x > 0)
            {
                temp.Add(x);
            }

            ListNode1<int> r = null;
            ListNode1<int> t = null;

            for (int i = 0; i < temp.Count; i++)
            {
                r = t;
                t = new ListNode1<int>();
                t.value = temp[i];
                t.next = r;
            }
            return t;
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
    
    }
}
