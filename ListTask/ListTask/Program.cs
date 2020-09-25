using System;
using System.Globalization;
using System.Collections.Generic;
namespace ListTask
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Func> list = new List<Func>();
            int id;
            Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <=n; i++)
            {
                Console.WriteLine("Emplyee #" + i + ":");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary:");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Func(id, name, salary));
                
            }

            Console.WriteLine("Enter the Employees id will have salary increase");
            double searchId = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Faz o filtro pegando o item filtrado
            Func emp = list.Find(value => value.Id == searchId);
            if(emp != null)
            {
                Console.Write("Enter the percentage ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);

            }

            else {
                Console.WriteLine("ID NO EXIST");
            }

            Console.WriteLine("Updated list of employees");

            foreach (Func obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
