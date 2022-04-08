using System;
using System.Collections.Generic;
using System.Globalization;
using Polimorfism.Entities;

namespace Polimorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(System.Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string employeeName = Console.ReadLine();
                Console.Write("Hours: ");
                int emplyeeHour = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (op == 'y' || op == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourceEmployee(employeeName, emplyeeHour, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(employeeName, emplyeeHour, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
