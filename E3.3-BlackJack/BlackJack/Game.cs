using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Game
    {

        Baraja baraja;
        public Game() //Constructor de la clase
        {
            baraja = new Baraja();
        }

        public void Play()
        {

            Player player = new Player(); //Objeto "player"
            Mano playerMano = player.Jugar(baraja); //Creamos un objeto de la clase Mano para
            int cont1 = 0;
            int cont2 = 0;
            int suma1 = 0;
            int suma2 = 0;
            if (playerMano.Gana()) 
            {
                Console.WriteLine("HAS GANADO.");
                cont1++;
                suma1 += cont1;
            }
            else if (playerMano.Pierde())
            {
                Console.WriteLine("Game over");
                cont2++;
                suma2 += cont2;
            }
            else
            {
                Console.WriteLine("El jugador se mantiene en {0}", playerMano.Total());
            }

            Console.WriteLine("\nGanados: {0}\tPerdidos: {1}",suma1, suma2);
            Console.Write("\nPulse cualquier tecla para continuar...");

        }
    }
}
