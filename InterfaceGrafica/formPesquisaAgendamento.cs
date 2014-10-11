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

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formPesquisaAgendamento : formPesquisa
    {

        private const int FISICO = 0;
        private MapAgendamento map;
        private GerAgendamento agendamentoSQL;

        public formPesquisaAgendamento(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado) {
            InitializeComponent();
            map = new MapAgendamento(dsFROGIOS.CLIENTE_FISICO, dsFROGIOS.CLIENTE_JURIDICO, dsFROGIOS.AGENDAMENTO);
            agendamentoSQL = new GerAgendamento();
        }

        private bool eFisico() {
            return comboTipo.SelectedIndex == FISICO;
        }

        protected override void pesquisaExecutar() {
            string
                coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString()),
                valor = textValorPesquisa.Text;

            if (eFisico()) {
                dsFROGIOS.PESQUISA_AGENDAMENTO_FISICO.Clear();
                dsFROGIOS.PESQUISA_AGENDAMENTO_FISICO.Load(agendamentoSQL.pesquisar(coluna, valor, eFisico()));
            } else {
                dsFROGIOS.PESQUISA_AGENDAMENTO_JURIDICO.Clear();
                dsFROGIOS.PESQUISA_AGENDAMENTO_JURIDICO.Load(agendamentoSQL.pesquisar(coluna, valor, eFisico()));
            } 
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.PESQUISA_AGENDAMENTO_FISICO.Clear();
                dsFROGIOS.PESQUISA_AGENDAMENTO_JURIDICO.Clear();
            }
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
            this.ActiveControl = comboTipo;
        }

        private void selecionarFisico() {
            try {
                int indice = pESQUISA_AGENDAMENTO_FISICODataGridView.CurrentRow.Index;
                int codigo = (int)pESQUISA_AGENDAMENTO_FISICODataGridView[0, indice].Value;
                ((formCadastroAgendamento)cadastro).visualizarRegistro(codigo);
                this.DialogResult = DialogResult.Yes;
                this.Close();
            } catch (Exception) {
                this.ActiveControl = comboTipo;
            }
        }

        private void selecionarJuridico() {
            try {
                int indice = pESQUISA_AGENDAMENTO_JURIDICODataGridView.CurrentRow.Index;
                int codigo = (int)pESQUISA_AGENDAMENTO_JURIDICODataGridView[0, indice].Value;
                ((formCadastroAgendamento)cadastro).visualizarRegistro(codigo);
                this.DialogResult = DialogResult.Yes;
                this.Close();
            } catch (Exception) {
                this.ActiveControl = comboTipo;
            }
        }

        private void pESQUISA_AGENDAMENTO_FISICODataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarFisico();
                e.SuppressKeyPress = true;
            }
        }

        private void pESQUISA_AGENDAMENTO_FISICODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarFisico();
        }

        private void pESQUISA_AGENDAMENTO_JURIDICODataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarJuridico();
                e.SuppressKeyPress = true;
            }
        }

        private void pESQUISA_AGENDAMENTO_JURIDICODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarJuridico();
        }


        
    }
}
