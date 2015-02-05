using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS.Relatorios
{
    public class RelatorioOrdemServico
    {

        private String nomeCliente;
        private String enderecoCliente;
        private String foneCliente;
        private Int32 codigoOS;
        private Int32 codigoCliente;
        private Double total;
        private List<RelatorioItens> itens;
        private DateTime data;
        private DateTime dataEntrega;

        public RelatorioOrdemServico() {}

        public RelatorioOrdemServico(String nomeCliente, String enderecoCliente, String foneCliente, Int32 codigoOS, Int32 codigoCliente, Double total, List<RelatorioItens> itens, DateTime data, DateTime dataEntrega) {
            this.nomeCliente = nomeCliente;
            this.enderecoCliente = enderecoCliente;
            this.foneCliente = foneCliente;
            this.codigoOS = codigoOS;
            this.codigoCliente = codigoCliente;
            this.total = total;
            this.itens = itens;
            this.data = data;
            this.dataEntrega = dataEntrega;
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

        public Int32 CodigoOS {
            get {
                return this.codigoOS;
            }

            set {
                this.codigoOS = value;
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

        public DateTime DataEntrega {
            get {
                return this.dataEntrega;
            }
            set {
                this.dataEntrega = value;
            }
        }
    }
}