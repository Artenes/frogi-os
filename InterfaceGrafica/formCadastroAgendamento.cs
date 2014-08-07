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
    public partial class formCadastroAgendamento : formCadastro
    {
        public formCadastroAgendamento(bool pesquisaHabilitado) : base (pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado) {
                pesquisa = new formPesquisaAgendamento(this, false);
            }
        }

        protected override void salvaExecutar() {
            base.salvaExecutar();
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            this.ActiveControl = textCliente;
        }

        protected override void excluiExecutar() {
            base.excluiExecutar();
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null)
            {
                dsFROGIOS.AGENDAMENTO.Clear();
                textCliente.Text = "";
                textTelefone.Text = "";
                textCelular.Text = "";
            }
        }

        protected override void campos(bool estaDisponivel) {
            base.campos(estaDisponivel);
            if (textCliente != null)
            {
                textCliente.Enabled = estaDisponivel;    
            }
            
        }

        protected override string validarCampos() {
            return base.validarCampos();
        }

        public override void visualizarRegistro(int codigo) {
            base.visualizarRegistro(codigo);
        }
    }
}
