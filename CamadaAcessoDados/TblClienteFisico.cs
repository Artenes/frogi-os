using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS {
    class TblClienteFisico {

        private string paramCliente = "@CLIENTE";
        private string paramNome = "@NOME";
        private string paramCpf = "@CPF";
        private string paramRg = "@RG";
        private string paramNascimento = "@NASCIMENTO";
        private string paramSexo = "@SEXO";
        private string paramEstadoCivil = "@ESTADOCIVIL";
        private string paramProfissao = "@PROFISSAO";
        private string paramSalario = "@SALARIO";
        private string paramLimite = "@LIMITE";
        private string paramLimiteAtual = "@LIMITEATUAL";
        private string paramMae = "@MAE";
        private string paramPai = "@PAI";
        private string paramObservacao = "@OBSERVACAO";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.CLIENTE_FISICORow clienteFisico) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO CLIENTE_FISICO "
               + "VALUES ("
               + paramCliente + ", "
               + paramNome + ", "
               + paramCpf + ", "
               + paramRg + ", "
               + paramNascimento + ", "
               + paramSexo + ", "
               + paramEstadoCivil + ", "
               + paramProfissao + ", "
               + paramSalario + ", "
               + paramLimite + ", "
               + paramLimiteAtual + ", "
               + paramMae + ", "
               + paramPai + ", "
               + paramObservacao + ") "
               + "RETURNING CLIENTE_FISICO_CLIENTE;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCliente, clienteFisico.CLIENTE_FISICO_CLIENTE);
            comando.Parameters.AddWithValue(paramNome, clienteFisico.CLIENTE_FISICO_NOME);
            comando.Parameters.AddWithValue(paramCpf, clienteFisico.CLIENTE_FISICO_CPF);
            comando.Parameters.AddWithValue(paramRg, clienteFisico.CLIENTE_FISICO_RG);
            comando.Parameters.AddWithValue(paramNascimento, clienteFisico.CLIENTE_FISICO_NASCIMENTO);
            comando.Parameters.AddWithValue(paramSexo, clienteFisico.CLIENTE_FISICO_SEXO);
            comando.Parameters.AddWithValue(paramEstadoCivil, clienteFisico.CLIENTE_FISICO_ESTADO_CIVIL);
            comando.Parameters.AddWithValue(paramProfissao, clienteFisico.CLIENTE_FISICO_PROFISSAO);
            comando.Parameters.AddWithValue(paramSalario, clienteFisico.CLIENTE_FISICO_SALARIO);
            comando.Parameters.AddWithValue(paramLimite, clienteFisico.CLIENTE_FISICO_LIMITE);
            comando.Parameters.AddWithValue(paramLimiteAtual, clienteFisico.CLIENTE_FISICO_LIMITE_ATUAL);
            comando.Parameters.AddWithValue(paramMae, clienteFisico.CLIENTE_FISICO_MAE);
            comando.Parameters.AddWithValue(paramPai, clienteFisico.CLIENTE_FISICO_PAI);
            comando.Parameters.AddWithValue(paramObservacao, clienteFisico.CLIENTE_FISICO_OBSERVACAO);

            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.CLIENTE_FISICORow clienteFisico) {
            FbCommand comando = null;
            string sql =
                "UPDATE CLIENTE_FISICO "
                + "SET "
                + "CLIENTE_FISICO_NOME = " + paramNome + ", "
                + "CLIENTE_FISICO_CPF = " + paramCpf + ", "
                + "CLIENTE_FISICO_RG = " + paramRg + ", "
                + "CLIENTE_FISICO_NASCIMENTO = " + paramNascimento + ", "
                + "CLIENTE_FISICO_SEXO = " + paramSexo + ", "
                + "CLIENTE_FISICO_ESTADO_CIVIL = " + paramEstadoCivil + ", "
                + "CLIENTE_FISICO_PROFISSAO = " + paramProfissao + ", "
                + "CLIENTE_FISICO_SALARIO = " + paramSalario + ", "
                + "CLIENTE_FISICO_LIMITE = " + paramLimite + ", "
                + "CLIENTE_FISICO_LIMITE_ATUAL = " + paramLimiteAtual + ", "
                + "CLIENTE_FISICO_MAE = " + paramMae + ", "
                + "CLIENTE_FISICO_PAI = " + paramPai + ", "
                + "CLIENTE_FISICO_OBSERVACAO = " + paramObservacao + " "
                + "WHERE CLIENTE_FISICO_CLIENTE = " + paramCliente + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCliente, clienteFisico.CLIENTE_FISICO_CLIENTE);
            comando.Parameters.AddWithValue(paramNome, clienteFisico.CLIENTE_FISICO_NOME);
            comando.Parameters.AddWithValue(paramCpf, clienteFisico.CLIENTE_FISICO_CPF);
            comando.Parameters.AddWithValue(paramRg, clienteFisico.CLIENTE_FISICO_RG);
            comando.Parameters.AddWithValue(paramNascimento, clienteFisico.CLIENTE_FISICO_NASCIMENTO);
            comando.Parameters.AddWithValue(paramSexo, clienteFisico.CLIENTE_FISICO_SEXO);
            comando.Parameters.AddWithValue(paramEstadoCivil, clienteFisico.CLIENTE_FISICO_ESTADO_CIVIL);
            comando.Parameters.AddWithValue(paramProfissao, clienteFisico.CLIENTE_FISICO_PROFISSAO);
            comando.Parameters.AddWithValue(paramSalario, clienteFisico.CLIENTE_FISICO_SALARIO);
            comando.Parameters.AddWithValue(paramLimite, clienteFisico.CLIENTE_FISICO_LIMITE);
            comando.Parameters.AddWithValue(paramLimiteAtual, clienteFisico.CLIENTE_FISICO_LIMITE_ATUAL);
            comando.Parameters.AddWithValue(paramMae, clienteFisico.CLIENTE_FISICO_MAE);
            comando.Parameters.AddWithValue(paramPai, clienteFisico.CLIENTE_FISICO_PAI);
            comando.Parameters.AddWithValue(paramObservacao, clienteFisico.CLIENTE_FISICO_OBSERVACAO);

            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM CLIENTE_FISICO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.CLIENTE_FISICORow clienteFisico) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM CLIENTE_FISICO "
                + " WHERE CLIENTE_FISICO_CLIENTE = " + paramCliente + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCliente, clienteFisico.CLIENTE_FISICO_CLIENTE);

            return (int)comando.ExecuteScalar();
        }

    }
}
