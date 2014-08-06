using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formLogin : Form {

        private string login = "Admin";
        private string password = "masterkey";

        public formLogin() {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e) {
            int x = (Screen.PrimaryScreen.Bounds.Width / 2) - (panelLogin.Size.Width/2);
            int y = (Screen.PrimaryScreen.Bounds.Height / 2) - (panelLogin.Size.Height/2);
            panelLogin.Location = new Point(x, y);
        }

        private void validarLogin() {
            labelStatus.Visible = false;
            string nome = textNome.Text;
            string senha = textSenha.Text;

            if (nome == login)
            {
                if (senha == password)
                {
                    this.Dispose();
                }
                else
                {
                    textSenha.Text = "";
                    this.ActiveControl = textSenha;
                    labelStatus.Text = "Senha inválida";
                    labelStatus.Visible = true;
                }
            }
            else
            {
                textNome.Text = "";
                this.ActiveControl = textNome;
                labelStatus.Text = "Nome inválido";
                labelStatus.Visible = true;
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e) {
            validarLogin();
        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e) {
            
        }

        private void pictureFechar_Click(object sender, EventArgs e) {
            this.Owner.Dispose();
            this.Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter) {
                validarLogin();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
