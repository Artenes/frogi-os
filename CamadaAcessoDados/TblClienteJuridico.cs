using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS {
    class TblClienteJuridico {

        private string paramCliente = "@CLIENTE";
        private string paramRazaoSocial = "@RAZAOSOCIAL";
        private string paramCnpj = "@CNPJ";
        private string paramIe = "@IE";
        private string paramFantasia = "@FANTASIA";
        private string paramAtividade = "@ATIVIDADE";
        private string paramNomeContato = "@NOMECONTATO";

        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.CLIENTE_JURIDICORow clienteJuridico) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO CLIENTE_JURIDICO "
               + "VALUES ("
               + paramCliente + ", "
               + paramRazaoSocial + ", "
               + paramCnpj + ", "
               + paramIe + ", "
               + paramFantasia + ", "
               + paramAtividade + ", "
               + paramNomeContato + ") "
               + "RETURNING CLIENTE_JURIDICO_CLIENTE;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCliente, clienteJuridico.CLIENTE_JURIDICO_CLIENTE);
            comando.Parameters.AddWithValue(paramRazaoSocial, clienteJuridico.CLIENTE_JURIDICO_RAZAO_SOCIAL);
            comando.Parameters.AddWithValue(paramCnpj, clienteJuridico.CLIENTE_JURIDICO_CNPJ);
            comando.Parameters.AddWithValue(paramIe, clienteJuridico.CLIENTE_JURIDICO_IE);
            comando.Parameters.AddWithValue(paramFantasia, clienteJuridico.CLIENTE_JURIDICO_FANTASIA);
            comando.Parameters.AddWithValue(paramAtividade, clienteJuridico.CLIENTE_JURIDICO_ATIVIDADE);
            comando.Parameters.AddWithValue(paramNomeContato, clienteJuridico.CLIENTE_JURIDICO_NOME_CONTATO);
            
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.CLIENTE_JURIDICORow clienteJuridico) {
            FbCommand comando = null;
            string sql =
                "UPDATE CLIENTE_JURIDICO "
                + "SET "
                + "CLIENTE_JURIDICO_RAZAO_SOCIAL = " + paramRazaoSocial + ", "
                + "CLIENTE_JURIDICO_CNPJ = " + paramCnpj + ", "
                + "CLIENTE_JURIDICO_IE = " + paramIe + ", "
                + "CLIENTE_JURIDICO_FANTASIA = " + paramFantasia + ", "
                + "CLIENTE_JURIDICO_ATIVIDADE = " + paramAtividade + ", "
                + "CLIENTE_JURIDICO_NOME_CONTATO = " + paramNomeContato + " "
                + "WHERE CLIENTE_JURIDICO_CLIENTE = " + paramCliente + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCliente, clienteJuridico.CLIENTE_JURIDICO_CLIENTE);
            comando.Parameters.AddWithValue(paramRazaoSocial, clienteJuridico.CLIENTE_JURIDICO_RAZAO_SOCIAL);
            comando.Parameters.AddWithValue(paramCnpj, clienteJuridico.CLIENTE_JURIDICO_CNPJ);
            comando.Parameters.AddWithValue(paramIe, clienteJuridico.CLIENTE_JURIDICO_IE);
            comando.Parameters.AddWithValue(paramFantasia, clienteJuridico.CLIENTE_JURIDICO_FANTASIA);
            comando.Parameters.AddWithValue(paramAtividade, clienteJuridico.CLIENTE_JURIDICO_ATIVIDADE);
            comando.Parameters.AddWithValue(paramNomeContato, clienteJuridico.CLIENTE_JURIDICO_NOME_CONTATO);

            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM CLIENTE_JURIDICO "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.CLIENTE_JURIDICORow clienteJuridico) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM CLIENTE_JURIDICO "
                + " WHERE CLIENTE_JURIDICO_CLIENTE = " + paramCliente + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCliente, clienteJuridico.CLIENTE_JURIDICO_CLIENTE);

            return (int)comando.ExecuteScalar();
        }
    }
}
