using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapOS {

        private const string codigo = "Código";
        private const string nome = "Nome";
        private const string fantasia = "Fantasia";
        private const string telefone = "Telefone";
        private const string celular = "Celular";
        private const string funcionarioNome = "Funcionário";
        //private const string data = "Data";
        private const string status = "Status";

        private readonly string colunaCodigo;
        private readonly string colunaNome;
        private readonly string colunaFantasia;
        private readonly string colunaTelefone;
        private readonly string colunaCelular;
        private readonly string colunaFuncionario;
        //private readonly string colunaData;
        private readonly string colunaStatus;

        private readonly string[] colunasFisico;
        private readonly string[] colunasJuridico;

        public string[] ColunasFisico { get { return colunasFisico; } }
        public string[] ColunasJuridico { get { return colunasJuridico; } }

        public string Status { get { return status; } }

        public MapOS(dsFROGIOS.CLIENTEDataTable cliente, dsFROGIOS.CLIENTE_FISICODataTable fisico, dsFROGIOS.CLIENTE_JURIDICODataTable juridico, dsFROGIOS.FUNCIONARIODataTable funcionario, dsFROGIOS.OSDataTable os)
        {

            colunaCodigo = os.OS_CODIGOColumn.ColumnName;
            colunaNome = fisico.CLIENTE_FISICO_NOMEColumn.ColumnName;
            colunaFantasia = juridico.CLIENTE_JURIDICO_FANTASIAColumn.ColumnName;
            colunaTelefone = cliente.CLIENTE_TELEFONEColumn.ColumnName;
            colunaCelular = cliente.CLIENTE_CELULARColumn.ColumnName;
            colunaFuncionario = funcionario.FUNCIONARIO_NOMEColumn.ColumnName;
           // colunaData = os.OS_DATAColumn.ColumnName;
            colunaStatus = os.OS_STATUSColumn.ColumnName;

            colunasFisico = new string[] { 
                codigo,
                nome,
                telefone,
                celular,
                funcionarioNome,
             //   data,
                status
            };

            colunasJuridico = new string[] { 
                codigo,
                fantasia,
                telefone,
                celular,
                funcionarioNome,
               // data,
                status
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
                case status:
                    return colunaStatus;
                default:
                    return null;
            }
        }

    }
}