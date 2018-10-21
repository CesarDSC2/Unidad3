using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BlackJack
{
    class Mano
    {
        Stack cartas;
        public Mano()
        {
            cartas = new Stack();
        }

        public void Agregar(Carta carta)
        {
            cartas.Push(carta);
        }

        public int Total()
        {
            int total = 0;
            foreach (Carta item in cartas)
            {
                total = total + item.Valor;
            }
            return total;
        }

        public bool Pierde()
        {
            return Total() > 21; //Si se pasa de 21 pierde.
        }

        public bool Gana()
        {
            return Total() == 21; //Igual a 21 gana.
        }


        public override string ToString() //Función para imprimir el valor de la mano.
        {

            string x = "Mano: ";
            x = x + Total();
            Console.WriteLine();
            return x;
        }

    }
}
