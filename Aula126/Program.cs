using System;
using Aula126.Entities;

namespace Aula126
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(0000, "Maria", 2000);
            BusinessAccount bacc = new BusinessAccount(1111, "Pedro", 0, 1500);

            //UPCASTING 

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(2222, "Carla", 0, 2000);
            Account acc3 = new SavingsAccount(3333, "Anna", 0, 0.01);


            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            //BusinessAccount acc5 = (BusinessAccount)acc3;  vai dar erro, pois o acc3 não é compatível com o acc5

            if (acc3 is BusinessAccount) {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; //outra maneira de fazer o casting ultilizande o "as"
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount) {
                SavingsAccount acc5 = (SavingsAccount) acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
