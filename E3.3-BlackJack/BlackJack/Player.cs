using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BlackJack
{
    class Player
    {
        Mano mano;

        public Player() //Constructor
        {
            mano = new Mano(); //Asignamos e inicializamos el objeto mano de la clase Mano
        }

        public void JuegaCartas(int num, Baraja baraja)
        {
            for (int i = 0; i < num; i++)
            {
                mano.Agregar(baraja.ObtenerCarta()); //Para tomar una carta nueva
            }

            Console.WriteLine(this.ToString()); //Lo utilizamos para mostrar el total que hay en Mano
        }

        public Mano Jugar(Baraja baraja)
        {
            JuegaCartas(2, baraja);
            Console.WriteLine();

            bool juega = true;
            while (juega)
            {
                Console.WriteLine("1.-Jugar\n2.-Mantenerte");
                Console.Write("Opción: ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        JuegaCartas(1, baraja);
                        juega = !mano.Pierde();
                        break;
                    case 2:
                        juega = false;
                        break;
                    default:
                        Console.WriteLine("Ingrese un valor válido");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            return mano;
        }

        public override string ToString()
        {
            return mano.ToString(); //ToString para que nos revele el resultado en forma de caracteres.
        }
    }
}
