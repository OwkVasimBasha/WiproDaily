using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Case2
    {
        public void Check(char choice)
        {
            switch (choice)
            {
                case 'a':
                case 'A':
                case '1':
                    Console.WriteLine("Hi I am Vasim");
                    break;
                case 'b':
                case 'B':
                case '2':
                    Console.WriteLine("Hi I am Basha...");
                    break;
                case 'c':
                case 'C':
                case '3':
                    Console.WriteLine("Hi I am owk...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        static void Main()
        {
            char choice;
            Console.WriteLine("Enter Your Choice  ");
            choice = Convert.ToChar(Console.ReadLine());
            Case2 obj = new Case2();
            obj.Check(choice);
        }
    }
}
