using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class PerfectNumberDemo
    {
        public void show(int n)
        {
            int sum = 0;
            for (int i =1;i<n;i++)
            {
                if(n%i==0)
                {
                    sum +=i;
                }
            }
            if(sum==n)
            {
                Console.WriteLine("Perfect number");
            }
            else
            {
                Console.WriteLine("Not perfect Number");
            }
        }
       static void Main()

        {
            int n;
            Console.WriteLine("Enter the value of n");
            n = Convert.ToInt32(Console.ReadLine());
            PerfectNumberDemo demo = new PerfectNumberDemo();
            demo.show(n);

        }
    }
}
