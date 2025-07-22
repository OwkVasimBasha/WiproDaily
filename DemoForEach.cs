using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class DemoForEach
    {
        public void show(int a)
        {
            for(int i=2; i<a;i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            int a;
            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            DemoForEach d = new DemoForEach();
            d.show(a);
        }
    }
}
