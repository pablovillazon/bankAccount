using System;

namespace BankSystem
{
    public class BankAccount
    {
        private string customerName;

        private double currentBalance;

        private bool isFrozen = false;

        public BankAccount(string customerName, double currentBalance)
        {
            this.customerName = customerName;
            this.currentBalance = currentBalance;
        }

        public string CustomerName
        {
            get { return customerName; }
        }

        public double CurrentBalance
        {
            get { return currentBalance; }
        }

        public void Debit(double amount)
        {
            if (isFrozen)
            {
                Console.WriteLine("Cannot debit. Account is frozen");
                return;
            }

            if (amount > currentBalance)
            {
                Console.WriteLine("Insuficient available amount, your current balance is: " + currentBalance);
                return;
            }

            if (amount < 0)
            {
                Console.WriteLine("Invalid credit amount");
                return;
            }

            currentBalance += amount;  
        }

        public void Credit(double amount)
        {
            if (isFrozen)
            {
                Console.WriteLine("Cannot Credit. Account is frozen");
                return;
            }

            if (amount < 0)
            {
                Console.WriteLine("Invalid credit amount");
                return;
            }

            currentBalance -= amount;
        }

        public void FreezeAccount()
        {
            isFrozen = true;
        }

        public void UnfreezeAccount()
        {
            isFrozen = false;
        }
    }
}