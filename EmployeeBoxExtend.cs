using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class EmployeeBoxExtend
    {
        public void Show(object obj)
        {
            string type = obj.GetType().Name;
            Console.WriteLine(type);
            if(type.Equals("EmployeeBox"))
            {
                EmployeeBox e = (EmployeeBox)obj;
                Console.WriteLine(e.id+" "+e.name+" "+e.basics);
            }
            
        }
        static void Main()
        {
            EmployeeBox e = new EmployeeBox();
            e.id = 1;
            e.name = "Vasim";
            e.basics = 200;
            EmployeeBoxExtend e1 = new EmployeeBoxExtend();
            e1.Show(e);
            
        }
    }
}
