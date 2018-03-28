using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.HashTables
{
    public class SwapLexOrderExercise_2
    {
        public static string swapLexOrder(string str, int[][] pairs)
        {
            var arrayStr = str.ToArray();

            //removeDuplicatesFromPairs used only to remove duplicates
            var removeDuplicatesFromPairs = new HashSet<int>(pairs.SelectMany(x => x).OrderBy(x => x));
            //lp contains pairs related to number
            var lp = new Dictionary<int, List<int>>();

            foreach (var item in removeDuplicatesFromPairs)
            {
                var listlp = pairs.Where(x => x.Contains(item)).SelectMany(x => x).ToList();
                lp.Add(item, listlp);
            }
            foreach (var item in removeDuplicatesFromPairs)
            {
                var list = new HashSet<int>();
                var newlist = new HashSet<int>(lp[item]);
                var max = arrayStr[item - 1];
                var index = -1;

                //???
                while (newlist.Count() > 0)
                {

                    list.UnionWith(newlist);
                    newlist = new HashSet<int>(newlist.Select(x => lp[x])
                        .SelectMany(x => x).Where(x => !list.Contains(x)));
                }

                //Looking for lexicographically largest string
                //First we took the largest number from the list -- 4
                foreach (var i in list.Where(x => x > item))
                {
                    if (arrayStr[i - 1] > max)
                    {
                        max = arrayStr[i - 1];
                        index = i - 1;
                    }
                }

                if (index != -1)
                {
                    var temp = arrayStr[index];
                    arrayStr[index] = arrayStr[item - 1];
                    arrayStr[item - 1] = temp;
                }
            }
            return new string(arrayStr);
        }

    }
}
