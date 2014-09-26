using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FROGI_OS.InterfaceGrafica;
using FROGI_OS.CamadaAcessoDados;

namespace FROGI_OS {
    public partial class formCadastroFuncionario : formCadastro {

        private TblFuncionario funcionarioSQL;

        public formCadastroFuncionario(bool pesquisaHabilitado) : base (pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado) pesquisa = new formPesquisaFuncionario(this, false);
            funcionarioSQL = new TblFuncionario();
        }

        protected override void novoRegistro() {
            base.novoRegistro();
            this.ActiveControl = fUNCIONARIO_NOMETextBox;
        }

        protected override void salvaExecutar() {
            if (dsFROGIOS.FUNCIONARIO.Rows.Count == 0) {
                funcionarioSQL.inserir(pegaValorCamposFuncionario(null));
            } else {
                object codigo = ((dsFROGIOS.FUNCIONARIORow)dsFROGIOS.FUNCIONARIO.Rows[0]).FUNCIONARIO_CODIGO;
                funcionarioSQL.atualizar(pegaValorCamposFuncionario(codigo));
            }
        }

        private dsFROGIOS.FUNCIONARIORow pegaValorCamposFuncionario(object codigo) {

            dsFROGIOS.FUNCIONARIORow funcionarioRow = dsFROGIOS.FUNCIONARIO.NewFUNCIONARIORow();
            if (codigo != null) funcionarioRow.FUNCIONARIO_CODIGO = (int)codigo; else funcionarioRow.FUNCIONARIO_DATA_CADASTRO = DateTime.Now;
            funcionarioRow.FUNCIONARIO_NOME = fUNCIONARIO_NOMETextBox.Text;
            funcionarioRow.FUNCIONARIO_CPF = fUNCIONARIO_CPFMaskedTextBox.Text;
            funcionarioRow.FUNCIONARIO_RG = fUNCIONARIO_RGTextBox.Text;
            funcionarioRow.FUNCIONARIO_NASCIMENTO = fUNCIONARIO_NASCIMENTODateTimePicker.Value;
            funcionarioRow.FUNCIONARIO_PIS = fUNCIONARIO_PISMaskedTextBox.Text;
            funcionarioRow.FUNCIONARIO_TELEFONE = fUNCIONARIO_TELEFONEMaskedTextBox.Text;
            funcionarioRow.FUNCIONARIO_EMAIL = fUNCIONARIO_EMAILTextBox.Text;
            funcionarioRow.FUNCIONARIO_ENDERECO = fUNCIONARIO_ENDERECOTextBox.Text;
            funcionarioRow.FUNCIONARIO_BAIRRO = fUNCIONARIO_BAIRROTextBox.Text;
            funcionarioRow.FUNCIONARIO_CEP = fUNCIONARIO_CEPTextBox.Text;
            funcionarioRow.FUNCIONARIO_FUNCAO = fUNCIONARIO_FUNCAOTextBox.Text;
            funcionarioRow.FUNCIONARIO_SETOR = fUNCIONARIO_SETORTextBox.Text;
            try { funcionarioRow.FUNCIONARIO_SALARIO = Convert.ToDecimal(fUNCIONARIO_SALARIOTextBox.Text); } catch (Exception) { funcionarioRow.FUNCIONARIO_SALARIO = 0; }
            funcionarioRow.FUNCIONARIO_ADMISSAO = fUNCIONARIO_ADMISSAODateTimePicker.Value;
            funcionarioRow.FUNCIONARIO_SENHA = fUNCIONARIO_SENHATextBox.Text;
            return funcionarioRow;

        }

        protected override void editarRegistro() {
            base.editarRegistro();
        }

        protected override void excluiExecutar() {
            funcionarioSQL.deletar((dsFROGIOS.FUNCIONARIORow)dsFROGIOS.FUNCIONARIO.Rows[0]);
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null)
                dsFROGIOS.FUNCIONARIO.Clear();
        }

        protected override void campos(bool estaDisponivel){
            base.campos(estaDisponivel);
        }

        protected override string validarCampos() {

            string
                nome = fUNCIONARIO_NOMETextBox.Text,
                telefone = fUNCIONARIO_TELEFONEMaskedTextBox.Text,
                endereco = fUNCIONARIO_ENDERECOTextBox.Text,
                bairro =fUNCIONARIO_BAIRROTextBox.Text,
                funcao = fUNCIONARIO_FUNCAOTextBox.Text,
                salario = fUNCIONARIO_SALARIOTextBox.Text,
                senha = fUNCIONARIO_SENHATextBox.Text;

            if (!valorValido(nome)) return "Informe o nome do funcionário";
            if (!valorValido(telefone)) return "Informe o telefone do funcionário";
            if (!valorValido(endereco)) return "Informe o endereço do funcionário";
            if (!valorValido(bairro)) return "Informe o bairro do funcionário";
            if (!valorValido(funcao)) return "Informe a função do funcionário";
            if (!valorValido(salario)) return "Informe o salário do funcionário";
            if (!valorValido(senha)) return "Informe a senha do funcionário";

            return base.validarCampos();
        }

        protected override void visualizarRegistroExecutar(int codigo) {
            string coluna = dsFROGIOS.FUNCIONARIO.FUNCIONARIO_CODIGOColumn.ColumnName;
            string valor;
            try { valor = Convert.ToString(codigo); } catch (Exception) { valor = "-5"; }
            dsFROGIOS.FUNCIONARIO.Load(funcionarioSQL.selecionar(coluna, valor, true));
        }

    }
}
