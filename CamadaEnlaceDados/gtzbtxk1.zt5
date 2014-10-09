using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FROGI_OS.CamadaAcessoDados;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaEnlaceDados {
    class GerAgendamento {

        private TblAgendamento agendamentoSQL;
        private string paramValor = "@VALOR";

        public GerAgendamento() {
            agendamentoSQL = new TblAgendamento();
        }

        public int inserir(dsFROGIOS.AGENDAMENTORow agendamento) {
            return agendamentoSQL.inserir(agendamento);
        }

        public int atualizar(dsFROGIOS.AGENDAMENTORow agendamento) {
            return agendamentoSQL.atualizar(agendamento);
        }

        public void selecionar(
            int codigo, 
            dsFROGIOS.AGENDAMENTODataTable agendamento, 
            dsFROGIOS.CLIENTEDataTable cliente, 
            dsFROGIOS.CLIENTE_FISICODataTable fisico,
            dsFROGIOS.CLIENTE_JURIDICODataTable juridico) {

                agendamento.Clear();
                agendamento.Load(
                    agendamentoSQL.selecionar(
                        agendamento.AGEN_CODIGOColumn.ColumnName,
                        codigo.ToString(),
                        true
                    )
                );

                cliente.Clear();
                TblCliente clienteSQL = new TblCliente();
                cliente.Load(
                        clienteSQL.selecionar(
                            cliente.CLIENTE_CODIGOColumn.ColumnName,
                            ((dsFROGIOS.AGENDAMENTORow)agendamento.Rows[0]).AGEN_CLIENTE.ToString(),
                            true
                        )
                 );

                string tipo = ((dsFROGIOS.CLIENTERow)cliente.Rows[0]).CLIENTE_TIPO;
                if (tipo == "0") {
                    fisico.Clear();
                    TblClienteFisico fisicoSQL = new TblClienteFisico();
                    fisico.Load(fisicoSQL.selecionar(
                            fisico.CLIENTE_FISICO_CLIENTEColumn.ColumnName,
                            ((dsFROGIOS.CLIENTERow)cliente.Rows[0]).CLIENTE_CODIGO.ToString(),
                            true
                        ));
                } else {
                    juridico.Clear();
                    TblClienteJuridico juridicoSQL = new TblClienteJuridico();
                    juridico.Load(juridicoSQL.selecionar(
                            juridico.CLIENTE_JURIDICO_CLIENTEColumn.ColumnName,
                            ((dsFROGIOS.CLIENTERow)cliente.Rows[0]).CLIENTE_CODIGO.ToString(),
                            true
                        ));
                }
        }

        public FbDataReader pesquisar(string coluna, string valor, bool eFisico) {
            FbCommand comando = null;

            string sqlFisico =
                "SELECT "
                + "AGEN_CODIGO, "
                + "CLIENTE_FISICO_NOME, "
                + "AGEN_DATA "
                + "FROM AGENDAMENTO INNER JOIN CLIENTE "
                + "ON AGEN_CLIENTE = CLIENTE_CODIGO "
                + "INNER JOIN CLIENTE_FISICO "
                + "ON CLIENTE_CODIGO = CLIENTE_FISICO_CLIENTE "
                + "WHERE " + coluna + " CONTAINING " + paramValor + ";";

            string sqlJuridico =
                "SELECT "
                + "AGEN_CODIGO, "
                + "CLIENTE_JURIDICO_RAZAO_SOCIAL, "
                + "AGEN_DATA "
                + "FROM AGENDAMENTO INNER JOIN CLIENTE "
                + "ON AGEN_CLIENTE = CLIENTE_CODIGO "
                + "INNER JOIN CLIENTE_JURIDICO "
                + "ON CLIENTE_CODIGO = CLIENTE_JURIDICO_CLIENTE "
                + "WHERE " + coluna + " CONTAINING " + paramValor + ";";

            comando = new FbCommand((eFisico ? sqlFisico : sqlJuridico), Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.AGENDAMENTORow agendamento) {
            return agendamentoSQL.deletar(agendamento);
        }


    }
}
