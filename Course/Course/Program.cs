using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities.Enums;
using Course.Entities;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            string nameWorker;
            WorkerLevel levelWorker;
            double baseSalaryWorker;

            Console.Write("Enter Department’s name: ");
            string departmentName = Console.ReadLine();

            Console.Write("\nName: ");
            nameWorker = Console.ReadLine();

            Console.Write("Level [Junior/MidLevel/Senior]: ");
            levelWorker = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            baseSalaryWorker = double.Parse(Console.ReadLine());

            Department department = new Department(departmentName);

            Worker worker = new Worker(nameWorker, levelWorker, baseSalaryWorker, department);

            Console.Write("\nHow many contracts to this worker? ");
            int quantContract = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantContract; i++)
            {
                Console.WriteLine($"\nContract #{i+1}");
                
                Console.Write("\nDate[DD/MM/YYYY]: ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value Per Hour: R$");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.Write("\nEnter the month and year for calculate income this period (MM/YYYY): ");
            string dateIncome = Console.ReadLine();
            string[] vetorDateIncome = dateIncome.Split("/");
            double income = worker.Income(int.Parse(vetorDateIncome[0]), int.Parse(vetorDateIncome[1]));
            

            System.Console.WriteLine($"\nName: {worker.Name} \nDepartment: {worker.Department.NameDepartment} \nIncome for {dateIncome}: R${income.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
