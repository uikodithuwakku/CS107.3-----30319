using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number to get fibonacci :");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("first " + number + " terms of the fibonacci serious : ");
            for (int i = 0; i < number; i++)
            {
                int result = Fibonacci(i);
                Console.WriteLine(result);
            }
            Console.ReadLine();

        }

        static int Fibonacci(int N)
        {
                if (N <= 1)
                {
                    return N;
                }
                else
                {
                    return Fibonacci(N - 1) + Fibonacci(N - 2);
                }
            
        }
    }
}
