using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapMarca
    {

        private const string codigo = "Código";
        private const string descricao = "Descrição";

        private readonly string colunaCodigo;
        private readonly string colunaDescricao;

        private string[] colunas;

        public string[] Colunas { get { return colunas; } }

        public MapMarca(dsFROGIOS.MARCADataTable marca) {

            colunaCodigo = marca.MARCA_CODIGOColumn.ColumnName;
            colunaDescricao = marca.MARCA_DESCRICAOColumn.ColumnName;

            colunas = new string[]{
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
