using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FROGI_OS.CamadaAcessoDados;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace FROGI_OS.CamadaEnlaceDados {
    class GerServico {

        public void inserir(
            dsFROGIOS.SERVICORow servico,
            dsFROGIOS.TIPODataTable tipos) {

                TblServico servicoSQL = new TblServico();
                int codigo = servicoSQL.inserir(servico);

                TblServicoTipo servicoTipoSQL = new TblServicoTipo();
                dsFROGIOS.SERVICO_TIPORow servicoTipoLinha = new dsFROGIOS.SERVICO_TIPODataTable().NewSERVICO_TIPORow();

                foreach (dsFROGIOS.TIPORow tipo in tipos.Rows) {
                    servicoTipoLinha.SERVICO_TIPO_SERVICO = codigo;
                    servicoTipoLinha.SERVICO_TIPO_TIPO = tipo.TIPO_CODIGO;
                    servicoTipoSQL.inserir(servicoTipoLinha);
                }
        }

        public void atualizar(
            dsFROGIOS.SERVICORow servico,
            dsFROGIOS.TIPODataTable tipos
            ) {

                TblServico servicoSQL = new TblServico();
                servicoSQL.atualizar(servico);

                dsFROGIOS.TIPODataTable deletados = new dsFROGIOS.TIPODataTable();
                dsFROGIOS.TIPODataTable inseridos = new dsFROGIOS.TIPODataTable();

                /*
                 * Essa foi puta merda. Tava usando um método GetChanges da 
                 * classe DataTable. Esse método já me retornava um DataTable
                 * todo arrumadinho já com as linhas novas ou excluidas. Mas
                 * por problemas de constraint, tive que adotar essa
                 * pequena solução manual. Funciona assim também :)
                 */ 
                //Mas sério XP

                //Aqui pegamos todas as linhas que foram inseridas ou excluidas
                //o que foi inserido vai ser inserido e o que foi excluido vai ser excluido do BD
                foreach (dsFROGIOS.TIPORow linha in tipos.Rows) {
                    if (linha.RowState == DataRowState.Added) {
                        inseridos.AddTIPORow(linha.TIPO_CODIGO, linha.TIPO_DESCRICAO);
                    } /*else if (linha.RowState == DataRowState.Deleted) {
                        deletados.AddTIPORow(linha.TIPO_CODIGO, linha.TIPO_DESCRICAO);
                    }*/
                }
                deletados = (dsFROGIOS.TIPODataTable)tipos.GetChanges(DataRowState.Deleted);


                TblServicoTipo servicoTipoSQL = new TblServicoTipo();

                dsFROGIOS.SERVICO_TIPODataTable servicoTipo =  new dsFROGIOS.SERVICO_TIPODataTable();
                dsFROGIOS.SERVICO_TIPORow servicoTipoLinha = servicoTipo.NewSERVICO_TIPORow();
                servicoTipoLinha.SERVICO_TIPO_SERVICO = servico.SERVICO_CODIGO;

                int linhasDeletadas = (deletados != null) ? deletados.Rows.Count : 0;
                for (int i = 0; i < linhasDeletadas; i++) {
                    servicoTipoLinha.SERVICO_TIPO_TIPO =
                        (int)deletados.Rows[i][deletados.TIPO_CODIGOColumn, DataRowVersion.Original];
                    servicoTipoSQL.deletar(servicoTipoLinha);
                }
                
                int linhasInseridas = (inseridos != null) ? inseridos.Rows.Count : 0;
                for (int i = 0; i < linhasInseridas; i++) {
                    servicoTipoLinha.SERVICO_TIPO_TIPO =
                        (int)inseridos.Rows[i][inseridos.TIPO_CODIGOColumn, DataRowVersion.Current];
                    servicoTipoSQL.inserir(servicoTipoLinha);
                }
        }

        public void selecionar(int codigo, dsFROGIOS.SERVICODataTable servico, dsFROGIOS.TIPODataTable tipo) {
            servico.Clear();
            TblServico servicoSQL = new TblServico();
            servico.Load(servicoSQL.selecionar(
                servico.SERVICO_CODIGOColumn.ColumnName,
                codigo.ToString(),
                true)
            );
            tipo.Clear();
            string sql = 
                "SELECT * "
            +"FROM SERVICO_TIPO "
            +"INNER JOIN TIPO "
            +"ON SERVICO_TIPO_TIPO = TIPO_CODIGO "
            +"WHERE SERVICO_TIPO_SERVICO = " + codigo.ToString();
            FbCommand comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            tipo.Load(comando.ExecuteReader());
        }

        public void deletar(dsFROGIOS.SERVICORow servico) {
            TblServico servicoSQL = new TblServico();
            servicoSQL.deletar(servico);
            //No banco de dados, todas as chaves estrangeiras estão com CASCADE DELETE
            //Logo só basta deletar o registro pai que os registros filhos serão deletados
        }

    }
}
