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
    public partial class FrmListasCirculares : Form
    {
        ListaCircular lista = new ListaCircular();  // Instancia de la lista circular
        public FrmListasCirculares()
        {
            InitializeComponent();
        }
        private void MostrarTiempoYOperaciones(Stopwatch stopwatch, int operaciones)
        {
            long tiempoMs = stopwatch.ElapsedMilliseconds;
            long tiempoTicks = stopwatch.ElapsedTicks;
            TxInfo.Text = $"Tiempo: {tiempoMs} ms, {tiempoTicks} ticks, Operaciones: {operaciones}";
        }

        private void ActualizarLista()
        {
            var (resultado, _) = lista.Recorrer();
            TxResultado.Text = resultado;
        }
        private void BtInsetarPosicion_Click(object sender, EventArgs e)
        {

        }

        private void BtEliminarPosicion_Click(object sender, EventArgs e)
        {

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtListaCVaciar_Click(object sender, EventArgs e)
        {

        }
    }
}
