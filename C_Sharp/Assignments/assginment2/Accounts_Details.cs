using System;

namespace Assginment2

{
    class Accounts_Details
    {
        private string accountNumber;
        private string customerName;
        private string accountType;
        private char transactionType;
        private decimal amount;
        private decimal balance;

        public Accounts_Details(string customerName, string accountNumber, string accountType, char transactionType, decimal amount, decimal balance)
        {
            this.customerName = customerName;
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = amount;
            this.balance = balance;
        }

        public static Accounts_Details CreateAccount()
        {
            Console.WriteLine("---Welcome to XYZ Bank---");

            Console.WriteLine("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter Customer Account No: ");
            string accountNumber = Console.ReadLine();

            Console.WriteLine("Enter Account Type (Current/Saving A/c): ");
            string accountType = Console.ReadLine();

            Console.WriteLine("Transaction type for Deposit (D), Withdrawal (W): ");
            char transactionType = Convert.ToChar(Console.ReadLine().ToUpper());

            decimal amount = 0;
            if (transactionType == 'D')
            {
                Console.WriteLine("Enter the amount to Deposit: ");
                amount = Convert.ToDecimal(Console.ReadLine());
            }
            else if (transactionType == 'W')
            {
                Console.WriteLine("Enter the amount to Withdraw: ");
                amount = Convert.ToDecimal(Console.ReadLine());
            }

            Console.WriteLine("Enter the Balance of A/c: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());

            return new Accounts_Details(customerName, accountNumber, accountType, transactionType, amount, balance);
        }

        public void UpdateBalance()
        {
            if (transactionType == 'D')
                balance += amount;
            else if (transactionType == 'W')
                balance -= amount;
        }

        public void ShowAccountDetails()
        {
            Console.WriteLine("---Account Details---");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Transaction Type: {transactionType}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Balance: {balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accounts_Details account = Accounts_Details.CreateAccount();
            account.UpdateBalance();
            Console.WriteLine("------------Details After Transaction------------");
            account.ShowAccountDetails();
            Console.Read();
        }
    }
}