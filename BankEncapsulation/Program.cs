using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much will you deposit today? (in dollars):");
            double userDeposit = double.Parse(Console.ReadLine());
            BankAccount userAccount = new BankAccount();
            userAccount.Deposit(userDeposit);
            Console.WriteLine($"Your account's balance is {userAccount.GetBalance()} dollars.");
        }
    }
}
