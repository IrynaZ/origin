using System;


namespace Test_Program
{
    interface ISorter<T> : Iprintable
    {

        void Sort();

        void Swap(int i, int j);

    }
}
