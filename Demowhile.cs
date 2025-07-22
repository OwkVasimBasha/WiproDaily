using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Demowhile
    {
        public void show()
        {
            int i = 0;
            int count = 10;
            while(i<count)
            {
                Console.WriteLine("welcome to dot net");
                i++;
               
            }
        }
        static void Main()
        {
            Demowhile d = new Demowhile();
            d.show();

        }
    }
}
