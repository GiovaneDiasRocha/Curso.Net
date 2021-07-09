using System;
using System.Collections.Generic;

namespace Aula123ExercicioFixacao.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal(int quantity, double price)
        {
            return quantity * price;
        }
    }
}