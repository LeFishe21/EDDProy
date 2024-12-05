using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class FrmListasSimples : Form
    {
        ListaSimple lista = new ListaSimple();
        public FrmListasSimples()
        {
            InitializeComponent();
        }
        // Método para actualizar y mostrar la lista en el TextBox de resultados
        private void ActualizarLista()
        {
            var (recorrido, _) = lista.Recorrer();
            TxResultado.Text = recorrido;  // Mostrar el contenido de la lista en el TextBox de resultados
        }

        // Método para mostrar el tiempo y operaciones en el TextBox de información
        private void MostrarTiempoYOperaciones(Stopwatch stopwatch, int operaciones)
        {
            long tiempoMs = stopwatch.ElapsedMilliseconds;
            long tiempoTicks = stopwatch.ElapsedTicks;
            TxInfo.Text = $"Tiempo: {tiempoMs} ms, {tiempoTicks} ticks, Operaciones: {operaciones}";
        }
        private void BtInsetarInicio_Click(object sender, EventArgs e)
        {

        }

        private void BtInsetarFinal_Click(object sender, EventArgs e)
        {

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtEliminarDato_Click(object sender, EventArgs e)
        {

        }

        private void BtInsetarPosicion_Click(object sender, EventArgs e)
        {

        }

        private void BtListaVaciar_Click(object sender, EventArgs e)
        {

        }
    }
}
