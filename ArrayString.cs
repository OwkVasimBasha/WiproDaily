using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    
    internal class ArrayString
    {
        public void show()
        {
            string[] names = new string[]
            {
            "Vasim", "Basha", "Owk",

            };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        static void Main()
        {
            ArrayString a = new ArrayString();
            a.show();

            
        }
    }
}
