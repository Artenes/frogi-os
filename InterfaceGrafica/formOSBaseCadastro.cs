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
    public partial class formOSBaseCadastro : Form
    {
        public formOSBaseCadastro()
        {
            InitializeComponent();
        }

        public virtual void preencher(int codigo) { }

        public virtual void salvar() { }

        private void formOSBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            formDialogo dialogo = new formDialogo("Tem certeza que quer sair?", "Alterações não salvas serão perdidas!", formDialogo.TipoExpressao.Pergunta);
            if (dialogo.ShowDialog() == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void pictureFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
