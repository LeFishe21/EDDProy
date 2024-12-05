using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public class Pilas
    {
        public Nodo Top;
        public Pilas()
        {
            Top = null;
        }
        public bool estaVacio()
        {
            return Top == null;
        }
        // Push
        public int Push(string dato)
        {
            int operaciones = 0;
            Nodo nuevo = new Nodo(dato);
            operaciones++;

            if (Top == null)
            {
                Top = nuevo;
                operaciones++;
            }
            else
            {
                Nodo Temp = Top;
                Top = nuevo;
                Top.Sig = Temp;
                operaciones += 2;
            }
            return operaciones;
        }

        // Pop
        public (string, int) Pop()
        {
            int operaciones = 0;
            if (Top == null)
            {
                operaciones++;
                return ("Pila vacía", operaciones);
            }
            else
            {
                Nodo temp = Top;
                Top = Top.Sig;
                string Dato = temp.Dato;
                temp = null;
                operaciones += 3;
                return (Dato, operaciones);
            }
        }

        // Buscar valor especifico
        public (int, int) Buscar(string valor)
        {
            int operaciones = 0;
            if (Top == null) return (-1, operaciones);

            Nodo actual = Top;
            int pos = 1;
            operaciones++;

            while (actual != null)
            {
                operaciones++;
                if (actual.Dato == valor)
                {
                    return (pos, operaciones);
                }
                actual = actual.Sig;
                pos++;
            }
            return (-1, operaciones);
        }

        // Recorrer
        public (string, int) Recorrer()
        {
            int operaciones = 0;
            if (Top == null) return ("Pila vacía", operaciones);

            Nodo actual = Top;
            string resultado = "";
            operaciones++;

            while (actual != null)
            {
                resultado += actual.Dato + " -> ";
                actual = actual.Sig;
                operaciones++;
            }
            resultado += "null";
            return (resultado, operaciones);
        }
        public void Vaciar()
        {
            if (estaVacio())
            {
                MessageBox.Show("La pila ya está vacía");
                return;
            }
            while (!estaVacio())
            {
                Pop();
            }
            MessageBox.Show("La pila ha sido vaciada");
        }
    }
}
