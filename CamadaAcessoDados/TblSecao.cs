using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblSecao {

        private string paramCodigo = "@CODIGO";
        private string paramDescricao = "@DESCRICAO";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.SECAORow secao) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO SECAO "
               + "VALUES (NULL, "
               + paramDescricao + ") "
               + "RETURNING SECAO_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramDescricao, secao.SECAO_DESCRICAO);

            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.SECAORow secao) {
            FbCommand comando = null;
            string sql =
                "UPDATE SECAO "
                + "SET "
                + "SECAO_DESCRICAO = " + paramDescricao + " "
                + "WHERE SECAO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, secao.SECAO_CODIGO);
            comando.Parameters.AddWithValue(paramDescricao, secao.SECAO_DESCRICAO);

            return comando.ExecuteNonQuery();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM SECAO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.SECAORow secao) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM SECAO "
                + " WHERE SECAO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, secao.SECAO_CODIGO);

            return comando.ExecuteNonQuery();
        }

    }
}
