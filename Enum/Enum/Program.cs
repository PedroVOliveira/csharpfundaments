using TypeEnum.Entities;
using TypeEnum.Entities.Enums;
using System;

namespace TypeEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { Id = 1000, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };
            Console.WriteLine(order);
            // Convertendo o valor para string
            string txt = OrderStatus.PendingPayment.ToString();
            //Passando para um tipo inteiro
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}
