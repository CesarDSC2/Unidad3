using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MostrarArrayList
{
    public class MostrarArrayList
    {
        ArrayList alumno = new ArrayList();
        ArrayList clase = new ArrayList();
        ArrayList calificacion = new ArrayList();

        public void CapturaDatos(int x)
        {
            int cont = 0;
            int calif = 0;
            int clases;
            for (cont = 0; cont < x; cont++) //Captura de datos de las "n" clases asignadas por el usuario
            {
                Console.Write("Clase #{0}: ", cont + 1); //Captura el nombre de cada clase
                clase.Add(Console.ReadLine());              
            }
            Console.WriteLine();
            for (cont = 0; cont < x; cont++)
            {

                Console.Write("¿Cuántos alumnos tendra la clase de: {0}?: ", clase.ToArray().ElementAt(cont));
                alumno.Add(Console.ReadLine());
            }
            Console.WriteLine();
            for (clases = 0; clases < x; clases++)
            {
                for (cont = 0; cont < Convert.ToInt32(alumno.ToArray().ElementAt(clases)); cont++)
                {
                    Console.Write("Ingrese la calificación del alumno {0} de la clase de {1}: ", cont + 1, clase.ToArray().ElementAt(clases));
                    calificacion.Add(Console.ReadLine());
                }
            }
            Console.WriteLine();
            int cont1 = 0;
            foreach (var item in clase)
            {
                cont1++;
                Console.WriteLine("Clase {0}: {1}", cont1, item);
                for (int contador = 0; contador < Convert.ToInt32(alumno.ToArray().ElementAt(clase.IndexOf(item))); contador++)
                {
                    Console.WriteLine("Alumno #{0} su calificación es: {1}", contador + 1, calificacion.ToArray().ElementAt(calif));
                    calif++;
                }
            }
        }
    }
}
