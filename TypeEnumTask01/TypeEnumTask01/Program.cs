using System;
using System.Globalization;
using TypeEnumTask01.Entities;
using TypeEnumTask01.Entities.Enums;
namespace TypeEnumTask01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Departament name");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter Worker Data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Jr,Pleno,Sr)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many Contracts to this Worker?");
            int numberContracts = int.Parse(Console.ReadLine());

            for(int i = 0; i < numberContracts; i++)
            {
                Console.WriteLine($"Enter #{(i + 1)} contract data:");
                Console.Write("Date (DD/MM/YYYY/): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(contractDate, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.WriteLine("Enter month and Year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear} : {worker.Income(year,month)}");
        }
    }
}
