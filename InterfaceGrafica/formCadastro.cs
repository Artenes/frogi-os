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
        private bool pesquisaHabilitado;

        //Este atributo deve ser inicializado pelo construtor da classe filha
        protected formPesquisa pesquisa;

        public formCadastro() {
            InitializeComponent();
        }

        public formCadastro(bool pesquisaHabilitado) {
            InitializeComponent();
            this.pesquisaHabilitado = pesquisaHabilitado;
            dialogo = new formDialogo();
            resetar();
        }

        private void pesquisarRegistro() {

            if (pesquisa == null) {
                return;
            }

            dialogo.compor(
                "Deseja procurar um registro?",
                "O que não foi salvo será perdido!",
                formDialogo.TipoExpressao.Pergunta);

            if (dialogo.ShowDialog() == DialogResult.Yes){
                resetar();
                if (pesquisa.ShowDialog() == DialogResult.Yes) {
                    campos(false);
                    controles(true, true, true, false, true);
                }
            }
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
                        Conexao.abrir();
                        salvaExecutar();
                        dialogo.compor("Pronto! As informações foram guardadas!", "", formDialogo.TipoExpressao.AvisoFeliz);
                        dialogo.ShowDialog();
                        Conexao.getTransacao.Commit();
                        resetar();
                    }
                    catch (Exception erro) {
                        dialogo.compor("Essa não! Temos um problema...", erro.Message, formDialogo.TipoExpressao.AvisoTriste);
                        dialogo.ShowDialog();
                        Conexao.getTransacao.Rollback();
                    }
                    finally {
                        Conexao.fechar();
                    }
                }
            }
        }

        private void excluirRegistro() {
            dialogo.compor("Tem certeza que quer apagar este registro?", "Não vai dar pra recuperar ele depois!", formDialogo.TipoExpressao.Pergunta);
            if (dialogo.ShowDialog() == DialogResult.Yes) {
                try {
                    Conexao.abrir();
                    excluiExecutar();
                    dialogo.compor("Regitro excluido com sucesso", "Vai fazer falta...", formDialogo.TipoExpressao.AvisoTriste).ShowDialog();
                    Conexao.getTransacao.Commit();
                    resetar();
                } catch (Exception erro) {
                    string mensagemErro;
                    //Isso quer dizer que um registro não pode ser deletado já que outros dependem dele para fazer sentido
                    if (erro.Message.Contains("Foreign key references are present for the record")) {
                        mensagemErro = "Este registro não pode ser deletado porque outros registros dependem dele";
                    } else {
                        mensagemErro = erro.Message;
                    }

                    dialogo.compor("Essa não! Temos um problema...", mensagemErro, formDialogo.TipoExpressao.AvisoTriste).ShowDialog();
                    Conexao.getTransacao.Rollback();
                }
                finally {
                    Conexao.fechar();
                }
            }
        }

        private void controles(bool novo, bool editar, bool excluir, bool salvar, bool pesquisar) {
            pictureNovo.Visible = novo;
            pictureEditar.Visible = editar;
            pictureExcluir.Visible = excluir;
            pictureSalvar.Visible = salvar;
            picturePesquisar.Visible = pesquisaHabilitado ? pesquisar : false;
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

        protected bool valorValido(string valor)
        {
            if (valor != null && valor.Length > 0) {
                return true;
            } else {
                return false;
            }
        }

        /**
         * Métodos que precisam ser sobreescritos pela classe filha
         */
        protected virtual void novoRegistro() { resetar(); campos(true); controles(false, false, false, true, true); panelCodigo.Visible = false; }

        protected virtual void salvaExecutar() {}

        protected virtual void editarRegistro() {campos(true);controles(false, false, false, true, true);}

        protected virtual void excluiExecutar() {}

        protected virtual void resetar() {campos(false);controles(true, false, false, false, true);}

        protected virtual void campos(bool estaDisponivel) { panelCentro.Enabled = estaDisponivel; panelCodigo.Visible = estaDisponivel; }

        protected virtual string validarCampos() {return String.Empty;}

        protected virtual void visualizarRegistroExecutar(int codigo) { }

        public void visualizarRegistro(int codigo) {
            try {
                Conexao.abrir();
                visualizarRegistroExecutar(codigo);
            } catch (Exception erro){
                dialogo.compor("Temos um problema", erro.Message, formDialogo.TipoExpressao.AvisoTriste).ShowDialog();
            } finally {
                Conexao.fechar();
            }
        }

        private void pictureFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void formCadastro_FormClosing(object sender, FormClosingEventArgs e) {
            formDialogo dialogo = new formDialogo("Tem certeza que quer sair?", "Alterações não salvas serão perdidas!", formDialogo.TipoExpressao.Pergunta);
            if (dialogo.ShowDialog() == DialogResult.No) {
                e.Cancel = true;
            }
        }

    }
}
