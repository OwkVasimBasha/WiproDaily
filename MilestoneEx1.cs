using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class MilestoneEx1
    {
        public void show(string data)
        {
            data = data.ToLower();
            int count = 0;
            char[] ch = data.ToCharArray();
            foreach(char ch1 in ch)
            {
                if(ch1=='a'|| ch1=='e'|| ch1=='i'|| ch1=='o'||ch1=='u')
                {
                    count++;
                }
            }
            Console.WriteLine("The vowels are"+count);
        }
        static void Main()
        {
            string data;
            Console.WriteLine("Enter the Data");
            data = Console.ReadLine();
            MilestoneEx1 m = new MilestoneEx1();
            m.show(data);

        }
    }
}
