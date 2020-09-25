using System;
using System.Globalization;

namespace DateTime2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo Valor (Struct)
            //Guardar Valores
            //Apenas a data
            DateTime d1 = new DateTime(2018,11,25);
            //Data e a hora setada
            
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            //Pega a hora atual do computador
            DateTime d4 = DateTime.Now;
            //Pega o dia atual
            DateTime d5 = DateTime.Today;
            //pega o dia de acordo com o horario global
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d7);
            DateTime d8 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
            Console.WriteLine(d8);
        }
    }
}
