using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using FROGI_OS.CamadaAcessoDados;

namespace FROGI_OS
{
   
    public partial class formClientePesquisa : Form {
        
        public formClientePesquisa() {
            InitializeComponent();
        }

        private void pesquisar() {
            //clienteAtual = null;
            tabClienteJuridico.SelectedTab = tabPesquisa;
            controles(true, false, false, false, false);
            campos(false, false);
            dsFROGIOS.CLIENTE_FISICO.Clear();
            dsFROGIOS.CLIENTE_JURIDICO.Clear();
            dsFROGIOS.CLIENTE.Clear();
            dsFROGIOS.UF.Clear();
            this.ActiveControl = cbTipoCliente;
        }

        /// <summary>
        /// Quando um novo registro for criado
        /// esse método deve ser chamado
        /// </summary>
        private void novoRegistro() {
            formDialogo dialogo = new formDialogo("Quer cadastrar um novo cliente?", "", formDialogo.TipoExpressao.Pergunta);
            DialogResult resultado = dialogo.ShowDialog();
            dialogo.Dispose();
            if (resultado == System.Windows.Forms.DialogResult.No) {
                return;
            }
            tabClienteJuridico.SelectedTab = tabCliente;
            tabCadastro.SelectedTab = tabFisica;
            comboTipoCliente.SelectedIndex = 0;
            campos(true, false);
            //O por que disso?
            //Defino esses controles para ficarem invisíveis
            //pois não quero que eles sejam exibidos durante
            //o cadastro de um novo registro
            labelCodigoLabel.Visible = false;
            labelDataCadastroLabel.Visible = false;
            labelCodigo.Visible = false;
            labelData.Visible = false;
            comboTipoCliente.Visible = true;
            controles(false, false, false, true, true);
        }

