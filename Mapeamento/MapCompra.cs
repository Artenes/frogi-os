using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapCompra {

        private const string codigo = "Código";
        private const string notaFiscal = "Nota fiscal";
        private const string total = "Total";
        private const string data = "Data";

        private readonly string colunaCodigo;
        private readonly string colunaNotaFiscal;
        private readonly string colunaTotal;
        private readonly string colunaData;

        private readonly string[] colunas;

        public string[] Colunas { get { return colunas; } }

        public MapCompra(dsFROGIOS.COMPRADataTable compra) {

            colunaCodigo = compra.COMPRA_CODIGOColumn.ColumnName;
            colunaNotaFiscal = compra.COMPRA_NOTA_FISCALColumn.ColumnName;
            colunaTotal = compra.COMPRA_TOTALColumn.ColumnName;
            colunaData = compra.COMPRA_DATAColumn.ColumnName;

            colunas = new string[] { 
                codigo,
                notaFiscal,
                total,
                data
            };

        }

        public string paraColuna(string valor) {
            switch (valor)
            {
                case codigo:
                    return colunaCodigo;
                case notaFiscal:
                    return colunaNotaFiscal;
                case total:
                    return colunaTotal;
                case data:
                    return colunaData;
                default:
                    return null;
            }
            
        }

    }
}