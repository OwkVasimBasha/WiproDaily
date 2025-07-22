using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class ArrayCopy
    {
        public void show()
        {
            int[] a = new int[] { 12, 5, 32, 55, 22 };
            int[] b = a;
            for (int i=0;i<b.Length;i++)
            {
                Console.WriteLine(b[i]);
            }
        }
        static void Main()
        {
            ArrayCopy a = new ArrayCopy();
            a.show();



        }
    }
}
