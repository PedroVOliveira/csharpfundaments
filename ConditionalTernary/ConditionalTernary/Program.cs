using System;
using System.Globalization;
using System.Net;

namespace ConditionalTernary
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double descont = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(descont);
        }
    }
}
