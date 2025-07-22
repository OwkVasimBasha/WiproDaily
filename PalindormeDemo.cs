using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class PalindormeDemo
    {
        public bool show(string str)
        {
            char[] c = str.ToCharArray();
            string rev = "";
            for (int i=c.Length-1;i>=0;i--)
            {
                rev += c[i];
            }
            Console.WriteLine(rev);
            if(rev.Equals(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            string str = "madam";
            PalindormeDemo demo = new PalindormeDemo();
            Console.WriteLine(demo.show(str));


        }
    }
}
