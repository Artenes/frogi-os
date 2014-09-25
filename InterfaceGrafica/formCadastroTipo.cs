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
    public partial class formCadastroTipo : formCadastro {

        private TblTipo tipoSQL; //SQL! puta que pariu!

        public formCadastroTipo(bool pesquisaHabilitado) : base(pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado) 
                pesquisa = new formPesquisaTipo(this, false);
            tipoSQL = new TblTipo();
        }

        protected override void salvaExecutar() {

            if (dsFROGIOS.TIPO.Rows.Count == 0) {
                tipoSQL.inserir(pegarValorCamposTipo(null));
            } else {
                object codigo = ((dsFROGIOS.TIPORow)dsFROGIOS.TIPO.Rows[0]).TIPO_CODIGO;
                tipoSQL.atualizar(pegarValorCamposTipo(codigo));
            }

        }

        private dsFROGIOS.TIPORow pegarValorCamposTipo(Object codigo) {

            dsFROGIOS.TIPORow tipoRow = dsFROGIOS.TIPO.NewTIPORow();
            if (codigo != null) {
                tipoRow.TIPO_CODIGO = (int)codigo;
            }
            tipoRow.TIPO_DESCRICAO = tIPO_DESCRICAOTextBox.Text;

            return tipoRow;
        }

        protected override void editarRegistro() {
            base.editarRegistro();
        }

        protected override void excluiExecutar(){
            tipoSQL.deletar((dsFROGIOS.TIPORow)dsFROGIOS.TIPO.Rows[0]);
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.TIPO.Clear();
            }
        }

        protected override void campos(bool estaDisponivel){
            base.campos(estaDisponivel);
        }

        protected override string validarCampos() {
            string descricao = tIPO_DESCRICAOTextBox.Text;
            if (!valorValido(descricao)) return "Informe a descrição do tipo de serviço";
            return base.validarCampos();
        }

        protected override void visualizarRegistroExecutar(int codigo) {
            string coluna = dsFROGIOS.TIPO.TIPO_CODIGOColumn.ColumnName;
            string valor;
            try { valor = Convert.ToString(codigo); } catch (Exception) { valor = "-5";}
            dsFROGIOS.TIPO.Load(tipoSQL.selecionar(coluna, valor, true));
        }

    }
}
