using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning
{
    public class CryptSolutionExercise
    {
        public static bool isCryptSolution(String[] crypt, char[][] solution)
        {
            bool flag = false;

            List<char[]> wordHolder = new List<char[]>();
            wordHolder = crypt.Select(str => str.ToCharArray()).ToList();

            Dictionary<char, char> solutionHolder = new Dictionary<char, char>();
            for (int i = 0; i < solution.Length; i++)
                solutionHolder.Add(solution[i][0], solution[i][1]);

            //For Dictionary<char, char>, by using trick: solution[i][1] - '0' -- gives you char instead of int
            //solutionHolder.Add(solution[i][0], solution[i][1] - '0');


            if (crypt.Length <= 2)
                return false;

            int[] nums = new int[3];

            for (int i = 0; i < wordHolder.Count; i++)
            {
                for (int j = 0; j < wordHolder[i].Length; j++)
                {
                    //char temp = FindNumber(wordHolder[i][j]);
                    if (wordHolder[i].Length > 1 && solutionHolder[crypt[i][0]] == '0')
                        return false;

                    nums[i] = nums[i] * 10 + (solutionHolder[crypt[i][j]] - '0');

                }
            }

            return nums[0] + nums[1] == nums[2];
        }


       /* static char FindNumber(char temp)
        {
            char num = '\0';

            foreach (var item in solutionHolder)
            {
                if (item.Key == temp)
                    num = item.Value;
            }

            return num;
        }*/

    }
}
