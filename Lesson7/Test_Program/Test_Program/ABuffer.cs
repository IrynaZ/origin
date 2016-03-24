using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    abstract class ABuffer<T> : IBuffer<T>
    {

        protected int size = 0;
        protected T[] array = null;
        protected int pointer = 0;

        public ABuffer(int ArraySize)
        {
            this.size = ArraySize;
            array = new T[ArraySize];

        }

        public bool IsFull()
        {
            if (pointer == size)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsEmpty()
        {
            if (pointer == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("This Stack Is Empty!");
                return default(T);
            }
            else
            {
                return array[pointer - 1];
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Buffer Is Empty!");
            }
            else
            {
                Console.Write("Buffer Array is: ");
                for (int i = 0; i < pointer; i++)
                {
                    Console.Write("| {0}, | ", array[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
