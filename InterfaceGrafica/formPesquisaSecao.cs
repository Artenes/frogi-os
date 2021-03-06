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
    public partial class formPesquisaSecao : formPesquisa {

        private MapSecao map;
        private TblSecao secaoSQL;

        public formPesquisaSecao(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado) {
            InitializeComponent();
            map = new MapSecao(dsFROGIOS.SECAO);
            comboCampoPesquisa.Items.Clear();
            foreach (string coluna in map.Colunas)
            {
                comboCampoPesquisa.Items.Add(coluna);
            }
            secaoSQL = new TblSecao();
        }

        protected override void pesquisaExecutar() {
            string coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString());
            string valor = textValorPesquisa.Text;
            dsFROGIOS.SECAO.Clear();
            dsFROGIOS.SECAO.Load(secaoSQL.selecionar(coluna, valor, false));
            if (dsFROGIOS.SECAO.Rows.Count > 0) {
                this.ActiveControl = sECAODataGridView;
            } else {
                this.ActiveControl = textValorPesquisa;
            }
        }


        protected override void resetar() {
            base.resetar();
            dsFROGIOS.SECAO.Clear();
            this.ActiveControl = comboCampoPesquisa;
        }

        private void selecionarSecao() {
            try {
                int indice = sECAODataGridView.CurrentRow.Index;
                int codigo = (int)sECAODataGridView[0, indice].Value;
                if (cadastro.GetType() == typeof(formCadastroSecao)) {
                    ((formCadastroSecao)cadastro).visualizarRegistro(codigo);
                } else if (cadastro.GetType() == typeof(formCadastroProduto)) {
                    ((formCadastroProduto)cadastro).adicionarSecao(codigo);
                }
                this.DialogResult = DialogResult.Yes;
                Close();
            } catch (Exception) {
                this.ActiveControl = comboCampoPesquisa;
            }
        }

        private void sECAODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selecionarSecao();
        }

        private void sECAODataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                selecionarSecao();
                e.SuppressKeyPress = true;
            }
        }
    }
}