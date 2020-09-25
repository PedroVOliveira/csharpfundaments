using System;

namespace Switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Teste");
                    break;
                case 2:
                    Console.WriteLine("Teste case 2");
                    break;
                default:
                    Console.WriteLine("DEFAULT VALUE");
                    break;
                    
            }
        }
    }
}
