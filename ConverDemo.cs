using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class ConverDemo
    {
        int a, b;
        public ConverDemo()
        {
            a = 5;
            b = 7;
        }
        public ConverDemo(int a,int b)
        {
            this.a = a;
            this.b = b;

        }
        public void show()
        {
            Console.WriteLine("A value is"+a+ "B value is"+b);
        }
        static void Main()
        {
            ConverDemo demo = new ConverDemo();
            demo.show();
            ConverDemo demo1 = new ConverDemo(10, 20);
            demo1.show();
        }

    }
}
