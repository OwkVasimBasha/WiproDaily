using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Calculation
    {
        public int sum(int a , int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }

        public int mul(int a,int b)
        {
            return a * b;
        }
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter the two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calculation c = new Calculation();
            int result = c.sum(a, b);
            Console.WriteLine("The sum of two numbers are"+result);
            result = c.sub(a, b);
            Console.WriteLine("The sub of two numbers are"+ result);
            result = c.mul(a, b);
            Console.WriteLine("The multiplication of two numbers are"+result);

            
        }
    }
}
