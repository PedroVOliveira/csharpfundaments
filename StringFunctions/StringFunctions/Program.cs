using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ IJ IJ";
            string s1 = original.ToUpper();
            //Retira os espaços em branco na string

            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("FG");
            int n2 = original.LastIndexOf("IJ");

            string s4 = original.Substring(2);
            string s5 = original.Substring(3, 5);
            //Ele troca o valor do primeiro parametro, pelo segundo;
            string s6 = original.Replace('J', 'x');
            //Verificando se o valor é nulo ou vazio
            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(n1);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
    }
}
