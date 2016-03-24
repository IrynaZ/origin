using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    class Inherited_Bubble_from_abstract<T> : AbstractSorter<T> where T : IComparable
    {
        public Inherited_Bubble_from_abstract(int ArraySize) : base(ArraySize)
        {
            
        }
        
        override public void Sort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(j, j + 1);
                    }
                }
            }
        }
    }
}
