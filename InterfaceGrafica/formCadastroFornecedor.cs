using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FROGI_OS.CamadaEnlaceDados;

namespace FROGI_OS.InterfaceGrafica {
    public partial class formCadastroFornecedor : formCadastro {

        private readonly int FISICO = 0;
        private GerFornecedor fornecedorSQL;

        public formCadastroFornecedor(bool pesquisaHabilitado) : base (pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado)
                pesquisa = new formPesquisaFornecedor(this, false); 
            comboTipo.Enabled = false;
            fornecedorSQL = new GerFornecedor();
        }

        private bool eFisico() {
            return comboTipo.SelectedIndex == FISICO;
        }

        private int tipoOriginal() {
            dsFROGIOS.FORNECEDOR_FISICORow fisico;
            try { fisico = (dsFROGIOS.FORNECEDOR_FISICORow)dsFROGIOS.FORNECEDOR_FISICO.Rows[0]; } catch (Exception) { fisico = null; }
            if (fisico != null) return 0;
            else return 1;
        }

        protected override void novoRegistro() {
            base.novoRegistro();
            comboTipo.SelectedIndex = FISICO;
            this.ActiveControl = fORNECEDOR_FISICO_NOMETextBox;
        }

        protected override void salvaExecutar() {

            if (dsFROGIOS.FORNECEDOR.Rows.Count == 0) {

                dsFROGIOS.FORNECEDORRow fornecedorRow = pegarValorCamposFornecedor(null);
                dsFROGIOS.FORNECEDOR_FISICORow fisicoRow = null;
                dsFROGIOS.FORNECEDOR_JURIDICORow juridicoRow = null;

                if (eFisico()) {
                    fisicoRow = pegarValorCamposFisico(0);
                } else {
                    juridicoRow = pegarValorCamposJuridico(0);
                }

                fornecedorSQL.inserir(fornecedorRow, fisicoRow, juridicoRow);

            } else {

                int codigo = ((dsFROGIOS.FORNECEDORRow)dsFROGIOS.FORNECEDOR.Rows[0]).FORNECEDOR_CODIGO;
                bool mudouTipo = comboTipo.SelectedIndex != tipoOriginal();

                dsFROGIOS.FORNECEDORRow fornecedorRow = pegarValorCamposFornecedor(codigo);
                dsFROGIOS.FORNECEDOR_FISICORow fisicoRow = null;
                dsFROGIOS.FORNECEDOR_JURIDICORow juridicoRow = null;

                if (mudouTipo) {
                    if (eFisico()) {
                        fisicoRow = pegarValorCamposFisico(codigo);
                        juridicoRow = (dsFROGIOS.FORNECEDOR_JURIDICORow)dsFROGIOS.FORNECEDOR_JURIDICO.Rows[0];
                    } else {
                        fisicoRow = (dsFROGIOS.FORNECEDOR_FISICORow)dsFROGIOS.FORNECEDOR_FISICO.Rows[0];
                        juridicoRow = pegarValorCamposJuridico(codigo);
                    }
                } else {
                    if (eFisico()) {
                        fisicoRow = pegarValorCamposFisico(codigo);
                    } else {
                        juridicoRow = pegarValorCamposJuridico(codigo);
                    }
                }
                fornecedorSQL.atualizar(fornecedorRow, fisicoRow, juridicoRow, eFisico());
            }
        }

        private dsFROGIOS.FORNECEDORRow pegarValorCamposFornecedor(object codigo) {
            dsFROGIOS.FORNECEDORRow fornecedorRow = dsFROGIOS.FORNECEDOR.NewFORNECEDORRow();
            if (codigo != null) fornecedorRow.FORNECEDOR_CODIGO = (int)codigo;
            fornecedorRow.FORNECEDOR_ENDERECO = eFisico() ? fORNECEDOR_ENDERECOTextBox.Text : textEnderecoJuridico.Text;
            fornecedorRow.FORNECEDOR_BAIRRO = eFisico() ? fORNECEDOR_BAIRROTextBox.Text : textBairroJuridico.Text;
            fornecedorRow.FORNECEDOR_PERIMETRO = eFisico() ? fORNECEDOR_PERIMETROTextBox.Text : textPerimetroJuridico.Text;
            fornecedorRow.FORNECEDOR_CIDADE = eFisico() ? fORNECEDOR_CIDADETextBox.Text : textCidadeJuridico.Text;
            fornecedorRow.FORNECEDOR_UF = eFisico() ? (uF_DESCRICAOComboBox.SelectedIndex + 1) : (comboUfJuridico.SelectedIndex + 1);
            fornecedorRow.FORNECEDOR_CEP = eFisico() ? fORNECEDOR_CEPTextBox.Text : textCepJuridico.Text;
            fornecedorRow.FORNECEDOR_TELEFONE = eFisico() ? fORNECEDOR_TELEFONEMaskedTextBox.Text : textTelefoneJuridico.Text;
            fornecedorRow.FORNECEDOR_CELULAR = eFisico() ? fORNECEDOR_CELULARMaskedTextBox.Text : textCelularJuridico.Text;
            fornecedorRow.FORNECEDOR_EMAIL = eFisico() ? fORNECEDOR_EMAILTextBox.Text : textEmailJuridico.Text;
            fornecedorRow.FORNECEDOR_OBSERVACOES = eFisico() ? fORNECEDOR_OBSERVACOESTextBox.Text : textObservacoesJuridico.Text;
            return fornecedorRow;
        }

