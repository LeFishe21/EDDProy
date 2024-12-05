using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Ordenamiento.Clases
{
    internal class QuickSort
    {
        // Adapta quicksort para lista simple
        public static void FuncionQuicksort(ListaSimple lista)
        {
            if (lista.estaVacio()) return;

            // Convertir la lista a un arreglo
            int[] arreglo = ConvertirListaAArreglo(lista);

            QuicksortRecursivo(arreglo, 0, arreglo.Length - 1);

            ReconstruirListaDesdeArreglo(lista, arreglo);
        }

        // Función recursiva de Quicksort
        private static void QuicksortRecursivo(int[] A, int inf, int sup)
        {
            if (inf >= sup)
                return;

            int i = inf;
            int j = sup;
            int pivote = A[(inf + sup) / 2];

            while (i <= j)
            {
                // Busqueda a la izquierda
                while (A[i] < pivote)
                    i++;

                // Busqueda a la derecha
                while (A[j] > pivote)
                    j--;

                if (i <= j)
                {
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                    i++;
                    j--;
                }
            }

            // Llamadas recursivas para ordenar las sublistas
            if (inf < j)
                QuicksortRecursivo(A, inf, j);

            if (i < sup)
                QuicksortRecursivo(A, i, sup);
        }

        // Convierte una lista simple en un arreglo de enteros
        private static int[] ConvertirListaAArreglo(ListaSimple lista)
        {
            List<int> elementos = new List<int>();
            Nodo actual = lista.Cabeza;

            while (actual != null)
            {
                elementos.Add(int.Parse(actual.Dato)); // Todos los datos a entero
                actual = actual.Sig;
            }

            return elementos.ToArray();
        }

        // Se reconstruye la lista desde aun arreglo de enteros
        private static void ReconstruirListaDesdeArreglo(ListaSimple lista, int[] arreglo)
        {
            lista.Vaciar();

            foreach (int elemento in arreglo)
            {
                lista.InsertarFinal(elemento.ToString());
            }
        }
    }
}
