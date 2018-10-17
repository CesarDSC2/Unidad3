using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//Haga una comparación de los métodos que tiene pila y cola (Stack & Queue)
//y ponga las que son diferentes en Queue y su funcionamiento.

namespace E3_2.Santos_Chavez_Cesar_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~ Stack ~");
            Stack pila = new Stack();
            pila.Push("Cesar"); //En Stack se usa el "Push" para introducir elementos.
            pila.Push("Daniel");
            pila.Push("Santos");

            //Stack y Queue también contienen los métodos Peek, Count, GetType, ToString, ToArray, etc.
            Console.WriteLine("Principio de la Stack: {0}", pila.Peek());
            Console.WriteLine("Total de elementos: {0}", pila.Count);
            Console.WriteLine("Elementos:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, pila.Pop()); //Pop muestra y remueve el último elemento introducido.
            }

            Console.WriteLine("\n~ Queue ~");
            Queue cola = new Queue();
            cola.Enqueue("Cesar"); //En Queue se usa el "Enqueue" para introducir elementos.
            cola.Enqueue("Daniel");
            cola.Enqueue("Santos");

            Console.WriteLine("Principio de la Queue: {0}", cola.Peek());
            Console.WriteLine("Total de elementos: {0}", cola.Count);
            Console.WriteLine("Elementos:");
            for (int i = 0; i < 3; i++) //FIFO: El primero en entrar, es el primero en salir.

            {
                Console.WriteLine("{0}: {1}", i + 1, cola.Dequeue()); //Dequeue muestra y remueve primer elemento introducido.
            }

            //Un método que diferencia a Queue del Stack es el "TrimToSize"
            cola.TrimToSize(); //Este método se usa para minimizar la carga de memoria en la Cola si no se agregaran nuevos elementos en la cola.

            Console.ReadKey();

        }
    }
}
