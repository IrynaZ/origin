using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    public class Stack<T>
    {
        protected T[] array = null;
        protected int size = 0;
        private int pointer = 0;

        public Stack(int ArraySize)
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

        public void AddValue(T value)
        {
            if (IsFull())
            {
                Console.WriteLine("Buffer is Full");
            }
            else
            {
                array[pointer] = value;
                pointer++;
            }

        }
        public virtual T DropValue()
        {

            if (IsEmpty())
            {
                Console.WriteLine("This Stack Is Empty!");
                return default(T);
            }
            else
            {
                return array[--pointer];
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
