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
    public partial class formPesquisaOrcamento : formOSBasePesquisa
    {

        private MapOrcamento map;

        public formPesquisaOrcamento() : base () {
            InitializeComponent();
            map = new MapOrcamento(dsFROGIOS.CLIENTE, dsFROGIOS.CLIENTE_FISICO, dsFROGIOS.CLIENTE_JURIDICO, dsFROGIOS.FUNCIONARIO, dsFROGIOS.ORCAMENTO);
        }

        protected override void pesquisar() {
            base.pesquisar();
        }

        protected override void preencherCampoPesquisa(bool eFisico) {
            base.preencherCampoPesquisa(eFisico);
            comboCampoPesquisa.Items.Clear();
            if (eFisico) {
                foreach (string coluna in map.ColunasFisico){
                    comboCampoPesquisa.Items.Add(coluna);
                }
            }
            else {
                foreach (string coluna in map.ColunasJuridico) {
                    comboCampoPesquisa.Items.Add(coluna);
                }
            }
        }

        protected override void novoRegistro() {
            base.novoRegistro();
            formCadastroOrcamento orcamento = new formCadastroOrcamento();
            orcamento.ShowDialog();
            orcamento.Dispose();
            resetar();
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.PESQUISA_ORCAMENTO_FISICO.Clear();
                dsFROGIOS.PESQUISA_ORCAMENTO_JURIDICO.Clear();
            }
        }

    }
}
