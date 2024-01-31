using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Q_06
    {

        static void Main(string[] args)
        {
            Console.Write("Enter Name :");
            string name = Console.ReadLine();

            Console.Write("Enter Marks : ");
            int mark = Convert.ToInt32(Console.ReadLine());

            if(mark> 100)
            {
                Console.WriteLine("You can't enter values above 100");
            }
            else if(mark>= 75)
            {
                Console.WriteLine("" +name+ "  Grade A");
            }
            else if(mark>=60)
            {
                Console.WriteLine("" + name + "  Grade B");
            }
            else if(mark>=50)
            {
                Console.WriteLine("" + name + "  Grade C");
            }
            else if(mark >= 40)
            {
                Console.WriteLine("" + name + "  Grade D");
            }
            else if(mark<40) 
            {
                Console.WriteLine("" + name + "  Failed");
            }
            else
            {
                Console.WriteLine("Yu can't enter values below 0");
            }
            Console.ReadLine();
        }


    }
}
