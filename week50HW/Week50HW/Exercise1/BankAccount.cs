using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPADV.Exercise1
{
    public class BankAccount
    {
        private int accountNumber;
        private string accountHolder;
        private decimal balance;
        private List<Transaction> transactions;

        public BankAccount(int accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            this.balance = balance;
            this.transactions = new List<Transaction>();
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            Transaction depositTransaction = new Transaction(DateTime.Now, "deposit", amount);
            transactions.Add(depositTransaction);
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Transaction withdrawTransaction = new Transaction(DateTime.Now, "withdraw", amount);
                transactions.Add(withdrawTransaction);
            }
            else
            {
                throw new Exception("Not enough credits");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public List<Transaction> GetTransactionHistory()
        {
            List<Transaction> sortTransaction = new List<Transaction>(transactions);
            sortTransaction.Sort(CompareTransactions);
            return sortTransaction;
        }


        private int CompareTransactions(Transaction t1, Transaction t2)
        {
            return DateTime.Compare(t1.Timestamp, t2.Timestamp);
        }



    }

    public class Transaction
    {
        public DateTime Timestamp { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }

        public Transaction(DateTime timestamp, string type, decimal amount)
        {
            Timestamp = timestamp;
            Type = type;
            Amount = amount;
        }
    }
}
