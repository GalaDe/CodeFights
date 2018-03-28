using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.HashTables
{
    public class SwapLexOrderExercise_1
    {
        public static string swapLexOrder(string str, int[][] pairs)
        {
            // lexicographically largest string:
            // a) We only need to look on the order of pair letters
            // b) They should be decreasing order

            //P.S: This solution is not correct!!!
            List<char[]> strList = new List<char[]>();

            if (str.Length == 1)
                return str;

            //string str = "abdc"
            for (int i = 0; i < pairs.Length; i++)
            {
                var arrayStr = str.ToCharArray();
                for (int j = 0; j < 1; j++)
                {
                    char temp = arrayStr[(pairs[i][j]) - 1];
                    arrayStr[(pairs[i][j]) - 1] = arrayStr[(pairs[i][++j]) - 1];
                    arrayStr[(pairs[i][j]) - 1] = temp;               
                }
                strList.Add(arrayStr);
            }

            int largerest_char_pos = 0;
            string result = "";
            for (int i = 0; i < strList.Count - 1; i++)
            {
                for (int j = i + 1; j < strList[i].Length - 1; j++)
                {
                    if (strList[i][j] > strList[j][i])
                    {
                        result += strList[i][largerest_char_pos];
                    }
    
                }
   
                i = largerest_char_pos + 1;
            }

            return null;
        }
    }
}
