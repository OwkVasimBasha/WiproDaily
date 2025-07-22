using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///<summary>
///Program to convert celusis into Fahrenhit
/// </summary>
namespace Helloworld
{
    internal class CtoF
    {
      
        public double ConvertToFaherenhit(double celusis)
        {
            double f = ((9*celusis)/5)+32;
            return f;
        }

        


        
        static void Main()
        {
            double celsius;
            Console.WriteLine("Enter the celsius value");
            celsius = Convert.ToDouble(Console.ReadLine());
            CtoF c = new CtoF();
            Console.WriteLine("Farhenheit value is"+c.ConvertToFaherenhit(celsius));
           
        }

    }
}