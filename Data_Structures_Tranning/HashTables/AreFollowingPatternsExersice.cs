using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Examples
input: "ant dog cat dog", "a d c d"
output: true
This is true because every variable maps to exactly one word and vice verse.
a -> ant
d -> dog
c -> cat
d -> dog

input: "ant dog cat dog", "a d c e"
output: false
This is false because if we substitute "d" as "dog" then you can not also have "e" be substituted as "dog".
a -> ant
d, e -> dog (Both d and e can't both map to dog so false)
c -> cat

input: "monkey dog eel eel", "e f c c"
output: true
This is true because every variable maps to exactly one word and vice verse.
e -> monkey
f -> dog
c -> eel*/
namespace Data_Structures_Tranning.HashTables
{
    public class AreFollowingPatternsExersice
    {
        public static bool areFollowingPatterns(string[] strings, string[] patterns)
        {
            /*19/20 tests passed*/
            HashSet<string> setStrings = new HashSet<string>();
            HashSet<string> setPatterns = new HashSet<string>();

            if (strings.Length < 1)
                return false;

            if (patterns.Length < 1)
                return false;

            for (int i = 0; i < strings.Length; i++)
            {
                setStrings.Add(strings[i]);
            }
            for (int i = 0; i < patterns.Length; i++)
            {
                setPatterns.Add(patterns[i]);
            }

            if (setStrings.Count == setPatterns.Count)
                return true;
            else
                return false;
        }

    }
}
