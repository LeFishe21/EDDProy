﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class FrmPila : Form
    {
        Pilas pila = new Pilas();
        public FrmPila()
        {
            InitializeComponent();
        }
        private void ActualizarPila()
        {
            var (recorrido, _) = pila.Recorrer();
            TxResultado.Text = recorrido;  // Mostrar el contenido de la pila en el TextBox de resultados
        }

        // Método para mostrar el tiempo y operaciones en el TextBox de información
        private void MostrarTiempoYOperaciones(Stopwatch stopwatch, int operaciones)
        {
            long tiempoMs = stopwatch.ElapsedMilliseconds;
            long tiempoTicks = stopwatch.ElapsedTicks;
            TxInfo.Text = $"Tiempo: {tiempoMs} ms, {tiempoTicks} ticks, Operaciones: {operaciones}";
        }

        private void BtAñadir_Click(object sender, EventArgs e)
        {

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtPilaVaciar_Click(object sender, EventArgs e)
        {
            pila.Vaciar();
            ActualizarPila();
        }
    }
}