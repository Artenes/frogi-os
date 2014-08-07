using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FROGI_OS.Mapeamento;

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formPesquisaOS : formOSBasePesquisa
    {

        private MapOS map;

        public formPesquisaOS() : base ()
        {
            InitializeComponent();
            map = new MapOS(dsFROGIOS.CLIENTE, dsFROGIOS.CLIENTE_FISICO, dsFROGIOS.CLIENTE_JURIDICO, dsFROGIOS.FUNCIONARIO, dsFROGIOS.OS);
        }

        protected override void pesquisar()
        {
            base.pesquisar();
        }

        protected override void preencherCampoPesquisa(bool eFisico) {
            base.preencherCampoPesquisa(eFisico);
            if (map != null) {
                comboCampoPesquisa.Items.Clear();
                if (eFisico) {
                    foreach (string coluna in map.ColunasFisico) {
                        comboCampoPesquisa.Items.Add(coluna);
                    }
                }
                else {
                    foreach (string coluna in map.ColunasJuridico) {
                        comboCampoPesquisa.Items.Add(coluna);
                    }
                }
            }
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.PESQUISA_OS_FISICO.Clear();
                dsFROGIOS.PESQUISA_OS_JURIDICO.Clear();
            }
        }

        protected override void comboCampoPesquisa_SelectedIndexChanged(object sender, EventArgs e) {
            base.comboCampoPesquisa_SelectedIndexChanged(sender, e);
            string coluna = comboCampoPesquisa.Text;
            if (coluna == map.Status)
            {
                textValorPesquisa.Visible = false;
                comboStatus.Visible = true;
            }
            else {
                textValorPesquisa.Visible = true;
                comboStatus.Visible = false;
            }
        }

        protected override void novoRegistro() {
            base.novoRegistro();
            formCadastroOS cadastro = new formCadastroOS();
            cadastro.ShowDialog();
            cadastro.Dispose();
        }

        private void comboStatus_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                pesquisar();
            }
        }

    }
}