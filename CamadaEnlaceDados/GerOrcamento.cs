using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FROGI_OS.CamadaAcessoDados;
using System.Data;

namespace FROGI_OS.CamadaEnlaceDados
{
    class GerOrcamento {

        private TblOrcamento orcamentoSQL;
        private TblOrcamentoItem orcamentoItemSQL;
        private TblOrcamentoServico orcamentoServicoSQL;

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

            dsFROGIOS.ORCAMENTO_ITEMDataTable itensDeletados =
                (dsFROGIOS.ORCAMENTO_ITEMDataTable)itens.GetChanges(DataRowState.Deleted);
            dsFROGIOS.ORCAMENTO_ITEMDataTable itensInseridos =
                (dsFROGIOS.ORCAMENTO_ITEMDataTable)itens.GetChanges(DataRowState.Added);

            dsFROGIOS.ORCAMENTO_SERVICODataTable servicosDeletados =
                (dsFROGIOS.ORCAMENTO_SERVICODataTable)itens.GetChanges(DataRowState.Deleted);
            dsFROGIOS.ORCAMENTO_SERVICODataTable servicosInseridos =
                (dsFROGIOS.ORCAMENTO_SERVICODataTable)itens.GetChanges(DataRowState.Added);

            dsFROGIOS.ORCAMENTO_ITEMRow item = itens.NewORCAMENTO_ITEMRow();
            dsFROGIOS.ORCAMENTO_SERVICORow servico = servicos.NewORCAMENTO_SERVICORow();

            int qtdItensDeletados = itensDeletados.Rows.Count;
            int qtdItensInseridos = itensInseridos.Rows.Count;
            int qtdServicosDeletados = servicosDeletados.Rows.Count;
            int qtdServicosInseridos = servicosInseridos.Rows.Count;

            for (int i = 0; i < qtdItensDeletados; i++) {
                item.ORCAMENTO_ITEM_CODIGO =
                    (int)itensDeletados.Rows[i][itensDeletados.ORCAMENTO_ITEM_CODIGOColumn, DataRowVersion.Original];
                orcamentoItemSQL.deletar(item);
            }

            for (int i = 0; i < qtdServicosDeletados; i++) {
                servico.ORCAMENTO_SERVICO_CODIGO =
                    (int)servicosDeletados.Rows[i][servicosDeletados.ORCAMENTO_SERVICO_CODIGOColumn, DataRowVersion.Original];
                orcamentoServicoSQL.deletar(servico);
            }

            for (int i = 0; i < qtdItensInseridos; i++) {
                item.ORCAMENTO_ITEM_DESCONTO = (double) itensInseridos.Rows[i][itensInseridos.ORCAMENTO_ITEM_DESCONTOColumn, DataRowVersion.Current];
                item.ORCAMENTO_ITEM_DESCRICAO = (string) itensInseridos.Rows[i][itensInseridos.ORCAMENTO_ITEM_DESCRICAOColumn, DataRowVersion.Current];
                item.ORCAMENTO_ITEM_ORCAMENTO = orcamento.ORCAMENTO_CODIGO;
                item.ORCAMENTO_ITEM_PRODUTO = (int)itensInseridos.Rows[i][itensInseridos.ORCAMENTO_ITEM_PRODUTOColumn, DataRowVersion.Current];
                item.ORCAMENTO_ITEM_QUANTIDADE = (short)itensInseridos.Rows[i][itensInseridos.ORCAMENTO_ITEM_QUANTIDADEColumn, DataRowVersion.Current];
                item.ORCAMENTO_ITEM_TOTAL = (double)itensInseridos.Rows[i][itensInseridos.ORCAMENTO_ITEM_TOTALColumn, DataRowVersion.Current];
                item.ORCAMENTO_ITEM_VALOR = (double)itensInseridos.Rows[i][itensInseridos.ORCAMENTO_ITEM_VALORColumn, DataRowVersion.Current];
                orcamentoItemSQL.inserir(item);
            }

            for (int i = 0; i < qtdServicosInseridos; i++) {
                servico.ORCAMENTO_SERVICO_DESCONTO = (double)servicosInseridos.Rows[i][servicosInseridos.ORCAMENTO_SERVICO_DESCONTOColumn, DataRowVersion.Current];
                servico.ORCAMENTO_SERVICO_DESCRICAO = (string)servicosInseridos.Rows[i][servicosInseridos.ORCAMENTO_SERVICO_DESCRICAOColumn, DataRowVersion.Current];
                servico.ORCAMENTO_SERVICO_ORCAMENTO = orcamento.ORCAMENTO_CODIGO;
                servico.ORCAMENTO_SERVICO_SERVICO = (int)servicosInseridos.Rows[i][servicosInseridos.ORCAMENTO_SERVICO_SERVICOColumn, DataRowVersion.Current];
                servico.ORCAMENTO_SERVICO_TOTAL = (double)servicosInseridos.Rows[i][servicosInseridos.ORCAMENTO_SERVICO_TOTALColumn, DataRowVersion.Current];
                servico.ORCAMENTO_SERVICO_VALOR = (double)servicosInseridos.Rows[i][servicosInseridos.ORCAMENTO_SERVICO_VALORColumn, DataRowVersion.Current];
                orcamentoServicoSQL.inserir(servico);
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
        public void deletar(dsFROGIOS.ORCAMENTORow orcamento) {
            orcamentoSQL.deletar(orcamento);
            //Deleta só o orcamento
            //FK é CASACE DELETE
        }

    }
}
