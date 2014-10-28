using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblOsServico {

        private string paramCodigo = "@CODIGO";
        private string paramOs = "@OS";
        private string paramServico = "@SERVICO";
        //private string paramValor = "@VALOR";
        private string paramDescricao = "@DESCRICAO";
        private string paramDesconto = "@DESCONTO";
        private string paramAcrescimo = "@ACRESCIMO";
        private string paramTotal = "@TOTAL";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.OS_SERVICORow osServico) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO OS_SERVICO "
               + "VALUES (NULL, "
               + paramOs + ", "
               + paramServico + ", "
               + paramValor + ", "
               + paramDescricao + ", "
               + paramDesconto + ", "
               + paramAcrescimo + ", "
               + paramTotal + ") "
               + "RETURNING OS_SERVICO_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramOs, osServico.OS_SERVICO_OS);
            comando.Parameters.AddWithValue(paramServico, osServico.OS_SERVICO_SERVICO);
            comando.Parameters.AddWithValue(paramValor, osServico.OS_SERVICO_VALOR);
            comando.Parameters.AddWithValue(paramDescricao, osServico.OS_SERVICO_DESCRICAO);
            comando.Parameters.AddWithValue(paramDesconto, osServico.OS_SERVICO_DESCONTO);
            comando.Parameters.AddWithValue(paramAcrescimo, osServico.OS_SERVICO_ACRESCIMO);
            comando.Parameters.AddWithValue(paramTotal, osServico.OS_SERVICO_TOTAL);

            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.OS_SERVICORow osServico) {
            FbCommand comando = null;
            string sql =
                "UPDATE OS_SERVICO "
                + "SET "
                + "OS_SERVICO_OS = " + paramOs + ", "
                + "OS_SERVICO_SERVICO = " + paramServico + ", "
                + "OS_SERVICO_VALOR = " + paramValor + ", "
                + "OS_SERVICO_DESCRICAO = " + paramDescricao + ", "
                + "OS_SERVICO_DESCONTO = " + paramDesconto + ", "
                + "OS_SERVICO_ACRESCIMO = " + paramAcrescimo + ", "
                + "OS_SERVICO_TOTAL = " + paramTotal + " "
                + "WHERE OS_SERVICO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, osServico.OS_SERVICO_CODIGO);
            comando.Parameters.AddWithValue(paramOs, osServico.OS_SERVICO_OS);
            comando.Parameters.AddWithValue(paramServico, osServico.OS_SERVICO_SERVICO);
            comando.Parameters.AddWithValue(paramValor, osServico.OS_SERVICO_VALOR);
            comando.Parameters.AddWithValue(paramDescricao, osServico.OS_SERVICO_DESCRICAO);
            comando.Parameters.AddWithValue(paramDesconto, osServico.OS_SERVICO_DESCONTO);
            comando.Parameters.AddWithValue(paramAcrescimo, osServico.OS_SERVICO_ACRESCIMO);
            comando.Parameters.AddWithValue(paramTotal, osServico.OS_SERVICO_TOTAL);

            return comando.ExecuteNonQuery();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM OS_SERVICO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.OS_SERVICORow osServico) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM OS_SERVICO "
                + " WHERE OS_SERVICO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, osServico.OS_SERVICO_CODIGO);

            return comando.ExecuteNonQuery();
        }

    }
}
