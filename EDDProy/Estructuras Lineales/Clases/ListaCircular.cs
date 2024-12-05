using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListaCircular
    {
        public Nodo Inicio;
        public Nodo Fin;

        public ListaCircular()
        {
            Inicio = null;
            Fin = null;
        }
        public bool estaVacio()
        {
            return Inicio == null && Fin == null;
        }
        public int Insertar(string dato, int posicion)
        {
            Nodo nuevo = new Nodo(dato);
            int operaciones = 0;

            // Lista vacía
            if (Inicio == null && Fin == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
                Fin.Sig = Inicio;
                operaciones++;
                return operaciones;
            }

            // Insertar en la primera posición
            if (posicion == 0 || posicion == 1)
            {
                nuevo.Sig = Inicio;
                Inicio = nuevo;
                Fin.Sig = Inicio;
                operaciones += 2;
                return operaciones;
            }

            // Insertar en una posición mayor
            int pos = 1;
            Nodo aux = Inicio;
            Nodo previo = null;

            while (pos < posicion && aux.Sig != Inicio)
            {
                previo = aux;
                aux = aux.Sig;
                pos++;
                operaciones++;
            }

            if (pos == posicion)
            {
                nuevo.Sig = aux;
                if (previo != null)
                {
                    previo.Sig = nuevo;
                }
                operaciones++;

                if (aux == Inicio)
                {
                    Fin = nuevo;
                    operaciones++;
                }
            }
            else if (aux.Sig == Inicio)
            {
                Fin.Sig = nuevo;
                nuevo.Sig = Inicio;
                Fin = nuevo;
                operaciones++;
            }
            else
            {
                Console.WriteLine("Posición fuera de rango");
            }

            return operaciones;
        }

        // Recorrer e imprimir lista
        public (string, int) Recorrer()
        {
            string resultado = "";
            int operaciones = 0;

            if (Inicio == null)
            {
                return ("La lista está vacía", operaciones);
            }

            Nodo temp = Inicio;
            do
            {
                resultado += temp.Dato + " -> ";
                temp = temp.Sig;
                operaciones++;
            }
            while (temp != Inicio);

            resultado += "Circular";
            return (resultado, operaciones);
        }

        // Eliminar nodo en posición especifica
        public int Eliminar(int posicion)
        {
            int operaciones = 0;

            if (Inicio == null)
            {
                Console.WriteLine("Lista vacía");
                return operaciones;
            }

            Nodo aux = Inicio;
            Nodo previo = null;
            int pos = 1;

            while (pos < posicion && aux.Sig != Inicio)
            {
                previo = aux;
                aux = aux.Sig;
                pos++;
                operaciones++;
            }

            if (pos == posicion)
            {
                if (aux == Inicio && aux == Fin)
                {
                    Inicio = null;
                    Fin = null;
                    operaciones++;
                }
                else if (aux == Inicio)
                {
                    Inicio = aux.Sig;
                    Fin.Sig = Inicio;
                    operaciones++;
                }
                else if (aux == Fin)
                {
                    Fin = previo;
                    Fin.Sig = Inicio;
                    operaciones++;
                }
                else
                {
                    previo.Sig = aux.Sig;
                    operaciones++;
                }
            }
            else
            {
                Console.WriteLine("Posición fuera de rango");
            }

            return operaciones;
        }

        // Buscar valor y dar su posición
        public (int, int) Buscar(string valor)
        {
            int operaciones = 0;
            if (Inicio == null)
            {
                Console.WriteLine("La lista está vacía");
                return (-1, operaciones);
            }

            Nodo temp = Inicio;
            int pos = 1;

            do
            {
                operaciones++;
                if (temp.Dato == valor)
                {
                    return (pos, operaciones);
                }
                temp = temp.Sig;
                pos++;
            }
            while (temp != Inicio);

            Console.WriteLine("Valor no encontrado");
            return (-1, operaciones);
        }
    }
}
