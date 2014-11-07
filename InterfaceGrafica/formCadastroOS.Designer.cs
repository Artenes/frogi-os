namespace FROGI_OS.InterfaceGrafica
{
    partial class formCadastroOS
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
            System.Windows.Forms.Label cLIENTE_FISICO_NOMELabel;
            System.Windows.Forms.Label fUNCIONARIO_NOMELabel;
            System.Windows.Forms.Label oS_TOTAL_ITEMLabel;
            System.Windows.Forms.Label oS_TOTAL_SERVICOLabel;
            System.Windows.Forms.Label oS_PRODUTOLabel;
            System.Windows.Forms.Label oS_DEFEITOLabel;
            System.Windows.Forms.Label oS_AVULSOSLabel;
            System.Windows.Forms.Label oS_OBSERVACAOLabel;
            System.Windows.Forms.Label oS_ITEM_DESCRICAOLabel;
            System.Windows.Forms.Label oS_ITEM_DESCONTOLabel;
            System.Windows.Forms.Label oS_ITEM_QUANTIDADELabel;
            System.Windows.Forms.Label pRODUTO_PRECO_VENDALabel;
            System.Windows.Forms.Label sERVICO_DESCRICAOLabel;
            System.Windows.Forms.Label sERVICO_VALORLabel;
            System.Windows.Forms.Label oS_SERVICO_DESCONTOLabel;
            System.Windows.Forms.Label oS_SERVICO_ACRESCIMOLabel;
            System.Windows.Forms.Label oS_DIAGNOSTICOLabel;
            System.Windows.Forms.Label oS_ACRESCIMOLabel;
            System.Windows.Forms.Label oS_DESCONTOLabel;
            System.Windows.Forms.Label oS_TOTALLabel;
            System.Windows.Forms.Label oS_DATA_ENTREGALabel;
            System.Windows.Forms.Label label3;
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.oS_STATUSComboBox = new System.Windows.Forms.ComboBox();
            this.bsOS = new System.Windows.Forms.BindingSource(this.components);
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.taOS = new FROGI_OS.dsFROGIOSTableAdapters.OSTableAdapter();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.taFisico = new FROGI_OS.dsFROGIOSTableAdapters.CLIENTE_FISICOTableAdapter();
            this.taJuridico = new FROGI_OS.dsFROGIOSTableAdapters.CLIENTE_JURIDICOTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFuncionario = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.bsFuncionario = new System.Windows.Forms.BindingSource(this.components);
            this.bsJuridico = new System.Windows.Forms.BindingSource(this.components);
            this.bsFisico = new System.Windows.Forms.BindingSource(this.components);
            this.taFuncionario = new FROGI_OS.dsFROGIOSTableAdapters.FUNCIONARIOTableAdapter();
            this.groupTotais = new System.Windows.Forms.GroupBox();
            this.textTotalBruto = new WindowsFormsApplication2.Monetario();
            this.textTotalServicos = new WindowsFormsApplication2.Monetario();
            this.textTotalPecas = new WindowsFormsApplication2.Monetario();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.oS_DATALabel1 = new System.Windows.Forms.Label();
            this.oS_PRODUTOTextBox = new System.Windows.Forms.TextBox();
            this.oS_DEFEITORichTextBox = new System.Windows.Forms.RichTextBox();
            this.oS_AVULSOSRichTextBox = new System.Windows.Forms.RichTextBox();
            this.oS_OBSERVACAORichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupProduto = new System.Windows.Forms.GroupBox();
            this.textProdutoPreco = new WindowsFormsApplication2.Monetario();
            this.bsProduto = new System.Windows.Forms.BindingSource(this.components);
            this.textProdutoDesconto = new WindowsFormsApplication2.Monetario();
            this.pRODUTO_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.textPecaQuantidade = new System.Windows.Forms.TextBox();
            this.bsOsItem = new System.Windows.Forms.BindingSource(this.components);
            this.taOsItem = new FROGI_OS.dsFROGIOSTableAdapters.OS_ITEMTableAdapter();
            this.taProduto = new FROGI_OS.dsFROGIOSTableAdapters.PRODUTOTableAdapter();
            this.buttonPesquisarProduto = new System.Windows.Forms.Button();
            this.oS_ITEMDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaProdutoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaProdutoDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaProdutoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLancarProduto = new System.Windows.Forms.Button();
            this.groupServico = new System.Windows.Forms.GroupBox();
            this.textServicoAcrescimo = new WindowsFormsApplication2.Monetario();
            this.textServicoDesconto = new WindowsFormsApplication2.Monetario();
            this.textServicoPreco = new WindowsFormsApplication2.Monetario();
            this.bsServico = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICO_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.bsOsServico = new System.Windows.Forms.BindingSource(this.components);
            this.taServico = new FROGI_OS.dsFROGIOSTableAdapters.SERVICOTableAdapter();
            this.taOsServico = new FROGI_OS.dsFROGIOSTableAdapters.OS_SERVICOTableAdapter();
            this.oS_SERVICODataGridView = new System.Windows.Forms.DataGridView();
            this.colunaServicoDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPesquisarServico = new System.Windows.Forms.Button();
            this.buttonLancarServico = new System.Windows.Forms.Button();
            this.oS_DIAGNOSTICORichTextBox = new System.Windows.Forms.RichTextBox();
            this.tabConclusao = new System.Windows.Forms.TabPage();
            this.panelConclusao = new System.Windows.Forms.Panel();
            this.textTotalLiquido = new WindowsFormsApplication2.Monetario();
            this.oS_DATA_ENTREGADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textTroco = new WindowsFormsApplication2.Monetario();
            this.textValorPago = new WindowsFormsApplication2.Monetario();
            this.label4 = new System.Windows.Forms.Label();
            this.Troco = new System.Windows.Forms.Label();
            this.groupBoxAcrescimoouDesconto = new System.Windows.Forms.GroupBox();
            this.textOSDesconto = new WindowsFormsApplication2.Monetario();
            this.textOSAcrescimo = new WindowsFormsApplication2.Monetario();
            this.buttonAplicar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.oS_FORMA_PAGAMENTOComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            cLIENTE_FISICO_NOMELabel = new System.Windows.Forms.Label();
            fUNCIONARIO_NOMELabel = new System.Windows.Forms.Label();
            oS_TOTAL_ITEMLabel = new System.Windows.Forms.Label();
            oS_TOTAL_SERVICOLabel = new System.Windows.Forms.Label();
            oS_PRODUTOLabel = new System.Windows.Forms.Label();
            oS_DEFEITOLabel = new System.Windows.Forms.Label();
            oS_AVULSOSLabel = new System.Windows.Forms.Label();
            oS_OBSERVACAOLabel = new System.Windows.Forms.Label();
            oS_ITEM_DESCRICAOLabel = new System.Windows.Forms.Label();
            oS_ITEM_DESCONTOLabel = new System.Windows.Forms.Label();
            oS_ITEM_QUANTIDADELabel = new System.Windows.Forms.Label();
            pRODUTO_PRECO_VENDALabel = new System.Windows.Forms.Label();
            sERVICO_DESCRICAOLabel = new System.Windows.Forms.Label();
            sERVICO_VALORLabel = new System.Windows.Forms.Label();
            oS_SERVICO_DESCONTOLabel = new System.Windows.Forms.Label();
            oS_SERVICO_ACRESCIMOLabel = new System.Windows.Forms.Label();
            oS_DIAGNOSTICOLabel = new System.Windows.Forms.Label();
            oS_ACRESCIMOLabel = new System.Windows.Forms.Label();
            oS_DESCONTOLabel = new System.Windows.Forms.Label();
            oS_TOTALLabel = new System.Windows.Forms.Label();
            oS_DATA_ENTREGALabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
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
            this.groupStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJuridico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFisico)).BeginInit();
            this.groupTotais.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oS_ITEMDataGridView)).BeginInit();
            this.groupServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOsServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oS_SERVICODataGridView)).BeginInit();
            this.tabConclusao.SuspendLayout();
            this.panelConclusao.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxAcrescimoouDesconto.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.Controls.Add(this.groupStatus);
            this.panelCabecalho.Size = new System.Drawing.Size(800, 120);
            this.panelCabecalho.Controls.SetChildIndex(this.pictureFechar, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.labelBase, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.groupStatus, 0);
            // 
            // tabPai
            // 
            this.tabPai.Controls.Add(this.tabConclusao);
            this.tabPai.Location = new System.Drawing.Point(0, 120);
            this.tabPai.Size = new System.Drawing.Size(800, 401);
            this.tabPai.SelectedIndexChanged += new System.EventHandler(this.tabPai_SelectedIndexChanged);
            this.tabPai.Controls.SetChildIndex(this.tabConclusao, 0);
            this.tabPai.Controls.SetChildIndex(this.tabDiagnostico, 0);
            this.tabPai.Controls.SetChildIndex(this.tabServicos, 0);
            this.tabPai.Controls.SetChildIndex(this.tabPecas, 0);
            this.tabPai.Controls.SetChildIndex(this.tabInfoItem, 0);
            this.tabPai.Controls.SetChildIndex(this.tabGeral, 0);
            // 
            // tabInfoItem
            // 
            this.tabInfoItem.Size = new System.Drawing.Size(792, 360);
            // 
            // tabPecas
            // 
            this.tabPecas.Size = new System.Drawing.Size(792, 360);
            // 
            // tabServicos
            // 
            this.tabServicos.Size = new System.Drawing.Size(792, 360);
            // 
            // tabDiagnostico
            // 
            this.tabDiagnostico.Size = new System.Drawing.Size(792, 360);
            // 
            // tabGeral
            // 
            this.tabGeral.Size = new System.Drawing.Size(792, 360);
            // 
            // labelBase
            // 
            this.labelBase.Location = new System.Drawing.Point(12, 27);
            this.labelBase.Size = new System.Drawing.Size(380, 62);
            this.labelBase.Text = "Ordem de serviço";
            // 
            // panelGeral
            // 
            this.panelGeral.AutoScroll = true;
            this.panelGeral.Controls.Add(this.groupBox2);
            this.panelGeral.Controls.Add(this.groupTotais);
            this.panelGeral.Controls.Add(this.groupBox1);
            this.panelGeral.Size = new System.Drawing.Size(786, 354);
            // 
            // panelInfoItem
            // 
            this.panelInfoItem.AutoScroll = true;
            this.panelInfoItem.Controls.Add(oS_OBSERVACAOLabel);
            this.panelInfoItem.Controls.Add(this.oS_OBSERVACAORichTextBox);
            this.panelInfoItem.Controls.Add(oS_AVULSOSLabel);
            this.panelInfoItem.Controls.Add(this.oS_AVULSOSRichTextBox);
            this.panelInfoItem.Controls.Add(oS_DEFEITOLabel);
            this.panelInfoItem.Controls.Add(this.oS_DEFEITORichTextBox);
            this.panelInfoItem.Controls.Add(oS_PRODUTOLabel);
            this.panelInfoItem.Controls.Add(this.oS_PRODUTOTextBox);
            this.panelInfoItem.Size = new System.Drawing.Size(786, 354);
            // 
            // panelPecas
            // 
            this.panelPecas.AutoScroll = true;
            this.panelPecas.Controls.Add(this.buttonLancarProduto);
            this.panelPecas.Controls.Add(this.oS_ITEMDataGridView);
            this.panelPecas.Controls.Add(this.buttonPesquisarProduto);
            this.panelPecas.Controls.Add(this.groupProduto);
            this.panelPecas.Size = new System.Drawing.Size(786, 354);
            // 
            // panelServicos
            // 
            this.panelServicos.AutoScroll = true;
            this.panelServicos.Controls.Add(this.buttonLancarServico);
            this.panelServicos.Controls.Add(this.buttonPesquisarServico);
            this.panelServicos.Controls.Add(this.oS_SERVICODataGridView);
            this.panelServicos.Controls.Add(this.groupServico);
            this.panelServicos.Size = new System.Drawing.Size(786, 354);
            // 
            // panelDiagnostico
            // 
            this.panelDiagnostico.Controls.Add(oS_DIAGNOSTICOLabel);
            this.panelDiagnostico.Controls.Add(this.oS_DIAGNOSTICORichTextBox);
            this.panelDiagnostico.Size = new System.Drawing.Size(786, 354);
            // 
            // cLIENTE_FISICO_NOMELabel
            // 
            cLIENTE_FISICO_NOMELabel.AutoSize = true;
            cLIENTE_FISICO_NOMELabel.Location = new System.Drawing.Point(26, 40);
            cLIENTE_FISICO_NOMELabel.Name = "cLIENTE_FISICO_NOMELabel";
            cLIENTE_FISICO_NOMELabel.Size = new System.Drawing.Size(68, 25);
            cLIENTE_FISICO_NOMELabel.TabIndex = 0;
            cLIENTE_FISICO_NOMELabel.Text = "Cliente";
            // 
            // fUNCIONARIO_NOMELabel
            // 
            fUNCIONARIO_NOMELabel.AutoSize = true;
            fUNCIONARIO_NOMELabel.Location = new System.Drawing.Point(26, 112);
            fUNCIONARIO_NOMELabel.Name = "fUNCIONARIO_NOMELabel";
            fUNCIONARIO_NOMELabel.Size = new System.Drawing.Size(104, 25);
            fUNCIONARIO_NOMELabel.TabIndex = 3;
            fUNCIONARIO_NOMELabel.Text = "Funcionário";
            // 
            // oS_TOTAL_ITEMLabel
            // 
            oS_TOTAL_ITEMLabel.AutoSize = true;
            oS_TOTAL_ITEMLabel.Location = new System.Drawing.Point(26, 42);
            oS_TOTAL_ITEMLabel.Name = "oS_TOTAL_ITEMLabel";
            oS_TOTAL_ITEMLabel.Size = new System.Drawing.Size(56, 25);
            oS_TOTAL_ITEMLabel.TabIndex = 0;
            oS_TOTAL_ITEMLabel.Text = "Peças";
            // 
            // oS_TOTAL_SERVICOLabel
            // 
            oS_TOTAL_SERVICOLabel.AutoSize = true;
            oS_TOTAL_SERVICOLabel.Location = new System.Drawing.Point(26, 100);
            oS_TOTAL_SERVICOLabel.Name = "oS_TOTAL_SERVICOLabel";
            oS_TOTAL_SERVICOLabel.Size = new System.Drawing.Size(76, 25);
            oS_TOTAL_SERVICOLabel.TabIndex = 2;
            oS_TOTAL_SERVICOLabel.Text = "Serviços";
            // 
            // oS_PRODUTOLabel
            // 
            oS_PRODUTOLabel.AutoSize = true;
            oS_PRODUTOLabel.Location = new System.Drawing.Point(11, 9);
            oS_PRODUTOLabel.Name = "oS_PRODUTOLabel";
            oS_PRODUTOLabel.Size = new System.Drawing.Size(214, 25);
            oS_PRODUTOLabel.TabIndex = 0;
            oS_PRODUTOLabel.Text = "Produto a ser concertado";
            // 
            // oS_DEFEITOLabel
            // 
            oS_DEFEITOLabel.AutoSize = true;
            oS_DEFEITOLabel.Location = new System.Drawing.Point(11, 77);
            oS_DEFEITOLabel.Name = "oS_DEFEITOLabel";
            oS_DEFEITOLabel.Size = new System.Drawing.Size(172, 25);
            oS_DEFEITOLabel.TabIndex = 2;
            oS_DEFEITOLabel.Text = "Relatório de defeito";
            // 
            // oS_AVULSOSLabel
            // 
            oS_AVULSOSLabel.AutoSize = true;
            oS_AVULSOSLabel.Location = new System.Drawing.Point(386, 77);
            oS_AVULSOSLabel.Name = "oS_AVULSOSLabel";
            oS_AVULSOSLabel.Size = new System.Drawing.Size(72, 25);
            oS_AVULSOSLabel.TabIndex = 4;
            oS_AVULSOSLabel.Text = "Avulsos";
            // 
            // oS_OBSERVACAOLabel
            // 
            oS_OBSERVACAOLabel.AutoSize = true;
            oS_OBSERVACAOLabel.Location = new System.Drawing.Point(386, 226);
            oS_OBSERVACAOLabel.Name = "oS_OBSERVACAOLabel";
            oS_OBSERVACAOLabel.Size = new System.Drawing.Size(106, 25);
            oS_OBSERVACAOLabel.TabIndex = 6;
            oS_OBSERVACAOLabel.Text = "Observação";
            // 
            // oS_ITEM_DESCRICAOLabel
            // 
            oS_ITEM_DESCRICAOLabel.AutoSize = true;
            oS_ITEM_DESCRICAOLabel.Location = new System.Drawing.Point(19, 29);
            oS_ITEM_DESCRICAOLabel.Name = "oS_ITEM_DESCRICAOLabel";
            oS_ITEM_DESCRICAOLabel.Size = new System.Drawing.Size(88, 25);
            oS_ITEM_DESCRICAOLabel.TabIndex = 0;
            oS_ITEM_DESCRICAOLabel.Text = "Descrição";
            // 
            // oS_ITEM_DESCONTOLabel
            // 
            oS_ITEM_DESCONTOLabel.AutoSize = true;
            oS_ITEM_DESCONTOLabel.Location = new System.Drawing.Point(257, 80);
            oS_ITEM_DESCONTOLabel.Name = "oS_ITEM_DESCONTOLabel";
            oS_ITEM_DESCONTOLabel.Size = new System.Drawing.Size(88, 25);
            oS_ITEM_DESCONTOLabel.TabIndex = 4;
            oS_ITEM_DESCONTOLabel.Text = "Desconto";
            // 
            // oS_ITEM_QUANTIDADELabel
            // 
            oS_ITEM_QUANTIDADELabel.AutoSize = true;
            oS_ITEM_QUANTIDADELabel.Location = new System.Drawing.Point(512, 82);
            oS_ITEM_QUANTIDADELabel.Name = "oS_ITEM_QUANTIDADELabel";
            oS_ITEM_QUANTIDADELabel.Size = new System.Drawing.Size(106, 25);
            oS_ITEM_QUANTIDADELabel.TabIndex = 6;
            oS_ITEM_QUANTIDADELabel.Text = "Quantidade";
            // 
            // pRODUTO_PRECO_VENDALabel
            // 
            pRODUTO_PRECO_VENDALabel.AutoSize = true;
            pRODUTO_PRECO_VENDALabel.Location = new System.Drawing.Point(50, 80);
            pRODUTO_PRECO_VENDALabel.Name = "pRODUTO_PRECO_VENDALabel";
            pRODUTO_PRECO_VENDALabel.Size = new System.Drawing.Size(57, 25);
            pRODUTO_PRECO_VENDALabel.TabIndex = 8;
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
            sERVICO_VALORLabel.Location = new System.Drawing.Point(40, 85);
            sERVICO_VALORLabel.Name = "sERVICO_VALORLabel";
            sERVICO_VALORLabel.Size = new System.Drawing.Size(57, 25);
            sERVICO_VALORLabel.TabIndex = 2;
            sERVICO_VALORLabel.Text = "Preço";
            // 
            // oS_SERVICO_DESCONTOLabel
            // 
            oS_SERVICO_DESCONTOLabel.AutoSize = true;
            oS_SERVICO_DESCONTOLabel.Location = new System.Drawing.Point(281, 85);
            oS_SERVICO_DESCONTOLabel.Name = "oS_SERVICO_DESCONTOLabel";
            oS_SERVICO_DESCONTOLabel.Size = new System.Drawing.Size(88, 25);
            oS_SERVICO_DESCONTOLabel.TabIndex = 4;
            oS_SERVICO_DESCONTOLabel.Text = "Desconto";
            // 
            // oS_SERVICO_ACRESCIMOLabel
            // 
            oS_SERVICO_ACRESCIMOLabel.AutoSize = true;
            oS_SERVICO_ACRESCIMOLabel.Location = new System.Drawing.Point(529, 85);
            oS_SERVICO_ACRESCIMOLabel.Name = "oS_SERVICO_ACRESCIMOLabel";
            oS_SERVICO_ACRESCIMOLabel.Size = new System.Drawing.Size(94, 25);
            oS_SERVICO_ACRESCIMOLabel.TabIndex = 6;
            oS_SERVICO_ACRESCIMOLabel.Text = "Acréscimo";
            // 
            // oS_DIAGNOSTICOLabel
            // 
            oS_DIAGNOSTICOLabel.AutoSize = true;
            oS_DIAGNOSTICOLabel.Dock = System.Windows.Forms.DockStyle.Top;
            oS_DIAGNOSTICOLabel.Location = new System.Drawing.Point(0, 0);
            oS_DIAGNOSTICOLabel.Name = "oS_DIAGNOSTICOLabel";
            oS_DIAGNOSTICOLabel.Size = new System.Drawing.Size(329, 25);
            oS_DIAGNOSTICOLabel.TabIndex = 0;
            oS_DIAGNOSTICOLabel.Text = "Descreva qual foi o diagnóstico do item";
            // 
            // oS_ACRESCIMOLabel
            // 
            oS_ACRESCIMOLabel.AutoSize = true;
            oS_ACRESCIMOLabel.Location = new System.Drawing.Point(14, 17);
            oS_ACRESCIMOLabel.Name = "oS_ACRESCIMOLabel";
            oS_ACRESCIMOLabel.Size = new System.Drawing.Size(94, 25);
            oS_ACRESCIMOLabel.TabIndex = 2;
            oS_ACRESCIMOLabel.Text = "Acréscimo";
            // 
            // oS_DESCONTOLabel
            // 
            oS_DESCONTOLabel.AutoSize = true;
            oS_DESCONTOLabel.Location = new System.Drawing.Point(14, 84);
            oS_DESCONTOLabel.Name = "oS_DESCONTOLabel";
            oS_DESCONTOLabel.Size = new System.Drawing.Size(88, 25);
            oS_DESCONTOLabel.TabIndex = 4;
            oS_DESCONTOLabel.Text = "Desconto";
            // 
            // oS_TOTALLabel
            // 
            oS_TOTALLabel.AutoSize = true;
            oS_TOTALLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            oS_TOTALLabel.Location = new System.Drawing.Point(445, 15);
            oS_TOTALLabel.Name = "oS_TOTALLabel";
            oS_TOTALLabel.Size = new System.Drawing.Size(73, 37);
            oS_TOTALLabel.TabIndex = 6;
            oS_TOTALLabel.Text = "Total";
            // 
            // oS_DATA_ENTREGALabel
            // 
            oS_DATA_ENTREGALabel.AutoSize = true;
            oS_DATA_ENTREGALabel.Location = new System.Drawing.Point(549, 186);
            oS_DATA_ENTREGALabel.Name = "oS_DATA_ENTREGALabel";
            oS_DATA_ENTREGALabel.Size = new System.Drawing.Size(142, 25);
            oS_DATA_ENTREGALabel.TabIndex = 15;
            oS_DATA_ENTREGALabel.Text = "Data de entrega";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 163);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(100, 25);
            label3.TabIndex = 7;
            label3.Text = "Total Bruto";
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.oS_STATUSComboBox);
            this.groupStatus.ForeColor = System.Drawing.Color.White;
            this.groupStatus.Location = new System.Drawing.Point(398, 22);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(319, 82);
            this.groupStatus.TabIndex = 2;
            this.groupStatus.TabStop = false;
            this.groupStatus.Text = "Status";
            // 
            // oS_STATUSComboBox
            // 
            this.oS_STATUSComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOS, "OS_STATUS", true));
            this.oS_STATUSComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oS_STATUSComboBox.FormattingEnabled = true;
            this.oS_STATUSComboBox.Items.AddRange(new object[] {
            "LANÇADO",
            "ABERTO",
            "CONCLUÍDO",
            "CANCELADO"});
            this.oS_STATUSComboBox.Location = new System.Drawing.Point(19, 32);
            this.oS_STATUSComboBox.Name = "oS_STATUSComboBox";
            this.oS_STATUSComboBox.Size = new System.Drawing.Size(281, 33);
            this.oS_STATUSComboBox.TabIndex = 1;
            // 
            // bsOS
            // 
            this.bsOS.DataMember = "OS";
            this.bsOS.DataSource = this.dsFROGIOS;
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taOS
            // 
            this.taOS.ClearBeforeFill = true;
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
            this.tableAdapterManager.FUNCIONARIOTableAdapter = null;
            this.tableAdapterManager.GRUPOTableAdapter = null;
            this.tableAdapterManager.ITEM_COMPRATableAdapter = null;
            this.tableAdapterManager.MARCATableAdapter = null;
            this.tableAdapterManager.ORCAMENTO_ITEMTableAdapter = null;
            this.tableAdapterManager.ORCAMENTO_SERVICOTableAdapter = null;
            this.tableAdapterManager.ORCAMENTOTableAdapter = null;
            this.tableAdapterManager.OS_ITEMTableAdapter = null;
            this.tableAdapterManager.OS_SERVICOTableAdapter = null;
            this.tableAdapterManager.OSTableAdapter = this.taOS;
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
            // taFisico
            // 
            this.taFisico.ClearBeforeFill = true;
            // 
            // taJuridico
            // 
            this.taJuridico.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(fUNCIONARIO_NOMELabel);
            this.groupBox1.Controls.Add(this.labelFuncionario);
            this.groupBox1.Controls.Add(cLIENTE_FISICO_NOMELabel);
            this.groupBox1.Controls.Add(this.labelCliente);
            this.groupBox1.Location = new System.Drawing.Point(16, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pessoal";
            // 
            // labelFuncionario
            // 
            this.labelFuncionario.AutoSize = true;
            this.labelFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFuncionario.Location = new System.Drawing.Point(30, 152);
            this.labelFuncionario.Name = "labelFuncionario";
            this.labelFuncionario.Size = new System.Drawing.Size(233, 25);
            this.labelFuncionario.TabIndex = 4;
            this.labelFuncionario.Text = "Duplo clique para pesquisar";
            this.labelFuncionario.DoubleClick += new System.EventHandler(this.labelFuncionario_Click);
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCliente.Location = new System.Drawing.Point(26, 76);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(233, 25);
            this.labelCliente.TabIndex = 1;
            this.labelCliente.Text = "Duplo clique para pesquisar";
            this.labelCliente.DoubleClick += new System.EventHandler(this.labelCliente_Click);
            // 
            // bsFuncionario
            // 
            this.bsFuncionario.DataMember = "FUNCIONARIO";
            this.bsFuncionario.DataSource = this.dsFROGIOS;
            // 
            // bsJuridico
            // 
            this.bsJuridico.DataMember = "CLIENTE_JURIDICO";
            this.bsJuridico.DataSource = this.dsFROGIOS;
            // 
            // bsFisico
            // 
            this.bsFisico.DataMember = "CLIENTE_FISICO";
            this.bsFisico.DataSource = this.dsFROGIOS;
            // 
            // taFuncionario
            // 
            this.taFuncionario.ClearBeforeFill = true;
            // 
            // groupTotais
            // 
            this.groupTotais.Controls.Add(this.textTotalBruto);
            this.groupTotais.Controls.Add(this.textTotalServicos);
            this.groupTotais.Controls.Add(this.textTotalPecas);
            this.groupTotais.Controls.Add(label3);
            this.groupTotais.Controls.Add(oS_TOTAL_SERVICOLabel);
            this.groupTotais.Controls.Add(oS_TOTAL_ITEMLabel);
            this.groupTotais.Location = new System.Drawing.Point(16, 223);
            this.groupTotais.Name = "groupTotais";
            this.groupTotais.Size = new System.Drawing.Size(300, 210);
            this.groupTotais.TabIndex = 1;
            this.groupTotais.TabStop = false;
            this.groupTotais.Text = "Totais";
            // 
            // textTotalBruto
            // 
            this.textTotalBruto.Location = new System.Drawing.Point(150, 160);
            this.textTotalBruto.Name = "textTotalBruto";
            this.textTotalBruto.ReadOnly = true;
            this.textTotalBruto.Size = new System.Drawing.Size(129, 33);
            this.textTotalBruto.TabIndex = 10;
            this.textTotalBruto.Text = "R$ 0,00";
            this.textTotalBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTotalBruto.Valor = 0D;
            // 
            // textTotalServicos
            // 
            this.textTotalServicos.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsOS, "OS_TOTAL_SERVICO", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textTotalServicos.Location = new System.Drawing.Point(150, 97);
            this.textTotalServicos.Name = "textTotalServicos";
            this.textTotalServicos.ReadOnly = true;
            this.textTotalServicos.Size = new System.Drawing.Size(129, 33);
            this.textTotalServicos.TabIndex = 9;
            this.textTotalServicos.Text = "R$ 0,00";
            this.textTotalServicos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTotalServicos.Valor = 0D;
            // 
            // textTotalPecas
            // 
            this.textTotalPecas.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsOS, "OS_TOTAL_ITEM", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textTotalPecas.Location = new System.Drawing.Point(150, 39);
            this.textTotalPecas.Name = "textTotalPecas";
            this.textTotalPecas.ReadOnly = true;
            this.textTotalPecas.Size = new System.Drawing.Size(129, 33);
            this.textTotalPecas.TabIndex = 8;
            this.textTotalPecas.Text = "R$ 0,00";
            this.textTotalPecas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTotalPecas.Valor = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Bruto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.oS_DATALabel1);
            this.groupBox2.Location = new System.Drawing.Point(334, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 207);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data de lançamento";
            // 
            // oS_DATALabel1
            // 
            this.oS_DATALabel1.AutoSize = true;
            this.oS_DATALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOS, "OS_DATA", true));
            this.oS_DATALabel1.Location = new System.Drawing.Point(17, 100);
            this.oS_DATALabel1.Name = "oS_DATALabel1";
            this.oS_DATALabel1.Size = new System.Drawing.Size(49, 25);
            this.oS_DATALabel1.TabIndex = 1;
            this.oS_DATALabel1.Text = "Data";
            // 
            // oS_PRODUTOTextBox
            // 
            this.oS_PRODUTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOS, "OS_PRODUTO", true));
            this.oS_PRODUTOTextBox.Location = new System.Drawing.Point(16, 37);
            this.oS_PRODUTOTextBox.MaxLength = 120;
            this.oS_PRODUTOTextBox.Name = "oS_PRODUTOTextBox";
            this.oS_PRODUTOTextBox.Size = new System.Drawing.Size(745, 33);
            this.oS_PRODUTOTextBox.TabIndex = 1;
            // 
            // oS_DEFEITORichTextBox
            // 
            this.oS_DEFEITORichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOS, "OS_DEFEITO", true));
            this.oS_DEFEITORichTextBox.Location = new System.Drawing.Point(16, 111);
            this.oS_DEFEITORichTextBox.MaxLength = 200;
            this.oS_DEFEITORichTextBox.Name = "oS_DEFEITORichTextBox";
            this.oS_DEFEITORichTextBox.Size = new System.Drawing.Size(364, 258);
            this.oS_DEFEITORichTextBox.TabIndex = 3;
            this.oS_DEFEITORichTextBox.Text = "";
            // 
            // oS_AVULSOSRichTextBox
            // 
            this.oS_AVULSOSRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOS, "OS_AVULSOS", true));
            this.oS_AVULSOSRichTextBox.Location = new System.Drawing.Point(391, 111);
            this.oS_AVULSOSRichTextBox.MaxLength = 200;
            this.oS_AVULSOSRichTextBox.Name = "oS_AVULSOSRichTextBox";
            this.oS_AVULSOSRichTextBox.Size = new System.Drawing.Size(370, 112);
            this.oS_AVULSOSRichTextBox.TabIndex = 5;
            this.oS_AVULSOSRichTextBox.Text = "";
            // 
            // oS_OBSERVACAORichTextBox
            // 
            this.oS_OBSERVACAORichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOS, "OS_OBSERVACAO", true));
            this.oS_OBSERVACAORichTextBox.Location = new System.Drawing.Point(391, 254);
            this.oS_OBSERVACAORichTextBox.MaxLength = 200;
            this.oS_OBSERVACAORichTextBox.Name = "oS_OBSERVACAORichTextBox";
            this.oS_OBSERVACAORichTextBox.Size = new System.Drawing.Size(370, 115);
            this.oS_OBSERVACAORichTextBox.TabIndex = 7;
            this.oS_OBSERVACAORichTextBox.Text = "";
            // 
            // groupProduto
            // 
            this.groupProduto.Controls.Add(this.textProdutoPreco);
            this.groupProduto.Controls.Add(this.textProdutoDesconto);
            this.groupProduto.Controls.Add(pRODUTO_PRECO_VENDALabel);
            this.groupProduto.Controls.Add(this.pRODUTO_DESCRICAOTextBox);
            this.groupProduto.Controls.Add(oS_ITEM_QUANTIDADELabel);
            this.groupProduto.Controls.Add(this.textPecaQuantidade);
            this.groupProduto.Controls.Add(oS_ITEM_DESCONTOLabel);
            this.groupProduto.Controls.Add(oS_ITEM_DESCRICAOLabel);
            this.groupProduto.Location = new System.Drawing.Point(16, 43);
            this.groupProduto.Name = "groupProduto";
            this.groupProduto.Size = new System.Drawing.Size(747, 131);
            this.groupProduto.TabIndex = 0;
            this.groupProduto.TabStop = false;
            // 
            // textProdutoPreco
            // 
            this.textProdutoPreco.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsProduto, "PRODUTO_PRECO_VENDA", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textProdutoPreco.Location = new System.Drawing.Point(113, 77);
            this.textProdutoPreco.Name = "textProdutoPreco";
            this.textProdutoPreco.ReadOnly = true;
            this.textProdutoPreco.Size = new System.Drawing.Size(118, 33);
            this.textProdutoPreco.TabIndex = 10;
            this.textProdutoPreco.Text = "R$ 0,00";
            this.textProdutoPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textProdutoPreco.Valor = 0D;
            // 
            // bsProduto
            // 
            this.bsProduto.DataMember = "PRODUTO";
            this.bsProduto.DataSource = this.dsFROGIOS;
            // 
            // textProdutoDesconto
            // 
            this.textProdutoDesconto.Location = new System.Drawing.Point(351, 77);
            this.textProdutoDesconto.Name = "textProdutoDesconto";
            this.textProdutoDesconto.Size = new System.Drawing.Size(137, 33);
            this.textProdutoDesconto.TabIndex = 9;
            this.textProdutoDesconto.Text = "R$ 0,00";
            this.textProdutoDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textProdutoDesconto.Valor = 0D;
            // 
            // pRODUTO_DESCRICAOTextBox
            // 
            this.pRODUTO_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_DESCRICAO", true));
            this.pRODUTO_DESCRICAOTextBox.Location = new System.Drawing.Point(113, 26);
            this.pRODUTO_DESCRICAOTextBox.MaxLength = 120;
            this.pRODUTO_DESCRICAOTextBox.Name = "pRODUTO_DESCRICAOTextBox";
            this.pRODUTO_DESCRICAOTextBox.ReadOnly = true;
            this.pRODUTO_DESCRICAOTextBox.Size = new System.Drawing.Size(611, 33);
            this.pRODUTO_DESCRICAOTextBox.TabIndex = 1;
            // 
            // textPecaQuantidade
            // 
            this.textPecaQuantidade.Location = new System.Drawing.Point(624, 77);
            this.textPecaQuantidade.Name = "textPecaQuantidade";
            this.textPecaQuantidade.Size = new System.Drawing.Size(100, 33);
            this.textPecaQuantidade.TabIndex = 4;
            // 
            // bsOsItem
            // 
            this.bsOsItem.DataMember = "OS_ITEM";
            this.bsOsItem.DataSource = this.dsFROGIOS;
            // 
            // taOsItem
            // 
            this.taOsItem.ClearBeforeFill = true;
            // 
            // taProduto
            // 
            this.taProduto.ClearBeforeFill = true;
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
            // oS_ITEMDataGridView
            // 
            this.oS_ITEMDataGridView.AllowUserToAddRows = false;
            this.oS_ITEMDataGridView.AutoGenerateColumns = false;
            this.oS_ITEMDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.oS_ITEMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oS_ITEMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.colunaProdutoValor,
            this.colunaProdutoDesconto,
            this.dataGridViewTextBoxColumn7,
            this.colunaProdutoTotal});
            this.oS_ITEMDataGridView.DataSource = this.bsOsItem;
            this.oS_ITEMDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oS_ITEMDataGridView.Location = new System.Drawing.Point(0, 220);
            this.oS_ITEMDataGridView.Name = "oS_ITEMDataGridView";
            this.oS_ITEMDataGridView.ReadOnly = true;
            this.oS_ITEMDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.oS_ITEMDataGridView.Size = new System.Drawing.Size(786, 134);
            this.oS_ITEMDataGridView.TabIndex = 6;
            this.oS_ITEMDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.oS_ITEMDataGridView_CellDoubleClick);
            this.oS_ITEMDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.oS_ITEMDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OS_ITEM_DESCRICAO";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colunaProdutoValor
            // 
            this.colunaProdutoValor.DataPropertyName = "OS_ITEM_VALOR";
            this.colunaProdutoValor.HeaderText = "Valor";
            this.colunaProdutoValor.Name = "colunaProdutoValor";
            this.colunaProdutoValor.ReadOnly = true;
            this.colunaProdutoValor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colunaProdutoDesconto
            // 
            this.colunaProdutoDesconto.DataPropertyName = "OS_ITEM_DESCONTO";
            this.colunaProdutoDesconto.HeaderText = "Desconto";
            this.colunaProdutoDesconto.Name = "colunaProdutoDesconto";
            this.colunaProdutoDesconto.ReadOnly = true;
            this.colunaProdutoDesconto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OS_ITEM_QUANTIDADE";
            this.dataGridViewTextBoxColumn7.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colunaProdutoTotal
            // 
            this.colunaProdutoTotal.DataPropertyName = "OS_ITEM_TOTAL";
            this.colunaProdutoTotal.HeaderText = "Total";
            this.colunaProdutoTotal.Name = "colunaProdutoTotal";
            this.colunaProdutoTotal.ReadOnly = true;
            this.colunaProdutoTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.buttonLancarProduto.Text = "Lançar produto";
            this.buttonLancarProduto.UseVisualStyleBackColor = true;
            this.buttonLancarProduto.Click += new System.EventHandler(this.buttonLancarProduto_Click);
            // 
            // groupServico
            // 
            this.groupServico.Controls.Add(this.textServicoAcrescimo);
            this.groupServico.Controls.Add(this.textServicoDesconto);
            this.groupServico.Controls.Add(this.textServicoPreco);
            this.groupServico.Controls.Add(oS_SERVICO_ACRESCIMOLabel);
            this.groupServico.Controls.Add(oS_SERVICO_DESCONTOLabel);
            this.groupServico.Controls.Add(sERVICO_VALORLabel);
            this.groupServico.Controls.Add(sERVICO_DESCRICAOLabel);
            this.groupServico.Controls.Add(this.sERVICO_DESCRICAOTextBox);
            this.groupServico.Location = new System.Drawing.Point(16, 43);
            this.groupServico.Name = "groupServico";
            this.groupServico.Size = new System.Drawing.Size(750, 137);
            this.groupServico.TabIndex = 0;
            this.groupServico.TabStop = false;
            // 
            // textServicoAcrescimo
            // 
            this.textServicoAcrescimo.Location = new System.Drawing.Point(629, 82);
            this.textServicoAcrescimo.Name = "textServicoAcrescimo";
            this.textServicoAcrescimo.Size = new System.Drawing.Size(100, 33);
            this.textServicoAcrescimo.TabIndex = 9;
            this.textServicoAcrescimo.Text = "R$ 0,00";
            this.textServicoAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textServicoAcrescimo.Valor = 0D;
            this.textServicoAcrescimo.TextChanged += new System.EventHandler(this.textServicoAcrescimo_TextChanged);
            // 
            // textServicoDesconto
            // 
            this.textServicoDesconto.Location = new System.Drawing.Point(375, 82);
            this.textServicoDesconto.Name = "textServicoDesconto";
            this.textServicoDesconto.Size = new System.Drawing.Size(137, 33);
            this.textServicoDesconto.TabIndex = 8;
            this.textServicoDesconto.Text = "R$ 0,00";
            this.textServicoDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textServicoDesconto.Valor = 0D;
            this.textServicoDesconto.TextChanged += new System.EventHandler(this.textServicoDesconto_TextChanged);
            // 
            // textServicoPreco
            // 
            this.textServicoPreco.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsServico, "SERVICO_VALOR", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textServicoPreco.Location = new System.Drawing.Point(112, 82);
            this.textServicoPreco.Name = "textServicoPreco";
            this.textServicoPreco.ReadOnly = true;
            this.textServicoPreco.Size = new System.Drawing.Size(147, 33);
            this.textServicoPreco.TabIndex = 7;
            this.textServicoPreco.Text = "R$ 0,00";
            this.textServicoPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textServicoPreco.Valor = 0D;
            // 
            // bsServico
            // 
            this.bsServico.DataMember = "SERVICO";
            this.bsServico.DataSource = this.dsFROGIOS;
            // 
            // sERVICO_DESCRICAOTextBox
            // 
            this.sERVICO_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsServico, "SERVICO_DESCRICAO", true));
            this.sERVICO_DESCRICAOTextBox.Location = new System.Drawing.Point(112, 32);
            this.sERVICO_DESCRICAOTextBox.MaxLength = 120;
            this.sERVICO_DESCRICAOTextBox.Name = "sERVICO_DESCRICAOTextBox";
            this.sERVICO_DESCRICAOTextBox.ReadOnly = true;
            this.sERVICO_DESCRICAOTextBox.Size = new System.Drawing.Size(617, 33);
            this.sERVICO_DESCRICAOTextBox.TabIndex = 1;
            // 
            // bsOsServico
            // 
            this.bsOsServico.DataMember = "OS_SERVICO";
            this.bsOsServico.DataSource = this.dsFROGIOS;
            // 
            // taServico
            // 
            this.taServico.ClearBeforeFill = true;
            // 
            // taOsServico
            // 
            this.taOsServico.ClearBeforeFill = true;
            // 
            // oS_SERVICODataGridView
            // 
            this.oS_SERVICODataGridView.AllowUserToAddRows = false;
            this.oS_SERVICODataGridView.AutoGenerateColumns = false;
            this.oS_SERVICODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.oS_SERVICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oS_SERVICODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaServicoDescricao,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.oS_SERVICODataGridView.DataSource = this.bsOsServico;
            this.oS_SERVICODataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oS_SERVICODataGridView.Location = new System.Drawing.Point(0, 229);
            this.oS_SERVICODataGridView.Name = "oS_SERVICODataGridView";
            this.oS_SERVICODataGridView.ReadOnly = true;
            this.oS_SERVICODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.oS_SERVICODataGridView.Size = new System.Drawing.Size(786, 125);
            this.oS_SERVICODataGridView.TabIndex = 6;
            this.oS_SERVICODataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.oS_SERVICODataGridView_CellDoubleClick);
            this.oS_SERVICODataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.oS_SERVICODataGridView_CellFormatting);
            // 
            // colunaServicoDescricao
            // 
            this.colunaServicoDescricao.DataPropertyName = "OS_SERVICO_DESCRICAO";
            this.colunaServicoDescricao.HeaderText = "Descrição";
            this.colunaServicoDescricao.Name = "colunaServicoDescricao";
            this.colunaServicoDescricao.ReadOnly = true;
            this.colunaServicoDescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OS_SERVICO_VALOR";
            this.dataGridViewTextBoxColumn9.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OS_SERVICO_DESCONTO";
            this.dataGridViewTextBoxColumn11.HeaderText = "Desconto";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "OS_SERVICO_ACRESCIMO";
            this.dataGridViewTextBoxColumn12.HeaderText = "Acréscimo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "OS_SERVICO_TOTAL";
            this.dataGridViewTextBoxColumn13.HeaderText = "Total";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.buttonPesquisarServico.Text = "Pesquisar Serviço";
            this.buttonPesquisarServico.UseVisualStyleBackColor = true;
            this.buttonPesquisarServico.Click += new System.EventHandler(this.buttonPesquisarServico_Click);
            // 
            // buttonLancarServico
            // 
            this.buttonLancarServico.AutoSize = true;
            this.buttonLancarServico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLancarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLancarServico.Location = new System.Drawing.Point(0, 192);
            this.buttonLancarServico.Name = "buttonLancarServico";
            this.buttonLancarServico.Size = new System.Drawing.Size(786, 37);
            this.buttonLancarServico.TabIndex = 5;
            this.buttonLancarServico.Text = "Lançar Serviço";
            this.buttonLancarServico.UseVisualStyleBackColor = true;
            this.buttonLancarServico.Click += new System.EventHandler(this.buttonLancarServico_Click);
            // 
            // oS_DIAGNOSTICORichTextBox
            // 
            this.oS_DIAGNOSTICORichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOS, "OS_DIAGNOSTICO", true));
            this.oS_DIAGNOSTICORichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oS_DIAGNOSTICORichTextBox.Location = new System.Drawing.Point(0, 22);
            this.oS_DIAGNOSTICORichTextBox.MaxLength = 200;
            this.oS_DIAGNOSTICORichTextBox.Name = "oS_DIAGNOSTICORichTextBox";
            this.oS_DIAGNOSTICORichTextBox.Size = new System.Drawing.Size(786, 332);
            this.oS_DIAGNOSTICORichTextBox.TabIndex = 1;
            this.oS_DIAGNOSTICORichTextBox.Text = "";
            // 
            // tabConclusao
            // 
            this.tabConclusao.BackColor = System.Drawing.Color.LightBlue;
            this.tabConclusao.Controls.Add(this.panelConclusao);
            this.tabConclusao.Location = new System.Drawing.Point(4, 37);
            this.tabConclusao.Name = "tabConclusao";
            this.tabConclusao.Padding = new System.Windows.Forms.Padding(3);
            this.tabConclusao.Size = new System.Drawing.Size(792, 360);
            this.tabConclusao.TabIndex = 5;
            this.tabConclusao.Text = "Conclusão";
            // 
            // panelConclusao
            // 
            this.panelConclusao.AutoScroll = true;
            this.panelConclusao.Controls.Add(this.textTotalLiquido);
            this.panelConclusao.Controls.Add(oS_DATA_ENTREGALabel);
            this.panelConclusao.Controls.Add(this.oS_DATA_ENTREGADateTimePicker);
            this.panelConclusao.Controls.Add(this.groupBox5);
            this.panelConclusao.Controls.Add(this.groupBoxAcrescimoouDesconto);
            this.panelConclusao.Controls.Add(this.groupBox3);
            this.panelConclusao.Controls.Add(oS_TOTALLabel);
            this.panelConclusao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConclusao.Location = new System.Drawing.Point(3, 3);
            this.panelConclusao.Margin = new System.Windows.Forms.Padding(0);
            this.panelConclusao.Name = "panelConclusao";
            this.panelConclusao.Size = new System.Drawing.Size(786, 354);
            this.panelConclusao.TabIndex = 0;
            // 
            // textTotalLiquido
            // 
            this.textTotalLiquido.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsOS, "OS_TOTAL", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textTotalLiquido.Font = new System.Drawing.Font("Segoe UI Light", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalLiquido.Location = new System.Drawing.Point(452, 55);
            this.textTotalLiquido.Name = "textTotalLiquido";
            this.textTotalLiquido.ReadOnly = true;
            this.textTotalLiquido.Size = new System.Drawing.Size(313, 70);
            this.textTotalLiquido.TabIndex = 17;
            this.textTotalLiquido.Text = "R$ 0,00";
            this.textTotalLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTotalLiquido.Valor = 0D;
            // 
            // oS_DATA_ENTREGADateTimePicker
            // 
            this.oS_DATA_ENTREGADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOS, "OS_DATA_ENTREGA", true));
            this.oS_DATA_ENTREGADateTimePicker.Location = new System.Drawing.Point(491, 214);
            this.oS_DATA_ENTREGADateTimePicker.Name = "oS_DATA_ENTREGADateTimePicker";
            this.oS_DATA_ENTREGADateTimePicker.Size = new System.Drawing.Size(274, 33);
            this.oS_DATA_ENTREGADateTimePicker.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textTroco);
            this.groupBox5.Controls.Add(this.textValorPago);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.Troco);
            this.groupBox5.Location = new System.Drawing.Point(16, 133);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(232, 207);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            // 
            // textTroco
            // 
            this.textTroco.Location = new System.Drawing.Point(24, 137);
            this.textTroco.Name = "textTroco";
            this.textTroco.ReadOnly = true;
            this.textTroco.Size = new System.Drawing.Size(190, 33);
            this.textTroco.TabIndex = 14;
            this.textTroco.Text = "R$ 0,00";
            this.textTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTroco.Valor = 0D;
            // 
            // textValorPago
            // 
            this.textValorPago.Location = new System.Drawing.Point(24, 73);
            this.textValorPago.Name = "textValorPago";
            this.textValorPago.Size = new System.Drawing.Size(190, 33);
            this.textValorPago.TabIndex = 13;
            this.textValorPago.Text = "R$ 0,00";
            this.textValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textValorPago.Valor = 0D;
            this.textValorPago.TextChanged += new System.EventHandler(this.textValorPago_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Valor pago";
            // 
            // Troco
            // 
            this.Troco.AutoSize = true;
            this.Troco.Location = new System.Drawing.Point(14, 109);
            this.Troco.Name = "Troco";
            this.Troco.Size = new System.Drawing.Size(58, 25);
            this.Troco.TabIndex = 10;
            this.Troco.Text = "Troco";
            // 
            // groupBoxAcrescimoouDesconto
            // 
            this.groupBoxAcrescimoouDesconto.Controls.Add(this.textOSDesconto);
            this.groupBoxAcrescimoouDesconto.Controls.Add(this.textOSAcrescimo);
            this.groupBoxAcrescimoouDesconto.Controls.Add(this.buttonAplicar);
            this.groupBoxAcrescimoouDesconto.Controls.Add(oS_ACRESCIMOLabel);
            this.groupBoxAcrescimoouDesconto.Controls.Add(oS_DESCONTOLabel);
            this.groupBoxAcrescimoouDesconto.Location = new System.Drawing.Point(254, 133);
            this.groupBoxAcrescimoouDesconto.Name = "groupBoxAcrescimoouDesconto";
            this.groupBoxAcrescimoouDesconto.Size = new System.Drawing.Size(226, 207);
            this.groupBoxAcrescimoouDesconto.TabIndex = 14;
            this.groupBoxAcrescimoouDesconto.TabStop = false;
            // 
            // textOSDesconto
            // 
            this.textOSDesconto.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsOS, "OS_DESCONTO", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textOSDesconto.Location = new System.Drawing.Point(19, 112);
            this.textOSDesconto.Name = "textOSDesconto";
            this.textOSDesconto.Size = new System.Drawing.Size(195, 33);
            this.textOSDesconto.TabIndex = 19;
            this.textOSDesconto.Text = "R$ 0,00";
            this.textOSDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textOSDesconto.Valor = 0D;
            this.textOSDesconto.TextChanged += new System.EventHandler(this.oRCAMENTO_DESCONTOTextBox_TextChanged);
            // 
            // textOSAcrescimo
            // 
            this.textOSAcrescimo.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsOS, "OS_ACRESCIMO", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textOSAcrescimo.Location = new System.Drawing.Point(19, 48);
            this.textOSAcrescimo.Name = "textOSAcrescimo";
            this.textOSAcrescimo.Size = new System.Drawing.Size(195, 33);
            this.textOSAcrescimo.TabIndex = 18;
            this.textOSAcrescimo.Text = "R$ 0,00";
            this.textOSAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textOSAcrescimo.Valor = 0D;
            this.textOSAcrescimo.TextChanged += new System.EventHandler(this.oRCAMENTO_ACRESCIMOTextBox_TextChanged);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.AutoSize = true;
            this.buttonAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAplicar.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.buttonAplicar.Location = new System.Drawing.Point(19, 151);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(195, 40);
            this.buttonAplicar.TabIndex = 17;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            this.buttonAplicar.Click += new System.EventHandler(this.buttonAplicar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.oS_FORMA_PAGAMENTOComboBox);
            this.groupBox3.Location = new System.Drawing.Point(16, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 100);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Forma de pagamento";
            // 
            // oS_FORMA_PAGAMENTOComboBox
            // 
            this.oS_FORMA_PAGAMENTOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOS, "OS_FORMA_PAGAMENTO", true));
            this.oS_FORMA_PAGAMENTOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oS_FORMA_PAGAMENTOComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oS_FORMA_PAGAMENTOComboBox.FormattingEnabled = true;
            this.oS_FORMA_PAGAMENTOComboBox.Items.AddRange(new object[] {
            "DINHEIRO",
            "CARTÃO",
            "DEPÓSITO",
            "BOLETO",
            "TRANSFERÊNCIA",
            "OUTRO"});
            this.oS_FORMA_PAGAMENTOComboBox.Location = new System.Drawing.Point(19, 42);
            this.oS_FORMA_PAGAMENTOComboBox.Name = "oS_FORMA_PAGAMENTOComboBox";
            this.oS_FORMA_PAGAMENTOComboBox.Size = new System.Drawing.Size(288, 33);
            this.oS_FORMA_PAGAMENTOComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor pago";
            // 
            // formCadastroOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "formCadastroOS";
            this.Text = "formCadastroOS";
            this.Load += new System.EventHandler(this.formCadastroOS_Load);
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
            this.groupStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJuridico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFisico)).EndInit();
            this.groupTotais.ResumeLayout(false);
            this.groupTotais.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupProduto.ResumeLayout(false);
            this.groupProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oS_ITEMDataGridView)).EndInit();
            this.groupServico.ResumeLayout(false);
            this.groupServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOsServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oS_SERVICODataGridView)).EndInit();
            this.tabConclusao.ResumeLayout(false);
            this.panelConclusao.ResumeLayout(false);
            this.panelConclusao.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxAcrescimoouDesconto.ResumeLayout(false);
            this.groupBoxAcrescimoouDesconto.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupStatus;
        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsOS;
        private dsFROGIOSTableAdapters.OSTableAdapter taOS;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private dsFROGIOSTableAdapters.CLIENTE_FISICOTableAdapter taFisico;
        private System.Windows.Forms.BindingSource bsFisico;
        private System.Windows.Forms.Label labelCliente;
        private dsFROGIOSTableAdapters.CLIENTE_JURIDICOTableAdapter taJuridico;
        private System.Windows.Forms.BindingSource bsJuridico;
        private System.Windows.Forms.BindingSource bsFuncionario;
        private dsFROGIOSTableAdapters.FUNCIONARIOTableAdapter taFuncionario;
        private System.Windows.Forms.Label labelFuncionario;
        private System.Windows.Forms.GroupBox groupTotais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label oS_DATALabel1;
        private System.Windows.Forms.TextBox oS_PRODUTOTextBox;
        private System.Windows.Forms.RichTextBox oS_DEFEITORichTextBox;
        private System.Windows.Forms.RichTextBox oS_AVULSOSRichTextBox;
        private System.Windows.Forms.RichTextBox oS_OBSERVACAORichTextBox;
        private System.Windows.Forms.GroupBox groupProduto;
        private System.Windows.Forms.BindingSource bsOsItem;
        private dsFROGIOSTableAdapters.OS_ITEMTableAdapter taOsItem;
        private System.Windows.Forms.TextBox textPecaQuantidade;
        private System.Windows.Forms.BindingSource bsProduto;
        private dsFROGIOSTableAdapters.PRODUTOTableAdapter taProduto;
        private System.Windows.Forms.TextBox pRODUTO_DESCRICAOTextBox;
        private System.Windows.Forms.Button buttonPesquisarProduto;
        private System.Windows.Forms.Button buttonLancarProduto;
        private System.Windows.Forms.DataGridView oS_ITEMDataGridView;
        private System.Windows.Forms.GroupBox groupServico;
        private System.Windows.Forms.BindingSource bsServico;
        private dsFROGIOSTableAdapters.SERVICOTableAdapter taServico;
        private System.Windows.Forms.TextBox sERVICO_DESCRICAOTextBox;
        private System.Windows.Forms.BindingSource bsOsServico;
        private dsFROGIOSTableAdapters.OS_SERVICOTableAdapter taOsServico;
        private System.Windows.Forms.Button buttonLancarServico;
        private System.Windows.Forms.Button buttonPesquisarServico;
        private System.Windows.Forms.DataGridView oS_SERVICODataGridView;
        private System.Windows.Forms.RichTextBox oS_DIAGNOSTICORichTextBox;
        private System.Windows.Forms.TabPage tabConclusao;
        private System.Windows.Forms.Panel panelConclusao;
        private System.Windows.Forms.ComboBox oS_FORMA_PAGAMENTOComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Troco;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBoxAcrescimoouDesconto;
        private System.Windows.Forms.DateTimePicker oS_DATA_ENTREGADateTimePicker;
        private System.Windows.Forms.Button buttonAplicar;
        private System.Windows.Forms.ComboBox oS_STATUSComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaProdutoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaProdutoDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaProdutoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaServicoDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private WindowsFormsApplication2.Monetario textTotalBruto;
        private WindowsFormsApplication2.Monetario textTotalServicos;
        private WindowsFormsApplication2.Monetario textTotalPecas;
        private WindowsFormsApplication2.Monetario textProdutoPreco;
        private WindowsFormsApplication2.Monetario textProdutoDesconto;
        private WindowsFormsApplication2.Monetario textServicoAcrescimo;
        private WindowsFormsApplication2.Monetario textServicoDesconto;
        private WindowsFormsApplication2.Monetario textServicoPreco;
        private WindowsFormsApplication2.Monetario textTroco;
        private WindowsFormsApplication2.Monetario textValorPago;
        private WindowsFormsApplication2.Monetario textTotalLiquido;
        private WindowsFormsApplication2.Monetario textOSDesconto;
        private WindowsFormsApplication2.Monetario textOSAcrescimo;
    }
}