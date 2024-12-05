namespace EDDemo.Metodos_de_Ordenamiento
{
    partial class FrmMezclaNatural
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
            this.TxtTiempo = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtListaOrdenada = new System.Windows.Forms.TextBox();
            this.BtnGenerarLista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLista = new System.Windows.Forms.TextBox();
            this.TxtNumeroElementos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 88;
            this.label1.Text = "MEZCLA NATURAL";
            // 
            // TxtTiempo
            // 
            this.TxtTiempo.Location = new System.Drawing.Point(12, 418);
            this.TxtTiempo.Name = "TxtTiempo";
            this.TxtTiempo.ReadOnly = true;
            this.TxtTiempo.Size = new System.Drawing.Size(78, 20);
            this.TxtTiempo.TabIndex = 87;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Pink;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.Location = new System.Drawing.Point(182, 243);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(136, 50);
            this.btnOrdenar.TabIndex = 86;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(546, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 85;
            this.label6.Text = "Lista ordenada";
            // 
            // TxtListaOrdenada
            // 
            this.TxtListaOrdenada.BackColor = System.Drawing.Color.Pink;
            this.TxtListaOrdenada.Location = new System.Drawing.Point(428, 232);
            this.TxtListaOrdenada.Multiline = true;
            this.TxtListaOrdenada.Name = "TxtListaOrdenada";
            this.TxtListaOrdenada.Size = new System.Drawing.Size(360, 212);
            this.TxtListaOrdenada.TabIndex = 84;
            // 
            // BtnGenerarLista
            // 
            this.BtnGenerarLista.BackColor = System.Drawing.Color.Pink;
            this.BtnGenerarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarLista.Location = new System.Drawing.Point(51, 243);
            this.BtnGenerarLista.Name = "BtnGenerarLista";
            this.BtnGenerarLista.Size = new System.Drawing.Size(119, 50);
            this.BtnGenerarLista.TabIndex = 83;
            this.BtnGenerarLista.Text = "Generar lista";
            this.BtnGenerarLista.UseVisualStyleBackColor = false;
            this.BtnGenerarLista.Click += new System.EventHandler(this.BtnGenerarLista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 82;
            this.label3.Text = "Num. de elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 81;
            this.label2.Text = "Lista";
            // 
            // TxtLista
            // 
            this.TxtLista.BackColor = System.Drawing.Color.Pink;
            this.TxtLista.Location = new System.Drawing.Point(428, 40);
            this.TxtLista.Multiline = true;
            this.TxtLista.Name = "TxtLista";
            this.TxtLista.Size = new System.Drawing.Size(360, 159);
            this.TxtLista.TabIndex = 80;
            // 
            // TxtNumeroElementos
            // 
            this.TxtNumeroElementos.Location = new System.Drawing.Point(51, 217);
            this.TxtNumeroElementos.Name = "TxtNumeroElementos";
            this.TxtNumeroElementos.Size = new System.Drawing.Size(267, 20);
            this.TxtNumeroElementos.TabIndex = 79;
            // 
            // FrmMezclaNatural
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTiempo);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtListaOrdenada);
            this.Controls.Add(this.BtnGenerarLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLista);
            this.Controls.Add(this.TxtNumeroElementos);
            this.Name = "FrmMezclaNatural";
            this.Text = "FrmMezclaNatural";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTiempo;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtListaOrdenada;
        private System.Windows.Forms.Button BtnGenerarLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLista;
        private System.Windows.Forms.TextBox TxtNumeroElementos;
    }
}