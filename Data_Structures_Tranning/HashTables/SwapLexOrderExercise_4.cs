using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.HashTables
{
    public class SwapLexOrderExercise_4
    {
        public static string swapLexOrder(string str, int[][] pairs)
        {
            /* Process pairs by mapping indices to all indices each is directly 
             * swappable with, or indirectly by association.
             */
            var sets = new Hashtable();
            foreach (var p in pairs)
            {
                // set values to be 0-based
                p[0]--;
                p[1]--;

                /* Retrieve sets for both members of the pair. We use sorted 
                 * set so that when we process the set later on, they are in 
                 * increasing index order from left to right.
                 */
                var set1 = sets[p[0]] as SortedSet<int>;
                var set2 = sets[p[1]] as SortedSet<int>;
                if (set1 != null && set2 != null && set1 != set2)
                {
                    // merge sets when both sets exist and are not the same set
                    set1.UnionWith(set2);
                    foreach (var i in set2)
                    {
                        sets[i] = set1;
                    }
                }

                /* Retrieve first non-null set, with set1 as a higher priority 
                 * due to above merge step that prefers set1, or create a new 
                 * set if both are null. Then add the swappable pair and map 
                 * their indices to the resulting set.
                 */
                set1 = set1 ?? set2 ?? new SortedSet<int>();
                set1.UnionWith(p);
                sets[p[0]] = sets[p[1]] = set1;
            }

            /* Build string by fetching the letters at the indices in the set, 
             * sorting them, and filling them back into the string using the 
             * same indices in the set (which are sorted in increasing order).
             */
            var strChars = new char[str.Length]; // our result string
            foreach (SortedSet<int> set in sets.Values)
            {
                /* Fetch the letters at the indices in the set and sort them in 
                 * reverse lexicographic order (largest first). Combine this 
                 * with the indices in the set (which are sorted in increasing 
                 * order) and assign each letter in sequence to each string 
                 * position in sequence. Note that because Zip has lazy 
                 * evaluation, to perform the assignment for all elements we 
                 * have to invoke a method that will process all elements. We 
                 * are going to use "Count" because it has relatively low 
                 * overhead.
                 */
                set.Zip(set.Select(_ => str[_]).OrderByDescending(_ => _), (i, p) => strChars[i] = p).Count();
            }

            /* Direct copy indices that are not swappable with anything, and 
             * therefore were never assigned (have a value of 0).
             */
            for (int i = 0; i < str.Length; i++)
            {
                if (strChars[i] == 0)
                    strChars[i] = str[i];
            }

            return new string(strChars);
        }
    }
}
