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
        private dsFROGIOS.ORCAMENTO_SERVICORow servicoAtual;

        public formCadastroOrcamento(bool eNovo) : base (eNovo) {
            InitializeComponent();
            orcamentoSQL = new GerOrcamento();
            dsFROGIOS.EnforceConstraints = false;
            if (eNovo) {
                labelTotalLiquido.Text = "R$0,0";
                oRCAMENTO_DATALabel1.Text = DateTime.Now.ToShortDateString();
                campos(true);
                buttonLancarOS.Visible = false;
                panelCodigo.Visible = false;
            }
            else {
                buttonLancarOS.Visible = true;
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
            orcamentoRow.ORCAMENTO_TOTAL_ITEM = textTotalPecas.Valor;
            orcamentoRow.ORCAMENTO_TOTAL_SERVICO = textTotalServicos.Valor;
            orcamentoRow.ORCAMENTO_DESCONTO = textOrcamentoDesconto.Valor;
            orcamentoRow.ORCAMENTO_ACRESCIMO = textOrcamentoAcresicmo.Valor;
            orcamentoRow.ORCAMENTO_OBSERVACAO = oRCAMENTO_OBSERVACAORichTextBox.Text;
            orcamentoRow.ORCAMENTO_TOTAL = converterParaDouble(labelTotalLiquido.Text.Substring(2));
            orcamentoRow.ORCAMENTO_PRODUTO = oRCAMENTO_PRODUTOTextBox.Text;
            orcamentoRow.ORCAMENTO_DEFEITO = oRCAMENTO_DEFEITORichTextBox.Text;
            orcamentoRow.ORCAMENTO_AVULSOS = oRCAMENTO_AVULSOSRichTextBox.Text;
            orcamentoRow.ORCAMENTO_DIAGNOSTICO = oRCAMENTO_DIAGNOSTICORichTextBox.Text;
            return orcamentoRow;
        }

        protected override void editar() {
            base.editar();
            tabPai.SelectedTab = tabGeral;
            labelTotalLiquido.Text = "R$" + labelTotalLiquido.Text;
            buttonLancarOS.Visible = false;
            this.ActiveControl = textTotalPecas;
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
            if (dsFROGIOS.CLIENTE_FISICO.Rows.Count != 0) {
                labelCliente.Text = ((dsFROGIOS.CLIENTE_FISICORow)dsFROGIOS.CLIENTE_FISICO.Rows[0]).CLIENTE_FISICO_NOME;
            } else {
                labelCliente.Text = ((dsFROGIOS.CLIENTE_JURIDICORow)dsFROGIOS.CLIENTE_JURIDICO.Rows[0]).CLIENTE_JURIDICO_FANTASIA;
            }
            labelFuncionario.Text = ((dsFROGIOS.FUNCIONARIORow)dsFROGIOS.FUNCIONARIO.Rows[0]).FUNCIONARIO_NOME;
            calcularTotais();
            labelCodigo.Text = (dsFROGIOS.ORCAMENTO.Rows[0] as dsFROGIOS.ORCAMENTORow).ORCAMENTO_CODIGO.ToString();
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
            labelFuncionario.Text = ((dsFROGIOS.FUNCIONARIORow)dsFROGIOS.FUNCIONARIO.Rows[0]).FUNCIONARIO_NOME;
            funcionario = null;
        }

        public void selecionarProduto(int codigo) {
            GerProduto produto = new GerProduto();
            produto.selecionar(codigo, dsFROGIOS.PRODUTO, dsFROGIOS.MARCA, dsFROGIOS.GRUPO, dsFROGIOS.SECAO, dsFROGIOS.FORNECEDOR, dsFROGIOS.FORNECEDOR_FISICO, dsFROGIOS.FORNECEDOR_JURIDICO);
            produto = null;
        }

        public void selecionarServico(int codigo) {
            GerServico servico = new GerServico();
            servico.selecionar(codigo, dsFROGIOS.SERVICO, dsFROGIOS.TIPO);
            servico = null;
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
            textPecaDesconto.Valor = 00;
            textPecaQuantidade.Text = "1";
            this.itemAtual = null;
        }

        /**
         * Calculo de acréscimo e desconto sobre o valor bruto do orçamento
         */ 
        private void buttonAplicar_Click(object sender, EventArgs e) {
            aplicarDescontoAcrescimo();
        }

        private void buttonLancarProduto_Click(object sender, EventArgs e) {
            if (dsFROGIOS.PRODUTO.Rows.Count != 0) {
                dsFROGIOS.ORCAMENTO_ITEMRow item = (itemAtual != null) ? itemAtual : dsFROGIOS.ORCAMENTO_ITEM.NewORCAMENTO_ITEMRow();
                dsFROGIOS.PRODUTORow produto = (dsFROGIOS.PRODUTORow)dsFROGIOS.PRODUTO.Rows[0];

                item.ORCAMENTO_ITEM_PRODUTO = produto.PRODUTO_CODIGO;
                item.ORCAMENTO_ITEM_VALOR = produto.PRODUTO_PRECO_VENDA; //produto.PRODUTO_PRECO_VENDA;
                item.ORCAMENTO_ITEM_DESCRICAO = produto.PRODUTO_DESCRICAO;
                item.ORCAMENTO_ITEM_DESCONTO = textPecaDesconto.Valor;
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
                dsFROGIOS.PRODUTO.Clear();
                textPecaDesconto.Text = null;
                textPecaQuantidade.Text = null;
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
            textPecaDesconto.Valor = itemAtual.ORCAMENTO_ITEM_DESCONTO;
            textPecaQuantidade.Text = itemAtual.ORCAMENTO_ITEM_QUANTIDADE.ToString();
        }

        private void buttonPesquisarServico_Click(object sender, EventArgs e) {
            formPesquisaServico servico = new formPesquisaServico(this, false);
            servico.ShowDialog();
            servico.Dispose();
            textServicoAcrescimo.Valor = 00;
            textServicoDesconto.Valor = 00;
            this.servicoAtual = null;
        }

        private void buttonLancarServico_Click(object sender, EventArgs e) {
            if (dsFROGIOS.SERVICO.Rows.Count != 0) {
                dsFROGIOS.ORCAMENTO_SERVICORow servicoItem = (servicoAtual != null) ? servicoAtual : dsFROGIOS.ORCAMENTO_SERVICO.NewORCAMENTO_SERVICORow();
                dsFROGIOS.SERVICORow servico = (dsFROGIOS.SERVICORow)dsFROGIOS.SERVICO.Rows[0];

                servicoItem.ORCAMENTO_SERVICO_SERVICO = servico.SERVICO_CODIGO;
                servicoItem.ORCAMENTO_SERVICO_VALOR = servico.SERVICO_VALOR;
                servicoItem.ORCAMENTO_SERVICO_DESCRICAO = servico.SERVICO_DESCRICAO;
                servicoItem.ORCAMENTO_SERVICO_DESCONTO = textServicoDesconto.Valor;
                servicoItem.ORCAMENTO_SERVICO_ACRESCIMO = textServicoAcrescimo.Valor;

                //calculo do total
                double
                    valor = servicoItem.ORCAMENTO_SERVICO_VALOR,
                    desconto = servicoItem.ORCAMENTO_SERVICO_DESCONTO,
                    acrescimo = servicoItem.ORCAMENTO_SERVICO_ACRESCIMO,
                    total;

                if (desconto != 0 && desconto < valor) {
                    total = valor - desconto;
                } else {
                    total = valor + acrescimo;
                }

                servicoItem.ORCAMENTO_SERVICO_TOTAL = total;

                if (servicoAtual == null) {
                    dsFROGIOS.ORCAMENTO_SERVICO.Rows.Add(servicoItem.ItemArray);
                }
                servicoAtual = null;
                dsFROGIOS.SERVICO.Clear();
                textServicoAcrescimo.Text = null;
                textServicoDesconto.Text = null;
            }
        }

        private void oRCAMENTO_SERVICODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int indice = oRCAMENTO_SERVICODataGridView.CurrentRow.Index;
            servicoAtual = (dsFROGIOS.ORCAMENTO_SERVICORow)dsFROGIOS.ORCAMENTO_SERVICO.Rows[indice];
            dsFROGIOS.SERVICO.Clear();
            dsFROGIOS.SERVICORow servico = dsFROGIOS.SERVICO.NewSERVICORow();
            servico.SERVICO_CODIGO = servicoAtual.ORCAMENTO_SERVICO_SERVICO;
            servico.SERVICO_VALOR = servicoAtual.ORCAMENTO_SERVICO_VALOR;
            servico.SERVICO_DESCRICAO = servicoAtual.ORCAMENTO_SERVICO_DESCRICAO;
            dsFROGIOS.SERVICO.AddSERVICORow(servico);
            textServicoDesconto.Valor = servicoAtual.ORCAMENTO_SERVICO_DESCONTO;
            textServicoAcrescimo.Valor = servicoAtual.ORCAMENTO_SERVICO_ACRESCIMO;
        }

        private void aplicarDescontoAcrescimo() {

            double
               totalBruto = textTotalBruto.Valor,
               acrescimo = textOrcamentoAcresicmo.Valor,
               desconto = textOrcamentoDesconto.Valor;

            try {
                if (acrescimo != 0 && acrescimo > 0) {
                    labelTotalLiquido.Text = "R$" + (totalBruto + acrescimo).ToString("0.00");
                } else if (desconto != 0 && desconto > 0 && desconto < totalBruto) {
                    labelTotalLiquido.Text = "R$" + (totalBruto - desconto).ToString("0.00");
                } else {
                    labelTotalLiquido.Text = "R$" +  totalBruto.ToString("0.00");
                }
            } catch (Exception erro) {
                exibirMensagemErro(erro.Message);
            }
        }

        private void calcularTotais() {
            double
                    totalPecasBruto = 0,
                    totalServicosBruto = 0,
                    totalPecasLiquido = 0,
                    totalServicosLiquido = 0,
                    totalBruto,
                    totalLiquido;

            bool aplica = true;

            foreach (dsFROGIOS.ORCAMENTO_ITEMRow item in dsFROGIOS.ORCAMENTO_ITEM.Rows) {
                if (item.RowState != DataRowState.Deleted) {
                    totalPecasBruto += (item.ORCAMENTO_ITEM_VALOR * item.ORCAMENTO_ITEM_QUANTIDADE);
                    totalPecasLiquido += item.ORCAMENTO_ITEM_TOTAL;
                    if (item.ORCAMENTO_ITEM_DESCONTO != 0) {
                        aplica = false;
                    }    
                }
                
            }

            foreach (dsFROGIOS.ORCAMENTO_SERVICORow servico in dsFROGIOS.ORCAMENTO_SERVICO.Rows) {
                if (servico.RowState != DataRowState.Deleted) {
                    totalServicosBruto += servico.ORCAMENTO_SERVICO_VALOR;
                    totalServicosLiquido += servico.ORCAMENTO_SERVICO_TOTAL;
                    if (servico.ORCAMENTO_SERVICO_DESCONTO != 0 || servico.ORCAMENTO_SERVICO_ACRESCIMO != 0) {
                        aplica = false;
                    }    
                }
            }

            totalBruto = totalPecasBruto + totalServicosBruto;
            totalLiquido = totalPecasLiquido + totalServicosLiquido;

            textTotalPecas.Valor = totalPecasLiquido;
            textTotalServicos.Valor = totalServicosLiquido;
            textTotalBruto.Valor = totalBruto;
            labelTotalLiquido.Text = "R$" + totalLiquido.ToString("0.00");

            if (aplica) {
                panelDesconto_Acrescimo.Visible = true;
                aplicarDescontoAcrescimo();
            } else {
                panelDesconto_Acrescimo.Visible = false;
                textOrcamentoDesconto.Valor = 00;
                textOrcamentoAcresicmo.Valor = 00;
            }
        }

        private void tabPai_SelectedIndexChanged(object sender, EventArgs e) {
            if (((TabControl)sender).SelectedTab == tabGeral) {
                calcularTotais();
                this.ActiveControl = textTotalPecas;
            }
        }

        private void textServicoDesconto_TextChanged(object sender, EventArgs e) {
            if (textServicoDesconto.Focused) {
                textServicoAcrescimo.Text = "0,00";    
            }
            
        }

        private void textServicoAcrescimo_TextChanged(object sender, EventArgs e) {
            if (textServicoAcrescimo.Focused) {
                textServicoDesconto.Text = "0,00";    
            }
        }

        private void oRCAMENTO_DESCONTOTextBox_TextChanged(object sender, EventArgs e) {
            TextBox text = (TextBox)sender;
            if (text.Focused) {
                textOrcamentoAcresicmo.Valor = 00;
            }
        }

        private void oRCAMENTO_ACRESCIMOTextBox_TextChanged(object sender, EventArgs e) {
            TextBox text = (TextBox)sender;
            if (text.Focused) {
                textOrcamentoDesconto.Valor = 00;
            }
        }

        private void buttonLancarOS_Click(object sender, EventArgs e) {
            using (formDialogo dialogo = new formDialogo()) {
                string valido = validarCampos();
                if (valido != "") {
                    dialogo.compor(valido, "", formDialogo.TipoExpressao.AvisoTriste).ShowDialog();
                } else {
                    if (dialogo.compor("Deseja abrir uma nova ordem de serviço?", null, formDialogo.TipoExpressao.Pergunta).ShowDialog() == DialogResult.Yes) {
                        try {
                            Conexao.abrir();
                            criarNovaOS();
                            Conexao.getTransacao.Commit();
                            dialogo.compor("Ordem de serviço criada!", "Agora vá na seção de OS para ver mais informações", formDialogo.TipoExpressao.AvisoFeliz).ShowDialog();
                        } catch (Exception erro) {
                            Conexao.getTransacao.Rollback();
                            exibirMensagemErro(erro.Message);
                        } finally {
                            Conexao.fechar();
                        }
                        this.ignorar = true; //Impede que a caixa de dialogo de confirmação de saida seja exibida
                        this.Close();
                    }
                }
            }
        }

        private void criarNovaOS() {
            
            dsFROGIOS.OSRow os = dsFROGIOS.OS.NewOSRow();
            dsFROGIOS.ORCAMENTORow orcamento = dsFROGIOS.ORCAMENTO.Rows[0] as dsFROGIOS.ORCAMENTORow;

            //Inicialização dos valores da os com base nos valores do orcamento
            os.OS_CODIGO = 0;
            os.OS_CLIENTE = orcamento.ORCAMENTO_CLIENTE;
            os.OS_FUNCIONARIO = orcamento.ORCAMENTO_FUNCIONARIO;
            os.OS_TOTAL_ITEM = orcamento.ORCAMENTO_TOTAL_ITEM;
            os.OS_TOTAL_SERVICO = orcamento.ORCAMENTO_TOTAL_SERVICO;
            os.OS_DESCONTO = orcamento.ORCAMENTO_DESCONTO;
            os.OS_ACRESCIMO = orcamento.ORCAMENTO_ACRESCIMO;
            os.OS_TOTAL = orcamento.ORCAMENTO_TOTAL;
            os.OS_DATA = DateTime.Now;
            os.OS_FORMA_PAGAMENTO = String.Empty;
            os.OS_PRODUTO = orcamento.ORCAMENTO_PRODUTO;
            os.OS_DEFEITO = orcamento.ORCAMENTO_DEFEITO;
            os.OS_AVULSOS = orcamento.ORCAMENTO_AVULSOS;
            os.OS_DIAGNOSTICO = orcamento.ORCAMENTO_DIAGNOSTICO;
            os.OS_OBSERVACAO = orcamento.ORCAMENTO_OBSERVACAO;
            os.OS_STATUS = "Lançado";
            os.OS_DATA_ENTREGA = DateTime.Now;

            
            int contador = 0;
            //inicialização dos valores dos itens da os com base nos item do orcamento
            foreach (dsFROGIOS.ORCAMENTO_ITEMRow itemOrcamento in dsFROGIOS.ORCAMENTO_ITEM.Rows) {
                dsFROGIOS.OS_ITEMRow itemOs = dsFROGIOS.OS_ITEM.NewOS_ITEMRow();
                itemOs.OS_ITEM_CODIGO = contador;
                itemOs.OS_ITEM_OS = 0;
                itemOs.OS_ITEM_PRODUTO = itemOrcamento.ORCAMENTO_ITEM_PRODUTO;
                itemOs.OS_ITEM_DESCRICAO = itemOrcamento.ORCAMENTO_ITEM_DESCRICAO;
                itemOs.OS_ITEM_VALOR = itemOrcamento.ORCAMENTO_ITEM_VALOR;
                itemOs.OS_ITEM_DESCONTO = itemOrcamento.ORCAMENTO_ITEM_DESCONTO;
                itemOs.OS_ITEM_QUANTIDADE = itemOrcamento.ORCAMENTO_ITEM_QUANTIDADE;
                itemOs.OS_ITEM_TOTAL = itemOrcamento.ORCAMENTO_ITEM_TOTAL;
                contador++;
                dsFROGIOS.OS_ITEM.AddOS_ITEMRow(itemOs);
            }

            //inicialização dos valores dos serviços da os com base nos serviços do orcamento
            foreach (dsFROGIOS.ORCAMENTO_SERVICORow servicoOrcamento in dsFROGIOS.ORCAMENTO_SERVICO.Rows) {
                dsFROGIOS.OS_SERVICORow servicoOs = dsFROGIOS.OS_SERVICO.NewOS_SERVICORow();
                servicoOs.OS_SERVICO_CODIGO = contador;
                servicoOs.OS_SERVICO_OS = 0;
                servicoOs.OS_SERVICO_SERVICO = servicoOrcamento.ORCAMENTO_SERVICO_SERVICO;
                servicoOs.OS_SERVICO_VALOR = servicoOrcamento.ORCAMENTO_SERVICO_VALOR;
                servicoOs.OS_SERVICO_DESCRICAO = servicoOrcamento.ORCAMENTO_SERVICO_DESCRICAO;
                servicoOs.OS_SERVICO_DESCONTO = servicoOrcamento.ORCAMENTO_SERVICO_DESCONTO;
                servicoOs.OS_SERVICO_ACRESCIMO = servicoOrcamento.ORCAMENTO_SERVICO_ACRESCIMO;
                servicoOs.OS_SERVICO_TOTAL = servicoOrcamento.ORCAMENTO_SERVICO_TOTAL;
                contador++;
                dsFROGIOS.OS_SERVICO.AddOS_SERVICORow(servicoOs);
            }

            GerOs osSQL = new GerOs();
            osSQL.inserir(os,dsFROGIOS.OS_ITEM, dsFROGIOS.OS_SERVICO);

        }

        private void formCadastroOrcamento_Load(object sender, EventArgs e) {
            this.ActiveControl = textTotalPecas;
        }

        private void oRCAMENTO_ITEMDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            DataGridView tabela = sender as DataGridView;
            string nomeColuna = tabela.Columns[e.ColumnIndex].Name;
            if (nomeColuna == "colunaProdutoPreco" || nomeColuna == "colunaProdutoDesconto" || nomeColuna == "colunaProdutoTotal") {
                e.Value = ((double)e.Value).ToString("0.00");
            } 
        }

        private void oRCAMENTO_SERVICODataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            DataGridView tabela = sender as DataGridView;
            string nomeColuna = tabela.Columns[e.ColumnIndex].Name;
            if (nomeColuna != "colunaServicoDescricao") {
                e.Value = ((double)e.Value).ToString("0.00");
            }
        }

        private void _KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                aplicarDescontoAcrescimo();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

    }
}
