using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Q_02
    {
        static void Main(string[] args)
        {
            for(int i = 1;i<=10;i++)
            {
                Console.Write("Enter No " + i + ": ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine("Even number");
                }
                else
                {
                    Console.WriteLine("Odd number");
                }
            }
            Console.ReadLine();
        }

    }
}
