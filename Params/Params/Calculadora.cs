using System;
using System.Collections.Generic;
using System.Text;

namespace Params
{
    class Calculadora
    {
        //Seta a quantidade de elementos dentro da função
        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            for(int i = 0; i< numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }

    // Ref and out not use

    


}
