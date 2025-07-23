using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class OOPSOverloadDEmo
    {
        public void show(int x)
        {
            Console.WriteLine("Show Method w.r.t int "+x);
        }
        public void show(double x)
        {
            Console.WriteLine("Show Method w.r.t Double"+x);
        }
        public void show(string x)
        {
            Console.WriteLine("Show Method w.r.t string" +x);
        }
        static void Main()
        {
            OOPSOverloadDEmo o = new OOPSOverloadDEmo();
            o.show(10);
            o.show(10.20);
            o.show("Vasim");
        }
            
    }
}
