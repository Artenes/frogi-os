using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS {
    class Firebird {

        private FbConnection conexao;

        public Firebird() {
            this.conexao = Conexao.getConexao;
        }

        /// <summary>
        /// Insere dados na tabela especificada
        /// </summary>
        /// <param name="tabela">Tabela para inserir os dados, NÃO PODE SER NULL</param>
        /// <param name="colunas">Colunas da tabela a serem usadas no comando INSERT, NÃO PODE SER NULL</param>
        /// <param name="dados">FbCommand com os parâmetros contendo os dados a serem inseridos na tabela, NÃO PODE SER NULL</param>
        /// <returns>inteiro com chave primária do novo registro inserido</returns>
        public int inserir(string tabela, string[] colunas, FbParameterCollection dados, string colunaRetorno) {

            if ((tabela == null || tabela.Length == 0) || (colunas == null || colunas.Length == 0) || (dados == null || dados.Count == 0)) {
                return -1;
            }

            StringBuilder sql = new StringBuilder();
            int tamanho = colunas.Length;

            sql.Append("INSERT INTO ");
            sql.Append(tabela);
            sql.Append(" (");
            for (int i = 0; i < tamanho; i++) {
                sql.Append(i != (tamanho-1) ? colunas[i] + ", " : colunas[i]);
            }
            sql.Append(") ");
            sql.Append("VALUES ");
            sql.Append("( ");
            for (int i = 0; i < tamanho; i++) {
                sql.Append(i != (tamanho-1) ? "@"+colunas[i]+", " : "@"+colunas[i]);
            }
            sql.Append(") ");
            sql.Append("RETURNING ");
            sql.Append(colunaRetorno + ";");

            FbCommand comando = new FbCommand(sql.ToString(), conexao, conexao.BeginTransaction());
            foreach (FbParameter parametro in dados) {
                comando.Parameters.Add(parametro);
            }

            int codigo = -1;
            try {
                codigo = Convert.ToInt32(comando.ExecuteScalar());
                comando.Transaction.Commit();                
            } catch {
                comando.Transaction.Rollback();
                return -1;
            } finally {
                comando.Dispose();
            }

            return codigo;
        }

        /// <summary>
        /// Atualiza uma linha da tabela especificada
        /// </summary>
        /// <param name="tabela">Tabela para atualizar os dados, NÃO PODE SER NULL</param>
        /// <param name="colunas">Colunas da tabela a serem usadas no comando UPDATE, NÃO PODE SER NULL</param>
        /// <param name="onde">Clausula WHERE sem o WHERE propriamente dito. Deve conter os parâmetros, tendo os nomes da coluna precedida por @, NÃO PODE SER NULL</param>
        /// <param name="dados">FbCommand com os parâmetros contendo os dados a serem atualizados na tabela, NÃO PODE SER NULL</param>
        /// <returns>inteiro com chave primária do registro atualizado</returns>
        public int atualizar(string tabela, string[] colunas, string onde, FbParameterCollection dados, string colunaRetorno) {

            if ((tabela == null || tabela.Length == 0) || (colunas == null || colunas.Length == 0) || (onde == null || onde.Length == 0) ||(dados == null || dados.Count == 0)) {
                return -1;
            }
            
            StringBuilder sql = new StringBuilder();
            int tamanho = colunas.Length;

            sql.Append("UPDATE ");
            sql.Append(tabela);
            sql.Append(" SET ");
            for (int i = 0; i < tamanho; i++) {
                sql.Append(i != (tamanho - 1) ? colunas[i] + " = @" + colunas[i] + ", " : colunas[i] + " = @" + colunas[i]);
            }
            sql.Append(" WHERE ");
            sql.Append(onde);
            sql.Append(" RETURNING ");
            sql.Append(colunaRetorno + ";");

            FbCommand comando = new FbCommand(sql.ToString(), conexao, conexao.BeginTransaction());
            foreach (FbParameter parametro in dados) {
                comando.Parameters.Add(parametro);
            }

            int codigoRetorno = -1;
            try {
                codigoRetorno = Convert.ToInt32(comando.ExecuteScalar());
                comando.Transaction.Commit();
            } catch (Exception) {
                comando.Transaction.Rollback();
                return -1;
            } finally {
                comando.Dispose();
            }

            return codigoRetorno;
        }

        /// <summary>
        /// Seleciona dados da tabela especificada
        /// </summary>
        /// <param name="tabela">Tabela para selecionar os dados, NÃO PODE SER NULL</param>
        /// <param name="colunas">Colunas da tabela a serem usadas no comando SELECT, NÃO PODE SER NULL</param>
        /// <param name="como">Será associada a cada uma das colunas para montar o comando AS</param>
        /// <param name="onde">Clausula WHERE sem o WHERE propriamente dito</param>
        /// <returns>FbDataReader com os dados selecionados</returns>
        public FbDataReader selecionar(string tabela, string[] colunas, string[] como, string onde, FbParameterCollection dados) {

            if ((tabela == null || tabela.Length == 0) || (colunas == null || colunas.Length == 0)) {
                return null;
            }

            StringBuilder sql = new StringBuilder();
            int tamanho = colunas.Length;

            sql.Append("SELECT ");
            for (int i = 0; i < tamanho; i++) {
                sql.Append(colunas[i]);
                if (como != null) {
                    sql.Append(" AS ");
                    sql.Append("\"" + como[i] + "\"");
                }
                if (i != tamanho - 1) sql.Append(", ");
            }
            sql.Append(" FROM ");
            sql.Append(tabela);
            if (onde != null && onde.Length > 0) {
                sql.Append(" WHERE ");
                sql.Append(onde);
            }
            sql.Append(";");
            
            FbCommand comando = new FbCommand(sql.ToString(), conexao);
            if (dados != null) {
                foreach (FbParameter parametro in dados) {
                    comando.Parameters.Add(parametro);
                }
            }
            
            FbDataReader resultado = null;
            
            try {
                resultado = comando.ExecuteReader();
            } catch (Exception) {
                return null;
            }
           
            return resultado;
        }

        /// <summary>
        /// Deleta dados da tabela especificada
        /// </summary>
        /// <param name="tabela">Tabela para deletar os dados, NÃO PODE SER NULL</param>
        /// <param name="onde">Clausula WHERE sem o WHERE propriamente dito. Deve conter os parâmetros, tendo os nomes da coluna precedida por @, NÃO PODE SER NULL</param>
        /// <param name="colunaRetorno">Coluna da tabela que deve ter seu valor retornado ao fim da execução do comando</param>
        /// <param name="dados">FbCommand com os parâmetros contendo os dados a serem deletados na tabela, NÃO PODE SER NULL</param>
        /// <returns></returns>
        public int deletar(string tabela, string onde, string colunaRetorno, FbParameterCollection dados) {
            
            if ((tabela == null || tabela.Length == 0) || (onde == null || onde.Length == 0) || (colunaRetorno == null || colunaRetorno.Length == 0) || (dados == null || dados.Count == 0)) {
                return -1;
            }

            StringBuilder sql = new StringBuilder();

            sql.Append("DELETE FROM");
            sql.Append(tabela);
            sql.Append(" WHERE ");
            sql.Append(onde);
            sql.Append(" RETURNING ");
            sql.Append(colunaRetorno + ";");

            FbCommand comando = new FbCommand(sql.ToString(), conexao, conexao.BeginTransaction());
            
            int codigoRetorno = -1;
            try {
                codigoRetorno = Convert.ToInt32(comando.ExecuteScalar());
                comando.Transaction.Commit();
            } catch (Exception) {
                comando.Transaction.Rollback();
                return -1;
            } finally {
                comando.Dispose();
            }

            return codigoRetorno;
        }
    
    }
}