        /// <summary>
        /// Método para salvar ou atualizar um cliente no banco de dados
        /// </summary>
        private void salvarRegistro() {
            formDialogo dialogo;

            string validacao = validarCampos();
            if (validacao != "") {
                dialogo = new formDialogo(validacao, "", formDialogo.TipoExpressao.AvisoTriste);
                dialogo.ShowDialog();
                dialogo.Dispose();
                return;
            }

            dialogo = new formDialogo("Quer salvar as informações deste cliente?", "", formDialogo.TipoExpressao.Pergunta);
            DialogResult resultado = dialogo.ShowDialog();
            dialogo.Dispose();
            if (resultado == System.Windows.Forms.DialogResult.No) {
                return;
            }
            //Um cliente terá relação com um UF, cliente físico ou jurídico
            TblUF uf = null;
            TblClienteFisico fisico;
            TblClienteJuridico juridico;

            if (true) {
                fisico = null;
                juridico = null;
            } else {
                //fisico = clienteAtual.fisico;
                //juridico = clienteAtual.juridico;
            }

            try {
                //Com base no UF selecionado tenho de ir ao banco de dados
                //perguntar se ele tem o UF selecionado, se tiver ele
                //vai me retornar o código daquele UF pra ser colocado
                //no cliente atual
                object ufItem = uF_DESCRICAOComboBox.SelectedItem;
                if (ufItem != null) {
                    //uf = new TblUF((dsFROGIOS.UFRow)taUF.GetByDescricao(ufItem.ToString()).Rows[0]);
                } else {
                    MessageBox.Show("Faltou você escolher um UF para o cliente");
                    return;
                }
            } catch (Exception erro) {
                MessageBox.Show(erro.Message);
                return;
            }
            //Este é uma loucura
            //Cada um desses é um decimal que quero preencher
            //Com um valor retirado de uma string
            //Caso a string não possa ser convertida
            //corretamente para decimal, um erro será
            //levantado, logo o valor do decimal deverá ser 0
            decimal salario, limite, limiteAtual;
            try { salario = Convert.ToDecimal(cLIENTE_FISICO_SALARIOMaskedTextBox.Text); } catch (Exception) { salario = 0; }
            try { limite = Convert.ToDecimal(cLIENTE_FISICO_LIMITETextBox.Text); } catch (Exception) { limite = 0; }
            try { limiteAtual = Convert.ToDecimal(cLIENTE_FISICO_LIMITE_ATUALTextBox.Text); } catch (Exception) { limiteAtual = 0; }
            //Este é simples, pego o que tá digitado nos campos
            //do formulário e coloco no objeto Fisico ou Juridico
            if (true) {
                //if (fisico == null) fisico = new TblClienteFisico();
                //fisico.compactar(
                //    cLIENTE_FISICO_NOMETextBox.Text,
                //    cLIENTE_FISICO_CPFMaskedTextBox.Text,
                //    cLIENTE_FISICO_RGTextBox.Text,
                //    cLIENTE_FISICO_NASCIMENTODateTimePicker.Value.Date,
                //    cLIENTE_FISICO_SEXOComboBox.SelectedItem.ToString(),
                //    cLIENTE_FISICO_ESTADO_CIVILTextBox.Text,
                //    cLIENTE_FISICO_PROFISSAOTextBox.Text,
                //    salario,
                //    limite,
                //    limiteAtual,
                //    cLIENTE_FISICO_MAETextBox.Text,
                //    cLIENTE_FISICO_PAITextBox.Text,
                //    cLIENTE_FISICO_OBSERVACAORichTextBox.Text);
            } else if (true) {
                //if (juridico == null) juridico = new TblClienteJuridico();
                //juridico.compactar(
                //    cLIENTE_JURIDICO_RAZAO_SOCIALTextBox.Text,
                //    cLIENTE_JURIDICO_CNPJMaskedTextBox.Text,
                //    cLIENTE_JURIDICO_IEMaskedTextBox.Text,
                //    cLIENTE_JURIDICO_FANTASIATextBox.Text,
                //    cLIENTE_JURIDICO_ATIVIDADETextBox.Text,
                //    cLIENTE_JURIDICO_NOME_CONTATOTextBox.Text);
            }
            //Por que isso ta aqui?
            /**
             * É pra evitar repetição,
             * caso um cliente eteja sendo editado
             * temos de pegar a data que ele carrega no registro dele,
             * senão, a data atual do sistema deve ser coletada
             */
            DateTime dataCadastro;
            string tipo_antigo;
            bool novo = false; //O novo aqui é uma gambiarra, define se eu vou ou inserir ou atualizar o cliente. É feio mas funciona...
            if (true) {
                //clienteAtual = new TblCliente();
                dataCadastro = DateTime.Today;
                //tipo_antigo = tipo_atual.ToString();
                novo = true;
            } else {
                //dataCadastro = clienteAtual.dataCadastro;
                //tipo_antigo = clienteAtual.tipo;
            }
            //clienteAtual.compactar(
            //    tipo_atual.ToString(),
            //    cLIENTE_TELEFONEMaskedTextBox.Text,
            //    cLIENTE_CELULARMaskedTextBox.Text,
            //    cLIENTE_EMAILTextBox.Text,
            //    cLIENTE_ENDERECOTextBox.Text,
            //    cLIENTE_BAIRROTextBox.Text,
            //    cLIENTE_PERIMETROTextBox.Text,
            //    cLIENTE_CIDADETextBox.Text,
            //    cLIENTE_CEPMaskedTextBox.Text,
            //    dataCadastro,
            //    uf,
            //    fisico,
            //    juridico);

            try {
                if (novo == true) {
                    //clienteAtual.inserir();
                } else {
                    //clienteAtual.atualizar(tipo_antigo, tipo_atual.ToString());
                }
                dialogo = new formDialogo("Pronto! As informações do cliente foram salvas", "", formDialogo.TipoExpressao.AvisoFeliz);
                dialogo.ShowDialog();
                dialogo.Dispose();
                pesquisar();
            } catch (Exception erro) {
                dialogo = new formDialogo("Essa não! Tivemos um pequeno problema", erro.Message, formDialogo.TipoExpressao.AvisoTriste);
                dialogo.ShowDialog();
                dialogo.Dispose();
            }
        }
        
        /// <summary>
        /// Chame esse aqui quando precisar liberar os campos para edição
        /// </summary>
        private void editarRegistro() {
            campos(true, true);
            controles(false, false, false, true, true);
        }
        
