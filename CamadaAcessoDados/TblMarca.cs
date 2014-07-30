using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblMarca {

        private string paramCodigo = "@CODIGO";
        private string paramDescricao = "@DESCRICAO";
        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.MARCARow marca) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO MARCA "
               + "VALUES (NULL, " + paramDescricao + ") "
               + "RETURNING MARCA_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramDescricao, marca.MARCA_DESCRICAO);
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.MARCARow marca) {
            FbCommand comando = null;
            string sql =
                "UPDATE MARCA "
                + "SET MARCA_DESCRICAO = " + paramDescricao + " "
                + "WHERE MARCA_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, marca);
            comando.Parameters.AddWithValue(paramDescricao, marca.MARCA_DESCRICAO);

            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM MARCA "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.MARCARow marca) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM MARCA "
                + " WHERE MARCA_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, marca.MARCA_CODIGO);

            return (int)comando.ExecuteScalar();
        }

    }
}
