using Microsoft.VisualBasic;
using System;

namespace propetiesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58,275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date " + d.Date);
            Console.WriteLine("2) Day: "+ d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) Day: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Mounth: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortDateString();
            string s6 = d.ToString("dd/MM/yyyy HH:mm:ss");
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s6);

            //Operators DateTime
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            //Diferença entre as duas datas
            TimeSpan t = d3.Subtract(d2);
            Console.WriteLine(t);

            //Time span é igual a dateTime nos metodos
            //
            DateTime date1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime date2 = new DateTime(2000, 8, 15, 13, 5, 58,DateTimeKind.Utc);
            DateTime date3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1:" + date1);
            Console.WriteLine("d1 King " + date1.Kind);
            Console.WriteLine("d1 Local " + date1.ToLocalTime());
            Console.WriteLine("D1 to Utc " + date1.ToUniversalTime());

            // O ideal é instanciar o no padrao uTC e chamar no padrao local

            DateTime date4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime date5 = DateTime.Parse("2000-08-15 13:05:58Z");

            Console.Write("Hello,World!");

        }
    }
}
