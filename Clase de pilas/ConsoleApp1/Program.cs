using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilas lista = new Pilas();

            for (int i = 0; i < 5; i++)
            {
                lista.Push(i + 1);
            }

            /*Console.WriteLine(lista.Count);
            Console.ReadKey();
            Console.WriteLine(lista.Peek());
            Console.ReadKey();
            Console.WriteLine(lista.Pop());
            Console.WriteLine(lista.Peek());
            */
            Console.ReadKey();
            string character;
            string palabra = "sees";
            bool isPalindrome = true;

            for (int i = 0; i < palabra.Length; i++)
            {
                //Extrae los elementos del string de acuerdo al indice y a la cantidad de elementos y los agrega a la pila
                lista.Push(palabra.Substring(i, 1));
                int posicion = 0;
                while (lista.Count > 0)
                {
                    character = lista.Pop().ToString();
                }
            }
        }
    }
}
