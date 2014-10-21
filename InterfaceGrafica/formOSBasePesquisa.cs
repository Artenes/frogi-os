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
    public partial class formOSBasePesquisa : Form {

        private formDialogo dialogo;

        public formOSBasePesquisa() {
            InitializeComponent();
            resetar();
            dialogo = new formDialogo();
        }

        protected void exibirMensagemErro(String mensagem) {
            dialogo.compor("Temos um problema", mensagem, formDialogo.TipoExpressao.AvisoTriste);
            dialogo.ShowDialog();
        }

        protected virtual void preencherCampoPesquisa(bool eFisico) { }
        protected virtual void pesquisar() { }
        protected virtual void novoRegistro() { }

        protected virtual void resetar() {
            this.ActiveControl = comboTipoCliente;
            textValorPesquisa.Text = "";
            textValorPesquisa.Enabled = false;
            buttonPesquisar.Enabled = false;
        }

        private void comboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox) sender;
            if (comboBox != null) {
                object item = comboBox.SelectedItem;
                if (item != null)  {
                    comboCampoPesquisa.Items.Clear();
                    if (item.ToString() == "Físico") {
                        tablessPai.SelectedTab = tabFisico;
                        preencherCampoPesquisa(true);
                    }
                    else {
                        tablessPai.SelectedTab = tabJuridico;
                        preencherCampoPesquisa(false);
                    }
                    comboCampoPesquisa.Enabled = true;
                    textValorPesquisa.Enabled = false;
                    buttonPesquisar.Enabled = false;
                }
            }
            this.ActiveControl = comboTipoCliente;
        }

        protected virtual void comboCampoPesquisa_SelectedIndexChanged(object sender, EventArgs e) {
            textValorPesquisa.Enabled = true;
            buttonPesquisar.Enabled = true;
        }

        private void textValorPesquisa_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                pesquisar();
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e) {
            pesquisar();
        }

        private void buttonNovoRegistro_Click(object sender, EventArgs e) {
            formDialogo dialogo = new formDialogo("Deseja lançar um novo registro?", "", formDialogo.TipoExpressao.Pergunta);
            if (dialogo.ShowDialog() == DialogResult.Yes) {
                novoRegistro();
            }
            else {
                dialogo.Dispose();
            }
        }

        private void formOSBasePesquisa_FormClosing(object sender, FormClosingEventArgs e) {
            formDialogo dialogo = new formDialogo("Tem certeza que quer sair?", "", formDialogo.TipoExpressao.Pergunta);
            if (dialogo.ShowDialog() == DialogResult.No) {
                e.Cancel = true;
            }
            dialogo.Dispose();
        }

        private void pictureFechar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