        /// <summary>
        /// Quando quiser excluir um registro, este método deve ser chamado
        /// </summary>
        private void excluirRegistro() {
            formDialogo dialogo = new formDialogo("Tem certeza que quer excluir este cliente?", "Não vai dar pra recuperar ele depois!", formDialogo.TipoExpressao.Pergunta);
            DialogResult resultado = dialogo.ShowDialog();
            dialogo.Dispose();
            if (resultado == System.Windows.Forms.DialogResult.No) {
                return;
            }
            try {
                //clienteAtual.deletar();
                dialogo = new formDialogo("Cliente excluido com sucesso", "Vai fazer falta...", formDialogo.TipoExpressao.AvisoTriste);
                dialogo.ShowDialog();
                dialogo.Dispose();
            } catch (Exception erro) {
                dialogo = new formDialogo("Essa não! Tivemos um pequeno problema", erro.Message, formDialogo.TipoExpressao.AvisoTriste);
                dialogo.ShowDialog();
                dialogo.Dispose();
            }
            
            pesquisar();
        }

        /// <summary>
        /// Este método ficou com uma cara miserável de complicada. Este é engatilado quando
        /// uma linha do DataGridView é clicada duas vezes. Isso significa que o usuário quer
        /// visualizar aquele registro
        /// </summary>
        private void visualizarClienteFisico() {
            //1º - essas três linhas servem para pegar o código do cliente selecionado [sei, é muita puta merda pra pouca coisa]
            int indiceLinha = sP_CLIENTE_FISICO_PESQUISADataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow linha = sP_CLIENTE_FISICO_PESQUISADataGridView.Rows[indiceLinha];
            int codigo = Convert.ToInt32(linha.Cells["codigoFisico"].Value);
            //2º - limpamos os datatables que seguravam alguma informação nos DataGridViews
            dsFROGIOS.SP_CLIENTE_FISICO_PESQUISA.Clear();
            dsFROGIOS.SP_CLIENTE_JURIDICO_PESQUISA.Clear();
            //3º - com o código do cliente voltamos ao banco de dados para pegar todas as informações do cliente
            //já que o DataGridView somente carregava algumas informações
            //TODO Na pesquisa de clientes, ao buscar os dados, todas as colunas devem ser retornadas na query para que tudo seja trablahado na memória sem precisar voltar a acessar o banco de dados
            taCliente.FillByCodigo(dsFROGIOS.CLIENTE, codigo);
            taClienteFisico.FillByCliente(dsFROGIOS.CLIENTE_FISICO, codigo);
            //Nesse aqui tenho que recorrer ao datatable CLIENTE para pegar o código da UF
            taUF.FillByCodigo(dsFROGIOS.UF, (int)dsFROGIOS.CLIENTE.Rows[0][dsFROGIOS.CLIENTE.CLIENTE_UFColumn]);
            //4º - algumas alterações na GUI...
            tabClienteJuridico.SelectedTab = tabCliente;
            controles(false, true, true, false, true);
            campos(false, true);
            comboTipoCliente.SelectedIndex = 0;
            //5º - Objeto clienteAtual é inicializado
            //clienteAtual = new TblCliente(
            //    (dsFROGIOS.CLIENTERow)dsFROGIOS.CLIENTE.Rows[0],
            //    (dsFROGIOS.CLIENTE_FISICORow)dsFROGIOS.CLIENTE_FISICO.Rows[0],
            //    null,
            //    (dsFROGIOS.UFRow)dsFROGIOS.UF.Rows[0]);
        }

