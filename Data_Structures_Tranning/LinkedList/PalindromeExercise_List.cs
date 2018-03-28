using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.LinkedList
{
    public class PalindromeExercise_List
    {
        public static bool isListPalindrome(List<int> l)
        {
            bool result;
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            int half = l.Count/2;

            if (l.Count <= 2)
                return false;

            for (int i = 0; i < half; i++)
            {a.Add(l[i]);}

            for (int j = l.Count - 1; j > half; j--)
            {b.Add(l[j]);}

            result = (a.Count == b.Count) && !a.Except(b).Any();
            return result;

        }

    }
}
