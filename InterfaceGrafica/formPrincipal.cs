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

        private void pictureClientes_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            new formCadastroCliente(true).ShowDialog();
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
            this.ActiveControl = (Control)sender;
            new formCadastroMarca(true).ShowDialog();
        }

        private void pictureFuncionarios_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            new formCadastroFuncionario(true).ShowDialog();
        }

        private void pictureOrdemServico_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            formPesquisaOS os = new formPesquisaOS();
            os.ShowDialog();
            os.Dispose();
        }

        private void pictureSecoes_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            new formCadastroSecao(true).ShowDialog();
        }

        private void pictureServicos_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            new formCadastroServico(true).ShowDialog();
        }

        private void pictureProdutos_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            new formCadastroProduto(true).ShowDialog();
        }

        private void pictureGrupos_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            new formCadastroGrupo(true).ShowDialog();
        }

        private void pictureTipos_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            new formCadastroTipo(true).ShowDialog();
        }

        private void pictureFornecedores_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            new formCadastroFornecedor(true).ShowDialog();
        }

        private void pictureUsuarios_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            new formCadastroUsuario(true).ShowDialog();
        }

        private void pictureOrcamentos_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            new formPesquisaOrcamento().ShowDialog();
        }

        private void pictureAgendamentos_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            formCadastroAgendamento agendamento = new formCadastroAgendamento(true);
            agendamento.ShowDialog();
            agendamento.Dispose();
        }

        private void pictureCompras_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            formDialogo dialogo = new formDialogo("Seção não disponível na versão beta", "", formDialogo.TipoExpressao.AvisoTriste);
            dialogo.ShowDialog();
            dialogo.Dispose();
            /*formCadastroCompra compra = new formCadastroCompra(true);
            compra.ShowDialog();
            compra.Dispose();*/
        }

        private void pictureAjuda_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            formSobre sobre = new formSobre();
            sobre.ShowDialog();
            sobre.Dispose();
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

        private void pictureOpcoes_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            formDialogo dialogo = new formDialogo("Seção não disponível na versão beta", "", formDialogo.TipoExpressao.AvisoTriste);
            dialogo.ShowDialog();
            dialogo.Dispose();
        }

        private void dateDataServico_ValueChanged(object sender, EventArgs e) {
            DateTime data = (sender as DateTimePicker).Value;
            taAFAZER_FISICO.FillByDate(dsFROGIOS.AFAZER_FISICO, data);
            taAFAZER_JURIDICO.FillByDate(dsFROGIOS.AFAZER_JURIDICO, data);
        }

        private void pictureRelatorios_Click(object sender, EventArgs e) {
            this.ActiveControl = (Control)sender;
            formDialogo dialogo = new formDialogo("Seção não disponível na versão beta", "", formDialogo.TipoExpressao.AvisoTriste);
            dialogo.ShowDialog();
            dialogo.Dispose();
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

    }
}