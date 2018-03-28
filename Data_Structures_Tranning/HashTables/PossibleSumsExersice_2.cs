using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.HashTables
{
    public class PossibleSumsExersice_2
    {
        public static int possibleSums(int[] coins, int[] quantity)
        {
            HashSet<int> sumsSet = new HashSet<int>();
            sumsSet.Add(0);
            for (int i = 0; i < quantity.Length; ++i)
            {
                List<int> sumsCurrent = new List<int>(sumsSet);
                foreach (int sum in sumsCurrent)
                {
                    for (int j = 1; j <= quantity[i]; ++j)
                    {
                        sumsSet.Add(sum + j * coins[i]);
                    }
                }
            }
            return sumsSet.Count() - 1;
        }
    }
}
