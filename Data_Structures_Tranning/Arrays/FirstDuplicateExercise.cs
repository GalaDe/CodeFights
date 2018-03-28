using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning
{
    public class FirstDuplicateExercise
    {

        #region Using Arrays Only

        /*public static int firstDuplicate(int[] arr)
        {
            bool isFoundoutside = false;
            int num = 0;
            int [] newArr = new int[arr.Length];
            

            if (arr.Length <= 1)
                return -1;

            if (arr[0] == arr[1])
                return arr[0];

            if (arr.Length > 1)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    bool isFoundinside = false;
                    if (arr[i] <= arr.Length)
                    {
                        for (int j = 0; j < arr.Length; j++)
                        {
                            if (i != j)
                            {
                                if ((arr[i] == arr[j]) && (!isFoundinside) && (!newArr.Contains(arr[j])))
                                {
                                    isFoundinside = true;
                                    newArr[j] = arr[j];

                                }
                            }

                        }
                    }
                }

                /for (int i = 0; i < arr.Length/2; i++)
                    {
                        bool isFoundinside = false;

                        for (int j = arr.Length-i-1; j > 0; j--)
                        {
                            if (i != j)
                            {
                                if ((arr[i] == arr[j]) && (!isFoundinside) && (!newArr.Contains(arr[j])))
                                {
                                    isFoundinside = true;
                                    pairCount++;
                                    newArr[j] = arr[j];

                                }
                            }
                        }
                    }/ commented
            }

            //Going through the new array
            foreach (var value in newArr)
            {
                if (value != 0)
                {
                    num = value;
                    isFoundoutside = true;
                    break;
                }
            }

            if (isFoundoutside)
                return num;
            else
                return -1;

        }
    }*/

        #endregion

        #region Using Dictionary

        public static int firstDuplicate(int[] a)
        {
            // (value, index)
            Dictionary<int, int> dupSet = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (dupSet.ContainsKey(a[i]))
                {
                    return a[i];
                }
                else
                {
                    dupSet.Add(a[i], i);
                }
            }
            return -1;
        }

        #endregion

        #region Using Hash Set

        /*int firstDuplicate(int[] a)
        {
            var prevNums = new HashSet<int>();
            foreach (int n in a)
            {
                if (prevNums.Contains(n))
                    return n;
                prevNums.Add(n);
            }
            return -1;
        }*/
        #endregion

    }
}
