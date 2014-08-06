using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FROGI_OS.CamadaAcessoDados;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaEnlaceDados {
    class GerCompra {

        private string paramValor = "@VALOR";

        public void inserir(
            dsFROGIOS.COMPRARow compra,
            dsFROGIOS.ITEM_COMPRADataTable itemCompra) {

                TblCompra compraSQL = new TblCompra();
                int codigo = compraSQL.inserir(compra);

                TblItemCompra itemCompraSQL = new TblItemCompra();
                foreach (dsFROGIOS.ITEM_COMPRARow item in itemCompra.Rows) {
                    item.ITEM_COMPRA_COMPRA = codigo;
                    itemCompraSQL.inserir(item);
                }
        }

        public void atualizar(
            dsFROGIOS.COMPRARow compra,
            dsFROGIOS.ITEM_COMPRADataTable itemCompra
            ) {

                TblCompra compraSQL = new TblCompra();
                compraSQL.atualizar(compra);

                dsFROGIOS.ITEM_COMPRADataTable deletados = (dsFROGIOS.ITEM_COMPRADataTable)itemCompra.GetChanges(DataRowState.Deleted);
                dsFROGIOS.ITEM_COMPRADataTable inseridos = (dsFROGIOS.ITEM_COMPRADataTable)itemCompra.GetChanges(DataRowState.Added);
                TblItemCompra itemCompraSQL = new TblItemCompra();
                dsFROGIOS.ITEM_COMPRARow itemCompraLinha = itemCompra.NewITEM_COMPRARow();

                int linhasDeletadas = deletados.Rows.Count;
                for (int i = 0; i < linhasDeletadas; i++) {
                    itemCompraLinha.ITEM_COMPRA_CODIGO = (int)deletados.Rows[i][deletados.ITEM_COMPRA_CODIGOColumn, DataRowVersion.Original];
                    itemCompraSQL.deletar(itemCompraLinha);
                }

                itemCompraLinha.ITEM_COMPRA_COMPRA = (int)compra.COMPRA_CODIGO;

                int linhasInseridas = inseridos.Rows.Count;
                for (int i = 0; i < linhasInseridas; i++) {
                    itemCompraLinha.ITEM_COMPRA_QUANTIDADE = (short)inseridos.Rows[i][inseridos.ITEM_COMPRA_QUANTIDADEColumn, DataRowVersion.Current];
                    itemCompraLinha.ITEM_COMPRA_DESCONTO = (int)inseridos.Rows[i][inseridos.ITEM_COMPRA_DESCONTOColumn, DataRowVersion.Current];
                    itemCompraLinha.ITEM_COMPRA_PRECO = (int)inseridos.Rows[i][inseridos.ITEM_COMPRA_PRECOColumn, DataRowVersion.Current];
                    itemCompraLinha.ITEM_COMPRA_PRECO_TOTAL = (int)inseridos.Rows[i][inseridos.ITEM_COMPRA_PRECO_TOTALColumn, DataRowVersion.Current];
                    itemCompraLinha.ITEM_COMPRA_PRODUTO = (int)inseridos.Rows[i][inseridos.ITEM_COMPRA_PRODUTOColumn, DataRowVersion.Current];
                    itemCompraSQL.inserir(itemCompraLinha);
                }
        }

        public FbDataReader pesquisar(string coluna, string valor) {
            
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ");
            sql.Append("COMPRA_CODIGO, COMPRA_NOTA_FISCAL, FUNCIONARIO_NOME, COMPRA_TOTAL, COMPRA_DATA ");
            sql.Append("FROM FUNCIONARIO ");
            sql.Append("INNER JOIN COMPRA ");
            sql.Append("ON FUNCIONARIO_CODIGO = COMPRA_FUNCIONARIO ");
            sql.Append("WHERE " + coluna + " CONTAINING " + paramValor);

            FbCommand comando = new FbCommand(sql.ToString(), Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);

            return comando.ExecuteReader();
        }

        public void selecionar(
            int codigo,
            dsFROGIOS.COMPRADataTable compra,
            dsFROGIOS.ITEM_COMPRADataTable itemCompra,
            dsFROGIOS.FUNCIONARIODataTable funcionario,
            dsFROGIOS.FORNECEDORDataTable fornecedor,
            dsFROGIOS.FORNECEDOR_FISICODataTable fisico,
            dsFROGIOS.FORNECEDOR_JURIDICODataTable juridico) {

                TblFornecedor fornecedorSQL = new TblFornecedor();
                TblFornecedorFisico fisicoSQL = new TblFornecedorFisico();
                TblFornecedorJuridico juridicoSQL = new TblFornecedorJuridico();

                compra.Clear();
                TblCompra compraSQL = new TblCompra();
                compra.Load(
                    compraSQL.selecionar(
                        compra.COMPRA_CODIGOColumn.ColumnName,
                        codigo.ToString(),
                        true
                    )
                );

                dsFROGIOS.COMPRARow compraLinha = (dsFROGIOS.COMPRARow) compra.Rows[0];

                itemCompra.Clear();
                TblItemCompra itemCompraSQL = new TblItemCompra();
                itemCompra.Load(
                        itemCompraSQL.selecionar(
                            itemCompra.ITEM_COMPRA_COMPRAColumn.ColumnName,
                            codigo.ToString(),
                            true
                        )
                );

                fornecedor.Clear();
                fornecedor.Load(
                        fornecedorSQL.selecionar(
                            fornecedor.FORNECEDOR_CODIGOColumn.ColumnName,
                            compraLinha.COMPRA_FORNECEDOR.ToString(),
                            true
                        )
                    );

                fisico.Clear();
                fisico.Load(
                        fisicoSQL.selecionar(
                            fisico.FORNECEDOR_FISICO_FORNECEDORColumn.ColumnName,
                            compraLinha.COMPRA_FORNECEDOR.ToString(),
                            true
                        )
                    );

        }

        public void deletar(dsFROGIOS.COMPRARow compra) {
            TblCompra compraSQL = new TblCompra();
            compraSQL.deletar(compra);
            //Só basta deletar uma compra que seus itens vão embora
            //FK está com CASCADE DELETE
        }

    }
}
