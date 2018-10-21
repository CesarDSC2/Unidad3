using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Carta
    {
        public int Valor { get; } //Propiedad de solo lectura (get)
        
        public Carta(int valor) //Constructor
        {
            Valor = valor;
        }

        public override string ToString() //Representa el valor en forma de caracteres.
        {
            return Valor.ToString();
        }
    }
}
