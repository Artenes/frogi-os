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
    public partial class formTipoCadastro : formCadastro {
        
        public formTipoCadastro() : base() {
            InitializeComponent();
            base.pesquisa = new formTipoPesquisa();
        }

        protected override void salvaExecutar() {
            
        }

        protected override void editarRegistro() {
            base.editarRegistro();
        }

        protected override void excluiExecutar(){
            
        }

        protected override void resetar() {
            base.resetar();
        }

        protected override void campos(bool estaDisponivel){
            
        }

        protected override string validarCampos() {
            return base.validarCampos();
        }

    }
}
