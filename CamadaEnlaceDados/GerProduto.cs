using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FROGI_OS.CamadaAcessoDados;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaEnlaceDados {
    class GerProduto {

        private string paramValor = "@VALOR";

        public void inserir(dsFROGIOS.PRODUTORow produto) {
            TblProduto produtoSQL = new TblProduto();
            produtoSQL.inserir(produto);
        }

        public void atualizar(dsFROGIOS.PRODUTORow produto) {
            TblProduto produtoSQL = new TblProduto();
            produtoSQL.atualizar(produto);
        }

        public FbDataReader pesquisar(string coluna, string valor) {

            string sql = 
                "SELECT PRODUTO_CODIGO, PRODUTO_DESCRICAO, MARCA_DESCRICAO, PRODUTO_UNIDADE_VENDA, PRODUTO_PRECO_VENDA, PRODUTO_ESTOQUE_ATUAL "
            + "FROM PRODUTO "
            + "INNER JOIN MARCA "
            + "ON PRODUTO_MARCA = MARCA_CODIGO "
            + "WHERE " + coluna + " CONTAINING " + paramValor + ";";

            FbCommand comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public void selecionar(
            int codigo,
            dsFROGIOS.PRODUTODataTable produto,
            dsFROGIOS.MARCADataTable marca,
            dsFROGIOS.GRUPODataTable grupo,
            dsFROGIOS.SECAODataTable secao,
            dsFROGIOS.FORNECEDORDataTable fornecedor,
            dsFROGIOS.FORNECEDOR_FISICODataTable fisico,
            dsFROGIOS.FORNECEDOR_JURIDICODataTable juridico
            ) {

                TblProduto produtoSQL = new TblProduto();
                produto.Clear();
                produto.Load(produtoSQL.selecionar(
                    produto.PRODUTO_CODIGOColumn.ColumnName,
                    codigo.ToString(),
                    true
                ));
                dsFROGIOS.PRODUTORow produtoLinha = (dsFROGIOS.PRODUTORow)produto.Rows[0];

                try {
                    TblMarca marcaSQL = new TblMarca();
                    marca.Load(marcaSQL.selecionar(
                        marca.MARCA_CODIGOColumn.ColumnName,
                        produtoLinha.PRODUTO_MARCA.ToString(),
                        true
                        ));
                } catch (Exception) {}

                try {
                    TblGrupo grupoSQL = new TblGrupo();
                    grupo.Load(grupoSQL.selecionar(
                        grupo.GRUPO_CODIGOColumn.ColumnName,
                        produtoLinha.PRODUTO_GRUPO.ToString(),
                        true
                        ));
                } catch (Exception) {}


                try {
                    TblSecao secaoSQL = new TblSecao();
                    secao.Load(secaoSQL.selecionar(
                        secao.SECAO_CODIGOColumn.ColumnName,
                        produtoLinha.PRODUTO_SECAO.ToString(),
                        true
                        ));    
                } catch (Exception) {}
            
                
                try {	        
                    TblFornecedor fornecedorSQL = new TblFornecedor();
                    fornecedor.Load(fornecedorSQL.selecionar(
                        fornecedor.FORNECEDOR_CODIGOColumn.ColumnName,
                        produtoLinha.PRODUTO_FORNECEDOR.ToString(),
                        true
                    ));

                    dsFROGIOS.FORNECEDORRow fornecedorLinha = (dsFROGIOS.FORNECEDORRow)fornecedor.Rows[0];

                    TblFornecedorFisico fisicoSQL = new TblFornecedorFisico();
                    fisico.Load(fisicoSQL.selecionar(
                        fisico.FORNECEDOR_FISICO_FORNECEDORColumn.ColumnName,
                        fornecedorLinha.FORNECEDOR_CODIGO.ToString(),
                        true
                        ));

                    TblFornecedorJuridico juridicoSQL = new TblFornecedorJuridico();
                    juridico.Load(juridicoSQL.selecionar(
                        juridico.FORNECEDOR_JURIDICO_FORNECEDORColumn.ColumnName,
                        fornecedorLinha.FORNECEDOR_CODIGO.ToString(),
                        true
                        ));

                } catch (Exception) {}
                
        }

        public void deletar(dsFROGIOS.PRODUTORow produto) {
            TblProduto produtoSQL = new TblProduto();
            produtoSQL.deletar(produto);
        }

    }
}