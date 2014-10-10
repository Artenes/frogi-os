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

    public partial class formCadastroCliente : formCadastro {

        private readonly int FISICO   = 0; //zero é para cliente físico
        private GerCliente clienteSQL; //Carrega os comandos SQL com ele
        private TblUF uf; // <---- SQL aqui também

        public formCadastroCliente(bool pesquisaHabilitado) : base(pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado)
                pesquisa = new formPesquisaCliente(this, false);
            comboTipo.Enabled = false;
            clienteSQL = new GerCliente();
            uf = new TblUF();
        }
            
        protected override void novoRegistro() {
            base.novoRegistro();
            comboTipo.SelectedIndex = FISICO;
            this.ActiveControl = cLIENTE_FISICO_NOMETextBox;
        }

        protected override void salvaExecutar() {
            //Neste se esta inserindo um novo cliente
            if (dsFROGIOS.CLIENTE.Rows.Count == 0) {

                //Verifica se o cliente é fisico ou não. Caso não seja obviamente será juridico
                bool eFisico = (comboTipo.SelectedIndex == FISICO);

                dsFROGIOS.CLIENTERow clienteRow = pegaValorCamposCliente(null);
                dsFROGIOS.CLIENTE_FISICORow fisicoRow = null;
                dsFROGIOS.CLIENTE_JURIDICORow juridicoRow = null;

                if (eFisico) {
                    fisicoRow = pegarValorCamposFisico(0); //Este 0 significa nada. É só para ir de acorodo com a assinatura do método
                } else {
                    juridicoRow = pegarValorCamposJuridico(0);
                }

                clienteSQL.inserir(clienteRow, fisicoRow, juridicoRow);

            } else {

                int codigo = ((dsFROGIOS.CLIENTERow)dsFROGIOS.CLIENTE.Rows[0]).CLIENTE_CODIGO; //código do registro atual
                int tipoAntigo = Convert.ToInt32(((dsFROGIOS.CLIENTERow)dsFROGIOS.CLIENTE.Rows[0]).CLIENTE_TIPO); //Pego o "tipo antigo" do registro atual para caso seu tipo tenha sido alterado
                bool mudouTipo = comboTipo.SelectedIndex != tipoAntigo; //Aqui o "tipo antigo" entra em ação. É verificado se o cliente teve seu tipo alterado
                bool eFisico = comboTipo.SelectedIndex == FISICO; 

                dsFROGIOS.CLIENTERow clienteRow = pegaValorCamposCliente(codigo);
                dsFROGIOS.CLIENTE_FISICORow fisicoRow = null;
                dsFROGIOS.CLIENTE_JURIDICORow juridicoRow = null;

                /**
                 * LOGICA:
                 * Se o tipo mudou e o cliente é fisico, significa que ele era jurídico
                 * então vamos apagar no BD o jurídico e inserir o físico
                 * Se o tipo mudou e o cliente é jurídico, significa que ele era fisico
                 * então vamos apagar no BD o físico e inserir o jurídico
                 */
                if (mudouTipo) {
                    if (eFisico) {
                        fisicoRow = pegarValorCamposFisico(codigo); //Para inserir pego os valores que foram digitados nos campos
                        juridicoRow = (dsFROGIOS.CLIENTE_JURIDICORow)dsFROGIOS.CLIENTE_JURIDICO.Rows[0]; //Para apagar pego a instância que tava no BD
                    } else {
                        fisicoRow = (dsFROGIOS.CLIENTE_FISICORow)dsFROGIOS.CLIENTE_FISICO.Rows[0];
                        juridicoRow = pegarValorCamposJuridico(codigo);
                    }
                } else {
                    if (eFisico) {
                        fisicoRow = pegarValorCamposFisico(codigo);
                    } else {
                        juridicoRow = pegarValorCamposJuridico(codigo);
                    }
                }

                clienteSQL.atualizar(clienteRow, fisicoRow, juridicoRow, eFisico);

            }
        }

        private dsFROGIOS.CLIENTERow pegaValorCamposCliente (object codigo) {

            bool eFisico = comboTipo.SelectedIndex == FISICO;
            dsFROGIOS.CLIENTERow clienteRow = dsFROGIOS.CLIENTE.NewCLIENTERow();

            //Essa verificação serve para caso o cliente esteka sendo inserido
            //pela primeira vez, logo nenhum código será fornecido
            if (codigo != null) {
                clienteRow.CLIENTE_CODIGO = (int)codigo;
            } else {
                clienteRow.CLIENTE_DATA_CADASTRO = DateTime.Now;
            }
            clienteRow.CLIENTE_TIPO = comboTipo.SelectedIndex.ToString();
            clienteRow.CLIENTE_TELEFONE = eFisico ? cLIENTE_TELEFONEMaskedTextBox.Text : textTelefoneJuridico.Text;
            clienteRow.CLIENTE_CELULAR = eFisico ? cLIENTE_CELULARMaskedTextBox.Text : textCelularJuridico.Text;
            clienteRow.CLIENTE_EMAIL = eFisico ? cLIENTE_EMAILTextBox.Text : textEmailJuridico.Text;
            clienteRow.CLIENTE_ENDERECO = eFisico ? cLIENTE_ENDERECOTextBox.Text : textEnderecoJuridico.Text;
            clienteRow.CLIENTE_BAIRRO = eFisico ? cLIENTE_BAIRROTextBox.Text : textBairroJuridico.Text;
            clienteRow.CLIENTE_PERIMETRO = eFisico ? cLIENTE_PERIMETROTextBox.Text : textPerimetroJuridico.Text;
            clienteRow.CLIENTE_CIDADE = eFisico ? cLIENTE_CIDADETextBox.Text : textCidadeJuridico.Text;
            clienteRow.CLIENTE_UF = eFisico ? (uF_DESCRICAOComboBox.SelectedIndex + 1) : (comboUFJuridico.SelectedIndex + 1);
            clienteRow.CLIENTE_CEP = eFisico ? cLIENTE_CEPMaskedTextBox.Text : textCepJuridico.Text;

            return clienteRow;
        }

        private dsFROGIOS.CLIENTE_FISICORow pegarValorCamposFisico(int codigo) {

            dsFROGIOS.CLIENTE_FISICORow fisicoRow = dsFROGIOS.CLIENTE_FISICO.NewCLIENTE_FISICORow();

            fisicoRow.CLIENTE_FISICO_CLIENTE = codigo;
            fisicoRow.CLIENTE_FISICO_NOME = cLIENTE_FISICO_NOMETextBox.Text;
            fisicoRow.CLIENTE_FISICO_CPF = cLIENTE_FISICO_CPFMaskedTextBox.Text;
            fisicoRow.CLIENTE_FISICO_RG = cLIENTE_FISICO_RGTextBox.Text;
            fisicoRow.CLIENTE_FISICO_NASCIMENTO = cLIENTE_FISICO_NASCIMENTODateTimePicker.Value;
            fisicoRow.CLIENTE_FISICO_SEXO = cLIENTE_FISICO_SEXOComboBox.Text;
            fisicoRow.CLIENTE_FISICO_ESTADO_CIVIL = cLIENTE_FISICO_ESTADO_CIVILTextBox.Text;
            fisicoRow.CLIENTE_FISICO_PROFISSAO = cLIENTE_FISICO_PROFISSAOTextBox.Text;
            try { fisicoRow.CLIENTE_FISICO_SALARIO = Convert.ToDouble(cLIENTE_FISICO_SALARIOMaskedTextBox.Text); }
            catch (Exception) { fisicoRow.CLIENTE_FISICO_SALARIO = 0; }
            try { fisicoRow.CLIENTE_FISICO_LIMITE = Convert.ToDouble(cLIENTE_FISICO_LIMITETextBox.Text); }
            catch (Exception) { fisicoRow.CLIENTE_FISICO_LIMITE = 0; }
            try { fisicoRow.CLIENTE_FISICO_LIMITE_ATUAL = Convert.ToDouble(cLIENTE_FISICO_LIMITE_ATUALTextBox.Text); }
            catch (Exception) { fisicoRow.CLIENTE_FISICO_LIMITE_ATUAL = 0; }
            fisicoRow.CLIENTE_FISICO_MAE = cLIENTE_FISICO_MAETextBox.Text;
            fisicoRow.CLIENTE_FISICO_PAI = cLIENTE_FISICO_PAITextBox.Text;
            fisicoRow.CLIENTE_FISICO_OBSERVACAO = cLIENTE_FISICO_OBSERVACAORichTextBox.Text;

            return fisicoRow;
        }

        private dsFROGIOS.CLIENTE_JURIDICORow pegarValorCamposJuridico(int codigo) {

            dsFROGIOS.CLIENTE_JURIDICORow juridicoRow = dsFROGIOS.CLIENTE_JURIDICO.NewCLIENTE_JURIDICORow();

            juridicoRow.CLIENTE_JURIDICO_CLIENTE = codigo;
            juridicoRow.CLIENTE_JURIDICO_RAZAO_SOCIAL = cLIENTE_JURIDICO_RAZAO_SOCIALTextBox.Text;
            juridicoRow.CLIENTE_JURIDICO_CNPJ = cLIENTE_JURIDICO_CNPJMaskedTextBox.Text;
            juridicoRow.CLIENTE_JURIDICO_IE = cLIENTE_JURIDICO_IEMaskedTextBox.Text;
            juridicoRow.CLIENTE_JURIDICO_FANTASIA = cLIENTE_JURIDICO_FANTASIATextBox.Text;
            juridicoRow.CLIENTE_JURIDICO_ATIVIDADE = cLIENTE_JURIDICO_ATIVIDADETextBox.Text;
            juridicoRow.CLIENTE_JURIDICO_NOME_CONTATO = cLIENTE_JURIDICO_NOME_CONTATOTextBox.Text;

            return juridicoRow;
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            if (comboTipo.SelectedIndex == FISICO) {
                this.ActiveControl = cLIENTE_FISICO_NOMETextBox;
            } else {
                this.ActiveControl = cLIENTE_JURIDICO_RAZAO_SOCIALTextBox;
            }
        }

        protected override void excluiExecutar() {
            clienteSQL.deletar((dsFROGIOS.CLIENTERow)dsFROGIOS.CLIENTE[0]);
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null) {
                dsFROGIOS.CLIENTE.Clear();
                dsFROGIOS.CLIENTE_FISICO.Clear();
                dsFROGIOS.CLIENTE_JURIDICO.Clear();
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
            int tipo = comboTipo.SelectedIndex;
            bool eFisico = tipo == FISICO;

            string 
                telefone =  eFisico ? cLIENTE_TELEFONEMaskedTextBox.Text : textTelefoneJuridico.Text,
                endereco = eFisico ? cLIENTE_ENDERECOTextBox.Text : textEnderecoJuridico.Text,
                bairro = eFisico ? cLIENTE_BAIRROTextBox.Text : textBairroJuridico.Text, 
                cidade = eFisico ? cLIENTE_CIDADETextBox.Text : textCidadeJuridico.Text, 
                uf = eFisico ? uF_DESCRICAOComboBox.Text : comboUFJuridico.Text;

            if (!valorValido(telefone)) return "Informe o telefone do cliente";
            if (!valorValido(endereco)) return "Informe o endereço do cliente";
            if (!valorValido(bairro)) return "Informe o bairro do cliente";
            if (!valorValido(cidade)) return "Informe a cidade do cliente";
            if (!valorValido(uf)) return "Informe o UF do cliente";

            if (eFisico) {
                string
                nascimento = cLIENTE_FISICO_NASCIMENTODateTimePicker.Text,
                sexo = cLIENTE_FISICO_SEXOComboBox.Text,
                estadoCivil = cLIENTE_FISICO_ESTADO_CIVILTextBox.Text;

                if (!(valorValido(nascimento))) return "Informe a data de nascimento do cliente";
                if (!(valorValido(sexo))) return "Informe o sexo do cliente";
                if (!(valorValido(estadoCivil))) return "Informe o estado civil do cliente";
            } else  {
                string
                razaoSocial = cLIENTE_JURIDICO_RAZAO_SOCIALTextBox.Text,
                fantasia = cLIENTE_JURIDICO_FANTASIATextBox.Text,
                atividade = cLIENTE_JURIDICO_ATIVIDADETextBox.Text;

                if (!(valorValido(razaoSocial))) return "Informe a razão social do cliente";
                if (!(valorValido(fantasia))) return "Informe o nome fantasia do cliente";
                if (!(valorValido(atividade))) return "Informe a atividade do cliente";
            }

            return base.validarCampos();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
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
            Conexao.abrir();
            if (eFisico) {
                clienteSQL.selecionar(codigo, dsFROGIOS.CLIENTE, dsFROGIOS.CLIENTE_FISICO, null);
                comboTipo.SelectedIndex = 0; //Físico
            } else {
                clienteSQL.selecionar(codigo, dsFROGIOS.CLIENTE, null, dsFROGIOS.CLIENTE_JURIDICO);
                comboTipo.SelectedIndex = 1; //Jurídico
            }
            int codigoUF = dsFROGIOS.CLIENTE[0].CLIENTE_UF;
            dsFROGIOS.UF.Load(uf.selecionar("UF_CODIGO", codigoUF.ToString(), true));
            Conexao.fechar();
        }
    }
}