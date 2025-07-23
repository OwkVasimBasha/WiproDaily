using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class OOPS
    {
        public int Sum()
        {
            return 5;
        }
        public int Sum(int x,int y)
        {
            return x + y;
        }
        static void Main()
        {
            OOPS o = new OOPS();
            Console.WriteLine("Sum with Zero Args"+o.Sum());
            Console.WriteLine("Sum with Two Args" + o.Sum());



        }
    }
}
