using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FROGI_OS.CamadaAcessoDados;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaEnlaceDados
{
    class GerOrcamento {

        private TblOrcamento orcamentoSQL;
        private TblOrcamentoItem orcamentoItemSQL;
        private TblOrcamentoServico orcamentoServicoSQL;
        private string paramValor = "@VALOR";

        public GerOrcamento() {
            orcamentoSQL = new TblOrcamento();
            orcamentoItemSQL = new TblOrcamentoItem();
            orcamentoServicoSQL = new TblOrcamentoServico();
        }

        public void inserir(
            dsFROGIOS.ORCAMENTORow orcamento, 
            dsFROGIOS.ORCAMENTO_ITEMDataTable itens, 
            dsFROGIOS.ORCAMENTO_SERVICODataTable servicos) 
        {
            int codigo = orcamentoSQL.inserir(orcamento);

            foreach (dsFROGIOS.ORCAMENTO_ITEMRow item in itens.Rows) {
                item.ORCAMENTO_ITEM_ORCAMENTO = codigo;
                orcamentoItemSQL.inserir(item);
            }

            foreach (dsFROGIOS.ORCAMENTO_SERVICORow servico in servicos.Rows) {
                servico.ORCAMENTO_SERVICO_ORCAMENTO = codigo;
                orcamentoServicoSQL.inserir(servico);
            }

        }

        public void atualizar(
            dsFROGIOS.ORCAMENTORow orcamento,
            dsFROGIOS.ORCAMENTO_ITEMDataTable itens,
            dsFROGIOS.ORCAMENTO_SERVICODataTable servicos) 
        {
            orcamentoSQL.atualizar(orcamento);

            dsFROGIOS.ORCAMENTO_ITEMDataTable itensDeletados = new dsFROGIOS.ORCAMENTO_ITEMDataTable();
            dsFROGIOS.ORCAMENTO_ITEMDataTable itensInseridos = new dsFROGIOS.ORCAMENTO_ITEMDataTable();
            dsFROGIOS.ORCAMENTO_SERVICODataTable servicosDeletados = new dsFROGIOS.ORCAMENTO_SERVICODataTable();
            dsFROGIOS.ORCAMENTO_SERVICODataTable servicosInseridos = new dsFROGIOS.ORCAMENTO_SERVICODataTable();

            int contador = 0;
            foreach (dsFROGIOS.ORCAMENTO_ITEMRow item in itens) {
                if (item.RowState == DataRowState.Added) {
                    item.ORCAMENTO_ITEM_CODIGO = contador; contador++;
                    item.ORCAMENTO_ITEM_ORCAMENTO = orcamento.ORCAMENTO_CODIGO;
                    itensInseridos.ImportRow(item);
                }
            }
            itensDeletados = (dsFROGIOS.ORCAMENTO_ITEMDataTable)itens.GetChanges(DataRowState.Deleted);

            contador = 0;
            foreach (dsFROGIOS.ORCAMENTO_SERVICORow servico in servicos) {
                if (servico.RowState == DataRowState.Added) {
                    servico.ORCAMENTO_SERVICO_CODIGO = contador; contador++;
                    servico.ORCAMENTO_SERVICO_ORCAMENTO = orcamento.ORCAMENTO_CODIGO;
                    servicosInseridos.ImportRow(servico);
                }
            }
            servicosDeletados = (dsFROGIOS.ORCAMENTO_SERVICODataTable)servicos.GetChanges(DataRowState.Deleted);

            dsFROGIOS.ORCAMENTO_ITEMRow itemTmp = itens.NewORCAMENTO_ITEMRow();
            dsFROGIOS.ORCAMENTO_SERVICORow servicoTmp = servicos.NewORCAMENTO_SERVICORow();

            int qtdItensDeletados = itensDeletados != null ? itensDeletados.Rows.Count : 0;
            int qtdItensInseridos = itensInseridos != null ? itensInseridos.Rows.Count : 0;
            int qtdServicosDeletados = servicosDeletados != null ? servicosDeletados.Rows.Count : 0;
            int qtdServicosInseridos = servicosInseridos != null ? servicosInseridos.Rows.Count : 0;

            for (int i = 0; i < qtdItensDeletados; i++) {
                itemTmp.ORCAMENTO_ITEM_CODIGO = (int)itensDeletados.Rows[i][itensDeletados.ORCAMENTO_ITEM_CODIGOColumn, DataRowVersion.Original];
                orcamentoItemSQL.deletar(itemTmp);
            }

            for (int i = 0; i < qtdServicosDeletados; i++) {
                servicoTmp.ORCAMENTO_SERVICO_CODIGO = (int)servicosDeletados.Rows[i][servicosDeletados.ORCAMENTO_SERVICO_CODIGOColumn, DataRowVersion.Original];
                orcamentoServicoSQL.deletar(servicoTmp);
            }

            for (int i = 0; i < qtdItensInseridos; i++) {
                itemTmp.ORCAMENTO_ITEM_ORCAMENTO = orcamento.ORCAMENTO_CODIGO;
                itemTmp.ORCAMENTO_ITEM_PRODUTO = (int)itensInseridos.Rows[i][itensInseridos.ORCAMENTO_ITEM_PRODUTOColumn, DataRowVersion.Current];
                itemTmp.ORCAMENTO_ITEM_VALOR = (double)itensInseridos.Rows[i][itensInseridos.ORCAMENTO_ITEM_VALORColumn, DataRowVersion.Current];
                itemTmp.ORCAMENTO_ITEM_DESCRICAO = (string) itensInseridos.Rows[i][itensInseridos.ORCAMENTO_ITEM_DESCRICAOColumn, DataRowVersion.Current];
                itemTmp.ORCAMENTO_ITEM_DESCONTO = (double)itensInseridos.Rows[i][itensInseridos.ORCAMENTO_ITEM_DESCONTOColumn, DataRowVersion.Current];
                itemTmp.ORCAMENTO_ITEM_QUANTIDADE = (short)itensInseridos.Rows[i][itensInseridos.ORCAMENTO_ITEM_QUANTIDADEColumn, DataRowVersion.Current];
                itemTmp.ORCAMENTO_ITEM_TOTAL = (double)itensInseridos.Rows[i][itensInseridos.ORCAMENTO_ITEM_TOTALColumn, DataRowVersion.Current];
                orcamentoItemSQL.inserir(itemTmp);
            }

            for (int i = 0; i < qtdServicosInseridos; i++) {
                servicoTmp.ORCAMENTO_SERVICO_ORCAMENTO = orcamento.ORCAMENTO_CODIGO;
                servicoTmp.ORCAMENTO_SERVICO_SERVICO = (int)servicosInseridos.Rows[i][servicosInseridos.ORCAMENTO_SERVICO_SERVICOColumn, DataRowVersion.Current];
                servicoTmp.ORCAMENTO_SERVICO_VALOR = (double)servicosInseridos.Rows[i][servicosInseridos.ORCAMENTO_SERVICO_VALORColumn, DataRowVersion.Current];
                servicoTmp.ORCAMENTO_SERVICO_DESCRICAO = (string)servicosInseridos.Rows[i][servicosInseridos.ORCAMENTO_SERVICO_DESCRICAOColumn, DataRowVersion.Current];
                servicoTmp.ORCAMENTO_SERVICO_DESCONTO = (double)servicosInseridos.Rows[i][servicosInseridos.ORCAMENTO_SERVICO_DESCONTOColumn, DataRowVersion.Current];
                servicoTmp.ORCAMENTO_SERVICO_ACRESCIMO = (double)servicosInseridos.Rows[i][servicosInseridos.ORCAMENTO_SERVICO_ACRESCIMOColumn, DataRowVersion.Current];
                servicoTmp.ORCAMENTO_SERVICO_TOTAL = (double)servicosInseridos.Rows[i][servicosInseridos.ORCAMENTO_SERVICO_TOTALColumn, DataRowVersion.Current];
                orcamentoServicoSQL.inserir(servicoTmp);
            }
        }

        public void selecionar(
            int codigo,
            dsFROGIOS.ORCAMENTODataTable orcamento,
            dsFROGIOS.ORCAMENTO_ITEMDataTable item,
            dsFROGIOS.ORCAMENTO_SERVICODataTable servico,
            dsFROGIOS.CLIENTEDataTable cliente,
            dsFROGIOS.CLIENTE_FISICODataTable fisico,
            dsFROGIOS.CLIENTE_JURIDICODataTable juridico,
            dsFROGIOS.FUNCIONARIODataTable funcionario)
        {

            TblCliente clienteSQL = new TblCliente();
            TblClienteFisico fisicoSQL = new TblClienteFisico();
            TblClienteJuridico juridicoSQL = new TblClienteJuridico();
            TblFuncionario funcionarioSQL = new TblFuncionario();

            orcamento.Clear();
            orcamento.Load(
                    orcamentoSQL.selecionar(
                        orcamento.ORCAMENTO_CODIGOColumn.ColumnName,
                        codigo.ToString(),
                        true
                    )
                );

            dsFROGIOS.ORCAMENTORow orcamentoLinha = (dsFROGIOS.ORCAMENTORow)orcamento.Rows[0];

            item.Clear();
            item.Load(
                    orcamentoItemSQL.selecionar(
                        item.ORCAMENTO_ITEM_ORCAMENTOColumn.ColumnName,
                        codigo.ToString(),
                        true
                    )
                );

            servico.Clear();
            servico.Load(
                    orcamentoServicoSQL.selecionar(
                        servico.ORCAMENTO_SERVICO_ORCAMENTOColumn.ColumnName,
                        codigo.ToString(),
                        true
                    )
                );

            cliente.Clear();
            cliente.Load(
                    clienteSQL.selecionar(
                        cliente.CLIENTE_CODIGOColumn.ColumnName,
                        orcamentoLinha.ORCAMENTO_CLIENTE.ToString(),
                        true
                    )
                );

            fisico.Clear();
            fisico.Load(
                    fisicoSQL.selecionar(
                        fisico.CLIENTE_FISICO_CLIENTEColumn.ColumnName,
                        orcamentoLinha.ORCAMENTO_CLIENTE.ToString(),
                        true
                    )
                );

            juridico.Clear();
            juridico.Load(
                    juridicoSQL.selecionar(
                        juridico.CLIENTE_JURIDICO_CLIENTEColumn.ColumnName,
                        orcamentoLinha.ORCAMENTO_CLIENTE.ToString(),
                        true
                    )
                );

            funcionario.Clear();
            funcionario.Load(
                    funcionarioSQL.selecionar(
                        funcionario.FUNCIONARIO_CODIGOColumn.ColumnName,
                        orcamentoLinha.ORCAMENTO_FUNCIONARIO.ToString(),
                        true
                    )
                );
        }

        public FbDataReader pesquisar(string coluna, string valor, bool eFisico) {
            FbCommand comando = null;

            string sqlFisico = 
                "SELECT "
                + "ORCAMENTO_CODIGO, "
                + "CLIENTE_FISICO_NOME, "
                + "CLIENTE_TELEFONE, " 
                + "CLIENTE_CELULAR, "
                + "FUNCIONARIO_NOME, "
                + "ORCAMENTO_DATA "
                + "FROM "
                + "CLIENTE INNER JOIN "
                + "CLIENTE_FISICO ON CLIENTE_CODIGO = CLIENTE_FISICO_CLIENTE INNER JOIN "
                + "ORCAMENTO ON CLIENTE_CODIGO = ORCAMENTO_CLIENTE INNER JOIN "
                + "FUNCIONARIO ON ORCAMENTO_FUNCIONARIO = FUNCIONARIO_CODIGO "
                + "WHERE " + coluna + " CONTAINING " + paramValor + ";";


            string sqlJuridico =
                "SELECT "
                + "ORCAMENTO_CODIGO, "
                + "CLIENTE_JURIDICO_FANTASIA, "
                + "CLIENTE_TELEFONE, "
                + "CLIENTE_CELULAR, "
                + "FUNCIONARIO_NOME, "
                + "ORCAMENTO_DATA "
                + "FROM "
                + "CLIENTE INNER JOIN "
                + "CLIENTE_JURIDICO ON CLIENTE_CODIGO = CLIENTE_JURIDICO_CLIENTE INNER JOIN "
                + "ORCAMENTO ON CLIENTE_CODIGO = ORCAMENTO_CLIENTE INNER JOIN "
                + "FUNCIONARIO ON ORCAMENTO_FUNCIONARIO = FUNCIONARIO_CODIGO;"
                + "WHERE " + coluna + " CONTAINING " + paramValor + ";";

            comando = new FbCommand((eFisico ? sqlFisico : sqlJuridico), Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);

            return comando.ExecuteReader();
        }

        public void deletar(dsFROGIOS.ORCAMENTORow orcamento) {
            orcamentoSQL.deletar(orcamento);
            //Deleta só o orcamento
            //FK é CASACE DELETE
        }

    }
}
