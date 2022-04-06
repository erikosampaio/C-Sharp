using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using OrderCompositionAndEnumerates.Entities.Enums;
using OrderCompositionAndEnumerates.Entities;

namespace OrderCompositionAndEnumerates.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();


        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total(OrderItem items)
        {
            double soma = items.SubTotal();
            foreach (OrderItem item in Items)
            {
                soma += item.SubTotal();
            }
            return soma;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (" + Client.BirthDate.ToString("dd/MM/yyyy") + ")");
            sb.AppendLine(" - " + Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.Append(item.Product.Name);
                sb.Append(", $" + item.Price.ToString("f2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: " + item.Quantity);
                sb.AppendLine(", Subtotal: $" + item.Price.ToString("f2", CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }
    }
}
