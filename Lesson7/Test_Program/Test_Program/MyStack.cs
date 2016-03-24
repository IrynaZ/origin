using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    class MyStack<T> : ABuffer<T>, IMyStack<T> where T : IComparable
    {
        public MyStack(int ArraySize) : base(ArraySize)
        {
            
        }

        public void Push(T value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is Full");
            }
            else
            {
                array[pointer] = value;
                pointer++;
            }
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("This Stack Is Empty!");
                return default (T);
            }
            else
            {
                return array[--pointer];
            }
        }
    }
}
