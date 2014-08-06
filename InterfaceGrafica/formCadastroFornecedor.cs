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
    public partial class formCadastroFornecedor : formCadastro
    {

        private readonly int FISICO = 0;
        private readonly int JURIDICO = 1;

        public formCadastroFornecedor(bool pesquisaHabilitado) : base (pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado)
                pesquisa = new formPesquisaFornecedor(this, false); 
            comboTipo.Enabled = false;
        }

        protected override void novoRegistro() {
            base.novoRegistro();
            comboTipo.SelectedIndex = FISICO;
            this.ActiveControl = fORNECEDOR_FISICO_NOMETextBox;
        }

        protected override void salvaExecutar() {
            base.salvaExecutar();
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            if (comboTipo.SelectedIndex == FISICO) {
                this.ActiveControl = fORNECEDOR_FISICO_NOMETextBox;
            }
            else {
                this.ActiveControl = fORNECEDOR_JURIDICO_RAZ_SOCTextBox;
            }
        }

        protected override void excluiExecutar() {
            base.excluiExecutar();
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.FORNECEDOR.Clear();
                dsFROGIOS.FORNECEDOR_FISICO.Clear();
                dsFROGIOS.FORNECEDOR_JURIDICO.Clear();
                dsFROGIOS.UF.Clear();
            }
        }

        protected override void campos(bool estaDisponivel) {
            base.campos(estaDisponivel);
            if (comboTipo != null) {
                comboTipo.Enabled = estaDisponivel;    
            }
            
        }

        protected override string validarCampos() {
            return base.validarCampos();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox comboBox = (ComboBox) sender;
            if (comboBox != null) {
                object item = comboBox.SelectedItem;
                if (item != null && item.ToString() == "Físico") {
                    tablessPai.SelectedTab = tabFisico;
                } else if (item != null && item.ToString() == "Jurídico") {
                    tablessPai.SelectedTab = tabJuridico;
                }
            }
        }

        public override void visualizarRegistro(int codigo)
        {
            base.visualizarRegistro(codigo);
        }
    }
}
