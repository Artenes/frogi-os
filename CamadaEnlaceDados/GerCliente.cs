using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using FROGI_OS.CamadaAcessoDados;

namespace FROGI_OS.CamadaEnlaceDados {
    class GerCliente {

        private string paramValor = "@VALOR";

        public void inserir(
            dsFROGIOS.CLIENTERow cliente, 
            dsFROGIOS.CLIENTE_FISICORow fisico, 
            dsFROGIOS.CLIENTE_JURIDICORow juridico) {

                TblCliente clienteSQL = new TblCliente();
                int codigo = clienteSQL.inserir(cliente);

                if (fisico != null) {
                    TblClienteFisico fisicoSQL = new TblClienteFisico();
                    fisico.CLIENTE_FISICO_CLIENTE = codigo;
                    fisicoSQL.inserir(fisico);
                } else if (juridico != null) {
                    TblClienteJuridico juridicoSQL = new TblClienteJuridico();
                    juridico.CLIENTE_JURIDICO_CLIENTE = codigo;
                    juridicoSQL.inserir(juridico);
                }
        }

        public void atualizar(
            dsFROGIOS.CLIENTERow cliente,
            dsFROGIOS.CLIENTE_FISICORow fisico,
            dsFROGIOS.CLIENTE_JURIDICORow juridico,
            bool eFisico) {
                TblCliente clienteSQL = new TblCliente();
                clienteSQL.atualizar(cliente);
                TblClienteFisico fisicoSQL = new TblClienteFisico();
                TblClienteJuridico juridicoSQL = new TblClienteJuridico();
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
            + "CLIENTE_CODIGO, "
            + "CLIENTE_FISICO_NOME, "
            + "CLIENTE_FISICO_CPF, "
            + "CLIENTE_TELEFONE, "
            + "CLIENTE_CELULAR, "
            + "CLIENTE_ENDERECO, "
            + "CLIENTE_BAIRRO, "
            + "CLIENTE_CIDADE "
            + "FROM CLIENTE INNER JOIN CLIENTE_FISICO "
            + "ON CLIENTE_CODIGO = CLIENTE_FISICO_CLIENTE "
            + "WHERE " + coluna + " CONTAINING " + paramValor + ";";

            string sqlJuridico = "SELECT "
            + "CLIENTE_CODIGO, "
            + "CLIENTE_JURIDICO_FANTASIA, "
            + "CLIENTE_JURIDICO_CNPJ, "
            + "CLIENTE_TELEFONE, "
            + "CLIENTE_CELULAR, "
            + "CLIENTE_ENDERECO, "
            + "CLIENTE_BAIRRO, "
            + "CLIENTE_CIDADE "
            + "FROM CLIENTE INNER JOIN CLIENTE_JURIDICO "
            + "ON CLIENTE_CODIGO = CLIENTE_JURIDICO_CLIENTE "
            + "WHERE " + coluna + " CONTAINING " + paramValor + ";";

            if (eFisico) {
                comando = new FbCommand(sqlFisico, Conexao.getConexao, Conexao.getTransacao);
            } else {
                comando = new FbCommand(sqlJuridico, Conexao.getConexao, Conexao.getTransacao);
            }

            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public void selecionar(int codigo, dsFROGIOS.CLIENTEDataTable cliente, dsFROGIOS.CLIENTE_FISICODataTable fisico, dsFROGIOS.CLIENTE_JURIDICODataTable juridico) {

            cliente.Clear();
            TblCliente clienteSql = new TblCliente();
            cliente.Load(
                clienteSql.selecionar(
                cliente.CLIENTE_CODIGOColumn.ColumnName,
                codigo.ToString(),
                true
                )
            );
            if (fisico != null) {
                fisico.Clear();
                TblClienteFisico fisicoSql = new TblClienteFisico();
                fisico.Load(
                    fisicoSql.selecionar(
                        fisico.CLIENTE_FISICO_CLIENTEColumn.ColumnName,
                        codigo.ToString(),
                        true
                    )
                );
            } else if (juridico != null) {
                juridico.Clear();
                TblClienteJuridico juridicoSql = new TblClienteJuridico();
                juridico.Load(
                    juridicoSql.selecionar(
                        juridico.CLIENTE_JURIDICO_CLIENTEColumn.ColumnName,
                        codigo.ToString(),
                        true
                    )
                );
            }
        }

        public void deletar(dsFROGIOS.CLIENTERow cliente) {
            TblCliente clienteSql = new TblCliente();
            clienteSql.deletar(cliente);
            //No banco de dados, todas as chaves estrangeiras estão com CASCADE DELETE
            //Logo só basta deletar o registro pai que os registros filhos serão deletados
        }


    }
}
