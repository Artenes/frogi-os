namespace FROGI_OS.InterfaceGrafica
{
    partial class formCadastroOrcamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label oRCAMENTO_PRODUTOLabel;
            System.Windows.Forms.Label oRCAMENTO_DEFEITOLabel;
            System.Windows.Forms.Label oRCAMENTO_AVULSOSLabel;
            System.Windows.Forms.Label oRCAMENTO_OBSERVACAOLabel;
            System.Windows.Forms.Label pRODUTO_DESCRICAOLabel;
            System.Windows.Forms.Label pRODUTO_PRECO_VENDALabel;
            System.Windows.Forms.Label sERVICO_DESCRICAOLabel;
            System.Windows.Forms.Label sERVICO_VALORLabel;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label oRCAMENTO_DIAGNOSTICOLabel;
            System.Windows.Forms.Label oRCAMENTO_DESCONTOLabel;
            System.Windows.Forms.Label oRCAMENTO_ACRESCIMOLabel;
            this.bsOrcamento = new System.Windows.Forms.BindingSource(this.components);
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.labelFuncionario = new System.Windows.Forms.Label();
            this.bsFuncionario = new System.Windows.Forms.BindingSource(this.components);
            this.oRCAMENTO_DATALabel1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textTotalBruto = new WindowsFormsApplication2.Monetario();
            this.textTotalServicos = new WindowsFormsApplication2.Monetario();
            this.textTotalPecas = new WindowsFormsApplication2.Monetario();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bsFisico = new System.Windows.Forms.BindingSource(this.components);
            this.bsJuridico = new System.Windows.Forms.BindingSource(this.components);
            this.groupData = new System.Windows.Forms.GroupBox();
            this.oRCAMENTO_PRODUTOTextBox = new System.Windows.Forms.TextBox();
            this.oRCAMENTO_DEFEITORichTextBox = new System.Windows.Forms.RichTextBox();
            this.oRCAMENTO_AVULSOSRichTextBox = new System.Windows.Forms.RichTextBox();
            this.oRCAMENTO_OBSERVACAORichTextBox = new System.Windows.Forms.RichTextBox();
            this.oRCAMENTO_ITEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRCAMENTO_ITEMDataGridView = new System.Windows.Forms.DataGridView();
            this.oRCAMENTOITEMDESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaProdutoPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaProdutoDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRCAMENTOITEMQUANTIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaProdutoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUTO_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.pRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textPecaQuantidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupProduto = new System.Windows.Forms.GroupBox();
            this.textProdutoPreco = new WindowsFormsApplication2.Monetario();
            this.textPecaDesconto = new WindowsFormsApplication2.Monetario();
            this.buttonPesquisarProduto = new System.Windows.Forms.Button();
            this.buttonLancarProduto = new System.Windows.Forms.Button();
            this.groupServico = new System.Windows.Forms.GroupBox();
            this.textServicoValor = new WindowsFormsApplication2.Monetario();
            this.sERVICOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textServicoAcrescimo = new WindowsFormsApplication2.Monetario();
            this.textServicoDesconto = new WindowsFormsApplication2.Monetario();
            this.sERVICO_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.buttonPesquisarServico = new System.Windows.Forms.Button();
            this.buttonLancarServico = new System.Windows.Forms.Button();
            this.oRCAMENTO_SERVICODataGridView = new System.Windows.Forms.DataGridView();
            this.colunaServicoDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaServicoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaServicoDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaServicoAcrescimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaServicoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRCAMENTO_SERVICOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRCAMENTO_DIAGNOSTICORichTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonLancarOS = new System.Windows.Forms.Button();
            this.taFisico = new FROGI_OS.dsFROGIOSTableAdapters.CLIENTE_FISICOTableAdapter();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.taJuridico = new FROGI_OS.dsFROGIOSTableAdapters.CLIENTE_JURIDICOTableAdapter();
            this.taFuncionario = new FROGI_OS.dsFROGIOSTableAdapters.FUNCIONARIOTableAdapter();
            this.taOrcamento = new FROGI_OS.dsFROGIOSTableAdapters.ORCAMENTOTableAdapter();
            this.oRCAMENTO_ITEMTableAdapter = new FROGI_OS.dsFROGIOSTableAdapters.ORCAMENTO_ITEMTableAdapter();
            this.pRODUTOTableAdapter = new FROGI_OS.dsFROGIOSTableAdapters.PRODUTOTableAdapter();
            this.sERVICOTableAdapter = new FROGI_OS.dsFROGIOSTableAdapters.SERVICOTableAdapter();
            this.oRCAMENTO_SERVICOTableAdapter = new FROGI_OS.dsFROGIOSTableAdapters.ORCAMENTO_SERVICOTableAdapter();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panelDesconto_Acrescimo = new System.Windows.Forms.Panel();
            this.textOrcamentoAcresicmo = new WindowsFormsApplication2.Monetario();
            this.textOrcamentoDesconto = new WindowsFormsApplication2.Monetario();
            this.buttonAplicar = new System.Windows.Forms.Button();
            this.labelTotalLiquido = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            oRCAMENTO_PRODUTOLabel = new System.Windows.Forms.Label();
            oRCAMENTO_DEFEITOLabel = new System.Windows.Forms.Label();
            oRCAMENTO_AVULSOSLabel = new System.Windows.Forms.Label();
            oRCAMENTO_OBSERVACAOLabel = new System.Windows.Forms.Label();
            pRODUTO_DESCRICAOLabel = new System.Windows.Forms.Label();
            pRODUTO_PRECO_VENDALabel = new System.Windows.Forms.Label();
            sERVICO_DESCRICAOLabel = new System.Windows.Forms.Label();
            sERVICO_VALORLabel = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            oRCAMENTO_DIAGNOSTICOLabel = new System.Windows.Forms.Label();
            oRCAMENTO_DESCONTOLabel = new System.Windows.Forms.Label();
            oRCAMENTO_ACRESCIMOLabel = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.tabPai.SuspendLayout();
            this.tabInfoItem.SuspendLayout();
            this.tabPecas.SuspendLayout();
            this.tabServicos.SuspendLayout();
            this.tabDiagnostico.SuspendLayout();
            this.tabGeral.SuspendLayout();
            this.panelGeral.SuspendLayout();
            this.panelInfoItem.SuspendLayout();
            this.panelPecas.SuspendLayout();
            this.panelServicos.SuspendLayout();
            this.panelDiagnostico.SuspendLayout();
            this.panelRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditar)).BeginInit();
            this.panelCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFisico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJuridico)).BeginInit();
            this.groupData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRCAMENTO_ITEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRCAMENTO_ITEMDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).BeginInit();
            this.groupProduto.SuspendLayout();
            this.groupServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRCAMENTO_SERVICODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRCAMENTO_SERVICOBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panelDesconto_Acrescimo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.Controls.Add(this.buttonLancarOS);
            this.panelCabecalho.Size = new System.Drawing.Size(800, 92);
            this.panelCabecalho.Controls.SetChildIndex(this.labelBase, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.buttonLancarOS, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.pictureFechar, 0);
            // 
            // pictureFechar
            // 
            this.pictureFechar.Location = new System.Drawing.Point(730, 13);
            // 
            // tabPai
            // 
            this.tabPai.Location = new System.Drawing.Point(0, 92);
            this.tabPai.Size = new System.Drawing.Size(800, 429);
            this.tabPai.SelectedIndexChanged += new System.EventHandler(this.tabPai_SelectedIndexChanged);
            // 
            // tabInfoItem
            // 
            this.tabInfoItem.Size = new System.Drawing.Size(792, 388);
            // 
            // tabPecas
            // 
            this.tabPecas.Size = new System.Drawing.Size(792, 388);
            // 
            // tabServicos
            // 
            this.tabServicos.Size = new System.Drawing.Size(792, 388);
            // 
            // tabDiagnostico
            // 
            this.tabDiagnostico.Size = new System.Drawing.Size(792, 388);
            // 
            // tabGeral
            // 
            this.tabGeral.AutoScroll = true;
            this.tabGeral.Size = new System.Drawing.Size(792, 388);
            // 
            // labelBase
            // 
            this.labelBase.Size = new System.Drawing.Size(251, 62);
            this.labelBase.Text = "Orçamento";
            // 
            // panelGeral
            // 
            this.panelGeral.AutoScroll = true;
            this.panelGeral.Controls.Add(this.groupBox4);
            this.panelGeral.Controls.Add(this.groupBox5);
            this.panelGeral.Controls.Add(this.groupData);
            this.panelGeral.Controls.Add(this.groupBox3);
            this.panelGeral.Size = new System.Drawing.Size(786, 382);
            // 
            // panelInfoItem
            // 
            this.panelInfoItem.AutoScroll = true;
            this.panelInfoItem.Controls.Add(oRCAMENTO_OBSERVACAOLabel);
            this.panelInfoItem.Controls.Add(this.oRCAMENTO_OBSERVACAORichTextBox);
            this.panelInfoItem.Controls.Add(oRCAMENTO_AVULSOSLabel);
            this.panelInfoItem.Controls.Add(this.oRCAMENTO_AVULSOSRichTextBox);
            this.panelInfoItem.Controls.Add(oRCAMENTO_DEFEITOLabel);
            this.panelInfoItem.Controls.Add(this.oRCAMENTO_DEFEITORichTextBox);
            this.panelInfoItem.Controls.Add(oRCAMENTO_PRODUTOLabel);
            this.panelInfoItem.Controls.Add(this.oRCAMENTO_PRODUTOTextBox);
            this.panelInfoItem.Size = new System.Drawing.Size(786, 382);
            // 
            // panelPecas
            // 
            this.panelPecas.AutoScroll = true;
            this.panelPecas.Controls.Add(this.buttonLancarProduto);
            this.panelPecas.Controls.Add(this.buttonPesquisarProduto);
            this.panelPecas.Controls.Add(this.groupProduto);
            this.panelPecas.Controls.Add(this.oRCAMENTO_ITEMDataGridView);
            this.panelPecas.Size = new System.Drawing.Size(786, 382);
            // 
            // panelServicos
            // 
            this.panelServicos.AutoScroll = true;
            this.panelServicos.Controls.Add(this.buttonLancarServico);
            this.panelServicos.Controls.Add(this.oRCAMENTO_SERVICODataGridView);
            this.panelServicos.Controls.Add(this.buttonPesquisarServico);
            this.panelServicos.Controls.Add(this.groupServico);
            this.panelServicos.Size = new System.Drawing.Size(786, 382);
            // 
            // panelDiagnostico
            // 
            this.panelDiagnostico.Controls.Add(oRCAMENTO_DIAGNOSTICOLabel);
            this.panelDiagnostico.Controls.Add(this.oRCAMENTO_DIAGNOSTICORichTextBox);
            this.panelDiagnostico.Size = new System.Drawing.Size(786, 382);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 25);
            label2.TabIndex = 8;
            label2.Text = "Peças";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(16, 74);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 25);
            label4.TabIndex = 10;
            label4.Text = "Serviços";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(17, 29);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 25);
            label5.TabIndex = 1;
            label5.Text = "Cliente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(17, 106);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(104, 25);
            label9.TabIndex = 5;
            label9.Text = "Funcionário";
            // 
            // oRCAMENTO_PRODUTOLabel
            // 
            oRCAMENTO_PRODUTOLabel.AutoSize = true;
            oRCAMENTO_PRODUTOLabel.Location = new System.Drawing.Point(11, 10);
            oRCAMENTO_PRODUTOLabel.Name = "oRCAMENTO_PRODUTOLabel";
            oRCAMENTO_PRODUTOLabel.Size = new System.Drawing.Size(214, 25);
            oRCAMENTO_PRODUTOLabel.TabIndex = 0;
            oRCAMENTO_PRODUTOLabel.Text = "Produto a ser concertado";
            // 
            // oRCAMENTO_DEFEITOLabel
            // 
            oRCAMENTO_DEFEITOLabel.AutoSize = true;
            oRCAMENTO_DEFEITOLabel.Location = new System.Drawing.Point(11, 79);
            oRCAMENTO_DEFEITOLabel.Name = "oRCAMENTO_DEFEITOLabel";
            oRCAMENTO_DEFEITOLabel.Size = new System.Drawing.Size(172, 25);
            oRCAMENTO_DEFEITOLabel.TabIndex = 2;
            oRCAMENTO_DEFEITOLabel.Text = "Relatório de defeito";
            // 
            // oRCAMENTO_AVULSOSLabel
            // 
            oRCAMENTO_AVULSOSLabel.AutoSize = true;
            oRCAMENTO_AVULSOSLabel.Location = new System.Drawing.Point(474, 79);
            oRCAMENTO_AVULSOSLabel.Name = "oRCAMENTO_AVULSOSLabel";
            oRCAMENTO_AVULSOSLabel.Size = new System.Drawing.Size(72, 25);
            oRCAMENTO_AVULSOSLabel.TabIndex = 4;
            oRCAMENTO_AVULSOSLabel.Text = "Avulsos";
            // 
            // oRCAMENTO_OBSERVACAOLabel
            // 
            oRCAMENTO_OBSERVACAOLabel.AutoSize = true;
            oRCAMENTO_OBSERVACAOLabel.Location = new System.Drawing.Point(474, 209);
            oRCAMENTO_OBSERVACAOLabel.Name = "oRCAMENTO_OBSERVACAOLabel";
            oRCAMENTO_OBSERVACAOLabel.Size = new System.Drawing.Size(106, 25);
            oRCAMENTO_OBSERVACAOLabel.TabIndex = 6;
            oRCAMENTO_OBSERVACAOLabel.Text = "Observação";
            // 
            // pRODUTO_DESCRICAOLabel
            // 
            pRODUTO_DESCRICAOLabel.AutoSize = true;
            pRODUTO_DESCRICAOLabel.Location = new System.Drawing.Point(17, 29);
            pRODUTO_DESCRICAOLabel.Name = "pRODUTO_DESCRICAOLabel";
            pRODUTO_DESCRICAOLabel.Size = new System.Drawing.Size(88, 25);
            pRODUTO_DESCRICAOLabel.TabIndex = 1;
            pRODUTO_DESCRICAOLabel.Text = "Descrição";
            // 
            // pRODUTO_PRECO_VENDALabel
            // 
            pRODUTO_PRECO_VENDALabel.AutoSize = true;
            pRODUTO_PRECO_VENDALabel.Location = new System.Drawing.Point(30, 75);
            pRODUTO_PRECO_VENDALabel.Name = "pRODUTO_PRECO_VENDALabel";
            pRODUTO_PRECO_VENDALabel.Size = new System.Drawing.Size(57, 25);
            pRODUTO_PRECO_VENDALabel.TabIndex = 3;
            pRODUTO_PRECO_VENDALabel.Text = "Preço";
            // 
            // sERVICO_DESCRICAOLabel
            // 
            sERVICO_DESCRICAOLabel.AutoSize = true;
            sERVICO_DESCRICAOLabel.Location = new System.Drawing.Point(18, 29);
            sERVICO_DESCRICAOLabel.Name = "sERVICO_DESCRICAOLabel";
            sERVICO_DESCRICAOLabel.Size = new System.Drawing.Size(88, 25);
            sERVICO_DESCRICAOLabel.TabIndex = 0;
            sERVICO_DESCRICAOLabel.Text = "Descrição";
            // 
            // sERVICO_VALORLabel
            // 
            sERVICO_VALORLabel.AutoSize = true;
            sERVICO_VALORLabel.Location = new System.Drawing.Point(15, 81);
            sERVICO_VALORLabel.Name = "sERVICO_VALORLabel";
            sERVICO_VALORLabel.Size = new System.Drawing.Size(53, 25);
            sERVICO_VALORLabel.TabIndex = 2;
            sERVICO_VALORLabel.Text = "Valor";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(468, 81);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(94, 25);
            label13.TabIndex = 6;
            label13.Text = "Acréscimo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(237, 81);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(88, 25);
            label14.TabIndex = 7;
            label14.Text = "Desconto";
            // 
            // oRCAMENTO_DIAGNOSTICOLabel
            // 
            oRCAMENTO_DIAGNOSTICOLabel.AutoSize = true;
            oRCAMENTO_DIAGNOSTICOLabel.Dock = System.Windows.Forms.DockStyle.Top;
            oRCAMENTO_DIAGNOSTICOLabel.Location = new System.Drawing.Point(0, 0);
            oRCAMENTO_DIAGNOSTICOLabel.Name = "oRCAMENTO_DIAGNOSTICOLabel";
            oRCAMENTO_DIAGNOSTICOLabel.Size = new System.Drawing.Size(329, 25);
            oRCAMENTO_DIAGNOSTICOLabel.TabIndex = 0;
            oRCAMENTO_DIAGNOSTICOLabel.Text = "Descreva qual foi o diagnóstico do item";
            // 
            // oRCAMENTO_DESCONTOLabel
            // 
            oRCAMENTO_DESCONTOLabel.AutoSize = true;
            oRCAMENTO_DESCONTOLabel.Location = new System.Drawing.Point(15, 8);
            oRCAMENTO_DESCONTOLabel.Name = "oRCAMENTO_DESCONTOLabel";
            oRCAMENTO_DESCONTOLabel.Size = new System.Drawing.Size(88, 25);
            oRCAMENTO_DESCONTOLabel.TabIndex = 1;
            oRCAMENTO_DESCONTOLabel.Text = "Desconto";
            // 
            // oRCAMENTO_ACRESCIMOLabel
            // 
            oRCAMENTO_ACRESCIMOLabel.AutoSize = true;
            oRCAMENTO_ACRESCIMOLabel.Location = new System.Drawing.Point(10, 61);
            oRCAMENTO_ACRESCIMOLabel.Name = "oRCAMENTO_ACRESCIMOLabel";
            oRCAMENTO_ACRESCIMOLabel.Size = new System.Drawing.Size(94, 25);
            oRCAMENTO_ACRESCIMOLabel.TabIndex = 3;
            oRCAMENTO_ACRESCIMOLabel.Text = "Acréscimo";
            // 
            // bsOrcamento
            // 
            this.bsOrcamento.DataMember = "ORCAMENTO";
            this.bsOrcamento.DataSource = this.dsFROGIOS;
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelFuncionario
            // 
            this.labelFuncionario.AutoSize = true;
            this.labelFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFuncionario.ForeColor = System.Drawing.Color.Black;
            this.labelFuncionario.Location = new System.Drawing.Point(37, 141);
            this.labelFuncionario.Name = "labelFuncionario";
            this.labelFuncionario.Size = new System.Drawing.Size(233, 25);
            this.labelFuncionario.TabIndex = 6;
            this.labelFuncionario.Text = "Duplo clique para pesquisar";
            this.labelFuncionario.DoubleClick += new System.EventHandler(this.fUNCIONARIO_NOMELabel1_Click);
            // 
            // bsFuncionario
            // 
            this.bsFuncionario.DataMember = "FUNCIONARIO";
            this.bsFuncionario.DataSource = this.dsFROGIOS;
            // 
            // oRCAMENTO_DATALabel1
            // 
            this.oRCAMENTO_DATALabel1.AutoSize = true;
            this.oRCAMENTO_DATALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrcamento, "ORCAMENTO_DATA", true));
            this.oRCAMENTO_DATALabel1.ForeColor = System.Drawing.Color.Black;
            this.oRCAMENTO_DATALabel1.Location = new System.Drawing.Point(17, 69);
            this.oRCAMENTO_DATALabel1.Name = "oRCAMENTO_DATALabel1";
            this.oRCAMENTO_DATALabel1.Size = new System.Drawing.Size(47, 25);
            this.oRCAMENTO_DATALabel1.TabIndex = 17;
            this.oRCAMENTO_DATALabel1.Text = "data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textTotalBruto);
            this.groupBox3.Controls.Add(this.textTotalServicos);
            this.groupBox3.Controls.Add(this.textTotalPecas);
            this.groupBox3.Controls.Add(label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(label4);
            this.groupBox3.Location = new System.Drawing.Point(11, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 162);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totais";
            // 
            // textTotalBruto
            // 
            this.textTotalBruto.Location = new System.Drawing.Point(126, 118);
            this.textTotalBruto.Name = "textTotalBruto";
            this.textTotalBruto.ReadOnly = true;
            this.textTotalBruto.Size = new System.Drawing.Size(118, 33);
            this.textTotalBruto.TabIndex = 15;
            this.textTotalBruto.Text = "R$ 0,00";
            this.textTotalBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTotalBruto.Valor = 0D;
            // 
            // textTotalServicos
            // 
            this.textTotalServicos.Location = new System.Drawing.Point(127, 71);
            this.textTotalServicos.Name = "textTotalServicos";
            this.textTotalServicos.ReadOnly = true;
            this.textTotalServicos.Size = new System.Drawing.Size(118, 33);
            this.textTotalServicos.TabIndex = 14;
            this.textTotalServicos.Text = "R$ 0,00";
            this.textTotalServicos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTotalServicos.Valor = 0D;
            // 
            // textTotalPecas
            // 
            this.textTotalPecas.Location = new System.Drawing.Point(127, 26);
            this.textTotalPecas.Name = "textTotalPecas";
            this.textTotalPecas.ReadOnly = true;
            this.textTotalPecas.Size = new System.Drawing.Size(118, 33);
            this.textTotalPecas.TabIndex = 13;
            this.textTotalPecas.Text = "R$ 0,00";
            this.textTotalPecas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTotalPecas.Valor = 0D;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Bruto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelFuncionario);
            this.groupBox4.Controls.Add(label5);
            this.groupBox4.Controls.Add(this.labelCliente);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(label9);
            this.groupBox4.Location = new System.Drawing.Point(10, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(741, 190);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pessoal";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCliente.ForeColor = System.Drawing.Color.Black;
            this.labelCliente.Location = new System.Drawing.Point(31, 64);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(233, 25);
            this.labelCliente.TabIndex = 4;
            this.labelCliente.Text = "Duplo clique para pesquisar";
            this.labelCliente.DoubleClick += new System.EventHandler(this.labelCliente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFisico, "CLIENTE_FISICO_NOME", true));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(31, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Clique para pesquisar";
            // 
            // bsFisico
            // 
            this.bsFisico.DataMember = "CLIENTE_FISICO";
            this.bsFisico.DataSource = this.dsFROGIOS;
            // 
            // bsJuridico
            // 
            this.bsJuridico.DataMember = "CLIENTE_JURIDICO";
            this.bsJuridico.DataSource = this.dsFROGIOS;
            // 
            // groupData
            // 
            this.groupData.Controls.Add(this.oRCAMENTO_DATALabel1);
            this.groupData.Location = new System.Drawing.Point(323, 201);
            this.groupData.Name = "groupData";
            this.groupData.Size = new System.Drawing.Size(435, 160);
            this.groupData.TabIndex = 20;
            this.groupData.TabStop = false;
            this.groupData.Text = "Data de lançamento";
            // 
            // oRCAMENTO_PRODUTOTextBox
            // 
            this.oRCAMENTO_PRODUTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrcamento, "ORCAMENTO_PRODUTO", true));
            this.oRCAMENTO_PRODUTOTextBox.Location = new System.Drawing.Point(16, 38);
            this.oRCAMENTO_PRODUTOTextBox.MaxLength = 120;
            this.oRCAMENTO_PRODUTOTextBox.Name = "oRCAMENTO_PRODUTOTextBox";
            this.oRCAMENTO_PRODUTOTextBox.Size = new System.Drawing.Size(743, 33);
            this.oRCAMENTO_PRODUTOTextBox.TabIndex = 1;
            // 
            // oRCAMENTO_DEFEITORichTextBox
            // 
            this.oRCAMENTO_DEFEITORichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrcamento, "ORCAMENTO_DEFEITO", true));
            this.oRCAMENTO_DEFEITORichTextBox.Location = new System.Drawing.Point(16, 107);
            this.oRCAMENTO_DEFEITORichTextBox.MaxLength = 200;
            this.oRCAMENTO_DEFEITORichTextBox.Name = "oRCAMENTO_DEFEITORichTextBox";
            this.oRCAMENTO_DEFEITORichTextBox.Size = new System.Drawing.Size(452, 248);
            this.oRCAMENTO_DEFEITORichTextBox.TabIndex = 3;
            this.oRCAMENTO_DEFEITORichTextBox.Text = "";
            // 
            // oRCAMENTO_AVULSOSRichTextBox
            // 
            this.oRCAMENTO_AVULSOSRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrcamento, "ORCAMENTO_AVULSOS", true));
            this.oRCAMENTO_AVULSOSRichTextBox.Location = new System.Drawing.Point(474, 107);
            this.oRCAMENTO_AVULSOSRichTextBox.MaxLength = 200;
            this.oRCAMENTO_AVULSOSRichTextBox.Name = "oRCAMENTO_AVULSOSRichTextBox";
            this.oRCAMENTO_AVULSOSRichTextBox.Size = new System.Drawing.Size(285, 99);
            this.oRCAMENTO_AVULSOSRichTextBox.TabIndex = 5;
            this.oRCAMENTO_AVULSOSRichTextBox.Text = "";
            // 
            // oRCAMENTO_OBSERVACAORichTextBox
            // 
            this.oRCAMENTO_OBSERVACAORichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrcamento, "ORCAMENTO_OBSERVACAO", true));
            this.oRCAMENTO_OBSERVACAORichTextBox.Location = new System.Drawing.Point(474, 237);
            this.oRCAMENTO_OBSERVACAORichTextBox.MaxLength = 120;
            this.oRCAMENTO_OBSERVACAORichTextBox.Name = "oRCAMENTO_OBSERVACAORichTextBox";
            this.oRCAMENTO_OBSERVACAORichTextBox.Size = new System.Drawing.Size(285, 118);
            this.oRCAMENTO_OBSERVACAORichTextBox.TabIndex = 7;
            this.oRCAMENTO_OBSERVACAORichTextBox.Text = "";
            // 
            // oRCAMENTO_ITEMBindingSource
            // 
            this.oRCAMENTO_ITEMBindingSource.AllowNew = true;
            this.oRCAMENTO_ITEMBindingSource.DataMember = "ORCAMENTO_ITEM";
            this.oRCAMENTO_ITEMBindingSource.DataSource = this.dsFROGIOS;
            // 
            // oRCAMENTO_ITEMDataGridView
            // 
            this.oRCAMENTO_ITEMDataGridView.AllowUserToAddRows = false;
            this.oRCAMENTO_ITEMDataGridView.AutoGenerateColumns = false;
            this.oRCAMENTO_ITEMDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.oRCAMENTO_ITEMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oRCAMENTO_ITEMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oRCAMENTOITEMDESCRICAODataGridViewTextBoxColumn,
            this.colunaProdutoPreco,
            this.colunaProdutoDesconto,
            this.oRCAMENTOITEMQUANTIDADEDataGridViewTextBoxColumn,
            this.colunaProdutoTotal});
            this.oRCAMENTO_ITEMDataGridView.DataSource = this.oRCAMENTO_ITEMBindingSource;
            this.oRCAMENTO_ITEMDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oRCAMENTO_ITEMDataGridView.Location = new System.Drawing.Point(0, 220);
            this.oRCAMENTO_ITEMDataGridView.Name = "oRCAMENTO_ITEMDataGridView";
            this.oRCAMENTO_ITEMDataGridView.ReadOnly = true;
            this.oRCAMENTO_ITEMDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.oRCAMENTO_ITEMDataGridView.Size = new System.Drawing.Size(786, 162);
            this.oRCAMENTO_ITEMDataGridView.TabIndex = 6;
            this.oRCAMENTO_ITEMDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.oRCAMENTO_ITEMDataGridView_CellDoubleClick);
            this.oRCAMENTO_ITEMDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.oRCAMENTO_ITEMDataGridView_CellFormatting);
            // 
            // oRCAMENTOITEMDESCRICAODataGridViewTextBoxColumn
            // 
            this.oRCAMENTOITEMDESCRICAODataGridViewTextBoxColumn.DataPropertyName = "ORCAMENTO_ITEM_DESCRICAO";
            this.oRCAMENTOITEMDESCRICAODataGridViewTextBoxColumn.HeaderText = "Produto";
            this.oRCAMENTOITEMDESCRICAODataGridViewTextBoxColumn.Name = "oRCAMENTOITEMDESCRICAODataGridViewTextBoxColumn";
            this.oRCAMENTOITEMDESCRICAODataGridViewTextBoxColumn.ReadOnly = true;
            this.oRCAMENTOITEMDESCRICAODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colunaProdutoPreco
            // 
            this.colunaProdutoPreco.DataPropertyName = "ORCAMENTO_ITEM_VALOR";
            this.colunaProdutoPreco.HeaderText = "Preço";
            this.colunaProdutoPreco.Name = "colunaProdutoPreco";
            this.colunaProdutoPreco.ReadOnly = true;
            this.colunaProdutoPreco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colunaProdutoDesconto
            // 
            this.colunaProdutoDesconto.DataPropertyName = "ORCAMENTO_ITEM_DESCONTO";
            this.colunaProdutoDesconto.HeaderText = "Desconto";
            this.colunaProdutoDesconto.Name = "colunaProdutoDesconto";
            this.colunaProdutoDesconto.ReadOnly = true;
            this.colunaProdutoDesconto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // oRCAMENTOITEMQUANTIDADEDataGridViewTextBoxColumn
            // 
            this.oRCAMENTOITEMQUANTIDADEDataGridViewTextBoxColumn.DataPropertyName = "ORCAMENTO_ITEM_QUANTIDADE";
            this.oRCAMENTOITEMQUANTIDADEDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.oRCAMENTOITEMQUANTIDADEDataGridViewTextBoxColumn.Name = "oRCAMENTOITEMQUANTIDADEDataGridViewTextBoxColumn";
            this.oRCAMENTOITEMQUANTIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRCAMENTOITEMQUANTIDADEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colunaProdutoTotal
            // 
            this.colunaProdutoTotal.DataPropertyName = "ORCAMENTO_ITEM_TOTAL";
            this.colunaProdutoTotal.HeaderText = "Total";
            this.colunaProdutoTotal.Name = "colunaProdutoTotal";
            this.colunaProdutoTotal.ReadOnly = true;
            this.colunaProdutoTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pRODUTO_DESCRICAOTextBox
            // 
            this.pRODUTO_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOBindingSource, "PRODUTO_DESCRICAO", true));
            this.pRODUTO_DESCRICAOTextBox.Location = new System.Drawing.Point(111, 26);
            this.pRODUTO_DESCRICAOTextBox.MaxLength = 120;
            this.pRODUTO_DESCRICAOTextBox.Name = "pRODUTO_DESCRICAOTextBox";
            this.pRODUTO_DESCRICAOTextBox.ReadOnly = true;
            this.pRODUTO_DESCRICAOTextBox.Size = new System.Drawing.Size(635, 33);
            this.pRODUTO_DESCRICAOTextBox.TabIndex = 1;
            // 
            // pRODUTOBindingSource
            // 
            this.pRODUTOBindingSource.DataMember = "PRODUTO";
            this.pRODUTOBindingSource.DataSource = this.dsFROGIOS;
            // 
            // textPecaQuantidade
            // 
            this.textPecaQuantidade.Location = new System.Drawing.Point(628, 72);
            this.textPecaQuantidade.Name = "textPecaQuantidade";
            this.textPecaQuantidade.Size = new System.Drawing.Size(100, 33);
            this.textPecaQuantidade.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(516, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Quantidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "Desconto";
            // 
            // groupProduto
            // 
            this.groupProduto.Controls.Add(this.textProdutoPreco);
            this.groupProduto.Controls.Add(this.textPecaDesconto);
            this.groupProduto.Controls.Add(pRODUTO_DESCRICAOLabel);
            this.groupProduto.Controls.Add(this.label12);
            this.groupProduto.Controls.Add(this.pRODUTO_DESCRICAOTextBox);
            this.groupProduto.Controls.Add(this.label10);
            this.groupProduto.Controls.Add(pRODUTO_PRECO_VENDALabel);
            this.groupProduto.Controls.Add(this.textPecaQuantidade);
            this.groupProduto.Location = new System.Drawing.Point(7, 43);
            this.groupProduto.Name = "groupProduto";
            this.groupProduto.Size = new System.Drawing.Size(774, 125);
            this.groupProduto.TabIndex = 9;
            this.groupProduto.TabStop = false;
            // 
            // textProdutoPreco
            // 
            this.textProdutoPreco.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.pRODUTOBindingSource, "PRODUTO_PRECO_VENDA", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textProdutoPreco.Location = new System.Drawing.Point(111, 75);
            this.textProdutoPreco.Name = "textProdutoPreco";
            this.textProdutoPreco.ReadOnly = true;
            this.textProdutoPreco.Size = new System.Drawing.Size(138, 33);
            this.textProdutoPreco.TabIndex = 10;
            this.textProdutoPreco.Text = "R$ 0,00";
            this.textProdutoPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textProdutoPreco.Valor = 0D;
            // 
            // textPecaDesconto
            // 
            this.textPecaDesconto.Location = new System.Drawing.Point(356, 72);
            this.textPecaDesconto.Name = "textPecaDesconto";
            this.textPecaDesconto.Size = new System.Drawing.Size(140, 33);
            this.textPecaDesconto.TabIndex = 9;
            this.textPecaDesconto.Text = "R$ 0,00";
            this.textPecaDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textPecaDesconto.Valor = 0D;
            // 
            // buttonPesquisarProduto
            // 
            this.buttonPesquisarProduto.AutoSize = true;
            this.buttonPesquisarProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPesquisarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarProduto.Location = new System.Drawing.Point(0, 0);
            this.buttonPesquisarProduto.Name = "buttonPesquisarProduto";
            this.buttonPesquisarProduto.Size = new System.Drawing.Size(786, 37);
            this.buttonPesquisarProduto.TabIndex = 0;
            this.buttonPesquisarProduto.Text = "Pesquisar Produto";
            this.buttonPesquisarProduto.UseVisualStyleBackColor = true;
            this.buttonPesquisarProduto.Click += new System.EventHandler(this.buttonPesquisarProduto_Click);
            // 
            // buttonLancarProduto
            // 
            this.buttonLancarProduto.AutoSize = true;
            this.buttonLancarProduto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLancarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLancarProduto.Location = new System.Drawing.Point(0, 183);
            this.buttonLancarProduto.Name = "buttonLancarProduto";
            this.buttonLancarProduto.Size = new System.Drawing.Size(786, 37);
            this.buttonLancarProduto.TabIndex = 5;
            this.buttonLancarProduto.Text = "Lançar Produto";
            this.buttonLancarProduto.UseVisualStyleBackColor = true;
            this.buttonLancarProduto.Click += new System.EventHandler(this.buttonLancarProduto_Click);
            // 
            // groupServico
            // 
            this.groupServico.Controls.Add(this.textServicoValor);
            this.groupServico.Controls.Add(this.textServicoAcrescimo);
            this.groupServico.Controls.Add(this.textServicoDesconto);
            this.groupServico.Controls.Add(label14);
            this.groupServico.Controls.Add(label13);
            this.groupServico.Controls.Add(sERVICO_VALORLabel);
            this.groupServico.Controls.Add(sERVICO_DESCRICAOLabel);
            this.groupServico.Controls.Add(this.sERVICO_DESCRICAOTextBox);
            this.groupServico.Location = new System.Drawing.Point(5, 43);
            this.groupServico.Name = "groupServico";
            this.groupServico.Size = new System.Drawing.Size(776, 135);
            this.groupServico.TabIndex = 0;
            this.groupServico.TabStop = false;
            // 
            // textServicoValor
            // 
            this.textServicoValor.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.sERVICOBindingSource, "SERVICO_VALOR", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textServicoValor.Location = new System.Drawing.Point(86, 81);
            this.textServicoValor.Name = "textServicoValor";
            this.textServicoValor.ReadOnly = true;
            this.textServicoValor.Size = new System.Drawing.Size(131, 33);
            this.textServicoValor.TabIndex = 10;
            this.textServicoValor.Text = "R$ 0,00";
            this.textServicoValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textServicoValor.Valor = 0D;
            // 
            // sERVICOBindingSource
            // 
            this.sERVICOBindingSource.DataMember = "SERVICO";
            this.sERVICOBindingSource.DataSource = this.dsFROGIOS;
            // 
            // textServicoAcrescimo
            // 
            this.textServicoAcrescimo.Location = new System.Drawing.Point(562, 81);
            this.textServicoAcrescimo.Name = "textServicoAcrescimo";
            this.textServicoAcrescimo.Size = new System.Drawing.Size(148, 33);
            this.textServicoAcrescimo.TabIndex = 9;
            this.textServicoAcrescimo.Text = "R$ 0,00";
            this.textServicoAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textServicoAcrescimo.Valor = 0D;
            this.textServicoAcrescimo.TextChanged += new System.EventHandler(this.textServicoAcrescimo_TextChanged);
            // 
            // textServicoDesconto
            // 
            this.textServicoDesconto.Location = new System.Drawing.Point(331, 81);
            this.textServicoDesconto.Name = "textServicoDesconto";
            this.textServicoDesconto.Size = new System.Drawing.Size(131, 33);
            this.textServicoDesconto.TabIndex = 8;
            this.textServicoDesconto.Text = "R$ 0,00";
            this.textServicoDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textServicoDesconto.Valor = 0D;
            this.textServicoDesconto.TextChanged += new System.EventHandler(this.textServicoDesconto_TextChanged);
            // 
            // sERVICO_DESCRICAOTextBox
            // 
            this.sERVICO_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sERVICOBindingSource, "SERVICO_DESCRICAO", true));
            this.sERVICO_DESCRICAOTextBox.Enabled = false;
            this.sERVICO_DESCRICAOTextBox.Location = new System.Drawing.Point(112, 29);
            this.sERVICO_DESCRICAOTextBox.Name = "sERVICO_DESCRICAOTextBox";
            this.sERVICO_DESCRICAOTextBox.Size = new System.Drawing.Size(598, 33);
            this.sERVICO_DESCRICAOTextBox.TabIndex = 1;
            // 
            // buttonPesquisarServico
            // 
            this.buttonPesquisarServico.AutoSize = true;
            this.buttonPesquisarServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPesquisarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarServico.Location = new System.Drawing.Point(0, 0);
            this.buttonPesquisarServico.Name = "buttonPesquisarServico";
            this.buttonPesquisarServico.Size = new System.Drawing.Size(786, 37);
            this.buttonPesquisarServico.TabIndex = 0;
            this.buttonPesquisarServico.Text = "Pesquisar serviço";
            this.buttonPesquisarServico.UseVisualStyleBackColor = true;
            this.buttonPesquisarServico.Click += new System.EventHandler(this.buttonPesquisarServico_Click);
            // 
            // buttonLancarServico
            // 
            this.buttonLancarServico.AutoSize = true;
            this.buttonLancarServico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLancarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLancarServico.Location = new System.Drawing.Point(0, 193);
            this.buttonLancarServico.Name = "buttonLancarServico";
            this.buttonLancarServico.Size = new System.Drawing.Size(786, 37);
            this.buttonLancarServico.TabIndex = 5;
            this.buttonLancarServico.Text = "Lançar Serviço";
            this.buttonLancarServico.UseVisualStyleBackColor = true;
            this.buttonLancarServico.Click += new System.EventHandler(this.buttonLancarServico_Click);
            // 
            // oRCAMENTO_SERVICODataGridView
            // 
            this.oRCAMENTO_SERVICODataGridView.AllowUserToAddRows = false;
            this.oRCAMENTO_SERVICODataGridView.AutoGenerateColumns = false;
            this.oRCAMENTO_SERVICODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.oRCAMENTO_SERVICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oRCAMENTO_SERVICODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaServicoDescricao,
            this.colunaServicoValor,
            this.colunaServicoDesconto,
            this.colunaServicoAcrescimo,
            this.colunaServicoTotal});
            this.oRCAMENTO_SERVICODataGridView.DataSource = this.oRCAMENTO_SERVICOBindingSource;
            this.oRCAMENTO_SERVICODataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oRCAMENTO_SERVICODataGridView.Location = new System.Drawing.Point(0, 230);
            this.oRCAMENTO_SERVICODataGridView.Name = "oRCAMENTO_SERVICODataGridView";
            this.oRCAMENTO_SERVICODataGridView.ReadOnly = true;
            this.oRCAMENTO_SERVICODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.oRCAMENTO_SERVICODataGridView.Size = new System.Drawing.Size(786, 152);
            this.oRCAMENTO_SERVICODataGridView.TabIndex = 6;
            this.oRCAMENTO_SERVICODataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.oRCAMENTO_SERVICODataGridView_CellDoubleClick);
            this.oRCAMENTO_SERVICODataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.oRCAMENTO_SERVICODataGridView_CellFormatting);
            // 
            // colunaServicoDescricao
            // 
            this.colunaServicoDescricao.DataPropertyName = "ORCAMENTO_SERVICO_DESCRICAO";
            this.colunaServicoDescricao.HeaderText = "Descrição";
            this.colunaServicoDescricao.Name = "colunaServicoDescricao";
            this.colunaServicoDescricao.ReadOnly = true;
            this.colunaServicoDescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colunaServicoValor
            // 
            this.colunaServicoValor.DataPropertyName = "ORCAMENTO_SERVICO_VALOR";
            this.colunaServicoValor.HeaderText = "Valor";
            this.colunaServicoValor.Name = "colunaServicoValor";
            this.colunaServicoValor.ReadOnly = true;
            this.colunaServicoValor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colunaServicoDesconto
            // 
            this.colunaServicoDesconto.DataPropertyName = "ORCAMENTO_SERVICO_DESCONTO";
            this.colunaServicoDesconto.HeaderText = "Desconto";
            this.colunaServicoDesconto.Name = "colunaServicoDesconto";
            this.colunaServicoDesconto.ReadOnly = true;
            this.colunaServicoDesconto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colunaServicoAcrescimo
            // 
            this.colunaServicoAcrescimo.DataPropertyName = "ORCAMENTO_SERVICO_ACRESCIMO";
            this.colunaServicoAcrescimo.HeaderText = "Acréscimo";
            this.colunaServicoAcrescimo.Name = "colunaServicoAcrescimo";
            this.colunaServicoAcrescimo.ReadOnly = true;
            this.colunaServicoAcrescimo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colunaServicoTotal
            // 
            this.colunaServicoTotal.DataPropertyName = "ORCAMENTO_SERVICO_TOTAL";
            this.colunaServicoTotal.HeaderText = "Total";
            this.colunaServicoTotal.Name = "colunaServicoTotal";
            this.colunaServicoTotal.ReadOnly = true;
            this.colunaServicoTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // oRCAMENTO_SERVICOBindingSource
            // 
            this.oRCAMENTO_SERVICOBindingSource.DataMember = "ORCAMENTO_SERVICO";
            this.oRCAMENTO_SERVICOBindingSource.DataSource = this.dsFROGIOS;
            // 
            // oRCAMENTO_DIAGNOSTICORichTextBox
            // 
            this.oRCAMENTO_DIAGNOSTICORichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrcamento, "ORCAMENTO_DIAGNOSTICO", true));
            this.oRCAMENTO_DIAGNOSTICORichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oRCAMENTO_DIAGNOSTICORichTextBox.Location = new System.Drawing.Point(0, 27);
            this.oRCAMENTO_DIAGNOSTICORichTextBox.MaxLength = 200;
            this.oRCAMENTO_DIAGNOSTICORichTextBox.Name = "oRCAMENTO_DIAGNOSTICORichTextBox";
            this.oRCAMENTO_DIAGNOSTICORichTextBox.Size = new System.Drawing.Size(786, 355);
            this.oRCAMENTO_DIAGNOSTICORichTextBox.TabIndex = 1;
            this.oRCAMENTO_DIAGNOSTICORichTextBox.Text = "";
            // 
            // buttonLancarOS
            // 
            this.buttonLancarOS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLancarOS.AutoSize = true;
            this.buttonLancarOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLancarOS.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.buttonLancarOS.ForeColor = System.Drawing.Color.White;
            this.buttonLancarOS.Location = new System.Drawing.Point(531, 14);
            this.buttonLancarOS.Name = "buttonLancarOS";
            this.buttonLancarOS.Size = new System.Drawing.Size(143, 49);
            this.buttonLancarOS.TabIndex = 2;
            this.buttonLancarOS.Text = "Lançar OS";
            this.buttonLancarOS.UseVisualStyleBackColor = true;
            this.buttonLancarOS.Click += new System.EventHandler(this.buttonLancarOS_Click);
            // 
            // taFisico
            // 
            this.taFisico.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AGENDAMENTOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = null;
            this.tableAdapterManager.CLIENTE_FISICOTableAdapter = this.taFisico;
            this.tableAdapterManager.CLIENTE_JURIDICOTableAdapter = this.taJuridico;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.COMPRATableAdapter = null;
            this.tableAdapterManager.EMPRESATableAdapter = null;
            this.tableAdapterManager.FORNECEDOR_FISICOTableAdapter = null;
            this.tableAdapterManager.FORNECEDOR_JURIDICOTableAdapter = null;
            this.tableAdapterManager.FORNECEDORTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOTableAdapter = this.taFuncionario;
            this.tableAdapterManager.GRUPOTableAdapter = null;
            this.tableAdapterManager.ITEM_COMPRATableAdapter = null;
            this.tableAdapterManager.MARCATableAdapter = null;
            this.tableAdapterManager.ORCAMENTO_ITEMTableAdapter = null;
            this.tableAdapterManager.ORCAMENTO_SERVICOTableAdapter = null;
            this.tableAdapterManager.ORCAMENTOTableAdapter = this.taOrcamento;
            this.tableAdapterManager.OS_ITEMTableAdapter = null;
            this.tableAdapterManager.OS_SERVICOTableAdapter = null;
            this.tableAdapterManager.OSTableAdapter = null;
            this.tableAdapterManager.PERMISSAOTableAdapter = null;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.SECAOTableAdapter = null;
            this.tableAdapterManager.SERVICO_TIPOTableAdapter = null;
            this.tableAdapterManager.SERVICOTableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // taJuridico
            // 
            this.taJuridico.ClearBeforeFill = true;
            // 
            // taFuncionario
            // 
            this.taFuncionario.ClearBeforeFill = true;
            // 
            // taOrcamento
            // 
            this.taOrcamento.ClearBeforeFill = true;
            // 
            // oRCAMENTO_ITEMTableAdapter
            // 
            this.oRCAMENTO_ITEMTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUTOTableAdapter
            // 
            this.pRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // sERVICOTableAdapter
            // 
            this.sERVICOTableAdapter.ClearBeforeFill = true;
            // 
            // oRCAMENTO_SERVICOTableAdapter
            // 
            this.oRCAMENTO_SERVICOTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panelDesconto_Acrescimo);
            this.groupBox5.Controls.Add(this.labelTotalLiquido);
            this.groupBox5.Location = new System.Drawing.Point(11, 375);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(747, 120);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total líquido";
            // 
            // panelDesconto_Acrescimo
            // 
            this.panelDesconto_Acrescimo.Controls.Add(this.textOrcamentoAcresicmo);
            this.panelDesconto_Acrescimo.Controls.Add(this.textOrcamentoDesconto);
            this.panelDesconto_Acrescimo.Controls.Add(oRCAMENTO_DESCONTOLabel);
            this.panelDesconto_Acrescimo.Controls.Add(this.buttonAplicar);
            this.panelDesconto_Acrescimo.Controls.Add(oRCAMENTO_ACRESCIMOLabel);
            this.panelDesconto_Acrescimo.Location = new System.Drawing.Point(319, 21);
            this.panelDesconto_Acrescimo.Name = "panelDesconto_Acrescimo";
            this.panelDesconto_Acrescimo.Size = new System.Drawing.Size(422, 100);
            this.panelDesconto_Acrescimo.TabIndex = 24;
            // 
            // textOrcamentoAcresicmo
            // 
            this.textOrcamentoAcresicmo.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsOrcamento, "ORCAMENTO_ACRESCIMO", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textOrcamentoAcresicmo.Location = new System.Drawing.Point(109, 58);
            this.textOrcamentoAcresicmo.Name = "textOrcamentoAcresicmo";
            this.textOrcamentoAcresicmo.Size = new System.Drawing.Size(197, 33);
            this.textOrcamentoAcresicmo.TabIndex = 25;
            this.textOrcamentoAcresicmo.Text = "R$ 0,00";
            this.textOrcamentoAcresicmo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textOrcamentoAcresicmo.Valor = 0D;
            this.textOrcamentoAcresicmo.TextChanged += new System.EventHandler(this.oRCAMENTO_ACRESCIMOTextBox_TextChanged);
            // 
            // textOrcamentoDesconto
            // 
            this.textOrcamentoDesconto.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsOrcamento, "ORCAMENTO_DESCONTO", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textOrcamentoDesconto.Location = new System.Drawing.Point(109, 8);
            this.textOrcamentoDesconto.Name = "textOrcamentoDesconto";
            this.textOrcamentoDesconto.Size = new System.Drawing.Size(197, 33);
            this.textOrcamentoDesconto.TabIndex = 24;
            this.textOrcamentoDesconto.Text = "R$ 0,00";
            this.textOrcamentoDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textOrcamentoDesconto.Valor = 0D;
            this.textOrcamentoDesconto.TextChanged += new System.EventHandler(this.oRCAMENTO_DESCONTOTextBox_TextChanged);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.AutoSize = true;
            this.buttonAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAplicar.Location = new System.Drawing.Point(312, 8);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(91, 81);
            this.buttonAplicar.TabIndex = 23;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            this.buttonAplicar.Click += new System.EventHandler(this.buttonAplicar_Click);
            // 
            // labelTotalLiquido
            // 
            this.labelTotalLiquido.AutoSize = true;
            this.labelTotalLiquido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrcamento, "ORCAMENTO_TOTAL", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "N2"));
            this.labelTotalLiquido.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLiquido.Location = new System.Drawing.Point(15, 42);
            this.labelTotalLiquido.Name = "labelTotalLiquido";
            this.labelTotalLiquido.Size = new System.Drawing.Size(46, 37);
            this.labelTotalLiquido.TabIndex = 1;
            this.labelTotalLiquido.Text = "R$";
            // 
            // formCadastroOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "formCadastroOrcamento";
            this.Load += new System.EventHandler(this.formCadastroOrcamento_Load);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.tabPai.ResumeLayout(false);
            this.tabInfoItem.ResumeLayout(false);
            this.tabPecas.ResumeLayout(false);
            this.tabServicos.ResumeLayout(false);
            this.tabDiagnostico.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            this.panelGeral.ResumeLayout(false);
            this.panelInfoItem.ResumeLayout(false);
            this.panelInfoItem.PerformLayout();
            this.panelPecas.ResumeLayout(false);
            this.panelPecas.PerformLayout();
            this.panelServicos.ResumeLayout(false);
            this.panelServicos.PerformLayout();
            this.panelDiagnostico.ResumeLayout(false);
            this.panelDiagnostico.PerformLayout();
            this.panelRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditar)).EndInit();
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFisico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJuridico)).EndInit();
            this.groupData.ResumeLayout(false);
            this.groupData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRCAMENTO_ITEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRCAMENTO_ITEMDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).EndInit();
            this.groupProduto.ResumeLayout(false);
            this.groupProduto.PerformLayout();
            this.groupServico.ResumeLayout(false);
            this.groupServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRCAMENTO_SERVICODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRCAMENTO_SERVICOBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panelDesconto_Acrescimo.ResumeLayout(false);
            this.panelDesconto_Acrescimo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsFisico;
        private dsFROGIOSTableAdapters.CLIENTE_FISICOTableAdapter taFisico;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private dsFROGIOSTableAdapters.CLIENTE_JURIDICOTableAdapter taJuridico;
        private System.Windows.Forms.BindingSource bsJuridico;
        private dsFROGIOSTableAdapters.FUNCIONARIOTableAdapter taFuncionario;
        private System.Windows.Forms.BindingSource bsFuncionario;
        private dsFROGIOSTableAdapters.ORCAMENTOTableAdapter taOrcamento;
        private System.Windows.Forms.BindingSource bsOrcamento;
        private System.Windows.Forms.Label labelFuncionario;
        private System.Windows.Forms.Label oRCAMENTO_DATALabel1;
        private System.Windows.Forms.GroupBox groupData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox oRCAMENTO_PRODUTOTextBox;
        private System.Windows.Forms.RichTextBox oRCAMENTO_DEFEITORichTextBox;
        private System.Windows.Forms.RichTextBox oRCAMENTO_AVULSOSRichTextBox;
        private System.Windows.Forms.RichTextBox oRCAMENTO_OBSERVACAORichTextBox;
        private System.Windows.Forms.BindingSource oRCAMENTO_ITEMBindingSource;
        private dsFROGIOSTableAdapters.ORCAMENTO_ITEMTableAdapter oRCAMENTO_ITEMTableAdapter;
        private System.Windows.Forms.DataGridView oRCAMENTO_ITEMDataGridView;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource;
        private dsFROGIOSTableAdapters.PRODUTOTableAdapter pRODUTOTableAdapter;
        private System.Windows.Forms.TextBox pRODUTO_DESCRICAOTextBox;
        private System.Windows.Forms.Button buttonLancarProduto;
        private System.Windows.Forms.Button buttonPesquisarProduto;
        private System.Windows.Forms.GroupBox groupProduto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPecaQuantidade;
        private System.Windows.Forms.GroupBox groupServico;
        private System.Windows.Forms.BindingSource sERVICOBindingSource;
        private dsFROGIOSTableAdapters.SERVICOTableAdapter sERVICOTableAdapter;
        private System.Windows.Forms.Button buttonLancarServico;
        private System.Windows.Forms.Button buttonPesquisarServico;
        private System.Windows.Forms.TextBox sERVICO_DESCRICAOTextBox;
        private System.Windows.Forms.BindingSource oRCAMENTO_SERVICOBindingSource;
        private dsFROGIOSTableAdapters.ORCAMENTO_SERVICOTableAdapter oRCAMENTO_SERVICOTableAdapter;
        private System.Windows.Forms.DataGridView oRCAMENTO_SERVICODataGridView;
        private System.Windows.Forms.RichTextBox oRCAMENTO_DIAGNOSTICORichTextBox;
        private System.Windows.Forms.Button buttonLancarOS;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonAplicar;
        private System.Windows.Forms.Label labelTotalLiquido;
        private System.Windows.Forms.Panel panelDesconto_Acrescimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaServicoDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaServicoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaServicoDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaServicoAcrescimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaServicoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRCAMENTOITEMDESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaProdutoPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaProdutoDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRCAMENTOITEMQUANTIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaProdutoTotal;
        private WindowsFormsApplication2.Monetario textTotalBruto;
        private WindowsFormsApplication2.Monetario textTotalServicos;
        private WindowsFormsApplication2.Monetario textTotalPecas;
        private WindowsFormsApplication2.Monetario textOrcamentoAcresicmo;
        private WindowsFormsApplication2.Monetario textOrcamentoDesconto;
        private WindowsFormsApplication2.Monetario textPecaDesconto;
        private WindowsFormsApplication2.Monetario textServicoAcrescimo;
        private WindowsFormsApplication2.Monetario textServicoDesconto;
        private WindowsFormsApplication2.Monetario textServicoValor;
        private WindowsFormsApplication2.Monetario textProdutoPreco;





    }
}