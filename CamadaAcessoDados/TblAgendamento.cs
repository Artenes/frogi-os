using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblAgendamento {

        private string
            paramValor = "@VALOR",
            paramCodigo = "@CODIGO",
            paramCliente = "@CLIENTE",
            paramData = "@DATA",
            paramDescricao = "@DESCRICAO";

        public int inserir(dsFROGIOS.AGENDAMENTORow agendamento) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO AGENDAMENTO "
                + "VALUES ("
                + "NULL, "
                + paramCliente + ", "
                + paramData + ", "
                + paramDescricao + " "
                + ") "
                + "RETURNING AGEN_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCliente, agendamento.AGEN_CLIENTE);
            comando.Parameters.AddWithValue(paramData, agendamento.AGEN_DATA);
            comando.Parameters.AddWithValue(paramDescricao, agendamento.AGEN_DESCRICAO);

            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.AGENDAMENTORow agendamento) {
            FbCommand comando = null;
            string sql =
                "UPDATE AGENDAMENTO "
                + "SET AGEN_CLIENTE = " + paramCliente + ", "
                + "AGEN_DATA = " + paramData + ", "
                + "AGEN_DESCRICAO = " + paramDescricao + " "
                + "WHERE AGEN_CODIGO = " + paramCodigo + ";";
            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, agendamento.AGEN_CODIGO);
            comando.Parameters.AddWithValue(paramCliente, agendamento.AGEN_CLIENTE);
            comando.Parameters.AddWithValue(paramData, agendamento.AGEN_DATA);
            comando.Parameters.AddWithValue(paramDescricao, agendamento.AGEN_DESCRICAO);

            return comando.ExecuteNonQuery();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM AGENDAMENTO "
                + "WHERE " + coluna + precisao + paramValor + ";";
            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.AGENDAMENTORow agendamento) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM AGENDAMENTO "
                + " WHERE AGEN_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, agendamento.AGEN_CODIGO);
            return comando.ExecuteNonQuery();
        }

    }
}
