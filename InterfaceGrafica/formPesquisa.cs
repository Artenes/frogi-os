using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS
{
    public partial class formPesquisa : Form
    {

        protected formCadastro cadastro;
        protected formDialogo dialogo;

        public formPesquisa() {
            InitializeComponent();
        }

        public formPesquisa(formCadastro cadastro, bool novoHabilitado)
        {
            InitializeComponent();
            this.cadastro = cadastro;
            if (novoHabilitado)
            {
                pictureNovo.Visible = true;
            }
            else {
                pictureNovo.Visible = false;
            }
            dialogo = new formDialogo();
        }

        protected void exibirMensagemErro (String mensagem) {
            dialogo.compor("Temos um problema", mensagem, formDialogo.TipoExpressao.AvisoTriste);
            dialogo.ShowDialog();
        }

        private void pesquisar() {
            try {
                Conexao.abrir();
                pesquisaExecutar();
            } catch (Exception erro) {
                exibirMensagemErro(erro.Message);
            } finally {
                Conexao.fechar();
            }
        }

        protected virtual void pesquisaExecutar() {}

        protected virtual void resetar() {
            comboCampoPesquisa.SelectedIndex = 0;
            textValorPesquisa.Text = String.Empty;
        }

        protected bool querVisualizarRegistro() {
            formDialogo dialogo = new formDialogo("Deseja visualiar este registro?", "", formDialogo.TipoExpressao.Pergunta);
            if (dialogo.ShowDialog() == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void novoRegistro() {
            formDialogo dialogo = new formDialogo("Deseja criar um novo registro?", "", formDialogo.TipoExpressao.Pergunta);
            if (dialogo.ShowDialog() == DialogResult.Yes) {
                cadastro.ShowDialog();
                this.Dispose();
            }
        }

        private void pictureFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureNovo_Click(object sender, EventArgs e)
        {
            novoRegistro();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e) {
            pesquisar();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                if (pictureNovo.Visible)
                {
                    novoRegistro();
                    return true;
                }
                else {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }

        private void formPesquisa_FormClosing(object sender, FormClosingEventArgs e)
        {
            resetar();
        }

        private void textValorPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisar();
            }
        }

        private void comboCampoPesquisa_SelectedIndexChanged(object sender, EventArgs e){
            textValorPesquisa.Enabled = true;
            buttonPesquisar.Enabled = true;
        }

    }
}
