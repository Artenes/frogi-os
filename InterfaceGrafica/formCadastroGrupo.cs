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
    public partial class formCadastroGrupo : formCadastro {

        private TblGrupo grupoSQL;

        public formCadastroGrupo(bool pesquisaHabilitado) : base (pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado)
                pesquisa = new formPesquisaGrupo(this, false);
            grupoSQL = new TblGrupo();
        }

        protected override void novoRegistro() {
            base.novoRegistro();
            this.ActiveControl = gRUPO_DESCRICAOTextBox;
        }

        protected override void salvaExecutar() {
            if (dsFROGIOS.GRUPO.Rows.Count == 0) {
                grupoSQL.inserir(pegarValorCamposGrupo(null));
            } else {
                object codigo = ((dsFROGIOS.GRUPORow)dsFROGIOS.GRUPO.Rows[0]).GRUPO_CODIGO;
                grupoSQL.atualizar(pegarValorCamposGrupo(codigo));
            }
        }

        private dsFROGIOS.GRUPORow pegarValorCamposGrupo (object codigo) {
            dsFROGIOS.GRUPORow grupoRow = dsFROGIOS.GRUPO.NewGRUPORow();
            if (codigo != null) grupoRow.GRUPO_CODIGO = (int)codigo;
            grupoRow.GRUPO_DESCRICAO = gRUPO_DESCRICAOTextBox.Text;
            try { grupoRow.GRUPO_DESCONTO = Convert.ToDouble(gRUPO_DESCONTOTextBox.Text); } catch (Exception) { grupoRow.GRUPO_DESCONTO = 0; }
            return grupoRow;
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            this.ActiveControl = gRUPO_DESCRICAOTextBox;
        }

        protected override void excluiExecutar() {
            grupoSQL.deletar((dsFROGIOS.GRUPORow)dsFROGIOS.GRUPO.Rows[0]);
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) dsFROGIOS.GRUPO.Clear();
        }

        protected override void campos(bool estaDisponivel) {
            base.campos(estaDisponivel);
        }

        protected override string validarCampos() {

            gRUPO_DESCONTOTextBox.Text = "0,00";
            
            string
                descricao = gRUPO_DESCRICAOTextBox.Text,
                desconto = gRUPO_DESCONTOTextBox.Text;

            if (!valorValido(descricao)) return "Informe a descrição do grupo";
            if (!valorValido(desconto)) return "Informe o desconto do grupo";

            return base.validarCampos();
        }

        protected override void visualizarRegistroExecutar(int codigo) {
            string coluna = dsFROGIOS.GRUPO.GRUPO_CODIGOColumn.ColumnName;
            string valor;
            try { valor = Convert.ToString(codigo); } catch (Exception) { valor = "-5"; }
            dsFROGIOS.GRUPO.Load(grupoSQL.selecionar(coluna, valor, true));
        }
    }
}
