using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSharpx.Collections;

namespace Data_Structures_Tranning.LinkedList
{
    public class ListNode1<T>
    {
        public T value { get; set; }
        public ListNode1<T> next { get; set; }

        public ListNode1(T node)
        {
            value = node;
        }

        public ListNode1()
        {
            value = value;
        }
    }

}
