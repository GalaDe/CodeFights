using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.HashTables
{
    public class GroupingDishesExersice_UsingLINQ_2
    {
       public static string[][] groupingDishes(string[][] dishes)
        {
            /*SortedDictionary:
             * keeps its keys always sorted. 
             * Slower than Dictionary*/

            /*SortedSet:
             * This is an ordered set collection. 
             * We have many elements and want to store them in a sorted order
             * Eliminate all duplicates from the data structure.*/

            var ingredients = new SortedDictionary<string, SortedSet<string>>(StringComparer.Ordinal);

            //Step 1: sort by ingredients
            foreach (var d in dishes)
            {
                foreach (var i in d.Skip(1))
                {
                    (ingredients.ContainsKey(i) ? ingredients[i] : ingredients[i] = new SortedSet<string>(StringComparer.Ordinal)).Add(d[0]);
                    /*if (ingredients.ContainsKey(i))
                    {
                         ingredients[i] = new SortedSet<string>(StringComparer.Ordinal)).Add(d[0]);
                    }
                    
                    ingredients[i] = new SortedSet<string>(StringComparer.Ordinal)).Add(d[0]);*/
                }
            }

            //Step 2: If Count > 1 >> add to array
            return ingredients.Where(_ => _.Value.Count > 1).Select(_ => new[] { _.Key }.Concat(_.Value).ToArray()).ToArray();
        }

    }
}
