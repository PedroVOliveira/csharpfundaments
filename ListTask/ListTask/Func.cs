using System;
using System.Globalization;

namespace ListTask
{
    class Func
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static double Salary { get ; private set; }

        public Func(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public  void IncreaseSalary(double value)
        {
             Salary += Salary * value / 100.0;
            
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
