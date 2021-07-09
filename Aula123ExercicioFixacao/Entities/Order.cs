using System;
using System.Collections.Generic;
using System.Text;
using Aula123ExercicioFixacao.Entities.Enums;

namespace Aula123ExercicioFixacao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            double subTotal = 0;
            double somaSubTotal = 0;

            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:MM:ss"));
            sb.Append("Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.BirthDate.ToString("(dd/MM/yyyy) - "));
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items: ");

            foreach (OrderItem item in Items)
            {
                sb.Append(item.Product.Name);
                sb.Append(", ");
                sb.Append(item.Price);
                sb.Append(", Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", Subtotal: ");
                subTotal = item.SubTotal(item.Quantity, item.Price);
                somaSubTotal += subTotal;
                sb.AppendLine(subTotal.ToString());
            }
            sb.Append("Total: ");
            sb.Append(somaSubTotal);

            return sb.ToString();
        }
    }
}