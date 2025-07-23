using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class TwoDimensionalUsingCustom
    {
        static void Main()
        {
            int m, n;
            Console.WriteLine("Enter Rows and Columns");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] x = new int[m, n];
            Console.WriteLine("Enter the array elements",m*n);
            for(int i=0;i<x.GetLength(0);i++)
            {
                for(int j=0;j<x.GetLength(n-1);j++)
                {
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Display Elements in matrix format");
            for(int i=0;i<x.GetLength(0);i++)
            {
                for(int j=0;j<x.GetLength(1);j++)
                {
                    Console.WriteLine(x[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
