using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListEmployee {
    class Program {
        static void Main(string[] args) {


            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                // Employee emp = list.Find(x => x.Id == verificaId); --> Está pegando a posição do Id na lista.
                Employee validatesId = list.Find(x => x.Id == id);
                while (validatesId != null) {
                    Console.Write("Id already registered. Choose another: ");
                    id = int.Parse(Console.ReadLine());
                    validatesId = list.Find(x => x.Id == id);
                }
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                Console.WriteLine();

                list.Add(new Employee(id, name, salary));
            }            

            Console.Write("Enter the employee id that will have salary increase: ");
            int checkId = int.Parse(Console.ReadLine());

            Employee check = list.Find(x => x.Id == checkId);
            if (check != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                check.increaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees:");
            foreach (Employee employee in list) {
                Console.WriteLine(employee);
            }            
        }
    }
}
