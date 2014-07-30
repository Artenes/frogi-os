using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblItemCompra {

        private string paramCodigo = "@CODIGO";
        private string paramCompra = "@COMPRA";
        private string paramProduto = "@PRODUTO";
        private string paramPreco = "@PRECO";
        private string paramDesconto = "@DESCONTO";
        private string paramQuantidade = "@QUANTIDADE";
        private string paramPrecoTotal = "@PRECOTOTAL";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.ITEM_COMPRARow itemCompra) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO ITEM_COMPRA "
               + "VALUES (NULL, "
               + paramCompra + ", "
               + paramProduto + ", "
               + paramPreco + ", "
               + paramDesconto + ", "
               + paramQuantidade + ", "
               + paramPrecoTotal + ") "
               + "RETURNING ITEM_COMPRA_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCompra, itemCompra.ITEM_COMPRA_COMPRA);
            comando.Parameters.AddWithValue(paramProduto, itemCompra.ITEM_COMPRA_PRODUTO);
            comando.Parameters.AddWithValue(paramPreco, itemCompra.ITEM_COMPRA_PRECO);
            comando.Parameters.AddWithValue(paramDesconto, itemCompra.ITEM_COMPRA_DESCONTO);
            comando.Parameters.AddWithValue(paramQuantidade, itemCompra.ITEM_COMPRA_QUANTIDADE);
            comando.Parameters.AddWithValue(paramPrecoTotal, itemCompra.ITEM_COMPRA_PRECO_TOTAL);
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.ITEM_COMPRARow itemCompra) {
            FbCommand comando = null;
            string sql =
                "UPDATE ITEM_COMPRA "
                + "SET "
                + "ITEM_COMPRA_COMPRA = " + paramCompra + ", "
                + "ITEM_COMPRA_PRODUTO = " + paramProduto + ", "
                + "ITEM_COMPRA_PRECO = " + paramPreco + ", "
                + "ITEM_COMPRA_DESCONTO = " + paramDesconto + ", "
                + "ITEM_COMPRA_QUANTIDADE = " + paramQuantidade + ", "
                + "ITEM_COMPRA_PRECO_TOTAL = " + paramPrecoTotal + " "
                + "WHERE ITEM_COMPRA_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, itemCompra.ITEM_COMPRA_CODIGO);
            comando.Parameters.AddWithValue(paramCompra, itemCompra.ITEM_COMPRA_COMPRA);
            comando.Parameters.AddWithValue(paramProduto, itemCompra.ITEM_COMPRA_PRODUTO);
            comando.Parameters.AddWithValue(paramPreco, itemCompra.ITEM_COMPRA_PRECO);
            comando.Parameters.AddWithValue(paramDesconto, itemCompra.ITEM_COMPRA_DESCONTO);
            comando.Parameters.AddWithValue(paramQuantidade, itemCompra.ITEM_COMPRA_QUANTIDADE);
            comando.Parameters.AddWithValue(paramPrecoTotal, itemCompra.ITEM_COMPRA_PRECO_TOTAL);

            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM ITEM_COMPRA "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.ITEM_COMPRARow itemCompra) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM ITEM_COMPRA "
                + " WHERE ITEM_COMPRA_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, itemCompra.ITEM_COMPRA_CODIGO);

            return (int)comando.ExecuteScalar();
        }

    }
}
