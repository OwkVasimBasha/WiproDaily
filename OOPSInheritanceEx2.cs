using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class First
    {
        public void Show()
        {
            Console.WriteLine("This is first class");

        }
    }
    class Second: First
    {
        public void Display()
        {
            Console.WriteLine("This is Second class");
        }
    }
    internal class OOPSInheritanceEx2
    {
        static void Main()
        {
            Second s = new Second();
            s.Show();
            s.Display();

            
        }

        

    }
}
