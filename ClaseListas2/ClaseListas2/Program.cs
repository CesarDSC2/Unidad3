using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*Listas
 * Listas ligadas
 * Listas circulares
 * 
 * List vs Array
 * Array: 1.- Un solo tipo de dato, 2.- Dimensiones, 3.- Longitud, 4.- Solo lectura(que no se puede cambiar su tamaño una vez definido)
 * 5.- Sincronizado, 6.-Métodos / propiedades, 7.- Uso en memoria.
 * 
 * Lista: 1.-Dinamicas(una lista la puedes convertir en un arreglo), 2.-Acepta todo tipo de datos, 3.- Longitud no definida, 
 * 4.- Tienen métodos, 5.-Tienen propiedades, 6.- Funciones específicas de acceso.
 * En Listas siempre despues de añadir un valor a un espacio, automaticamente se crea un nuevo elemento vacio, a este espacio
 * se le llama "nulo".
 * Listas ligadas: Propiedad: Sirve para ordenar, buscar elementos, una lista ligada se compone de dos parámetros: nodos y listas.
 * Nodo se utiliza para ligar los elementos. En estes caso espacio vacio se queda esperando un nuevo valor, pero la diferencia es que 
 * el elemento se crea después de introducir el valor, y en las listas ese espacio se crea antes de.
 * *NodeHead*
 * En arreglos tenemos indices, en listas ligadas tenemos relaciones.
 * Usamos listas ligadas cuando tenemos elementos parecidos.
 * Ventaja es que ocupa menor espacio de memoria, pero la desventaja es que requiere un tiempo de ejecución más largo.
 * */

namespace ClaseListas2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> list = new List<int>();
            
            int[] array = new int[2];
            
        }
    }
}
