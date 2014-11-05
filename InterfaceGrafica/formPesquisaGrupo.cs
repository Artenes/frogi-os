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
    public partial class formPesquisaGrupo : formPesquisa
    {

        private MapGrupo map;
        private TblGrupo grupoSQL;
        public formPesquisaGrupo(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado)
        {
            InitializeComponent();
            map = new MapGrupo(dsFROGIOS.GRUPO);
            comboCampoPesquisa.Items.Clear();
            foreach (string coluna in map.Colunas){
                comboCampoPesquisa.Items.Add(coluna);
            }
            grupoSQL = new TblGrupo();
        }

        protected override void pesquisaExecutar() {
            string coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString());
            string valor = textValorPesquisa.Text;
            dsFROGIOS.GRUPO.Clear();
            dsFROGIOS.GRUPO.Load(grupoSQL.selecionar(coluna, valor, false));
            if (dsFROGIOS.GRUPO.Rows.Count > 0) {
                this.ActiveControl = gRUPODataGridView;
            } else {
                this.ActiveControl = textValorPesquisa;
            }
        }

        protected override void resetar() {
            base.resetar();
            dsFROGIOS.GRUPO.Clear();
            this.ActiveControl = comboCampoPesquisa;
        }

        private void selecionarGrupo() {
            try {
                int indice = gRUPODataGridView.CurrentRow.Index;
                int codigo = (int)gRUPODataGridView[0, indice].Value;

                if (cadastro.GetType() == typeof(formCadastroGrupo)) {
                    ((formCadastroGrupo)cadastro).visualizarRegistro(codigo);
                } else if (cadastro.GetType() == typeof(formCadastroProduto)) {
                    ((formCadastroProduto)cadastro).adicionarGrupo(codigo);
                }

                this.DialogResult = DialogResult.Yes;
                this.Close();
            } catch (Exception) {
                this.ActiveControl = comboCampoPesquisa;
            }
        }

        private void gRUPODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarGrupo();
        }

        private void gRUPODataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarGrupo();
                e.SuppressKeyPress = true;
            }
        }

    }
}