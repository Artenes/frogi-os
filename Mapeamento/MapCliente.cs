using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapCliente
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

        public MapCliente(dsFROGIOS.CLIENTEDataTable cliente, dsFROGIOS.CLIENTE_FISICODataTable fisico, dsFROGIOS.CLIENTE_JURIDICODataTable juridico)
        {
            colunaCodigo = cliente.CLIENTE_CODIGOColumn.ColumnName;
            colunaNome = fisico.CLIENTE_FISICO_NOMEColumn.ColumnName;
            colunaCpf = fisico.CLIENTE_FISICO_CPFColumn.ColumnName;
            colunaFantasia = juridico.CLIENTE_JURIDICO_FANTASIAColumn.ColumnName;
            colunaCnpj = juridico.CLIENTE_JURIDICO_CNPJColumn.ColumnName;
            colunaTelefone = cliente.CLIENTE_TELEFONEColumn.ColumnName;
            colunaCelular = cliente.CLIENTE_CELULARColumn.ColumnName;
            colunaEndereco = cliente.CLIENTE_ENDERECOColumn.ColumnName;
            colunaBairro = cliente.CLIENTE_BAIRROColumn.ColumnName;
            colunaCidade = cliente.CLIENTE_CIDADEColumn.ColumnName;

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

        public string paraColuna(string valor) {
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