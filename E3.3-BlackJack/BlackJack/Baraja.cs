using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Baraja
    {
        Random random; //Nuevo objeto de la clase Random
        public Baraja() //Constructor
        {
            random = new Random(); 
        }

        public Carta ObtenerCarta() //Generar un número aleatorio
        {
            int valor = random.Next(1, 11);
            Carta c = new Carta(valor);
            return c;
        }
    }
}
