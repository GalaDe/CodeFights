using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning
{
    public class SodukuExercise_Version2
    {
        public static bool Sudoku(char[][] grid)
        {

            /*RULES: A number cannot repeat in any row or column or region.
                     If you see the number that you want to place is already placed in a row or column or region 
                     that is not where it is suppose to be.*/

            int num = 0;
            bool result = true;
            List<char> list = null;
            HashSet<char> list2 = new HashSet<char>();
            List<char> list3 = new List<char>();

            for (int i = 0; i < grid.Length; i++)//row
            {
                list = new List<char>();
                for (int j = 0; j < grid.Length; j++)//col
                {
                    if (grid[i][j] != '.')
                    {
                        list.Add(grid[i][j]);
                        list2.Add(grid[i][j]);
                    }
                }
                //Group the elements and look for repeating
                if (list.GroupBy(n => n).Any(c => c.Count() > 1))
                    return false;
            }

            list3 = list2.ToList();
            list3.Sort();

            List<char> a = new List<char>(new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' });
            //var b = Enumerable.Range(1, 9).ToList();

            if (list3.Count != a.Count)
                return false;

            return result;
        }




    }
}
