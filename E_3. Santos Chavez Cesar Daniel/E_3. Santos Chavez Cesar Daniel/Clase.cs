using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_3.Santos_Chavez_Cesar_Daniel
{
    public class Clase
    {
        public string Maestro { get; set; }
        public string Alumno { get; set; }
        public string NombreClase { get; set; }
        public int Calificacion { get; set; }
        public string Nota { get; set; }

        public override string ToString()
        {
            Console.WriteLine("* * * * * * * *");
            return "Alumno: " + Alumno + "\nClase: " + NombreClase + "\nMaestro: " + Maestro + "\nCalificación: " + Calificacion + "\nNota: " + Nota;
        }
        public Clase()
        {
            
        }

        
    }
}
