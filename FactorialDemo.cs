using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class FactorialDemo
    {
        public void show(int n)
        {
            int i = 1, f = 1;
            while(i<=n)
            {
                f = f * i;
                i++;
            }
            Console.WriteLine("Factorila value"+f);
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter the value of n");
            n = Convert.ToInt32(Console.ReadLine());
            FactorialDemo f = new FactorialDemo();
            f.show(n);
        }
    }
}