        /// <summary>
        /// Este método ficou com uma cara miserável de complicada. Este é engatilado quando
        /// uma linha do DataGridView é clicada duas vezes. Isso significa que o usuário quer
        /// visualizar aquele registro
        /// </summary>
        private void visualizarClienteJuridico() {
            //1º - essas três linhas servem para pegar o código do cliente selecionado [sei, é muita puta merda pra pouca coisa]
            int indiceLinha = sP_CLIENTE_JURIDICO_PESQUISADataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow linha = sP_CLIENTE_JURIDICO_PESQUISADataGridView.Rows[indiceLinha];
            int codigo = Convert.ToInt32(linha.Cells["codigoJuridico"].Value);
            //2º - limpamos os datatables que seguravam alguma informação nos DataGridViews
            dsFROGIOS.SP_CLIENTE_FISICO_PESQUISA.Clear();
            dsFROGIOS.SP_CLIENTE_JURIDICO_PESQUISA.Clear();
            //3º - com o código do cliente voltamos ao banco de dados para pegar todas as informações do cliente
            //já que o DataGridView somente carregava algumas informações
            //TODO Na pesquisa de clientes, ao buscar os dados, todas as colunas devem ser retornadas na query para que tudo seja trablahado na memória sem precisar voltar a acessar o banco de dados
            taCliente.FillByCodigo(dsFROGIOS.CLIENTE, codigo);
            taClienteJuridico.FillByCliente(dsFROGIOS.CLIENTE_JURIDICO, codigo);
            //Nesse aqui tenho que recorrer ao datatable CLIENTE para pegar o código da UF
            taUF.FillByCodigo(dsFROGIOS.UF, (int)dsFROGIOS.CLIENTE.Rows[0][dsFROGIOS.CLIENTE.CLIENTE_UFColumn]);
            //4º - algumas alterações na GUI...
            tabClienteJuridico.SelectedTab = tabCliente;
            controles(false, true, true, false, true);
            campos(false, true);
            comboTipoCliente.SelectedIndex = 1;
            //5º - Objeto clienteAtual é inicializado
            //clienteAtual = new TblCliente(
            //    (dsFROGIOS.CLIENTERow)dsFROGIOS.CLIENTE.Rows[0],
            //    null,
            //    (dsFROGIOS.CLIENTE_JURIDICORow)dsFROGIOS.CLIENTE_JURIDICO.Rows[0],
            //    (dsFROGIOS.UFRow)dsFROGIOS.UF.Rows[0]);
        }

        /// <summary>
        /// Durante a pesquisa, caso queira mudar entre procurar um cliente
        /// físico ou jurídico, este método será disparado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e) {
            string tipoCliente = cbTipoCliente.SelectedItem.ToString(); //Pego o tipo do cliente [físico ou jurídico]
            //Pego os datatables do dataset e coloco nesses objetos pra facilitar o trabalho
            DataTable dtFisico = dsFROGIOS.SP_CLIENTE_FISICO_PESQUISA;
            DataTable dtJuridico = dsFROGIOS.SP_CLIENTE_JURIDICO_PESQUISA;
            cbCampoPesquisa.Items.Clear(); //Limpo os itens que existem no combobox usado para escolher o campo para pesquisar
            if (true) {
                //Aqui pegamos os nomes das colunas que estão no datatable
                //e jogamos como itens para lista do combobox para escolher o campo de pesquisa
                foreach (DataColumn coluna in dtFisico.Columns) {
                    cbCampoPesquisa.Items.Add(coluna.ColumnName);
                }
                tabGridPesquisa.SelectedTab = tabFisicoPesquisa;
            } else if (true) {
                //Aqui pegamos os nomes das colunas que estão no datatable
                //e jogamos como itens para lista do combobox para escolher o campo de pesquisa
                foreach (DataColumn coluna in dtJuridico.Columns) {
                    cbCampoPesquisa.Items.Add(coluna.ColumnName);
                }
                tabGridPesquisa.SelectedTab = tabJuridicoPesquisa;
            }
            //Aqui liberamos e bloquemos alguns controles
            //Importante manter os que estão em false como false
            //senão erros irao acontecer
            cbCampoPesquisa.Enabled = true;
            textCampoPesquisa.Enabled = false;
            buttonPesquisar.Enabled = false;
            this.ActiveControl = cbTipoCliente;
        }
        
