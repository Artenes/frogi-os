using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblServico {

        private string paramCodigo = "@CODIGO";
        private string paramDescricao = "@DESCRICAO";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.SERVICORow servico) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO SERVICO "
               + "VALUES (NULL, "
               + paramDescricao + ", "
               + paramValor + ") "
               + "RETURNING SERVICO_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramDescricao, servico.SERVICO_DESCRICAO);
            comando.Parameters.AddWithValue(paramValor, servico.SERVICO_VALOR);

            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.SERVICORow servico) {
            FbCommand comando = null;
            string sql =
                "UPDATE SERVICO "
                + "SET "
                + "SERVICO_DESCRICAO = " + paramDescricao + ", "
                + "SERVICO_VALOR = " + paramValor + " "
                + "WHERE SERVICO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, servico.SERVICO_CODIGO);
            comando.Parameters.AddWithValue(paramDescricao, servico.SERVICO_DESCRICAO);
            comando.Parameters.AddWithValue(paramValor, servico.SERVICO_VALOR);

            return comando.ExecuteNonQuery();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM SERVICO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.SERVICORow servico) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM SERVICO "
                + " WHERE SERVICO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, servico.SERVICO_CODIGO);

            return comando.ExecuteNonQuery();
        }
   
    }
}
