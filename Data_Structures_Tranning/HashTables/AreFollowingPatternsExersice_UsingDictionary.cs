using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning.HashTables
{
    public class AreFollowingPatternsExersice_UsingDictionary
    {
        public static bool areFollowingPatterns(string[] strings, string[] patterns)
        {
            var dic = new Dictionary<string, string>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (dic.ContainsKey(patterns[i]))
                {
                    if (dic[patterns[i]] != strings[i])
                        return false;
                }
                else
                {
                    if (dic.ContainsValue(strings[i]))
                        return false;
                    dic.Add(patterns[i], strings[i]); //key, value
                }

            }
            return true;
        }
    }
}
