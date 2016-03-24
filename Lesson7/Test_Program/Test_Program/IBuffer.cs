using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    interface IBuffer<T> : Iprintable
    {
        bool IsFull();
        bool IsEmpty();
        T Peek();


    }
}
