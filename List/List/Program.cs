using System;
using System.Collections.Generic;
namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("joao");
            list.Add("pedro");
            list.Add("teste1");
            list.Add("teste5");
        
            //Pega o primeiro de acordo com a condicao
            string s1 = list.Find(value => value[0] == 'M');
            Console.WriteLine("First name : " + s1);
            string s2 = list.FindLast(value => value[0] == 't');
            Console.WriteLine("Last name : " + s2);

            int pos1 = list.FindIndex(value => value[0] == 't');
            Console.WriteLine("Last name : " + pos1);
            List<string> list2 = list.FindAll(value => value.Length > 4);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj); 
            }

            list.Remove("Maria");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
