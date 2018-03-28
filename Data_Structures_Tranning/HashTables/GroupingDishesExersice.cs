using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSharpx.Collections;

namespace Data_Structures_Tranning.HashTables
{
    public class GroupingDishesExersice
    {
        public static string[][] groupingDishes(string[][] dishes)
        {

            //1st item in array is name of the dish
            //Group dishes by ingredient >> result should have: 1st item ingredient, than dishes
            //Sort dishes  lexicographically

            Dictionary<string, HashSet<string>> dict = new Dictionary<string, HashSet<string>>();

            //better to use foreach in this case, because var dish in this case will be the whole array
            foreach (var dish in dishes)
            {
                var dishName = dish.First();
                //var ingredient will be item from array of arrays               
                foreach (var ingredient in dish.Skip(1))
                {
                    if (!dict.ContainsKey(ingredient))
                    {
                        dict[ingredient] = new HashSet<string>();
                    }
                    dict[ingredient].Add(dishName);
                }
            }

            var ingredients = dict.Where(kvp => kvp.Value.Count > 1).OrderBy(kvp => kvp.Key, StringComparer.Ordinal).Select(
                kvp => {
                    var l = new List<string>() { kvp.Key };
                    l.AddRange(kvp.Value.OrderBy(x => x, StringComparer.Ordinal));
                    return l.ToArray();
                }).ToArray();

            return ingredients;
        }

    }
}
