using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class GreaterThanNumber
    {
        public void greater(int a, int b, int c)
        {

            //int m = a;
            //if(m<b)
            //{
            //    Console.WriteLine("Max is"+a);
            //}
            //else if (b>=c)
            //{
            //    Console.WriteLine("Max is"+b);
            //}
            //else
            //{
            //    Console.WriteLine("Max is"+c);
            //}


            if (a>b && a>c)
            {
                Console.WriteLine(" a is big"+a);
            }
            else if(b>a && b>c)
            {
                Console.WriteLine(" b is big"+b);
            }
            else
            {
                Console.WriteLine("c is big"+c);
            }
        }
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter the three numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            GreaterThanNumber g = new GreaterThanNumber();
            g.greater(a, b, c);


        }
    }
}
