using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2 {
    class Monetario : TextBox {

        public Monetario() : base() {
            this.TextAlign = HorizontalAlignment.Right;
        }

        // String usada para manipular o valor 
        private string str = "";
        private bool teclaNumericaPressionada = false;

        protected override void OnKeyDown(KeyEventArgs e) {
            TextBox txtBox = (TextBox)this;
            Control controle = txtBox;
            str = RetiraVirgula(str);
            //captura a tecla precionada
            int KeyCode = e.KeyValue;
            //testa pra ve se a tecla foi um numero ou backspace ou delete
            if (!IsNumeric(KeyCode) && !eLetra(KeyCode) || ReadOnly) {
                teclaNumericaPressionada = true;
                return;
            } else {
                teclaNumericaPressionada = true;
            }
            if (((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0)) {
                //apaga o campo caso seja precionado backspace ou delete quando o campo esta maior que 0
                str = str.Substring(0, str.Length - 1);
            } else if (!((KeyCode == 8) || (KeyCode == 46))) {

                // convert o codigo da tabela ascii para o seu valor numerico
                if ((KeyCode >= 48 && KeyCode <= 57)) {
                    str = str + Convert.ToChar(KeyCode);
                }
                    //leve gambiarra pra fazer funcionar a captura do teclado numerico
                else if ((KeyCode >= 96 && KeyCode <= 105)) {
                    str = str + Convert.ToChar(KeyCode - 48);
                }
            }

            if (str.Length == 0) {
                controle.Text = "";
            }

            if (str.Length == 1) {
                //adiciona "," na mascara
                controle.Text = Convert.ToDecimal("0,0" + str).ToString("C");
            } else if (str.Length == 2) {
                //adiciona "," na mascara
                controle.Text = Convert.ToDecimal("0," + str).ToString("C");
            } else if (str.Length > 2) {
                //adiciona "," na mascara
                controle.Text = Convert.ToDecimal(str.Substring(0, str.Length - 2) + "," + str.Substring(str.Length - 2)).ToString("C");
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e) {
            e.Handled = teclaNumericaPressionada;
        }

        //testa o codigo da tecla pra ver se é numero ou nao
        private bool IsNumeric(int Val) {
            return ((Val >= 48 && Val <= 57) || (Val >= 96 && Val <= 105) || (Val == 8) || (Val == 46));
        }

        private bool eLetra(int tecla) {
            return (tecla >= 65 && tecla <= 90);
        }

        // função para retirar virgula de uma string
        public String RetiraVirgula(String val) {
            String[] vetor;
            String valor;
            if (val.Contains(',')) {
                vetor = val.Split(',');
                if (vetor[1].Length == 1) {
                    vetor[1] = vetor[1] + "0";
                }
                valor = vetor[0] + vetor[1];
                return valor;
            } else {
                valor = val;
                return valor;
            }
        }
        // retorna o valor sem o R$ em formato double
        private double retornaValor() {
            String a = base.Text;
            try {
                a = a.Substring(2, a.Length - 2);
            } catch (Exception) {
                a = "0";
            }
            return Convert.ToDouble(a);
        }

        public double Valor {
            get { return retornaValor(); }
            set { insereValor(value.ToString()); }
        }

        //função para inserir valor via TEXT
        private void insereValor(String valor) {
            if (valor.Contains(',')) {
                valor = RetiraVirgula(valor);
            } else {
                valor += "00";
            }

            if (valor.Length == 0) {
                valor = "";
            }

            if (valor.Length == 1) {
                //adiciona "," na mascara
                valor = Convert.ToDouble("0,0" + valor).ToString("C");
            } else if (valor.Length == 2) {
                //adiciona "," na mascara
                valor = Convert.ToDouble("0," + valor).ToString("C");
            } else if (valor.Length > 2) {
                //adiciona "," na mascara
                valor = Convert.ToDouble(valor.Substring(0, valor.Length - 2) + "," + valor.Substring(valor.Length - 2)).ToString("C");
            }
            base.Text = valor;
            str = RetiraVirgula(valor);
            str = Convert.ToString(retornaValor());
        }
    }
}