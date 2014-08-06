using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblOrcamentoServico {

        private string paramCodigo = "@CODIGO";
        private string paramOrcamento = "@ORCAMENTO";
        private string paramServico = "@SERVICO";
        //private string paramValor = "@VALOR";
        private string paramDescricao = "@DESCRICAO";
        private string paramDesconto = "@DESCONTO";
        private string paramAcrescimo = "@ACRESCIMO";
        private string paramTotal = "@TOTAL";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.ORCAMENTO_SERVICORow orcamentoServico) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO ORCAMENTO_SERVICO "
               + "VALUES (NULL, "
               + paramOrcamento + ", "
               + paramServico + ", "
               + paramValor + ", "
               + paramDescricao + ", "
               + paramDesconto + ", "
               + paramAcrescimo + ", "
               + paramTotal + ") "
               + "RETURNING ORCAMENTO_SERVICO_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramOrcamento, orcamentoServico.ORCAMENTO_SERVICO_ORCAMENTO);
            comando.Parameters.AddWithValue(paramServico, orcamentoServico.ORCAMENTO_SERVICO_SERVICO);
            comando.Parameters.AddWithValue(paramValor, orcamentoServico.ORCAMENTO_SERVICO_VALOR);
            comando.Parameters.AddWithValue(paramDescricao, orcamentoServico.ORCAMENTO_SERVICO_DESCRICAO);
            comando.Parameters.AddWithValue(paramDesconto, orcamentoServico.ORCAMENTO_SERVICO_DESCONTO);
            comando.Parameters.AddWithValue(paramAcrescimo, orcamentoServico.ORCAMENTO_SERVICO_ACRESCIMO);
            comando.Parameters.AddWithValue(paramTotal, orcamentoServico.ORCAMENTO_SERVICO_TOTAL);

            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.ORCAMENTO_SERVICORow orcamentoServico) {
            FbCommand comando = null;
            string sql =
                "UPDATE ORCAMENTO_SERVICO "
                + "SET "
                + "ORCAMENTO_SERVICO_ORCAMENTO = " + paramOrcamento + ", "
                + "ORCAMENTO_SERVICO_SERVICO = " + paramServico + ", "
                + "ORCAMENTO_SERVICO_VALOR = " + paramValor + ", "
                + "ORCAMENTO_SERVICO_DESCRICAO = " + paramDescricao + ", "
                + "ORCAMENTO_SERVICO_DESCONTO = " + paramDesconto + ", "
                + "ORCAMENTO_SERVICO_ACRESCIMO = " + paramAcrescimo + ", "
                + "ORCAMENTO_SERVICO_TOTAL = " + paramTotal + " "
                + "WHERE ORCAMENTO_SERVICO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, orcamentoServico.ORCAMENTO_SERVICO_CODIGO);
            comando.Parameters.AddWithValue(paramOrcamento, orcamentoServico.ORCAMENTO_SERVICO_ORCAMENTO);
            comando.Parameters.AddWithValue(paramServico, orcamentoServico.ORCAMENTO_SERVICO_SERVICO);
            comando.Parameters.AddWithValue(paramValor, orcamentoServico.ORCAMENTO_SERVICO_VALOR);
            comando.Parameters.AddWithValue(paramDescricao, orcamentoServico.ORCAMENTO_SERVICO_DESCRICAO);
            comando.Parameters.AddWithValue(paramDesconto, orcamentoServico.ORCAMENTO_SERVICO_DESCONTO);
            comando.Parameters.AddWithValue(paramAcrescimo, orcamentoServico.ORCAMENTO_SERVICO_ACRESCIMO);
            comando.Parameters.AddWithValue(paramTotal, orcamentoServico.ORCAMENTO_SERVICO_TOTAL);

            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM ORCAMENTO_SERVICO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.ORCAMENTO_SERVICORow orcamentoServico) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM ORCAMENTO_SERVICO "
                + " WHERE ORCAMENTO_SERVICO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, orcamentoServico.ORCAMENTO_SERVICO_CODIGO);

            return (int)comando.ExecuteScalar();
        }

    }
}
