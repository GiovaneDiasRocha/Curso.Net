using System;
using Aula131e132.Entities;

namespace Aula131e132
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityEmployees;

            Employee employee = new Employee();
            OutsourcedEmployee outsourced = new OutsourcedEmployee();

            Console.Write("Enter the number of employees: ");
            quantityEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantityEmployees; i++)
            {
                Console.Write("Outsourced? [S/N] ");
                string option = Console.ReadLine();
                if (option == "n")
                {
                    Console.Write("Name: ");
                    employee.Name = Console.ReadLine();
                    Console.Write("Hours: ");
                    employee.Hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hours: ");
                    employee.ValuePerHour = double.Parse(Console.ReadLine());

                    employee.addEmployeeInList(employee);
                }
                else if (option == "s")
                {
                    Console.Write("Name: ");
                    outsourced.Name = Console.ReadLine();
                    Console.Write("Hours: ");
                    outsourced.Hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hours: ");
                    outsourced.ValuePerHour = double.Parse(Console.ReadLine());
                    Console.Write("Additional charge: ");
                    outsourced.AdditionalCharge = double.Parse(Console.ReadLine());

                    employee.addEmployeeInList(outsourced);
                }
                else
                {
                    System.Console.WriteLine("Option invalid, employee not cadastred.");
                }
            }
            Console.WriteLine("\nPAYMENTS");
            Console.WriteLine(employee);

        }
    }
}
