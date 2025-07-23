using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class ObjectAssignthroughRef
    {
        public void Increment(ref int x)
        {
            ++x;
        }
        static void Main()
        {
            int x = 13;
            ObjectAssignthroughRef r = new ObjectAssignthroughRef();
            r.Increment(ref x);
            Console.WriteLine(x);
        }
    }
}
