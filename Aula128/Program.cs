using System;
using Aula128.Entities;

namespace Aula128
{
    class Program
    {
        static void Main(string[] args)
        {   
            Account acc = new Account (1111, "Anna", 500);
            Account acc1 = new SavingsAccount(2222, "Bruno", 500, 0.01);

            acc.Withdraw(10);
            acc1.Withdraw(10);

            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc1.Balance);
        }
    }
}
