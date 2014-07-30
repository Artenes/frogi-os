using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FROGI_OS.CamadaAcessoDados;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaEnlaceDados
{
    class GerUsuario {

        private TblUsuario sqlUsuario;
        private TblPermissao sqlPermissao;

        public GerUsuario() {
            sqlPermissao = new TblPermissao();
            sqlUsuario = new TblUsuario();
        }

        public void inserir(dsFROGIOS.USUARIORow usuario, dsFROGIOS.PERMISSAORow permissao) {
            int codigo = sqlUsuario.inserir(usuario);
            permissao.PERMISSAO_USUARIO = codigo;
            sqlPermissao.inserir(permissao);
        }
        public void atualizar(dsFROGIOS.USUARIORow usuario, dsFROGIOS.PERMISSAORow permissao) {
            sqlUsuario.atualizar(usuario);
            sqlPermissao.atualizar(permissao);
        }
        
        public void selecionar(int codigo, dsFROGIOS.USUARIODataTable usuario, dsFROGIOS.PERMISSAODataTable permissao) {
            usuario.Clear();
            usuario.Load(sqlUsuario.selecionar(usuario.USUARIO_CODIGOColumn.ColumnName, codigo.ToString(), true));

            permissao.Clear();
            permissao.Load(sqlPermissao.selecionar(permissao.PERMISSAO_USUARIOColumn.ColumnName, codigo.ToString(), true));
        }
        public void deletar(dsFROGIOS.USUARIORow usuario) {
            sqlUsuario.deletar(usuario);
            //FK é DELETE CASCADE
            //Não precisa informar a permissão a ser deletada
        }

    }
}
