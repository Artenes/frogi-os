using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblGrupo {

        private string paramCodigo = "@CODIGO";
        private string paramDescricao = "@DESCRICAO";
        private string paramDesconto = "@DESCONTO";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.GRUPORow grupo) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO GRUPO "
               + "VALUES (NULL, " 
               + paramDescricao + ", "
               + paramDesconto + ") "
               + "RETURNING GRUPO_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramDescricao, grupo.GRUPO_DESCRICAO);
            comando.Parameters.AddWithValue(paramDesconto, grupo.GRUPO_DESCONTO);
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.GRUPORow grupo) {
            FbCommand comando = null;
            string sql =
                "UPDATE GRUPO "
                + "SET GRUPO_DESCRICAO = " + paramDescricao + ", "
                + "GRUPO_DESCONTO = " + paramDesconto + " "
                + "WHERE GRUPO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, grupo.GRUPO_CODIGO);
            comando.Parameters.AddWithValue(paramDescricao, grupo.GRUPO_DESCRICAO);
            comando.Parameters.AddWithValue(paramDescricao, grupo.GRUPO_DESCONTO);

            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM GRUPO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.GRUPORow grupo) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM GRUPO "
                + " WHERE GRUPO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, grupo.GRUPO_CODIGO);

            return (int)comando.ExecuteScalar();
        }

    }
}
