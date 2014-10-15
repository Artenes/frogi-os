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

namespace FROGI_OS.InterfaceGrafica {
    public partial class formCadastroOrcamento : formOSBaseCadastro {

        private GerOrcamento orcamentoSQL;
        private dsFROGIOS.ORCAMENTO_ITEMRow itemAtual;

        public formCadastroOrcamento(bool eNovo) : base (eNovo) {
            InitializeComponent();
            orcamentoSQL = new GerOrcamento();
            dsFROGIOS.EnforceConstraints = false;
            if (eNovo) {
                oRCAMENTO_TOTAL_ITEMTextBox.Text = "0,0";
                oRCAMENTO_TOTAL_SERVICOTextBox.Text = "0,0";
                textTotalBruto.Text = "0,0";
                oRCAMENTO_TOTALLabel1.Text = "R$0,0";
                oRCAMENTO_DESCONTOTextBox.Text = "0,0";
                oRCAMENTO_ACRESCIMOTextBox.Text = "0,0";
                oRCAMENTO_DATALabel1.Text = DateTime.Now.ToShortDateString();
                campos(true);
            }
        }

        protected override void salvarExecutar() {
            if (dsFROGIOS.ORCAMENTO.Rows.Count == 0) {
                orcamentoSQL.inserir(pegarValorCamposOrcamento(null), dsFROGIOS.ORCAMENTO_ITEM, dsFROGIOS.ORCAMENTO_SERVICO);
            } else {
                object codigo = ((dsFROGIOS.ORCAMENTORow)dsFROGIOS.ORCAMENTO.Rows[0]).ORCAMENTO_CODIGO;
                orcamentoSQL.atualizar(pegarValorCamposOrcamento(codigo), dsFROGIOS.ORCAMENTO_ITEM, dsFROGIOS.ORCAMENTO_SERVICO);
            }
        }

        private dsFROGIOS.ORCAMENTORow pegarValorCamposOrcamento(object codigo) {
            dsFROGIOS.ORCAMENTORow orcamentoRow = dsFROGIOS.ORCAMENTO.NewORCAMENTORow();
            if (codigo != null) {
                orcamentoRow.ORCAMENTO_CODIGO = (int)codigo;
                orcamentoRow.ORCAMENTO_DATA = ((dsFROGIOS.ORCAMENTORow)dsFROGIOS.ORCAMENTO.Rows[0]).ORCAMENTO_DATA;
            } else {
                orcamentoRow.ORCAMENTO_DATA = DateTime.Now;
            }
            orcamentoRow.ORCAMENTO_CLIENTE = ((dsFROGIOS.CLIENTERow)dsFROGIOS.CLIENTE.Rows[0]).CLIENTE_CODIGO;
            orcamentoRow.ORCAMENTO_FUNCIONARIO = ((dsFROGIOS.FUNCIONARIORow)dsFROGIOS.FUNCIONARIO.Rows[0]).FUNCIONARIO_CODIGO;
            orcamentoRow.ORCAMENTO_TOTAL_ITEM = converterParaDouble(oRCAMENTO_TOTAL_ITEMTextBox.Text);
            orcamentoRow.ORCAMENTO_TOTAL_SERVICO = converterParaDouble(oRCAMENTO_TOTAL_SERVICOTextBox.Text);
            orcamentoRow.ORCAMENTO_DESCONTO = converterParaDouble(oRCAMENTO_DESCONTOTextBox.Text);
            orcamentoRow.ORCAMENTO_ACRESCIMO = converterParaDouble(oRCAMENTO_ACRESCIMOTextBox.Text);
            orcamentoRow.ORCAMENTO_OBSERVACAO = oRCAMENTO_OBSERVACAORichTextBox.Text;
            orcamentoRow.ORCAMENTO_TOTAL = converterParaDouble(oRCAMENTO_TOTALLabel1.Text);
            orcamentoRow.ORCAMENTO_PRODUTO = pRODUTO_DESCRICAOTextBox.Text;
            //orcamentoRow.ORCAMENTO_DEFEITO = oRCAMENTO_DEFEITORichTextBox.Text;
            //orcamentoRow.ORCAMENTO_AVULSOS = oRCAMENTO_AVULSOSRichTextBox.Text;
            //orcamentoRow.ORCAMENTO_DIAGNOSTICO = oRCAMENTO_DIAGNOSTICORichTextBox.Text;
            return orcamentoRow;
        }

