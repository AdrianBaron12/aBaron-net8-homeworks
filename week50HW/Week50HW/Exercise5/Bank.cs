using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OOPADV.Exercise5
{
    public class Bank
    {
        public static double InterestRate { get; set; } = 0.01;
        public static int NumAccounts { get; set; } = 0;

        public static double CalculateInterest(double balance)
        {
            return balance * InterestRate;
        }

        public static int GetNumAccounts()
        {
            return NumAccounts;
        }
    }

    public class BankAccount
    {
        private string accountNumber;
        private string accountHolder;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
            Bank.NumAccounts++;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("You have no more credits");
            }
        }

        public double GetInterest()
        {
            return balance * Bank.InterestRate;
        }

    }
}
