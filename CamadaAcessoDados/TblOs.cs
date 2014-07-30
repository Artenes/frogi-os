using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblOs {

        private string paramCodigo = "@CODIGO";
        private string paramCliente = "@CLIENTE";
        private string paramFuncionario = "@FUNCIONARIO";
        private string paramTotalItem = "@TOTALITEM";
        private string paramTotalServico = "@TOTALSERVICO";
        private string paramDesconto = "@DESCONTO";
        private string paramAcrescimo = "@ACRESCIMO";
        private string paramFormaPagamento = "@FORMAPAGAMENTO";
        private string paramTotal = "@TOTAL";
        private string paramData = "@DATA";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.OSRow os) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO OS "
               + "VALUES (NULL, "
               + paramCliente + ", "
               + paramFuncionario + ", "
               + paramTotalItem + ", "
               + paramTotalServico + ", "
               + paramDesconto + ", "
               + paramAcrescimo + ", "
               + paramFormaPagamento + ", "
               + paramTotal + ", "
               + paramData + ") "
               + "RETURNING OS_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCliente, os.OS_CLIENTE);
            comando.Parameters.AddWithValue(paramFuncionario, os.OS_FUNCIONARIO);
            comando.Parameters.AddWithValue(paramTotalItem, os.OS_TOTAL_ITEM);
            comando.Parameters.AddWithValue(paramTotalServico, os.OS_TOTAL_SERVICO);
            comando.Parameters.AddWithValue(paramDesconto, os.OS_DESCONTO);
            comando.Parameters.AddWithValue(paramAcrescimo, os.OS_ACRESCIMO);
            comando.Parameters.AddWithValue(paramFormaPagamento, os.OS_FORMA_PAGAMENTO);
            comando.Parameters.AddWithValue(paramTotal, os.OS_TOTAL);
            comando.Parameters.AddWithValue(paramData, os.OS_DATA);
            
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.OSRow os) {
            FbCommand comando = null;
            string sql =
                "UPDATE OS "
                + "SET "
                + "OS_CLIENTE = " + paramCliente + ", "
                + "OS_FUNCIONARIO = " + paramFuncionario + ", "
                + "OS_TOTAL_ITEM = " + paramTotalItem + ", "
                + "OS_TOTAL_SERVICO = " + paramTotalServico + ", "
                + "OS_DESCONTO = " + paramDesconto + ", "
                + "OS_ACRESCIMO = " + paramAcrescimo + ", "
                + "OS_FORMA_PAGAMENTO = " + paramFormaPagamento + ", "
                + "OS_TOTAL = " + paramTotal + ", "
                + "OS_DATA = " + paramData + " "
                + "WHERE OS_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, os.OS_CODIGO);
            comando.Parameters.AddWithValue(paramCliente, os.OS_CLIENTE);
            comando.Parameters.AddWithValue(paramFuncionario, os.OS_FUNCIONARIO);
            comando.Parameters.AddWithValue(paramTotalItem, os.OS_TOTAL_ITEM);
            comando.Parameters.AddWithValue(paramTotalServico, os.OS_TOTAL_SERVICO);
            comando.Parameters.AddWithValue(paramDesconto, os.OS_DESCONTO);
            comando.Parameters.AddWithValue(paramAcrescimo, os.OS_ACRESCIMO);
            comando.Parameters.AddWithValue(paramFormaPagamento, os.OS_FORMA_PAGAMENTO);
            comando.Parameters.AddWithValue(paramTotal, os.OS_TOTAL);
            comando.Parameters.AddWithValue(paramData, os.OS_DATA);
            
            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM OS "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.OSRow os) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM OS "
                + " WHERE OS_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, os.OS_CODIGO);

            return (int)comando.ExecuteScalar();
        }

    }
}
