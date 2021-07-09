using System;
using Aula126.Entities;

namespace Aula126
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount ac1 = new BusinessAccount(1234, "João", 1500, 1600);
            ac1.Loan(400);
            Account ac2 = new Account(4231, "Maria", 2000);
            ac2.Deposit(500);
            ac2.WithDraw(1000);   

            Console.WriteLine(ac1.Balance);    
            Console.WriteLine(ac2.Balance);   
        }
    }
}
