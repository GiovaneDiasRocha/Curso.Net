using System;
using Aula123ExercicioFixacao.Entities;
using Aula123ExercicioFixacao.Entities.Enums;

namespace Aula123ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            Console.Write("Enter client data");
            Console.Write("Name: ");
            order.Client.Name = Console.ReadLine();
            Console.Write("Email: ");
            order.Client.Email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            order.Client.BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data");
            Console.Write("Status: ");
            order.Status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int numberItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberItems; i++)
            {   
                Console.WriteLine($"Enter #{i+1} data");
                Console.Write("Product name: ");
                order.OrderItem.Product.Name = Console.ReadLine();
                Console.Write("Product price: ");
                order.OrderItem.Product.Price = double.Parse(Console.ReadLine());
                Console.Write("Product quantity: ");
                order.OrderItem.Quantity = int.Parse(Console.ReadLine());

                order.AddItem(order.OrderItem);

                Console.WriteLine("Order Summary");
            }
        }
    }
}
