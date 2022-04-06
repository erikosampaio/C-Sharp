using OrderCompositionAndEnumerates.Entities;
using OrderCompositionAndEnumerates.Entities.Enums;
using System;
using System.Globalization;

namespace OrderCompositionAndEnumerates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime BirthDate = DateTime.Parse(Console.ReadLine());            
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status;
            Enum.TryParse(Console.ReadLine(), out status);

            Client c1 = new Client(name, email, BirthDate);
            Order order1 = new Order(DateTime.Now, status, c1);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nam = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product1 = new Product(nam, price);

                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());
                
                OrderItem orderItem1 = new OrderItem(qtd, price, product1);                

                order1.AddItem(orderItem1);
            }
            Console.WriteLine();
            Console.WriteLine(order1);
        }
    }
}
