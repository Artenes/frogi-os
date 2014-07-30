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
    public partial class formProdutoCadastro : formCadastro
    {

        public formProdutoCadastro() : base() {
            InitializeComponent();
            pesquisa = new formProdutoPesquisa();
        }

        protected override void salvaExecutar() {
            
        }

        protected override void editarRegistro() {
            base.editarRegistro();
        }

        protected override void excluiExecutar() {
            
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
    }
}
