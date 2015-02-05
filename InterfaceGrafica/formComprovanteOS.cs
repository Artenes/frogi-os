using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using FROGI_OS.Relatorios;

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formComprovanteOS : Form
    {
        private RelatorioOrdemServico comprovante;

        public formComprovanteOS(RelatorioOrdemServico comprovante)
        {
            InitializeComponent();
            this.comprovante = comprovante;
        }

        private void formComprovanteOS_Load(object sender, EventArgs e)
        {
            PageSettings conf = this.reportViewer1.GetPageSettings();
            conf.Margins.Top = 0;
            conf.Margins.Left = 0;
            conf.Margins.Right = 0;
            conf.Margins.Bottom = 0;
            this.reportViewer1.SetPageSettings(conf);
            this.bsOS.DataSource = this.comprovante;
            this.bsItens.DataSource = this.comprovante.Itens;
            this.reportViewer1.RefreshReport();
        }
    }
}
