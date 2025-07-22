using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class BoxingAndUnBoxingDemo
    {
        static void Main()
        {
            int x = 200;
            string s = "Wipro";
            double y = 12.5;

            //Boxing
            object ob1 = x;
            object ob2 = s;
            object ob3 = y;

            //unboxing 
            int x1 = (Int32)ob1;
            string s1 = (String)ob2;
            double y1 = (double)ob3;

            Console.WriteLine(x1);
            Console.WriteLine(y1);
            Console.WriteLine(s1);


        }
    }
}

