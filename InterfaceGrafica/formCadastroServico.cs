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
    public partial class formCadastroServico : formCadastro {

        private GerServico servicoSQL; //SQL tá tudo nessa bagaça
        private TblTipo tipoSQL; //SQL tem aqui também :D
        private formDialogo dialogo;

        public formCadastroServico(bool pesquisaHabilitado) : base(pesquisaHabilitado) {
            InitializeComponent();
            if (pesquisaHabilitado)
                pesquisa = new formPesquisaServico(this, false);
            
            servicoSQL = new GerServico();
            tipoSQL = new TblTipo();
            dialogo = new formDialogo();

            dsFROGIOS.EnforceConstraints = false;
        }

        protected override void novoRegistro() {
            base.novoRegistro();
            this.ActiveControl = sERVICO_DESCRICAOTextBox;
        }

        protected override void salvaExecutar() {
            //Quando tem porra nenhuma é porque tamo inserindo um novo registro
            if (dsFROGIOS.SERVICO.Rows.Count == 0) {
                servicoSQL.inserir(pegaValorCamposServico(null), dsFROGIOS.TIPO);
            } else {
                int codigo = ((dsFROGIOS.SERVICORow)dsFROGIOS.SERVICO.Rows[0]).SERVICO_CODIGO; //aqui pego o código do caramba do serviço :T
                servicoSQL.atualizar(pegaValorCamposServico(codigo), dsFROGIOS.TIPO);
            }
        }

        private dsFROGIOS.SERVICORow pegaValorCamposServico (Object codigo) {

            dsFROGIOS.SERVICORow servicoRow = dsFROGIOS.SERVICO.NewSERVICORow();
            if (codigo != null)
                servicoRow.SERVICO_CODIGO = (int) codigo;

            servicoRow.SERVICO_DESCRICAO = sERVICO_DESCRICAOTextBox.Text;
            try  {servicoRow.SERVICO_VALOR = Convert.ToDecimal(sERVICO_VALORTextBox.Text);} catch (Exception){servicoRow.SERVICO_VALOR = 0;} //Conversão de string para deciaml, se der pau o valor que vai pro BD é ZERO ~ que nem minha tolerância

            return servicoRow;
        }

        protected override void editarRegistro() {
            base.editarRegistro();
            this.ActiveControl = sERVICO_DESCRICAOTextBox;
        }

        protected override void excluiExecutar() {
            servicoSQL.deletar((dsFROGIOS.SERVICORow)dsFROGIOS.SERVICO[0]);
        }

        protected override void resetar() {
            base.resetar();
            if (dsFROGIOS != null)
            {
                dsFROGIOS.SERVICO.Clear();
                dsFROGIOS.TIPO.Clear();
                dsFROGIOS.SERVICO_TIPO.Clear();
            }
        }

        protected override void campos(bool estaDisponivel) {
            base.campos(estaDisponivel);
        }

        protected override string validarCampos() {

            string
                descricao = sERVICO_DESCRICAOTextBox.Text,
                valor = sERVICO_VALORTextBox.Text;

            int
                quantidadeTipos = dsFROGIOS.TIPO.Rows.Count;

            if (!valorValido(descricao)) return "Informe uma descrição para o serviço";
            if (!valorValido(valor)) return "Informe o valor do serviço";
            if (quantidadeTipos == 0) return "Informe ao menos um tipo de serviço";

            return base.validarCampos();
        }

        protected override void visualizarRegistroExecutar(int codigo) {
            servicoSQL.selecionar(codigo, dsFROGIOS.SERVICO, dsFROGIOS.TIPO);
        }

        
        public void adicionarTipo(int codigo) {
            //Negócinho cumplicado XP
            string coluna = dsFROGIOS.TIPO.TIPO_CODIGOColumn.ColumnName; //Pegamo valor aqui 
            string valor;
            try { valor = Convert.ToString(codigo);}catch (Exception) { valor = "-5"; }
            dsFROGIOS.TIPODataTable tipoTabela = new FROGI_OS.dsFROGIOS.TIPODataTable(); //depois criamos um objeto de tabela 
            tipoTabela.Load(tipoSQL.selecionar(coluna, valor, true)); //para usar o método Load que já pega o resultado da query no formato desejado (não sei fazer isso de outra forma XP)
            int codigoTipo = ((dsFROGIOS.TIPORow)tipoTabela.Rows[0]).TIPO_CODIGO;
            if (dsFROGIOS.TIPO.FindByTIPO_CODIGO(codigoTipo) == null) {
                dsFROGIOS.TIPO.Rows.Add(tipoTabela.Rows[0].ItemArray); //Depois adicionamos a row ao DataSet
            }
        }

        private void buttonAdicionarTipo_Click(object sender, EventArgs e)  {
            formPesquisaTipo pesquisaTipoServico = new formPesquisaTipo(this, false);
            pesquisaTipoServico.ShowDialog();
            pesquisaTipoServico.Dispose();
        }
    }

}