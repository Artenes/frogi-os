using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblOsItem {

        private string paramCodigo = "@CODIGO";
        private string paramOs = "@OS";
        private string paramProduto = "@PRODUTO";
        private string paramDescricao = "@DESCRICAO";
        //private string paramValor = "@VALOR";
        private string paramDesconto = "@DESCONTO";
        private string paramQuantidade = "@QUANTIDADE";
        private string paramTotal = "@TOTAL";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.OS_ITEMRow osItem) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO OS_ITEM "
               + "VALUES (NULL, "
               + paramOs + ", "
               + paramProduto + ", "
               + paramDescricao + ", "
               + paramValor + ", "
               + paramDesconto + ", "
               + paramQuantidade + ", "
               + paramTotal + ") "
               + "RETURNING OS_ITEM_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramOs, osItem.OS_ITEM_OS);
            comando.Parameters.AddWithValue(paramProduto, osItem.OS_ITEM_PRODUTO);
            comando.Parameters.AddWithValue(paramDescricao, osItem.OS_ITEM_DESCRICAO);
            comando.Parameters.AddWithValue(paramValor, osItem.OS_ITEM_VALOR);
            comando.Parameters.AddWithValue(paramDesconto, osItem.OS_ITEM_DESCONTO);
            comando.Parameters.AddWithValue(paramQuantidade, osItem.OS_ITEM_QUANTIDADE);
            comando.Parameters.AddWithValue(paramTotal, osItem.OS_ITEM_TOTAL);
            
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.OS_ITEMRow osItem) {
            FbCommand comando = null;
            string sql =
                "UPDATE OS_ITEM "
                + "SET "
                + "OS_ITEM_OS = " + paramOs + ", "
                + "OS_ITEM_PRODUTO = " + paramProduto + ", "
                + "OS_ITEM_DESCRICAO = " + paramDescricao + ", "
                + "OS_ITEM_VALOR = " + paramValor + ", "
                + "OS_ITEM_DESCONTO = " + paramDesconto + ", "
                + "OS_ITEM_QUANTIDADE = " + paramQuantidade + ", "
                + "OS_ITEM_TOTAL = " + paramTotal + " "
                + "WHERE OS_ITEM_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, osItem.OS_ITEM_CODIGO);
            comando.Parameters.AddWithValue(paramOs, osItem.OS_ITEM_OS);
            comando.Parameters.AddWithValue(paramProduto, osItem.OS_ITEM_PRODUTO);
            comando.Parameters.AddWithValue(paramDescricao, osItem.OS_ITEM_DESCRICAO);
            comando.Parameters.AddWithValue(paramValor, osItem.OS_ITEM_VALOR);
            comando.Parameters.AddWithValue(paramDesconto, osItem.OS_ITEM_DESCONTO);
            comando.Parameters.AddWithValue(paramQuantidade, osItem.OS_ITEM_QUANTIDADE);
            comando.Parameters.AddWithValue(paramTotal, osItem.OS_ITEM_TOTAL);

            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM OS_ITEM "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.OS_ITEMRow osItem) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM OS_ITEM "
                + " WHERE OS_ITEM_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, osItem.OS_ITEM_CODIGO);

            return (int)comando.ExecuteScalar();
        }

    }
}
