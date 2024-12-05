namespace EDDemo.Metodos_de_Ordenamiento
{
    partial class FrmIntercalacion
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
            this.BtnIntercalarArchivos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtArchivoIntercalado = new System.Windows.Forms.TextBox();
            this.BtnGenerarArchivo2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtArchivo2 = new System.Windows.Forms.TextBox();
            this.TxtNumElementosArchivo2 = new System.Windows.Forms.TextBox();
            this.BtnGenerarArchivo1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtArchivo1 = new System.Windows.Forms.TextBox();
            this.TxtNumElementosArchivo1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 77;
            this.label1.Text = "INTERCALACION";
            // 
            // TxtTiempo
            // 
            this.TxtTiempo.Location = new System.Drawing.Point(12, 418);
            this.TxtTiempo.Name = "TxtTiempo";
            this.TxtTiempo.ReadOnly = true;
            this.TxtTiempo.Size = new System.Drawing.Size(78, 20);
            this.TxtTiempo.TabIndex = 76;
            // 
            // BtnIntercalarArchivos
            // 
            this.BtnIntercalarArchivos.BackColor = System.Drawing.Color.Pink;
            this.BtnIntercalarArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIntercalarArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIntercalarArchivos.Location = new System.Drawing.Point(315, 204);
            this.BtnIntercalarArchivos.Name = "BtnIntercalarArchivos";
            this.BtnIntercalarArchivos.Size = new System.Drawing.Size(153, 28);
            this.BtnIntercalarArchivos.TabIndex = 75;
            this.BtnIntercalarArchivos.Text = "Intercalar Archivos";
            this.BtnIntercalarArchivos.UseVisualStyleBackColor = false;
            this.BtnIntercalarArchivos.Click += new System.EventHandler(this.BtnIntercalarArchivos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 74;
            this.label6.Text = "Archivo intercalado";
            // 
            // TxtArchivoIntercalado
            // 
            this.TxtArchivoIntercalado.BackColor = System.Drawing.Color.Pink;
            this.TxtArchivoIntercalado.Location = new System.Drawing.Point(228, 259);
            this.TxtArchivoIntercalado.Multiline = true;
            this.TxtArchivoIntercalado.Name = "TxtArchivoIntercalado";
            this.TxtArchivoIntercalado.Size = new System.Drawing.Size(348, 179);
            this.TxtArchivoIntercalado.TabIndex = 73;
            // 
            // BtnGenerarArchivo2
            // 
            this.BtnGenerarArchivo2.BackColor = System.Drawing.Color.Pink;
            this.BtnGenerarArchivo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarArchivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarArchivo2.Location = new System.Drawing.Point(549, 94);
            this.BtnGenerarArchivo2.Name = "BtnGenerarArchivo2";
            this.BtnGenerarArchivo2.Size = new System.Drawing.Size(94, 28);
            this.BtnGenerarArchivo2.TabIndex = 72;
            this.BtnGenerarArchivo2.Text = "Generar";
            this.BtnGenerarArchivo2.UseVisualStyleBackColor = false;
            this.BtnGenerarArchivo2.Click += new System.EventHandler(this.BtnGenerarArchivo2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 18);
            this.label4.TabIndex = 71;
            this.label4.Text = "Numero de Elementos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 70;
            this.label5.Text = "Archivo 2";
            // 
            // TxtArchivo2
            // 
            this.TxtArchivo2.BackColor = System.Drawing.Color.Pink;
            this.TxtArchivo2.Location = new System.Drawing.Point(417, 124);
            this.TxtArchivo2.Multiline = true;
            this.TxtArchivo2.Name = "TxtArchivo2";
            this.TxtArchivo2.Size = new System.Drawing.Size(360, 74);
            this.TxtArchivo2.TabIndex = 69;
            // 
            // TxtNumElementosArchivo2
            // 
            this.TxtNumElementosArchivo2.Location = new System.Drawing.Point(476, 72);
            this.TxtNumElementosArchivo2.Name = "TxtNumElementosArchivo2";
            this.TxtNumElementosArchivo2.Size = new System.Drawing.Size(226, 20);
            this.TxtNumElementosArchivo2.TabIndex = 68;
            // 
            // BtnGenerarArchivo1
            // 
            this.BtnGenerarArchivo1.BackColor = System.Drawing.Color.Pink;
            this.BtnGenerarArchivo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarArchivo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarArchivo1.Location = new System.Drawing.Point(144, 94);
            this.BtnGenerarArchivo1.Name = "BtnGenerarArchivo1";
            this.BtnGenerarArchivo1.Size = new System.Drawing.Size(94, 28);
            this.BtnGenerarArchivo1.TabIndex = 67;
            this.BtnGenerarArchivo1.Text = "Generar";
            this.BtnGenerarArchivo1.UseVisualStyleBackColor = false;
            this.BtnGenerarArchivo1.Click += new System.EventHandler(this.BtnGenerarArchivo1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 66;
            this.label3.Text = "Numero de Elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 65;
            this.label2.Text = "Archivo 1";
            // 
            // TxtArchivo1
            // 
            this.TxtArchivo1.BackColor = System.Drawing.Color.Pink;
            this.TxtArchivo1.Location = new System.Drawing.Point(12, 124);
            this.TxtArchivo1.Multiline = true;
            this.TxtArchivo1.Name = "TxtArchivo1";
            this.TxtArchivo1.Size = new System.Drawing.Size(360, 69);
            this.TxtArchivo1.TabIndex = 64;
            // 
            // TxtNumElementosArchivo1
            // 
            this.TxtNumElementosArchivo1.Location = new System.Drawing.Point(82, 72);
            this.TxtNumElementosArchivo1.Name = "TxtNumElementosArchivo1";
            this.TxtNumElementosArchivo1.Size = new System.Drawing.Size(216, 20);
            this.TxtNumElementosArchivo1.TabIndex = 63;
            // 
            // FrmIntercalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTiempo);
            this.Controls.Add(this.BtnIntercalarArchivos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtArchivoIntercalado);
            this.Controls.Add(this.BtnGenerarArchivo2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtArchivo2);
            this.Controls.Add(this.TxtNumElementosArchivo2);
            this.Controls.Add(this.BtnGenerarArchivo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtArchivo1);
            this.Controls.Add(this.TxtNumElementosArchivo1);
            this.Name = "FrmIntercalacion";
            this.Text = "FrmIntercalación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTiempo;
        private System.Windows.Forms.Button BtnIntercalarArchivos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtArchivoIntercalado;
        private System.Windows.Forms.Button BtnGenerarArchivo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtArchivo2;
        private System.Windows.Forms.TextBox TxtNumElementosArchivo2;
        private System.Windows.Forms.Button BtnGenerarArchivo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtArchivo1;
        private System.Windows.Forms.TextBox TxtNumElementosArchivo1;
    }
}