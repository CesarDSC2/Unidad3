using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Pilas
    {
        private int p_index;
        private ArrayList list; //Los nombres de las clases deben ir en mayúscula y en singular.

        public Pilas()
        {
            list = new ArrayList();
            p_index = -1;
        }

        public int Count //Es una variable
        {
            get { return list.Count; } //Es un identificador de acceso que obtiene el dato el dato publico de una variable
        }

        public void Push(object item)
        {
            list.Add(item);
            p_index++;
        }

        public object Pop() //Va a regresar lo que sea que este en la lista en el p_index
        {
            object obj = list[p_index];
            list.Remove(p_index);
            p_index--;
            return obj;
        }

        public void Clear()
        {
            list.Clear();
            p_index = -1;
        }

        public object Peek()
        {
            return list[p_index];
        }
    }
}
