using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FROGI_OS.CamadaAcessoDados;
using System.Data;

namespace FROGI_OS.CamadaEnlaceDados
{
    class GerOs {

        private TblOs sqlOs;
        private TblOsItem sqlOsItem;
        private TblOsServico sqlOsServico;

        public GerOs() {
            sqlOs = new TblOs();
            sqlOsItem = new TblOsItem();
            sqlOsServico = new TblOsServico();
        }

        public void inserir(
            dsFROGIOS.OSRow os, 
            dsFROGIOS.OS_ITEMDataTable itens, 
            dsFROGIOS.OS_SERVICODataTable servicos) 
        {
            int codigo = sqlOs.inserir(os);

            foreach (dsFROGIOS.OS_ITEMRow item in itens.Rows) {
                item.OS_ITEM_OS = codigo;
                sqlOsItem.inserir(item);
            }

            foreach (dsFROGIOS.OS_SERVICORow servico in servicos.Rows) {
                servico.OS_SERVICO_OS = codigo;
                sqlOsServico.inserir(servico);
            }

        }

        public void atualizar(
            dsFROGIOS.OSRow os,
            dsFROGIOS.OS_ITEMDataTable itens,
            dsFROGIOS.OS_SERVICODataTable servicos) 
        {
            sqlOs.atualizar(os);

            dsFROGIOS.OS_ITEMDataTable itensDeletados =
                (dsFROGIOS.OS_ITEMDataTable)itens.GetChanges(DataRowState.Deleted);
            dsFROGIOS.OS_ITEMDataTable itensInseridos =
                (dsFROGIOS.OS_ITEMDataTable)itens.GetChanges(DataRowState.Added);

            dsFROGIOS.OS_SERVICODataTable servicosDeletados =
                (dsFROGIOS.OS_SERVICODataTable)itens.GetChanges(DataRowState.Deleted);
            dsFROGIOS.OS_SERVICODataTable servicosInseridos =
                (dsFROGIOS.OS_SERVICODataTable)itens.GetChanges(DataRowState.Added);

            dsFROGIOS.OS_ITEMRow item = itens.NewOS_ITEMRow();
            dsFROGIOS.OS_SERVICORow servico = servicos.NewOS_SERVICORow();

            int qtdItensDeletados = itensDeletados.Rows.Count;
            int qtdItensInseridos = itensInseridos.Rows.Count;
            int qtdServicosDeletados = servicosDeletados.Rows.Count;
            int qtdServicosInseridos = servicosInseridos.Rows.Count;

            for (int i = 0; i < qtdItensDeletados; i++) {
                item.OS_ITEM_CODIGO =
                    (int)itensDeletados.Rows[i][itensDeletados.OS_ITEM_CODIGOColumn, DataRowVersion.Original];
                sqlOsItem.deletar(item);
            }

            for (int i = 0; i < qtdServicosDeletados; i++) {
                servico.OS_SERVICO_CODIGO =
                    (int)servicosDeletados.Rows[i][servicosDeletados.OS_SERVICO_CODIGOColumn, DataRowVersion.Original];
                sqlOsServico.deletar(servico);
            }

            for (int i = 0; i < qtdItensInseridos; i++) {
                item.OS_ITEM_DESCONTO = (double) itensInseridos.Rows[i][itensInseridos.OS_ITEM_DESCONTOColumn, DataRowVersion.Current];
                item.OS_ITEM_DESCRICAO = (string) itensInseridos.Rows[i][itensInseridos.OS_ITEM_DESCRICAOColumn, DataRowVersion.Current];
                item.OS_ITEM_OS = os.OS_CODIGO;
                item.OS_ITEM_PRODUTO = (int)itensInseridos.Rows[i][itensInseridos.OS_ITEM_PRODUTOColumn, DataRowVersion.Current];
                item.OS_ITEM_QUANTIDADE = (short)itensInseridos.Rows[i][itensInseridos.OS_ITEM_QUANTIDADEColumn, DataRowVersion.Current];
                item.OS_ITEM_TOTAL = (double)itensInseridos.Rows[i][itensInseridos.OS_ITEM_TOTALColumn, DataRowVersion.Current];
                item.OS_ITEM_VALOR = (double)itensInseridos.Rows[i][itensInseridos.OS_ITEM_VALORColumn, DataRowVersion.Current];
                sqlOsItem.inserir(item);
            }

            for (int i = 0; i < qtdServicosInseridos; i++) {
                servico.OS_SERVICO_DESCONTO = (double)servicosInseridos.Rows[i][servicosInseridos.OS_SERVICO_DESCONTOColumn, DataRowVersion.Current];
                servico.OS_SERVICO_DESCRICAO = (string)servicosInseridos.Rows[i][servicosInseridos.OS_SERVICO_DESCRICAOColumn, DataRowVersion.Current];
                servico.OS_SERVICO_OS = os.OS_CODIGO;
                servico.OS_SERVICO_SERVICO = (int)servicosInseridos.Rows[i][servicosInseridos.OS_SERVICO_SERVICOColumn, DataRowVersion.Current];
                servico.OS_SERVICO_TOTAL = (double)servicosInseridos.Rows[i][servicosInseridos.OS_SERVICO_TOTALColumn, DataRowVersion.Current];
                servico.OS_SERVICO_VALOR = (double)servicosInseridos.Rows[i][servicosInseridos.OS_SERVICO_VALORColumn, DataRowVersion.Current];
                sqlOsServico.inserir(servico);
            }
        }

