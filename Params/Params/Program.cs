using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vect = new string[] { "Maria","Fabiana","Teste"};
            //Foreach
            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
