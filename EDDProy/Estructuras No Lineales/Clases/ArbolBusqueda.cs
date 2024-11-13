using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L label=\"L\"] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }
            else
            {
                b.AppendFormat("{0}->L{1} [side=L, style=\"invis\" label=\"L\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("L{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R label=\"R\"] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            else
            {
                b.AppendFormat("{0}->R{1} [side=R, style=\"invis\" label=\"R\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("R{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);

            }
            return b.ToString();
        }


        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }

        public bool Busqueda(int Dato, NodoBinario nodo)
        {
            if (nodo == null)
                return false;
            if (Dato == nodo.Dato)
                return true;
            if (Dato < nodo.Dato)
                return Busqueda(Dato, nodo.Izq);
            else
                return Busqueda(Dato, nodo.Der);
        }

        public bool InsertarNodoRecursivo(int Dato)
        {
            if (Busqueda(Dato, Raiz))
                return false;
            InsertaNodo(Dato, ref Raiz);
            return true;
        }

        // NUEVOS METODOS
        public void PodarArbol(ref NodoBinario nodo)
        {
            if (nodo == null)
                return;
            PodarArbol(ref nodo.Izq);
            PodarArbol(ref nodo.Der);
            nodo = null;
        }

        public void PodarArbolCompleto()
        {
            if (Raiz == null)
            {
                Console.WriteLine("Arbol vacio");
                return;
            }

            PodarArbol(ref Raiz);
            Raiz = null;
            Console.WriteLine("El arbol ha sido podado por completo");
        }


        public NodoBinario EliminarPredecesor(NodoBinario nodo, int valor)
        {
            if (nodo == null) return nodo;

            if (valor < nodo.Dato)
            {
                nodo.Izq = EliminarPredecesor(nodo.Izq, valor);
            }
            else if (valor > nodo.Dato)
            {
                nodo.Der = EliminarPredecesor(nodo.Der, valor);
            }
            else
            {
                if (nodo.Izq != null && nodo.Der != null)
                {
                    NodoBinario predecesor = EncontrarMaximo(nodo.Izq);
                    nodo.Dato = predecesor.Dato;
                    nodo.Izq = EliminarPredecesor(nodo.Izq, predecesor.Dato);
                }
                else
                {
                    nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;
                }
            }

            return nodo;
        }

        private NodoBinario EncontrarMaximo(NodoBinario nodo)
        {
            while (nodo.Der != null)
            {
                nodo = nodo.Der;
            }
            return nodo;
        }

        private NodoBinario EncontrarMinimo(NodoBinario nodo)
        {
            while (nodo.Izq != null)
                nodo = nodo.Izq;
            return nodo;
        }

        public NodoBinario EliminarSucesor(NodoBinario nodo, int valor)
        {
            if (nodo == null) return nodo;

            if (valor < nodo.Dato)
            {
                nodo.Izq = EliminarSucesor(nodo.Izq, valor);
            }
            else if (valor > nodo.Dato)
            {
                nodo.Der = EliminarSucesor(nodo.Der, valor);
            }
            else
            {
                if (nodo.Izq != null && nodo.Der != null)
                {
                    NodoBinario sucesor = EncontrarMinimo(nodo.Der);
                    nodo.Dato = sucesor.Dato;
                    nodo.Der = EliminarSucesor(nodo.Der, sucesor.Dato);
                }
                else
                {
                    nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;
                }
            }

            return nodo;
        }


        private NodoBinario Minimo(NodoBinario nodo)
        {
            while (nodo.Izq != null)
                nodo = nodo.Izq;
            return nodo;
        }

        public void RecorrerPorNiveles()
        {
            if (Raiz == null)
                return;

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(Raiz);
            strRecorrido = "";

            while (cola.Count > 0)
            {
                NodoBinario actual = cola.Dequeue();
                strRecorrido += actual.Dato + ",";

                if (actual.Izq != null)
                    cola.Enqueue(actual.Izq);
                if (actual.Der != null)
                    cola.Enqueue(actual.Der);
            }
        }

        public int Altura(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;
            int alturaIzq = Altura(nodo.Izq);
            int alturaDer = Altura(nodo.Der);
            return Math.Max(alturaIzq, alturaDer) + 1;
        }

        public int ContarHojas(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;
            if (nodo.Izq == null && nodo.Der == null)
                return 1;
            return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }

        public int ContarNodos(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;
            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);
        }

        public bool EsCompleto()
        {
            if (Raiz == null)
                return true;

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(Raiz);
            bool finalCompleto = false;

            while (cola.Count > 0)
            {
                NodoBinario actual = cola.Dequeue();
                if (actual.Izq != null)
                {
                    if (finalCompleto)
                        return false;
                    cola.Enqueue(actual.Izq);
                }
                else
                {
                    finalCompleto = true;
                }
                if (actual.Der != null)
                {
                    if (finalCompleto)
                        return false;
                    cola.Enqueue(actual.Der);
                }
                else
                {
                    finalCompleto = true;
                }
            }
            return true;
        }

        public bool EsLleno()
        {
            if (Raiz == null)
                return true;

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(Raiz);
            int altura = Altura(Raiz);

            while (cola.Count > 0)
            {
                NodoBinario actual = cola.Dequeue();
                if ((actual.Izq == null && actual.Der != null) || (actual.Izq != null && actual.Der == null))
                    return false;

                if (actual.Izq != null)
                    cola.Enqueue(actual.Izq);
                if (actual.Der != null)
                    cola.Enqueue(actual.Der);
            }
            return true;

        }

    }
}