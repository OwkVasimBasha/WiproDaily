using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class TwoDimensionalDemo
    {
        static void Main()
        {
            int[,] data = new int[2, 3]
            {
                {1,2,3 },
                {4,5,6 }
            };
            for(int i=0;i<data.GetLength(0);i++)
            {
                for(int j=0;j<data.GetLength(1);j++)
                {
                    Console.WriteLine("x{0}{1} {2}",i,j, data[i,j]);
                }
            }
        }
    }
}
