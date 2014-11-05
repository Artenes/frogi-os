using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FROGI_OS.InterfaceGrafica;
using FROGI_OS.CamadaAcessoDados;
using FROGI_OS.CamadaEnlaceDados;

namespace FROGI_OS
{
    public partial class formCadastroProduto : formCadastro {

        private GerProduto produtoSQL;

        public formCadastroProduto(bool pesquisaHabilitado) : base(pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado)
                pesquisa = new formPesquisaProduto(this, false);
            produtoSQL = new GerProduto();
            dsFROGIOS.EnforceConstraints = false;
        }

        protected override void salvaExecutar() {
            if (dsFROGIOS.PRODUTO.Rows.Count == 0) {
                produtoSQL.inserir(pegarValorCamposProduto(null));
            } else {
                object codigo = ((dsFROGIOS.PRODUTORow)dsFROGIOS.PRODUTO.Rows[0]).PRODUTO_CODIGO;
                produtoSQL.atualizar(pegarValorCamposProduto(codigo));
            }      
        }

        private dsFROGIOS.PRODUTORow pegarValorCamposProduto(object codigo) {

            dsFROGIOS.PRODUTORow produtoRow = dsFROGIOS.PRODUTO.NewPRODUTORow();

            if (codigo != null) {
                produtoRow.PRODUTO_CODIGO = (int)codigo;
                produtoRow.PRODUTO_DATA_CADASTRO = ((dsFROGIOS.PRODUTORow)dsFROGIOS.PRODUTO.Rows[0]).PRODUTO_DATA_CADASTRO;
            } else {
                produtoRow.PRODUTO_DATA_CADASTRO = DateTime.Now;
            }
            produtoRow.PRODUTO_DESCRICAO = pRODUTO_DESCRICAOTextBox.Text;
            produtoRow.PRODUTO_CARACTERISTICA = pRODUTO_CARACTERISTICATextBox.Text;
            produtoRow.PRODUTO_UNIDADE_COMPRA = pRODUTO_UNIDADE_COMPRATextBox.Text;
            produtoRow.PRODUTO_UNIDADE_VENDA = pRODUTO_UNIDADE_VENDATextBox.Text;
            try { produtoRow.PRODUTO_PESO = Convert.ToDouble(pRODUTO_PESOTextBox.Text); } catch (Exception) { produtoRow.PRODUTO_PESO = 0; }
            produtoRow.PRODUTO_NUMERO = pRODUTO_NUMEROTextBox.Text;
            produtoRow.PRODUTO_EAN = pRODUTO_EANTextBox.Text;
            produtoRow.PRODUTO_NUMERO_SERIE = pRODUTO_NUMERO_SERIETextBox.Text;
            produtoRow.PRODUTO_CFOP = pRODUTO_CFOPTextBox.Text;
            produtoRow.PRODUTO_CSOSN = pRODUTO_CSOSNTextBox.Text;
            produtoRow.PRODUTO_NCM = pRODUTO_NCMTextBox.Text;
            produtoRow.PRODUTO_SITUACAO_TRIBUTARIA = pRODUTO_SITUACAO_TRIBUTARIATextBox.Text;
            produtoRow.PRODUTO_ORIGEM_MERCADORIA = pRODUTO_ORIGEM_MERCADORIATextBox.Text;
            try { produtoRow.PRODUTO_ESTOQUE_MINIMO = Convert.ToInt16(pRODUTO_ESTOQUE_MINIMOTextBox.Text); } catch (Exception) { produtoRow.PRODUTO_ESTOQUE_MINIMO = 0; }
            try { produtoRow.PRODUTO_ESTOQUE_MAXIMO = Convert.ToInt16(pRODUTO_ESTOQUE_MAXIMOTextBox.Text); } catch (Exception) { produtoRow.PRODUTO_ESTOQUE_MAXIMO = 0; }
            try { produtoRow.PRODUTO_ESTOQUE_ATUAL = Convert.ToInt16(pRODUTO_ESTOQUE_ATUALTextBox.Text); } catch (Exception) { produtoRow.PRODUTO_ESTOQUE_ATUAL = 0; }
            try { produtoRow.PRODUTO_PRECO_COMPRA = Convert.ToDouble(pRODUTO_PRECO_COMPRATextBox.Text); } catch (Exception) { produtoRow.PRODUTO_PRECO_COMPRA = 0; }
            try { produtoRow.PRODUTO_PRECO_CUSTO = Convert.ToDouble(pRODUTO_PRECO_CUSTOTextBox.Text); } catch (Exception) { produtoRow.PRODUTO_PRECO_CUSTO = 0; }
            try { produtoRow.PRODUTO_PRECO_VENDA = Convert.ToDouble(pRODUTO_PRECO_VENDATextBox.Text); } catch (Exception) { produtoRow.PRODUTO_PRECO_VENDA = 0; }

            if (dsFROGIOS.MARCA.Rows.Count != 0) produtoRow.PRODUTO_MARCA = ((dsFROGIOS.MARCARow)dsFROGIOS.MARCA.Rows[0]).MARCA_CODIGO;
            if (dsFROGIOS.GRUPO.Rows.Count != 0) produtoRow.PRODUTO_GRUPO = ((dsFROGIOS.GRUPORow)dsFROGIOS.GRUPO.Rows[0]).GRUPO_CODIGO;
            if (dsFROGIOS.SECAO.Rows.Count != 0) produtoRow.PRODUTO_SECAO = ((dsFROGIOS.SECAORow)dsFROGIOS.SECAO.Rows[0]).SECAO_CODIGO;
            if (dsFROGIOS.FORNECEDOR.Rows.Count != 0) produtoRow.PRODUTO_FORNECEDOR = ((dsFROGIOS.FORNECEDORRow)dsFROGIOS.FORNECEDOR.Rows[0]).FORNECEDOR_CODIGO;

            return produtoRow;
        }

