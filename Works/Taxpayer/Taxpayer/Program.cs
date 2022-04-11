using System;
using System.Collections.Generic;
using System.Globalization;
using Taxpayer.Entities;

namespace Taxpayer
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nameEmployee = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    TaxPayer emp = new Individual(nameEmployee, anualIncome, healthExpenditures);
                    list.Add(emp);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    TaxPayer emp = new Company(nameEmployee, anualIncome, numberEmployees);
                    list.Add(emp);
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double totalTaxes = 0.0;
            foreach (TaxPayer item in list)
            {
                Console.WriteLine("Name: " + item.Name + " $ " + item.TaxesPaid().ToString("f2", CultureInfo.InvariantCulture));
                totalTaxes += item.TaxesPaid();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
