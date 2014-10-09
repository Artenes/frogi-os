using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblFuncionario {

        private string paramCodigo = "@CODIGO";
        private string paramNome = "@NOME";
        private string paramCpf = "@CPF";
        private string paramRg = "@RG";
        private string paramNascimento = "@NASCIMENTO";
        private string paramPis = "@PIS";
        private string paramTelefone = "@TELEFONE";
        private string paramEmail = "@EMAIL";
        private string paramEndereco = "@ENDERECO";
        private string paramBairro = "@BAIRRO";
        private string paramCep = "@CEP";
        private string paramFuncao = "@FUNCAO";
        private string paramSetor = "@SETOR";
        private string paramSalario = "@SALARIO";
        private string paramAdmissao = "@ADMISSAO";
        private string paramSenha = "@SENHA";
        //private string paramCategoria = "@CATEGORIA";
        private string paramDataCadastro = "@DATACADASTRO";
        
        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.FUNCIONARIORow funcionario) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO FUNCIONARIO "
               + "VALUES (NULL, "
               + paramNome + ", "
               + paramCpf + ", "
               + paramRg + ", "
               + paramNascimento + ", "
               + paramPis + ", "
               + paramTelefone + ", "
               + paramEmail + ", "
               + paramEndereco + ", "
               + paramBairro + ", "
               + paramCep + ", "
               + paramFuncao + ", "
               + paramSetor + ", "
               + paramSalario + ", "
               + paramAdmissao + ", "
               + paramSenha + ", "
               //+ paramCategoria + ", "
               + paramDataCadastro + ") "
               + "RETURNING FUNCIONARIO_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramNome, funcionario.FUNCIONARIO_NOME);
            comando.Parameters.AddWithValue(paramCpf, funcionario.FUNCIONARIO_CPF);
            comando.Parameters.AddWithValue(paramRg, funcionario.FUNCIONARIO_RG);
            comando.Parameters.AddWithValue(paramNascimento, funcionario.FUNCIONARIO_NASCIMENTO);
            comando.Parameters.AddWithValue(paramPis, funcionario.FUNCIONARIO_PIS);
            comando.Parameters.AddWithValue(paramTelefone, funcionario.FUNCIONARIO_TELEFONE);
            comando.Parameters.AddWithValue(paramEmail, funcionario.FUNCIONARIO_EMAIL);
            comando.Parameters.AddWithValue(paramEndereco, funcionario.FUNCIONARIO_ENDERECO);
            comando.Parameters.AddWithValue(paramBairro, funcionario.FUNCIONARIO_BAIRRO);
            comando.Parameters.AddWithValue(paramCep, funcionario.FUNCIONARIO_CEP);
            comando.Parameters.AddWithValue(paramFuncao, funcionario.FUNCIONARIO_FUNCAO);
            comando.Parameters.AddWithValue(paramSetor, funcionario.FUNCIONARIO_SETOR);
            comando.Parameters.AddWithValue(paramSalario, funcionario.FUNCIONARIO_SALARIO);
            comando.Parameters.AddWithValue(paramAdmissao, funcionario.FUNCIONARIO_ADMISSAO);
            comando.Parameters.AddWithValue(paramSenha, funcionario.FUNCIONARIO_SENHA);
            //comando.Parameters.AddWithValue(paramCategoria, funcionario.FUNCIONARIO_CATEGORIA);
            comando.Parameters.AddWithValue(paramDataCadastro, funcionario.FUNCIONARIO_DATA_CADASTRO);
            
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.FUNCIONARIORow funcionario) {
            FbCommand comando = null;
            string sql =
                "UPDATE FUNCIONARIO "
                + "SET "
                + "FUNCIONARIO_NOME = " + paramNome + ", "
                + "FUNCIONARIO_CPF = " + paramCpf + ", "
                + "FUNCIONARIO_RG = " + paramRg + ", "
                + "FUNCIONARIO_NASCIMENTO = " + paramNascimento + ", "
                + "FUNCIONARIO_PIS = " + paramPis + ", "
                + "FUNCIONARIO_TELEFONE = " + paramTelefone + ", "
                + "FUNCIONARIO_EMAIL = " + paramEmail + ", "
                + "FUNCIONARIO_ENDERECO = " + paramEndereco + ", "
                + "FUNCIONARIO_BAIRRO = " + paramBairro + ", "
                + "FUNCIONARIO_CEP = " + paramCep + ", "
                + "FUNCIONARIO_FUNCAO = " + paramFuncao + ", "
                + "FUNCIONARIO_SETOR = " + paramSetor + ", "
                + "FUNCIONARIO_SALARIO = " + paramSalario + ", "
                + "FUNCIONARIO_ADMISSAO = " + paramAdmissao + ", "
                + "FUNCIONARIO_SENHA = " + paramSenha + " "
                + "WHERE FUNCIONARIO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, funcionario.FUNCIONARIO_CODIGO);
            comando.Parameters.AddWithValue(paramNome, funcionario.FUNCIONARIO_NOME);
            comando.Parameters.AddWithValue(paramCpf, funcionario.FUNCIONARIO_CPF);
            comando.Parameters.AddWithValue(paramRg, funcionario.FUNCIONARIO_RG);
            comando.Parameters.AddWithValue(paramNascimento, funcionario.FUNCIONARIO_NASCIMENTO);
            comando.Parameters.AddWithValue(paramPis, funcionario.FUNCIONARIO_PIS);
            comando.Parameters.AddWithValue(paramTelefone, funcionario.FUNCIONARIO_TELEFONE);
            comando.Parameters.AddWithValue(paramEmail, funcionario.FUNCIONARIO_EMAIL);
            comando.Parameters.AddWithValue(paramEndereco, funcionario.FUNCIONARIO_ENDERECO);
            comando.Parameters.AddWithValue(paramBairro, funcionario.FUNCIONARIO_BAIRRO);
            comando.Parameters.AddWithValue(paramCep, funcionario.FUNCIONARIO_CEP);
            comando.Parameters.AddWithValue(paramFuncao, funcionario.FUNCIONARIO_FUNCAO);
            comando.Parameters.AddWithValue(paramSetor, funcionario.FUNCIONARIO_SETOR);
            comando.Parameters.AddWithValue(paramSalario, funcionario.FUNCIONARIO_SALARIO);
            comando.Parameters.AddWithValue(paramAdmissao, funcionario.FUNCIONARIO_ADMISSAO);
            comando.Parameters.AddWithValue(paramSenha, funcionario.FUNCIONARIO_SENHA);
            
            return comando.ExecuteNonQuery();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM FUNCIONARIO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.FUNCIONARIORow funcionario) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM FUNCIONARIO "
                + " WHERE FUNCIONARIO_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, funcionario.FUNCIONARIO_CODIGO);

            return comando.ExecuteNonQuery();
        }

    }
}
