﻿using EDDemo.Recursividad.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Recursividad
{
    public partial class FrmFactorial : Form
    {
        public FrmFactorial()
        {
            InitializeComponent();
        }
        Factorial factorial = new Factorial();
        private void EntrarFactorial_Click(object sender, EventArgs e)
        {

        }
    }
}