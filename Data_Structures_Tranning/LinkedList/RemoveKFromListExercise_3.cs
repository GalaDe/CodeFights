using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures_Tranning.LinkedList;

namespace Data_Structures_Tranning
{
    public class RemoveKFromListExercise_3
    {
        public static LinkedList<int> removeKFromList(LinkedList<int> l, int k)
        {
            if (l.Count < 0)
                return null;

            //foreach (var item in l)
            //{
            //    if (item == k)
            //        l.Remove(item);
            //}

            var node = l.First;
            while (node != null)
            {
                var nextNode = node.Next;
                if (node.Value == k)
                {
                    l.Remove(node);
                }
                node = nextNode;
            }
            return l;
        }
    }
}
