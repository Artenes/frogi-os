﻿using System;
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
    public partial class formPesquisaServico : formPesquisa {

        private MapServico map;
        private TblServico servicoSQL;

        public formPesquisaServico(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado) {
            InitializeComponent();
            map = new MapServico(dsFROGIOS.SERVICO);
            comboCampoPesquisa.Items.Clear();
            foreach (string coluna in map.Colunas) {   
                comboCampoPesquisa.Items.Add(coluna);
            }
            servicoSQL = new TblServico();
        }

        public formPesquisaServico(formOSBaseCadastro cadastro, bool novoHabilitado) : base(cadastro, novoHabilitado) {
            InitializeComponent();
            map = new MapServico(dsFROGIOS.SERVICO);
            comboCampoPesquisa.Items.Clear();
            foreach (string coluna in map.Colunas)
                comboCampoPesquisa.Items.Add(coluna);
            servicoSQL = new TblServico();
        }

        protected override void pesquisaExecutar() {
            try {
                Conexao.abrir();

                string coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString());
                string valor = textValorPesquisa.Text;

                dsFROGIOS.SERVICO.Clear();
                dsFROGIOS.SERVICO.Load(servicoSQL.selecionar(coluna, valor, false));
                this.ActiveControl = dsFROGIOS.SERVICO.Rows.Count > 0 ? sERVICODataGridView as Control : textValorPesquisa as Control;
            } catch (Exception erro) {
                exibirMensagemErro(erro.Message);
            } finally {
                Conexao.fechar();
            }
        }

        protected override void resetar() {
            base.resetar();
            dsFROGIOS.SERVICO.Clear();
            this.ActiveControl = comboCampoPesquisa;
        }

        private void selecionarServico() {
            try {
                Conexao.abrir();
                int indice = sERVICODataGridView.CurrentRow.Index;
                int codigo = (int)sERVICODataGridView[0, indice].Value;
                if (cadastro != null) {
                    ((formCadastroServico)cadastro).visualizarRegistro(codigo);
                } else  if (cadastroOS != null) {
                    if (cadastroOS.GetType() == typeof(formCadastroOrcamento))
                    {
                        ((formCadastroOrcamento)cadastroOS).selecionarServico(codigo);
                    }
                    else {
                        ((formCadastroOS)cadastroOS).selecionarServico(codigo);
                    }
                    
                }
                this.DialogResult = DialogResult.Yes;
                this.Close();
            } catch (Exception erro) {
                //exibirMensagemErro(erro.Message);
            } finally {
                Conexao.fechar();
            }
        }

        private void sERVICODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarServico();
        }

        private void sERVICODataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarServico();
                e.SuppressKeyPress = true;
            }
        }

        private void sERVICODataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            DataGridView tabela = sender as DataGridView;
            if (tabela.Columns[e.ColumnIndex].Name.Equals("colunaValor")) {
                string valor = ((double)e.Value).ToString("0.00");
                e.Value = valor;
            }
        }
    }
}