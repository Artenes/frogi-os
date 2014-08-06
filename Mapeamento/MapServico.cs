using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapServico
    {

        private const string codigo = "Código";
        private const string descricao = "Descrição";
        private const string valor = "Valor";

        private readonly string colunaCodigo;
        private readonly string colunaDescricao;
        private readonly string colunaValor;

        private readonly string[] colunas;

        public string[] Colunas { get { return colunas; } }

        public MapServico(dsFROGIOS.SERVICODataTable servico) {

            colunaCodigo = servico.SERVICO_CODIGOColumn.ColumnName;
            colunaDescricao = servico.SERVICO_DESCRICAOColumn.ColumnName;
            colunaValor = servico.SERVICO_VALORColumn.ColumnName;

            colunas = new string[] { 
                codigo,
                descricao,
                valor
            };

        }

        public string paraColuna(string coluna) {
            switch (coluna)
            {
                case codigo:
                    return colunaCodigo;
                case descricao:
                    return colunaDescricao;
                case valor:
                    return colunaValor;
                default:
                    return null;
            }
        }

    }
}