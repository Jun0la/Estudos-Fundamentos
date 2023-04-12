using System;
using Course.Entities;

namespace Course
{
    class Program
    {
    static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Annie", 155.0, 0.01);
            Account acc3 = new BusinessAccount(1003, "Manager", 500.0, 0.01);

            acc1.Withdraw(25.0);
            acc2.Withdraw(15.0);
            acc3.Deposit(500.00);
            acc3.Withdraw(155.00);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc3.Balance);
        }
    }
}