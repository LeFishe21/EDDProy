namespace EDDemo.Recursividad
{
    partial class FrmPotencia
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
            this.LabelPedirExponente = new System.Windows.Forms.Label();
            this.ExcribirExponenteTxtBox = new System.Windows.Forms.TextBox();
            this.ResultadoExpoTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EntrarBoton = new System.Windows.Forms.Button();
            this.LabelPedirBase = new System.Windows.Forms.Label();
            this.EscribirBaseTxtBox = new System.Windows.Forms.TextBox();
            this.labelDescripcionExpo = new System.Windows.Forms.Label();
            this.LabelTituloExpo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelPedirExponente
            // 
            this.LabelPedirExponente.AutoSize = true;
            this.LabelPedirExponente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPedirExponente.Location = new System.Drawing.Point(569, 249);
            this.LabelPedirExponente.Name = "LabelPedirExponente";
            this.LabelPedirExponente.Size = new System.Drawing.Size(162, 21);
            this.LabelPedirExponente.TabIndex = 35;
            this.LabelPedirExponente.Text = "Escribe el exponente";
            // 
            // ExcribirExponenteTxtBox
            // 
            this.ExcribirExponenteTxtBox.Location = new System.Drawing.Point(584, 285);
            this.ExcribirExponenteTxtBox.Name = "ExcribirExponenteTxtBox";
            this.ExcribirExponenteTxtBox.Size = new System.Drawing.Size(136, 20);
            this.ExcribirExponenteTxtBox.TabIndex = 34;
            // 
            // ResultadoExpoTxtBox
            // 
            this.ResultadoExpoTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoExpoTxtBox.Location = new System.Drawing.Point(76, 358);
            this.ResultadoExpoTxtBox.Name = "ResultadoExpoTxtBox";
            this.ResultadoExpoTxtBox.Size = new System.Drawing.Size(691, 25);
            this.ResultadoExpoTxtBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 32;
            // 
            // EntrarBoton
            // 
            this.EntrarBoton.BackColor = System.Drawing.Color.Pink;
            this.EntrarBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntrarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntrarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EntrarBoton.Location = new System.Drawing.Point(404, 309);
            this.EntrarBoton.Name = "EntrarBoton";
            this.EntrarBoton.Size = new System.Drawing.Size(75, 34);
            this.EntrarBoton.TabIndex = 31;
            this.EntrarBoton.Text = "Ejecutar";
            this.EntrarBoton.UseVisualStyleBackColor = false;
            this.EntrarBoton.Click += new System.EventHandler(this.EntrarBoton_Click);
            // 
            // LabelPedirBase
            // 
            this.LabelPedirBase.AutoSize = true;
            this.LabelPedirBase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPedirBase.Location = new System.Drawing.Point(96, 249);
            this.LabelPedirBase.Name = "LabelPedirBase";
            this.LabelPedirBase.Size = new System.Drawing.Size(178, 21);
            this.LabelPedirBase.TabIndex = 30;
            this.LabelPedirBase.Text = "Escribe el número base";
            // 
            // EscribirBaseTxtBox
            // 
            this.EscribirBaseTxtBox.Location = new System.Drawing.Point(131, 285);
            this.EscribirBaseTxtBox.Name = "EscribirBaseTxtBox";
            this.EscribirBaseTxtBox.Size = new System.Drawing.Size(136, 20);
            this.EscribirBaseTxtBox.TabIndex = 29;
            // 
            // labelDescripcionExpo
            // 
            this.labelDescripcionExpo.AutoSize = true;
            this.labelDescripcionExpo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionExpo.Location = new System.Drawing.Point(33, 137);
            this.labelDescripcionExpo.Name = "labelDescripcionExpo";
            this.labelDescripcionExpo.Size = new System.Drawing.Size(660, 25);
            this.labelDescripcionExpo.TabIndex = 28;
            this.labelDescripcionExpo.Text = "Este algortimo calcula el exponente de un numero dado a una potencia dada";
            // 
            // LabelTituloExpo
            // 
            this.LabelTituloExpo.AutoSize = true;
            this.LabelTituloExpo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTituloExpo.ForeColor = System.Drawing.Color.Snow;
            this.LabelTituloExpo.Location = new System.Drawing.Point(92, 68);
            this.LabelTituloExpo.Name = "LabelTituloExpo";
            this.LabelTituloExpo.Size = new System.Drawing.Size(398, 45);
            this.LabelTituloExpo.TabIndex = 27;
            this.LabelTituloExpo.Text = "Exponente de un numero";
            // 
            // FrmPotencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelPedirExponente);
            this.Controls.Add(this.ExcribirExponenteTxtBox);
            this.Controls.Add(this.ResultadoExpoTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EntrarBoton);
            this.Controls.Add(this.LabelPedirBase);
            this.Controls.Add(this.EscribirBaseTxtBox);
            this.Controls.Add(this.labelDescripcionExpo);
            this.Controls.Add(this.LabelTituloExpo);
            this.Name = "FrmPotencia";
            this.Text = "FrmPotencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPedirExponente;
        private System.Windows.Forms.TextBox ExcribirExponenteTxtBox;
        private System.Windows.Forms.TextBox ResultadoExpoTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EntrarBoton;
        private System.Windows.Forms.Label LabelPedirBase;
        private System.Windows.Forms.TextBox EscribirBaseTxtBox;
        private System.Windows.Forms.Label labelDescripcionExpo;
        private System.Windows.Forms.Label LabelTituloExpo;
    }
}