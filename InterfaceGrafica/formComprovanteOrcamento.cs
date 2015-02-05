using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FROGI_OS.Relatorios;
using System.Drawing.Printing;

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formComprovanteOrcamento : Form
    {

        private RelatorioOrcamento comprovante;

        public formComprovanteOrcamento(RelatorioOrcamento comprovante)
        {
            InitializeComponent();
            this.comprovante = comprovante;
        }

        private void formComprovanteOrcamento_Load(object sender, EventArgs e)
        {
            PageSettings conf = this.reportViewer1.GetPageSettings();
            conf.Margins.Top = 0;
            conf.Margins.Left = 0;
            conf.Margins.Right = 0;
            conf.Margins.Bottom = 0;
            this.reportViewer1.SetPageSettings(conf);
            this.bsOrcamento.DataSource = this.comprovante;
            this.bsItens.DataSource = this.comprovante.Itens;
            this.reportViewer1.RefreshReport();
        }
    }
}
