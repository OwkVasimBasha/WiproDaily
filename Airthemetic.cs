using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Airthemetic
    { 
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter 2 number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Sum is " + c);
            c = a - b;
            Console.WriteLine("sub is " + c);
            c = a * b;
            Console.WriteLine("Mul is " + c);

        }
    }
}
