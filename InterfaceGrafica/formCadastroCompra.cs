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
    public partial class formCadastroCompra : formCadastro {

        private GerCompra compraSQL;
        private dsFROGIOS.ITEM_COMPRARow itemAtual;

        public formCadastroCompra(bool pesquisaHabilitado) : base (pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado) pesquisa = new formPesquisaCompra(this, false);
            compraSQL = new GerCompra();
        }

        protected override void novoRegistro() {
            base.novoRegistro();
            tabPai.SelectedTab = tabGeral;
            this.ActiveControl = cOMPRA_FUNCIONARIOTextBox;
        }

        protected override void salvaExecutar() {
            if (dsFROGIOS.COMPRA.Rows.Count == 0) {
                compraSQL.inserir(pegarValorCamposCompra(null), dsFROGIOS.ITEM_COMPRA);
            } else {
                object codigo = (dsFROGIOS.COMPRA.Rows[0] as dsFROGIOS.COMPRARow).COMPRA_CODIGO;
                compraSQL.atualizar(pegarValorCamposCompra(codigo), dsFROGIOS.ITEM_COMPRA);
            }
        }

        private dsFROGIOS.COMPRARow pegarValorCamposCompra(object codigo) {

            dsFROGIOS.COMPRARow compra = dsFROGIOS.COMPRA.NewCOMPRARow();

            if (codigo != null)
                compra.COMPRA_CODIGO = (int)codigo;

            compra.COMPRA_NOTA_FISCAL = cOMPRA_NOTA_FISCALTextBox.Text;
            compra.COMPRA_FUNCIONARIO = (dsFROGIOS.FUNCIONARIO.Rows[0] as dsFROGIOS.FUNCIONARIORow).FUNCIONARIO_CODIGO;
            compra.COMPRA_FORNECEDOR = (dsFROGIOS.FORNECEDOR.Rows[0] as dsFROGIOS.FORNECEDORRow).FORNECEDOR_CODIGO;
            compra.COMPRA_DESCONTO = converterParaDouble(cOMPRA_DESCONTOTextBox.Text);
            compra.COMPRA_ACRESCIMO = converterParaDouble(cOMPRA_ACRESCIMOTextBox.Text);
            compra.COMPRA_TOTAL = converterParaDouble(cOMPRA_TOTALTextBox.Text);
            compra.COMPRA_DATA = cOMPRA_DATADateTimePicker.Value;

            return compra;
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            tabPai.SelectedTab = tabGeral;
            this.ActiveControl = cOMPRA_FUNCIONARIOTextBox;
        }

        protected override void excluiExecutar() {
            compraSQL.deletar(dsFROGIOS.COMPRA.Rows[0] as dsFROGIOS.COMPRARow);
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.COMPRA.Clear();
                dsFROGIOS.PRODUTO.Clear();
                dsFROGIOS.ITEM_COMPRA.Clear();
                tabPai.SelectedTab = tabGeral;
            }
        }

        protected override void campos(bool estaDisponivel){
            base.campos(estaDisponivel);
        }

        protected override string validarCampos() {

            if (dsFROGIOS.FUNCIONARIO.Rows.Count == 0) return "Informe o funcionário que realizou a compra";
            if (dsFROGIOS.FORNECEDOR.Rows.Count == 0) return "Informe o fornecedor do qual foi comprada a mercadoria";
            if (dsFROGIOS.ITEM_COMPRA.Rows.Count == 0) return "Informe ao menos um produto para a compra";

            return base.validarCampos();
        }

        protected override void visualizarRegistroExecutar(int codigo) {
            compraSQL.selecionar(codigo, dsFROGIOS.COMPRA, dsFROGIOS.ITEM_COMPRA, dsFROGIOS.FUNCIONARIO, dsFROGIOS.FORNECEDOR, dsFROGIOS.FORNECEDOR_FISICO, dsFROGIOS.FORNECEDOR_JURIDICO);
        }

        private void cOMPRA_FUNCIONARIOTextBox_DoubleClick(object sender, EventArgs e) {
            formPesquisaFuncionario funcionario = new formPesquisaFuncionario(this, false);
            funcionario.ShowDialog();
            funcionario.Dispose();
        }

        public void inserirFuncionario(int codigo) {
            try {
                Conexao.abrir();
                GerFuncionario funcionario = new GerFuncionario();
                funcionario.selecionar(codigo, dsFROGIOS.FUNCIONARIO, dsFROGIOS.CATEGORIA);
            } catch (Exception erro) {
                exibirMensagemErro(erro.Message);
            } finally {
                Conexao.fechar();
            }
        }

        private void cOMPRA_FORNECEDORTextBox_DoubleClick(object sender, EventArgs e) {
            formPesquisaFornecedor fornecedor = new formPesquisaFornecedor(this,false);
            fornecedor.ShowDialog();
            fornecedor.Dispose();
        }

        public void inserirFornecedor(int codigo, bool eFisico) {
            try {
                Conexao.abrir();
                GerFornecedor fornecedor = new GerFornecedor();
                fornecedor.selecionar(
                    codigo, 
                    dsFROGIOS.FORNECEDOR, 
                    eFisico ? dsFROGIOS.FORNECEDOR_FISICO : null, 
                    eFisico ? null : dsFROGIOS.FORNECEDOR_JURIDICO, 
                    dsFROGIOS.UF);
            } catch (Exception erro) {
                exibirMensagemErro(erro.Message);
            } finally {
                Conexao.fechar();
            }
        }

        private void buttonPesquisarProduto_Click(object sender, EventArgs e) {
            formPesquisaProduto produto = new formPesquisaProduto(this, false);
            produto.ShowDialog();
            produto.Dispose();
            textProdutoDesconto.Text = "0,00";
            textProdutoQuantidade.Text = "1";
        }

        private void buttonLancarProduto_Click(object sender, EventArgs e) {
            if (dsFROGIOS.PRODUTO.Rows.Count != 0) {
                dsFROGIOS.ITEM_COMPRARow item = (itemAtual != null) ? itemAtual : dsFROGIOS.ITEM_COMPRA.NewITEM_COMPRARow();
                dsFROGIOS.PRODUTORow produto = (dsFROGIOS.PRODUTORow)dsFROGIOS.PRODUTO.Rows[0];

                item.ITEM_COMPRA_PRODUTO = produto.PRODUTO_CODIGO;
                item.ITEM_COMPRA_PRECO = converterParaDouble(textProdutoPreco.Text); //produto.PRODUTO_PRECO_VENDA;
                item.ITEM_COMPRA_DESCONTO = converterParaDouble(textProdutoDesconto.Text);
                item.ITEM_COMPRA_QUANTIDADE = converterParaShort(textProdutoQuantidade.Text);

                //Calculo do total
                double
                    valor = (item.ITEM_COMPRA_PRECO * item.ITEM_COMPRA_QUANTIDADE),
                    desconto = item.ITEM_COMPRA_DESCONTO,
                    total;

                if (desconto != 0 && desconto < valor) {
                    total = valor - desconto;
                } else {
                    total = valor;
                }

                item.ITEM_COMPRA_PRECO_TOTAL = total;

                if (itemAtual == null) {
                    dsFROGIOS.ITEM_COMPRA.Rows.Add(item.ItemArray);
                }
                itemAtual = null;
                dsFROGIOS.PRODUTO.Clear();
                textProdutoDesconto.Text = null;
                textProdutoQuantidade.Text = null;
            }
        }

      



    }
}
