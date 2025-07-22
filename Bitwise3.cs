using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Bitwise3
    {
        //Bitwise XOR sets each bit to 1 if the corresponding bits are different
        static void Main()
        {
            int a = 5, b = 3;
            //101
            //011
            //110 Result
            Console.WriteLine(a^b);
        }
       
    }
}
