using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FROGI_OS {
    public partial class formDialogo : Form {

        public formDialogo() {
            InitializeComponent();
            defineLargura();
        }

        public formDialogo(string titulo, string mensagem, TipoExpressao expressao) {
            InitializeComponent();
            compor(titulo, mensagem, expressao);
            defineLargura();
        }

        private void defineLargura() {
            int largura = Screen.PrimaryScreen.Bounds.Width;
            int altura = 400;
            this.Size = new Size(largura, altura);
        }

        public void setTitulo (string titulo) {
            labelTitulo.Text = titulo;
        }

        public void setMensagem(string mensagem) {
            labelDescricao.Text = mensagem;
        }

        public void setExpressao(TipoExpressao expr) {
            labelExpressao.Text = expressao(expr);
            if (expr == TipoExpressao.AvisoFeliz || expr == TipoExpressao.AvisoTriste) {
                buttonNao.Visible = false;
                buttonSim.Text = "OK";
                buttonSim.DialogResult = DialogResult.OK;
            }
            else {
                buttonNao.Visible = true;
                buttonSim.Text = "Sim";
                buttonSim.DialogResult = DialogResult.Yes;
            }
        }

        public void compor(string titulo, string mensagem, TipoExpressao expressao) {
            setTitulo(titulo);
            setMensagem(mensagem);
            setExpressao(expressao);
        }

        public enum TipoExpressao { 
            Pergunta,
            AvisoFeliz,
            AvisoTriste
        }

        private string expressao (TipoExpressao exp) {
            switch (exp) {
                case TipoExpressao.Pergunta:
                    return ":-/";
                case TipoExpressao.AvisoFeliz:
                    return ":-)";
                case TipoExpressao.AvisoTriste:
                    return ":-(";
                default:
                    return ":-|";
            }
        }
    }
}
