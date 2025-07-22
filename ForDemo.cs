using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class ForDemo
    {
        public void show(int a)
        {
            for(int i =0; i< a; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            int a;
            Console.WriteLine("Enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            ForDemo f = new ForDemo();
            f.show(a);

        }
    }
}
