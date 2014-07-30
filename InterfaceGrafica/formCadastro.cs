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

namespace FROGI_OS {

    public partial class formCadastro : Form{

        private formDialogo dialogo;

        //Este atributo deve ser inicializado pelo contrutor da classe filha
        protected formPesquisa pesquisa;

        public formCadastro() {
            InitializeComponent();
            dialogo = new formDialogo();
            resetar();
        }

        private void pesquisarRegistro() {

            dialogo.compor(
                "Deseja procurar um registro?",
                "O que não foi salvo será perdido!",
                formDialogo.TipoExpressao.Pergunta);

            if (dialogo.ShowDialog() == DialogResult.Yes){
                if (pesquisa.ShowDialog() == DialogResult.Yes) {
                    campos(false);
                    controles(true, true, true, false, true);
                }
                else {
                    resetar();
                }
            }
        }

        private void novoRegistro() {
            campos(true);
            controles(false, false, false, true, true);
            panelCodigo.Visible = false;
        }

        private void salvarRegistro() {
            string validacao = validarCampos();
            if (validacao != "") {
                dialogo.compor(validacao, "", formDialogo.TipoExpressao.AvisoTriste);
                dialogo.ShowDialog();
            } else {
                dialogo.compor("Quer guardar essas informações que você digitou?", "", formDialogo.TipoExpressao.Pergunta);
                if (dialogo.ShowDialog() == DialogResult.Yes) {
                    try {
                        salvaExecutar();
                        dialogo.compor("Pronto! As informações foram guardadas!", "", formDialogo.TipoExpressao.AvisoFeliz);
                        dialogo.ShowDialog();
                        resetar();
                    } catch (Exception erro) {
                        dialogo.compor("Essa não! Temos um problema...", erro.Message, formDialogo.TipoExpressao.AvisoTriste);
                        dialogo.ShowDialog();
                    }
                }
            }
        }

        private void excluirRegistro() {
            dialogo.compor("Tem certeza que quer apagar este registro?", "Não vai dar pra recuperar ele depois!", formDialogo.TipoExpressao.Pergunta);
            if (dialogo.ShowDialog() == DialogResult.Yes) {
                try {
                    excluiExecutar();
                    dialogo.compor("Serviço excluido com sucesso", "Vai fazer falta...", formDialogo.TipoExpressao.AvisoTriste);
                    dialogo.ShowDialog();
                    resetar();
                } catch (Exception erro) {
                    dialogo.compor("Essa não! Temos um problema...", erro.Message, formDialogo.TipoExpressao.AvisoTriste);
                    dialogo.ShowDialog();
                }
            }
        }

        private void controles(bool novo, bool editar, bool excluir, bool salvar, bool pesquisar) {
            pictureNovo.Visible = novo;
            pictureEditar.Visible = editar;
            pictureExcluir.Visible = excluir;
            pictureSalvar.Visible = salvar;
            picturePesquisar.Visible = pesquisar;
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

        private void pictureSalvar_Click(object sender, EventArgs e){
            salvarRegistro();
        }

        private void picturePesquisar_Click(object sender, EventArgs e){
            pesquisarRegistro();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == (Keys.Control | Keys.N) && pictureNovo.Visible) {
                novoRegistro();
                return true;
            } else if (keyData == (Keys.Control | Keys.E) && pictureEditar.Visible) {
                editarRegistro();
                return true;
            } else if (keyData == (Keys.Control | Keys.D) && pictureExcluir.Visible) {
                excluirRegistro();
                return true;
            } else if (keyData == (Keys.Control | Keys.S) && pictureSalvar.Visible)
            {
                salvarRegistro();
                return true;
            } else if (keyData == (Keys.Control | Keys.P) && picturePesquisar.Visible) {
                pesquisarRegistro();
                return true;
            } else {
                return false;
            }
        }

        /**
         * Métodos que precisam ser sobreescritos pela classe filha
         */ 
        protected virtual void salvaExecutar() {}

        protected virtual void editarRegistro() {campos(true);controles(false, false, false, true, true);}

        protected virtual void excluiExecutar() {}

        protected virtual void resetar() {campos(false);controles(true, false, false, false, true);}

        protected virtual void campos(bool estaDisponivel) {}

        protected virtual string validarCampos() {return String.Empty;}

        private void pictureFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
