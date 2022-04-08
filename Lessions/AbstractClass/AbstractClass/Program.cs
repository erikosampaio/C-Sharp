using System;
using System.Globalization;
using System.Collections.Generic;
using AbstractClass.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();
            
            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 400));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("f2", CultureInfo.InvariantCulture));

            foreach (Account item in list)
            {
                item.Withdraw(10.0);
            }

            foreach (Account item in list)
            {
                Console.WriteLine("Update balance for account "
                + item.Number
                + ": "
                + item.Balance.ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}