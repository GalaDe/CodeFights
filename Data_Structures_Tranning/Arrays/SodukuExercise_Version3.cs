using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning
{
    public class SodukuExercise_Version3
    {
        //accepting 9 different arrays
        public static bool Sudoku(char[][] board)
        {
            /*RULES: A number cannot repeat in any row or column or region.
                     If you see the number that you want to place is already placed in a row or column or region 
                     that is not where it is suppose to be.*/

            int column;
            int columngroup;
            List<char> listChars;
            int row;
            int rowgroup;

            // Ensure that the sizes are correct.  
            if (board.Length != 9)
            {
                return false;
            }


            // Check the rows.
            for (row = 0; row < 9; row++) // j
            {
                listChars = new List<char>();

                for (column = 0; column < 9; column++)// i
                {
                    listChars.Add(board[row][column]);
                }
                if (!isValidSet(listChars))
                {
                    return false;
                }
            }

            // Check the columns.
            for (column = 0; column < 9; column++) //j
            {
                listChars = new List<char>();

                for (row = 0; row < 9; row++) // i
                {
                    listChars.Add(board[row][column]);
                }
                if (!isValidSet(listChars))
                {
                    return false;
                }
            }


            // Check the sub-boxes.
            for (rowgroup = 0; rowgroup < 3; rowgroup++)
            {
                for (columngroup = 0; columngroup < 3; columngroup++)
                {
                    listChars = new List<char>();

                    for (row = 0; row < 3; row++)
                    {
                        for (column = 0; column < 3; column++)
                        {
                            listChars.Add(board[rowgroup * 3 + row][columngroup * 3 + column]);
                        }
                    }
                    if (!isValidSet(listChars))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool isValidSet(List<char> listChars)
        {
            HashSet<char> setCharsSeen = new HashSet<char>();

            foreach (char ch in listChars)
            {
                if (ch == '.')
                {
                    // Do nothing. Any combination of '.' is fine.
                }
                else if (ch >= '1' && ch <= '9')
                {
                    if (setCharsSeen.Contains(ch))
                    {
                        return false; // We've seen this number before.
                    }
                    setCharsSeen.Add(ch);
                }
                else {
                    return false; // It's not a . or 1-9.
                }
            }

            return true;
        }

    }
}
