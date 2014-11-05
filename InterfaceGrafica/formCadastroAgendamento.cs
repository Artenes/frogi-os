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
using FROGI_OS.CamadaAcessoDados;

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formCadastroAgendamento : formCadastro
    {

        private GerAgendamento agendamentoSQL;

        public formCadastroAgendamento(bool pesquisaHabilitado) : base (pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado) {
                pesquisa = new formPesquisaAgendamento(this, false);
            }
            agendamentoSQL = new GerAgendamento();
        }

        protected override void salvaExecutar() {
            if (dsFROGIOS.AGENDAMENTO.Rows.Count == 0) {
                agendamentoSQL.inserir(pegarValorCamposAgendamento(null));
            } else {
                object codigo = ((dsFROGIOS.AGENDAMENTORow)dsFROGIOS.AGENDAMENTO.Rows[0]).AGEN_CODIGO;
                agendamentoSQL.atualizar(pegarValorCamposAgendamento(codigo));
            }
        }

        private dsFROGIOS.AGENDAMENTORow pegarValorCamposAgendamento(object codigo) {

            dsFROGIOS.AGENDAMENTORow agendamentoRow = dsFROGIOS.AGENDAMENTO.NewAGENDAMENTORow();

            if (codigo != null) agendamentoRow.AGEN_CODIGO = (int)codigo;
            agendamentoRow.AGEN_CLIENTE = ((dsFROGIOS.CLIENTERow)dsFROGIOS.CLIENTE.Rows[0]).CLIENTE_CODIGO;
            agendamentoRow.AGEN_DATA = aGEN_DATADateTimePicker.Value;
            agendamentoRow.AGEN_DESCRICAO = aGEN_DESCRICAORichTextBox.Text;

            return agendamentoRow;

        }

        

        protected override void editarRegistro() {
            base.editarRegistro();
            this.ActiveControl = textCliente;
        }

        protected override void excluiExecutar() {
            agendamentoSQL.deletar((dsFROGIOS.AGENDAMENTORow)dsFROGIOS.AGENDAMENTO.Rows[0]);
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null)
            {
                dsFROGIOS.AGENDAMENTO.Clear();
                dsFROGIOS.CLIENTE.Clear();
                dsFROGIOS.CLIENTE_FISICO.Clear();
                dsFROGIOS.CLIENTE_JURIDICO.Clear();
                textCliente.Text = "Duplo clique para pesquisar";
                textTelefone.Text = "";
                textCelular.Text = "";
            }
        }

        protected override void campos(bool estaDisponivel) {
            base.campos(estaDisponivel);
            if (textCliente != null)
            {
                textCliente.Enabled = estaDisponivel;    
            }
        }

        protected override string validarCampos() {
            string descricao = aGEN_DESCRICAORichTextBox.Text;
            int cliente = dsFROGIOS.CLIENTE.Rows.Count;

            if (!valorValido(descricao)) return "Informe a descrição do serviço";
            if (cliente == 0) return "Informe o cliente para o agendamento";
            return base.validarCampos();
        }

        protected override void visualizarRegistroExecutar(int codigo) {
            agendamentoSQL.selecionar(codigo, dsFROGIOS.AGENDAMENTO, dsFROGIOS.CLIENTE, dsFROGIOS.CLIENTE_FISICO, dsFROGIOS.CLIENTE_JURIDICO);
            if (dsFROGIOS.CLIENTE_FISICO.Rows.Count != 0) {
                textCliente.Text = ((dsFROGIOS.CLIENTE_FISICORow)dsFROGIOS.CLIENTE_FISICO.Rows[0]).CLIENTE_FISICO_NOME;
                textTelefone.Text = ((dsFROGIOS.CLIENTERow)dsFROGIOS.CLIENTE.Rows[0]).CLIENTE_TELEFONE;
                textCelular.Text = ((dsFROGIOS.CLIENTERow)dsFROGIOS.CLIENTE.Rows[0]).CLIENTE_CELULAR;
            } else {
                textCliente.Text = ((dsFROGIOS.CLIENTE_JURIDICORow)dsFROGIOS.CLIENTE_JURIDICO.Rows[0]).CLIENTE_JURIDICO_FANTASIA;
                textTelefone.Text = ((dsFROGIOS.CLIENTERow)dsFROGIOS.CLIENTE.Rows[0]).CLIENTE_TELEFONE;
                textCelular.Text = ((dsFROGIOS.CLIENTERow)dsFROGIOS.CLIENTE.Rows[0]).CLIENTE_CELULAR;
            }
        }

        public void adicionarCliente(int codigo, bool efisico) {
            try {
                Conexao.abrir();
                GerCliente clienteSQL = new GerCliente();
                clienteSQL.selecionar(codigo, dsFROGIOS.CLIENTE, efisico ? dsFROGIOS.CLIENTE_FISICO : null, efisico ? null : dsFROGIOS.CLIENTE_JURIDICO);
                textCliente.Text = efisico ? ((dsFROGIOS.CLIENTE_FISICORow)dsFROGIOS.CLIENTE_FISICO.Rows[0]).CLIENTE_FISICO_NOME : ((dsFROGIOS.CLIENTE_JURIDICORow)dsFROGIOS.CLIENTE_JURIDICO.Rows[0]).CLIENTE_JURIDICO_FANTASIA;
                textTelefone.Text = ((dsFROGIOS.CLIENTERow)dsFROGIOS.CLIENTE.Rows[0]).CLIENTE_TELEFONE;
                textCelular.Text = ((dsFROGIOS.CLIENTERow)dsFROGIOS.CLIENTE.Rows[0]).CLIENTE_CELULAR;
            } catch (Exception erro) {
                exibirMensagemErro(erro.Message);
            } finally {
                Conexao.fechar();
            }
        }

        private void textCliente_DoubleClick(object sender, EventArgs e) {
            formPesquisaCliente cliente = new formPesquisaCliente(this, false);
            cliente.ShowDialog();
            cliente.Dispose();
        }
    }
}
