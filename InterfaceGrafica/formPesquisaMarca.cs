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

namespace FROGI_OS.InterfaceGrafica {
    public partial class formPesquisaMarca : formPesquisa {

        private MapMarca map;
        private TblMarca marcaSQL;

        public formPesquisaMarca(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado) {
            InitializeComponent();
            map = new MapMarca(dsFROGIOS.MARCA);
            comboCampoPesquisa.Items.Clear();
            foreach (string coluna in map.Colunas) {
                comboCampoPesquisa.Items.Add(coluna);
            }
            marcaSQL = new TblMarca();
        }

        protected override void pesquisaExecutar() {
            string coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString());
            string valor = textValorPesquisa.Text;
            dsFROGIOS.MARCA.Clear();
            dsFROGIOS.MARCA.Load(marcaSQL.selecionar(coluna, valor, false));
            if (dsFROGIOS.MARCA.Rows.Count > 0) {
                this.ActiveControl = mARCADataGridView;
            } else {
                this.ActiveControl = textValorPesquisa;
            }
        }

        protected override void resetar() {
            base.resetar();
            dsFROGIOS.MARCA.Clear();
            this.ActiveControl = comboCampoPesquisa;
        }

        private void selecionarMarca() {
            try {
                int indice = mARCADataGridView.CurrentRow.Index;
                int codigo = (int)mARCADataGridView[0, indice].Value;

                if (cadastro.GetType() == typeof(formCadastroMarca)) {
                    ((formCadastroMarca)cadastro).visualizarRegistro(codigo);
                } else if (cadastro.GetType() == typeof(formCadastroProduto)) {
                    ((formCadastroProduto)cadastro).adicionarMarca(codigo);
                }

                this.DialogResult = DialogResult.Yes;
                this.Close();
            } catch (Exception) {
                this.ActiveControl = comboCampoPesquisa;
            }
        }

        private void mARCADataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarMarca();
        }

        private void mARCADataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarMarca();
                e.SuppressKeyPress = true;
            }
        }
    }
}