using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapGrupo
    {

        private const string codigo = "Código";
        private const string descricao = "Descrição";
        //private const string desconto = "Desconto";

        private readonly string colunaCodigo;
        private readonly string colunaDescricao;
        //private readonly string colunaDesconto;

        private readonly string[] colunas;

        public string[] Colunas { get { return colunas; } }

        public MapGrupo(dsFROGIOS.GRUPODataTable grupo) {

            colunaCodigo = grupo.GRUPO_CODIGOColumn.ColumnName;
            colunaDescricao = grupo.GRUPO_DESCRICAOColumn.ColumnName;
            //colunaDesconto = grupo.GRUPO_DESCONTOColumn.ColumnName;

            colunas = new string[] { 
                codigo,
                descricao
            };
        }

        public string paraColuna(string valor) {
            switch (valor)
            {
                case codigo:
                    return colunaCodigo;
                case descricao:
                    return colunaDescricao;
                default:
                    return null;
            }
        }

    }
}
