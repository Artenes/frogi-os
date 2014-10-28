using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblOrcamento {

        private string paramCodigo = "@CODIGO";
        private string paramCliente = "@CLIENTE";
        private string paramFuncionario = "@FUNCIONARIO";
        private string paramTotalItem = "@TOTALITEM";
        private string paramTotalServico = "@TOTALSERVICO";
        private string paramDesconto = "@DESCONTO";
        private string paramAcrescimo = "@ACRESCIMO";
        private string paramObservacao = "@OBSERVACAO";
        private string paramTotal = "@TOTAL";
        private string paramData = "@DATA";
        private string paramProduto = "@PRODUTO";
        private string paramDiagnostico = "@DIAGNOSTICO";
        private string paramAvulsos = "@AVULSOS";
        private string paramDefeito = "@DEFEITO";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.ORCAMENTORow orcamento) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO ORCAMENTO "
               + "VALUES (NULL, " 
               + paramCliente + ", "
               + paramFuncionario + ", "
               + paramTotalItem + ", "
               + paramTotalServico + ", "
               + paramDesconto + ", "
               + paramAcrescimo + ", "
               + paramObservacao + ", "
               + paramTotal + ", "
               + paramData + ", "
               + paramProduto + ", "
               + paramDiagnostico + ", "
               + paramAvulsos + ", "
               + paramDefeito + ") "
               + "RETURNING ORCAMENTO_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCliente, orcamento.ORCAMENTO_CLIENTE);
            comando.Parameters.AddWithValue(paramFuncionario, orcamento.ORCAMENTO_FUNCIONARIO);
            comando.Parameters.AddWithValue(paramTotalItem, orcamento.ORCAMENTO_TOTAL_ITEM);
            comando.Parameters.AddWithValue(paramTotalServico, orcamento.ORCAMENTO_TOTAL_SERVICO);
            comando.Parameters.AddWithValue(paramDesconto, orcamento.ORCAMENTO_DESCONTO);
            comando.Parameters.AddWithValue(paramAcrescimo, orcamento.ORCAMENTO_ACRESCIMO);
            comando.Parameters.AddWithValue(paramObservacao, orcamento.ORCAMENTO_OBSERVACAO);
            comando.Parameters.AddWithValue(paramTotal, orcamento.ORCAMENTO_TOTAL);
            comando.Parameters.AddWithValue(paramData, orcamento.ORCAMENTO_DATA);
            comando.Parameters.AddWithValue(paramProduto, orcamento.ORCAMENTO_PRODUTO);
            comando.Parameters.AddWithValue(paramDiagnostico, orcamento.ORCAMENTO_DIAGNOSTICO);
            comando.Parameters.AddWithValue(paramAvulsos, orcamento.ORCAMENTO_AVULSOS);
            comando.Parameters.AddWithValue(paramDefeito, orcamento.ORCAMENTO_DEFEITO);

            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.ORCAMENTORow orcamento) {
            FbCommand comando = null;
            string sql =
                "UPDATE ORCAMENTO "
                + "SET "
                + "ORCAMENTO_CLIENTE = " + paramCliente + ", "
                + "ORCAMENTO_FUNCIONARIO = " + paramFuncionario + ", "
                + "ORCAMENTO_TOTAL_ITEM = " + paramTotalItem + ", "
                + "ORCAMENTO_TOTAL_SERVICO = " + paramTotalServico + ", "
                + "ORCAMENTO_DESCONTO = " + paramDesconto + ", "
                + "ORCAMENTO_ACRESCIMO = " + paramAcrescimo + ", "
                + "ORCAMENTO_OBSERVACAO = " + paramObservacao + ", "
                + "ORCAMENTO_TOTAL = " + paramTotal + ", "
                + "ORCAMENTO_DATA = " + paramData + ", "
                + "ORCAMENTO_PRODUTO = " + paramProduto + ", "
                + "ORCAMENTO_DIAGNOSTICO = " + paramDiagnostico + ", "
                + "ORCAMENTO_AVULSOS = " + paramAvulsos + ", "
                + "ORCAMENTO_DEFEITO = " + paramDefeito + " "
                + "WHERE ORCAMENTO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, orcamento.ORCAMENTO_CODIGO);
            comando.Parameters.AddWithValue(paramCliente, orcamento.ORCAMENTO_CLIENTE);
            comando.Parameters.AddWithValue(paramFuncionario, orcamento.ORCAMENTO_FUNCIONARIO);
            comando.Parameters.AddWithValue(paramTotalItem, orcamento.ORCAMENTO_TOTAL_ITEM);
            comando.Parameters.AddWithValue(paramTotalServico, orcamento.ORCAMENTO_TOTAL_SERVICO);
            comando.Parameters.AddWithValue(paramDesconto, orcamento.ORCAMENTO_DESCONTO);
            comando.Parameters.AddWithValue(paramAcrescimo, orcamento.ORCAMENTO_ACRESCIMO);
            comando.Parameters.AddWithValue(paramObservacao, orcamento.ORCAMENTO_OBSERVACAO);
            comando.Parameters.AddWithValue(paramTotal, orcamento.ORCAMENTO_TOTAL);
            comando.Parameters.AddWithValue(paramData, orcamento.ORCAMENTO_DATA);
            comando.Parameters.AddWithValue(paramProduto, orcamento.ORCAMENTO_PRODUTO);
            comando.Parameters.AddWithValue(paramDiagnostico, orcamento.ORCAMENTO_DIAGNOSTICO);
            comando.Parameters.AddWithValue(paramAvulsos, orcamento.ORCAMENTO_AVULSOS);
            comando.Parameters.AddWithValue(paramDefeito, orcamento.ORCAMENTO_DEFEITO);

            return comando.ExecuteNonQuery();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM ORCAMENTO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.ORCAMENTORow orcamento) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM ORCAMENTO "
                + " WHERE ORCAMENTO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, orcamento.ORCAMENTO_CODIGO);

            return comando.ExecuteNonQuery();
        }

    }
}
