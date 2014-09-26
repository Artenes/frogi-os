using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblFornecedorFisico {
        private string paramFornecedor = "@FORNECEDOR";
        private string paramNome = "@NOME";
        private string paramCpf = "@CPF";
        private string paramRg = "@RG";
        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.FORNECEDOR_FISICORow fornecedorFisico) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO FORNECEDOR_FISICO "
               + "VALUES ("
               + paramFornecedor + ", "
               + paramNome + ", "
               + paramCpf + ", "
               + paramRg + ") "
               + "RETURNING FORNECEDOR_FISICO_FORNECEDOR;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramFornecedor, fornecedorFisico.FORNECEDOR_FISICO_FORNECEDOR);
            comando.Parameters.AddWithValue(paramNome, fornecedorFisico.FORNECEDOR_FISICO_NOME);
            comando.Parameters.AddWithValue(paramCpf, fornecedorFisico.FORNECEDOR_FISICO_CPF);
            comando.Parameters.AddWithValue(paramRg, fornecedorFisico.FORNECEDOR_FISICO_RG);
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.FORNECEDOR_FISICORow fornecedorFisico) {
            FbCommand comando = null;
            string sql =
                "UPDATE FORNECEDOR_FISICO "
                + "SET "
                + "FORNECEDOR_FISICO_NOME = " + paramNome + ", "
                + "FORNECEDOR_FISICO_CPF = " + paramCpf + ", "
                + "FORNECEDOR_FISICO_RG = " + paramRg + " "
                + "WHERE FORNECEDOR_FISICO_FORNECEDOR = " + paramFornecedor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramFornecedor, fornecedorFisico.FORNECEDOR_FISICO_FORNECEDOR);
            comando.Parameters.AddWithValue(paramNome, fornecedorFisico.FORNECEDOR_FISICO_NOME);
            comando.Parameters.AddWithValue(paramCpf, fornecedorFisico.FORNECEDOR_FISICO_CPF);
            comando.Parameters.AddWithValue(paramRg, fornecedorFisico.FORNECEDOR_FISICO_RG);
            return comando.ExecuteNonQuery();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM FORNECEDOR_FISICO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.FORNECEDOR_FISICORow fornecedorFisico) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM FORNECEDOR_FISICO "
                + " WHERE FORNECEDOR_FISICO_FORNECEDOR = " + paramFornecedor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramFornecedor, fornecedorFisico.FORNECEDOR_FISICO_FORNECEDOR);

            return comando.ExecuteNonQuery();
        }
    }
}
