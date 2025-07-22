using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class InputThroughCommandPrompt
    {
        static void Main()
        {
            int a;
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            String name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("The value of a is"+a);
            Console.WriteLine("The name is"+name);

        }
    }
}
