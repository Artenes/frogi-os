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
using FROGI_OS.CamadaAcessoDados;

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formPesquisaProduto : formPesquisa
    {

        private MapProduto map;
        private TblProduto produtoSQL;

        public formPesquisaProduto(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado)
        {
            InitializeComponent();
            map = new MapProduto(dsFROGIOS.PRODUTO, dsFROGIOS.MARCA);
            comboCampoPesquisa.Items.Clear();
            foreach (string coluna in map.Colunas)
            {
                comboCampoPesquisa.Items.Add(coluna);
            }
            produtoSQL = new TblProduto();
        }

        protected override void pesquisaExecutar() {
            string 
                coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString()),
                valor = textValorPesquisa.Text;
            dsFROGIOS.PRODUTO.Load(produtoSQL.selecionar(coluna, valor, false));
        }

        protected override void resetar()
        {
            base.resetar();
            dsFROGIOS.PRODUTO.Clear();
            this.ActiveControl = comboCampoPesquisa;
        }

        private void selecionarProduto() {
            try {
                int indice = pRODUTODataGridView.CurrentRow.Index;
                int codigo = (int)pRODUTODataGridView[0, indice].Value;
                ((formCadastroProduto)cadastro).visualizarRegistro(codigo);
                this.DialogResult = DialogResult.Yes;
                this.Close();
            } catch (Exception) {
                this.ActiveControl = comboCampoPesquisa;
            }
        }

        private void pRODUTODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarProduto();
        }

        private void pRODUTODataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarProduto();
                e.SuppressKeyPress = true;
            }
        }




    }
}