using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FROGI_OS.CamadaAcessoDados;

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formCadastroUsuario : formCadastro {

        private TblUsuario usuarioSQL;

        public formCadastroUsuario(bool pesquisaHabilitado) : base(pesquisaHabilitado) {
            InitializeComponent();
            pesquisa = pesquisaHabilitado ? new formPesquisaUsuario(this, false) : null;
            usuarioSQL = new TblUsuario();
        }

        protected override void novoRegistro(){
            base.novoRegistro();
            this.ActiveControl = uSUARIO_NOMETextBox;
        }

        protected override void salvaExecutar() {
            if (dsFROGIOS.USUARIO.Rows.Count == 0) {
                usuarioSQL.inserir(pegarValorCamposUsuario(null));
            } else {
                object codigo = ((dsFROGIOS.USUARIORow)dsFROGIOS.USUARIO.Rows[0]).USUARIO_CODIGO;
                usuarioSQL.atualizar(pegarValorCamposUsuario(codigo));
            }
        }

        private dsFROGIOS.USUARIORow pegarValorCamposUsuario(object codigo) {
            dsFROGIOS.USUARIORow usuarioRow = dsFROGIOS.USUARIO.NewUSUARIORow();
            if (codigo != null) {
                usuarioRow.USUARIO_CODIGO = (int)codigo;
                usuarioRow.USUARIO_DATA_CADASTRO = ((dsFROGIOS.USUARIORow)dsFROGIOS.USUARIO.Rows[0]).USUARIO_DATA_CADASTRO;
            } else {
                usuarioRow.USUARIO_DATA_CADASTRO = DateTime.Now;
            }
            usuarioRow.USUARIO_NOME = uSUARIO_NOMETextBox.Text;
            usuarioRow.USUARIO_SENHA = uSUARIO_SENHATextBox.Text;
            usuarioRow.USUARIO_CATEGORIA = radioAdministrador.Checked ? 0 : 1;
            return usuarioRow;
        }

        protected override void excluiExecutar() {
            usuarioSQL.deletar((dsFROGIOS.USUARIORow)dsFROGIOS.USUARIO.Rows[0]);
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            this.ActiveControl = uSUARIO_NOMETextBox;
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.USUARIO.Clear();
                radioFuncionario.Checked = false;
                radioAdministrador.Checked = false;
            }
        }

        protected override void campos(bool estaDisponivel) {
            base.campos(estaDisponivel);
        }

        protected override string validarCampos() {
            string 
                nome = uSUARIO_NOMETextBox.Text,
                senha = uSUARIO_SENHATextBox.Text;
            if (!valorValido(nome)) return "Informe o nome do usuário";
            if (!valorValido(senha)) return "Informe uma senha para o usuário";
            if ((!radioAdministrador.Checked) && (!radioFuncionario.Checked)) return "Informe o tipo de usuário";
            return base.validarCampos();
        }

        protected override void visualizarRegistroExecutar(int codigo) {
            string coluna = dsFROGIOS.USUARIO.USUARIO_CODIGOColumn.ColumnName;
            string valor;
            try {valor = Convert.ToString(codigo);} catch (Exception) {valor = "-5";}
            dsFROGIOS.USUARIO.Load(usuarioSQL.selecionar(coluna, valor, true));
            if ((dsFROGIOS.USUARIO.Rows[0] as dsFROGIOS.USUARIORow).USUARIO_CATEGORIA == 0) {
                radioAdministrador.Checked = true;
            } else {
                radioFuncionario.Checked = true;
            }
        }
    }
}
