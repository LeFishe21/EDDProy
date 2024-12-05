﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    internal class BusquedaBinaria
    {
        public int[] GenerarArregloAleatorio(int tamaño)
        {
            Random rnd = new Random();
            int[] arreglo = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                arreglo[i] = rnd.Next(1, 1001); // Genera números aleatorios entre 1 y 1001     
            }

            return arreglo;
        }
        public List<int> BuscarTodosIndices(int[] arreglo, int valorBuscado, int inicio, int fin)
        {
            List<int> indices = new List<int>();

            if (inicio > fin)
                return indices; // Indicar que el elemento no esta en el arreglo

            int medio = inicio + (fin - inicio) / 2;

            // Buscar en el índice medio
            if (arreglo[medio] == valorBuscado)
            {
                // Agregar el índice medio
                indices.Add(medio);

                // Busqueda a la izquierda
                int izquierda = medio - 1;
                while (izquierda >= inicio && arreglo[izquierda] == valorBuscado)
                {
                    indices.Add(izquierda);
                    izquierda--;
                }

                // Busqueda a la derecha
                int derecha = medio + 1;
                while (derecha <= fin && arreglo[derecha] == valorBuscado)
                {
                    indices.Add(derecha);
                    derecha++;
                }

                // Verificar que los indices esten ordenados
                indices.Sort();

                return indices;
            }

            // Busqueda en la mitad izquierda
            if (arreglo[medio] > valorBuscado)
                return BuscarTodosIndices(arreglo, valorBuscado, inicio, medio - 1);
            else
                // Busqueda en la mitad derecha
                return BuscarTodosIndices(arreglo, valorBuscado, medio + 1, fin);
        }
    }
}
