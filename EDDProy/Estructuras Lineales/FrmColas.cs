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
    public partial class FrmColas : Form
    {
        Colas cola = new Colas();  // Instancia de la cola
        public FrmColas()
        {
            InitializeComponent();
        }
        private void ActualizarCola()
        {
            var (recorrido, _) = cola.Recorrer();
            TxResultado.Text = recorrido;  // Mostrar el contenido de la cola en el TextBox de resultados
        }
        private void MostrarTiempoYOperaciones(Stopwatch stopwatch, int operaciones)
        {
            long tiempoMs = stopwatch.ElapsedMilliseconds;
            long tiempoTicks = stopwatch.ElapsedTicks;
            TxInfo.Text = $"Tiempo: {tiempoMs} ms, {tiempoTicks} ticks, Operaciones: {operaciones}";
        }
        private void BtQueue_Click(object sender, EventArgs e)
        {

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtDequeue_Click(object sender, EventArgs e)
        {

        }

        private void BtColaVaciar_Click(object sender, EventArgs e)
        {
            cola.Vaciar();
            ActualizarCola();

        }
    }
}
