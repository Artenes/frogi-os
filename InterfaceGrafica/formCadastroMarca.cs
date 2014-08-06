using System;
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
    public partial class formCadastroMarca : formCadastro
    {
        public formCadastroMarca(bool pesquisaHabilitado) : base (pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado)
                pesquisa = new formPesquisaMarca(this, false);
        }

        protected override void novoRegistro() {
            base.novoRegistro();
            this.ActiveControl = mARCA_DESCRICAOTextBox;
        }

        protected override void salvaExecutar() {
            base.salvaExecutar();
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            this.ActiveControl = mARCA_DESCRICAOTextBox;
        }

        protected override void excluiExecutar(){
            base.excluiExecutar();
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.MARCA.Clear();
            }
        }

        protected override void campos(bool estaDisponivel) {
            base.campos(estaDisponivel);
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
