using System;
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
    public partial class formCadastroProduto : formCadastro
    {

        public formCadastroProduto(bool pesquisaHabilitado) : base(pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado)
                pesquisa = new formPesquisaProduto(this, false);
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

        protected override void campos(bool estaDisponivel) {
            panelCentro.Enabled = estaDisponivel;
            panelCodigo.Visible = estaDisponivel;
        }

        protected override string validarCampos() {
            return base.validarCampos();
        }

       public override void visualizarRegistro(int codigo)
        {
            base.visualizarRegistro(codigo);
        }
    }
}
