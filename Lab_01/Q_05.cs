using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Q_05
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int no = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                int y = no * i;
                Console.WriteLine(+no + "*" + i + "=" + y);

            }
            Console.ReadLine();
        }
    }
    
}


