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
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.InterfaceGrafica {
    public partial class formPesquisaOrcamento : formOSBasePesquisa {

        private MapOrcamento map;
        private GerOrcamento orcamentoSQL;

        public formPesquisaOrcamento() : base () {
            InitializeComponent();
            map = new MapOrcamento(dsFROGIOS.CLIENTE, dsFROGIOS.CLIENTE_FISICO, dsFROGIOS.CLIENTE_JURIDICO, dsFROGIOS.FUNCIONARIO, dsFROGIOS.ORCAMENTO);
            orcamentoSQL = new GerOrcamento();
        }

        private bool eFisico() {
            return comboTipoCliente.SelectedIndex == 0;
        }

        protected override void pesquisar() {
            try {
                Conexao.abrir();
                string coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString());
                string valor = textValorPesquisa.Text;
                if (eFisico()) {
                    dsFROGIOS.PESQUISA_ORCAMENTO_FISICO.Clear();
                    dsFROGIOS.PESQUISA_ORCAMENTO_FISICO.Load(orcamentoSQL.pesquisar(coluna, valor, eFisico()));
                } else {
                    dsFROGIOS.PESQUISA_ORCAMENTO_JURIDICO.Clear();
                    dsFROGIOS.PESQUISA_ORCAMENTO_JURIDICO.Load(orcamentoSQL.pesquisar(coluna, valor, eFisico()));
                }
            } catch (InvalidOperationException erro) {
                exibirMensagemErro(erro.Message);
            } finally {
                Conexao.fechar();
            }

            
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
            formCadastroOrcamento orcamento = new formCadastroOrcamento(true);
            orcamento.ShowDialog();
            orcamento.Dispose();
            resetar();
            Conexao.abrir();
            comboTipoCliente.SelectedIndex = 0;
            comboCampoPesquisa.SelectedIndex = 0;
            pesquisar();
            Conexao.fechar();
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.PESQUISA_ORCAMENTO_FISICO.Clear();
                dsFROGIOS.PESQUISA_ORCAMENTO_JURIDICO.Clear();
            }
        }

        private void comboTipoCliente_SelectedIndexChanged(object sender, EventArgs e) {
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
                    } else {
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
            this.ActiveControl = comboTipoCliente;
        }

        private void selecionarOrcamento() {
            try {
                int indice, codigo;
                if (eFisico()) {
                    indice = pESQUISA_ORCAMENTO_FISICODataGridView.CurrentRow.Index;
                    codigo = (int)pESQUISA_ORCAMENTO_FISICODataGridView[0, indice].Value;
                } else {
                    indice = pESQUISA_ORCAMENTO_JURIDICODataGridView.CurrentRow.Index;
                    codigo = (int)pESQUISA_ORCAMENTO_JURIDICODataGridView.CurrentRow.Index;
                }

                Conexao.abrir();
                formCadastroOrcamento orcamento = new formCadastroOrcamento(false);
                orcamento.selecionar(codigo);
                Conexao.fechar();

                orcamento.ShowDialog();
                orcamento.Dispose();

                Conexao.abrir();
                comboTipoCliente.SelectedIndex = 0;
                comboCampoPesquisa.SelectedIndex = 0;
                pesquisar();
                Conexao.fechar();

            } catch (NullReferenceException) {
                this.ActiveControl = textValorPesquisa;
                Conexao.fechar();
            } catch (FbException erro) {
                exibirMensagemErro(erro.Message);
                Conexao.fechar();
            } 
            
        }

        private void _CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarOrcamento();
        }

        private void _KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarOrcamento();
                e.SuppressKeyPress = true;
            }
        } 

    }
}
