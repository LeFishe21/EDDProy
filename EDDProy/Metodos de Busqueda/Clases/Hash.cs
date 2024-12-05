﻿using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Busqueda.Clases
{
    internal class Hash
    {
        private const int TAMANIO = 100;
        private int[] claves;
        private string[] valores;
        private ListaSimple[] tabla;
        public Hash()
        {
            tabla = new ListaSimple[TAMANIO];
            for (int i = 0; i < TAMANIO; i++)
            {
                tabla[i] = new ListaSimple();
            }
        }

        // Función hash simple (modular)
        private int FuncionHash(int clave)
        {
            return clave % TAMANIO;
        }

        // Función hash polinomial
        public static int FuncionHashPolinomial(string clave, int tamanioTabla)
        {
            const int basePolinomial = 31;
            int hash = 0;
            for (int i = 0; i < clave.Length; i++)
            {
                hash = (hash * basePolinomial + clave[i]) % tamanioTabla;
            }
            return Math.Abs(hash);
        }

        // Insertar clave y valor
        public void Insertar(int clave, string valor)
        {
            int indice = FuncionHash(clave);
            tabla[indice].InsertarFinal(valor);
        }

        // Buscar el valor por su clave
        public string Buscar(int clave)
        {
            int indice = FuncionHash(clave);
            var resultado = tabla[indice].ToString();
            return resultado != " -> null" ? resultado : null;
        }

        // Guardar claves y valores en un archivo
        public void GuardarEnArchivo(string ruta)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                for (int i = 0; i < TAMANIO; i++)
                {
                    if (claves[i] != -1)
                    {
                        sw.WriteLine($"{claves[i]},{valores[i]}");
                    }
                }
            }
        }
        public void VaciarTabla()
        {
            for (int i = 0; i < TAMANIO; i++)
            {
                tabla[i].VaciarHash();
            }
        }
        // Cargar claves y valores
        public void CargarDesdeArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split(',');
                    if (partes.Length == 2)
                    {
                        int clave = int.Parse(partes[0]);
                        string valor = partes[1];
                        Insertar(clave, valor);
                    }
                }
            }
        }
    }
}
