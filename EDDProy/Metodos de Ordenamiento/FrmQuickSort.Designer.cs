namespace EDDemo.Metodos_de_Ordenamiento
{
    partial class FrmQuickSort
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
            this.BtnOrdenarLista = new System.Windows.Forms.Button();
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
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(100, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 66;
            this.label1.Text = "QUICKSORT";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(12, 409);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(78, 20);
            this.txtTiempo.TabIndex = 65;
            // 
            // BtnOrdenarLista
            // 
            this.BtnOrdenarLista.BackColor = System.Drawing.Color.Pink;
            this.BtnOrdenarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrdenarLista.Location = new System.Drawing.Point(193, 271);
            this.BtnOrdenarLista.Name = "BtnOrdenarLista";
            this.BtnOrdenarLista.Size = new System.Drawing.Size(106, 40);
            this.BtnOrdenarLista.TabIndex = 64;
            this.BtnOrdenarLista.Text = "Ordenar";
            this.BtnOrdenarLista.UseVisualStyleBackColor = false;
            this.BtnOrdenarLista.Click += new System.EventHandler(this.BtnOrdenarLista_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 63;
            this.label6.Text = "Lista ordenada";
            // 
            // TxtListaOrdenada
            // 
            this.TxtListaOrdenada.BackColor = System.Drawing.Color.Pink;
            this.TxtListaOrdenada.Location = new System.Drawing.Point(416, 282);
            this.TxtListaOrdenada.Multiline = true;
            this.TxtListaOrdenada.Name = "TxtListaOrdenada";
            this.TxtListaOrdenada.Size = new System.Drawing.Size(360, 156);
            this.TxtListaOrdenada.TabIndex = 62;
            // 
            // BtnGenerarLista
            // 
            this.BtnGenerarLista.BackColor = System.Drawing.Color.Pink;
            this.BtnGenerarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarLista.Location = new System.Drawing.Point(50, 271);
            this.BtnGenerarLista.Name = "BtnGenerarLista";
            this.BtnGenerarLista.Size = new System.Drawing.Size(106, 40);
            this.BtnGenerarLista.TabIndex = 61;
            this.BtnGenerarLista.Text = "Generar lista";
            this.BtnGenerarLista.UseVisualStyleBackColor = false;
            this.BtnGenerarLista.Click += new System.EventHandler(this.BtnGenerarLista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 60;
            this.label3.Text = "Num. de elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "Lista";
            // 
            // TxtLista
            // 
            this.TxtLista.BackColor = System.Drawing.Color.Pink;
            this.TxtLista.Location = new System.Drawing.Point(416, 85);
            this.TxtLista.Multiline = true;
            this.TxtLista.Name = "TxtLista";
            this.TxtLista.Size = new System.Drawing.Size(360, 133);
            this.TxtLista.TabIndex = 58;
            // 
            // TxtNumeroElementos
            // 
            this.TxtNumeroElementos.Location = new System.Drawing.Point(50, 245);
            this.TxtNumeroElementos.Name = "TxtNumeroElementos";
            this.TxtNumeroElementos.Size = new System.Drawing.Size(249, 20);
            this.TxtNumeroElementos.TabIndex = 57;
            // 
            // FrmQuickSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.BtnOrdenarLista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtListaOrdenada);
            this.Controls.Add(this.BtnGenerarLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLista);
            this.Controls.Add(this.TxtNumeroElementos);
            this.Name = "FrmQuickSort";
            this.Text = "FrmQuickSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Button BtnOrdenarLista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtListaOrdenada;
        private System.Windows.Forms.Button BtnGenerarLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLista;
        private System.Windows.Forms.TextBox TxtNumeroElementos;
    }
}