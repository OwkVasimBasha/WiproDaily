using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class A
    {
        public A()
        {
            Console.WriteLine("This is A class");
        }
    }
    class B: A
    {
        public B()
        {
            Console.WriteLine("This is B class");
        }

    }
    internal class OOPsInheritance
    {
        static void Main()
        {
            B b = new B();
        }
    }
}
