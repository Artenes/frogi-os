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
    public partial class formManutencaoOS : Form
    {

        public formManutencaoOS()
        {
            InitializeComponent();
        }

        private void pictureFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new formOS().ShowDialog();
        }

    }
}
