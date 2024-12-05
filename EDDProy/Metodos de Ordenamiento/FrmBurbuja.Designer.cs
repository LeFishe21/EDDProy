namespace EDDemo.Metodos_de_Ordenamiento
{
    partial class FrmBurbuja
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.btnOrdenarLista = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtListaOrdenada = new System.Windows.Forms.TextBox();
            this.btnGenerarLista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.txtInPut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(225, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 29);
            this.label1.TabIndex = 77;
            this.label1.Text = "ORDENAMIENTO DE BURBUJA";
            // 
            // txtTiempo
            // 
            this.txtTiempo.BackColor = System.Drawing.Color.White;
            this.txtTiempo.Location = new System.Drawing.Point(18, 429);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(78, 20);
            this.txtTiempo.TabIndex = 76;
            // 
            // btnOrdenarLista
            // 
            this.btnOrdenarLista.BackColor = System.Drawing.Color.Pink;
            this.btnOrdenarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarLista.Location = new System.Drawing.Point(412, 143);
            this.btnOrdenarLista.Name = "btnOrdenarLista";
            this.btnOrdenarLista.Size = new System.Drawing.Size(125, 30);
            this.btnOrdenarLista.TabIndex = 75;
            this.btnOrdenarLista.Text = "Ordenar";
            this.btnOrdenarLista.UseVisualStyleBackColor = false;
            this.btnOrdenarLista.Click += new System.EventHandler(this.btnOrdenarLista_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 74;
            this.label6.Text = "Lista ordenada";
            // 
            // txtListaOrdenada
            // 
            this.txtListaOrdenada.BackColor = System.Drawing.Color.Pink;
            this.txtListaOrdenada.Location = new System.Drawing.Point(443, 224);
            this.txtListaOrdenada.Multiline = true;
            this.txtListaOrdenada.Name = "txtListaOrdenada";
            this.txtListaOrdenada.Size = new System.Drawing.Size(330, 199);
            this.txtListaOrdenada.TabIndex = 73;
            // 
            // btnGenerarLista
            // 
            this.btnGenerarLista.BackColor = System.Drawing.Color.Pink;
            this.btnGenerarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarLista.Location = new System.Drawing.Point(281, 143);
            this.btnGenerarLista.Name = "btnGenerarLista";
            this.btnGenerarLista.Size = new System.Drawing.Size(125, 30);
            this.btnGenerarLista.TabIndex = 72;
            this.btnGenerarLista.Text = "Generar";
            this.btnGenerarLista.UseVisualStyleBackColor = false;
            this.btnGenerarLista.Click += new System.EventHandler(this.btnGenerarLista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 71;
            this.label3.Text = "Elementos de la lista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "LISTA";
            // 
            // txtLista
            // 
            this.txtLista.BackColor = System.Drawing.Color.Pink;
            this.txtLista.Location = new System.Drawing.Point(18, 224);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(360, 199);
            this.txtLista.TabIndex = 69;
            // 
            // txtInPut
            // 
            this.txtInPut.Location = new System.Drawing.Point(230, 107);
            this.txtInPut.Name = "txtInPut";
            this.txtInPut.Size = new System.Drawing.Size(360, 20);
            this.txtInPut.TabIndex = 68;
            // 
            // FrmBurbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.btnOrdenarLista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtListaOrdenada);
            this.Controls.Add(this.btnGenerarLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.txtInPut);
            this.Name = "FrmBurbuja";
            this.Text = "FrmBurbuja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Button btnOrdenarLista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtListaOrdenada;
        private System.Windows.Forms.Button btnGenerarLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.TextBox txtInPut;
    }
}