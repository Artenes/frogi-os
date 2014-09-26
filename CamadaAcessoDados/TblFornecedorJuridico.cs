using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
namespace FROGI_OS.CamadaAcessoDados {
    class TblFornecedorJuridico {

        private string paramFornecedor = "@FORNECEDOR";
        private string paramRazSoc = "@RAZSOC";
        private string paramCnpj = "@CNPJ";
        private string paramIe = "@IE";
        private string paramFantasia = "@FANTASIA";
        private string paramRepre = "@REPRE";
        private string paramContato = "@CONTATO";
        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.FORNECEDOR_JURIDICORow fornecedorJuridico) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO FORNECEDOR_JURIDICO "
               + "VALUES ("
               + paramFornecedor + ", "
               + paramRazSoc + ", "
               + paramCnpj + ", "
               + paramIe + ", "
               + paramFantasia + ", "
               + paramRepre + ", "
               + paramContato + ") "
               + "RETURNING FORNECEDOR_JURIDICO_FORNECEDOR;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramFornecedor, fornecedorJuridico.FORNECEDOR_JURIDICO_FORNECEDOR);
            comando.Parameters.AddWithValue(paramRazSoc, fornecedorJuridico.FORNECEDOR_JURIDICO_RAZ_SOC);
            comando.Parameters.AddWithValue(paramCnpj, fornecedorJuridico.FORNECEDOR_JURIDICO_CNPJ);
            comando.Parameters.AddWithValue(paramIe, fornecedorJuridico.FORNECEDOR_JURIDICO_IE);
            comando.Parameters.AddWithValue(paramFantasia, fornecedorJuridico.FORNECEDOR_JURIDICO_FANTASIA);
            comando.Parameters.AddWithValue(paramRepre, fornecedorJuridico.FORNECEDOR_JURIDICO_REPRE);
            comando.Parameters.AddWithValue(paramContato, fornecedorJuridico.FORNECEDOR_JURIDICO_CONTATO);
            
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.FORNECEDOR_JURIDICORow fornecedorJuridico) {
            FbCommand comando = null;
            string sql =
                "UPDATE FORNECEDOR_JURIDICO "
                + "SET "
                + "FORNECEDOR_JURIDICO_RAZ_SOC = " + paramRazSoc + ", "
                + "FORNECEDOR_JURIDICO_CNPJ = " + paramCnpj + ", "
                + "FORNECEDOR_JURIDICO_IE = " + paramIe + ", "
                + "FORNECEDOR_JURIDICO_FANTASIA = " + paramFantasia + ", "
                + "FORNECEDOR_JURIDICO_REPRE = " + paramRepre + ", "
                + "FORNECEDOR_JURIDICO_CONTATO = " + paramContato + " "
                + "WHERE FORNECEDOR_JURIDICO_FORNECEDOR = " + paramFornecedor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramFornecedor, fornecedorJuridico.FORNECEDOR_JURIDICO_FORNECEDOR);
            comando.Parameters.AddWithValue(paramRazSoc, fornecedorJuridico.FORNECEDOR_JURIDICO_RAZ_SOC);
            comando.Parameters.AddWithValue(paramCnpj, fornecedorJuridico.FORNECEDOR_JURIDICO_CNPJ);
            comando.Parameters.AddWithValue(paramIe, fornecedorJuridico.FORNECEDOR_JURIDICO_IE);
            comando.Parameters.AddWithValue(paramFantasia, fornecedorJuridico.FORNECEDOR_JURIDICO_FANTASIA);
            comando.Parameters.AddWithValue(paramRepre, fornecedorJuridico.FORNECEDOR_JURIDICO_REPRE);
            comando.Parameters.AddWithValue(paramContato, fornecedorJuridico.FORNECEDOR_JURIDICO_CONTATO);
            return comando.ExecuteNonQuery();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM FORNECEDOR_JURIDICO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.FORNECEDOR_JURIDICORow fornecedorJuridico) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM FORNECEDOR_JURIDICO "
                + " WHERE FORNECEDOR_JURIDICO_FORNECEDOR = " + paramFornecedor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramFornecedor, fornecedorJuridico.FORNECEDOR_JURIDICO_FORNECEDOR);

            return comando.ExecuteNonQuery();
        }

    }
}
