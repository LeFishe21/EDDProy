﻿namespace EDDemo.Recursividad
{
    partial class FrmFactorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxResultadoFact = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.EntrarFactorial = new System.Windows.Forms.Button();
            this.labelPedirNumFact = new System.Windows.Forms.Label();
            this.CuadroTxtFact = new System.Windows.Forms.TextBox();
            this.labelDescripcionFact = new System.Windows.Forms.Label();
            this.TituloFact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxResultadoFact
            // 
            this.textBoxResultadoFact.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultadoFact.Location = new System.Drawing.Point(65, 364);
            this.textBoxResultadoFact.Name = "textBoxResultadoFact";
            this.textBoxResultadoFact.Size = new System.Drawing.Size(591, 25);
            this.textBoxResultadoFact.TabIndex = 28;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(315, 340);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 21);
            this.labelResultado.TabIndex = 27;
            // 
            // EntrarFactorial
            // 
            this.EntrarFactorial.BackColor = System.Drawing.Color.Pink;
            this.EntrarFactorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntrarFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntrarFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EntrarFactorial.Location = new System.Drawing.Point(345, 292);
            this.EntrarFactorial.Name = "EntrarFactorial";
            this.EntrarFactorial.Size = new System.Drawing.Size(75, 34);
            this.EntrarFactorial.TabIndex = 26;
            this.EntrarFactorial.Text = "Ejecutar";
            this.EntrarFactorial.UseVisualStyleBackColor = false;
            this.EntrarFactorial.Click += new System.EventHandler(this.EntrarFactorial_Click);
            // 
            // labelPedirNumFact
            // 
            this.labelPedirNumFact.AutoSize = true;
            this.labelPedirNumFact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedirNumFact.Location = new System.Drawing.Point(315, 216);
            this.labelPedirNumFact.Name = "labelPedirNumFact";
            this.labelPedirNumFact.Size = new System.Drawing.Size(145, 21);
            this.labelPedirNumFact.TabIndex = 25;
            this.labelPedirNumFact.Text = "Escribe un número";
            // 
            // CuadroTxtFact
            // 
            this.CuadroTxtFact.Location = new System.Drawing.Point(314, 266);
            this.CuadroTxtFact.Name = "CuadroTxtFact";
            this.CuadroTxtFact.Size = new System.Drawing.Size(136, 20);
            this.CuadroTxtFact.TabIndex = 24;
            // 
            // labelDescripcionFact
            // 
            this.labelDescripcionFact.AutoSize = true;
            this.labelDescripcionFact.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionFact.Location = new System.Drawing.Point(34, 129);
            this.labelDescripcionFact.Name = "labelDescripcionFact";
            this.labelDescripcionFact.Size = new System.Drawing.Size(309, 25);
            this.labelDescripcionFact.TabIndex = 23;
            this.labelDescripcionFact.Text = "Consigue el factorial de un número";
            // 
            // TituloFact
            // 
            this.TituloFact.AutoSize = true;
            this.TituloFact.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFact.ForeColor = System.Drawing.Color.Snow;
            this.TituloFact.Location = new System.Drawing.Point(12, 60);
            this.TituloFact.Name = "TituloFact";
            this.TituloFact.Size = new System.Drawing.Size(367, 45);
            this.TituloFact.TabIndex = 22;
            this.TituloFact.Text = "Factorial de un numero";
            // 
            // FrmFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResultadoFact);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.EntrarFactorial);
            this.Controls.Add(this.labelPedirNumFact);
            this.Controls.Add(this.CuadroTxtFact);
            this.Controls.Add(this.labelDescripcionFact);
            this.Controls.Add(this.TituloFact);
            this.Name = "FrmFactorial";
            this.Text = "FrmFactorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResultadoFact;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button EntrarFactorial;
        private System.Windows.Forms.Label labelPedirNumFact;
        private System.Windows.Forms.TextBox CuadroTxtFact;
        private System.Windows.Forms.Label labelDescripcionFact;
        private System.Windows.Forms.Label TituloFact;
    }
}