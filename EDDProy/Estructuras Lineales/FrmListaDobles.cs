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
    public partial class FrmListaDobles : Form
    {
        ListasDobles lista = new ListasDobles();  // Instancia de la lista doble
        public FrmListaDobles()
        {
            InitializeComponent();
        }
        // Actualizar y mostrar la lista en el TextBox de resultados (hacia adelante)
        private void ActualizarLista()
        {
            var (resultado, _) = lista.RecorrerAdelante();
            TxResultado.Text = resultado;  // Mostrar la lista en el TextBox
        }

        // Mostrar tiempo y operaciones en el TextBox de información
        private void MostrarTiempoYOperaciones(Stopwatch stopwatch, int operaciones)
        {
            long tiempoMs = stopwatch.ElapsedMilliseconds;
            long tiempoTicks = stopwatch.ElapsedTicks;
            TxInfo.Text = $"Tiempo: {tiempoMs} ms, {tiempoTicks} ticks, Operaciones: {operaciones}";
        }
        private void BtInsetarPosicion_Click(object sender, EventArgs e)
        {

        }
        // Botón para eliminar en una posición específica
        private void BtEliminarPosicion_Click(object sender, EventArgs e)
        {

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtRecorrerAtras_Click(object sender, EventArgs e)
        {

        }

        private void BtListaDVaciar_Click(object sender, EventArgs e)
        {

        }
    }
}
