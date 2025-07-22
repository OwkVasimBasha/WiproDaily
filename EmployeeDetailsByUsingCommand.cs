using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class EmployeeDetailsByUsingCommand
    {
        public int a;
        public String b;
       

        static void Main()
        {
            EmployeeDetailsByUsingCommand c = new EmployeeDetailsByUsingCommand();
            Console.WriteLine("Enter employee number and name");
            c.a = Convert.ToInt32(Console.ReadLine());
            c.b = Console.ReadLine();
            Console.WriteLine("The value of a is" + c.a);
            Console.WriteLine("The value of b is" + c.b);
           



        }

    }
    
}
