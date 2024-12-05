using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Ordenamiento.Clases
{
    public class ShellSort
    {
        public static void FuncionShellSort(ListaSimple lista)
        {
            if (lista.estaVacio()) return;

            // Se convierte la lista en un arreglo
            int[] valores = ConvertirListaAArreglo(lista);

            // Aplicar el algoritmo Shellsort
            Shellsort(valores);

            // Rehacer la lista con los elemntos ordenados
            ReconstruirListaDesdeArreglo(lista, valores);
        }

        // Implementación del algoritmo Shellsort
        private static void Shellsort(int[] valores)
        {
            int n = valores.Length;

            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = valores[i];
                    int j = i;

                    // Comparación e intercambio utilizando el gap
                    while (j >= gap && valores[j - gap] > temp)
                    {
                        valores[j] = valores[j - gap];
                        j -= gap;
                    }

                    valores[j] = temp;
                }
                gap /= 2;
            }
        }

        // Lista simple a un arreglo de enteros
        private static int[] ConvertirListaAArreglo(ListaSimple lista)
        {
            List<int> elementos = new List<int>();
            Nodo actual = lista.Cabeza;

            while (actual != null)
            {
                elementos.Add(int.Parse(actual.Dato));
                actual = actual.Sig;
            }

            return elementos.ToArray();
        }

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
