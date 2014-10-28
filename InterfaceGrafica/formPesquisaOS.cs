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

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formPesquisaOS : formOSBasePesquisa
    {

        private MapOS map;
        private GerOs osSQL;

        public formPesquisaOS() : base ()
        {
            InitializeComponent();
            map = new MapOS(dsFROGIOS.CLIENTE, dsFROGIOS.CLIENTE_FISICO, dsFROGIOS.CLIENTE_JURIDICO, dsFROGIOS.FUNCIONARIO, dsFROGIOS.OS);
            osSQL = new GerOs();
        }

        private bool eFisico()
        {
            return comboTipoCliente.SelectedIndex == 0;
        }

        protected override void pesquisar()
        {
            try
            {
                Conexao.abrir();
                string coluna = map.paraColuna(comboCampoPesquisa.SelectedItem.ToString());
                string valor = textValorPesquisa.Text;
                if (eFisico())
                {
                    dsFROGIOS.PESQUISA_OS_FISICO.Clear();
                    dsFROGIOS.PESQUISA_OS_FISICO.Load(osSQL.pesquisar(coluna, valor, eFisico()));
                }
                else
                {
                    dsFROGIOS.PESQUISA_OS_JURIDICO.Clear();
                    dsFROGIOS.PESQUISA_OS_JURIDICO.Load(osSQL.pesquisar(coluna, valor, eFisico()));
                }
            }
            catch (Exception erro)
            {
                exibirMensagemErro(erro.Message);
            }
            finally {
                Conexao.fechar();
            }
        }

        protected override void preencherCampoPesquisa(bool eFisico) {
            base.preencherCampoPesquisa(eFisico);
            if (map != null) {
                comboCampoPesquisa.Items.Clear();
                if (eFisico) {
                    foreach (string coluna in map.ColunasFisico) {
                        comboCampoPesquisa.Items.Add(coluna);
                    }
                }
                else {
                    foreach (string coluna in map.ColunasJuridico) {
                        comboCampoPesquisa.Items.Add(coluna);
                    }
                }
            }
        }

        protected override void novoRegistro()
        {
            base.novoRegistro();
            formCadastroOS os = new formCadastroOS(true);
            os.ShowDialog();
            os.Dispose();
            resetar();
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.PESQUISA_OS_FISICO.Clear();
                dsFROGIOS.PESQUISA_OS_JURIDICO.Clear();
            }
        }

        private void comboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
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
            this.ActiveControl = comboTipoCliente;
        }

        private void selecionarOs()
        {
            try
            {
                int indice, codigo;
                if (eFisico())
                {
                    indice = pESQUISA_OS_FISICODataGridView.CurrentRow.Index;
                    codigo = (int)pESQUISA_OS_FISICODataGridView[0, indice].Value;
                }
                else
                {
                    indice = pESQUISA_OS_JURIDICODataGridView.CurrentRow.Index;
                    codigo = (int)pESQUISA_OS_JURIDICODataGridView.CurrentRow.Index;
                }

                Conexao.abrir();
                formCadastroOS os = new formCadastroOS(false);
                os.selecionar(codigo);
                Conexao.fechar();

                os.ShowDialog();
                os.Dispose();

                Conexao.abrir();
                comboTipoCliente.SelectedIndex = 0;
                comboCampoPesquisa.SelectedIndex = 0;
                pesquisar();
                Conexao.fechar();
            }
            catch (NullReferenceException)
            {
                this.ActiveControl = textValorPesquisa;
                Conexao.fechar();
            }
            catch (FbException erro)
            {
                exibirMensagemErro(erro.Message);
                Conexao.fechar();
            }
        }

        private void _CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionarOs();
        }

        private void _KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                selecionarOs();
                e.SuppressKeyPress = true;
            }
        } 

        protected override void comboCampoPesquisa_SelectedIndexChanged(object sender, EventArgs e) {
            base.comboCampoPesquisa_SelectedIndexChanged(sender, e);
            string coluna = comboCampoPesquisa.Text;
            if (coluna == map.Status)
            {
                textValorPesquisa.Visible = false;
                comboStatus.Visible = true;
            }
            else {
                textValorPesquisa.Visible = true;
                comboStatus.Visible = false;
            }
        }

        private void comboStatus_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                pesquisar();
            }
        }

    }
}