using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.HashTables
{
    public class GroupingDishesExersice_UsingLINQ
    {
        public static string[][] groupingDishes(string[][] dishes)
        {
            //a -- array
            //a => a.Skip(1) -- means skip the 1st element
            var x = dishes
                .SelectMany(a => a.Skip(1).Select(r => new Tuple<string, string>(r, a[0])))
                .GroupBy(g => g.Item1, g => g.Item2)
                .Where(h => h.Count() > 1);
            return x.Select(h => (new string[] { h.Key }).Concat(h.OrderBy(m => m, StringComparer.Ordinal)).ToArray())
                .OrderBy(h => h[0], StringComparer.Ordinal).ToArray();
        }
    }
}
