using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Tranning
{
    interface StackADT
    {
        Boolean isEmpty();
        void Push(Object element);
        Object Pop();
        Object Peek();
        void Display();
    }
}
