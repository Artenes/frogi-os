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
    public partial class formPesquisaUsuario : formPesquisa {

        private MapUsuario map;
        private TblUsuario usuarioSQL;

        public formPesquisaUsuario(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado) {
            InitializeComponent();
            map = new MapUsuario(dsFROGIOS.USUARIO);
            comboCampoPesquisa.Items.Clear();
            foreach (string coluna in map.Colunas) comboCampoPesquisa.Items.Add(coluna);
            usuarioSQL = new TblUsuario();
        }

        protected override void pesquisaExecutar() {
            string coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString());
            string valor = textValorPesquisa.Text;
            dsFROGIOS.USUARIO.Clear();
            dsFROGIOS.USUARIO.Load(usuarioSQL.selecionar(coluna, valor, false));
            if (dsFROGIOS.USUARIO.Rows.Count > 0) {
                this.ActiveControl = uSUARIODataGridView;
            } else {
                this.ActiveControl = textValorPesquisa;
            }
        }

        protected override void resetar() {
            base.resetar();
            dsFROGIOS.USUARIO.Clear();
            this.ActiveControl = comboCampoPesquisa;
        }

        private void selecionarUsuario() {
            try {
                int indice = uSUARIODataGridView.CurrentRow.Index;
                int codigo = (int)uSUARIODataGridView[0, indice].Value;
                ((formCadastroUsuario)cadastro).visualizarRegistro(codigo);
                this.DialogResult = DialogResult.Yes;
                this.Close();
            } catch (Exception) {
                this.ActiveControl = comboCampoPesquisa;
            }
        }

        private void uSUARIODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarUsuario();
        }

        private void uSUARIODataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarUsuario();
                e.SuppressKeyPress = true;
            }
        }
    }
}