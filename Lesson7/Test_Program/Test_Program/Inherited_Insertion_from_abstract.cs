using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    class Inherited_Insertion_from_abstract<T> : AbstractSorter<T> where T : IComparable
    {
        public Inherited_Insertion_from_abstract(int ArraySize) : base(ArraySize)
        {
            
        }
        public override void Sort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j - 1].CompareTo(array[j])> 0)
                {
                    Swap(j, j - 1);
                    j--;
                }

            }
        }
    }
}
