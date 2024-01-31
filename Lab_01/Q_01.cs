using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Q_01
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height :");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter width :");
            int width = Convert.ToInt32(Console.ReadLine());

            CalArea(width, height);
            Console.ReadLine();
        }

        static void CalArea(int height, int width)
        {
            int area = height * width;
            Console.WriteLine("Area is " + area);
        }
    }
}
