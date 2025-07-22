using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Voting
    {
        public void elligile(int age)
        {
            if(age>=18)
            {
                Console.WriteLine("elligible");
            }
            else
            {
                Console.WriteLine("Not elligible");
            }

        }
        static void Main()
        {
            int age;
            Console.WriteLine("Enter the age");
            age = Convert.ToInt32(Console.ReadLine());
            Voting v = new Voting();
            v.elligile(age);

        }
    }
}
