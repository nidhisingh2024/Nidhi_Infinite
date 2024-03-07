using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTransfer
{
    using System;

    // Custom exception for insufficient balance during withdrawal
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    // Class representing a bank account
    public class BankAccount
    {
        private decimal balance;

        // Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            // No exception handling needed as this operation should not fail
            balance += amount;
            Console.WriteLine($"Deposited {amount} into the account.");
            Console.ReadLine();
        }

        // Method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            // Check if there's enough balance for withdrawal
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount} from the account.");
                Console.ReadLine();
            }
            else
            {
                // Throw custom exception if there's insufficient balance
                throw new InsufficientBalanceException("Insufficient balance to withdraw.");
            }
        }

        // Method to check the account balance
        public decimal GetBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            // Example transactions
            try
            {
                account.Deposit(1000);
                Console.WriteLine($"Current balance: {account.GetBalance()}");

                account.Withdraw(500);
                Console.WriteLine($"Current balance: {account.GetBalance()}");

                account.Withdraw(700); // This should throw InsufficientBalanceException
                Console.WriteLine($"Current balance: {account.GetBalance()}");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }

}
