using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Manfred", 100000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawl(420, DateTime.Now, "Console");
            account.MakeWithdrawl(1000, DateTime.Now, "For Me");

            Console.WriteLine(account.GetAccountHistory());

            // Test for a negative balance
            //try
            //{
            //    var invalidAccount = new BankAccount("For Prince Manfred", -1000);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating wwith negative balance");
            //    Console.WriteLine(e.ToString());
            //}
        }
    }
}