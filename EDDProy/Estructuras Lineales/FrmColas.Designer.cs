namespace EDDemo.Estructuras_Lineales
{
    partial class FrmColas
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
            this.BtDequeue = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtQueue = new System.Windows.Forms.Button();
            this.TxResultado = new System.Windows.Forms.TextBox();
            this.BtColaVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxInfo
            // 
            this.TxInfo.Location = new System.Drawing.Point(538, 392);
            this.TxInfo.Multiline = true;
            this.TxInfo.Name = "TxInfo";
            this.TxInfo.Size = new System.Drawing.Size(201, 35);
            this.TxInfo.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Escriba un dato";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(202, 59);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(73, 25);
            this.Titulo.TabIndex = 47;
            this.Titulo.Text = "COLA";
            // 
            // TxInPut
            // 
            this.TxInPut.Location = new System.Drawing.Point(453, 221);
            this.TxInPut.Name = "TxInPut";
            this.TxInPut.Size = new System.Drawing.Size(206, 20);
            this.TxInPut.TabIndex = 46;
            // 
            // BtDequeue
            // 
            this.BtDequeue.BackColor = System.Drawing.Color.Pink;
            this.BtDequeue.Location = new System.Drawing.Point(679, 247);
            this.BtDequeue.Name = "BtDequeue";
            this.BtDequeue.Size = new System.Drawing.Size(96, 32);
            this.BtDequeue.TabIndex = 45;
            this.BtDequeue.Text = "Dequeue";
            this.BtDequeue.UseVisualStyleBackColor = false;
            // 
            // BtBuscar
            // 
            this.BtBuscar.BackColor = System.Drawing.Color.Pink;
            this.BtBuscar.Location = new System.Drawing.Point(679, 208);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(96, 33);
            this.BtBuscar.TabIndex = 44;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = false;
            // 
            // BtQueue
            // 
            this.BtQueue.BackColor = System.Drawing.Color.Pink;
            this.BtQueue.Location = new System.Drawing.Point(679, 168);
            this.BtQueue.Name = "BtQueue";
            this.BtQueue.Size = new System.Drawing.Size(96, 34);
            this.BtQueue.TabIndex = 43;
            this.BtQueue.Text = "Queue";
            this.BtQueue.UseVisualStyleBackColor = false;
            // 
            // TxResultado
            // 
            this.TxResultado.BackColor = System.Drawing.Color.Pink;
            this.TxResultado.Location = new System.Drawing.Point(38, 89);
            this.TxResultado.Multiline = true;
            this.TxResultado.Name = "TxResultado";
            this.TxResultado.Size = new System.Drawing.Size(385, 349);
            this.TxResultado.TabIndex = 42;
            // 
            // BtColaVaciar
            // 
            this.BtColaVaciar.BackColor = System.Drawing.Color.Pink;
            this.BtColaVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtColaVaciar.Location = new System.Drawing.Point(26, 12);
            this.BtColaVaciar.Name = "BtColaVaciar";
            this.BtColaVaciar.Size = new System.Drawing.Size(97, 48);
            this.BtColaVaciar.TabIndex = 41;
            this.BtColaVaciar.Text = "Limpiar";
            this.BtColaVaciar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtColaVaciar.UseVisualStyleBackColor = false;
            // 
            // FrmColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.TxInPut);
            this.Controls.Add(this.BtDequeue);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.BtQueue);
            this.Controls.Add(this.TxResultado);
            this.Controls.Add(this.BtColaVaciar);
            this.Name = "FrmColas";
            this.Text = "FrmColas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TxInPut;
        private System.Windows.Forms.Button BtDequeue;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtQueue;
        private System.Windows.Forms.TextBox TxResultado;
        private System.Windows.Forms.Button BtColaVaciar;
    }
}