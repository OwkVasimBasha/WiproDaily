using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class DemoArry
    {
        public void show()
        {
            int[] a = new int[] { 1, 2, 3, 4, 4 };
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            DemoArry demo = new DemoArry();
            demo.show();
            
        }
    }
}
