using System;

namespace TimeSpan2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trabalhando com unidade de tempo
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            TimeSpan t2 = new TimeSpan(9000000L);
            Console.WriteLine(t1);
            TimeSpan t3 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t3);
            TimeSpan t4 =  new TimeSpan(1, 2, 3, 4, 543);

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 =  TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1);
            TimeSpan t10 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
        }
    }
}
