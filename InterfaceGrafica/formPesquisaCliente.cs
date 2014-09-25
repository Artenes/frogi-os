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

        protected override void pesquisaExecutar() {
            bool eFisico = comboTipo.SelectedIndex == FISICO;
            string coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString());
            string valor = textValorPesquisa.Text;
            if (eFisico) {
                dsFROGIOS.PESQUISA_CLIENTE_FISICO.Clear();
                dsFROGIOS.PESQUISA_CLIENTE_FISICO.Load(cliente.pesquisar(coluna, valor, eFisico));
            }
            else {
                dsFROGIOS.PESQUISA_CLIENTE_JURIDICO.Clear();
                dsFROGIOS.PESQUISA_CLIENTE_JURIDICO.Load(cliente.pesquisar(coluna, valor, eFisico));
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

        private void fisicoSelecionar() {
            int indice = pESQUISA_CLIENTE_FISICODataGridView.CurrentRow.Index;
            int codigo = (int)pESQUISA_CLIENTE_FISICODataGridView[0, indice].Value;
            ((formCadastroCliente)cadastro).visualizarRegistro(codigo, comboTipo.SelectedIndex == FISICO);
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void juridicoSelecionar() {
            int indice = pESQUISA_CLIENTE_JURIDICODataGridView.CurrentRow.Index;
            int codigo = (int)pESQUISA_CLIENTE_JURIDICODataGridView[0, indice].Value;
            ((formCadastroCliente)cadastro).visualizarRegistro(codigo, comboTipo.SelectedIndex == FISICO);
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void pESQUISA_CLIENTE_FISICODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            fisicoSelecionar();
        }

        private void pESQUISA_CLIENTE_FISICODataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                fisicoSelecionar();
                e.SuppressKeyPress = true;
            }
            
        }

        private void pESQUISA_CLIENTE_JURIDICODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            juridicoSelecionar();
        }

        private void pESQUISA_CLIENTE_JURIDICODataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                juridicoSelecionar();
                e.SuppressKeyPress = true;
            }
        }

    }
}