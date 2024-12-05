namespace EDDemo.Recursividad
{
    partial class FrmTorresDeHanoi
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
            this.ResultadoHanoiTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btEjecutarHanoi = new System.Windows.Forms.Button();
            this.labelPedirDiscos = new System.Windows.Forms.Label();
            this.LeerDiscosTxtBox = new System.Windows.Forms.TextBox();
            this.TituloHanoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultadoHanoiTxtBox
            // 
            this.ResultadoHanoiTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoHanoiTxtBox.Location = new System.Drawing.Point(60, 268);
            this.ResultadoHanoiTxtBox.Multiline = true;
            this.ResultadoHanoiTxtBox.Name = "ResultadoHanoiTxtBox";
            this.ResultadoHanoiTxtBox.Size = new System.Drawing.Size(706, 143);
            this.ResultadoHanoiTxtBox.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 37;
            // 
            // btEjecutarHanoi
            // 
            this.btEjecutarHanoi.BackColor = System.Drawing.Color.Pink;
            this.btEjecutarHanoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEjecutarHanoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEjecutarHanoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEjecutarHanoi.Location = new System.Drawing.Point(370, 185);
            this.btEjecutarHanoi.Name = "btEjecutarHanoi";
            this.btEjecutarHanoi.Size = new System.Drawing.Size(75, 34);
            this.btEjecutarHanoi.TabIndex = 36;
            this.btEjecutarHanoi.Text = "Ejecutar";
            this.btEjecutarHanoi.UseVisualStyleBackColor = false;
            this.btEjecutarHanoi.Click += new System.EventHandler(this.btEjecutarHanoi_Click);
            // 
            // labelPedirDiscos
            // 
            this.labelPedirDiscos.AutoSize = true;
            this.labelPedirDiscos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedirDiscos.Location = new System.Drawing.Point(105, 132);
            this.labelPedirDiscos.Name = "labelPedirDiscos";
            this.labelPedirDiscos.Size = new System.Drawing.Size(302, 21);
            this.labelPedirDiscos.TabIndex = 35;
            this.labelPedirDiscos.Text = "Escribe el número de discos que quieras";
            // 
            // LeerDiscosTxtBox
            // 
            this.LeerDiscosTxtBox.Location = new System.Drawing.Point(174, 195);
            this.LeerDiscosTxtBox.Name = "LeerDiscosTxtBox";
            this.LeerDiscosTxtBox.Size = new System.Drawing.Size(136, 20);
            this.LeerDiscosTxtBox.TabIndex = 34;
            // 
            // TituloHanoi
            // 
            this.TituloHanoi.AutoSize = true;
            this.TituloHanoi.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloHanoi.ForeColor = System.Drawing.Color.Snow;
            this.TituloHanoi.Location = new System.Drawing.Point(34, 39);
            this.TituloHanoi.Name = "TituloHanoi";
            this.TituloHanoi.Size = new System.Drawing.Size(310, 45);
            this.TituloHanoi.TabIndex = 33;
            this.TituloHanoi.Text = "Las torres de Hanoi";
            // 
            // FrmTorresDeHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultadoHanoiTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btEjecutarHanoi);
            this.Controls.Add(this.labelPedirDiscos);
            this.Controls.Add(this.LeerDiscosTxtBox);
            this.Controls.Add(this.TituloHanoi);
            this.Name = "FrmTorresDeHanoi";
            this.Text = "FrmTorresDeHanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultadoHanoiTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btEjecutarHanoi;
        private System.Windows.Forms.Label labelPedirDiscos;
        private System.Windows.Forms.TextBox LeerDiscosTxtBox;
        private System.Windows.Forms.Label TituloHanoi;
    }
}