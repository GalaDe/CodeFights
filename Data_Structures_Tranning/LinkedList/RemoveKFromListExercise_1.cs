using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning
{
    public class RemoveKFromListExercise_1
    {
        public static List<int> removeKFromList(List<int> l, int k)
        {
            if (l.Count < 0)
                return null;


            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] == k)
                {
                    l.Remove(l[i]);
                }
            }

            return l;
        }



    }
}
