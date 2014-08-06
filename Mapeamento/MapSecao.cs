using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapSecao
    {

        private const string codigo = "Código";
        private const string descricao = "Descriação";

        private readonly string colunaCodigo;
        private readonly string colunaDescricao;

        private string[] colunas;

        public string[] Colunas { get { return colunas; } }

        public MapSecao(dsFROGIOS.SECAODataTable secao) {

            colunaCodigo = secao.SECAO_CODIGOColumn.ColumnName;
            colunaDescricao = secao.SECAO_DESCRICAOColumn.ColumnName;

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