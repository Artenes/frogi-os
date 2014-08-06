using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS {
    class TblProduto {

        private string paramCodigo = "@CODIGO";
        private string paramDescricao = "@DESCRICAO";
        private string paramCaracteristica = "@CARACTERISTICA";
        private string paramUnidadeCompra = "@UNIDADECOMPRA";
        private string paramUnidadeVenda = "@UNIDADEVENDA";
        private string paramPeso = "@PESO";
        private string paramNumero = "@NUMERO";
        private string paramEan = "@EAN";
        private string paramNumeroSerie = "@NUMEROSERIE";
        private string paramMarca = "@MARCA";
        private string paramGrupo = "@GRUPO";
        private string paramSecao = "@SECAO";
        private string paramFornecedor = "@FORNECEDOR";
        private string paramCfop = "@CFOP";
        private string paramCsosn = "@CSOSN";
        private string paramNcm = "@NCM";
        private string paramSituacaoTributaria = "@SITUACAOTRIBUTARIA";
        private string paramOrigemMercadoria = "@ORIGEMMERCADORIA";
        private string paramEstoqueMinimo = "@ESTOQUEMINIMO";
        private string paramEstoqueMaximo = "@ESTOQUEMAXIMO";
        private string paramEstoqueAtual = "@ESTOQUEATUAL";
        private string paramPrecoCompra = "@PRECOCOMPRA";
        private string paramPrecoCusto = "@PRECOCUSTO";
        private string paramPrecoVenda = "@PRECOVENDA";
        private string paramDataCadastro = "@DATACADASTRO";
        
        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.PRODUTORow produto) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO PRODUTO "
               + "VALUES (NULL, "
               + paramDescricao + ", "
               + paramCaracteristica + ", "
               + paramUnidadeCompra + ", "
               + paramUnidadeVenda + ", "
               + paramPeso + ", "
               + paramNumero + ", "
               + paramEan + ", "
               + paramNumeroSerie + ", "
               + paramMarca + ", "
               + paramGrupo + ", "
               + paramSecao + ", "
               + paramFornecedor + ", "
               + paramCfop + ", "
               + paramCsosn + ", "
               + paramNcm + ", "
               + paramSituacaoTributaria + ", "
               + paramOrigemMercadoria + ", "
               + paramEstoqueMinimo + ", "
               + paramEstoqueMaximo + ", "
               + paramEstoqueAtual + ", "
               + paramPrecoCompra + ", "
               + paramPrecoCusto + ", "
               + paramPrecoVenda + ", "
               + paramDataCadastro + ") "
               + "RETURNING PRODUTO_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramDescricao, produto.PRODUTO_DESCRICAO);
            comando.Parameters.AddWithValue(paramCaracteristica, produto.PRODUTO_CARACTERISTICA);
            comando.Parameters.AddWithValue(paramUnidadeCompra, produto.PRODUTO_UNIDADE_COMPRA);
            comando.Parameters.AddWithValue(paramUnidadeVenda, produto.PRODUTO_UNIDADE_VENDA);
            comando.Parameters.AddWithValue(paramPeso, produto.PRODUTO_PESO);
            comando.Parameters.AddWithValue(paramNumero, produto.PRODUTO_NUMERO);
            comando.Parameters.AddWithValue(paramEan, produto.PRODUTO_EAN);
            comando.Parameters.AddWithValue(paramNumeroSerie, produto.PRODUTO_NUMERO_SERIE);
            comando.Parameters.AddWithValue(paramMarca, produto.PRODUTO_MARCA);
            comando.Parameters.AddWithValue(paramGrupo, produto.PRODUTO_GRUPO);
            comando.Parameters.AddWithValue(paramSecao, produto.PRODUTO_SECAO);
            comando.Parameters.AddWithValue(paramFornecedor, produto.PRODUTO_FORNECEDOR);
            comando.Parameters.AddWithValue(paramCfop, produto.PRODUTO_CFOP);
            comando.Parameters.AddWithValue(paramCsosn, produto.PRODUTO_CSOSN);
            comando.Parameters.AddWithValue(paramNcm, produto.PRODUTO_NCM);
            comando.Parameters.AddWithValue(paramSituacaoTributaria, produto.PRODUTO_SITUACAO_TRIBUTARIA);
            comando.Parameters.AddWithValue(paramOrigemMercadoria, produto.PRODUTO_ORIGEM_MERCADORIA);
            comando.Parameters.AddWithValue(paramEstoqueMinimo, produto.PRODUTO_ESTOQUE_MINIMO);
            comando.Parameters.AddWithValue(paramEstoqueMaximo, produto.PRODUTO_ESTOQUE_MAXIMO);
            comando.Parameters.AddWithValue(paramEstoqueAtual, produto.PRODUTO_ESTOQUE_ATUAL);
            comando.Parameters.AddWithValue(paramPrecoCompra, produto.PRODUTO_PRECO_COMPRA);
            comando.Parameters.AddWithValue(paramPrecoCusto, produto.PRODUTO_PRECO_CUSTO);
            comando.Parameters.AddWithValue(paramPrecoVenda, produto.PRODUTO_PRECO_VENDA);
            comando.Parameters.AddWithValue(paramDataCadastro, produto.PRODUTO_DATA_CADASTRO);

            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.PRODUTORow produto) {
            FbCommand comando = null;
            string sql =
                "UPDATE PRODUTO "
                + "SET "
                + "PRODUTO_DESCRICAO = " + paramDescricao + ", "
                + "PRODUTO_CARACTERISTICA = " + paramCaracteristica + ", "
                + "PRODUTO_UNIDADE_COMPRA = " + paramUnidadeCompra + ", "
                + "PRODUTO_UNIDADE_VENDA = " + paramUnidadeVenda + ", "
                + "PRODUTO_PESO = " + paramPeso + ", "
                + "PRODUTO_NUMERO = " + paramNumero + ", "
                + "PRODUTO_EAN = " + paramEan + ", "
                + "PRODUTO_NUMERO_SERIE = " + paramNumeroSerie + ", "
                + "PRODUTO_MARCA = " + paramMarca + ", "
                + "PRODUTO_GRUPO = " + paramGrupo + ", "
                + "PRODUTO_SECAO = " + paramSecao + ", "
                + "PRODUTO_FORNECEDOR = " + paramFornecedor + ", "
                + "PRODUTO_CFOP = " + paramCfop + ", "
                + "PRODUTO_CSOSN = " + paramCsosn + ", "
                + "PRODUTO_NCM = " + paramNcm + ", "
                + "PRODUTO_SITUACAO_TRIBUTARIA = " + paramSituacaoTributaria + ", "
                + "PRODUTO_ORIGEM_MERCADORIA = " + paramOrigemMercadoria + ", "
                + "PRODUTO_ESTOQUE_MINIMO = " + paramEstoqueMinimo + ", "
                + "PRODUTO_ESTOQUE_MAXIMO = " + paramEstoqueMaximo + ", "
                + "PRODUTO_ESTOQUE_ATUAL = " + paramEstoqueAtual + ", "
                + "PRODUTO_PRECO_COMPRA = " + paramPrecoCompra + ", "
                + "PRODUTO_PRECO_CUSTO = " + paramPrecoCusto + ", "
                + "PRODUTO_PRECO_VENDA = " + paramPrecoVenda + ", "
                + "PRODUTO_DATA_CADASTRO = " + paramDataCadastro + " "
                + "WHERE PRODUTO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, produto.PRODUTO_CODIGO);
            comando.Parameters.AddWithValue(paramDescricao, produto.PRODUTO_DESCRICAO);
            comando.Parameters.AddWithValue(paramCaracteristica, produto.PRODUTO_CARACTERISTICA);
            comando.Parameters.AddWithValue(paramUnidadeCompra, produto.PRODUTO_UNIDADE_COMPRA);
            comando.Parameters.AddWithValue(paramUnidadeVenda, produto.PRODUTO_UNIDADE_VENDA);
            comando.Parameters.AddWithValue(paramPeso, produto.PRODUTO_PESO);
            comando.Parameters.AddWithValue(paramNumero, produto.PRODUTO_NUMERO);
            comando.Parameters.AddWithValue(paramEan, produto.PRODUTO_EAN);
            comando.Parameters.AddWithValue(paramNumeroSerie, produto.PRODUTO_NUMERO_SERIE);
            comando.Parameters.AddWithValue(paramMarca, produto.PRODUTO_MARCA);
            comando.Parameters.AddWithValue(paramGrupo, produto.PRODUTO_GRUPO);
            comando.Parameters.AddWithValue(paramSecao, produto.PRODUTO_SECAO);
            comando.Parameters.AddWithValue(paramFornecedor, produto.PRODUTO_FORNECEDOR);
            comando.Parameters.AddWithValue(paramCfop, produto.PRODUTO_CFOP);
            comando.Parameters.AddWithValue(paramCsosn, produto.PRODUTO_CSOSN);
            comando.Parameters.AddWithValue(paramNcm, produto.PRODUTO_NCM);
            comando.Parameters.AddWithValue(paramSituacaoTributaria, produto.PRODUTO_SITUACAO_TRIBUTARIA);
            comando.Parameters.AddWithValue(paramOrigemMercadoria, produto.PRODUTO_ORIGEM_MERCADORIA);
            comando.Parameters.AddWithValue(paramEstoqueMinimo, produto.PRODUTO_ESTOQUE_MINIMO);
            comando.Parameters.AddWithValue(paramEstoqueMaximo, produto.PRODUTO_ESTOQUE_MAXIMO);
            comando.Parameters.AddWithValue(paramEstoqueAtual, produto.PRODUTO_ESTOQUE_ATUAL);
            comando.Parameters.AddWithValue(paramPrecoCompra, produto.PRODUTO_PRECO_COMPRA);
            comando.Parameters.AddWithValue(paramPrecoCusto, produto.PRODUTO_PRECO_CUSTO);
            comando.Parameters.AddWithValue(paramPrecoVenda, produto.PRODUTO_PRECO_VENDA);
            comando.Parameters.AddWithValue(paramDataCadastro, produto.PRODUTO_DATA_CADASTRO);

            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM PRODUTO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.PRODUTORow produto) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM PRODUTO "
                + " WHERE PRODUTO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, produto.PRODUTO_CODIGO);

            return (int)comando.ExecuteScalar();
        }

    }
}
