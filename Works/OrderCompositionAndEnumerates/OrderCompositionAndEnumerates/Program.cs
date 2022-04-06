using OrderCompositionAndEnumerates.Entities;
using OrderCompositionAndEnumerates.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace OrderCompositionAndEnumerates
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client c1 = new Client(name, email, date);            

            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status;
            Enum.TryParse(Console.ReadLine(), out status);
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nam = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());


                Product product1 = new Product(nam, price);
                OrderItem orderItem1 = new OrderItem(qtd, price);
                orderItem1.Product = product1;
                order1 = new Order(
                    DateTime.Now,
                    status,
                    c1
                    );
                order1.AddItem(orderItem1);
                totalPrice += orderItem1.SubTotal();
            }

            Console.WriteLine(order1);
            Console.WriteLine("Total price: $" + totalPrice.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
