using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[3, 3];
            //Metodos de matrizes
            // ler as colunas
            Console.WriteLine(mat.Rank);
            // ler a linhas
            Console.WriteLine(mat.Length);
            // ler colunas
            Console.WriteLine(mat.GetLength(0));
            //Ler as linhas
            Console.WriteLine(mat.GetLength(1));

        }
    }
}
