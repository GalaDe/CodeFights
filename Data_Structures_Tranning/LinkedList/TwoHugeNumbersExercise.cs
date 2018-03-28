using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.FSharp.Core;

namespace Data_Structures_Tranning.LinkedList
{
    public class TwoHugeNumbersExercise
    {
        
        public static ListNode1<int> addTwoHugeNumbers(ListNode1<int> a, ListNode1<int> b)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();
            var mergeList = new List<int>();
            string merge1 = null;
            string merge2 = null;
            var result = new List<int>();
            int carryOver = 0;
            int res;

            //checking a
            if ((a == null) || (a.value == 0))
                return b;
            //checking b
            if ((b == null) || (b.value == 0))
                return a;

            list1 = ConvertToList(a);
            list2 = ConvertToList(b);

            list1.Reverse();
            list2.Reverse();

            int list1Lenght = list1.Count;
            int list2Lenght = list2.Count;
       

            if (list1.Count == list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    if ((list1[i] >= 0 && list1[i] <= 9999) || (list2[i] >= 0 && list2[i] <= 9999))
                    {
                        result.Add(list1[i] + list2[i] + carryOver);
                        res = VerifyResult(result[i]);

                        if (res == 0)
                        {
                            carryOver = 1;
                            result[i] = 0;
                        }
                        else
                            carryOver = 0;
                    }               
                }
            }
            else if (list1.Count > list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    if ((list1[i] >= 0 && list1[i] <= 9999) || (list2[i] >= 0 && list2[i] <= 9999))
                    {
                        if (list2Lenght != 0)
                        {
                            result.Add(list1[i] + list2[i] + carryOver);
                            list2Lenght--;

                            res = VerifyResult(result[i]);

                            if (res == 0)
                            {
                                carryOver = 1;
                                result[i] = 0;
                            }
                            else
                                carryOver = 0;
                        }
                        else
                        {
                            result.Add(list1[i] + carryOver);
                            res = VerifyResult(result[i]);

                            if (res == 0)
                            {
                                carryOver = 1;
                                result[i] = 0;
                            }
                            else
                                carryOver = 0;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    if ((list1[i] >= 0 && list1[i] <= 9999) || (list2[i] >= 0 && list2[i] <= 9999))
                    {
                        if (list1Lenght != 0)
                        {
                            result.Add(list1[i] + list2[i] + carryOver);
                            list1Lenght--;
                            res = VerifyResult(result[i]);

                            if (res == 0)
                            {
                                carryOver = 1;
                                result[i] = 0;
                            }
                            else
                                carryOver = 0;
                        }
                        else
                        {
                            result.Add(list2[i]);
                            res = VerifyResult(result[i] + carryOver);

                            if (res == 0)
                            {
                                carryOver = 1;
                                result[i] = 0;
                            }
                            else
                                carryOver = 0;
                        }
                    }
                }
            }

            ListNode1<int> r = null;
            ListNode1<int> t = null;

            for (int i = 0; i < result.Count; i++)
            {
                r = t;
                t = new ListNode1<int>();
                t.value = result[i];
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

        static string MergeListNodes(List<int> list)
        {
            string merge = null;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] >= 0 && list[i] <= 9999)
                {
                    merge += list[i].ToString();
                }
            }

            return merge;
        }
        static int VerifyResult(int num)
        {
            if ((num > 9) && (num < 99))
            {
                if (num % 10 == 0)
                    num = 0;
            }

            else if ((num > 99)&& (num < 999))
            {
                if (num % 100 == 0)
                    num = 0;
            }

            else if ((num > 999)&&(num < 9999))
            {
                if (num % 100 == 0)
                    num = 0;
            }

            else if ((num > 9999)&&(num<99999))
            {
                if (num % 1000 == 0)
                    num = 0;
            }

            else if (num > 99999)
            {
                if (num % 10000 == 0)
                    num = 0;
            }

            return num;
        }

    }
}
