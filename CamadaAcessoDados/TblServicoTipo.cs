using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS {
    class TblServicoTipo {

        private string paramServico = "@SERVICO";
        private string paramTipo = "@TIPO";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.SERVICO_TIPORow servicoTipo) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO SERVICO_TIPO "
               + "VALUES ("
               + paramServico + ", "
               + paramTipo + ") "
               + "RETURNING SERVICO_TIPO_SERVICO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramServico, servicoTipo.SERVICO_TIPO_SERVICO);
            comando.Parameters.AddWithValue(paramTipo, servicoTipo.SERVICO_TIPO_TIPO);

            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM SERVICO_TIPO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.SERVICO_TIPORow servicoTipo) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM SERVICO_TIPO "
                + " WHERE SERVICO_TIPO_SERVICO = " + paramServico + " AND SERVICO_TIPO_TIPO = " + paramTipo;

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramServico, servicoTipo.SERVICO_TIPO_SERVICO);
            comando.Parameters.AddWithValue(paramTipo, servicoTipo.SERVICO_TIPO_TIPO);

            return comando.ExecuteNonQuery();
        }
    }
}
