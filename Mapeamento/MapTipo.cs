using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapTipo
    {

        private const string codigo = "Código";
        private const string descricao = "Descrição";

        private readonly string colunaCodigo;
        private readonly string colunaDescricao;

        private string[] colunas;

        public string[] Colunas { get { return colunas; } }

        public MapTipo(dsFROGIOS.TIPODataTable tipo) {

            colunaCodigo = tipo.TIPO_CODIGOColumn.ColumnName;
            colunaDescricao = tipo.TIPO_DESCRICAOColumn.ColumnName;

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
