using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calificaciones de universitarios";
            int opc = 0;
            do
            {
                Console.Clear();
                int x;
                MostrarArrayList obj = new MostrarArrayList();

                Console.Write("¿Cuántas clases són en total?: ");
                x = Convert.ToInt32(Console.ReadLine());

                obj.CapturaDatos(x);
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("¿Desea volver a repetir?\n1.-Si\n2.-No");
                Console.Write("Opción: ");
                opc = Int32.Parse(Console.ReadLine());
            } while (opc < 2);
            
        }
    }
}
