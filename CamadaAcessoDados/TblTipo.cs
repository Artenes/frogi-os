using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS {
    class TblTipo {

        private string paramCodigo = "@CODIGO";
        private string paramDescricao = "@DESCRICAO";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.TIPORow tipo) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO TIPO "
               + "VALUES (NULL, "
               + paramDescricao + ") "
               + "RETURNING TIPO_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramDescricao, tipo.TIPO_DESCRICAO);

            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.TIPORow tipo) {
            FbCommand comando = null;
            string sql =
                "UPDATE TIPO "
                + "SET "
                + "TIPO_DESCRICAO = " + paramDescricao + " "
                + "WHERE TIPO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, tipo.TIPO_CODIGO);
            comando.Parameters.AddWithValue(paramDescricao, tipo.TIPO_DESCRICAO);

            return comando.ExecuteNonQuery();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM TIPO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.TIPORow tipo) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM TIPO "
                + " WHERE TIPO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, tipo.TIPO_CODIGO);

            return comando.ExecuteNonQuery();
        }

    }
}
