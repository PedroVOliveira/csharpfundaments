using System;

namespace MatrizTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da matriz");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            
            for(int i = 0; i < n; i++)
            {
                
                string[] vet = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++)
                {
                    matriz[i,j] = int.Parse(vet[j]);
                }
            }

            Console.Write("Digite um numero que pertence a matriz");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i < n; i++)
                {
                    Console.Write("Teste");
                }
            }
        }
    }
}
