using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.HashTables
{
    public class SwapLexOrderExercise_3
    {
        public static string swapLexOrder(string str, int[][] pairs)
        {
            var groups = new List<HashSet<int>>();
            foreach (var pair in pairs)
            {
                var a = pair[0] - 1;
                var b = pair[1] - 1;
                bool AddedToGroup = false;
                HashSet<int> groupFound = null;

                foreach (var group in groups)
                {
                    if (group.Contains(a) || group.Contains(b))
                    {
                        if (AddedToGroup)
                        {
                            foreach (var i in group)
                                groupFound.Add(i);
                            group.Clear();
                        }
                        else
                        {
                            group.Add(a);
                            group.Add(b);
                            AddedToGroup = true;
                            groupFound = group;
                        }
                    }
                }
                if (!AddedToGroup)
                {
                    var hs = new HashSet<int>();
                    hs.Add(a);
                    hs.Add(b);
                    groups.Add(hs);
                }
            }
            var charArray = str.ToCharArray();
            foreach (var group in groups)
            {
                var orderedIndexes = group.ToList();
                orderedIndexes.Sort();
                Console.WriteLine(string.Join(",", orderedIndexes));
                var orderedChars = group.Select(i => charArray[i]).OrderByDescending(c => c.ToString()).ToList();
                Console.WriteLine(string.Join(",", orderedChars));
                for (var i = 0; i < orderedIndexes.Count; i++)
                {
                    charArray[orderedIndexes[i]] = orderedChars[i];
                }
            }
            return new string(charArray);
        }
    }
}
