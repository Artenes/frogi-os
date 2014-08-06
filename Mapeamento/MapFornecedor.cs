using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapFornecedor
    {

        private const string codigo = "Código";
        private const string nome = "Nome";
        private const string cpf = "CPF";
        private const string fantasia = "Fantasia";
        private const string cnpj = "CNPJ";
        private const string telefone = "Telefone";
        private const string celular = "Celular";
        private const string endereco = "Endereço";
        private const string bairro = "Bairro";
        private const string cidade = "Cidade";

        private readonly string colunaCodigo;
        private readonly string colunaNome;
        private readonly string colunaCpf;
        private readonly string colunaFantasia;
        private readonly string colunaCnpj;
        private readonly string colunaTelefone;
        private readonly string colunaCelular;
        private readonly string colunaEndereco;
        private readonly string colunaBairro;
        private readonly string colunaCidade;

        private readonly String[] colunasFisico;
        private readonly String[] colunasJuridico;

        public String[] ColunasFisico { get { return colunasFisico; } }
        public String[] ColunasJuridico { get { return colunasJuridico; } }

        public MapFornecedor(dsFROGIOS.FORNECEDORDataTable fornecedor, dsFROGIOS.FORNECEDOR_FISICODataTable fisico, dsFROGIOS.FORNECEDOR_JURIDICODataTable juridico) {

            colunaCodigo = fornecedor.FORNECEDOR_CODIGOColumn.ColumnName;
            colunaNome = fisico.FORNECEDOR_FISICO_NOMEColumn.ColumnName;
            colunaCpf = fisico.FORNECEDOR_FISICO_CPFColumn.ColumnName;
            colunaFantasia = juridico.FORNECEDOR_JURIDICO_FANTASIAColumn.ColumnName;
            colunaCnpj = juridico.FORNECEDOR_JURIDICO_CNPJColumn.ColumnName;
            colunaTelefone = fornecedor.FORNECEDOR_TELEFONEColumn.ColumnName;
            colunaCelular = fornecedor.FORNECEDOR_CELULARColumn.ColumnName;
            colunaEndereco = fornecedor.FORNECEDOR_ENDERECOColumn.ColumnName;
            colunaBairro = fornecedor.FORNECEDOR_BAIRROColumn.ColumnName;
            colunaCidade = fornecedor.FORNECEDOR_CIDADEColumn.ColumnName;

            colunasFisico = new String[] { 
                codigo,
                nome,
                cpf,
                telefone,
                celular,
                endereco,
                bairro,
                cidade
            };

            colunasJuridico = new String[]{
                codigo,
                fantasia,
                cnpj,
                telefone,
                celular,
                endereco,
                bairro,
                cidade
            };

        }

        public string paraColuna(string valor)
        {
            switch (valor)
            {
                case codigo:
                    return colunaCodigo;
                case nome:
                    return colunaNome;
                case cpf:
                    return colunaCpf;
                case fantasia:
                    return colunaFantasia;
                case cnpj:
                    return colunaCnpj;
                case telefone:
                    return colunaTelefone;
                case celular:
                    return colunaCelular;
                case endereco:
                    return colunaEndereco;
                case bairro:
                    return colunaBairro;
                case cidade:
                    return colunaCidade;
                default:
                    return null;
            }
        }

    }
}
