namespace EDDemo.Estructuras_Lineales
{
    partial class FrmPila
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
            this.TxInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.TxInPut = new System.Windows.Forms.TextBox();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtAñadir = new System.Windows.Forms.Button();
            this.TxResultado = new System.Windows.Forms.TextBox();
            this.BtPilaVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxInfo
            // 
            this.TxInfo.Location = new System.Drawing.Point(46, 384);
            this.TxInfo.Multiline = true;
            this.TxInfo.Name = "TxInfo";
            this.TxInfo.Size = new System.Drawing.Size(263, 31);
            this.TxInfo.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "escribe el dato que quieras";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(556, 36);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(61, 25);
            this.Titulo.TabIndex = 36;
            this.Titulo.Text = "PILA";
            // 
            // TxInPut
            // 
            this.TxInPut.Location = new System.Drawing.Point(46, 174);
            this.TxInPut.Name = "TxInPut";
            this.TxInPut.Size = new System.Drawing.Size(238, 20);
            this.TxInPut.TabIndex = 35;
            // 
            // BtEliminar
            // 
            this.BtEliminar.BackColor = System.Drawing.Color.Pink;
            this.BtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminar.Location = new System.Drawing.Point(46, 273);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtEliminar.TabIndex = 34;
            this.BtEliminar.Text = "Pop";
            this.BtEliminar.UseVisualStyleBackColor = false;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.BackColor = System.Drawing.Color.Pink;
            this.BtBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscar.Location = new System.Drawing.Point(46, 244);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtBuscar.TabIndex = 33;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtAñadir
            // 
            this.BtAñadir.BackColor = System.Drawing.Color.Pink;
            this.BtAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAñadir.Location = new System.Drawing.Point(46, 215);
            this.BtAñadir.Name = "BtAñadir";
            this.BtAñadir.Size = new System.Drawing.Size(75, 23);
            this.BtAñadir.TabIndex = 32;
            this.BtAñadir.Text = "Push";
            this.BtAñadir.UseVisualStyleBackColor = false;
            this.BtAñadir.Click += new System.EventHandler(this.BtAñadir_Click);
            // 
            // TxResultado
            // 
            this.TxResultado.BackColor = System.Drawing.Color.Pink;
            this.TxResultado.Location = new System.Drawing.Point(392, 66);
            this.TxResultado.Multiline = true;
            this.TxResultado.Name = "TxResultado";
            this.TxResultado.Size = new System.Drawing.Size(385, 349);
            this.TxResultado.TabIndex = 31;
            // 
            // BtPilaVaciar
            // 
            this.BtPilaVaciar.BackColor = System.Drawing.Color.Pink;
            this.BtPilaVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPilaVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPilaVaciar.Location = new System.Drawing.Point(24, 36);
            this.BtPilaVaciar.Name = "BtPilaVaciar";
            this.BtPilaVaciar.Size = new System.Drawing.Size(97, 48);
            this.BtPilaVaciar.TabIndex = 30;
            this.BtPilaVaciar.Text = "Limpiar";
            this.BtPilaVaciar.UseVisualStyleBackColor = false;
            this.BtPilaVaciar.Click += new System.EventHandler(this.BtPilaVaciar_Click);
            // 
            // FrmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.TxInPut);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.BtAñadir);
            this.Controls.Add(this.TxResultado);
            this.Controls.Add(this.BtPilaVaciar);
            this.Name = "FrmPila";
            this.Text = "FrmPilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TxInPut;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtAñadir;
        private System.Windows.Forms.TextBox TxResultado;
        private System.Windows.Forms.Button BtPilaVaciar;
    }
}