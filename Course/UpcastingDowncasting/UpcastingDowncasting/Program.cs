using System;
using System.Security.Principal;
using UpcastingDowncasting.Entities;

namespace UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // account = new BusinessAccount(8010,"Bob Brown",100.0,500.0);

            // Console.WriteLine(account.Balance);
            // account.Balance = 200.0;

            // Account account = new Account(1001, "Alex", 0.0);
            // BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // Upcasting

            // Account acc1 = bacc;
            // Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            // Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);


            // Dowcasting, operacao insegura

            // BusinessAccount acc4 = (BusinessAccount)acc2;
            // acc4.Loan(100.0);


            // BusinessAccount acc5 = (BusinessAccount)acc3; // incompativeis 

            /* if (acc3 is BusinessAccount)
             {

                 //BusinessAccount acc5 = (BusinessAccount)acc3;
                 BusinessAccount acc5 = acc3 as BusinessAccount;
                 acc5.Loan(200.0);
                 Console.WriteLine("Loan!");
             }

             if (acc3 is SavingsAccount)
             {
                 //SavingsAccount acc5 = (SavingsAccount)acc3;
                 SavingsAccount acc5 = acc3 as SavingsAccount;
                 acc5.UpdateBalance();
                 Console.WriteLine("Update");
             } */

            // Sobreposicao, palavras virtual override e base 03/11/23

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
