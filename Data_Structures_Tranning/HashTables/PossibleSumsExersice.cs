using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.HashTables
{
    public class PossibleSumsExersice
    {
        public static int possibleSums(int[] coins, int[] quantity)
        {
            int sum = 0;
            int sum2 = 0;
            int total = 0;
            int quan = 0;
            int repeat = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            HashSet<int> set = new HashSet<int>();

            if ((quantity.Length == 1) && (quantity[0] == 1))
                return 1;

            for (int i = 0; i < coins.Length && i < quantity.Length; i++)
            {
                total += coins[i];
                if (!set.Contains(total))
                    set.Add(total);
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[i] == coins[j])
                    {
                        if (!set.Contains(coins[j]))
                            set.Add(coins[j]);
                    }
                    else
                    {
                        sum = coins[i] + coins[j];
                        if (!set.Contains(sum))
                            set.Add(sum);
                        if (quantity[j] > 1)
                        {
                            quan = quantity[j];
                            repeat = coins[j];
                            for (int k = 0; k < coins.Length; k++)
                            {

                                if (coins[k] != coins[j])
                                {
                                    sum2 += coins[k] + (coins[j] * quantity[j]);
                                    if (!set.Contains(sum2))
                                        set.Add(sum2);
                                }
                                else
                                {
                                    int sum3 = coins[j] + coins[j];
                                    set.Add(sum3);
                                }
                                sum2 = 0;
                            }
                        }
                    }                     
                }
                sum = 0;
            }

            int total2 = total + (quan * repeat) - repeat;
            if (!set.Contains(total2))
                set.Add(total2);

            //for (int i = 0; i < coins.Length; i++)
            //{
            //    dic.Add(coins[i], quantity[i]); //key, value
            //}



            return set.Count;
        }
    }
}
