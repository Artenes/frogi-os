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
    public partial class formPesquisaFuncionario : formPesquisa {

        private MapFuncionario map;
        private TblFuncionario funcionarioSQL;

        public formPesquisaFuncionario(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado) {
            InitializeComponent();
            map = new MapFuncionario(dsFROGIOS.FUNCIONARIO);
            comboCampoPesquisa.Items.Clear();
            foreach (string coluna in map.Colunas){
                comboCampoPesquisa.Items.Add(coluna);
            }
            funcionarioSQL = new TblFuncionario();
        }

        public formPesquisaFuncionario(formOSBaseCadastro cadastro, bool novoHabilitado) : base(cadastro, novoHabilitado) {
            InitializeComponent();
            map = new MapFuncionario(dsFROGIOS.FUNCIONARIO);
            comboCampoPesquisa.Items.Clear();
            foreach (string coluna in map.Colunas) {
                comboCampoPesquisa.Items.Add(coluna);
            }
            funcionarioSQL = new TblFuncionario();
        }

        protected override void pesquisaExecutar() {
            string coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString());
            string valor = textValorPesquisa.Text;
            dsFROGIOS.FUNCIONARIO.Clear();
            dsFROGIOS.FUNCIONARIO.Load(funcionarioSQL.selecionar(coluna, valor, false));
        }

        protected override void resetar() {
            base.resetar();
            dsFROGIOS.FUNCIONARIO.Clear();
            this.ActiveControl = comboCampoPesquisa;
        }

        private void selecionarFuncionario() {
            try {
                int indice = fUNCIONARIODataGridView.CurrentRow.Index;
                int codigo = (int)fUNCIONARIODataGridView[0, indice].Value;
                if (cadastro != null) {
                    if (cadastro.GetType() == typeof(formCadastroFuncionario)) {
                        ((formCadastroFuncionario)cadastro).visualizarRegistro(codigo);    
                    } else if (cadastro.GetType() == typeof(formCadastroCompra)) {
                        ((formCadastroCompra)cadastro).inserirFuncionario(codigo);
                    } 
                } else if (cadastroOS != null) {
                    try {
                        Conexao.abrir();
                        if (cadastroOS.GetType() == typeof(formCadastroOrcamento))
                        {
                            ((formCadastroOrcamento)cadastroOS).selecionarFuncionario(codigo);
                        }
                        else
                        {
                            ((formCadastroOS)cadastroOS).selecionarFuncionario(codigo);
                        }
                        
                    } catch (Exception erro) {
                        exibirMensagemErro(erro.Message);
                    } finally {
                        Conexao.fechar();
                    }
                }
                this.DialogResult = DialogResult.Yes;
                this.Close();
            } catch (Exception) {
                this.ActiveControl = comboCampoPesquisa;
            }
        }

        private void fUNCIONARIODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarFuncionario();
        }

        private void fUNCIONARIODataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarFuncionario();
                e.SuppressKeyPress = true;
            }
        }


    }
}