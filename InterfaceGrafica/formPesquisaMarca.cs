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
    public partial class formPesquisaMarca : formPesquisa
    {

        private MapMarca map;

        public formPesquisaMarca(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado)
        {
            InitializeComponent();
            map = new MapMarca(dsFROGIOS.MARCA);
            comboCampoPesquisa.Items.Clear();
            foreach (string coluna in map.Colunas)
            {
                comboCampoPesquisa.Items.Add(coluna);
            }
        }

        protected override void pesquisar()
        {
            base.pesquisar();
        }

        protected override void resetar()
        {
            base.resetar();
            dsFROGIOS.MARCA.Clear();
            this.ActiveControl = comboCampoPesquisa;
        }

    }
}
