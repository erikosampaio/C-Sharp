using System;
using Heritage.Entities;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Eriko", 100, 500);

            Console.WriteLine(account.Balance);
            // account.Balance = 200; --> Não é possível devido o properties está com o set com a proteção "protected".
        }
    }
}
