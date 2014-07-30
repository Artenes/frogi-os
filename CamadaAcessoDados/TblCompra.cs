using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblCompra {

        private string paramCodigo = "@CODIGO";
        private string paramNotaFiscal = "@NOTAFISCAL";
        private string paramFuncionario = "@FUNCIONARIO";
        private string paramFornecedor = "@FORNECEDOR";
        private string paramDesconto = "@DESCONTO";
        private string paramAcrescimo = "@ACRESCIMO";
        private string paramTotal = "@TOTAL";
        private string paramData = "@DATA";
        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.COMPRARow compra) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO COMPRA "
               + "VALUES (NULL, "
               + paramNotaFiscal + ", "
               + paramFuncionario + ", "
               + paramFornecedor + ", "
               + paramDesconto + ", "
               + paramAcrescimo + ", "
               + paramTotal + ", "
               + paramData + ") "
               + "RETURNING COMPRA_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramNotaFiscal, compra.COMPRA_NOTA_FISCAL);
            comando.Parameters.AddWithValue(paramFuncionario, compra.COMPRA_FUNCIONARIO);
            comando.Parameters.AddWithValue(paramFornecedor, compra.COMPRA_FORNECEDOR);
            comando.Parameters.AddWithValue(paramDesconto, compra.COMPRA_DESCONTO);
            comando.Parameters.AddWithValue(paramAcrescimo, compra.COMPRA_NOTA_FISCAL);
            comando.Parameters.AddWithValue(paramTotal, compra.COMPRA_TOTAL);
            comando.Parameters.AddWithValue(paramData, compra.COMPRA_DATA);
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.COMPRARow compra) {
            FbCommand comando = null;
            string sql =
                "UPDATE COMPRA "
                + "SET COMPRA_NOTA_FISCAL = " + paramNotaFiscal + ", "
                + "SET COMPRA_FUNCIONARIO = " + paramFuncionario + ", "
                + "SET COMPRA_FORNECEDOR = " + paramFornecedor + ", "
                + "SET COMPRA_DESCONTO = " + paramDesconto + ", "
                + "SET COMPRA_ACRESCIMO = " + paramAcrescimo + ", "
                + "SET COMPRA_TOTAL = " + paramTotal + ", "
                + "SET COMPRA_DATA = " + paramData + " "
                + "WHERE COMPRA_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, compra.COMPRA_CODIGO);
            comando.Parameters.AddWithValue(paramNotaFiscal, compra.COMPRA_NOTA_FISCAL);
            comando.Parameters.AddWithValue(paramFuncionario, compra.COMPRA_FUNCIONARIO);
            comando.Parameters.AddWithValue(paramFornecedor, compra.COMPRA_FORNECEDOR);
            comando.Parameters.AddWithValue(paramDesconto, compra.COMPRA_DESCONTO);
            comando.Parameters.AddWithValue(paramAcrescimo, compra.COMPRA_NOTA_FISCAL);
            comando.Parameters.AddWithValue(paramTotal, compra.COMPRA_TOTAL);
            comando.Parameters.AddWithValue(paramData, compra.COMPRA_DATA);
            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM COMPRA "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.COMPRARow compra) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM COMPRA "
                + " WHERE COMPRA_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, compra.COMPRA_CODIGO);

            return (int)comando.ExecuteScalar();
        }

    }
}