        protected override void editar() {
            base.editar();
            tabPai.SelectedTab = tabGeral;
        }

        protected override void excluirExecutar() {
            orcamentoSQL.deletar((dsFROGIOS.ORCAMENTORow)dsFROGIOS.ORCAMENTO.Rows[0]);
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.Clear();
            }
        }

        protected override string validarCampos() {

            if (dsFROGIOS.CLIENTE.Rows.Count == 0) return "Informe o cliente que quer o orçamento";
            if (dsFROGIOS.FUNCIONARIO.Rows.Count == 0) return "Informe o funcionário responsável pelo orçamento";

            return base.validarCampos();
        }

        public override void selecionar(int codigo) {
            orcamentoSQL.selecionar(codigo,dsFROGIOS.ORCAMENTO, dsFROGIOS.ORCAMENTO_ITEM, dsFROGIOS.ORCAMENTO_SERVICO, dsFROGIOS.CLIENTE, dsFROGIOS.CLIENTE_FISICO, dsFROGIOS.CLIENTE_JURIDICO, dsFROGIOS.FUNCIONARIO);
        }

        public void selecionarCliente(int codigo, bool eFisico) {
            GerCliente cliente = new GerCliente();
            cliente.selecionar(codigo, dsFROGIOS.CLIENTE, eFisico ? dsFROGIOS.CLIENTE_FISICO : null, eFisico ? null : dsFROGIOS.CLIENTE_JURIDICO);
            if (eFisico) {
                labelCliente.Text = ((dsFROGIOS.CLIENTE_FISICORow)dsFROGIOS.CLIENTE_FISICO.Rows[0]).CLIENTE_FISICO_NOME;
            } else {
                labelCliente.Text = ((dsFROGIOS.CLIENTE_JURIDICORow)dsFROGIOS.CLIENTE_JURIDICO.Rows[0]).CLIENTE_JURIDICO_FANTASIA;
            }
            cliente = null;
        }

        public void selecionarFuncionario(int codigo) {
            GerFuncionario funcionario = new GerFuncionario();
            funcionario.selecionar(codigo, dsFROGIOS.FUNCIONARIO, null);
            fUNCIONARIO_NOMELabel1.Text = ((dsFROGIOS.FUNCIONARIORow)dsFROGIOS.FUNCIONARIO.Rows[0]).FUNCIONARIO_NOME;
            funcionario = null;
        }

        public void selecionarProduto(int codigo) {
            GerProduto produto = new GerProduto();
            produto.selecionar(codigo, dsFROGIOS.PRODUTO, dsFROGIOS.MARCA, dsFROGIOS.GRUPO, dsFROGIOS.SECAO, dsFROGIOS.FORNECEDOR, dsFROGIOS.FORNECEDOR_FISICO, dsFROGIOS.FORNECEDOR_JURIDICO);
            produto = null;
        }

        private void labelCliente_Click(object sender, EventArgs e) {
            formPesquisaCliente cliente = new formPesquisaCliente(this, false);
            cliente.ShowDialog();
            cliente.Dispose();

        }

        private void fUNCIONARIO_NOMELabel1_Click(object sender, EventArgs e) {
            formPesquisaFuncionario funcionario = new formPesquisaFuncionario(this, false);
            funcionario.ShowDialog();
            funcionario.Dispose();
        }

        private void buttonPesquisarProduto_Click(object sender, EventArgs e) {
            formPesquisaProduto produto = new formPesquisaProduto(this, false);
            produto.ShowDialog();
            produto.Dispose();
        }

