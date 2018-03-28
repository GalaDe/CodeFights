using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning
{
    public class SudokuExercise_Version1
    {
        public static bool Sudoku(char[,] grid)
        {
            int num = 0;
            bool result = false;
            List<char> list = null;
            List<char> list2 = new List<char>();
            List<char> list3 = new List<char>();

            for (int i = 0; i < grid.GetLength(0); i++)//col
            {
                list = new List<char>();
                for (int j = 0; j < grid.GetLength(0); j++)//row
                {
                    if (grid[i, j] != '.')
                    {
                        list.Add(grid[i, j]);
                    }   
                }
                //Group the elements and look for repeating
                if (list.GroupBy(n => n).Any(c => c.Count() > 1))
                    result = false;
                else
                    result = true;
            }

           
           
            return result;
        }
    }
}