        /// <summary>
        /// Quando o botao pesquisar for pressionado uma pesquisa será feita
        /// no banco de dados com base nos dados dos campos preenchidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPesquisar_Click(object sender, EventArgs e) {
            /*
             * Eu quer saber, respectivamente:
             * - o tipo do cliente
             * - a coluna que deve ser usada para pesquisa
             * - o valor que será usado para pesquisa
             */
            string tipoCliente = cbTipoCliente.SelectedItem.ToString();
            string campo = cbCampoPesquisa.SelectedItem.ToString();
            string valor = textCampoPesquisa.Text;
            //Conforme o tipo de cliente o DataGridView será preenchido com o resultado
            if (true) {
                taClienteFisicoPesquisa.Fill(dsFROGIOS.SP_CLIENTE_FISICO_PESQUISA, campo, valor);
                this.ActiveControl = sP_CLIENTE_FISICO_PESQUISADataGridView;
            } else if (true) {
                taClienteJuridicoPesquisa.Fill(dsFROGIOS.SP_CLIENTE_JURIDICO_PESQUISA, campo, valor);
                this.ActiveControl = sP_CLIENTE_JURIDICO_PESQUISADataGridView;
            }
        }
        
        /// <summary>
        /// Quando escolhermos um valor neste combobox, este método será disparado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCampoPesquisa_SelectedIndexChanged(object sender, EventArgs e) {
            //Simples, quando um campo for selecionado
            //Significa que podemos digitar um valor
            //e clicar no botão pesquisar
            textCampoPesquisa.Enabled = true;
            buttonPesquisar.Enabled = true;
        }
        
        /// <summary>
        /// Este útil método muda a visibilidade dos controles
        /// de CRUD do formulário
        /// </summary>
        /// <param name="novo"></param>
        /// <param name="editar"></param>
        /// <param name="excluir"></param>
        /// <param name="salvar"></param>
        /// <param name="pesquisar"></param>
        private void controles(bool novo, bool editar, bool excluir, bool salvar, bool pesquisar) {
            pictureNovo.Visible = novo;
            pictureEditar.Visible = editar;
            pictureExcluir.Visible = excluir;
            pictureSalvar.Visible = salvar;
            picturePesquisar.Visible = pesquisar;
        }
        
        /// <summary>
        /// Quando for necessário bloquear ou desbloquear os campos do formulário
        /// basta chamar este método. Defina taDisponivle como true para liberar os campos,
        /// false para bloquear. taVisualizando serve para mudar a visibilidade de alguns
        /// controles na tela, deve ser true quando se estiver visualizando um registro
        /// e false quando se estive inserindo um novo registro
        /// </summary>
        /// <param name="taDisponivel"></param>
        /// <param name="taVisualizando"></param>
        private void campos(bool taDisponivel, bool taVisualizando) {
            panelCliente.Enabled = taDisponivel;
            panelFisico.Enabled = taDisponivel;
            panelJuridica.Enabled = taDisponivel;
            comboTipoCliente.Enabled = taDisponivel;

            labelCodigoLabel.Visible = taVisualizando;
            labelDataCadastroLabel.Visible = taVisualizando;
            labelCodigo.Visible = taVisualizando;
            labelData.Visible = taVisualizando;
            comboTipoCliente.Visible = taVisualizando;
        }
        
        /// <summary>
        /// Bem... Fecha a janela e destroi o Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureFechar_Click(object sender, EventArgs e) {
            Dispose();
        }
        
        /// <summary>
        /// Gatilho pra iniciar o processo de inserção de novo registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureNovo_Click(object sender, EventArgs e) {
            novoRegistro();
        }
        
        /// <summary>
        /// Quando o tipo de cliente durante o cadastro for alterado,
        /// este método é chamado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboTipoCliente_SelectedIndexChanged(object sender, EventArgs e) {
            /*
             * Sinceramente toda essa verificação feita antes de começar a fazer algo
             * se deve ao programa estar chamando este método durante a transação de 
             * Abas no objeto tabPai. Então devo verificar se as coisas estõa null ou não
             */ 
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox != null){
                object itemSelcionado = comboBox.SelectedItem;
                //Simples: se for físico tipo_atual vira físico, senão virá jurídico
                if (itemSelcionado != null && true) {
                    tabCadastro.SelectedTab = tabFisica;
                    //tipo_atual = CLIENTE_FISICO;
                } else if (itemSelcionado != null && true) {
                    tabCadastro.SelectedTab = tabJuridica;
                    //tipo_atual = CLIENTE_JURIDICO;
                }
            }
            
        }

        /// <summary>
        /// Gatilho para iniciar o processo de salva do registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureSalvar_Click(object sender, EventArgs e) {
            salvarRegistro();
        }

        /// <summary>
        /// Gatilho para iniciar o processo de edição do registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureEditar_Click(object sender, EventArgs e) {
            editarRegistro();
        }

        /// <summary>
        /// Gatilho para iniciar o processo de exclusão do registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureExcluir_Click(object sender, EventArgs e) {
            excluirRegistro();
        }

        ///<summary>
        ///Gatilho para visualizar um registro
        ///</summary>>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sP_CLIENTE_FISICO_PESQUISADataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            visualizarClienteFisico();
        }

        /// <summary>
        /// Gatilho para visualizar um registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sP_CLIENTE_JURIDICO_PESQUISADataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            visualizarClienteJuridico();
        }

        /// <summary>
        /// Gatilho para iniciar o processo de pesquisa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picturePesquisar_Click(object sender, EventArgs e) {
            formDialogo dialogo = new formDialogo("Deseja pesquisar outro cliente?", "O que não foi salvo será perdido!", formDialogo.TipoExpressao.Pergunta);
            DialogResult resultado = dialogo.ShowDialog();
            if (resultado == System.Windows.Forms.DialogResult.Yes) {
                pesquisar();
            }
        }

        private void sP_CLIENTE_FISICO_PESQUISADataGridView_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                visualizarClienteFisico();        
            }
        }

        private void sP_CLIENTE_JURIDICO_PESQUISADataGridView_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                visualizarClienteJuridico();
            }
        }

        private void tabPai_KeyDown(object sender, KeyEventArgs e) {
            if ((e.Control && e.KeyCode == Keys.N) && (pictureNovo.Visible)) {
                novoRegistro();
            } else if ((e.Control && e.KeyCode == Keys.E) && pictureEditar.Visible) {
                editarRegistro();
            } else if ((e.Control && e.KeyCode == Keys.D) && pictureExcluir.Visible) {
                excluirRegistro();
            } else if ((e.Control && e.KeyCode == Keys.S) && pictureSalvar.Visible) {
                salvarRegistro();
            } else if ((e.Control && e.KeyCode == Keys.P) && picturePesquisar.Visible) {
                formDialogo dialogo = new formDialogo("Deseja pesquisar outro cliente?", "O que não foi salvo será perdido!",  formDialogo.TipoExpressao.Pergunta);
                DialogResult resultado = dialogo.ShowDialog();
                if (resultado == System.Windows.Forms.DialogResult.Yes) {
                    pesquisar();
                }
            }
        }

        private string validarCampos() {
            if (true) {
                if (String.IsNullOrWhiteSpace(cLIENTE_FISICO_NOMETextBox.Text)) return "Me diga o nome do cliente";
            } else if (true) {
                if (String.IsNullOrWhiteSpace(cLIENTE_JURIDICO_FANTASIATextBox.Text)) {
                    return "Me diga o nome fantasia da empresa do cliente";
		        } else if (String.IsNullOrWhiteSpace(cLIENTE_JURIDICO_NOME_CONTATOTextBox.Text)) {
                    return "Me diga o nome do representante da empresa do cliente";
		        }
            }
            if (String.IsNullOrWhiteSpace(cLIENTE_TELEFONEMaskedTextBox.Text) && String.IsNullOrWhiteSpace(cLIENTE_CELULARMaskedTextBox.Text)) {
                return "Me diga um número de contato do cliente";
            } else if (String.IsNullOrWhiteSpace(cLIENTE_ENDERECOTextBox.Text)) {
                return "Me diga o endereço do cliente";
            } else if (String.IsNullOrWhiteSpace(cLIENTE_BAIRROTextBox.Text)) {
                return "Me diga o bairro aonde o cliente mora";
            } else if (String.IsNullOrWhiteSpace(cLIENTE_CIDADETextBox.Text)) {
                return "Me diga a cidade que o cliente vive";
            } else if (uF_DESCRICAOComboBox.SelectedItem == null) {
                return "Me diga em que estado o cliente mora";
            } else {
                return "";
            }
        }

    }
}
