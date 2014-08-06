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

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formPesquisaFornecedor : formPesquisa
    {

        private const int FISICO = 0;
        private MapFornecedor map;

        public formPesquisaFornecedor(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado) 
        {
            InitializeComponent();
            map = new MapFornecedor(dsFROGIOS.FORNECEDOR, dsFROGIOS.FORNECEDOR_FISICO, dsFROGIOS.FORNECEDOR_JURIDICO);
        }

        protected override void pesquisar()
        {
            base.pesquisar();
        }

        protected override void resetar()
        {
            comboTipo.SelectedIndex = FISICO;
            base.resetar();
            dsFROGIOS.PESQUISA_FORNECEDOR_FISICO.Clear();
            dsFROGIOS.PESQUISA_FORNECEDOR_JURIDICO.Clear();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox != null)
            {
                object item = comboBox.SelectedItem;
                if (item != null)
                {
                    comboCampoPesquisa.Items.Clear();
                    if (item.ToString() == "Físico")
                    {
                        tablessPai.SelectedTab = tabFisico;
                        foreach (string coluna in map.ColunasFisico)
                        {
                            comboCampoPesquisa.Items.Add(coluna);
                        }
                    }
                    else
                    {
                        tablessPai.SelectedTab = tabJuridico;
                        foreach (string coluna in map.ColunasJuridico)
                        {
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
    }
}
