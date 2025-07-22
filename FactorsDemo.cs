using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class FactorsDemo
    {
        public void show(int n)
        {
            for(int i=0;i<=n;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine("Factor"+i);
                }
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter the factorial value");
            n = Convert.ToInt32(Console.ReadLine());
            FactorialDemo demo = new FactorialDemo();
            demo.show(n);

        }

    }
}
