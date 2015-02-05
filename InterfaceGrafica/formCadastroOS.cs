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
using FROGI_OS.Relatorios;

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
            if (eNovo) {
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
            osRow.OS_TOTAL_ITEM = textTotalPecas.Valor;
            osRow.OS_TOTAL_SERVICO = textTotalServicos.Valor;
            osRow.OS_DESCONTO = textOSDesconto.Valor;
            osRow.OS_ACRESCIMO = textOSAcrescimo.Valor;
            osRow.OS_FORMA_PAGAMENTO = oS_FORMA_PAGAMENTOComboBox.Text;
            osRow.OS_TOTAL = textTotalLiquido.Valor;
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
            this.ActiveControl = textTotalPecas;
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
            if (this.dsFROGIOS.OS_ITEM.Rows.Count == 0 && this.dsFROGIOS.OS_SERVICO.Rows.Count == 0) return "Adicione ao menos uma peça ou serviço na ordem de serviço";

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
            textProdutoDesconto.Valor = 0;
            textPecaQuantidade.Text = "1";
            this.itemAtual = null;
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
                item.OS_ITEM_VALOR = textProdutoPreco.Valor; //produto.PRODUTO_PRECO_VENDA;
                item.OS_ITEM_DESCRICAO = produto.PRODUTO_DESCRICAO;
                item.OS_ITEM_DESCONTO = textProdutoDesconto.Valor;
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
                textProdutoDesconto.Valor = 00;
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
            textProdutoDesconto.Valor = itemAtual.OS_ITEM_DESCONTO;
            textPecaQuantidade.Text = itemAtual.OS_ITEM_QUANTIDADE.ToString();
        }

        private void buttonPesquisarServico_Click(object sender, EventArgs e)
        {
            formPesquisaServico servico = new formPesquisaServico(this, false);
            servico.ShowDialog();
            servico.Dispose();
            textServicoAcrescimo.Valor = 0;
            textServicoDesconto.Valor = 0;
            this.servicoAtual = null;
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
                servicoItem.OS_SERVICO_DESCONTO = textServicoDesconto.Valor;
                servicoItem.OS_SERVICO_ACRESCIMO = textServicoAcrescimo.Valor;

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
                textServicoAcrescimo.Valor = 0;
                textServicoDesconto.Valor = 0;
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
            textServicoDesconto.Valor = servicoAtual.OS_SERVICO_DESCONTO;
            textServicoAcrescimo.Valor = servicoAtual.OS_SERVICO_ACRESCIMO;
        }

        private void aplicarDescontoAcrescimo()
        {

            double
               totalBruto = textTotalBruto.Valor,
               acrescimo = textOSAcrescimo.Valor,
               desconto = textOSDesconto.Valor;

            try
            {
                if (acrescimo != 0 && acrescimo > 0)
                {
                    textTotalLiquido.Valor = totalBruto + acrescimo;
                }
                else if (desconto != 0 && desconto > 0 && desconto < totalBruto)
                {
                    textTotalLiquido.Valor = totalBruto - desconto;
                }
                else {
                    textTotalLiquido.Valor = totalBruto;
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

            textTotalPecas.Valor = totalPecasLiquido;
            textTotalServicos.Valor = totalServicosLiquido;
            textTotalBruto.Valor = totalBruto;
            textTotalLiquido.Valor = totalLiquido;

            if (aplica)
            {
                groupBoxAcrescimoouDesconto.Visible = true;
                aplicarDescontoAcrescimo();
            }
            else
            {
                groupBoxAcrescimoouDesconto.Visible = false;
                textOSDesconto.Valor = 0;
                textOSAcrescimo.Valor = 0;
            }
        }

        private void tabPai_SelectedIndexChanged(object sender, EventArgs e) {
            TabPage abaSelecionada = (sender as TabControl).SelectedTab;
            if (abaSelecionada == tabGeral) {
                calcularTotais();
                this.ActiveControl = textTotalPecas;
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
                this.ActiveControl = textTotalLiquido;
            }
        }

        private void textServicoDesconto_TextChanged(object sender, EventArgs e)
        {
            if (textServicoDesconto.Focused)
            {
                textServicoAcrescimo.Valor = 0;
            }

        }

        private void textServicoAcrescimo_TextChanged(object sender, EventArgs e)
        {
            if (textServicoAcrescimo.Focused)
            {
                textServicoDesconto.Valor = 0;
            }
        }

        private void oRCAMENTO_DESCONTOTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (text.Focused) {
                textOSAcrescimo.Valor = 0;
            }
        }

        private void oRCAMENTO_ACRESCIMOTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (text.Focused) {
                textOSDesconto.Valor = 0;
            }
        }

        private void formCadastroOS_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelCliente;
        }

        private double calcularTroco(double valorTotal, double valorPago) {
            return Math.Round((valorPago >= valorTotal) ? (valorPago - valorTotal) : 0, 2);
        }

        private void textValorPago_TextChanged(object sender, EventArgs e) {
            double valorPago = textValorPago.Valor;
            double valorTotal = textTotalLiquido.Valor;
            textTroco.Valor = calcularTroco(valorTotal, valorPago);
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

        private void imprimirOS() {
            String mensagem = this.validarCampos();
            if (!String.IsNullOrEmpty(mensagem))
            {
                formDialogo dialogo = new formDialogo("Antes de imprimir a ordem de serviço...", mensagem, formDialogo.TipoExpressao.AvisoTriste);
                dialogo.ShowDialog();
                dialogo.Dispose();
            }
            else
            {
                dsFROGIOS.CLIENTERow cliente = this.dsFROGIOS.CLIENTE.Rows[0] as dsFROGIOS.CLIENTERow;
                dsFROGIOS.OSRow os;
                try
                {
                    os = this.dsFROGIOS.OS.Rows[0] as dsFROGIOS.OSRow;
                }
                catch (Exception)
                {
                    os = null;
                }
                List<RelatorioItens> itens = new List<RelatorioItens>();
                String nomeCliente = this.labelCliente.Text;
                String enderecoCliente = cliente.CLIENTE_ENDERECO + ", " + cliente.CLIENTE_BAIRRO;
                String foneCliente = String.IsNullOrEmpty(cliente.CLIENTE_TELEFONE) ? cliente.CLIENTE_CELULAR : cliente.CLIENTE_TELEFONE;
                Int32 codigoCliente = cliente.CLIENTE_CODIGO;
                Int32 codigoOs;
                if (os == null)
                {
                    Conexao.abrir();
                    codigoOs = this.osSQL.pegarMaiorCodigo();
                    Conexao.fechar();
                }
                else
                {
                    codigoOs = os.OS_CODIGO;
                }
                DateTime data = os == null ? DateTime.Now : os.OS_DATA;
                Double total;
                try
                {
                    total = Convert.ToDouble(this.textTotalLiquido.Text.Replace("R$", ""));
                }
                catch (Exception)
                {
                    total = 0.00;
                }
                DateTime dataEntrega = this.oS_DATA_ENTREGADateTimePicker.Value;

                foreach (dsFROGIOS.OS_ITEMRow item in dsFROGIOS.OS_ITEM.Rows)
                {
                    itens.Add(new RelatorioItens(
                        item.OS_ITEM_DESCRICAO,
                        item.OS_ITEM_VALOR,
                        item.OS_ITEM_TOTAL
                        ));
                }

                foreach (dsFROGIOS.OS_SERVICORow servico in dsFROGIOS.OS_SERVICO.Rows)
                {
                    itens.Add(new RelatorioItens(
                        servico.OS_SERVICO_DESCRICAO,
                        servico.OS_SERVICO_VALOR,
                        servico.OS_SERVICO_TOTAL
                        ));
                }

                formComprovanteOS comprovante = new formComprovanteOS(new RelatorioOrdemServico(
                    nomeCliente,
                    enderecoCliente,
                    foneCliente,
                    codigoOs,
                    codigoCliente,
                    total,
                    itens,
                    data,
                    dataEntrega
                    ));
                comprovante.ShowDialog();
                comprovante.Dispose();
            }
        }

        private void buttonImprimirOS_Click(object sender, EventArgs e)
        {
            this.imprimirOS();
        }

    }
}