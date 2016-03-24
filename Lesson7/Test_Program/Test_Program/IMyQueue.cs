using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    interface IMyQueue<T>
    {
        void Enqueue(T value);
        T Dequeue();

    }
}
