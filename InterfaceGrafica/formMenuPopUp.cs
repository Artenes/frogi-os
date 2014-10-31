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

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formMenuPopUp : Form {

        public formMenuPopUp() {
            InitializeComponent();
        }

        private void linkLogOff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            formDialogo dialogo = new formDialogo("Tem certeza que quer trocar de usuário?", "", formDialogo.TipoExpressao.Pergunta);
            if (dialogo.ShowDialog() == DialogResult.Yes) {
                formLogin login = new formLogin();
                login.ShowDialog(this.Owner);
                dialogo.Dispose();
                this.Close();
            } else {
                dialogo.Dispose();
                this.Close();
            }
            
        }

        private void pictureFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void linkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new formPerfil().ShowDialog();
            this.Dispose();
        }

        private void linkSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Owner.Close();
            this.Close();
        }

       

        

    }
}
