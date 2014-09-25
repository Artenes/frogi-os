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

namespace FROGI_OS.InterfaceGrafica {
    public partial class formCadastroMarca : formCadastro {

        private TblMarca marcaSQL;

        public formCadastroMarca(bool pesquisaHabilitado) : base (pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado)
                pesquisa = new formPesquisaMarca(this, false);
            marcaSQL = new TblMarca();
        }

        protected override void novoRegistro() {
            base.novoRegistro();
            this.ActiveControl = mARCA_DESCRICAOTextBox;
        }

        protected override void salvaExecutar() {
            if (dsFROGIOS.MARCA.Rows.Count == 0) {
                marcaSQL.inserir(pegarValorCamposMarca(null));
            } else {
                object codigo = ((dsFROGIOS.MARCARow)dsFROGIOS.MARCA.Rows[0]).MARCA_CODIGO;
                marcaSQL.atualizar(pegarValorCamposMarca(codigo));
            }
        }

        private dsFROGIOS.MARCARow pegarValorCamposMarca(object codigo) {
            dsFROGIOS.MARCARow marcaRow = dsFROGIOS.MARCA.NewMARCARow();
            if (codigo != null) marcaRow.MARCA_CODIGO = (int)codigo;
            marcaRow.MARCA_DESCRICAO = mARCA_DESCRICAOTextBox.Text;
            return marcaRow;
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            this.ActiveControl = mARCA_DESCRICAOTextBox;
        }

        protected override void excluiExecutar(){
            marcaSQL.deletar((dsFROGIOS.MARCARow)dsFROGIOS.MARCA.Rows[0]);
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.MARCA.Clear();
            }
        }

        protected override void campos(bool estaDisponivel) {
            base.campos(estaDisponivel);
        }

        protected override string validarCampos() {
            string descricao = mARCA_DESCRICAOTextBox.Text;
            if (!valorValido(descricao)) return "Informe a descrição da marca";
            return base.validarCampos();
        }

        protected override void visualizarRegistroExecutar(int codigo) {
            string coluna = dsFROGIOS.MARCA.MARCA_CODIGOColumn.ColumnName;
            string valor;
            try { valor = Convert.ToString(codigo); } catch (Exception) { valor = "-5"; }
            dsFROGIOS.MARCA.Load(marcaSQL.selecionar(coluna, valor, true));
        }
    }
}