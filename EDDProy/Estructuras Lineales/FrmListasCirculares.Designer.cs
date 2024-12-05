namespace EDDemo.Estructuras_Lineales
{
    partial class FrmListasCirculares
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
            this.TxPosicion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.TxInPut = new System.Windows.Forms.TextBox();
            this.BtEliminarPosicion = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtInsetarPosicion = new System.Windows.Forms.Button();
            this.TxResultado = new System.Windows.Forms.TextBox();
            this.BtListaCVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxPosicion
            // 
            this.TxPosicion.Location = new System.Drawing.Point(455, 249);
            this.TxPosicion.Name = "TxPosicion";
            this.TxPosicion.Size = new System.Drawing.Size(152, 20);
            this.TxPosicion.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Posicion";
            // 
            // TxInfo
            // 
            this.TxInfo.Location = new System.Drawing.Point(521, 402);
            this.TxInfo.Multiline = true;
            this.TxInfo.Name = "TxInfo";
            this.TxInfo.Size = new System.Drawing.Size(193, 36);
            this.TxInfo.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Dato";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(138, 60);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(196, 25);
            this.Titulo.TabIndex = 81;
            this.Titulo.Text = "LISTA CIRCULAR";
            // 
            // TxInPut
            // 
            this.TxInPut.Location = new System.Drawing.Point(455, 175);
            this.TxInPut.Name = "TxInPut";
            this.TxInPut.Size = new System.Drawing.Size(152, 20);
            this.TxInPut.TabIndex = 80;
            // 
            // BtEliminarPosicion
            // 
            this.BtEliminarPosicion.BackColor = System.Drawing.Color.Pink;
            this.BtEliminarPosicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminarPosicion.Location = new System.Drawing.Point(629, 201);
            this.BtEliminarPosicion.Name = "BtEliminarPosicion";
            this.BtEliminarPosicion.Size = new System.Drawing.Size(164, 42);
            this.BtEliminarPosicion.TabIndex = 79;
            this.BtEliminarPosicion.Text = "Eliminar una posicion";
            this.BtEliminarPosicion.UseVisualStyleBackColor = false;
            this.BtEliminarPosicion.Click += new System.EventHandler(this.BtEliminarPosicion_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.BackColor = System.Drawing.Color.Pink;
            this.BtBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscar.Location = new System.Drawing.Point(629, 249);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(164, 42);
            this.BtBuscar.TabIndex = 78;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtInsetarPosicion
            // 
            this.BtInsetarPosicion.BackColor = System.Drawing.Color.Pink;
            this.BtInsetarPosicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtInsetarPosicion.Location = new System.Drawing.Point(629, 153);
            this.BtInsetarPosicion.Name = "BtInsetarPosicion";
            this.BtInsetarPosicion.Size = new System.Drawing.Size(164, 42);
            this.BtInsetarPosicion.TabIndex = 77;
            this.BtInsetarPosicion.Text = "Insetar en posicion";
            this.BtInsetarPosicion.UseVisualStyleBackColor = false;
            this.BtInsetarPosicion.Click += new System.EventHandler(this.BtInsetarPosicion_Click);
            // 
            // TxResultado
            // 
            this.TxResultado.BackColor = System.Drawing.Color.Pink;
            this.TxResultado.Location = new System.Drawing.Point(39, 90);
            this.TxResultado.Multiline = true;
            this.TxResultado.Name = "TxResultado";
            this.TxResultado.Size = new System.Drawing.Size(385, 349);
            this.TxResultado.TabIndex = 76;
            // 
            // BtListaCVaciar
            // 
            this.BtListaCVaciar.BackColor = System.Drawing.Color.Pink;
            this.BtListaCVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtListaCVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtListaCVaciar.Location = new System.Drawing.Point(7, 12);
            this.BtListaCVaciar.Name = "BtListaCVaciar";
            this.BtListaCVaciar.Size = new System.Drawing.Size(97, 48);
            this.BtListaCVaciar.TabIndex = 75;
            this.BtListaCVaciar.Text = "Limpiar";
            this.BtListaCVaciar.UseVisualStyleBackColor = false;
            this.BtListaCVaciar.Click += new System.EventHandler(this.BtListaCVaciar_Click);
            // 
            // FrmListasCirculares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxPosicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.TxInPut);
            this.Controls.Add(this.BtEliminarPosicion);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.BtInsetarPosicion);
            this.Controls.Add(this.TxResultado);
            this.Controls.Add(this.BtListaCVaciar);
            this.Name = "FrmListasCirculares";
            this.Text = "FrmListaCircular";
            this.Load += new System.EventHandler(this.FrmListasCirculares_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxPosicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TxInPut;
        private System.Windows.Forms.Button BtEliminarPosicion;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtInsetarPosicion;
        private System.Windows.Forms.TextBox TxResultado;
        private System.Windows.Forms.Button BtListaCVaciar;
    }
}