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
            this.ActiveControl = pictureClientes;
        }

        private void buttonSair_Click(object sender, EventArgs e) {
            Close();
        }

        private void pictureClientes_Click(object sender, EventArgs e)
        {
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

        private void pictureMarcas_Click(object sender, EventArgs e)
        {
            new formCadastroMarca(true).ShowDialog();
        }

        private void pictureFuncionarios_Click(object sender, EventArgs e)
        {
            new formCadastroFuncionario(true).ShowDialog();
        }

        private void pictureOrdemServico_Click(object sender, EventArgs e) {
            formPesquisaOS os = new formPesquisaOS();
            os.ShowDialog();
            os.Dispose();
        }

        private void pictureSecoes_Click(object sender, EventArgs e) {
            new formCadastroSecao(true).ShowDialog();
        }

        private void pictureServicos_Click(object sender, EventArgs e) {
            new formCadastroServico(true).ShowDialog();
        }

        private void pictureProdutos_Click(object sender, EventArgs e) {
            new formCadastroProduto(true).ShowDialog();
        }

        private void pictureGrupos_Click(object sender, EventArgs e) {
            new formCadastroGrupo(true).ShowDialog();
        }

        private void pictureTipos_Click(object sender, EventArgs e) {
            new formCadastroTipo(true).ShowDialog();
        }

        private void pictureFornecedores_Click(object sender, EventArgs e) {
            new formCadastroFornecedor(true).ShowDialog();
        }

        private void pictureUsuarios_Click(object sender, EventArgs e) {
            new formCadastroUsuario(true).ShowDialog();
        }

        private void formPrincipal_Load(object sender, EventArgs e) {
            formLogin login = new formLogin();
            login.ShowDialog(this);
        }

        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            formDialogo dialogo = new formDialogo("Quer fechar o programa?", "Tava tão legal com você por aqui...", formDialogo.TipoExpressao.Pergunta);
            dialogo.ShowDialog();
            if (dialogo.DialogResult == DialogResult.No) {
                e.Cancel = true;
            }
            dialogo.Dispose();
        }

        private void pictureOrcamentos_Click(object sender, EventArgs e) {
            new formPesquisaOrcamento().ShowDialog();
        }

    }
}