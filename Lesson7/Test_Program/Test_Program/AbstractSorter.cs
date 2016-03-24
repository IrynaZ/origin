using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    abstract class AbstractSorter<T> : ISorter<T>
    {
        protected int size = 0;
        protected T[] array = null;

        public AbstractSorter(int ArraySize)
        {
            this.size = ArraySize;
            array = new T[ArraySize];

        }

        public abstract void Sort();

        public void Swap(int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public void Print()
        {
            Console.Write("Sorted array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("| {0}, | ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
