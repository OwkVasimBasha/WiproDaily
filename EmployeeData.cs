using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class EmployeeData
    {
        static void Main()
        {
            Employee e = new Employee();
            e.empno = 1;
            e.empName = "Basha";
            e.basis = 200;
            Console.WriteLine(e.empno);
            Console.WriteLine(e.empName);
            Console.WriteLine(e.basis);
        }
    }
}