        protected override void novoRegistro() {
            base.novoRegistro();
            this.ActiveControl = pRODUTO_DESCRICAOTextBox;
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            this.ActiveControl = pRODUTO_DESCRICAOTextBox;
        }

        protected override void excluiExecutar() {
            produtoSQL.deletar((dsFROGIOS.PRODUTORow)dsFROGIOS.PRODUTO.Rows[0]);
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.PRODUTO.Clear();
                dsFROGIOS.MARCA.Clear();
                dsFROGIOS.GRUPO.Clear();
                dsFROGIOS.SECAO.Clear();
                dsFROGIOS.FORNECEDOR.Clear();
                string texto = "Duplo clique para pesquisar";
                mARCA_DESCRICAOTextBox.Text = texto;
                sECAO_DESCRICAOTextBox.Text = texto;
                gRUPO_DESCRICAOTextBox.Text = texto;
                fORNECEDOR_FISICO_NOMETextBox.Text = texto;
                fORNECEDOR_JURIDICO_FANTASIATextBox.Text = texto;
            }
        }

        protected override void campos(bool estaDisponivel) {
            panelCentro.Enabled = estaDisponivel;
            panelCodigo.Visible = estaDisponivel;
        }

        protected override string validarCampos() {
            string descricao = pRODUTO_DESCRICAOTextBox.Text;
            if (!valorValido(descricao)) return "Informe uma descrição para o produto";
            return base.validarCampos();
        }

       protected override void visualizarRegistroExecutar(int codigo) {
           produtoSQL.selecionar(codigo, dsFROGIOS.PRODUTO, dsFROGIOS.MARCA, dsFROGIOS.GRUPO, dsFROGIOS.SECAO, dsFROGIOS.FORNECEDOR, dsFROGIOS.FORNECEDOR_FISICO, dsFROGIOS.FORNECEDOR_JURIDICO);
           if (dsFROGIOS.FORNECEDOR_FISICO.Rows.Count > 0) {
               fORNECEDOR_FISICO_NOMETextBox.Visible = true;
               fORNECEDOR_JURIDICO_FANTASIATextBox.Visible = false;
           }

           if (dsFROGIOS.FORNECEDOR_JURIDICO.Rows.Count > 0) {
               fORNECEDOR_FISICO_NOMETextBox.Visible = false;
               fORNECEDOR_JURIDICO_FANTASIATextBox.Visible = true;
           }
       }

       public void adicionarMarca(int codigo) {
           try {
               Conexao.abrir();
               TblMarca marcaSQL = new TblMarca();
               string coluna = dsFROGIOS.MARCA.MARCA_CODIGOColumn.ColumnName;
               string valor; try { valor = Convert.ToString(codigo); } catch (Exception) { valor = "-5"; }
               dsFROGIOS.MARCA.Clear();
               dsFROGIOS.MARCA.Load(marcaSQL.selecionar(coluna, valor, true));
           } catch (Exception erro) {
               exibirMensagemErro(erro.Message);
           } finally {
               Conexao.fechar();
           }
       }

       public void adicionarGrupo(int codigo) {
           try {
               Conexao.abrir();
               TblGrupo grupoSQL = new TblGrupo();
               string coluna = dsFROGIOS.GRUPO.GRUPO_CODIGOColumn.ColumnName;
               string valor; try { valor = Convert.ToString(codigo); } catch (Exception) { valor = "-5"; }
               dsFROGIOS.GRUPO.Clear();
               dsFROGIOS.GRUPO.Load(grupoSQL.selecionar(coluna, valor, true));
           } catch (Exception erro) {
               exibirMensagemErro(erro.Message);
           } finally {
               Conexao.fechar();
           }
       }

       public void adicionarSecao(int codigo) {
           try {
               Conexao.abrir();
               TblSecao secaoSQL = new TblSecao();
               string coluna = dsFROGIOS.SECAO.SECAO_CODIGOColumn.ColumnName;
               string valor; try { valor = Convert.ToString(codigo); } catch (Exception) { valor = "-5"; }
               dsFROGIOS.SECAO.Clear();
               dsFROGIOS.SECAO.Load(secaoSQL.selecionar(coluna, valor, true));
           } catch (Exception erro) {
               exibirMensagemErro(erro.Message);
           } finally {
               Conexao.fechar();
           }
       }

       public void adicionarFornecedor(int codigo, bool eFisico) {
           GerFornecedor fornecedorSQL = new GerFornecedor();
           dsFROGIOS.FORNECEDOR_FISICO.Clear();
           dsFROGIOS.FORNECEDOR_JURIDICO.Clear();
           if (eFisico) {
               fornecedorSQL.selecionar(codigo, dsFROGIOS.FORNECEDOR, dsFROGIOS.FORNECEDOR_FISICO, null, dsFROGIOS.UF);
           } else {
               fornecedorSQL.selecionar(codigo, dsFROGIOS.FORNECEDOR, null, dsFROGIOS.FORNECEDOR_JURIDICO, dsFROGIOS.UF);
           }

           if (dsFROGIOS.FORNECEDOR_FISICO.Rows.Count > 0) {
               fORNECEDOR_FISICO_NOMETextBox.Visible = true;
               fORNECEDOR_JURIDICO_FANTASIATextBox.Visible = false;
           } else {
               fORNECEDOR_FISICO_NOMETextBox.Visible = false;
               fORNECEDOR_JURIDICO_FANTASIATextBox.Visible = true;
           }
       }

       private void mARCA_DESCRICAOTextBox_DoubleClick(object sender, EventArgs e) {
           formPesquisaMarca marca = new formPesquisaMarca(this, false);
           marca.ShowDialog();
           marca.Dispose();
       }

       private void sECAO_DESCRICAOTextBox_DoubleClick(object sender, EventArgs e) {
           formPesquisaSecao secao = new formPesquisaSecao(this, false);
           secao.ShowDialog();
           secao.Dispose();
       }

       private void gRUPO_DESCRICAOTextBox_DoubleClick(object sender, EventArgs e) {
           formPesquisaGrupo grupo = new formPesquisaGrupo(this, false);
           grupo.ShowDialog();
           grupo.Dispose();
       }

       private void fORNECEDOR_FISICO_NOMETextBox_DoubleClick(object sender, EventArgs e) {
           formPesquisaFornecedor fornecedor = new formPesquisaFornecedor(this, false);
           fornecedor.ShowDialog();
           fornecedor.Dispose();
       }

       private void fORNECEDOR_JURIDICO_FANTASIATextBox_DoubleClick(object sender, EventArgs e) {
           formPesquisaFornecedor fornecedor = new formPesquisaFornecedor(this, false);
           fornecedor.ShowDialog();
           fornecedor.Dispose();
       }




    }
}