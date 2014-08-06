using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblPermissao {

        private string paramCodigo = "@CODIGO";
        private string paramDescricao = "@DESCRICAO";
        private string paramUsuario = "@USUARIO";
        
        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.PERMISSAORow permissao) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO PERMISSAO "
               + "VALUES (NULL, "
               + paramDescricao + ", "
               + paramUsuario + ") "
               + "RETURNING PERMISSAO_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramDescricao, permissao.PERMISSAO_DESCRICAO);
            comando.Parameters.AddWithValue(paramUsuario, permissao.PERMISSAO_USUARIO);

            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.PERMISSAORow permissao) {
            FbCommand comando = null;
            string sql =
                "UPDATE PERMISSAO "
                + "SET "
                + "PERMISSAO_DESCRICAO = " + paramDescricao + ", "
                + "PERMISSAO_USUARIO = " + paramUsuario + " "
                + "WHERE PERMISSAO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, permissao.PERMISSAO_CODIGO);
            comando.Parameters.AddWithValue(paramDescricao, permissao.PERMISSAO_DESCRICAO);
            comando.Parameters.AddWithValue(paramUsuario, permissao.PERMISSAO_USUARIO);

            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM PERMISSAO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.PERMISSAORow permissao) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM PERMISSAO "
                + " WHERE PERMISSAO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, permissao.PERMISSAO_CODIGO);

            return (int)comando.ExecuteScalar();
        }

    }
}
