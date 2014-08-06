using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapFuncionario
    {

        private const string codigo = "Código";
        private const string nome = "Nome";
        private const string cpf = "CPF";
        private const string telefone = "Telefone";
        private const string endereco = "Endereço";
        private const string bairro = "Bairro";

        private readonly string colunaCodigo;
        private readonly string colunaNome;
        private readonly string colunaCpf;
        private readonly string colunaTelefone;
        private readonly string colunaEndereco;
        private readonly string colunaBairro;

        private string[] colunas;

        public string[] Colunas { get { return colunas; } }

        public MapFuncionario(dsFROGIOS.FUNCIONARIODataTable funcionario) {

            colunaCodigo = funcionario.FUNCIONARIO_CODIGOColumn.ColumnName;
            colunaNome = funcionario.FUNCIONARIO_NOMEColumn.ColumnName;
            colunaCpf = funcionario.FUNCIONARIO_CPFColumn.ColumnName;
            colunaTelefone = funcionario.FUNCIONARIO_TELEFONEColumn.ColumnName;
            colunaEndereco = funcionario.FUNCIONARIO_ENDERECOColumn.ColumnName;
            colunaBairro = funcionario.FUNCIONARIO_BAIRROColumn.ColumnName;

            colunas = new string[] { 
                codigo,
                nome,
                cpf,
                telefone,
                endereco,
                bairro
            };

        }

        public string paraColuna(string valor) {
            switch (valor)
            {
             
                case codigo:
                    return colunaCodigo;
                case nome:
                    return colunaNome;
                case cpf:
                    return colunaCpf;
                case telefone:
                    return colunaTelefone;
                case endereco:
                    return colunaEndereco;
                case bairro:
                    return colunaBairro;
                default:
                    return null;
            }
        }

    }
}
