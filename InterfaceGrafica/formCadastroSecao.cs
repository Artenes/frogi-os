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
    public partial class formCadastroSecao : formCadastro {

        private TblSecao secaoSQL;

        public formCadastroSecao(bool pesquisaHabilitado) : base(pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado)
                pesquisa = new formPesquisaSecao(this, false);
            secaoSQL = new TblSecao();
        }

        protected override void novoRegistro() {
            base.novoRegistro();
            this.ActiveControl = sECAO_DESCRICAOTextBox;
        }

        protected override void salvaExecutar() {
            if (dsFROGIOS.SECAO.Rows.Count == 0) {
                secaoSQL.inserir(pegaValorCamposSecao(null));
            } else {
                object codigo = ((dsFROGIOS.SECAORow)dsFROGIOS.SECAO.Rows[0]).SECAO_CODIGO;
                secaoSQL.atualizar(pegaValorCamposSecao(codigo));
            }
        }

        private dsFROGIOS.SECAORow pegaValorCamposSecao(object codigo) {
            dsFROGIOS.SECAORow secaoRow = dsFROGIOS.SECAO.NewSECAORow();
            if (codigo != null) {
                secaoRow.SECAO_CODIGO = (int)codigo;
            }
            secaoRow.SECAO_DESCRICAO = sECAO_DESCRICAOTextBox.Text;
            return secaoRow;
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            this.ActiveControl = sECAO_DESCRICAOTextBox;
        }

        protected override void excluiExecutar() {
            secaoSQL.deletar((dsFROGIOS.SECAORow)dsFROGIOS.SECAO.Rows[0]);
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.SECAO.Clear();
            }
        }

        protected override void campos(bool estaDisponivel) {
            base.campos(estaDisponivel);    
        }

        protected override string validarCampos() {

            string descricao = sECAO_DESCRICAOTextBox.Text;

            if (!valorValido(descricao)) return "Informe a descrição da seção";

            return base.validarCampos();
        }

        protected override void visualizarRegistroExecutar(int codigo) {
            string coluna = dsFROGIOS.SECAO.SECAO_CODIGOColumn.ColumnName;
            string valor;
            try { valor = Convert.ToString(codigo); }catch (Exception) { valor = "-5"; }
            dsFROGIOS.SECAO.Load(secaoSQL.selecionar(coluna, valor, true));
        }
    }
}
