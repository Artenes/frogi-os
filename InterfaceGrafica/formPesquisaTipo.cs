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

namespace FROGI_OS.InterfaceGrafica {
    public partial class formPesquisaTipo : formPesquisa {

        private MapTipo map;
        private TblTipo tipoSQL;

        public formPesquisaTipo(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado) {
            InitializeComponent();
            map = new MapTipo(dsFROGIOS.TIPO);
            comboCampoPesquisa.Items.Clear();
            foreach (string coluna in map.Colunas) {
                comboCampoPesquisa.Items.Add(coluna);
            }
            tipoSQL = new TblTipo();
        }

        protected override void pesquisaExecutar() {
            string coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString());
            string valor = textValorPesquisa.Text;
            dsFROGIOS.TIPO.Clear();
            dsFROGIOS.TIPO.Load(tipoSQL.selecionar(coluna, valor, false));
            if (dsFROGIOS.TIPO.Rows.Count > 0) {
                this.ActiveControl = tIPODataGridView;
            } else {
                this.ActiveControl = textValorPesquisa;
            }
        }

        protected override void resetar() {
            base.resetar();
            dsFROGIOS.TIPO.Clear();
            this.ActiveControl = comboCampoPesquisa;
        }

        private void selecionarTipo() {

            try {
                int indice = tIPODataGridView.CurrentRow.Index; //Aqui pegamos a linha selecionada
                int codigo = (int)tIPODataGridView[0, indice].Value; //e Aqui pegamos o código da linha selecionada
                //Firulas :T
                if (cadastro.GetType() == typeof(formCadastroServico)) { //Se o cadastro for lá dos serviços
                    try {
                        Conexao.abrir();
                        ((formCadastroServico)cadastro).adicionarTipo(codigo); //Bora é adicionar o tipo à lista de tipos do serviço
                    } catch (Exception erro) {
                        exibirMensagemErro(erro.Message);
                    } finally {
                        Conexao.fechar();
                    }
                } else if (cadastro.GetType() == typeof(formCadastroTipo)) {
                    try {
                        Conexao.abrir();
                        ((formCadastroTipo)cadastro).visualizarRegistro(codigo);
                        this.DialogResult = DialogResult.Yes; //Aqui precisa do dialog result pois tamo usando o método lá do cadastro de tipo
                    } catch (Exception erro) {
                        exibirMensagemErro(erro.Message);
                    } finally {
                        Conexao.fechar();
                    }
                }
                this.Close();
            } catch (Exception) {
                this.ActiveControl = comboCampoPesquisa;
            }
        }

        private void tIPODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarTipo();
        }

        private void tIPODataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarTipo();
                e.SuppressKeyPress = true;
            }
        }

    }
}