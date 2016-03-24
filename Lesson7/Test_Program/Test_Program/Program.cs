using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> IrynaZ = new MyStack<int>(4);
           
            IrynaZ.Push(7);
            IrynaZ.Push(25);
            IrynaZ.Push(6);
           
            IrynaZ.Push(17);
            IrynaZ.Push(666);
            IrynaZ.Print();
            IrynaZ.Pop();
            IrynaZ.Peek();

            IrynaZ.Print();
            


        }
    }
}
