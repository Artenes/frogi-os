using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapProduto
    {

        private const string codigo = "Código";
        private const string descricao = "Descrição";
        private const string marca = "Marca";
        private const string unidade = "Unidade";
        private const string preco = "Preço";
        private const string estoque = "Estoque";

        private readonly string colunaCodigo;
        private readonly string colunaDescricao;
        private readonly string colunaMarca;
        private readonly string colunaUnidade;
        private readonly string colunaPreco;
        private readonly string colunaEstoque;

        private readonly string[] colunas;

        public string[] Colunas { get { return colunas; } }

        public MapProduto(dsFROGIOS.PRODUTODataTable produto, dsFROGIOS.MARCADataTable produtoMarca) {

            colunaCodigo = produto.PRODUTO_CODIGOColumn.ColumnName;
            colunaDescricao = produto.PRODUTO_DESCRICAOColumn.ColumnName;
            colunaMarca = produtoMarca.MARCA_DESCRICAOColumn.ColumnName;
            colunaUnidade = produto.PRODUTO_UNIDADE_VENDAColumn.ColumnName;
            colunaPreco = produto.PRODUTO_ESTOQUE_ATUALColumn.ColumnName;
            colunaEstoque = produto.PRODUTO_ESTOQUE_ATUALColumn.ColumnName;

            colunas = new string[]{
                codigo,
                descricao,
                marca,
                unidade,
                preco,
                estoque
            };
        }

        public string paraColuna(string valor) {
            switch (valor)
            {
                case codigo:
                    return colunaCodigo;
                case descricao:
                    return colunaDescricao;
                case marca:
                    return colunaMarca;
                case unidade:
                    return colunaUnidade;
                case preco:
                    return colunaPreco;
                case estoque:
                    return colunaEstoque;
                default:
                    return null;
            }
        }
    }
}