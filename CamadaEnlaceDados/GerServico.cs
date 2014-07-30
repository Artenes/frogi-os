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

                dsFROGIOS.TIPODataTable deletados =
                    (dsFROGIOS.TIPODataTable) tipos.GetChanges(DataRowState.Deleted);
                dsFROGIOS.TIPODataTable inseridos =
                    (dsFROGIOS.TIPODataTable)tipos.GetChanges(DataRowState.Added);

                TblServicoTipo servicoTipoSQL = new TblServicoTipo();

                dsFROGIOS.SERVICO_TIPODataTable servicoTipo = 
                    new dsFROGIOS.SERVICO_TIPODataTable();
                dsFROGIOS.SERVICO_TIPORow servicoTipoLinha = servicoTipo.NewSERVICO_TIPORow();
                servicoTipoLinha.SERVICO_TIPO_SERVICO = servico.SERVICO_CODIGO;

                int linhasDeletadas = deletados.Rows.Count;
                for (int i = 0; i < linhasDeletadas; i++) {
                    servicoTipoLinha.SERVICO_TIPO_TIPO =
                        (int)deletados.Rows[i][deletados.TIPO_CODIGOColumn, DataRowVersion.Original];
                    servicoTipoSQL.deletar(servicoTipoLinha);
                }
                
                int linhasInseridas = inseridos.Rows.Count;
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
