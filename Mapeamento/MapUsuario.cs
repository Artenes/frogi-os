using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapUsuario
    {

        private const string codigo = "Código";
        private const string nome = "Nome";
        private const string categoria = "Categoria";

        private readonly string colunaCodigo;
        private readonly string colunaNome;
        private readonly string colunaCategoria;

        private string[] colunas;

        public string[] Colunas { get { return colunas; } }

        public MapUsuario(dsFROGIOS.USUARIODataTable usuario) {

            colunaCodigo = usuario.USUARIO_CODIGOColumn.ColumnName;
            colunaNome = usuario.USUARIO_NOMEColumn.ColumnName;
            colunaCategoria = usuario.USUARIO_CATEGORIAColumn.ColumnName;

            colunas = new string[] { 
                codigo,
                nome
                //categoria
            };
        
        }

        public string paraColuna(string valor) {
            switch (valor)
            {
                case codigo:
                    return colunaCodigo;
                case nome:
                    return colunaNome;
                case categoria:
                    return colunaCategoria;
                default:
                    return null;
            }
        }

    }
}
