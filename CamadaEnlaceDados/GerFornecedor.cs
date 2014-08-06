using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FROGI_OS.CamadaAcessoDados;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaEnlaceDados {
    class GerFornecedor {

        private string paramValor = "@VALOR";

        public void inserir(
            dsFROGIOS.FORNECEDORRow fornecedor,
            dsFROGIOS.FORNECEDOR_FISICORow fisico,
            dsFROGIOS.FORNECEDOR_JURIDICORow juridico) {

            TblFornecedor fornecedorSQL = new TblFornecedor();    
            int codigo = fornecedorSQL.inserir(fornecedor);

            if (fisico != null) {
                TblFornecedorFisico fisicoSQL = new TblFornecedorFisico();
                fisico.FORNECEDOR_FISICO_FORNECEDOR = codigo;
                fisicoSQL.inserir(fisico);
            } else if (juridico != null) {
                TblFornecedorJuridico juridicoSQL = new TblFornecedorJuridico();
                juridico.FORNECEDOR_JURIDICO_FORNECEDOR = codigo;
                juridicoSQL.inserir(juridico);
            }
        }

        public void atualizar(
            dsFROGIOS.FORNECEDORRow fornecedor,
            dsFROGIOS.FORNECEDOR_FISICORow fisico,
            dsFROGIOS.FORNECEDOR_JURIDICORow juridico,
            bool eFisico) {
            TblFornecedor fornecedorSQL = new TblFornecedor();
            fornecedorSQL.atualizar(fornecedor);
            TblFornecedorFisico fisicoSQL = new TblFornecedorFisico();
            TblFornecedorJuridico juridicoSQL = new TblFornecedorJuridico();
            if (eFisico) {
                if (juridico != null) {
                    juridicoSQL.deletar(juridico);
                    fisicoSQL.inserir(fisico);
                } else {
                    fisicoSQL.atualizar(fisico);
                }
            } else {
                if (fisico != null) {
                    fisicoSQL.deletar(fisico);
                    juridicoSQL.inserir(juridico);
                } else {
                    juridicoSQL.atualizar(juridico);
                }
            }
        }

        public FbDataReader pesquisar(string coluna, string valor, bool eFisico) {
            FbCommand comando = null;

            string sqlFisico = "SELECT "
            + "FORNECEDOR_CODIGO, "
            + "FORNECEDOR_FISICO_NOME, "
            + "FORNECEDOR_FISICO_CPF, "
            + "FORNECEDOR_TELEFONE, "
            + "FORNECEDOR_CELULAR, "
            + "FORNECEDOR_ENDERECO, "
            + "FORNECEDOR_BAIRRO, "
            + "FORNECEDOR_CIDADE "
            + "FROM FORNECEDOR INNER JOIN FORNECEDOR_FISICO "
            + "ON FORNECEDOR_CODIGO = FORNECEDOR_FISICO_FORNECEDOR "
            + "WHERE " + coluna + " CONTAINING " + paramValor + ";";

            string sqlJuridico = "SELECT "
            + "FORNECEDOR_CODIGO, "
            + "FORNECEDOR_JURIDICO_FANTASIA, "
            + "FORNECEDOR_JURIDICO_CNPJ, "
            + "FORNECEDOR_TELEFONE, "
            + "FORNECEDOR_CELULAR, "
            + "FORNECEDOR_ENDERECO, "
            + "FORNECEDOR_BAIRRO, "
            + "FORNECEDOR_CIDADE "
            + "FROM FORNECEDOR INNER JOIN FORNECEDOR_JURIDICO "
            + "ON FORNECEDOR_CODIGO = FORNECEDOR_JURIDICO_FORNECEDOR "
            + "WHERE " + coluna + " CONTAINING " + paramValor + ";";

            if (eFisico) {
                comando = new FbCommand(sqlFisico, Conexao.getConexao, Conexao.getTransacao);
            } else {
                comando = new FbCommand(sqlJuridico, Conexao.getConexao, Conexao.getTransacao);
            }

            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public void selecionar(
            int codigo, 
            dsFROGIOS.FORNECEDORDataTable fornecedor, 
            dsFROGIOS.FORNECEDOR_FISICODataTable fisico, 
            dsFROGIOS.FORNECEDOR_JURIDICODataTable juridico) {

            fornecedor.Clear();
            
            TblFornecedor fornecedorSql = new TblFornecedor();
            fornecedor.Load(
                fornecedorSql.selecionar(
                fornecedor.FORNECEDOR_CODIGOColumn.ColumnName,
                codigo.ToString(),
                true
                )
            );

            if (fisico != null) {
                fisico.Clear();
                TblFornecedorFisico fisicoSql = new TblFornecedorFisico();
                fisico.Load(
                    fisicoSql.selecionar(
                        fisico.FORNECEDOR_FISICO_FORNECEDORColumn.ColumnName,
                        codigo.ToString(),
                        true
                    )
                );
            } else if (juridico != null) {
                juridico.Clear();
                TblFornecedorJuridico juridicoSql = new TblFornecedorJuridico();
                juridico.Load(
                    juridicoSql.selecionar(
                        juridico.FORNECEDOR_JURIDICO_FORNECEDORColumn.ColumnName,
                        codigo.ToString(),
                        true
                    )
                );
            }
        }

        public void deletar(dsFROGIOS.FORNECEDORRow fornecedor) {
            TblFornecedor fornecedorSql = new TblFornecedor();
            fornecedorSql.deletar(fornecedor);
            //No banco de dados, todas as chaves estrangeiras estão com CASCADE DELETE
            //Logo só basta deletar o registro pai que os registros filhos serão deletados
        }

    }
}
