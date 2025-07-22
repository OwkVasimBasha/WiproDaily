using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class CirclePrograme
    {

        public void  TofindRadius(double a)
        {
            double area, cir;
            area = Math.PI * a * a;
            cir = 2 * Math.PI * a;
            Console.WriteLine("Area of circle"+area);
            Console.WriteLine("Circumference"+cir);

           
        }
        static void Main()
        {
            double a;
            Console.WriteLine("Enter the value of a");
            a = Convert.ToDouble(Console.ReadLine());

            CirclePrograme c = new CirclePrograme();
            c.TofindRadius(a);
            
        




        }
    }
}
