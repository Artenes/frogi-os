using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblCliente {

        private string paramCodigo = "@CODIGO";
        private string paramTipo = "@TIPO";
        private string paramTelefone = "@TELEFONE";
        private string paramCelular = "@CELULAR";
        private string paramEmail = "@EMAIL";
        private string paramEndereco = "@ENDERECO";
        private string paramBairro = "@BAIRRO";
        private string paramPerimetro = "@PERIMETRO";
        private string paramCidade = "@CIDADE";
        private string paramUf = "@UF";
        private string paramCep = "@CEP";
        private string paramDataCadastro = "@DATACADASTRO";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.CLIENTERow cliente) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO CLIENTE "
               + "VALUES (NULL, "
               + paramTipo + ", "
               + paramTelefone + ", "
               + paramCelular + ", "
               + paramEmail + ", "
               + paramEndereco + ", "
               + paramBairro + ", "
               + paramPerimetro + ", "
               + paramCidade + ", "
               + paramUf + ", "
               + paramCep + ", "
               + paramDataCadastro + ") "
               + "RETURNING CLIENTE_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramTipo, cliente.CLIENTE_TIPO);
            comando.Parameters.AddWithValue(paramTelefone, cliente.CLIENTE_TELEFONE);
            comando.Parameters.AddWithValue(paramCelular, cliente.CLIENTE_CELULAR);
            comando.Parameters.AddWithValue(paramEmail, cliente.CLIENTE_EMAIL);
            comando.Parameters.AddWithValue(paramEndereco, cliente.CLIENTE_ENDERECO);
            comando.Parameters.AddWithValue(paramBairro, cliente.CLIENTE_BAIRRO);
            comando.Parameters.AddWithValue(paramPerimetro, cliente.CLIENTE_PERIMETRO);
            comando.Parameters.AddWithValue(paramCidade, cliente.CLIENTE_CIDADE);
            comando.Parameters.AddWithValue(paramUf, cliente.CLIENTE_UF);
            comando.Parameters.AddWithValue(paramCep, cliente.CLIENTE_CEP);
            comando.Parameters.AddWithValue(paramDataCadastro, cliente.CLIENTE_DATA_CADASTRO);

            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.CLIENTERow cliente) {
            FbCommand comando = null;
            string sql =
                "UPDATE CLIENTE "
                + "SET "
                + "CLIENTE_TIPO = " + paramTipo + ", "
                + "CLIENTE_TELEFONE = " + paramTelefone + ", "
                + "CLIENTE_CELULAR = " + paramCelular + ", "
                + "CLIENTE_EMAIL = " + paramEmail + ", "
                + "CLIENTE_ENDERECO = " + paramEndereco + ", "
                + "CLIENTE_BAIRRO = " + paramBairro + ", "
                + "CLIENTE_PERIMETRO = " + paramPerimetro + ", "
                + "CLIENTE_CIDADE = " + paramCidade + ", "
                + "CLIENTE_UF = " + paramUf + ", "
                + "CLIENTE_CEP = " + paramCep + ", "
                + "CLIENTE_DATA_CADASTRO = " + paramDataCadastro + " "
                + "WHERE CLIENTE_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, cliente.CLIENTE_CODIGO);
            comando.Parameters.AddWithValue(paramTipo, cliente.CLIENTE_TIPO);
            comando.Parameters.AddWithValue(paramTelefone, cliente.CLIENTE_TELEFONE);
            comando.Parameters.AddWithValue(paramCelular, cliente.CLIENTE_CELULAR);
            comando.Parameters.AddWithValue(paramEmail, cliente.CLIENTE_EMAIL);
            comando.Parameters.AddWithValue(paramEndereco, cliente.CLIENTE_ENDERECO);
            comando.Parameters.AddWithValue(paramBairro, cliente.CLIENTE_BAIRRO);
            comando.Parameters.AddWithValue(paramPerimetro, cliente.CLIENTE_PERIMETRO);
            comando.Parameters.AddWithValue(paramCidade, cliente.CLIENTE_CIDADE);
            comando.Parameters.AddWithValue(paramUf, cliente.CLIENTE_UF);
            comando.Parameters.AddWithValue(paramCep, cliente.CLIENTE_CEP);
            comando.Parameters.AddWithValue(paramDataCadastro, cliente.CLIENTE_DATA_CADASTRO);

            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM CLIENTE "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.CLIENTERow cliente) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM CLIENTE "
                + " WHERE CLIENTE_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, cliente.CLIENTE_CODIGO);

            return (int)comando.ExecuteScalar();
        }
        
    }
}
