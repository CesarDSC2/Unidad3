using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_3.Santos_Chavez_Cesar_Daniel
{
    class Menu
    {
        public void Iniciar()
        {
        x:
            Console.Clear();
            int opc;
            Console.WriteLine("¿Que ejercicio deseas ejecutar? \n1.-Ejercicio 1. \n2.-Ejercicio 2. \n3.-Ejercicio 3. \n4.-Ejercicio 4.");
            Console.Write("Opción: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Operacion obj1 = new Operacion();
                    obj1.Ejercicio1();
                    break;
                case 2:
                    Operacion obj2 = new Operacion();
                    obj2.Ejercicio2();
                    break;
                case 3:
                    Operacion obj3 = new Operacion();
                    obj3.Ejercicio3();
                    break;
                case 4:
                    Operacion obj4 = new Operacion();
                    obj4.Ejercicio4();
                    break;
                default:
                    Console.WriteLine("Ingrese una opción válida.");
                    break;

            }
            Console.ReadKey();
            goto x;
        }
    }
}
