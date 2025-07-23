using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class ObjectAssign
    {
        int n;
        static void Main()
        {
            int x = 12;
            ObjectAssign b1 = new ObjectAssign();
            b1.n = 12;
            ObjectAssign b2 = b1;
            b2.n = 13;
            Console.WriteLine(b1.n);
            Console.WriteLine(b1.GetHashCode());
            Console.WriteLine(b2.GetHashCode());

        }

    }
}
