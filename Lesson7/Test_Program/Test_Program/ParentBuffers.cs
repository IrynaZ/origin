using System;


namespace Test_Program
{
    class ParentBuffers
    {

        protected int size = 0;
        protected int[] array = null;
        protected int pointer = 0;

        public ParentBuffers(int arraysize)
        {
            this.size = arraysize;
            this.array = new int[arraysize];
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

        public void AddValue(int value)
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
        public virtual int DropValue()
        {

            return 0;

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
