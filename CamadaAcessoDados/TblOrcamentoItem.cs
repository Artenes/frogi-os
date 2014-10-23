using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblOrcamentoItem {

        private string paramCodigo = "@CODIGO";
        private string paramOrcamento = "@ORCAMENTO";
        private string paramProduto = "@PRODUTO";
        private string paramDescricao = "@DESCRICAO";
        //private string paramValor = "@VALOR";
        private string paramDesconto = "@DESCONTO";
        private string paramQuantidade = "@QUANTIDADE";
        private string paramTotal = "@TOTAL";
        
        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.ORCAMENTO_ITEMRow orcamentoItem) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO ORCAMENTO_ITEM "
               + "VALUES (NULL, "
               + paramOrcamento + ", "
               + paramProduto + ", "
               + paramValor + ", "
               + paramDescricao + ", "
               + paramDesconto + ", "
               + paramQuantidade + ", "
               + paramTotal + ") "
               + "RETURNING ORCAMENTO_ITEM_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramOrcamento, orcamentoItem.ORCAMENTO_ITEM_ORCAMENTO);
            comando.Parameters.AddWithValue(paramProduto, orcamentoItem.ORCAMENTO_ITEM_PRODUTO);
            comando.Parameters.AddWithValue(paramValor, orcamentoItem.ORCAMENTO_ITEM_VALOR);
            comando.Parameters.AddWithValue(paramDescricao, orcamentoItem.ORCAMENTO_ITEM_DESCRICAO);
            comando.Parameters.AddWithValue(paramDesconto, orcamentoItem.ORCAMENTO_ITEM_DESCONTO);
            comando.Parameters.AddWithValue(paramQuantidade, orcamentoItem.ORCAMENTO_ITEM_QUANTIDADE);
            comando.Parameters.AddWithValue(paramTotal, orcamentoItem.ORCAMENTO_ITEM_TOTAL);
            
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.ORCAMENTO_ITEMRow orcamentoItem) {
            FbCommand comando = null;
            string sql =
                "UPDATE ORCAMENTO_ITEM "
                + "SET "
                + "ORCAMENTO_ITEM_ORCAMENTO = " + paramOrcamento + ", "
                + "ORCAMENTO_ITEM_PRODUTO = " + paramProduto + ", "
                + "ORCAMENTO_ITEM_VALOR = " + paramValor + ", "
                + "ORCAMENTO_ITEM_DESCRICAO = " + paramDescricao + ", "
                + "ORCAMENTO_ITEM_DESCONTO = " + paramDesconto + ", "
                + "ORCAMENTO_ITEM_QUANTIDADE = " + paramQuantidade + ", "
                + "ORCAMENTO_ITEM_TOTAL = " + paramTotal + " "
                + "WHERE ORCAMENTO_ITEM_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, orcamentoItem.ORCAMENTO_ITEM_CODIGO);
            comando.Parameters.AddWithValue(paramOrcamento, orcamentoItem.ORCAMENTO_ITEM_ORCAMENTO);
            comando.Parameters.AddWithValue(paramProduto, orcamentoItem.ORCAMENTO_ITEM_PRODUTO);
            comando.Parameters.AddWithValue(paramValor, orcamentoItem.ORCAMENTO_ITEM_VALOR);
            comando.Parameters.AddWithValue(paramDescricao, orcamentoItem.ORCAMENTO_ITEM_DESCRICAO);
            comando.Parameters.AddWithValue(paramDesconto, orcamentoItem.ORCAMENTO_ITEM_DESCONTO);
            comando.Parameters.AddWithValue(paramQuantidade, orcamentoItem.ORCAMENTO_ITEM_QUANTIDADE);
            comando.Parameters.AddWithValue(paramTotal, orcamentoItem.ORCAMENTO_ITEM_TOTAL);

            return comando.ExecuteNonQuery();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM ORCAMENTO_ITEM "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.ORCAMENTO_ITEMRow orcamentoItem) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM ORCAMENTO_ITEM "
                + " WHERE ORCAMENTO_ITEM_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, orcamentoItem.ORCAMENTO_ITEM_CODIGO);

            return comando.ExecuteNonQuery();
        }

    }
}

