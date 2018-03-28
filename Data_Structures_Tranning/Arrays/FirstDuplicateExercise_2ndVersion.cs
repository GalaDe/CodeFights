using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSharpx.Collections;
using Microsoft.FSharp.Data.UnitSystems.SI.UnitNames;

namespace Data_Structures_Tranning
{
    public class FirstDuplicateExercise_2ndVersion
    {
        public static int firstDuplicate(int[] arr)
        {
            Dictionary<int, int> second  = new Dictionary<int, int>();
            HashSet<int> first = new HashSet<int>();

            for (int i = 0; i < arr.Length; ++i)
            {
                int num = arr[i];

                if (first.Contains(num) && !second.ContainsKey(num))
                {
                    second[num] = i;
                }

                first.Add(num);
            }
            int selected = -1;
            int minIndex = arr.Length;


            foreach (var item in second)
            {
                if (item.Value < minIndex)
                {
                    minIndex = item.Value;
                    selected = item.Key;
                }
            }

            return selected;
        }
    }
}
