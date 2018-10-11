using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
 * Contains
 * GetType
 * ToString
 * ToArray
 * GetEnumerator
*/

namespace E.C.Santos_Chavez_Cesar_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word = "";
            Stack pila = new Stack();
            pila.Push("Jesus");
            pila.Push("Erick");
            pila.Push("Cesar");
            pila.Push("Eduardo");
            Console.WriteLine("\tContains.");
            Console.Write("Verificar si un elemento está en la pila: ");
            string ver = Console.ReadLine();

            if (pila.Contains(ver)) //Contains: indica si un cierto elemento está en la pila.
            {
                Console.WriteLine("El elemento existe");
            }
            else
            {
                Console.WriteLine("El elemento no existe");
            }
            /*for (int i = 0; i < 4; i++)
                {
                    word = (string)pila.Pop();
                    Console.WriteLine(word);
                }*/
            Console.WriteLine("\n\tGetType");
            foreach (var item in pila)
            {
                Console.WriteLine("{0} es de tipo {1}", item, item.GetType());
            }

            Console.WriteLine("\n\tToString");
            Console.WriteLine(pila.ToString()); //ToString: devuelve el elemento actual convertido en un string.

            Console.WriteLine("\n\tToArray");
            object[] Array = pila.ToArray(); //ToArray.devuelve toda la pila convertida en un array.
            Console.WriteLine("El nuevo arreglo contiene:");

            foreach (var item in Array)
            {
                string sep = "- ";
                
                Console.WriteLine("{0}{1}", sep, item);
            }

            Console.WriteLine("\n\tGetEnumerator");
            IEnumerator next = pila.GetEnumerator(); //GetEnumerator: permite usar enumeradores para recorrer la pila.

            next.MoveNext();
            next.MoveNext();

            Console.WriteLine(next.Current);

            Console.ReadKey();
        }    
    }
}
