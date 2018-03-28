using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.HashTables
{
    public static class ContainsCloseNumsExersice_Dictionary
    {
        public static bool containsCloseNums(int[] nums, int k)
        {
            Dictionary<int,int> dic = new Dictionary<int, int>();
            int[] result = new int[] {};
            bool flag = false;

            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(i, nums[i]);
            }

            //way to to check the duplicate values in the dictionary
            var sortedDic = dic.GroupBy(x => x.Value).Where(x => x.Count() > 1);
            /*var result = from p in dic
                         group p by p.Value into g
                         where g.Count() > 1
                         select g;*/

            foreach (var r in sortedDic)
            {
                result = (from p in r
                                 select p.Key).ToArray();
            }

            int j = 1;
            for (int i = 0; i < result.Length && j < result.Length; i++)
            {
                int sum = result[j] - result[i];
                if (sum <= k)
                    flag = true;
                else
                    j++;
            }
        
            return flag;
        }
    }
}
