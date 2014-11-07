using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapOrcamento
    {

        private const string codigo = "Código";
        private const string nome = "Nome";
        private const string fantasia = "Fantasia";
        private const string telefone = "Telefone";
        private const string celular = "Celular";
        private const string funcionarioNome = "Funcionário";
        //private const string data = "Data";

        private readonly string colunaCodigo;
        private readonly string colunaNome;
        private readonly string colunaFantasia;
        private readonly string colunaTelefone;
        private readonly string colunaCelular;
        private readonly string colunaFuncionario;
        //private readonly string colunaData;

        private readonly string[] colunasFisico;
        private readonly string[] colunasJuridico;

        public string[] ColunasFisico { get { return colunasFisico; } }
        public string[] ColunasJuridico { get { return colunasJuridico; } }

        public MapOrcamento(dsFROGIOS.CLIENTEDataTable cliente, dsFROGIOS.CLIENTE_FISICODataTable fisico, dsFROGIOS.CLIENTE_JURIDICODataTable juridico, dsFROGIOS.FUNCIONARIODataTable funcionario, dsFROGIOS.ORCAMENTODataTable orcamento)
        {

            colunaCodigo = orcamento.ORCAMENTO_CODIGOColumn.ColumnName;
            colunaNome = fisico.CLIENTE_FISICO_NOMEColumn.ColumnName;
            colunaFantasia = juridico.CLIENTE_JURIDICO_FANTASIAColumn.ColumnName;
            colunaTelefone = cliente.CLIENTE_TELEFONEColumn.ColumnName;
            colunaCelular = cliente.CLIENTE_CELULARColumn.ColumnName;
            colunaFuncionario = funcionario.FUNCIONARIO_NOMEColumn.ColumnName;
          //  colunaData = orcamento.ORCAMENTO_DATAColumn.ColumnName;

            colunasFisico = new string[] { 
                codigo,
                nome,
                telefone,
                celular,
                funcionarioNome
                //data
            };

            colunasJuridico = new string[] { 
                codigo,
                fantasia,
                telefone,
                celular,
                funcionarioNome
                //data
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
                case fantasia:
                    return colunaFantasia;
                case telefone:
                    return colunaTelefone;
                case celular:
                    return colunaCelular;
                case funcionarioNome:
                    return colunaFuncionario;
                //case data:
                  //  return colunaData;
                default:
                    return null;
            }
        }

    }
}