        private dsFROGIOS.FORNECEDOR_FISICORow pegarValorCamposFisico(int codigo) {
            dsFROGIOS.FORNECEDOR_FISICORow fisicoRow = dsFROGIOS.FORNECEDOR_FISICO.NewFORNECEDOR_FISICORow();
            fisicoRow.FORNECEDOR_FISICO_FORNECEDOR = codigo;
            fisicoRow.FORNECEDOR_FISICO_NOME = fORNECEDOR_FISICO_NOMETextBox.Text;
            fisicoRow.FORNECEDOR_FISICO_CPF = fORNECEDOR_FISICO_CPFMaskedTextBox.Text;
            fisicoRow.FORNECEDOR_FISICO_RG = fORNECEDOR_FISICO_RGTextBox.Text;
            return fisicoRow;
        }

        private dsFROGIOS.FORNECEDOR_JURIDICORow pegarValorCamposJuridico(int codigo) {
            dsFROGIOS.FORNECEDOR_JURIDICORow juridicoRow = dsFROGIOS.FORNECEDOR_JURIDICO.NewFORNECEDOR_JURIDICORow();
            juridicoRow.FORNECEDOR_JURIDICO_FORNECEDOR = codigo;
            juridicoRow.FORNECEDOR_JURIDICO_RAZ_SOC = fORNECEDOR_JURIDICO_RAZ_SOCTextBox.Text;
            juridicoRow.FORNECEDOR_JURIDICO_CNPJ = fORNECEDOR_JURIDICO_CNPJMaskedTextBox.Text;
            juridicoRow.FORNECEDOR_JURIDICO_IE = fORNECEDOR_JURIDICO_IEMaskedTextBox.Text;
            juridicoRow.FORNECEDOR_JURIDICO_FANTASIA = fORNECEDOR_JURIDICO_FANTASIATextBox.Text;
            juridicoRow.FORNECEDOR_JURIDICO_REPRE = fORNECEDOR_JURIDICO_REPRETextBox.Text;
            juridicoRow.FORNECEDOR_JURIDICO_CONTATO = fORNECEDOR_JURIDICO_CONTATOMaskedTextBox.Text;
            return juridicoRow;
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            if (comboTipo.SelectedIndex == FISICO) {
                this.ActiveControl = fORNECEDOR_FISICO_NOMETextBox;
            }
            else {
                this.ActiveControl = fORNECEDOR_JURIDICO_RAZ_SOCTextBox;
            }
        }

        protected override void excluiExecutar() {
            fornecedorSQL.deletar((dsFROGIOS.FORNECEDORRow)dsFROGIOS.FORNECEDOR.Rows[0]);
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.FORNECEDOR.Clear();
                dsFROGIOS.FORNECEDOR_FISICO.Clear();
                dsFROGIOS.FORNECEDOR_JURIDICO.Clear();
                dsFROGIOS.UF.Clear();
            }
            if (comboTipo != null) {
                comboTipo.SelectedIndex = FISICO;
            }
        }

        protected override void campos(bool estaDisponivel) {
            base.campos(estaDisponivel);
            if (comboTipo != null) {
                comboTipo.Enabled = estaDisponivel;    
            }
            
        }

        protected override string validarCampos() {

            string
                endereco = eFisico() ? fORNECEDOR_ENDERECOTextBox.Text : textEnderecoJuridico.Text,
                bairro = eFisico() ? fORNECEDOR_BAIRROTextBox.Text : textBairroJuridico.Text,
                cidade = eFisico() ? fORNECEDOR_CIDADETextBox.Text : textCidadeJuridico.Text,
                uf = eFisico() ? uF_DESCRICAOComboBox.Text : comboUfJuridico.Text;

            if (!valorValido(endereco)) return "Informe o endereço do fornecedor";
            if (!valorValido(bairro)) return "Informe o bairro do fornecedor";
            if (!valorValido(cidade)) return "Informe a cidade do fornecedor";
            if (!valorValido(uf)) return "Informe a UF do fornecedor";

            if (eFisico()) {
                string nome = fORNECEDOR_FISICO_NOMETextBox.Text;
                if (!valorValido(nome)) return "Informe o nome do fornecedor";
            } else {
                string razaoSocial = fORNECEDOR_JURIDICO_RAZ_SOCTextBox.Text;
                if (!valorValido(razaoSocial)) return "informe a Razão Social do fornecedor";
            }

            return base.validarCampos();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox comboBox = (ComboBox) sender;
            if (comboBox != null) {
                object item = comboBox.SelectedItem;
                if (item != null && item.ToString() == "Físico") {
                    tablessPai.SelectedTab = tabFisico;
                } else if (item != null && item.ToString() == "Jurídico") {
                    tablessPai.SelectedTab = tabJuridico;
                }
            }
        }

        public void visualizarRegistro(int codigo, bool eFisico) {
            if (eFisico) {
                fornecedorSQL.selecionar(codigo, dsFROGIOS.FORNECEDOR, dsFROGIOS.FORNECEDOR_FISICO, null, dsFROGIOS.UF);
                comboTipo.SelectedIndex = 0;
            } else {
                fornecedorSQL.selecionar(codigo, dsFROGIOS.FORNECEDOR, null, dsFROGIOS.FORNECEDOR_JURIDICO, dsFROGIOS.UF);
                comboTipo.SelectedIndex = 1;
            }
        }
    }
}
