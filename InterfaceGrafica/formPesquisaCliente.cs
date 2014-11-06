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
    public partial class formPesquisaCliente : formPesquisa {

        private const int FISICO = 0;
        private MapCliente map;
        private GerCliente cliente;

        public formPesquisaCliente(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado) {
            InitializeComponent();
            map = new MapCliente(dsFROGIOS.CLIENTE, dsFROGIOS.CLIENTE_FISICO, dsFROGIOS.CLIENTE_JURIDICO);
            cliente = new GerCliente();
        }

        public formPesquisaCliente(formOSBaseCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado) {
            InitializeComponent();
            map = new MapCliente(dsFROGIOS.CLIENTE, dsFROGIOS.CLIENTE_FISICO, dsFROGIOS.CLIENTE_JURIDICO);
            cliente = new GerCliente();
        }

        private bool eFisico() {
            return comboTipo.SelectedIndex == FISICO;
        }

        protected override void pesquisaExecutar() {
            bool eFisico = comboTipo.SelectedIndex == FISICO;
            string coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString());
            string valor = textValorPesquisa.Text;
            if (eFisico) {
                dsFROGIOS.PESQUISA_CLIENTE_FISICO.Clear();
                dsFROGIOS.PESQUISA_CLIENTE_FISICO.Load(cliente.pesquisar(coluna, valor, eFisico));
                this.ActiveControl = dsFROGIOS.PESQUISA_CLIENTE_FISICO.Rows.Count > 0 ? pESQUISA_CLIENTE_FISICODataGridView as Control : textValorPesquisa as Control;
            }
            else {
                dsFROGIOS.PESQUISA_CLIENTE_JURIDICO.Clear();
                dsFROGIOS.PESQUISA_CLIENTE_JURIDICO.Load(cliente.pesquisar(coluna, valor, eFisico));
                this.ActiveControl = dsFROGIOS.PESQUISA_CLIENTE_JURIDICO.Rows.Count > 0 ? pESQUISA_CLIENTE_JURIDICODataGridView as Control : textValorPesquisa as Control;
            }
        }

        protected override void resetar() {
            comboTipo.SelectedIndex = FISICO;
            base.resetar();
            dsFROGIOS.PESQUISA_CLIENTE_FISICO.Clear();
            dsFROGIOS.PESQUISA_CLIENTE_JURIDICO.Clear();
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

        private void selecionarCliente () {
            try {
                int indice, codigo;
                if (eFisico()) {
                    indice = pESQUISA_CLIENTE_FISICODataGridView.CurrentRow.Index;
                    codigo = (int)pESQUISA_CLIENTE_FISICODataGridView[0, indice].Value;
                } else {
                    indice = pESQUISA_CLIENTE_JURIDICODataGridView.CurrentRow.Index;
                    codigo = (int)pESQUISA_CLIENTE_JURIDICODataGridView[0, indice].Value;
                }

                if (cadastro != null) {
                    if (cadastro.GetType() == typeof(formCadastroCliente)) {
                        ((formCadastroCliente)cadastro).visualizarRegistro(codigo, eFisico());
                    } else if (cadastro.GetType() == typeof(formCadastroAgendamento)) {
                        ((formCadastroAgendamento)cadastro).adicionarCliente(codigo, eFisico());
                    }
                } else if (cadastroOS != null) {
                    try {
                        Conexao.abrir();
                        if (cadastroOS.GetType() == typeof(formCadastroOrcamento))
                        {
                            ((formCadastroOrcamento)cadastroOS).selecionarCliente(codigo, eFisico());
                        }
                        else {
                            ((formCadastroOS)cadastroOS).selecionarCliente(codigo, eFisico());
                        }
                        
                    } catch (Exception erro) {
                        exibirMensagemErro(erro.Message);
                    } finally {
                        Conexao.fechar();
                    }                    
                }
                
                this.DialogResult = DialogResult.Yes;
                this.Close();
            } catch (Exception erro) {
                this.ActiveControl = comboTipo;
                //exibirMensagemErro(erro.Message);
            }

        }

        private void _CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarCliente();
        }

        private void _KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarCliente();
                e.SuppressKeyPress = true;
            }
        }

    }
}