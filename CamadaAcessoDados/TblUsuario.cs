using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblUsuario {

        private string paramCodigo = "@CODIGO";
        private string paramNome = "@NOME";
        private string paramSenha = "@SENHA";
        private string paramCategoria = "@CATEGORIA";
        private string paramDataCadastro = "@DATACADASTRO";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.USUARIORow ususario) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO USUARIO "
               + "VALUES (NULL, "
               + paramNome + ", "
               + paramSenha + ", "
               + paramCategoria + ", "
               + paramDataCadastro + ") "
               + "RETURNING USUARIO_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramNome, ususario.USUARIO_NOME);
            comando.Parameters.AddWithValue(paramSenha, ususario.USUARIO_SENHA);
            comando.Parameters.AddWithValue(paramCategoria, ususario.USUARIO_CATEGORIA);
            comando.Parameters.AddWithValue(paramDataCadastro, ususario.USUARIO_DATA_CADASTRO);
            //try {
            //    comando.Parameters.AddWithValue(paramCategoria, ususario.USUARIO_CATEGORIA);
            //} catch (Exception) {
            //    comando.Parameters.AddWithValue(paramCategoria, null);
            //}
            
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.USUARIORow usuario) {
            FbCommand comando = null;
            string sql =
                "UPDATE USUARIO "
                + "SET "
                + "USUARIO_NOME = " + paramNome + ", "
                + "USUARIO_SENHA = " + paramSenha + ", "
                + "USUARIO_CATEGORIA = " + paramCategoria + ", "
                + "USUARIO_DATA_CADASTRO = " + paramDataCadastro + " "
                + "WHERE USUARIO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, usuario.USUARIO_CODIGO);
            comando.Parameters.AddWithValue(paramNome, usuario.USUARIO_NOME);
            comando.Parameters.AddWithValue(paramSenha, usuario.USUARIO_SENHA);
            comando.Parameters.AddWithValue(paramCategoria, usuario.USUARIO_CATEGORIA);
            comando.Parameters.AddWithValue(paramDataCadastro, usuario.USUARIO_DATA_CADASTRO);

            return comando.ExecuteNonQuery();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM USUARIO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.USUARIORow usuario) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM USUARIO "
                + " WHERE USUARIO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, usuario.USUARIO_CODIGO);

            return comando.ExecuteNonQuery();
        }

    }
}
