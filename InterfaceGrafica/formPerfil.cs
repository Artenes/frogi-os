﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formPerfil : Form
    {
        public formPerfil()
        {
            InitializeComponent();
        }

        private void pictureSalvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
