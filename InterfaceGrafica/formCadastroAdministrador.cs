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

namespace FROGI_OS.InterfaceGrafica {
    public partial class formCadastroAdministrador : Form {

        public formCadastroAdministrador() {
            InitializeComponent();
        }

        private void salvar() {

            string nomeDigitado = textNome.Text;
            string senhaDigitada = textSenha.Text;

            if (nomeDigitado != null && nomeDigitado != String.Empty) {
                if (senhaDigitada != null && senhaDigitada != String.Empty) {

                    try {
                        Conexao.abrir();

                        string sql = "INSERT INTO USUARIO VALUES (NULL, @NOME, @SENHA, @CATEGORIA, @DATA);";
                        FbCommand comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
                        comando.Parameters.AddWithValue("@NOME", nomeDigitado);
                        comando.Parameters.AddWithValue("@SENHA", senhaDigitada);
                        comando.Parameters.AddWithValue("@CATEGORIA", 0);
                        comando.Parameters.AddWithValue("@DATA", DateTime.Now);
                        comando.ExecuteNonQuery();
                        Conexao.getTransacao.Commit();
                        this.Close();

                    } catch (Exception erro) {
                        labelStatus.Text = erro.Message;
                        this.ActiveControl = textNome;
                    } finally {
                        Conexao.fechar();
                    }
                    
                    
                } else {
                    labelStatus.Text = "Digite uma senha para o administrador";
                    this.ActiveControl = textSenha;
                }
            } else {
                labelStatus.Text = "Digite um nome para o administrador";
                this.ActiveControl = textNome;
            }

        }

        private void buttonSalvar_Click(object sender, EventArgs e) {
            salvar();
        }

        private void buttonSair_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
