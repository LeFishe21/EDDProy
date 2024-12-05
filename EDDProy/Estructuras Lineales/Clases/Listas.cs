using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    class Listas
    {
        public Nodo Cabeza;
        public Listas()
        {
            Cabeza = null;
        }
        public bool estaVacio()
        {
            return Cabeza == null;
        }
        // Insertar al inicio
        public int InsertarInicio(string valor)
        {
            int operaciones = 0;
            Nodo Nuevo = new Nodo(valor);
            Nuevo.Sig = Cabeza;
            Cabeza = Nuevo;
            operaciones++;
            return operaciones;
        }

        // Insertar al final
        public int InsertarFinal(string valor)
        {
            int operaciones = 0;
            Nodo Nuevo = new Nodo(valor);
            operaciones++;

            if (Cabeza == null)
            {
                Cabeza = Nuevo;
                operaciones++;
            }
            else
            {
                Nodo Actual = Cabeza;
                while (Actual.Sig != null)
                {
                    Actual = Actual.Sig;
                    operaciones++;
                }
                Actual.Sig = Nuevo;
                operaciones++;
            }
            return operaciones;
        }

        // Insertar en posición especifica
        public int InsertarPos(string valor, int pos)
        {
            int operaciones = 0;
            pos = pos - 1;
            Nodo Nuevo = new Nodo(valor);
            operaciones++;

            if (pos == 0)
            {
                operaciones += InsertarInicio(valor);
            }
            else
            {
                Nodo Actual = Cabeza;
                int Contador = 0;
                while (Actual != null && Contador < pos - 1)
                {
                    Actual = Actual.Sig;
                    Contador++;
                    operaciones++;
                }

                if (Actual != null)
                {
                    Nuevo.Sig = Actual.Sig;
                    Actual.Sig = Nuevo;
                    operaciones += 2;
                }
                else
                {
                    Console.WriteLine("La posición excede el tamaño de la lista.");
                }
            }
            return operaciones;
        }

        // Eliminar primer nodo
        public int EliminarTop()
        {
            int operaciones = 0;
            if (Cabeza != null)
            {
                Cabeza = Cabeza.Sig;
                operaciones++;
            }
            else
            {
                Console.WriteLine("La lista está vacía.");
            }
            return operaciones;
        }

        // Eliminar un valor en especifico
        public int EliminarValor(string valor)
        {
            int operaciones = 0;

            if (Cabeza == null) return operaciones;

            if (Cabeza.Dato == valor)
            {
                operaciones += EliminarTop();
                return operaciones;
            }

            Nodo Actual = Cabeza;
            while (Actual.Sig != null && Actual.Sig.Dato != valor)
            {
                Actual = Actual.Sig;
                operaciones++;
            }

            if (Actual.Sig != null)
            {
                Actual.Sig = Actual.Sig.Sig;
                operaciones++;
            }
            else
            {
                Console.WriteLine("Valor no encontrado.");
            }
            return operaciones;
        }

        // Buscar un valor
        public (int, int) Buscar(string valor)
        {
            Nodo Actual = Cabeza;
            int Pos = 1;
            int operaciones = 0;

            while (Actual != null)
            {
                operaciones++;
                if (Actual.Dato == valor) return (Pos, operaciones);
                Actual = Actual.Sig;
                Pos++;
            }

            Console.WriteLine("Valor no encontrado en la lista.");
            return (-1, operaciones);
        }

        // Recorrer
        public (string, int) Recorrer()
        {
            int operaciones = 0;
            if (Cabeza == null)
            {
                operaciones++;
                return ("La lista está vacía.", operaciones);
            }

            Nodo Actual = Cabeza;
            string resultado = "";
            operaciones++;

            while (Actual != null)
            {
                resultado += Actual.Dato + " -> ";
                Actual = Actual.Sig;
                operaciones++;
            }
            resultado += "null";
            return (resultado, operaciones);
        }
        public void Vaciar()
        {
            if (estaVacio())
            {
                MessageBox.Show("La lista ya está vacía");
                return;
            }

            Nodo actual = Cabeza;

            // Eliminar todos los nodos
            while (actual != null)
            {
                Nodo sig = actual.Sig;
                actual.Sig = null;
                actual = sig;
            }

            Cabeza = null;
        }
        public void VaciarHash()
        {
            if (estaVacio())
            {
                return;
            }

            Nodo actual = Cabeza;


            while (actual != null)
            {
                Nodo sig = actual.Sig;
                actual.Sig = null;
                actual = sig;
            }

            Cabeza = null;
        }
        public override string ToString()
        {
            Nodo actual = Cabeza;
            StringBuilder resultado = new StringBuilder();

            while (actual != null)
            {
                if (resultado.Length > 0)
                    resultado.Append(" -> ");

                resultado.Append(actual.Dato);
                actual = actual.Sig;
            }

            resultado.Append(" -> null");
            return resultado.ToString();
        }
    }
}
