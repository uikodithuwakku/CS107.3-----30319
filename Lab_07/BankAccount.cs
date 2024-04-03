using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{

    public abstract class BankAccount
    {
        public abstract void deposit(double amount);
        public abstract void withdraw(double amount);

        public double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void displayBalance()
        {
            Console.WriteLine($"Current balance : {balance}");
        }

    }

    public class SavingAccount : BankAccount
    {
        public SavingAccount(double initialBalance) : base(initialBalance) { }
        public override void deposit(double amount)
        {
            balance += amount;
        }
        public override void withdraw(double amount)
        {
            if(balance - amount >= 0)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance.....");
            }
        }
    }

    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(double initialBalance) : base(initialBalance) { }
        public override void deposit(double amount)
        {
            balance += amount;
        }
        public override void withdraw(double amount)
        {
            balance -= amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sa = new SavingAccount(1000);
            CurrentAccount ca = new CurrentAccount(2000);

            Console.WriteLine("Choose the Account type :");
            Console.WriteLine("1. Saving Account \t\t 2.Current Account");
            int AccType = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose the Transaction type :");
            Console.WriteLine("1. Deposit \t\t 2.Withdraw");
            int TransactionType = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Amount :");
            double amount = double.Parse(Console.ReadLine());   

            if(AccType == 1)
            {
                if(TransactionType == 1)
                {
                    sa.deposit(amount);
                }
                else
                {
                    sa.withdraw(amount);
                }
                sa.displayBalance();
            }
            else if (AccType == 2) 
            {
                if (TransactionType == 1)
                {
                    ca.deposit(amount);
                }
                else
                {
                    ca.withdraw(amount);
                }
                ca.displayBalance();
            }
            else
            {
                Console.WriteLine("Choose account type or transaction type");
            }
            
            
            Console.ReadLine();
        }
    }
}
