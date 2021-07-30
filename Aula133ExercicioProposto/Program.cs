using System;
using Aula133ExercicioProposto.Entities;

namespace Aula133ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product();
            UsedProduct used = new UsedProduct();
            ImportedProduct importedProduct = new ImportedProduct();

            Console.Write("Enter the number of products: ");
            int quantityOfProducts = int.Parse(Console.ReadLine());


            for (int i = 0; i < quantityOfProducts; i++)
            {
                Console.Write("Common, Used or Imported [c/u/i]? ");
                string TypeProduct = Console.ReadLine();

                switch (TypeProduct)
                {
                    case "c":
                        Console.Write("Name: ");
                        product.Name = Console.ReadLine();
                        Console.Write("Price: ");
                        product.Price = double.Parse(Console.ReadLine());
                        product.AddProductInList(product);
                        break;

                    case "u":
                        Console.Write("Name: ");
                        used.Name = Console.ReadLine();
                        Console.Write("Price: ");
                        used.Price = double.Parse(Console.ReadLine());
                        Console.Write("Manufacture Date: [DD/MM/YYYY] ");
                        used.ManufactureDate = DateTime.Parse(Console.ReadLine());
                        product.AddProductInList(used);
                        break;

                    case "i":
                        Console.Write("Name: ");
                        importedProduct.Name = Console.ReadLine();
                        Console.Write("Price: ");
                        importedProduct.Price = double.Parse(Console.ReadLine());
                        Console.Write("Custums Fee: $ ");
                        importedProduct.CustomsFee = double.Parse(Console.ReadLine());
                        product.AddProductInList(importedProduct);
                        break;

                    default:
                        Console.WriteLine("Type invalid, product not cadastred!");
                        break;
                }
            }
            Console.WriteLine("\nPRODUCTS\n");
            Console.WriteLine(product);
        }
    }
}
