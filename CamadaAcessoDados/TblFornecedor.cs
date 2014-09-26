using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblFornecedor {

        private string paramCodigo = "@CODIGO";
        private string paramEndereco = "@ENDERECO";
        private string paramBairro = "@BAIRRO";
        private string paramPerimetro = "@PERIMETRO";
        private string paramCidade = "@CIDADE";
        private string paramUf = "@UF";
        private string paramCep = "@CEP";
        private string paramTelefone = "@TELEFONE";
        private string paramCelular = "@CELULAR";
        private string paramEmail = "@EMAIL";
        private string paramObservacoes = "@OBSERVACOES";
        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.FORNECEDORRow fornecedor) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO FORNECEDOR "
               + "VALUES (NULL, "
               + paramEndereco + ", "
               + paramBairro + ", "
               + paramPerimetro + ", "
               + paramCidade + ", "
               + paramUf + ", "
               + paramCep + ", "
               + paramTelefone + ", "
               + paramCelular + ", "
               + paramEmail + ", "
               + paramObservacoes + ") "
               + "RETURNING FORNECEDOR_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramEndereco, fornecedor.FORNECEDOR_ENDERECO);
            comando.Parameters.AddWithValue(paramBairro, fornecedor.FORNECEDOR_BAIRRO);
            comando.Parameters.AddWithValue(paramPerimetro, fornecedor.FORNECEDOR_PERIMETRO);
            comando.Parameters.AddWithValue(paramCidade, fornecedor.FORNECEDOR_CIDADE);
            comando.Parameters.AddWithValue(paramUf, fornecedor.FORNECEDOR_UF);
            comando.Parameters.AddWithValue(paramCep, fornecedor.FORNECEDOR_CEP);
            comando.Parameters.AddWithValue(paramTelefone, fornecedor.FORNECEDOR_TELEFONE);
            comando.Parameters.AddWithValue(paramCelular, fornecedor.FORNECEDOR_CELULAR);
            comando.Parameters.AddWithValue(paramEmail, fornecedor.FORNECEDOR_EMAIL);
            comando.Parameters.AddWithValue(paramObservacoes, fornecedor.FORNECEDOR_OBSERVACOES);
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.FORNECEDORRow fornecedor) {
            FbCommand comando = null;
            string sql =
                "UPDATE FORNECEDOR "
                + "SET FORNECEDOR_ENDERECO = " + paramEndereco + ", "
                + "FORNECEDOR_BAIRRO = " + paramBairro + ", "
                + "FORNECEDOR_PERIMETRO = " + paramPerimetro + ", "
                + "FORNECEDOR_CIDADE = " + paramCidade + ", "
                + "FORNECEDOR_UF = " + paramUf + ", "
                + "FORNECEDOR_CEP = " + paramCep + ", "
                + "FORNECEDOR_TELEFONE = " + paramTelefone + ", "
                + "FORNECEDOR_CELULAR = " + paramCelular + ", "
                + "FORNECEDOR_EMAIL = " + paramEmail + ", "
                + "FORNECEDOR_OBSERVACOES = " + paramObservacoes + " "
                + "WHERE FORNECEDOR_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, fornecedor.FORNECEDOR_CODIGO);
            comando.Parameters.AddWithValue(paramEndereco, fornecedor.FORNECEDOR_ENDERECO);
            comando.Parameters.AddWithValue(paramBairro, fornecedor.FORNECEDOR_BAIRRO);
            comando.Parameters.AddWithValue(paramPerimetro, fornecedor.FORNECEDOR_PERIMETRO);
            comando.Parameters.AddWithValue(paramCidade, fornecedor.FORNECEDOR_CIDADE);
            comando.Parameters.AddWithValue(paramUf, fornecedor.FORNECEDOR_UF);
            comando.Parameters.AddWithValue(paramCep, fornecedor.FORNECEDOR_CEP);
            comando.Parameters.AddWithValue(paramTelefone, fornecedor.FORNECEDOR_TELEFONE);
            comando.Parameters.AddWithValue(paramCelular, fornecedor.FORNECEDOR_CELULAR);
            comando.Parameters.AddWithValue(paramEmail, fornecedor.FORNECEDOR_EMAIL);
            comando.Parameters.AddWithValue(paramObservacoes, fornecedor.FORNECEDOR_OBSERVACOES);

            return comando.ExecuteNonQuery();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM FORNECEDOR "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.FORNECEDORRow fornecedor) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM FORNECEDOR "
                + " WHERE FORNECEDOR_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, fornecedor.FORNECEDOR_CODIGO);

            return comando.ExecuteNonQuery();
        }

    }
}
