using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    class MyQueue<T> : ABuffer<T>, IMyQueue<T> where T : IComparable
    {
           public MyQueue(int ArraySize) : base(ArraySize)
        {
            
        }

           public void Enqueue(T value)
           {
               if (IsFull())
               {
                   Console.WriteLine("Queue is Full");
               }
               else
               {
                   array[pointer] = value;
                   pointer++;
               }
           }

           public T Dequeue()
           {
               if (IsEmpty())
               {
                   Console.WriteLine("This Queue Is Empty!");
                   return default(T);
               }
               else
               {
                   return array[--pointer];
               }
           }
    }
}
