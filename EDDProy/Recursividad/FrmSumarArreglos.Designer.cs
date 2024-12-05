﻿namespace EDDemo.Recursividad
{
    partial class FrmSumarArreglos
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
            this.ResultadoArregloTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btEntrarArreglo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxArregloEscribir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TituloArreglo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultadoArregloTxtBox
            // 
            this.ResultadoArregloTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoArregloTxtBox.Location = new System.Drawing.Point(54, 345);
            this.ResultadoArregloTxtBox.Name = "ResultadoArregloTxtBox";
            this.ResultadoArregloTxtBox.Size = new System.Drawing.Size(376, 25);
            this.ResultadoArregloTxtBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 26;
            // 
            // btEntrarArreglo
            // 
            this.btEntrarArreglo.BackColor = System.Drawing.Color.Pink;
            this.btEntrarArreglo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEntrarArreglo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEntrarArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btEntrarArreglo.Location = new System.Drawing.Point(238, 261);
            this.btEntrarArreglo.Name = "btEntrarArreglo";
            this.btEntrarArreglo.Size = new System.Drawing.Size(75, 34);
            this.btEntrarArreglo.TabIndex = 25;
            this.btEntrarArreglo.Text = "Ejecutar";
            this.btEntrarArreglo.UseVisualStyleBackColor = false;
            this.btEntrarArreglo.Click += new System.EventHandler(this.btEntrarArreglo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Escribe los datos";
            // 
            // txtboxArregloEscribir
            // 
            this.txtboxArregloEscribir.Location = new System.Drawing.Point(68, 271);
            this.txtboxArregloEscribir.Name = "txtboxArregloEscribir";
            this.txtboxArregloEscribir.Size = new System.Drawing.Size(136, 20);
            this.txtboxArregloEscribir.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Realiza la suma de los elementos de un arreglo";
            // 
            // TituloArreglo
            // 
            this.TituloArreglo.AutoSize = true;
            this.TituloArreglo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloArreglo.ForeColor = System.Drawing.Color.Snow;
            this.TituloArreglo.Location = new System.Drawing.Point(14, 58);
            this.TituloArreglo.Name = "TituloArreglo";
            this.TituloArreglo.Size = new System.Drawing.Size(542, 45);
            this.TituloArreglo.TabIndex = 21;
            this.TituloArreglo.Text = "Sumar los elementos de un arreglo";
            // 
            // FrmSumarArreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultadoArregloTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btEntrarArreglo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxArregloEscribir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TituloArreglo);
            this.Name = "FrmSumarArreglos";
            this.Text = "FrmSumarArreglos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultadoArregloTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEntrarArreglo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxArregloEscribir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TituloArreglo;
    }
}