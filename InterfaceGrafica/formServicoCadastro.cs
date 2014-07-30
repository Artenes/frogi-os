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
using FROGI_OS.InterfaceGrafica;

namespace FROGI_OS
{
    public partial class formServicoCadastro : Form {

        private formDialogo dialogo;

        public formServicoCadastro() {
            InitializeComponent();
            dialogo = new formDialogo();
            resetar();
        }

        private void pesquisarRegistro() {

            dialogo.compor(
                "Deseja pesquisar um serviço?",
                "O que não foi salvo será perdido!",
                formDialogo.TipoExpressao.Pergunta);

            if (dialogo.ShowDialog() == DialogResult.Yes) {

                formServicoPesquisa pesquisa = new formServicoPesquisa();
                if (pesquisa.ShowDialog() == DialogResult.Yes) {
                    campos(false);
                    controles(true, true, true, false, true);
                    //Aqui chamar o método para preencher os 
                    //Biding sources que está ligado aos campos
                }
                else {
                    resetar();
                }

            }
        }

        private void novoRegistro() {
            campos(true);
            panelCodigo.Visible = false;
            controles(false, false, false, true, true);
        }

        private void salvarRegistro() {
            string validacao = validarCampos();
            if (validacao != "") {
                dialogo.compor(validacao, "", formDialogo.TipoExpressao.AvisoTriste);
                dialogo.ShowDialog();
            } else {
                dialogo.compor("Quer salvar as informações deste serviço?", "", formDialogo.TipoExpressao.Pergunta);
                if (dialogo.ShowDialog() == DialogResult.Yes) {
                    //Método para salvar as paradinhas
                    dialogo.compor("Pronto! As informações do serviço foram salvas", "", formDialogo.TipoExpressao.AvisoFeliz);
                    dialogo.ShowDialog();
                    resetar();
                }
            }
        }

        private void editarRegistro() {
            campos(true);
            controles(false, false, false, true, true);
            ActiveControl = sERVICO_DESCRICAOTextBox;
        }
        private void excluirRegistro() {
            dialogo.compor("Tem certeza que quer excluir este serviço?", "Não vai dar pra recuperar ele depois!", formDialogo.TipoExpressao.Pergunta);
            if (dialogo.ShowDialog() == DialogResult.Yes) {
                //Método para apagar as paradinhas
                dialogo.compor("Serviço excluido com sucesso", "Vai fazer falta...", formDialogo.TipoExpressao.AvisoTriste);
                dialogo.ShowDialog();
                resetar();
            }
        }
        

        private void resetar() {
            campos(false);
            controles(true, false, false, false,true);
            dsFROGIOS.SERVICO.Clear();
            dsFROGIOS.TIPO.Clear();
        }

        private void controles(bool novo, bool editar, bool excluir, bool salvar, bool pesquisar)
        {
            pictureNovo.Visible = novo;
            pictureEditar.Visible = editar;
            pictureExcluir.Visible = excluir;
            pictureSalvar.Visible = salvar;
            picturePesquisar.Visible = pesquisar;
        }

        private void campos(bool estaDisponivel)
        {
            panelCampos.Enabled = estaDisponivel;
            panelCodigo.Visible = estaDisponivel;
        }

        private void pictureFechar_Click(object sender, EventArgs e) {
            Close();
        }

        private void tabPai_KeyDown(object sender, KeyEventArgs e) {
            if ((e.Control && e.KeyCode == Keys.N) && (pictureNovo.Visible)) {
                novoRegistro();
            } else if ((e.Control && e.KeyCode == Keys.E) && pictureEditar.Visible) {
                editarRegistro();
            } else if ((e.Control && e.KeyCode == Keys.D) && pictureExcluir.Visible) {
                excluirRegistro();
            } else if ((e.Control && e.KeyCode == Keys.S) && pictureSalvar.Visible) {
                salvarRegistro();
            } else if ((e.Control && e.KeyCode == Keys.P) && picturePesquisar.Visible) {
                pesquisarRegistro();
            }
        }

        private void pictureNovo_Click(object sender, EventArgs e) {
            novoRegistro();
        }

        private void pictureEditar_Click(object sender, EventArgs e) {
            editarRegistro();
        }

        private void pictureExcluir_Click(object sender, EventArgs e) {
            excluirRegistro();
        }

        private void pictureSalvar_Click(object sender, EventArgs e) {
            salvarRegistro();
        }

        private void picturePesquisar_Click(object sender, EventArgs e) {
            pesquisarRegistro();
        }

        private string validarCampos() {
            return "";
        }

    }
}
