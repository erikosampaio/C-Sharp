using System;
using CastingAndDowncasting.Entities;

namespace CastingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            Console.WriteLine(acc1 is Account);
            Console.WriteLine(acc1 is BusinessAccount);
            Console.WriteLine(acc1 is SavingsAccount);

            Console.WriteLine(acc3 is Account);
            Console.WriteLine(acc3 is SavingsAccount);
            Console.WriteLine(acc3 is BusinessAccount);


            //DOWNCASTING - Inseguro e somente se necessário!

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3; Erro por acc3 ser do tipo Account!
            if (acc3 is BusinessAccount) // Testa pra saber se acc3 é do tipo BusinessAccount.
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3; Abaixo outra forma de declararar.
                BusinessAccount acc5 = acc as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount) // Testa pra saber se acc3 é do tipo BusinessAccount.
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3; Abaixo outra forma de declararar.
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine(acc5 is Account);
                Console.WriteLine(acc5 is SavingsAccount);
                Console.WriteLine(acc5 is BusinessAccount);
                Console.WriteLine("Update!");
            }
        }
    }
}
