using System;

namespace Test_Program
{
    public class ParentSorters
    {
        protected int[] array = null;
        protected int size = 0;

        public ParentSorters(int ArraySize)
        {
            this.size = ArraySize;
            array = new int[ArraySize];

        }
        public void Swap(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;

        }
        public virtual void Sort()
        {
     
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
