﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FROGI_OS.InterfaceGrafica;

namespace FROGI_OS
{
    public partial class formCadastroFuncionario : formCadastro
    {

        public formCadastroFuncionario(bool pesquisaHabilitado) : base (pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado)
                pesquisa = new formPesquisaFuncionario(this, false);
        }

        protected override void salvaExecutar() {
            base.salvaExecutar();
        }

        protected override void editarRegistro() {
            base.editarRegistro();
        }

        protected override void excluiExecutar() {
            base.excluiExecutar();
        }

        protected override void resetar() {
            base.resetar();
        }

        protected override void campos(bool estaDisponivel){
            base.campos(estaDisponivel);
        }

        protected override string validarCampos() {
            return base.validarCampos();
        }

        protected override void visualizarRegistroExecutar(int codigo)
        {
            base.visualizarRegistroExecutar(codigo);
        }

    }
}
