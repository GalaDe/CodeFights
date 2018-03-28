using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.HashTables
{
    public class ContainsCloseNumsExersice
    {
        //All tests passed, but exceeds the Execution time limit 
        public static bool containsCloseNums(int[] nums, int k)
        {
            int sum = 0;
            bool result = false;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = nums.Length - 1; j >= 0; j--)
                {
                    if (i == j)
                        continue;
                    if (nums[i] == nums[j])
                    {
                        if (j > i)
                        {
                            sum = j - i;
                            if (sum <= k)
                            {
                                result = true;
                            }
                        }
                    }
                }
            }
            return result;

            #region
            /*for (int i = 0; i < nums.Length / 2; i++)
            {
                for (int j = nums.Length - 1; j >= nums.Length / 2; j--)
                {
                    if (nums[i] == nums[j])
                    {
                        if (j > i)
                        {
                            sum = j - i;
                            if (sum <= k)
                            {
                                result = true;
                            }
                        }
                    }
                }
            }
            return result;*/
            #endregion

        }
    }
}
