using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FROGI_OS.CamadaAcessoDados;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formLogin : Form {

        //private string login = "Admin";
        //private string password = "masterkey";
        private bool loginValidado;
        private TblUsuario usuarioSQL;

        public formLogin() {
            InitializeComponent();
            loginValidado = false;
            usuarioSQL = new TblUsuario();
        }

        private void formLogin_Load(object sender, EventArgs e) {
            int x = (Screen.PrimaryScreen.Bounds.Width / 2) - (panelLogin.Size.Width/2);
            int y = (Screen.PrimaryScreen.Bounds.Height / 2) - (panelLogin.Size.Height/2);
            panelLogin.Location = new Point(x, y);

            try {
                Conexao.abrir();
                
                FbDataReader leitor = usuarioSQL.selecionar("USUARIO_CATEGORIA", "0", true);
                bool temAdministrador = leitor.Read();

                if (!temAdministrador) {
                    formCadastroAdministrador administrador = new formCadastroAdministrador();
                    administrador.ShowDialog();
                    administrador.Dispose();
                }

            } catch (Exception erro) {
                MessageBox.Show(erro.Message);
            } finally {
                Conexao.fechar();
            }

        }

        private void validarLogin() {

            labelStatus.Visible = false;
            
            string nomeDigitado = textNome.Text;
            string senhaDigitada = textSenha.Text;
            
            bool nomeFoiPreenchido = (nomeDigitado != null && nomeDigitado != String.Empty);
            bool senhaFoiPreenchido = (senhaDigitada != null && senhaDigitada != String.Empty);

            if (nomeFoiPreenchido) {
                if (senhaFoiPreenchido) {

                    FbDataReader usuarioRegistrado;

                    string 
                        nomeRegistrado = String.Empty,
                        senhaRegistrada = String.Empty;

                    try {
                        Conexao.abrir();
                        usuarioRegistrado = usuarioSQL.selecionar("USUARIO_SENHA", senhaDigitada, true);
                        if (usuarioRegistrado.HasRows && usuarioRegistrado.Read()) {
                            nomeRegistrado = usuarioRegistrado.GetString(1); //Índice da coluna no DataReader
                            senhaRegistrada = usuarioRegistrado.GetString(2); //Índice da coluna no DataReader
                            if (nomeDigitado == nomeRegistrado) {
                                if (senhaDigitada == senhaRegistrada) {
                                    loginValidado = true;
                                    (this.Owner as formPrincipal).selecionarUsuario(nomeRegistrado, usuarioRegistrado.GetInt32(3));
                                    usuarioRegistrado.Close();
                                    this.Dispose();
                                } else {
                                    alterarStatus("Senha inválida", textSenha);
                                }
                            } else {
                                alterarStatus("Nome inválido", textNome);
                            }
                        } else {
                            alterarStatus("Senha inválida", textNome);
                        }
                    } catch (Exception erro) {
                        formDialogo dialogo = new formDialogo("Temos um problema", erro.Message, formDialogo.TipoExpressao.AvisoTriste);
                        dialogo.ShowDialog();
                        dialogo.Dispose();
                    } finally {
                        Conexao.fechar();
                    }
                } else {
                    alterarStatus("Senha inválida", textSenha);
                }
            } else {
                alterarStatus("Nome inválido", textNome);
            }
        }

        private void alterarStatus(string novoStatus, TextBox textFoco) {
            textFoco.Text = String.Empty;
            this.ActiveControl = textFoco;
            labelStatus.Text = novoStatus;
            labelStatus.Visible = true;
        }

        private void buttonEntrar_Click(object sender, EventArgs e) {
            validarLogin();
        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e) {
            if (!loginValidado && this.Owner != null) {
                this.Owner.Dispose();
            }
        }

        private void pictureFechar_Click(object sender, EventArgs e) {
            this.Owner.Dispose();
            this.Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter) {
                validarLogin();
                return true;
            }  else {
                return false;
            }
        }

    }
}
