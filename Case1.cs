using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Case1
    {
        public void Show(string DayName)
        {
            switch(DayName.ToUpper())
            {
                case "SUN":
                    Console.WriteLine("It is sunday");
                    break;
                case "MON":
                    Console.WriteLine("It is Monday");
                    break;

                case "TUE":
                    Console.WriteLine("It is Tuesday");
                    break;

                case "WED":
                    Console.WriteLine("It is Wednesday");
                    break;

                case "THR":
                    Console.WriteLine("It is Thrsday");
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;

            }
        }
        static void Main()
        {
            string DayName;
            Console.WriteLine("Enter the 3 character of Day Name");
            DayName = Console.ReadLine();
            Case1 c = new Case1();
            c.Show(DayName);


           
        }
    }
}
