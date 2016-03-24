using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    interface IMyStack<T>
    {
        void Push(T value);
        T Pop();
    }
}
