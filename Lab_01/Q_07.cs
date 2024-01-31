using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    class Q_07
    {
        static void Main(string[] args)
        {
            int amount = 5000;
            

            while (true)
            {
                Console.WriteLine("1. Current Balance");
                Console.WriteLine("2. Witdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Cancel");
                Console.Write("Enter your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine()); 

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your current balance is " + amount);
                        break;

                    case 2:
                        Console.Write("Enter withdraw amount :");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw > amount)
                        {
                            Console.WriteLine("Sorry insufficient balance ");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.Write("Your balance is " + amount);
                        }
                        break;

                    case 3:
                        Console.Write("Enter deposit amount : ");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        amount = deposit + amount;
                        Console.WriteLine("Your balance is " + amount);
                        break;

                    case 4:
                        Console.WriteLine("Thank you .....");
                        break;

                   
                }
                Console.ReadLine();
            }
        }
    }
}
