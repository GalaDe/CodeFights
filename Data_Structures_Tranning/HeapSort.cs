using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSharpx.Collections;

namespace Data_Structures_Tranning
{
    public class HeapSort
    {

        public static List<int> HeapSorting(List<int> list)
        {
            int iValue;

            for (int i = list.Count/2; i >= 0; i--)
            {
                Adjust(i, list.Count - 1, list);
            }

            for (int i = list.Count - 2; i >= 0; i--)
            {
                iValue = list[i + 1];
                list[i + 1] = list[0];
                list[0] = iValue;
                Adjust(0, i, list);
            }

            return list;
        }

        private static void Adjust(int i, int n, List<int> list)
        {
            int iPosition;
            int iChange;

            iPosition = list[i];
            iChange = 2 * i;
            while (iChange <= n)
            {
                if (iChange < n && list[iChange] < list[iChange + 1])
                {
                    iChange++;
                }
                if (iPosition >= list[iChange])
                {
                    break;
                }
                list[iChange / 2] = list[iChange];
                iChange *= 2;
            }
            list[iChange / 2] = iPosition;
        }

        public static string PrintList(List<int> list)
        {
            string myValue = "";
            for (int i = 0; i < list.Count; i++)
            {
                myValue += list[i] + " ";
            }
            return myValue;
        }



    }
}
