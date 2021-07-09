using System;
using Aula123ExercicioFixacao.Entities;
using Aula123ExercicioFixacao.Entities.Enums;

namespace Aula123ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            Console.Write("Email: ");
            string emailClient = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDateClient = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(nameClient, emailClient, birthDateClient);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int numberItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberItems; i++)
            {
                Console.WriteLine($"Enter #{i + 1} data");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                Console.Write("Product quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

                order.AddItem(orderItem);
            }
            Console.WriteLine("\nOrder Summary");
            Console.WriteLine(order);
        }
    }
}
