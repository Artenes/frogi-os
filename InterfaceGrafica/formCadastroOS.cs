using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FROGI_OS.CamadaEnlaceDados;

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formCadastroOS : formOSBaseCadastro
    {

        private GerOs osSQL;
        private dsFROGIOS.OS_ITEMRow itemAtual;
        private dsFROGIOS.OS_SERVICORow servicoAtual;

        public formCadastroOS(bool eNovo) : base (eNovo)
        {
            InitializeComponent();
            osSQL = new GerOs();
            dsFROGIOS.EnforceConstraints = false;
            if (eNovo)
            {
                oS_TOTAL_ITEMTextBox.Text = "0,0";
                oS_TOTAL_SERVICOTextBox.Text = "0,0";
                textTotalBruto.Text = "0,0";
                textTotal.Text = "0,0";
                oS_DESCONTOTextBox.Text = "0,0";
                oS_ACRESCIMOTextBox.Text = "0,0";
                oS_DATALabel1.Text = DateTime.Now.ToShortDateString();
                campos(true);
                panelCodigo.Visible = false;
            }
        }

        protected override void salvarExecutar()
        {
            if (dsFROGIOS.OS.Rows.Count == 0)
            {
                osSQL.inserir(pegarValorCamposOs(null), dsFROGIOS.OS_ITEM, dsFROGIOS.OS_SERVICO);
            }
            else
            {
                object codigo = ((dsFROGIOS.OSRow)dsFROGIOS.OS.Rows[0]).OS_CODIGO;
                osSQL.atualizar(pegarValorCamposOs(codigo), dsFROGIOS.OS_ITEM, dsFROGIOS.OS_SERVICO);
            }
        }

        private dsFROGIOS.OSRow pegarValorCamposOs(object codigo) {
            dsFROGIOS.OSRow osRow = dsFROGIOS.OS.NewOSRow();
            if (codigo != null)
            {
                osRow.OS_CODIGO = (int)codigo;
                osRow.OS_DATA = (dsFROGIOS.OS.Rows[0] as dsFROGIOS.OSRow).OS_DATA;
            }
            else
            {
                osRow.OS_DATA = DateTime.Now;
            }

            osRow.OS_CLIENTE = (dsFROGIOS.CLIENTE.Rows[0] as dsFROGIOS.CLIENTERow).CLIENTE_CODIGO;
            osRow.OS_FUNCIONARIO = (dsFROGIOS.FUNCIONARIO.Rows[0] as dsFROGIOS.FUNCIONARIORow).FUNCIONARIO_CODIGO;
            osRow.OS_TOTAL_ITEM = converterParaDouble(oS_TOTAL_ITEMTextBox.Text);
            osRow.OS_TOTAL_SERVICO = converterParaDouble(oS_TOTAL_SERVICOTextBox.Text);
            osRow.OS_DESCONTO = converterParaDouble(oS_DESCONTOTextBox.Text);
            osRow.OS_ACRESCIMO = converterParaDouble(oS_ACRESCIMOTextBox.Text);
            osRow.OS_FORMA_PAGAMENTO = oS_FORMA_PAGAMENTOComboBox.Text;
            osRow.OS_TOTAL = converterParaDouble(textTotal.Text);
            osRow.OS_PRODUTO = oS_PRODUTOTextBox.Text;
            osRow.OS_DEFEITO = oS_DEFEITORichTextBox.Text;
            osRow.OS_AVULSOS = oS_AVULSOSRichTextBox.Text;
            osRow.OS_DIAGNOSTICO = oS_DIAGNOSTICORichTextBox.Text;
            osRow.OS_STATUS = oS_STATUSComboBox.Text;
            osRow.OS_OBSERVACAO = oS_OBSERVACAORichTextBox.Text;
            osRow.OS_DATA_ENTREGA = oS_DATA_ENTREGADateTimePicker.Value;
            return osRow;
        }

        protected override void editar()
        {
            base.editar();
            tabPai.SelectedTab = tabGeral;
            this.oS_STATUSComboBox.Enabled = true;
            this.ActiveControl = oS_TOTAL_ITEMTextBox;
        }

        protected override void excluirExecutar()
        {
            osSQL.deletar((dsFROGIOS.OSRow)dsFROGIOS.OS.Rows[0]);
        }

        protected override void resetar()
        {
            base.resetar();
            if (dsFROGIOS != null)
            {
                dsFROGIOS.Clear();
            }
        }

        protected override void campos(bool estaDisponivel) {
            base.campos(estaDisponivel);
        }

        protected override string validarCampos()
        {
            
            if (dsFROGIOS.CLIENTE.Rows.Count == 0) return "Informe o cliente para a ordem de serviço";
            if (dsFROGIOS.FUNCIONARIO.Rows.Count == 0) return "Informe o funcionário responsável pela ordem de serviço";
            if (oS_STATUSComboBox.SelectedItem == null) return "Informe o status da ordem de serviço";

            return base.validarCampos();
        }

        public override void selecionar(int codigo)
        {
            osSQL.selecionar(codigo, dsFROGIOS.OS, dsFROGIOS.OS_ITEM, dsFROGIOS.OS_SERVICO, dsFROGIOS.CLIENTE, dsFROGIOS.CLIENTE_FISICO, dsFROGIOS.CLIENTE_JURIDICO, dsFROGIOS.FUNCIONARIO);
            if (dsFROGIOS.CLIENTE_FISICO.Rows.Count != 0)
            {
                labelCliente.Text = ((dsFROGIOS.CLIENTE_FISICORow)dsFROGIOS.CLIENTE_FISICO.Rows[0]).CLIENTE_FISICO_NOME;
            }
            else
            {
                labelCliente.Text = ((dsFROGIOS.CLIENTE_JURIDICORow)dsFROGIOS.CLIENTE_JURIDICO.Rows[0]).CLIENTE_JURIDICO_FANTASIA;
            }
            labelFuncionario.Text = ((dsFROGIOS.FUNCIONARIORow)dsFROGIOS.FUNCIONARIO.Rows[0]).FUNCIONARIO_NOME;
            calcularTotais();
            this.ActiveControl = labelCliente;
            this.oS_STATUSComboBox.Enabled = false;
            this.labelCodigo.Text = (dsFROGIOS.OS.Rows[0] as dsFROGIOS.OSRow).OS_CODIGO.ToString();
        }

        public void selecionarCliente(int codigo, bool eFisico)
        {
            GerCliente cliente = new GerCliente();
            cliente.selecionar(codigo, dsFROGIOS.CLIENTE, eFisico ? dsFROGIOS.CLIENTE_FISICO : null, eFisico ? null : dsFROGIOS.CLIENTE_JURIDICO);
            if (eFisico)
            {
                labelCliente.Text = ((dsFROGIOS.CLIENTE_FISICORow)dsFROGIOS.CLIENTE_FISICO.Rows[0]).CLIENTE_FISICO_NOME;
            }
            else
            {
                labelCliente.Text = ((dsFROGIOS.CLIENTE_JURIDICORow)dsFROGIOS.CLIENTE_JURIDICO.Rows[0]).CLIENTE_JURIDICO_FANTASIA;
            }
            cliente = null;
        }

        public void selecionarFuncionario(int codigo)
        {
            GerFuncionario funcionario = new GerFuncionario();
            funcionario.selecionar(codigo, dsFROGIOS.FUNCIONARIO, null);
            labelFuncionario.Text = ((dsFROGIOS.FUNCIONARIORow)dsFROGIOS.FUNCIONARIO.Rows[0]).FUNCIONARIO_NOME;
            funcionario = null;
        }

        public void selecionarProduto(int codigo)
        {
            GerProduto produto = new GerProduto();
            produto.selecionar(codigo, dsFROGIOS.PRODUTO, dsFROGIOS.MARCA, dsFROGIOS.GRUPO, dsFROGIOS.SECAO, dsFROGIOS.FORNECEDOR, dsFROGIOS.FORNECEDOR_FISICO, dsFROGIOS.FORNECEDOR_JURIDICO);
            produto = null;
        }

        public void selecionarServico(int codigo)
        {
            GerServico servico = new GerServico();
            servico.selecionar(codigo, dsFROGIOS.SERVICO, dsFROGIOS.TIPO);
            servico = null;
        }

        private void labelCliente_Click(object sender, EventArgs e)
        {
            formPesquisaCliente cliente = new formPesquisaCliente(this, false);
            cliente.ShowDialog();
            cliente.Dispose();

        }

        private void labelFuncionario_Click(object sender, EventArgs e)
        {
            formPesquisaFuncionario funcionario = new formPesquisaFuncionario(this, false);
            funcionario.ShowDialog();
            funcionario.Dispose();
        }

        private void buttonPesquisarProduto_Click(object sender, EventArgs e)
        {
            formPesquisaProduto produto = new formPesquisaProduto(this, false);
            produto.ShowDialog();
            produto.Dispose();
            textPecaDesconto.Text = "0,00";
            textPecaQuantidade.Text = "1";
        }

        private void buttonAplicar_Click(object sender, EventArgs e)
        {
            aplicarDescontoAcrescimo();
        }

        private void buttonLancarProduto_Click(object sender, EventArgs e) {
            if (dsFROGIOS.PRODUTO.Rows.Count != 0) {
                dsFROGIOS.OS_ITEMRow item = (itemAtual != null) ? itemAtual : dsFROGIOS.OS_ITEM.NewOS_ITEMRow();
                dsFROGIOS.PRODUTORow produto = (dsFROGIOS.PRODUTORow)dsFROGIOS.PRODUTO.Rows[0];

                item.OS_ITEM_PRODUTO = produto.PRODUTO_CODIGO;
                item.OS_ITEM_VALOR = converterParaDouble(pRODUTO_PRECO_VENDATextBox.Text); //produto.PRODUTO_PRECO_VENDA;
                item.OS_ITEM_DESCRICAO = produto.PRODUTO_DESCRICAO;
                item.OS_ITEM_DESCONTO = converterParaDouble(textPecaDesconto.Text);
                item.OS_ITEM_QUANTIDADE = converterParaShort(textPecaQuantidade.Text);

                //Calculo do total
                double
                    valor = (item.OS_ITEM_VALOR * item.OS_ITEM_QUANTIDADE),
                    desconto = item.OS_ITEM_DESCONTO,
                    total;

                if (desconto != 0 && desconto < valor)
                {
                    total = valor - desconto;
                }
                else
                {
                    total = valor;
                }

                item.OS_ITEM_TOTAL = total;

                if (itemAtual == null)
                {
                    dsFROGIOS.OS_ITEM.Rows.Add(item.ItemArray);
                }
                
                itemAtual = null;
                dsFROGIOS.PRODUTO.Clear();
                textPecaDesconto.Text = null;
                textPecaQuantidade.Text = null;
            }
        }

        private void oS_ITEMDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = oS_ITEMDataGridView.CurrentRow.Index;
            itemAtual = (dsFROGIOS.OS_ITEMRow)dsFROGIOS.OS_ITEM.Rows[indice];
            dsFROGIOS.PRODUTO.Clear();
            dsFROGIOS.PRODUTORow produto = dsFROGIOS.PRODUTO.NewPRODUTORow();
            produto.PRODUTO_CODIGO = itemAtual.OS_ITEM_PRODUTO;
            produto.PRODUTO_PRECO_VENDA = itemAtual.OS_ITEM_VALOR;
            produto.PRODUTO_DESCRICAO = itemAtual.OS_ITEM_DESCRICAO;
            dsFROGIOS.PRODUTO.AddPRODUTORow(produto);
            textPecaDesconto.Text = itemAtual.OS_ITEM_DESCONTO.ToString("0.00");
            textPecaQuantidade.Text = itemAtual.OS_ITEM_QUANTIDADE.ToString();
        }

        private void buttonPesquisarServico_Click(object sender, EventArgs e)
        {
            formPesquisaServico servico = new formPesquisaServico(this, false);
            servico.ShowDialog();
            servico.Dispose();
            textServicoAcrescimo.Text = "0,00";
            textServicoDesconto.Text = "0,00";
        }

        private void buttonLancarServico_Click(object sender, EventArgs e)
        {
            if (dsFROGIOS.SERVICO.Rows.Count != 0)
            {
                dsFROGIOS.OS_SERVICORow servicoItem = (servicoAtual != null) ? servicoAtual : dsFROGIOS.OS_SERVICO.NewOS_SERVICORow();
                dsFROGIOS.SERVICORow servico = (dsFROGIOS.SERVICORow)dsFROGIOS.SERVICO.Rows[0];

                servicoItem.OS_SERVICO_SERVICO = servico.SERVICO_CODIGO;
                servicoItem.OS_SERVICO_VALOR = servico.SERVICO_VALOR;
                servicoItem.OS_SERVICO_DESCRICAO = servico.SERVICO_DESCRICAO;
                servicoItem.OS_SERVICO_DESCONTO = converterParaDouble(textServicoDesconto.Text);
                servicoItem.OS_SERVICO_ACRESCIMO = converterParaDouble(textServicoAcrescimo.Text);

                //calculo do total
                double
                    valor = servicoItem.OS_SERVICO_VALOR,
                    desconto = servicoItem.OS_SERVICO_DESCONTO,
                    acrescimo = servicoItem.OS_SERVICO_ACRESCIMO,
                    total;

                if (desconto != 0 && desconto < valor)
                {
                    total = valor - desconto;
                }
                else
                {
                    total = valor + acrescimo;
                }

                servicoItem.OS_SERVICO_TOTAL = total;

                if (servicoAtual == null)
                {
                    dsFROGIOS.OS_SERVICO.Rows.Add(servicoItem.ItemArray);
                }
                
                servicoAtual = null;
                dsFROGIOS.SERVICO.Clear();
                textServicoAcrescimo.Text = null;
                textServicoDesconto.Text = null;
            }
        }

        private void oS_SERVICODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = oS_SERVICODataGridView.CurrentRow.Index;
            servicoAtual = (dsFROGIOS.OS_SERVICORow)dsFROGIOS.OS_SERVICO.Rows[indice];
            dsFROGIOS.SERVICO.Clear();
            dsFROGIOS.SERVICORow servico = dsFROGIOS.SERVICO.NewSERVICORow();
            servico.SERVICO_CODIGO = servicoAtual.OS_SERVICO_SERVICO;
            servico.SERVICO_VALOR = servicoAtual.OS_SERVICO_VALOR;
            servico.SERVICO_DESCRICAO = servicoAtual.OS_SERVICO_DESCRICAO;
            dsFROGIOS.SERVICO.AddSERVICORow(servico);
            textServicoDesconto.Text = servicoAtual.OS_SERVICO_DESCONTO.ToString("0.00");
            textServicoAcrescimo.Text = servicoAtual.OS_SERVICO_ACRESCIMO.ToString("0.00");
        }

        private void aplicarDescontoAcrescimo()
        {

            double
               totalBruto = converterParaDouble(textTotalBruto.Text),
               acrescimo = converterParaDouble(oS_ACRESCIMOTextBox.Text),
               desconto = converterParaDouble(oS_DESCONTOTextBox.Text);

            try
            {
                if (acrescimo != 0 && acrescimo > 0)
                {
                    textTotal.Text = (totalBruto + acrescimo).ToString("0.00");
                }
                else if (desconto != 0 && desconto > 0 && desconto < totalBruto)
                {
                    textTotal.Text = (totalBruto - desconto).ToString("0.00");
                }
                else {
                    textTotal.Text = totalBruto.ToString("0.00");
                }
            }
            catch (Exception erro)
            {
                exibirMensagemErro(erro.Message);
            }
        }

        private void calcularTotais()
        {
            double
                    totalPecasBruto = 0,
                    totalServicosBruto = 0,
                    totalPecasLiquido = 0,
                    totalServicosLiquido = 0,
                    totalBruto,
                    totalLiquido;

            bool aplica = true;

            foreach (dsFROGIOS.OS_ITEMRow item in dsFROGIOS.OS_ITEM.Rows)
            {
                if (item.RowState != DataRowState.Deleted)
                {
                    totalPecasBruto += (item.OS_ITEM_VALOR * item.OS_ITEM_QUANTIDADE);
                    totalPecasLiquido += item.OS_ITEM_TOTAL;
                    if (item.OS_ITEM_DESCONTO != 0)
                    {
                        aplica = false;
                    }
                }

            }

            foreach (dsFROGIOS.OS_SERVICORow servico in dsFROGIOS.OS_SERVICO.Rows)
            {
                if (servico.RowState != DataRowState.Deleted)
                {
                    totalServicosBruto += servico.OS_SERVICO_VALOR;
                    totalServicosLiquido += servico.OS_SERVICO_TOTAL;
                    if (servico.OS_SERVICO_DESCONTO != 0 || servico.OS_SERVICO_ACRESCIMO != 0)
                    {
                        aplica = false;
                    }
                }
            }

            totalBruto = totalPecasBruto + totalServicosBruto;
            totalLiquido = totalPecasLiquido + totalServicosLiquido;

            oS_TOTAL_ITEMTextBox.Text = totalPecasLiquido.ToString("0.00");
            oS_TOTAL_SERVICOTextBox.Text = totalServicosLiquido.ToString("0.00");
            textTotalBruto.Text = totalBruto.ToString("0.00");
            textTotal.Text = totalLiquido.ToString("0.00");

            if (aplica)
            {
                groupBoxAcrescimoouDesconto.Visible = true;
                aplicarDescontoAcrescimo();
            }
            else
            {
                groupBoxAcrescimoouDesconto.Visible = false;
                oS_DESCONTOTextBox.Text = "0,00";
                oS_ACRESCIMOTextBox.Text = "0,00";
            }
        }

        private void tabPai_SelectedIndexChanged(object sender, EventArgs e) {
            TabPage abaSelecionada = (sender as TabControl).SelectedTab;
            if (abaSelecionada == tabGeral) {
                calcularTotais();
                this.ActiveControl = oS_TOTAL_ITEMTextBox;
            } else if (abaSelecionada == tabInfoItem) {
                this.ActiveControl = oS_PRODUTOTextBox;
            } else if (abaSelecionada == tabPecas) {
                this.ActiveControl = buttonPesquisarProduto;
            } else if (abaSelecionada == tabServicos) {
                this.ActiveControl = buttonPesquisarServico;
            } else if (abaSelecionada == tabDiagnostico) {
                this.ActiveControl = oS_DIAGNOSTICORichTextBox;
            } else if (abaSelecionada == tabConclusao) {
                calcularTotais();
                this.ActiveControl = textTotal;
            }
        }

        private void textServicoDesconto_TextChanged(object sender, EventArgs e)
        {
            if (textServicoDesconto.Focused)
            {
                textServicoAcrescimo.Text = "0,00";
            }

        }

        private void textServicoAcrescimo_TextChanged(object sender, EventArgs e)
        {
            if (textServicoAcrescimo.Focused)
            {
                textServicoDesconto.Text = "0,00";
            }
        }

        private void oRCAMENTO_DESCONTOTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (text.Focused)
            {
                oS_ACRESCIMOTextBox.Text = "0,00";
            }
        }

        private void oRCAMENTO_ACRESCIMOTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (text.Focused)
            {
                oS_DESCONTOTextBox.Text = "0,00";
            }
        }

        private void formCadastroOS_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelCliente;
        }

        private double calcularTroco(double valorTotal, double valorPago) {
            return (valorPago >= valorTotal) ? (valorPago - valorTotal) : 0;
        }

        private void textValorPago_TextChanged(object sender, EventArgs e) {
            double valorPago = converterParaDouble((sender as TextBox).Text);
            double valorTotal = converterParaDouble(textTotal.Text);
            this.textTroco.Text = calcularTroco(valorTotal, valorPago).ToString("0.00");
        }

        private void oS_ITEMDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            DataGridView tabela = sender as DataGridView;
            string nomeColuna = tabela.Columns[e.ColumnIndex].Name;
            if (nomeColuna == "colunaProdutoValor" || nomeColuna == "colunaProdutoDesconto" || nomeColuna == "colunaProdutoTotal") {
                e.Value = ((double)e.Value).ToString("0.00");
            }
        }

        private void oS_SERVICODataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            DataGridView tabela = sender as DataGridView;
            string nomeColuna = tabela.Columns[e.ColumnIndex].Name;
            if (nomeColuna != "colunaServicoDescricao") {
                e.Value = ((double)e.Value).ToString("0.00");
            }
        }
        
    }
}