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
    class GerOs {

        private TblOs sqlOs;
        private TblOsItem sqlOsItem;
        private TblOsServico sqlOsServico;
        private string paramValor = "@VALOR";
        public static string LANCADO = "LANÇADO";
        public static string ABERTO = "ABERTO";
        public static string CONCLUIDO = "CONCLUÍDO";
        public static string CANCELADO = "CANCELADO";

        public GerOs() {
            sqlOs = new TblOs();
            sqlOsItem = new TblOsItem();
            sqlOsServico = new TblOsServico();
        }

        public void inserir(
            dsFROGIOS.OSRow os, 
            dsFROGIOS.OS_ITEMDataTable itens, 
            dsFROGIOS.OS_SERVICODataTable servicos)  {

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

            dsFROGIOS.OS_ITEMDataTable itensDeletados = new dsFROGIOS.OS_ITEMDataTable();
            dsFROGIOS.OS_ITEMDataTable itensInseridos = new dsFROGIOS.OS_ITEMDataTable();
            dsFROGIOS.OS_SERVICODataTable servicosDeletados = new dsFROGIOS.OS_SERVICODataTable();
            dsFROGIOS.OS_SERVICODataTable servicosInseridos = new dsFROGIOS.OS_SERVICODataTable();

            int contador = 0;
            foreach (dsFROGIOS.OS_ITEMRow item in itens)
            {
                if (item.RowState == DataRowState.Added)
                {
                    item.OS_ITEM_CODIGO = contador; contador++;
                    item.OS_ITEM_OS = os.OS_CODIGO;
                    itensInseridos.ImportRow(item);
                }
            }
            itensDeletados = (dsFROGIOS.OS_ITEMDataTable)itens.GetChanges(DataRowState.Deleted);

            contador = 0;
            foreach (dsFROGIOS.OS_SERVICORow servico in servicos)
            {
                if (servico.RowState == DataRowState.Added)
                {
                    servico.OS_SERVICO_CODIGO = contador; contador++;
                    servico.OS_SERVICO_OS = os.OS_CODIGO;
                    servicosInseridos.ImportRow(servico);
                }
            }
            servicosDeletados = (dsFROGIOS.OS_SERVICODataTable)servicos.GetChanges(DataRowState.Deleted);

            dsFROGIOS.OS_ITEMRow itemTmp = itens.NewOS_ITEMRow();
            dsFROGIOS.OS_SERVICORow servicoTmp = servicos.NewOS_SERVICORow();

            int qtdItensDeletados = itensDeletados != null ? itensDeletados.Rows.Count : 0;
            int qtdItensInseridos = itensInseridos != null ? itensInseridos.Rows.Count : 0;
            int qtdServicosDeletados = servicosDeletados != null ? servicosDeletados.Rows.Count : 0;
            int qtdServicosInseridos = servicosInseridos != null ? servicosInseridos.Rows.Count : 0;

            for (int i = 0; i < qtdItensDeletados; i++) {
                itemTmp.OS_ITEM_CODIGO = (int)itensDeletados.Rows[i][itensDeletados.OS_ITEM_CODIGOColumn, DataRowVersion.Original];
                sqlOsItem.deletar(itemTmp);
            }

            for (int i = 0; i < qtdServicosDeletados; i++) {
                servicoTmp.OS_SERVICO_CODIGO = (int)servicosDeletados.Rows[i][servicosDeletados.OS_SERVICO_CODIGOColumn, DataRowVersion.Original];
                sqlOsServico.deletar(servicoTmp);
            }

            for (int i = 0; i < qtdItensInseridos; i++) {
                itemTmp.OS_ITEM_DESCONTO = (double) itensInseridos.Rows[i][itensInseridos.OS_ITEM_DESCONTOColumn, DataRowVersion.Current];
                itemTmp.OS_ITEM_DESCRICAO = (string) itensInseridos.Rows[i][itensInseridos.OS_ITEM_DESCRICAOColumn, DataRowVersion.Current];
                itemTmp.OS_ITEM_OS = os.OS_CODIGO;
                itemTmp.OS_ITEM_PRODUTO = (int)itensInseridos.Rows[i][itensInseridos.OS_ITEM_PRODUTOColumn, DataRowVersion.Current];
                itemTmp.OS_ITEM_QUANTIDADE = (short)itensInseridos.Rows[i][itensInseridos.OS_ITEM_QUANTIDADEColumn, DataRowVersion.Current];
                itemTmp.OS_ITEM_TOTAL = (double)itensInseridos.Rows[i][itensInseridos.OS_ITEM_TOTALColumn, DataRowVersion.Current];
                itemTmp.OS_ITEM_VALOR = (double)itensInseridos.Rows[i][itensInseridos.OS_ITEM_VALORColumn, DataRowVersion.Current];
                sqlOsItem.inserir(itemTmp);
            }

            for (int i = 0; i < qtdServicosInseridos; i++) {
                servicoTmp.OS_SERVICO_DESCONTO = (double)servicosInseridos.Rows[i][servicosInseridos.OS_SERVICO_DESCONTOColumn, DataRowVersion.Current];
                servicoTmp.OS_SERVICO_DESCRICAO = (string)servicosInseridos.Rows[i][servicosInseridos.OS_SERVICO_DESCRICAOColumn, DataRowVersion.Current];
                servicoTmp.OS_SERVICO_OS = os.OS_CODIGO;
                servicoTmp.OS_SERVICO_SERVICO = (int)servicosInseridos.Rows[i][servicosInseridos.OS_SERVICO_SERVICOColumn, DataRowVersion.Current];
                servicoTmp.OS_SERVICO_TOTAL = (double)servicosInseridos.Rows[i][servicosInseridos.OS_SERVICO_TOTALColumn, DataRowVersion.Current];
                servicoTmp.OS_SERVICO_VALOR = (double)servicosInseridos.Rows[i][servicosInseridos.OS_SERVICO_VALORColumn, DataRowVersion.Current];
                sqlOsServico.inserir(servicoTmp);
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

        public FbDataReader pesquisar(string coluna, string valor, bool eFisico)
        {
            FbCommand comando = null;

            string sqlFisico =
                "SELECT "
                + "OS_CODIGO, "
                + "CLIENTE_FISICO_NOME, "
                + "CLIENTE_TELEFONE, "
                + "CLIENTE_CELULAR, "
                + "FUNCIONARIO_NOME, "
                + "OS_DATA, "
                + "OS_STATUS "
                + "FROM "
                + "CLIENTE INNER JOIN "
                + "CLIENTE_FISICO ON CLIENTE_CODIGO = CLIENTE_FISICO_CLIENTE INNER JOIN "
                + "OS ON CLIENTE_CODIGO = OS_CLIENTE INNER JOIN "
                + "FUNCIONARIO ON OS_FUNCIONARIO = FUNCIONARIO_CODIGO "
                + "WHERE " + coluna + " CONTAINING " + paramValor + ";";


            string sqlJuridico =
                "SELECT "
                + "OS_CODIGO, "
                + "CLIENTE_JURIDICO_FANTASIA, "
                + "CLIENTE_TELEFONE, "
                + "CLIENTE_CELULAR, "
                + "FUNCIONARIO_NOME, "
                + "OS_DATA, "
                + "OS_STATUS "
                + "FROM "
                + "CLIENTE INNER JOIN "
                + "CLIENTE_JURIDICO ON CLIENTE_CODIGO = CLIENTE_JURIDICO_CLIENTE INNER JOIN "
                + "OS ON CLIENTE_CODIGO = OS_CLIENTE INNER JOIN "
                + "FUNCIONARIO ON OS_FUNCIONARIO = FUNCIONARIO_CODIGO "
                + "WHERE " + coluna + " CONTAINING " + paramValor + ";";

            comando = new FbCommand((eFisico ? sqlFisico : sqlJuridico), Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);

            return comando.ExecuteReader();
        }

    }
}
