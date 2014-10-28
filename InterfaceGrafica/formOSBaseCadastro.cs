using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FROGI_OS.InterfaceGrafica {
    public partial class formOSBaseCadastro : Form {

        private formDialogo dialogo;
        protected bool ignorar = false;

        public formOSBaseCadastro() {
            InitializeComponent();
            dialogo = new formDialogo();
            resetar();
        }

        public formOSBaseCadastro(bool eNovo) {
            InitializeComponent();
            dialogo = new formDialogo();
            resetar();
            if (eNovo) {
                controles(false, false, true);
            } else {
                controles(true, true, false);
            }
        }

        protected void exibirMensagemErro(String mensagem) {
            dialogo.compor("Temos um problema", mensagem, formDialogo.TipoExpressao.AvisoTriste);
            dialogo.ShowDialog();
        }

        protected double converterParaDouble(string valor) {
            double convertido;
            try {
                convertido = Convert.ToDouble(valor);
            } catch (Exception) {
                convertido = 0;
            }
            return convertido;
        }

        protected short converterParaShort(string valor) {
            short convertido;
            try {
                convertido = Convert.ToInt16(valor);
            } catch (Exception) {
                convertido = 0;
            }
            return convertido;
        } 

        public void salvar() {
            string validacao = validarCampos();
            if (validacao != "") {
                dialogo.compor(validacao, "", formDialogo.TipoExpressao.AvisoTriste).ShowDialog();
            } else {
                dialogo.compor("Quer guardar essas informações que você digitou?", "", formDialogo.TipoExpressao.Pergunta);
                if (dialogo.ShowDialog() == DialogResult.Yes) {
                    try {
                        Conexao.abrir();
                        salvarExecutar();
                        dialogo.compor("Pronto! As informações foram guardadas!", "", formDialogo.TipoExpressao.AvisoFeliz).ShowDialog();
                        Conexao.getTransacao.Commit();
                        resetar();
                        ignorar = true;
                        this.Close();
                    } catch (Exception erro) {
                        dialogo.compor("Essa não! Temos um problema...", erro.Message, formDialogo.TipoExpressao.AvisoTriste).ShowDialog();
                        Conexao.getTransacao.Rollback();
                    } finally {
                        Conexao.fechar();
                    }
                }
            }
        }

        public void deletar() {
            dialogo.compor("Tem certeza que quer apagar este registro?", "Não vai dar pra recuperar ele depois!", formDialogo.TipoExpressao.Pergunta);
            if (dialogo.ShowDialog() == DialogResult.Yes) {
                try {
                    Conexao.abrir();
                    excluirExecutar();
                    dialogo.compor("Regitro excluido com sucesso", "Vai fazer falta...", formDialogo.TipoExpressao.AvisoTriste).ShowDialog();
                    Conexao.getTransacao.Commit();
                    resetar();
                    ignorar = true;
                    this.Close();
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
                } finally {
                    Conexao.fechar();
                }
            }
        }

        private void controles(bool editar, bool excluir, bool salvar) {
            pictureEditar.Visible = editar;
            pictureExcluir.Visible = excluir;
            pictureSalvar.Visible = salvar;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == (Keys.Control | Keys.E) && pictureEditar.Visible) {
                editar();
                return true;
            } else if (keyData == (Keys.Control | Keys.D) && pictureExcluir.Visible) {
                deletar();
                return true;
            } else if (keyData == (Keys.Control | Keys.S) && pictureSalvar.Visible) {
                salvar();
                return true;
            } else {
                return false;
            }
        }

        /*
         * Método para serem sobreescritos pela classe filha
         */
        protected virtual void campos(bool estaDisponivel) {
            tabPai.Enabled = estaDisponivel;
        }

        protected virtual void salvarExecutar() { }
        protected virtual void excluirExecutar() { }    
        public virtual void selecionar(int codigo) {}
        
        protected virtual void editar() {
            campos(true);
            controles(false, false, true);
        }

        protected virtual void resetar() {
            campos(false);
            controles(true, true, false);
        }

        protected virtual string validarCampos() {
            return String.Empty;
        }

        private void pictureFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void formOSBase_FormClosing(object sender, FormClosingEventArgs e) {
            if (!ignorar) {
                formDialogo dialogo = new formDialogo("Tem certeza que quer sair?", "Alterações não salvas serão perdidas!", formDialogo.TipoExpressao.Pergunta);
                if (dialogo.ShowDialog() == DialogResult.No)
                    e.Cancel = true;
            }
            ignorar = false;
        }

        private void pictureEditar_Click(object sender, EventArgs e) {
            editar();
        }

        private void pictureExcluir_Click(object sender, EventArgs e) {
            deletar();
        }

        private void pictureSalvar_Click(object sender, EventArgs e) {
            salvar();
        }

    }
}
