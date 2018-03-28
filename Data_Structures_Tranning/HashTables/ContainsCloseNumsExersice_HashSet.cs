using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.HashTables
{
    public class ContainsCloseNumsExersice_HashSet
    {
        public static bool containsCloseNums(int[] nums, int k)
        {
            var a = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!a.Add(nums[i]))
                {
                    return true;
                }
                if (i >= k)
                {
                    a.Remove(nums[i - k]);
                }
            }
            return false;

        }
    }
}
