namespace EDDemo.Recursividad
{
    partial class FrmFibonacci
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
            this.textBoxResultadoFib = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btEnterFib = new System.Windows.Forms.Button();
            this.labelPedirNumFib = new System.Windows.Forms.Label();
            this.txtboxEscribirFib = new System.Windows.Forms.TextBox();
            this.labelDescripcionFib = new System.Windows.Forms.Label();
            this.TituloFibonacci = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxResultadoFib
            // 
            this.textBoxResultadoFib.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultadoFib.Location = new System.Drawing.Point(73, 371);
            this.textBoxResultadoFib.Name = "textBoxResultadoFib";
            this.textBoxResultadoFib.Size = new System.Drawing.Size(547, 25);
            this.textBoxResultadoFib.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 26;
            // 
            // btEnterFib
            // 
            this.btEnterFib.BackColor = System.Drawing.Color.Pink;
            this.btEnterFib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnterFib.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnterFib.Location = new System.Drawing.Point(176, 314);
            this.btEnterFib.Name = "btEnterFib";
            this.btEnterFib.Size = new System.Drawing.Size(75, 34);
            this.btEnterFib.TabIndex = 25;
            this.btEnterFib.Text = "Ejecutar";
            this.btEnterFib.UseVisualStyleBackColor = false;
            // 
            // labelPedirNumFib
            // 
            this.labelPedirNumFib.AutoSize = true;
            this.labelPedirNumFib.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedirNumFib.Location = new System.Drawing.Point(88, 211);
            this.labelPedirNumFib.Name = "labelPedirNumFib";
            this.labelPedirNumFib.Size = new System.Drawing.Size(258, 21);
            this.labelPedirNumFib.TabIndex = 24;
            this.labelPedirNumFib.Text = "Escribe la longitud de la secuencia";
            // 
            // txtboxEscribirFib
            // 
            this.txtboxEscribirFib.Location = new System.Drawing.Point(148, 275);
            this.txtboxEscribirFib.Name = "txtboxEscribirFib";
            this.txtboxEscribirFib.Size = new System.Drawing.Size(136, 20);
            this.txtboxEscribirFib.TabIndex = 23;
            // 
            // labelDescripcionFib
            // 
            this.labelDescripcionFib.AutoSize = true;
            this.labelDescripcionFib.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionFib.Location = new System.Drawing.Point(12, 129);
            this.labelDescripcionFib.Name = "labelDescripcionFib";
            this.labelDescripcionFib.Size = new System.Drawing.Size(509, 25);
            this.labelDescripcionFib.TabIndex = 22;
            this.labelDescripcionFib.Text = "Realiza la secuencia de Fibonacci hasta el número indicado";
            // 
            // TituloFibonacci
            // 
            this.TituloFibonacci.AutoSize = true;
            this.TituloFibonacci.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFibonacci.ForeColor = System.Drawing.Color.Snow;
            this.TituloFibonacci.Location = new System.Drawing.Point(65, 55);
            this.TituloFibonacci.Name = "TituloFibonacci";
            this.TituloFibonacci.Size = new System.Drawing.Size(362, 45);
            this.TituloFibonacci.TabIndex = 21;
            this.TituloFibonacci.Text = "Secuencia de Fibonacci";
            // 
            // FrmFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResultadoFib);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btEnterFib);
            this.Controls.Add(this.labelPedirNumFib);
            this.Controls.Add(this.txtboxEscribirFib);
            this.Controls.Add(this.labelDescripcionFib);
            this.Controls.Add(this.TituloFibonacci);
            this.Name = "FrmFibonacci";
            this.Text = "FrmFibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResultadoFib;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEnterFib;
        private System.Windows.Forms.Label labelPedirNumFib;
        private System.Windows.Forms.TextBox txtboxEscribirFib;
        private System.Windows.Forms.Label labelDescripcionFib;
        private System.Windows.Forms.Label TituloFibonacci;
    }
}