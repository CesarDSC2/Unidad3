using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args) //Se realizo una clase por cada cuerpo para una mejor estructura
        {
            int opc;
            do //Ciclo do-while para repetir el proceso
            {
                Console.Clear();
                Console.WriteLine("~ BlackJack ~");
                Console.WriteLine("Iniciando con carta:");
                Game obj = new Game(); //Creamos un objeto de la clase Game
                obj.Play(); //Llamamos al método Play a través del objeto obj
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("¿Quieres seguir jugando?\n1.-Si\n2.-No");
                Console.Write("Opción: ");
                opc = int.Parse(Console.ReadLine());
            } while (opc == 1);
        }
    }
}
