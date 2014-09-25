using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formCadastroUsuario : formCadastro {
        public formCadastroUsuario(bool pesquisaHabilitado) : base(pesquisaHabilitado) {
            InitializeComponent();
            pesquisa = null;
        }

        protected override void novoRegistro(){
            base.novoRegistro();
            this.ActiveControl = uSUARIO_NOMETextBox;
        }

        protected override void salvaExecutar() {
            
        }

        protected override void excluiExecutar() {
            
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            this.ActiveControl = uSUARIO_NOMETextBox;
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.USUARIO.Clear();    
            }
        }

        protected override void campos(bool estaDisponivel) {
            base.campos(estaDisponivel);
        }

        protected override string validarCampos() {
            return base.validarCampos();
        }

        protected override void visualizarRegistroExecutar(int codigo)
        {
            base.visualizarRegistroExecutar(codigo);
        }
    }
}
