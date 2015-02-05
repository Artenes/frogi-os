using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Relatorios
{
    public class RelatorioItens
    {

        private String discriminacao;
        private Double valorUnitario;
        private Double valorTotal;

        public RelatorioItens() { }

        public RelatorioItens(String discriminacao, Double valorUnitario, Double valorTotal)
        {
            this.discriminacao = discriminacao;
            this.valorUnitario = valorUnitario;
            this.valorTotal = valorTotal;
        }

        public String Discriminacao
        {
            get
            {
                return this.discriminacao;
            }
            set
            {
                this.discriminacao = value;
            }
        }

        public Double ValorUnitario
        {
            get
            {
                return this.valorUnitario;
            }
            set
            {
                this.valorUnitario = value;
            }
        }

        public Double ValorTotal
        {
            get
            {
                return this.valorTotal;
            }
            set
            {
                this.valorTotal = value;
            }
        }

    }
}
