using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class PositiveOrNegative
    {
        public void check(int a)
        {
            if (a<0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
        }
        static void Main()
        {
            int a;
            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            PositiveOrNegative p = new PositiveOrNegative();
            p.check(a);
           
            
            
        }
    }
}
