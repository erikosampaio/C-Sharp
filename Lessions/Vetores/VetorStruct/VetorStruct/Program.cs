using System;
using System.Globalization;

namespace VetorStruct {
    internal class Program {
        static void Main(string[] args) {
            
            int n = int.Parse(Console.ReadLine());

            Product[] v = new Product[n];

            
            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());                
                v[i] = new Product { Name = name, Price = price };
            }

            double sum = 0;
            for (int i = 0; i < n; i++) {
                sum += v[i].Price;
            }

            double average = sum / v.Length;

            Console.WriteLine("Average Price = " + average.ToString("f2", CultureInfo.InvariantCulture));  
        }
    }
}
