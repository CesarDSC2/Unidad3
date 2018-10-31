using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;
using System.Threading.Tasks;

namespace E_3.Santos_Chavez_Cesar_Daniel
{
    public class Operacion
    {
        public void Principal()
        {
            Stack Lista = new Stack();
            Queue Cola = new Queue();

        }

        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            Stack pila = new Stack();
            pila.Push(5);
            pila.Push(3);
            pila.Pop();
            pila.Push(2);
            pila.Push(8);
            pila.Pop();
            pila.Pop();
            pila.Push(9);
            pila.Push(1);
            pila.Pop();
            pila.Push(7);
            pila.Push(6);
            pila.Pop();
            pila.Pop();
            pila.Push(4);
            pila.Pop();
            pila.Pop();
            foreach (var item in pila)
            {
                Console.WriteLine("Elementos: " + item);
            }
        }

        public void Ejercicio2()
        {
            Console.Clear();
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
            LinkedList<string> identificador = new LinkedList<string>();
            LinkedList<string> literal = new LinkedList<string>();
            int n = 0;
            string word = "";
            Console.Write("¿Cuántas palabras quieres añadir?: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingresa una palabra: ");
                word = Console.ReadLine();
                if (word == "null" || word == "true" || word =="false" || word == "default")
                {
                    literal.AddLast(word);
                }
                else
                {
                    identificador.AddLast(word);
                }
            }

            List<string> lista = new List<string>();
            lista.AddRange(literal);
            lista.AddRange(identificador);
            x:
            Console.Clear();

            Console.WriteLine("Desplegar: \n1.-Literales. \n2.-Identificadores. \n3.-Todos los elementos. \n4.-Salir.");
            int opc = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opc)
            {
                case 1:
                    foreach (var item in literal)
                    {
                        Console.WriteLine(item);
                        
                        
                    }
                    Console.ReadKey();
                    goto x;
                    break;
                case 2:
                    foreach (var item in identificador)
                    {
                        Console.WriteLine(item);
                        
                    }
                    Console.ReadKey();
                    goto x;

                    break;
                case 3:
                    foreach (var item in lista)
                    {
                        if (item == "null" || item == "true" || item == "false" || item == "default")
                        {
                            Console.WriteLine(item + " pertenece a: literal");
                        }
                        else
                        {
                            Console.WriteLine(item + " pertenece a: identificador");
                        }
                        
                    }
                    Console.ReadKey();
                    goto x;
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Ingrese un valor válido");
                    break;
            }            


        }

        public void Ejercicio3()
        {                       
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            const int max = 9876;
            List<string> lista = new List<string>();
            LinkedList<string> listaligada = new LinkedList<string>();

            for (int i = 0; i < 9876; i++)
            {
                lista.Add("Holis");
                listaligada.AddLast("Holis");

            }

            var m1 = Stopwatch.StartNew();
            for (int i = 0; i < max; i++)
            {
                foreach (string item in lista)
                {
                    
                }
                
            }
            m1.Stop();

            var m2 = Stopwatch.StartNew();
            for (int i = 0; i < max; i++)
            {
                foreach (var item in listaligada)
                {
                    
                }
            }
            m2.Stop();

            Console.WriteLine("Lista: " + ((double)(m1.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));
            Console.WriteLine("Lista ligada: " + ((double)(m2.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));
            Console.ReadKey();
        }

        public void Ejercicio4()
        {

            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            List<Clase> obj = new List<Clase>();
            List<string> notaBaja = new List<string>();
            string maestro = "", alum = "", nomclass = "";
            int calif = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.Clear();
                Console.Write("Alumno {0}: ", i + 1);
                alum = Console.ReadLine();
                for (int j = 0; j < 1; j++)
                {
                    Console.Write("Nombre de la clase: ");
                    nomclass = Console.ReadLine();
                    
                    for (int k = 0; k < 1; k++)
                    {
                        Console.Write("Maestro: ");
                        maestro = Console.ReadLine();
                        for (int l = 0; l < 1; l++)
                        {
                            Console.Write("Calificación: ");
                            calif = int.Parse(Console.ReadLine());
                           
                        }
                    }
                }
                if (calif > 80 && calif < 100)
                {

                    obj.Add(new Clase() { Alumno = alum, NombreClase = nomclass, Maestro = maestro, Calificacion = calif, Nota = "Nota alta"});
                }
                else if (calif > 60 && calif < 80)
                {
                    obj.Add(new Clase() { Alumno = alum, NombreClase = nomclass, Maestro = maestro, Calificacion = calif, Nota = "Nota media" });
                }
                else if (calif > 0 && calif < 60)
                {
                    obj.Add(new Clase() { Alumno = alum, NombreClase = nomclass, Maestro = maestro, Calificacion = calif, Nota = "Nota baja" });
                }
                else
                {
                    Console.WriteLine("Ingrese una calificación entre 0-100.");
                }
            }
            Console.ReadKey();
            Console.Clear();
            string nomm = "", noma = "";
            Console.WriteLine("¿Qué quieres consultar? \n1.-Alumno. \n2.-Maestro. \n3.-Desplegar lista.");
            Console.Write("Opción: ");
            int opc = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Nombre del alumno: ");
                    noma = Console.ReadLine();

                    var Maestro = (from c in obj
                                   where c.Alumno == noma
                                   select c).ToList();

                    foreach (var item in Maestro)
                    {
                        Console.WriteLine("* * * * * * * *");
                        Console.WriteLine("Alumno: " + item.Alumno + "\nClase: " + item.NombreClase + "\nMaestro: " + item.Maestro + "\nCalificación: " + item.Calificacion + "\nNota: " + item.Nota);
                    }
                    break;
                case 2:
                    Console.WriteLine("Nombre del maestro: ");
                    nomm = Console.ReadLine();

                    var Alumno = (from c in obj
                                   where c.Maestro == nomm
                                   select c).ToList();

                    foreach (var item in Alumno)
                    {
                        Console.WriteLine("* * * * * * * *");
                        Console.WriteLine("Alumno: " + item.Alumno + "\nClase: " + item.NombreClase + "\nMaestro: " + item.Maestro + "\nCalificación: " + item.Calificacion + "\nNota: " + item.Nota);
                    }
                    break;
                case 3:
                    foreach  (Clase item in obj)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                default:
                    Console.WriteLine("Ingrese un valor válido.");
                    break;
            }

        }

    }
}
