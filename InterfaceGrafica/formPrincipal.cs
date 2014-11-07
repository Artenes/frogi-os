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
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS
{
    public partial class formPrincipal : Form
    {
        public formPrincipal() {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e) {
            Close();
        }

        private void formPrincipal_Load(object sender, EventArgs e) {
            labelData.Text = DateTime.Now.ToShortDateString();
            this.ActiveControl = pictureClientes;
            textDiretorioNotas.Text = Properties.Settings.Default.diretorioNotas;
            formLogin login = new formLogin();
            login.ShowDialog(this);
        }

        private void abrirForm(PictureBox icone, formCadastro cadastro) {
            if (icone != null && (icone.Cursor == Cursors.Hand) && cadastro != null) {
                this.ActiveControl = icone;
                cadastro.ShowDialog();
                cadastro.Dispose();
            }
        }

        private void abrirForm(PictureBox icone, formOSBasePesquisa pesquisa) {
            if (icone != null && (icone.Cursor == Cursors.Hand) && pesquisa != null) {
                this.ActiveControl = icone;
                pesquisa.ShowDialog();
                pesquisa.Dispose();
            }
        }

        private void pictureClientes_Click(object sender, EventArgs e) {
            abrirForm(sender as PictureBox, new formCadastroCliente(true));
        }

        private void pictureUsuarioFoto_Click(object sender, EventArgs e) {
            
            int x = tableUsuario.Location.X - (pictureUsuarioFoto.Size.Width / 2);
            int y = tableUsuario.Location.Y + pictureUsuarioFoto.Size.Height;

            formMenuPopUp menu = new formMenuPopUp();
            menu.StartPosition = FormStartPosition.Manual;
            menu.Location = new Point(x,y);
            menu.ShowDialog(this);
        }

        private void pictureMarcas_Click(object sender, EventArgs e) {
            abrirForm(sender as PictureBox, new formCadastroMarca(true));
        }

        private void pictureFuncionarios_Click(object sender, EventArgs e) {
            abrirForm(sender as PictureBox, new formCadastroFuncionario(true));
        }

        private void pictureOrdemServico_Click(object sender, EventArgs e) {
            abrirForm(sender as PictureBox, new formPesquisaOS());
        }

        private void pictureSecoes_Click(object sender, EventArgs e) {
            abrirForm(sender as PictureBox, new formCadastroSecao(true));
        }

        private void pictureServicos_Click(object sender, EventArgs e) {
            abrirForm(sender as PictureBox, new formCadastroServico(true));
        }

        private void pictureProdutos_Click(object sender, EventArgs e) {
            abrirForm(sender as PictureBox, new formCadastroProduto(true));
        }

        private void pictureGrupos_Click(object sender, EventArgs e) {
            abrirForm(sender as PictureBox, new formCadastroGrupo(true));
        }

        private void pictureTipos_Click(object sender, EventArgs e) {
            abrirForm(sender as PictureBox, new formCadastroTipo(true));
        }

        private void pictureFornecedores_Click(object sender, EventArgs e) {
            abrirForm(sender as PictureBox, new formCadastroFornecedor(true));
        }

        private void pictureUsuarios_Click(object sender, EventArgs e) {
            abrirForm(sender as PictureBox, new formCadastroUsuario(true));
        }

        private void pictureOrcamentos_Click(object sender, EventArgs e) {
            abrirForm(sender as PictureBox, new formPesquisaOrcamento());
        }

        private void pictureAgendamentos_Click(object sender, EventArgs e) {
            abrirForm(sender as PictureBox, new formCadastroAgendamento(true));
        }

        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            formDialogo dialogo = new formDialogo("Quer fechar o programa?", "Tava tão legal com você por aqui...", formDialogo.TipoExpressao.Pergunta);
            dialogo.ShowDialog();
            if (dialogo.DialogResult == DialogResult.No) {
                e.Cancel = true;
            }
            dialogo.Dispose();
        }

        private void hora_Tick(object sender, EventArgs e) {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void dateDataServico_ValueChanged(object sender, EventArgs e) {
            DateTime data = (sender as DateTimePicker).Value;
            taAFAZER_FISICO.FillByDate(dsFROGIOS.AFAZER_FISICO, data);
            taAFAZER_JURIDICO.FillByDate(dsFROGIOS.AFAZER_JURIDICO, data);
        }

        private void selecionarDiretorio(TextBox textExibir) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) {
                textExibir.Text = fbd.SelectedPath;
                Properties.Settings.Default.diretorioNotas = fbd.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void abrirDiretorio() { 
            string diretorio = Properties.Settings.Default.diretorioNotas;
            if (diretorio != String.Empty) {
                try {
                    System.Diagnostics.Process.Start(@diretorio);
                } catch (Exception) {
                    formDialogo dialogo = new formDialogo("Temos um problema...", "A pasta não existe mais", formDialogo.TipoExpressao.AvisoTriste);
                    dialogo.ShowDialog();
                    dialogo.Dispose();
                }
            }
        }

        private void buttonMudarDiretorio_Click(object sender, EventArgs e) {
            selecionarDiretorio(textDiretorioNotas);
        }

        private void buttonAbrirDiretorio_Click(object sender, EventArgs e) {
            abrirDiretorio();
        }

        public void selecionarUsuario (string nome, int tipo) {
            labelUsuarioNome.Text = nome;
            labelTipoUsuario.Text = tipo == 0 ? "Administrador" : "Funcionário";
            nivelAcesso(tipo);
        }

        private void pictureAjuda_Click(object sender, EventArgs e) {
            new formSobre().ShowDialog();
        }

        public void nivelAcesso(int usuarioTipo) {
            bool eAdministrador = (usuarioTipo == 0);
            if (eAdministrador) {
                pictureFuncionarios.Cursor = Cursors.Hand;
                pictureUsuarios.Cursor = Cursors.Hand;
            } else {
                pictureFuncionarios.Cursor = Cursors.No;
                pictureUsuarios.Cursor = Cursors.No;
            }
        }
        
    }
}