        public void selecionar(
            int codigo,
            dsFROGIOS.OSDataTable os,
            dsFROGIOS.OS_ITEMDataTable item,
            dsFROGIOS.OS_SERVICODataTable servico,
            dsFROGIOS.CLIENTEDataTable cliente,
            dsFROGIOS.CLIENTE_FISICODataTable fisico,
            dsFROGIOS.CLIENTE_JURIDICODataTable juridico,
            dsFROGIOS.FUNCIONARIODataTable funcionario)
        {

            TblCliente clienteSQL = new TblCliente();
            TblClienteFisico fisicoSQL = new TblClienteFisico();
            TblClienteJuridico juridicoSQL = new TblClienteJuridico();
            TblFuncionario funcionarioSQL = new TblFuncionario();

            os.Clear();
            os.Load(
                    sqlOs.selecionar(
                        os.OS_CODIGOColumn.ColumnName,
                        codigo.ToString(),
                        true
                    )
                );

            dsFROGIOS.OSRow osLinha = (dsFROGIOS.OSRow)os.Rows[0];

            item.Clear();
            item.Load(
                    sqlOsItem.selecionar(
                        item.OS_ITEM_OSColumn.ColumnName,
                        codigo.ToString(),
                        true
                    )
                );

            servico.Clear();
            servico.Load(
                    sqlOsServico.selecionar(
                        servico.OS_SERVICO_OSColumn.ColumnName,
                        codigo.ToString(),
                        true
                    )
                );

            cliente.Clear();
            cliente.Load(
                    clienteSQL.selecionar(
                        cliente.CLIENTE_CODIGOColumn.ColumnName,
                        osLinha.OS_CLIENTE.ToString(),
                        true
                    )
                );

            fisico.Clear();
            fisico.Load(
                    fisicoSQL.selecionar(
                        fisico.CLIENTE_FISICO_CLIENTEColumn.ColumnName,
                        osLinha.OS_CLIENTE.ToString(),
                        true
                    )
                );

            juridico.Clear();
            juridico.Load(
                    juridicoSQL.selecionar(
                        juridico.CLIENTE_JURIDICO_CLIENTEColumn.ColumnName,
                        osLinha.OS_CLIENTE.ToString(),
                        true
                    )
                );

            funcionario.Clear();
            funcionario.Load(
                    funcionarioSQL.selecionar(
                        funcionario.FUNCIONARIO_CODIGOColumn.ColumnName,
                        osLinha.OS_FUNCIONARIO.ToString(),
                        true
                    )
                );
        }
        public void deletar(dsFROGIOS.OSRow os) {
            sqlOs.deletar(os);
            //Deleta só o orcamento
            //FK é CASACE DELETE
        }

    }
}
