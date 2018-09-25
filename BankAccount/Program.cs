using System;

namespace BankSystem
{
    public class Program
    {
        public static void Main()
        {
            BankAccount bankAccount = new BankAccount("Carlos Rojas", 10.50);
            
            bankAccount.FreezeAccount();

            bankAccount.Credit(5.77);
            bankAccount.Debit(11.22);

            Console.WriteLine("Current balance is ${0}", bankAccount.CurrentBalance);

            Console.ReadKey();
        }

    }
}