using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning
{
    public class FirstNotRepeatingCharacterExercise
    {
        public static char firstNotRepeatingCharacter(string s)
        {
            char none = '_';
            char remember = '\0';
            var result = '\0';
            //List<char> list1 = s.ToList();

            //The commented solution below is removing only pair of characters
            //For example, if it will be odd number of characters, result will be incorrect
            /*for (int i = 0; i < s.Length; i++)
            {
          
                if (list1.Exists(x => x.Equals(s[i])) || (s[i] == remember))
                {
                    remember = s[i];
                    list1.RemoveAll(x => x.Equals(s[i]));
                }
                else
                {
                    list1.Add(s[i]);
                }
            }


            if (list1.Count > 0)
                return list1.First();
            else
                return none;*/

            for (int index = 0; index < s.Length; index++)
            {
                if (s.LastIndexOf(s[index]) == s.IndexOf(s[index]))
                {
                    result = s[index];
                    return result;
                }
            }

            return none;
        }
    }
}
