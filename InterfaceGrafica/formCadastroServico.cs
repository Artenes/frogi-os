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
    public partial class formCadastroServico : formCadastro
    {
        public formCadastroServico(bool pesquisaHabilitado) : base(pesquisaHabilitado)
        {
            InitializeComponent();
            if (pesquisaHabilitado)
                pesquisa = new formPesquisaServico(this, false);
        }

        protected override void novoRegistro()
        {
            base.novoRegistro();
            this.ActiveControl = sERVICO_DESCRICAOTextBox;
        }

        protected override void salvaExecutar()
        {
            base.salvaExecutar();
        }

        protected override void editarRegistro()
        {
            base.editarRegistro();
            this.ActiveControl = sERVICO_DESCRICAOTextBox;
        }

        protected override void excluiExecutar()
        {
            base.excluiExecutar();
        }

        protected override void resetar()
        {
            base.resetar();
            if (dsFROGIOS != null)
            {
                dsFROGIOS.SERVICO.Clear();
                dsFROGIOS.TIPO.Clear();
                dsFROGIOS.SERVICO_TIPO.Clear();
            }
        }

        protected override void campos(bool estaDisponivel)
        {
            base.campos(estaDisponivel);
        }

        protected override string validarCampos()
        {
            return base.validarCampos();
        }

        public override void visualizarRegistro(int codigo)
        {
            base.visualizarRegistro(codigo);
        }

        private void buttonAdicionarTipo_Click(object sender, EventArgs e)
        {

        }
    }

}