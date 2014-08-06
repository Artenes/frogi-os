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
    public partial class formPesquisaServico : formPesquisa
    {

        private MapServico map;

        public formPesquisaServico(formCadastro cadastro, bool novoHabilitado) : base (cadastro, novoHabilitado)
        {
            InitializeComponent();
            map = new MapServico(dsFROGIOS.SERVICO);
            comboCampoPesquisa.Items.Clear();
            foreach (string coluna in map.Colunas)
            {   
                comboCampoPesquisa.Items.Add(coluna);
            }
        }

        protected override void pesquisar()
        {
            base.pesquisar();
        }

        protected override void resetar()
        {
            base.resetar();
            dsFROGIOS.SERVICO.Clear();
            this.ActiveControl = comboCampoPesquisa;
        }
    }
}