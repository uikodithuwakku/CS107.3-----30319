using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    public class BankAccount
    {
        public int AccountNumber;
        public double balance;

        public BankAccount(double AccBalance)
        {
            balance = AccBalance;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
    }

    internal class Program
    {
        static void Main()
        {
            BankAccount myAccount = new BankAccount(500);

            Console.Write("Account Number :");
            myAccount.AccountNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Deposit Amount :");
            double amount = Convert.ToInt32(Console.ReadLine());

            myAccount.Deposit(amount);

            Console.WriteLine("Account Number : " + myAccount.AccountNumber);
            Console.WriteLine("Updated Balance : " + myAccount.balance);
            Console.Read();
        }
    }   
}
