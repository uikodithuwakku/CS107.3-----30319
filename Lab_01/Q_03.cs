using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Q_03
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            int no = Convert.ToInt32(Console.ReadLine());

            if (no > 0)
            {
                int sum = 0;
                for (int i = 1; i <= no; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine("Sum is " + sum);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }


        }
    }
}
