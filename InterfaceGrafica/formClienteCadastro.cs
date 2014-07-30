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
using FROGI_OS.CamadaAcessoDados;

namespace FROGI_OS
{
   
    public partial class formClienteCadastro : Form {

        private int CLIENTE_FISICO = 0;
        private int CLIENTE_JURIDICO = 0;
        private int tipoAtual;

        public formClienteCadastro() {
            tipoAtual = CLIENTE_FISICO;
            InitializeComponent();
            resetar();
        }

        /****
         * OPERAÇÕES
         ****/
        private void pesquisarRegistro() {

            formDialogo dialogo = new formDialogo("Deseja pesquisar um cliente?", "O que não foi salvo será perdido!", formDialogo.TipoExpressao.Pergunta);
            DialogResult resultado = dialogo.ShowDialog();
            if (resultado == System.Windows.Forms.DialogResult.No) {
                return;
            }

            formClientePesquisa pesquisa = new formClientePesquisa();
            resultado =  pesquisa.ShowDialog();

            if (resultado == DialogResult.Yes) {
                campos(false);
                controles(true, true, true, false, true);
                //Aqui chamar o método para preencher os 
                //Biding sources que está ligado aos campos
                if (dsFROGIOS.CLIENTE_FISICO.Rows.Count > 0) {
                    tabPai.SelectedTab = tabClienteFisico;
                    comboTipoCliente.SelectedIndex = 0;
                }
                else {
                    tabPai.SelectedTab = tabClienteJuridico;
                    comboTipoCliente.SelectedIndex = 1;
                }
            }
            else {
                resetar();
            }
        }

        private void novoRegistro() {
            campos(true);
            panelCodigoData.Visible = false;
            controles(false, false, false, true, true);
        }

        private void salvarRegistro() {

            formDialogo salvar;

            string validacao = validarCampos();
            if (validacao != "") {
                salvar = new formDialogo(validacao, "", formDialogo.TipoExpressao.AvisoTriste);
                salvar.ShowDialog();
                salvar.Dispose();
                return;
            }

            salvar = new formDialogo("Quer salvar as informações deste cliente?", "", formDialogo.TipoExpressao.Pergunta);
            DialogResult resultado = salvar.ShowDialog();
            salvar.Dispose();
            if (resultado == System.Windows.Forms.DialogResult.Yes) {
                salvar = new formDialogo("Pronto! As informações do cliente foram salvas", "", formDialogo.TipoExpressao.AvisoFeliz);
                salvar.ShowDialog();
                salvar.Dispose();
                resetar();
            }
            else {
                return;
            }
        }
       
        private void editarRegistro() {
            campos(true);
            controles(false, false, false, true, true);
        }
       
        private void excluirRegistro() {
            formDialogo dialogo = new formDialogo("Tem certeza que quer excluir este cliente?", "Não vai dar pra recuperar ele depois!", formDialogo.TipoExpressao.Pergunta);
            DialogResult resultado = dialogo.ShowDialog();
            dialogo.Dispose();
            if (resultado == System.Windows.Forms.DialogResult.Yes) {
                dialogo = new formDialogo("Cliente excluido com sucesso", "Vai fazer falta...", formDialogo.TipoExpressao.AvisoTriste);
                dialogo.ShowDialog();
                dialogo.Dispose();
                resetar();
            }
            else
            {
                return;
            }
        }

        private void comboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * Sinceramente toda essa verificação feita antes de começar a fazer algo
             * se deve ao programa estar chamando este método durante a transação de 
             * Abas no objeto tabPai. Então devo verificar se as coisas estõa null ou não
             */
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox != null)
            {
                object itemSelcionado = comboBox.SelectedItem;
                //Simples: se for físico tipo_atual vira físico, senão virá jurídico
                if (itemSelcionado != null && itemSelcionado.ToString() == "Físico")
                {
                    tabPai.SelectedTab = tabClienteFisico;
                    tipoAtual = CLIENTE_FISICO;
                }
                else if (itemSelcionado != null && itemSelcionado.ToString() == "Jurídico")
                {
                    tabPai.SelectedTab = tabClienteJuridico;
                    tipoAtual = CLIENTE_JURIDICO;
                }
            }

        }
        
        private string validarCampos() {
            return "";
        }

        /**
         * VISUALIZAÇÃO
         **/
        private void resetar() {
            tabPai.SelectedTab = tabClienteFisico;
            comboTipoCliente.SelectedIndex = 0;
            campos(false);
            controles(true, false, false, false, true);
            dsFROGIOS.CLIENTE.Clear();
            dsFROGIOS.CLIENTE_FISICO.Clear();
            dsFROGIOS.CLIENTE_JURIDICO.Clear();
            dsFROGIOS.UF.Clear();
        }

        private void controles(bool novo, bool editar, bool excluir, bool salvar, bool pesquisar) {
            pictureNovo.Visible = novo;
            pictureEditar.Visible = editar;
            pictureExcluir.Visible = excluir;
            pictureSalvar.Visible = salvar;
            picturePesquisar.Visible = pesquisar;
        }
    
        private void campos(bool taDisponivel) {
            panelClienteFisico.Enabled = taDisponivel;
            panelClienteJuridico.Enabled = taDisponivel;
            comboTipoCliente.Enabled = taDisponivel;
            panelCodigoData.Visible = taDisponivel;
        }
     

        /**
         * OUTROS
         */ 
        private void pictureFechar_Click(object sender, EventArgs e) {Dispose();}
        private void pictureNovo_Click(object sender, EventArgs e) {novoRegistro();}
        private void pictureSalvar_Click(object sender, EventArgs e) {salvarRegistro();}
        private void pictureEditar_Click(object sender, EventArgs e) {editarRegistro();}
        private void pictureExcluir_Click(object sender, EventArgs e) {excluirRegistro();}
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

    }
}
