using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class MileStoneEx2
    {
        static void Main()
        {
            string str = "Welcome to dot net vasim basha";
            string[] names = str.Split(' ');
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
