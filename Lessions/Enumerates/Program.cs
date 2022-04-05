using System;
using Enumerates.Entities;
using Enumerates.Entities.Enums;

namespace Enumerates
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os;
            Enum.TryParse<OrderStatus>("Delivered", true, out os);

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