        /**
         * Calculo de acréscimo e desconto sobre o valor bruto do orçamento
         */ 
        private void buttonAplicar_Click(object sender, EventArgs e) {
            
            double
                totalBruto = converterParaDouble(textTotalBruto.Text),
                acrescimo = converterParaDouble(oRCAMENTO_ACRESCIMOTextBox.Text),
                desconto = converterParaDouble(oRCAMENTO_DESCONTOTextBox.Text);

            try {
                if (acrescimo != 0 && acrescimo > 0) {
                    oRCAMENTO_TOTALLabel1.Text = "R$" + (totalBruto + acrescimo).ToString("0.00");
                } else if (desconto != 0 && desconto > 0 && desconto < totalBruto) {
                    oRCAMENTO_TOTALLabel1.Text = "R$" + (totalBruto - desconto).ToString("0.00");
                }                    
            } catch (Exception erro) {
                exibirMensagemErro(erro.Message);
            }

        }

        private void buttonLancarProduto_Click(object sender, EventArgs e) {
            if (dsFROGIOS.PRODUTO.Rows.Count != 0) {
                dsFROGIOS.ORCAMENTO_ITEMRow item = (itemAtual != null) ? itemAtual : dsFROGIOS.ORCAMENTO_ITEM.NewORCAMENTO_ITEMRow();
                dsFROGIOS.PRODUTORow produto = (dsFROGIOS.PRODUTORow)dsFROGIOS.PRODUTO.Rows[0];

                item.ORCAMENTO_ITEM_PRODUTO = produto.PRODUTO_CODIGO;
                item.ORCAMENTO_ITEM_VALOR = converterParaDouble(pRODUTO_PRECO_VENDATextBox.Text); //produto.PRODUTO_PRECO_VENDA;
                item.ORCAMENTO_ITEM_DESCRICAO = produto.PRODUTO_DESCRICAO;
                item.ORCAMENTO_ITEM_DESCONTO = converterParaDouble(textPecaDesconto.Text);
                item.ORCAMENTO_ITEM_QUANTIDADE = converterParaShort(textPecaQuantidade.Text);
                
                //Calculo do total
                double 
                    valor = (item.ORCAMENTO_ITEM_VALOR * item.ORCAMENTO_ITEM_QUANTIDADE),
                    desconto = item.ORCAMENTO_ITEM_DESCONTO,
                    total;

                if (desconto != 0 && desconto < valor) {
                    total = valor - desconto;
                } else {
                    total = valor;
                }

                item.ORCAMENTO_ITEM_TOTAL = total;

                if (itemAtual == null) {
                    dsFROGIOS.ORCAMENTO_ITEM.Rows.Add(item.ItemArray);
                }
                itemAtual = null;
            }
        }

        private void oRCAMENTO_ITEMDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int indice = oRCAMENTO_ITEMDataGridView.CurrentRow.Index;
            itemAtual = (dsFROGIOS.ORCAMENTO_ITEMRow)dsFROGIOS.ORCAMENTO_ITEM.Rows[indice];
            dsFROGIOS.PRODUTO.Clear();
            dsFROGIOS.PRODUTORow produto = dsFROGIOS.PRODUTO.NewPRODUTORow();
            produto.PRODUTO_CODIGO = itemAtual.ORCAMENTO_ITEM_PRODUTO;
            produto.PRODUTO_PRECO_VENDA = itemAtual.ORCAMENTO_ITEM_VALOR;
            produto.PRODUTO_DESCRICAO = itemAtual.ORCAMENTO_ITEM_DESCRICAO;
            dsFROGIOS.PRODUTO.AddPRODUTORow(produto);
            textPecaDesconto.Text = itemAtual.ORCAMENTO_ITEM_DESCONTO.ToString("0.00");
            textPecaQuantidade.Text = itemAtual.ORCAMENTO_ITEM_QUANTIDADE.ToString();
        }

       
       
        
        
    }
}
