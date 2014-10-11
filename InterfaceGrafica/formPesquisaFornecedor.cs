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
using FROGI_OS.CamadaEnlaceDados;

namespace FROGI_OS.InterfaceGrafica {
    public partial class formPesquisaFornecedor : formPesquisa {

        private const int FISICO = 0;
        private MapFornecedor map;
        private GerFornecedor fornecedorSQL;

        public formPesquisaFornecedor(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado) {
            InitializeComponent();
            map = new MapFornecedor(dsFROGIOS.FORNECEDOR, dsFROGIOS.FORNECEDOR_FISICO, dsFROGIOS.FORNECEDOR_JURIDICO);
            fornecedorSQL = new GerFornecedor();
        }

        private bool eFisico() {
            return comboTipo.SelectedIndex == FISICO;
        }

        protected override void pesquisaExecutar() {
            string coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString());
            string valor = textValorPesquisa.Text;
            if (eFisico()) {
                dsFROGIOS.PESQUISA_FORNECEDOR_FISICO.Clear();
                dsFROGIOS.PESQUISA_FORNECEDOR_FISICO.Load(fornecedorSQL.pesquisar(coluna, valor, eFisico()));
            } else {
                dsFROGIOS.PESQUISA_FORNECEDOR_JURIDICO.Clear();
                dsFROGIOS.PESQUISA_FORNECEDOR_JURIDICO.Load(fornecedorSQL.pesquisar(coluna, valor, eFisico()));
            }
        }

        protected override void resetar() {
            comboTipo.SelectedIndex = FISICO;
            base.resetar();
            dsFROGIOS.PESQUISA_FORNECEDOR_FISICO.Clear();
            dsFROGIOS.PESQUISA_FORNECEDOR_JURIDICO.Clear();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox != null) {
                object item = comboBox.SelectedItem;
                if (item != null) {
                    comboCampoPesquisa.Items.Clear();
                    if (item.ToString() == "Físico") {
                        tablessPai.SelectedTab = tabFisico;
                        foreach (string coluna in map.ColunasFisico) {
                            comboCampoPesquisa.Items.Add(coluna);
                        }
                    }
                    else {
                        tablessPai.SelectedTab = tabJuridico;
                        foreach (string coluna in map.ColunasJuridico) {
                            comboCampoPesquisa.Items.Add(coluna);
                        }
                    }
                    comboCampoPesquisa.Enabled = true;
                    textValorPesquisa.Enabled = false;
                    buttonPesquisar.Enabled = false;
                }
            }
            this.ActiveControl = comboTipo;
        }

        private void selecionarFornecedor(bool eFisico) {
            try {
                Conexao.abrir();
                if (eFisico) {
                    selecionarFisico();
                } else {
                    selecionarJuridico();
                }
            } catch (Exception erro) {
                //dialogo.compor("Temos um problema", erro.Message, formDialogo.TipoExpressao.AvisoTriste).ShowDialog();
            } finally {
                Conexao.fechar();
            }
        }

        private void selecionarFisico() {
            int indice = pESQUISA_FORNECEDOR_FISICODataGridView.CurrentRow.Index;
            int codigo = (int)pESQUISA_FORNECEDOR_FISICODataGridView[0, indice].Value;
            if (cadastro.GetType() == typeof(formCadastroFornecedor)) {
                ((formCadastroFornecedor)cadastro).visualizarRegistro(codigo, eFisico());        
            } else if (cadastro.GetType() == typeof(formCadastroProduto)) {
                ((formCadastroProduto)cadastro).adicionarFornecedor(codigo, true);
            }
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void selecionarJuridico() {
            int indice = pESQUISA_FORNECEDOR_JURIDICODataGridView.CurrentRow.Index;
            int codigo = (int)pESQUISA_FORNECEDOR_JURIDICODataGridView[0, indice].Value;
            if (cadastro.GetType() == typeof(formCadastroFornecedor)) {
                ((formCadastroFornecedor)cadastro).visualizarRegistro(codigo, eFisico());
            } else if (cadastro.GetType() == typeof(formCadastroProduto)) {
                ((formCadastroProduto)cadastro).adicionarFornecedor(codigo, false);
            }
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void pESQUISA_FORNECEDOR_FISICODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarFornecedor(true);
        }

        private void pESQUISA_FORNECEDOR_FISICODataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarFornecedor(true);
                e.SuppressKeyPress = true;
            }
        }

        private void pESQUISA_FORNECEDOR_JURIDICODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarFornecedor(false);
        }

        private void pESQUISA_FORNECEDOR_JURIDICODataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarFornecedor(false);
                e.SuppressKeyPress = true;
            }
        }

    }
}