using System;
using System.Collections.Generic;
using Aula135ExercicioProposto.Enums;
using Aula135ExercicioProposto.Entities;

namespace Aula135ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> listOfShapes = new List<Shape>();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfShapes; i++)
            {
                Console.Write($"Shape #{i + 1}");
                Console.Write("Rectangle or circle? [r/c] ");
                string typeOfShape = Console.ReadLine();
                if (typeOfShape == "r")
                {
                    Console.Write("Color: [Black, Blue, Red] ");
                    rectangle.Color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Width: ");
                    rectangle.Width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    rectangle.Height = double.Parse(Console.ReadLine());
                    listOfShapes.Add(rectangle);
                }
                else if (typeOfShape == "c")
                {
                    Console.Write("Color: [Black, Blue, Red] ");
                    circle.Color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Radius: ");
                    circle.Radius = double.Parse(Console.ReadLine());
                    listOfShapes.Add(circle);
                }
                else
                {
                    Console.WriteLine("Error, type invalid! Shape not cadestred.");
                }
            }

            Console.WriteLine("\nSHAPE AREAS: \n");

            foreach (Shape listItem in listOfShapes)
            {
                Console.WriteLine(listItem.getArea() + " m².");
            }

        }
    }
}
