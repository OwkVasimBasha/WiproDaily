using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class UsingCommandPrompt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("My name is"+name);

        }
    }
}
