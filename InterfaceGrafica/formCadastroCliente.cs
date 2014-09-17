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

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formCadastroCliente : formCadastro {

        private readonly int FISICO = 0;
        private GerCliente cliente;

        public formCadastroCliente(bool pesquisaHabilitado) : base(pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado)
                pesquisa = new formPesquisaCliente(this, false);
            comboTipo.Enabled = false;
            cliente = new GerCliente();
        }
            
        protected override void novoRegistro() {
            base.novoRegistro();
            this.ActiveControl = cLIENTE_FISICO_NOMETextBox;
        }

        protected override void salvaExecutar() {
            if (dsFROGIOS.CLIENTE.Rows.Count == 0) {

                dsFROGIOS.CLIENTERow clienteRow = dsFROGIOS.CLIENTE.NewCLIENTERow();
                clienteRow.CLIENTE_TIPO = comboTipo.SelectedIndex.ToString();
                clienteRow.CLIENTE_DATA_CADASTRO = DateTime.Now;

                bool eFisico = (comboTipo.SelectedIndex == FISICO);
                clienteRow.CLIENTE_TELEFONE = eFisico ? cLIENTE_TELEFONEMaskedTextBox.Text : textTelefoneJuridico.Text;
                clienteRow.CLIENTE_CELULAR = eFisico ? cLIENTE_CELULARMaskedTextBox.Text : textCelularJuridico.Text;
                clienteRow.CLIENTE_EMAIL = eFisico ? cLIENTE_EMAILTextBox.Text : textEmailJuridico.Text;
                clienteRow.CLIENTE_ENDERECO = eFisico ? cLIENTE_ENDERECOTextBox.Text : textEnderecoJuridico.Text;
                clienteRow.CLIENTE_BAIRRO = eFisico ? cLIENTE_BAIRROTextBox.Text : textBairroJuridico.Text;
                clienteRow.CLIENTE_PERIMETRO = eFisico ? cLIENTE_PERIMETROTextBox.Text : textPerimetroJuridico.Text;
                clienteRow.CLIENTE_CIDADE = eFisico ? cLIENTE_CIDADETextBox.Text : textCidadeJuridico.Text;
                clienteRow.CLIENTE_UF = eFisico ? (uF_DESCRICAOComboBox.SelectedIndex + 1) : (comboUFJuridico.SelectedIndex + 1);
                clienteRow.CLIENTE_CEP = eFisico ? cLIENTE_CEPMaskedTextBox.Text : textCepJuridico.Text;

                dsFROGIOS.CLIENTE_FISICORow fisicoRow = null;
                dsFROGIOS.CLIENTE_JURIDICORow juridicoRow = null;

                if (eFisico) {
                    fisicoRow = dsFROGIOS.CLIENTE_FISICO.NewCLIENTE_FISICORow();
                    fisicoRow.CLIENTE_FISICO_NOME = cLIENTE_FISICO_NOMETextBox.Text;
                    fisicoRow.CLIENTE_FISICO_CPF = cLIENTE_FISICO_CPFMaskedTextBox.Text;
                    fisicoRow.CLIENTE_FISICO_RG = cLIENTE_FISICO_RGTextBox.Text;
                    fisicoRow.CLIENTE_FISICO_NASCIMENTO = cLIENTE_FISICO_NASCIMENTODateTimePicker.Value;
                    fisicoRow.CLIENTE_FISICO_SEXO = cLIENTE_FISICO_SEXOComboBox.Text;
                    fisicoRow.CLIENTE_FISICO_ESTADO_CIVIL = cLIENTE_FISICO_ESTADO_CIVILTextBox.Text;
                    fisicoRow.CLIENTE_FISICO_PROFISSAO = cLIENTE_FISICO_PROFISSAOTextBox.Text;
                    fisicoRow.CLIENTE_FISICO_SALARIO = 100; //Convert.ToDecimal(cLIENTE_FISICO_SALARIOMaskedTextBox.Text);
                    fisicoRow.CLIENTE_FISICO_LIMITE = 200;//Convert.ToDecimal(cLIENTE_FISICO_LIMITETextBox.Text);
                    fisicoRow.CLIENTE_FISICO_LIMITE_ATUAL = 300;//Convert.ToDecimal(cLIENTE_FISICO_LIMITE_ATUALTextBox.Text);
                    fisicoRow.CLIENTE_FISICO_MAE = cLIENTE_FISICO_MAETextBox.Text;
                    fisicoRow.CLIENTE_FISICO_PAI = cLIENTE_FISICO_PAITextBox.Text;
                    fisicoRow.CLIENTE_FISICO_OBSERVACAO = cLIENTE_FISICO_OBSERVACAORichTextBox.Text;
                } else {

                    juridicoRow = dsFROGIOS.CLIENTE_JURIDICO.NewCLIENTE_JURIDICORow();
                    juridicoRow.CLIENTE_JURIDICO_RAZAO_SOCIAL = cLIENTE_JURIDICO_RAZAO_SOCIALTextBox.Text;
                    juridicoRow.CLIENTE_JURIDICO_CNPJ = cLIENTE_JURIDICO_CNPJMaskedTextBox.Text;
                    juridicoRow.CLIENTE_JURIDICO_IE = cLIENTE_JURIDICO_IEMaskedTextBox.Text;
                    juridicoRow.CLIENTE_JURIDICO_FANTASIA = cLIENTE_JURIDICO_FANTASIATextBox.Text;
                    juridicoRow.CLIENTE_JURIDICO_ATIVIDADE = cLIENTE_JURIDICO_ATIVIDADETextBox.Text;
                    juridicoRow.CLIENTE_JURIDICO_NOME_CONTATO = cLIENTE_JURIDICO_NOME_CONTATOTextBox.Text;

                }

                cliente.inserir(clienteRow, fisicoRow, juridicoRow);

            } else { 
            
            }
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            if (comboTipo.SelectedIndex == FISICO)
            {
                this.ActiveControl = cLIENTE_FISICO_NOMETextBox;
            }
            else
            {
                this.ActiveControl = cLIENTE_JURIDICO_RAZAO_SOCIALTextBox;
            }
        }

        protected override void excluiExecutar()
        {
            base.excluiExecutar();
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null)
            {
                dsFROGIOS.CLIENTE.Clear();
                dsFROGIOS.CLIENTE_FISICO.Clear();
                dsFROGIOS.CLIENTE_JURIDICO.Clear();
                dsFROGIOS.UF.Clear();
            }
            if (comboTipo != null)
            {
                comboTipo.SelectedIndex = FISICO;
            }
        }

        protected override void campos(bool estaDisponivel)
        {
            base.campos(estaDisponivel);
            if (comboTipo != null)
            {
                comboTipo.Enabled = estaDisponivel;
            }
        }

        protected override string validarCampos()
        {

            /*int tipo = comboTipo.SelectedIndex;
            bool eFisico = tipo == FISICO;

            string 
                telefone =  eFisico ? cLIENTE_TELEFONEMaskedTextBox.Text : textTelefoneJuridico.Text,
                endereco = eFisico ? cLIENTE_ENDERECOTextBox.Text : textEnderecoJuridico.Text,
                bairro = eFisico ? cLIENTE_BAIRROTextBox.Text : textBairroJuridico.Text, 
                cidade = eFisico ? cLIENTE_CIDADETextBox.Text : textCidadeJuridico.Text, 
                uf = eFisico ? uF_DESCRICAOComboBox.Text : comboUFJuridico.Text;

            if (!verificarCampo(telefone)) return "Informe o telefone do cliente";
            if (!verificarCampo(endereco)) return "Informe o endereço do cliente";
            if (!verificarCampo(bairro)) return "Informe o bairro do cliente";
            if (!verificarCampo(cidade)) return "Informe a cidade do cliente";
            if (!verificarCampo(uf)) return "Informe o UF do cliente";

            if (eFisico)
            {
                string
                nascimento = cLIENTE_FISICO_NASCIMENTODateTimePicker.Text,
                sexo = cLIENTE_FISICO_SEXOComboBox.Text,
                estadoCivil = cLIENTE_FISICO_ESTADO_CIVILTextBox.Text;

                if (!(verificarCampo(nascimento))) return "Informe a data de nascimento do cliente";
                if (!(verificarCampo(sexo))) return "Informe o sexo do cliente";
                if (!(verificarCampo(estadoCivil))) return "Informe o estado civil do cliente";
                
            }
            else 
            {
                string
                razaoSocial = cLIENTE_JURIDICO_RAZAO_SOCIALTextBox.Text,
                fantasia = cLIENTE_JURIDICO_FANTASIATextBox.Text,
                atividade = cLIENTE_JURIDICO_ATIVIDADETextBox.Text;

                if (!(verificarCampo(razaoSocial))) return "Informe a razão social do cliente";
                if (!(verificarCampo(fantasia))) return "Informe o nome fantasia do cliente";
                if (!(verificarCampo(atividade))) return "Informe a atividade do cliente";

            }*/

            return base.validarCampos();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox != null)
            {
                object item = comboBox.SelectedItem;
                if (item != null && item.ToString() == "Físico")
                {
                    tablessPai.SelectedTab = tabFisico;
                }
                else if (item != null && item.ToString() == "Jurídico")
                {
                    tablessPai.SelectedTab = tabJuridico;
                }
            }
        }

        public override void visualizarRegistro(int codigo)
        {
            base.visualizarRegistro(codigo);
        }
    }
}
