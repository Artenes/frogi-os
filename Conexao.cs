using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS {
    public static class Conexao {

        private static FbConnection conexao;
        private static FbTransaction transacao;

        private static string stringConexao = System.Configuration.ConfigurationManager.ConnectionStrings["FROGI_OS.Properties.Settings.csBancoDados"].ConnectionString;    

        public static FbConnection getConexao {
            get { return conexao; }
        }

        public static FbTransaction getTransacao {
            get { return transacao;  }
        }

        public static bool abrir () {
            conexao = new FbConnection(stringConexao);
            conexao.Open();
            transacao = conexao.BeginTransaction();
            return true;
        }

        public static bool fechar() {
            if (conexao != null) {
                if (conexao.State == System.Data.ConnectionState.Open) {
                    transacao.Dispose();
                    conexao.Close();
                    return true;
                } 
            } 
            return false;
        }

    }
}
