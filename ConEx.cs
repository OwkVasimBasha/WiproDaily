using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class ConEx
    {
        static ConEx()
        {
            Console.WriteLine("Static Constuctor");
        }
        ConEx()
        {
            Console.WriteLine("Instance Constructor");
        }
        static void Main()
        {
            ConEx c = new ConEx();
            
        }
    }
}
