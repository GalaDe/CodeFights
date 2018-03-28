using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning
{
    public class RotateImageExercise
    {
        public static  int[][] rotateImage(int[][] a)
        {

            #region With only print fanction
            /*int [,] newArr = new int[a.GetLength(0), a.GetLength(1)];
            // Lenght = 3
            for (int i = 0; i < a.GetLength(0); i++) //col
            {
                //Lenght = 3
                for (int j = a.GetLength(0) - 1; j >= 0; j--)//row
                {
                    newArr[j,i] = a[j,i];
                    Console.Write(a[j, i]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }

            return newArr;*/
            #endregion


            #region Using List<int[]> r, List and reverse command

            /*Logic: 
             1. I have 3 arrays, we will be adding by 3
             2. First adding to list t: 3 6 9 
                                        2 5 8 
                                        1 4 7
             3. Reverse command will switch first an last in our case:
                    9 6 3 
                    8 5 2 
                    7 4 1
             4. The last step is the Insertion into List<int[]> r,
                since 9 6 3 was the first in the previous list, they will be inserted first,
                but at the will be the last: 7 4 1
                                             8 5 2 
                                             9 6 3 
                    */
            //List<int[]> r = new List<int[]>();

            //i = 2, runs 3 times
            /*for (int i = a.Length - 1; i >= 0; i--) //column
            {
                List<int> t = new List<int>();
                //j = 0, runs 3 times
                for (int j = 0; j < a.Length; j++) //row
                    t.Add(a[j][i]);

                t.Reverse();
                r.Insert(0, t.ToArray());
            }
            return r.ToArray();*/

            #endregion

            #region Using array and reverse

            List<int[]> r = new List<int[]>();
            int[][] newArr = {new int[a.Length]};
            for (int i = 0; i < a.Length; i++)
            {
                List<int> t = new List<int>();
                for (int j = a.Length - 1; j >= 0; j--)
                {
                    //newArr[i][j] = a[j][i];
                    t.Add(a[j][i]);
                }
                //Array.Reverse(newArr[i]);
                t.Reverse();
                r.Insert(0, t.ToArray());
            }

            return newArr;
            #endregion
        }
    }


}
