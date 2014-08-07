using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Mapeamento
{
    class MapAgendamento
    {

        private const string codigo = "Código";
        private const string nome = "Nome";
        private const string fantasia = "Fantasia";

        private readonly string colunaCodigo;
        private readonly string colunaNome;
        private readonly string colunaFantasia;

        private string[] colunasFisico;
        private string[] colunasJuridico;

        public string[] ColunasFisico { get { return colunasFisico; } }
        public string[] ColunasJuridico { get { return colunasJuridico; } }

        public MapAgendamento(dsFROGIOS.CLIENTE_FISICODataTable fisico, dsFROGIOS.CLIENTE_JURIDICODataTable juridico, dsFROGIOS.AGENDAMENTODataTable agendamento) {

            colunaCodigo = agendamento.AGEN_CODIGOColumn.ColumnName;
            colunaNome = fisico.CLIENTE_FISICO_NOMEColumn.ColumnName;
            colunaFantasia = juridico.CLIENTE_JURIDICO_FANTASIAColumn.ColumnName;

            colunasFisico = new string[]{
                codigo,
                nome
            };

            colunasJuridico = new string[] { 
                codigo,
                fantasia
            };

        }

        public string paraColuna(string valor) {
            switch (valor)
            {
                case codigo:
                    return colunaCodigo;
                case nome:
                    return colunaNome;
                case fantasia:
                    return colunaFantasia;
                default:
                    return null;
            }
        }
    }
}