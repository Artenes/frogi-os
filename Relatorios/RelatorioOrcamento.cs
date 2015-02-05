using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Relatorios
{
    public class RelatorioOrcamento
    {

        private String nomeCliente;
        private String enderecoCliente;
        private String foneCliente;
        private Int32 codigoOrcamento;
        private Int32 codigoCliente;
        private Double total;
        private List<RelatorioItens> itens;
        private DateTime data;

        public RelatorioOrcamento() {}

        public RelatorioOrcamento(String nomeCliente, String enderecoCliente, String foneCliente, Int32 codigoOrcamento, Int32 codigoCliente, Double total, List<RelatorioItens> itens, DateTime data) {
            this.nomeCliente = nomeCliente;
            this.enderecoCliente = enderecoCliente;
            this.foneCliente = foneCliente;
            this.codigoOrcamento = codigoOrcamento;
            this.codigoCliente = codigoCliente;
            this.total = total;
            this.itens = itens;
            this.data = data;
        }

        public String NomeCliente {
            get {
                return this.nomeCliente;
            }

            set {
                this.nomeCliente = value;
            }
        }

        public String EnderecoCliente {
            get {
                return this.enderecoCliente;
            }

            set {
                this.enderecoCliente = value;
            }
        }

        public String FoneCliente {
            get {
                return this.foneCliente;
            }

            set {
                this.foneCliente = value;
            }
        }

        public Int32 CodigoOrcamento {
            get {
                return this.codigoOrcamento;
            }

            set {
                this.codigoOrcamento = value;
            }
        }

        public Int32 CodigoCliente {
            get {
                return this.codigoCliente;
            }
            set {
                this.codigoCliente = value;
            }
        }

        public Double Total {
            get { 
                return this.total; 
            }
            set {
                this.total = value;
            }
        }

        public List<RelatorioItens> Itens {
            get {
                return this.itens;
            }
            set {
                this.itens = value;
            }
        }

        public DateTime Data {
            get {
                return this.data;
            }
            set {
                this.data = value;
            }
        }
    }
}