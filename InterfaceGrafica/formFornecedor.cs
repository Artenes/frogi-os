using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FROGI_OS
{
    public partial class formFornecedor : Form
    {

        int i = 2;

        public formFornecedor()
        {
            InitializeComponent();
        }

        private void pictureFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTipoPessoa_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                buttonTipoPessoa.Text = "Físico";
                tabFornecedor.SelectedTab = tabFisica;
                i = 2;
            }
            else
            {
                buttonTipoPessoa.Text = "Jurídico";
                tabFornecedor.SelectedTab = tabJuridico;
                i = 1;
            }
        }

    }
}
