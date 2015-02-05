namespace FROGI_OS
{
    partial class formCadastroProduto : formCadastro
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
            System.Windows.Forms.Label pRODUTO_CODIGOLabel;
            System.Windows.Forms.Label pRODUTO_DESCRICAOLabel;
            System.Windows.Forms.Label pRODUTO_CARACTERISTICALabel;
            System.Windows.Forms.Label pRODUTO_UNIDADE_COMPRALabel;
            System.Windows.Forms.Label pRODUTO_UNIDADE_VENDALabel;
            System.Windows.Forms.Label pRODUTO_PESOLabel;
            System.Windows.Forms.Label pRODUTO_NUMEROLabel;
            System.Windows.Forms.Label pRODUTO_EANLabel;
            System.Windows.Forms.Label pRODUTO_NUMERO_SERIELabel;
            System.Windows.Forms.Label pRODUTO_CFOPLabel;
            System.Windows.Forms.Label pRODUTO_CSOSNLabel;
            System.Windows.Forms.Label pRODUTO_NCMLabel;
            System.Windows.Forms.Label pRODUTO_SITUACAO_TRIBUTARIALabel;
            System.Windows.Forms.Label pRODUTO_ORIGEM_MERCADORIALabel;
            System.Windows.Forms.Label pRODUTO_ESTOQUE_MINIMOLabel;
            System.Windows.Forms.Label pRODUTO_ESTOQUE_MAXIMOLabel;
            System.Windows.Forms.Label pRODUTO_ESTOQUE_ATUALLabel;
            System.Windows.Forms.Label pRODUTO_PRECO_COMPRALabel;
            System.Windows.Forms.Label pRODUTO_PRECO_CUSTOLabel;
            System.Windows.Forms.Label pRODUTO_PRECO_VENDALabel;
            System.Windows.Forms.Label pRODUTO_DATA_CADASTROLabel;
            System.Windows.Forms.Label mARCA_DESCRICAOLabel;
            System.Windows.Forms.Label gRUPO_DESCRICAOLabel;
            System.Windows.Forms.Label sECAO_DESCRICAOLabel;
            System.Windows.Forms.Label fORNECEDOR_JURIDICO_FANTASIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroProduto));
            this.pRODUTO_CODIGOLabel1 = new System.Windows.Forms.Label();
            this.bsProduto = new System.Windows.Forms.BindingSource(this.components);
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.pRODUTO_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_CARACTERISTICATextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_UNIDADE_COMPRATextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_UNIDADE_VENDATextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_PESOTextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_NUMEROTextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_EANTextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_NUMERO_SERIETextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_CFOPTextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_CSOSNTextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_NCMTextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_SITUACAO_TRIBUTARIATextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_ORIGEM_MERCADORIATextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_ESTOQUE_MINIMOTextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_ESTOQUE_MAXIMOTextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_ESTOQUE_ATUALTextBox = new System.Windows.Forms.TextBox();
            this.pRODUTO_DATA_CADASTROLabel1 = new System.Windows.Forms.Label();
            this.mARCA_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.bsMarca = new System.Windows.Forms.BindingSource(this.components);
            this.gRUPO_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.bsGrupo = new System.Windows.Forms.BindingSource(this.components);
            this.sECAO_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.bsSecao = new System.Windows.Forms.BindingSource(this.components);
            this.fORNECEDOR_FISICO_NOMETextBox = new System.Windows.Forms.TextBox();
            this.bsFisico = new System.Windows.Forms.BindingSource(this.components);
            this.fORNECEDOR_JURIDICO_FANTASIATextBox = new System.Windows.Forms.TextBox();
            this.bsJuridico = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textVenda = new WindowsFormsApplication2.Monetario();
            this.textCusto = new WindowsFormsApplication2.Monetario();
            this.textCompra = new WindowsFormsApplication2.Monetario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.taProduto = new FROGI_OS.dsFROGIOSTableAdapters.PRODUTOTableAdapter();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.taFisico = new FROGI_OS.dsFROGIOSTableAdapters.FORNECEDOR_FISICOTableAdapter();
            this.taJuridico = new FROGI_OS.dsFROGIOSTableAdapters.FORNECEDOR_JURIDICOTableAdapter();
            this.taGrupo = new FROGI_OS.dsFROGIOSTableAdapters.GRUPOTableAdapter();
            this.taMarca = new FROGI_OS.dsFROGIOSTableAdapters.MARCATableAdapter();
            this.taSecao = new FROGI_OS.dsFROGIOSTableAdapters.SECAOTableAdapter();
            pRODUTO_CODIGOLabel = new System.Windows.Forms.Label();
            pRODUTO_DESCRICAOLabel = new System.Windows.Forms.Label();
            pRODUTO_CARACTERISTICALabel = new System.Windows.Forms.Label();
            pRODUTO_UNIDADE_COMPRALabel = new System.Windows.Forms.Label();
            pRODUTO_UNIDADE_VENDALabel = new System.Windows.Forms.Label();
            pRODUTO_PESOLabel = new System.Windows.Forms.Label();
            pRODUTO_NUMEROLabel = new System.Windows.Forms.Label();
            pRODUTO_EANLabel = new System.Windows.Forms.Label();
            pRODUTO_NUMERO_SERIELabel = new System.Windows.Forms.Label();
            pRODUTO_CFOPLabel = new System.Windows.Forms.Label();
            pRODUTO_CSOSNLabel = new System.Windows.Forms.Label();
            pRODUTO_NCMLabel = new System.Windows.Forms.Label();
            pRODUTO_SITUACAO_TRIBUTARIALabel = new System.Windows.Forms.Label();
            pRODUTO_ORIGEM_MERCADORIALabel = new System.Windows.Forms.Label();
            pRODUTO_ESTOQUE_MINIMOLabel = new System.Windows.Forms.Label();
            pRODUTO_ESTOQUE_MAXIMOLabel = new System.Windows.Forms.Label();
            pRODUTO_ESTOQUE_ATUALLabel = new System.Windows.Forms.Label();
            pRODUTO_PRECO_COMPRALabel = new System.Windows.Forms.Label();
            pRODUTO_PRECO_CUSTOLabel = new System.Windows.Forms.Label();
            pRODUTO_PRECO_VENDALabel = new System.Windows.Forms.Label();
            pRODUTO_DATA_CADASTROLabel = new System.Windows.Forms.Label();
            mARCA_DESCRICAOLabel = new System.Windows.Forms.Label();
            gRUPO_DESCRICAOLabel = new System.Windows.Forms.Label();
            sECAO_DESCRICAOLabel = new System.Windows.Forms.Label();
            fORNECEDOR_JURIDICO_FANTASIALabel = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panelCodigo.SuspendLayout();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFisico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJuridico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCadastro
            // 
            this.labelCadastro.Size = new System.Drawing.Size(212, 72);
            this.labelCadastro.Text = "Produto";
            // 
            // panelCodigo
            // 
            this.panelCodigo.Controls.Add(this.pRODUTO_CODIGOLabel1);
            this.panelCodigo.Controls.Add(pRODUTO_CODIGOLabel);
            this.panelCodigo.Controls.Add(this.pRODUTO_DATA_CADASTROLabel1);
            this.panelCodigo.Controls.Add(pRODUTO_DATA_CADASTROLabel);
            this.panelCodigo.Size = new System.Drawing.Size(453, 72);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.groupBox7);
            this.panelCentro.Controls.Add(this.panel1);
            this.panelCentro.Controls.Add(this.groupBox6);
            this.panelCentro.Controls.Add(this.groupBox5);
            this.panelCentro.Controls.Add(this.groupBox4);
            this.panelCentro.Controls.Add(this.groupBox3);
            this.panelCentro.Controls.Add(this.groupBox2);
            this.panelCentro.Controls.Add(this.groupBox1);
            // 
            // pRODUTO_CODIGOLabel
            // 
            pRODUTO_CODIGOLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            pRODUTO_CODIGOLabel.AutoSize = true;
            pRODUTO_CODIGOLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            pRODUTO_CODIGOLabel.Location = new System.Drawing.Point(21, 6);
            pRODUTO_CODIGOLabel.Name = "pRODUTO_CODIGOLabel";
            pRODUTO_CODIGOLabel.Size = new System.Drawing.Size(72, 25);
            pRODUTO_CODIGOLabel.TabIndex = 0;
            pRODUTO_CODIGOLabel.Text = "Código";
            // 
            // pRODUTO_DESCRICAOLabel
            // 
            pRODUTO_DESCRICAOLabel.AutoSize = true;
            pRODUTO_DESCRICAOLabel.Location = new System.Drawing.Point(6, 40);
            pRODUTO_DESCRICAOLabel.Name = "pRODUTO_DESCRICAOLabel";
            pRODUTO_DESCRICAOLabel.Size = new System.Drawing.Size(88, 25);
            pRODUTO_DESCRICAOLabel.TabIndex = 2;
            pRODUTO_DESCRICAOLabel.Text = "Descrição";
            // 
            // pRODUTO_CARACTERISTICALabel
            // 
            pRODUTO_CARACTERISTICALabel.AutoSize = true;
            pRODUTO_CARACTERISTICALabel.Location = new System.Drawing.Point(6, 87);
            pRODUTO_CARACTERISTICALabel.Name = "pRODUTO_CARACTERISTICALabel";
            pRODUTO_CARACTERISTICALabel.Size = new System.Drawing.Size(116, 25);
            pRODUTO_CARACTERISTICALabel.TabIndex = 4;
            pRODUTO_CARACTERISTICALabel.Text = "Característica";
            // 
            // pRODUTO_UNIDADE_COMPRALabel
            // 
            pRODUTO_UNIDADE_COMPRALabel.AutoSize = true;
            pRODUTO_UNIDADE_COMPRALabel.Location = new System.Drawing.Point(19, 36);
            pRODUTO_UNIDADE_COMPRALabel.Name = "pRODUTO_UNIDADE_COMPRALabel";
            pRODUTO_UNIDADE_COMPRALabel.Size = new System.Drawing.Size(77, 25);
            pRODUTO_UNIDADE_COMPRALabel.TabIndex = 6;
            pRODUTO_UNIDADE_COMPRALabel.Text = "Compra";
            // 
            // pRODUTO_UNIDADE_VENDALabel
            // 
            pRODUTO_UNIDADE_VENDALabel.AutoSize = true;
            pRODUTO_UNIDADE_VENDALabel.Location = new System.Drawing.Point(19, 72);
            pRODUTO_UNIDADE_VENDALabel.Name = "pRODUTO_UNIDADE_VENDALabel";
            pRODUTO_UNIDADE_VENDALabel.Size = new System.Drawing.Size(63, 25);
            pRODUTO_UNIDADE_VENDALabel.TabIndex = 8;
            pRODUTO_UNIDADE_VENDALabel.Text = "Venda";
            // 
            // pRODUTO_PESOLabel
            // 
            pRODUTO_PESOLabel.AutoSize = true;
            pRODUTO_PESOLabel.Location = new System.Drawing.Point(11, 46);
            pRODUTO_PESOLabel.Name = "pRODUTO_PESOLabel";
            pRODUTO_PESOLabel.Size = new System.Drawing.Size(50, 25);
            pRODUTO_PESOLabel.TabIndex = 10;
            pRODUTO_PESOLabel.Text = "Peso";
            // 
            // pRODUTO_NUMEROLabel
            // 
            pRODUTO_NUMEROLabel.AutoSize = true;
            pRODUTO_NUMEROLabel.Location = new System.Drawing.Point(359, 46);
            pRODUTO_NUMEROLabel.Name = "pRODUTO_NUMEROLabel";
            pRODUTO_NUMEROLabel.Size = new System.Drawing.Size(78, 25);
            pRODUTO_NUMEROLabel.TabIndex = 12;
            pRODUTO_NUMEROLabel.Text = "Número";
            // 
            // pRODUTO_EANLabel
            // 
            pRODUTO_EANLabel.AutoSize = true;
            pRODUTO_EANLabel.Location = new System.Drawing.Point(11, 136);
            pRODUTO_EANLabel.Name = "pRODUTO_EANLabel";
            pRODUTO_EANLabel.Size = new System.Drawing.Size(151, 25);
            pRODUTO_EANLabel.TabIndex = 14;
            pRODUTO_EANLabel.Text = "Código de barras";
            // 
            // pRODUTO_NUMERO_SERIELabel
            // 
            pRODUTO_NUMERO_SERIELabel.AutoSize = true;
            pRODUTO_NUMERO_SERIELabel.Location = new System.Drawing.Point(175, 46);
            pRODUTO_NUMERO_SERIELabel.Name = "pRODUTO_NUMERO_SERIELabel";
            pRODUTO_NUMERO_SERIELabel.Size = new System.Drawing.Size(146, 25);
            pRODUTO_NUMERO_SERIELabel.TabIndex = 16;
            pRODUTO_NUMERO_SERIELabel.Text = "Número de série";
            // 
            // pRODUTO_CFOPLabel
            // 
            pRODUTO_CFOPLabel.AutoSize = true;
            pRODUTO_CFOPLabel.Location = new System.Drawing.Point(6, 29);
            pRODUTO_CFOPLabel.Name = "pRODUTO_CFOPLabel";
            pRODUTO_CFOPLabel.Size = new System.Drawing.Size(57, 25);
            pRODUTO_CFOPLabel.TabIndex = 18;
            pRODUTO_CFOPLabel.Text = "CFOP";
            // 
            // pRODUTO_CSOSNLabel
            // 
            pRODUTO_CSOSNLabel.AutoSize = true;
            pRODUTO_CSOSNLabel.Location = new System.Drawing.Point(6, 68);
            pRODUTO_CSOSNLabel.Name = "pRODUTO_CSOSNLabel";
            pRODUTO_CSOSNLabel.Size = new System.Drawing.Size(69, 25);
            pRODUTO_CSOSNLabel.TabIndex = 20;
            pRODUTO_CSOSNLabel.Text = "CSOSN";
            // 
            // pRODUTO_NCMLabel
            // 
            pRODUTO_NCMLabel.AutoSize = true;
            pRODUTO_NCMLabel.Location = new System.Drawing.Point(6, 107);
            pRODUTO_NCMLabel.Name = "pRODUTO_NCMLabel";
            pRODUTO_NCMLabel.Size = new System.Drawing.Size(53, 25);
            pRODUTO_NCMLabel.TabIndex = 22;
            pRODUTO_NCMLabel.Text = "NCM";
            // 
            // pRODUTO_SITUACAO_TRIBUTARIALabel
            // 
            pRODUTO_SITUACAO_TRIBUTARIALabel.AutoSize = true;
            pRODUTO_SITUACAO_TRIBUTARIALabel.Location = new System.Drawing.Point(6, 146);
            pRODUTO_SITUACAO_TRIBUTARIALabel.Name = "pRODUTO_SITUACAO_TRIBUTARIALabel";
            pRODUTO_SITUACAO_TRIBUTARIALabel.Size = new System.Drawing.Size(154, 25);
            pRODUTO_SITUACAO_TRIBUTARIALabel.TabIndex = 24;
            pRODUTO_SITUACAO_TRIBUTARIALabel.Text = "Situação tributária";
            // 
            // pRODUTO_ORIGEM_MERCADORIALabel
            // 
            pRODUTO_ORIGEM_MERCADORIALabel.AutoSize = true;
            pRODUTO_ORIGEM_MERCADORIALabel.Location = new System.Drawing.Point(6, 185);
            pRODUTO_ORIGEM_MERCADORIALabel.Name = "pRODUTO_ORIGEM_MERCADORIALabel";
            pRODUTO_ORIGEM_MERCADORIALabel.Size = new System.Drawing.Size(193, 25);
            pRODUTO_ORIGEM_MERCADORIALabel.TabIndex = 26;
            pRODUTO_ORIGEM_MERCADORIALabel.Text = "Origem da mercadoria";
            // 
            // pRODUTO_ESTOQUE_MINIMOLabel
            // 
            pRODUTO_ESTOQUE_MINIMOLabel.AutoSize = true;
            pRODUTO_ESTOQUE_MINIMOLabel.Location = new System.Drawing.Point(6, 29);
            pRODUTO_ESTOQUE_MINIMOLabel.Name = "pRODUTO_ESTOQUE_MINIMOLabel";
            pRODUTO_ESTOQUE_MINIMOLabel.Size = new System.Drawing.Size(73, 25);
            pRODUTO_ESTOQUE_MINIMOLabel.TabIndex = 28;
            pRODUTO_ESTOQUE_MINIMOLabel.Text = "Mínimo";
            // 
            // pRODUTO_ESTOQUE_MAXIMOLabel
            // 
            pRODUTO_ESTOQUE_MAXIMOLabel.AutoSize = true;
            pRODUTO_ESTOQUE_MAXIMOLabel.Location = new System.Drawing.Point(6, 68);
            pRODUTO_ESTOQUE_MAXIMOLabel.Name = "pRODUTO_ESTOQUE_MAXIMOLabel";
            pRODUTO_ESTOQUE_MAXIMOLabel.Size = new System.Drawing.Size(76, 25);
            pRODUTO_ESTOQUE_MAXIMOLabel.TabIndex = 30;
            pRODUTO_ESTOQUE_MAXIMOLabel.Text = "Máximo";
            // 
            // pRODUTO_ESTOQUE_ATUALLabel
            // 
            pRODUTO_ESTOQUE_ATUALLabel.AutoSize = true;
            pRODUTO_ESTOQUE_ATUALLabel.Location = new System.Drawing.Point(6, 111);
            pRODUTO_ESTOQUE_ATUALLabel.Name = "pRODUTO_ESTOQUE_ATUALLabel";
            pRODUTO_ESTOQUE_ATUALLabel.Size = new System.Drawing.Size(53, 25);
            pRODUTO_ESTOQUE_ATUALLabel.TabIndex = 32;
            pRODUTO_ESTOQUE_ATUALLabel.Text = "Atual";
            // 
            // pRODUTO_PRECO_COMPRALabel
            // 
            pRODUTO_PRECO_COMPRALabel.AutoSize = true;
            pRODUTO_PRECO_COMPRALabel.Location = new System.Drawing.Point(6, 30);
            pRODUTO_PRECO_COMPRALabel.Name = "pRODUTO_PRECO_COMPRALabel";
            pRODUTO_PRECO_COMPRALabel.Size = new System.Drawing.Size(77, 25);
            pRODUTO_PRECO_COMPRALabel.TabIndex = 34;
            pRODUTO_PRECO_COMPRALabel.Text = "Compra";
            // 
            // pRODUTO_PRECO_CUSTOLabel
            // 
            pRODUTO_PRECO_CUSTOLabel.AutoSize = true;
            pRODUTO_PRECO_CUSTOLabel.Location = new System.Drawing.Point(6, 69);
            pRODUTO_PRECO_CUSTOLabel.Name = "pRODUTO_PRECO_CUSTOLabel";
            pRODUTO_PRECO_CUSTOLabel.Size = new System.Drawing.Size(58, 25);
            pRODUTO_PRECO_CUSTOLabel.TabIndex = 36;
            pRODUTO_PRECO_CUSTOLabel.Text = "Custo";
            // 
            // pRODUTO_PRECO_VENDALabel
            // 
            pRODUTO_PRECO_VENDALabel.AutoSize = true;
            pRODUTO_PRECO_VENDALabel.Location = new System.Drawing.Point(6, 108);
            pRODUTO_PRECO_VENDALabel.Name = "pRODUTO_PRECO_VENDALabel";
            pRODUTO_PRECO_VENDALabel.Size = new System.Drawing.Size(63, 25);
            pRODUTO_PRECO_VENDALabel.TabIndex = 38;
            pRODUTO_PRECO_VENDALabel.Text = "Venda";
            // 
            // pRODUTO_DATA_CADASTROLabel
            // 
            pRODUTO_DATA_CADASTROLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            pRODUTO_DATA_CADASTROLabel.AutoSize = true;
            pRODUTO_DATA_CADASTROLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            pRODUTO_DATA_CADASTROLabel.Location = new System.Drawing.Point(21, 41);
            pRODUTO_DATA_CADASTROLabel.Name = "pRODUTO_DATA_CADASTROLabel";
            pRODUTO_DATA_CADASTROLabel.Size = new System.Drawing.Size(49, 25);
            pRODUTO_DATA_CADASTROLabel.TabIndex = 40;
            pRODUTO_DATA_CADASTROLabel.Text = "Data";
            // 
            // mARCA_DESCRICAOLabel
            // 
            mARCA_DESCRICAOLabel.AutoSize = true;
            mARCA_DESCRICAOLabel.Location = new System.Drawing.Point(15, 44);
            mARCA_DESCRICAOLabel.Name = "mARCA_DESCRICAOLabel";
            mARCA_DESCRICAOLabel.Size = new System.Drawing.Size(60, 25);
            mARCA_DESCRICAOLabel.TabIndex = 42;
            mARCA_DESCRICAOLabel.Text = "Marca";
            // 
            // gRUPO_DESCRICAOLabel
            // 
            gRUPO_DESCRICAOLabel.AutoSize = true;
            gRUPO_DESCRICAOLabel.Location = new System.Drawing.Point(15, 152);
            gRUPO_DESCRICAOLabel.Name = "gRUPO_DESCRICAOLabel";
            gRUPO_DESCRICAOLabel.Size = new System.Drawing.Size(63, 25);
            gRUPO_DESCRICAOLabel.TabIndex = 44;
            gRUPO_DESCRICAOLabel.Text = "Grupo";
            // 
            // sECAO_DESCRICAOLabel
            // 
            sECAO_DESCRICAOLabel.AutoSize = true;
            sECAO_DESCRICAOLabel.Location = new System.Drawing.Point(15, 95);
            sECAO_DESCRICAOLabel.Name = "sECAO_DESCRICAOLabel";
            sECAO_DESCRICAOLabel.Size = new System.Drawing.Size(59, 25);
            sECAO_DESCRICAOLabel.TabIndex = 46;
            sECAO_DESCRICAOLabel.Text = "Seção";
            // 
            // fORNECEDOR_JURIDICO_FANTASIALabel
            // 
            fORNECEDOR_JURIDICO_FANTASIALabel.AutoSize = true;
            fORNECEDOR_JURIDICO_FANTASIALabel.Location = new System.Drawing.Point(15, 209);
            fORNECEDOR_JURIDICO_FANTASIALabel.Name = "fORNECEDOR_JURIDICO_FANTASIALabel";
            fORNECEDOR_JURIDICO_FANTASIALabel.Size = new System.Drawing.Size(104, 25);
            fORNECEDOR_JURIDICO_FANTASIALabel.TabIndex = 50;
            fORNECEDOR_JURIDICO_FANTASIALabel.Text = "Fornecedor";
            // 
            // pRODUTO_CODIGOLabel1
            // 
            this.pRODUTO_CODIGOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_CODIGO", true));
            this.pRODUTO_CODIGOLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pRODUTO_CODIGOLabel1.Location = new System.Drawing.Point(99, 6);
            this.pRODUTO_CODIGOLabel1.Name = "pRODUTO_CODIGOLabel1";
            this.pRODUTO_CODIGOLabel1.Size = new System.Drawing.Size(100, 23);
            this.pRODUTO_CODIGOLabel1.TabIndex = 1;
            this.pRODUTO_CODIGOLabel1.Text = "código";
            // 
            // bsProduto
            // 
            this.bsProduto.DataMember = "PRODUTO";
            this.bsProduto.DataSource = this.dsFROGIOS;
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUTO_DESCRICAOTextBox
            // 
            this.pRODUTO_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_DESCRICAO", true));
            this.pRODUTO_DESCRICAOTextBox.Location = new System.Drawing.Point(150, 37);
            this.pRODUTO_DESCRICAOTextBox.MaxLength = 60;
            this.pRODUTO_DESCRICAOTextBox.Name = "pRODUTO_DESCRICAOTextBox";
            this.pRODUTO_DESCRICAOTextBox.Size = new System.Drawing.Size(631, 33);
            this.pRODUTO_DESCRICAOTextBox.TabIndex = 0;
            // 
            // pRODUTO_CARACTERISTICATextBox
            // 
            this.pRODUTO_CARACTERISTICATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_CARACTERISTICA", true));
            this.pRODUTO_CARACTERISTICATextBox.Location = new System.Drawing.Point(150, 84);
            this.pRODUTO_CARACTERISTICATextBox.MaxLength = 60;
            this.pRODUTO_CARACTERISTICATextBox.Name = "pRODUTO_CARACTERISTICATextBox";
            this.pRODUTO_CARACTERISTICATextBox.Size = new System.Drawing.Size(631, 33);
            this.pRODUTO_CARACTERISTICATextBox.TabIndex = 1;
            // 
            // pRODUTO_UNIDADE_COMPRATextBox
            // 
            this.pRODUTO_UNIDADE_COMPRATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_UNIDADE_COMPRA", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.pRODUTO_UNIDADE_COMPRATextBox.Location = new System.Drawing.Point(102, 32);
            this.pRODUTO_UNIDADE_COMPRATextBox.MaxLength = 3;
            this.pRODUTO_UNIDADE_COMPRATextBox.Name = "pRODUTO_UNIDADE_COMPRATextBox";
            this.pRODUTO_UNIDADE_COMPRATextBox.Size = new System.Drawing.Size(100, 33);
            this.pRODUTO_UNIDADE_COMPRATextBox.TabIndex = 2;
            // 
            // pRODUTO_UNIDADE_VENDATextBox
            // 
            this.pRODUTO_UNIDADE_VENDATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_UNIDADE_VENDA", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.pRODUTO_UNIDADE_VENDATextBox.Location = new System.Drawing.Point(102, 72);
            this.pRODUTO_UNIDADE_VENDATextBox.MaxLength = 3;
            this.pRODUTO_UNIDADE_VENDATextBox.Name = "pRODUTO_UNIDADE_VENDATextBox";
            this.pRODUTO_UNIDADE_VENDATextBox.Size = new System.Drawing.Size(100, 33);
            this.pRODUTO_UNIDADE_VENDATextBox.TabIndex = 3;
            // 
            // pRODUTO_PESOTextBox
            // 
            this.pRODUTO_PESOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_PESO", true));
            this.pRODUTO_PESOTextBox.Location = new System.Drawing.Point(16, 86);
            this.pRODUTO_PESOTextBox.MaxLength = 18;
            this.pRODUTO_PESOTextBox.Name = "pRODUTO_PESOTextBox";
            this.pRODUTO_PESOTextBox.Size = new System.Drawing.Size(146, 33);
            this.pRODUTO_PESOTextBox.TabIndex = 14;
            // 
            // pRODUTO_NUMEROTextBox
            // 
            this.pRODUTO_NUMEROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_NUMERO", true));
            this.pRODUTO_NUMEROTextBox.Location = new System.Drawing.Point(364, 86);
            this.pRODUTO_NUMEROTextBox.MaxLength = 60;
            this.pRODUTO_NUMEROTextBox.Name = "pRODUTO_NUMEROTextBox";
            this.pRODUTO_NUMEROTextBox.Size = new System.Drawing.Size(176, 33);
            this.pRODUTO_NUMEROTextBox.TabIndex = 16;
            // 
            // pRODUTO_EANTextBox
            // 
            this.pRODUTO_EANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_EAN", true));
            this.pRODUTO_EANTextBox.Location = new System.Drawing.Point(16, 167);
            this.pRODUTO_EANTextBox.MaxLength = 120;
            this.pRODUTO_EANTextBox.Name = "pRODUTO_EANTextBox";
            this.pRODUTO_EANTextBox.Size = new System.Drawing.Size(524, 33);
            this.pRODUTO_EANTextBox.TabIndex = 17;
            // 
            // pRODUTO_NUMERO_SERIETextBox
            // 
            this.pRODUTO_NUMERO_SERIETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_NUMERO_SERIE", true));
            this.pRODUTO_NUMERO_SERIETextBox.Location = new System.Drawing.Point(180, 86);
            this.pRODUTO_NUMERO_SERIETextBox.MaxLength = 60;
            this.pRODUTO_NUMERO_SERIETextBox.Name = "pRODUTO_NUMERO_SERIETextBox";
            this.pRODUTO_NUMERO_SERIETextBox.Size = new System.Drawing.Size(162, 33);
            this.pRODUTO_NUMERO_SERIETextBox.TabIndex = 15;
            // 
            // pRODUTO_CFOPTextBox
            // 
            this.pRODUTO_CFOPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_CFOP", true));
            this.pRODUTO_CFOPTextBox.Location = new System.Drawing.Point(213, 26);
            this.pRODUTO_CFOPTextBox.MaxLength = 60;
            this.pRODUTO_CFOPTextBox.Name = "pRODUTO_CFOPTextBox";
            this.pRODUTO_CFOPTextBox.Size = new System.Drawing.Size(294, 33);
            this.pRODUTO_CFOPTextBox.TabIndex = 18;
            // 
            // pRODUTO_CSOSNTextBox
            // 
            this.pRODUTO_CSOSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_CSOSN", true));
            this.pRODUTO_CSOSNTextBox.Location = new System.Drawing.Point(213, 65);
            this.pRODUTO_CSOSNTextBox.MaxLength = 60;
            this.pRODUTO_CSOSNTextBox.Name = "pRODUTO_CSOSNTextBox";
            this.pRODUTO_CSOSNTextBox.Size = new System.Drawing.Size(294, 33);
            this.pRODUTO_CSOSNTextBox.TabIndex = 19;
            // 
            // pRODUTO_NCMTextBox
            // 
            this.pRODUTO_NCMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_NCM", true));
            this.pRODUTO_NCMTextBox.Location = new System.Drawing.Point(213, 104);
            this.pRODUTO_NCMTextBox.MaxLength = 60;
            this.pRODUTO_NCMTextBox.Name = "pRODUTO_NCMTextBox";
            this.pRODUTO_NCMTextBox.Size = new System.Drawing.Size(294, 33);
            this.pRODUTO_NCMTextBox.TabIndex = 20;
            // 
            // pRODUTO_SITUACAO_TRIBUTARIATextBox
            // 
            this.pRODUTO_SITUACAO_TRIBUTARIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_SITUACAO_TRIBUTARIA", true));
            this.pRODUTO_SITUACAO_TRIBUTARIATextBox.Location = new System.Drawing.Point(213, 143);
            this.pRODUTO_SITUACAO_TRIBUTARIATextBox.MaxLength = 60;
            this.pRODUTO_SITUACAO_TRIBUTARIATextBox.Name = "pRODUTO_SITUACAO_TRIBUTARIATextBox";
            this.pRODUTO_SITUACAO_TRIBUTARIATextBox.Size = new System.Drawing.Size(294, 33);
            this.pRODUTO_SITUACAO_TRIBUTARIATextBox.TabIndex = 21;
            // 
            // pRODUTO_ORIGEM_MERCADORIATextBox
            // 
            this.pRODUTO_ORIGEM_MERCADORIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_ORIGEM_MERCADORIA", true));
            this.pRODUTO_ORIGEM_MERCADORIATextBox.Location = new System.Drawing.Point(213, 182);
            this.pRODUTO_ORIGEM_MERCADORIATextBox.MaxLength = 60;
            this.pRODUTO_ORIGEM_MERCADORIATextBox.Name = "pRODUTO_ORIGEM_MERCADORIATextBox";
            this.pRODUTO_ORIGEM_MERCADORIATextBox.Size = new System.Drawing.Size(294, 33);
            this.pRODUTO_ORIGEM_MERCADORIATextBox.TabIndex = 22;
            // 
            // pRODUTO_ESTOQUE_MINIMOTextBox
            // 
            this.pRODUTO_ESTOQUE_MINIMOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_ESTOQUE_MINIMO", true));
            this.pRODUTO_ESTOQUE_MINIMOTextBox.Location = new System.Drawing.Point(112, 26);
            this.pRODUTO_ESTOQUE_MINIMOTextBox.MaxLength = 5;
            this.pRODUTO_ESTOQUE_MINIMOTextBox.Name = "pRODUTO_ESTOQUE_MINIMOTextBox";
            this.pRODUTO_ESTOQUE_MINIMOTextBox.Size = new System.Drawing.Size(100, 33);
            this.pRODUTO_ESTOQUE_MINIMOTextBox.TabIndex = 4;
            // 
            // pRODUTO_ESTOQUE_MAXIMOTextBox
            // 
            this.pRODUTO_ESTOQUE_MAXIMOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_ESTOQUE_MAXIMO", true));
            this.pRODUTO_ESTOQUE_MAXIMOTextBox.Location = new System.Drawing.Point(112, 68);
            this.pRODUTO_ESTOQUE_MAXIMOTextBox.MaxLength = 5;
            this.pRODUTO_ESTOQUE_MAXIMOTextBox.Name = "pRODUTO_ESTOQUE_MAXIMOTextBox";
            this.pRODUTO_ESTOQUE_MAXIMOTextBox.Size = new System.Drawing.Size(100, 33);
            this.pRODUTO_ESTOQUE_MAXIMOTextBox.TabIndex = 5;
            // 
            // pRODUTO_ESTOQUE_ATUALTextBox
            // 
            this.pRODUTO_ESTOQUE_ATUALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_ESTOQUE_ATUAL", true));
            this.pRODUTO_ESTOQUE_ATUALTextBox.Location = new System.Drawing.Point(112, 111);
            this.pRODUTO_ESTOQUE_ATUALTextBox.MaxLength = 5;
            this.pRODUTO_ESTOQUE_ATUALTextBox.Name = "pRODUTO_ESTOQUE_ATUALTextBox";
            this.pRODUTO_ESTOQUE_ATUALTextBox.Size = new System.Drawing.Size(100, 33);
            this.pRODUTO_ESTOQUE_ATUALTextBox.TabIndex = 6;
            // 
            // pRODUTO_DATA_CADASTROLabel1
            // 
            this.pRODUTO_DATA_CADASTROLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_DATA_CADASTRO", true));
            this.pRODUTO_DATA_CADASTROLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pRODUTO_DATA_CADASTROLabel1.Location = new System.Drawing.Point(99, 41);
            this.pRODUTO_DATA_CADASTROLabel1.Name = "pRODUTO_DATA_CADASTROLabel1";
            this.pRODUTO_DATA_CADASTROLabel1.Size = new System.Drawing.Size(100, 23);
            this.pRODUTO_DATA_CADASTROLabel1.TabIndex = 41;
            this.pRODUTO_DATA_CADASTROLabel1.Text = "data";
            // 
            // mARCA_DESCRICAOTextBox
            // 
            this.mARCA_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMarca, "MARCA_DESCRICAO", true));
            this.mARCA_DESCRICAOTextBox.Location = new System.Drawing.Point(134, 41);
            this.mARCA_DESCRICAOTextBox.MaxLength = 60;
            this.mARCA_DESCRICAOTextBox.Name = "mARCA_DESCRICAOTextBox";
            this.mARCA_DESCRICAOTextBox.ReadOnly = true;
            this.mARCA_DESCRICAOTextBox.Size = new System.Drawing.Size(452, 33);
            this.mARCA_DESCRICAOTextBox.TabIndex = 10;
            this.mARCA_DESCRICAOTextBox.DoubleClick += new System.EventHandler(this.mARCA_DESCRICAOTextBox_DoubleClick);
            // 
            // bsMarca
            // 
            this.bsMarca.DataMember = "MARCA";
            this.bsMarca.DataSource = this.dsFROGIOS;
            // 
            // gRUPO_DESCRICAOTextBox
            // 
            this.gRUPO_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGrupo, "GRUPO_DESCRICAO", true));
            this.gRUPO_DESCRICAOTextBox.Location = new System.Drawing.Point(134, 152);
            this.gRUPO_DESCRICAOTextBox.MaxLength = 60;
            this.gRUPO_DESCRICAOTextBox.Name = "gRUPO_DESCRICAOTextBox";
            this.gRUPO_DESCRICAOTextBox.ReadOnly = true;
            this.gRUPO_DESCRICAOTextBox.Size = new System.Drawing.Size(452, 33);
            this.gRUPO_DESCRICAOTextBox.TabIndex = 12;
            this.gRUPO_DESCRICAOTextBox.DoubleClick += new System.EventHandler(this.gRUPO_DESCRICAOTextBox_DoubleClick);
            // 
            // bsGrupo
            // 
            this.bsGrupo.DataMember = "GRUPO";
            this.bsGrupo.DataSource = this.dsFROGIOS;
            // 
            // sECAO_DESCRICAOTextBox
            // 
            this.sECAO_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSecao, "SECAO_DESCRICAO", true));
            this.sECAO_DESCRICAOTextBox.Location = new System.Drawing.Point(134, 95);
            this.sECAO_DESCRICAOTextBox.MaxLength = 60;
            this.sECAO_DESCRICAOTextBox.Name = "sECAO_DESCRICAOTextBox";
            this.sECAO_DESCRICAOTextBox.ReadOnly = true;
            this.sECAO_DESCRICAOTextBox.Size = new System.Drawing.Size(452, 33);
            this.sECAO_DESCRICAOTextBox.TabIndex = 11;
            this.sECAO_DESCRICAOTextBox.DoubleClick += new System.EventHandler(this.sECAO_DESCRICAOTextBox_DoubleClick);
            // 
            // bsSecao
            // 
            this.bsSecao.DataMember = "SECAO";
            this.bsSecao.DataSource = this.dsFROGIOS;
            // 
            // fORNECEDOR_FISICO_NOMETextBox
            // 
            this.fORNECEDOR_FISICO_NOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFisico, "FORNECEDOR_FISICO_NOME", true));
            this.fORNECEDOR_FISICO_NOMETextBox.Location = new System.Drawing.Point(134, 209);
            this.fORNECEDOR_FISICO_NOMETextBox.MaxLength = 60;
            this.fORNECEDOR_FISICO_NOMETextBox.Name = "fORNECEDOR_FISICO_NOMETextBox";
            this.fORNECEDOR_FISICO_NOMETextBox.ReadOnly = true;
            this.fORNECEDOR_FISICO_NOMETextBox.Size = new System.Drawing.Size(452, 33);
            this.fORNECEDOR_FISICO_NOMETextBox.TabIndex = 13;
            this.fORNECEDOR_FISICO_NOMETextBox.DoubleClick += new System.EventHandler(this.fORNECEDOR_FISICO_NOMETextBox_DoubleClick);
            // 
            // bsFisico
            // 
            this.bsFisico.DataMember = "FORNECEDOR_FISICO";
            this.bsFisico.DataSource = this.dsFROGIOS;
            // 
            // fORNECEDOR_JURIDICO_FANTASIATextBox
            // 
            this.fORNECEDOR_JURIDICO_FANTASIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsJuridico, "FORNECEDOR_JURIDICO_FANTASIA", true));
            this.fORNECEDOR_JURIDICO_FANTASIATextBox.Location = new System.Drawing.Point(134, 209);
            this.fORNECEDOR_JURIDICO_FANTASIATextBox.MaxLength = 60;
            this.fORNECEDOR_JURIDICO_FANTASIATextBox.Name = "fORNECEDOR_JURIDICO_FANTASIATextBox";
            this.fORNECEDOR_JURIDICO_FANTASIATextBox.ReadOnly = true;
            this.fORNECEDOR_JURIDICO_FANTASIATextBox.Size = new System.Drawing.Size(452, 33);
            this.fORNECEDOR_JURIDICO_FANTASIATextBox.TabIndex = 51;
            this.fORNECEDOR_JURIDICO_FANTASIATextBox.DoubleClick += new System.EventHandler(this.fORNECEDOR_JURIDICO_FANTASIATextBox_DoubleClick);
            // 
            // bsJuridico
            // 
            this.bsJuridico.DataMember = "FORNECEDOR_JURIDICO";
            this.bsJuridico.DataSource = this.dsFROGIOS;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(pRODUTO_DESCRICAOLabel);
            this.groupBox1.Controls.Add(this.pRODUTO_CARACTERISTICATextBox);
            this.groupBox1.Controls.Add(pRODUTO_CARACTERISTICALabel);
            this.groupBox1.Controls.Add(this.pRODUTO_DESCRICAOTextBox);
            this.groupBox1.Location = new System.Drawing.Point(26, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pRODUTO_UNIDADE_COMPRATextBox);
            this.groupBox2.Controls.Add(this.pRODUTO_UNIDADE_VENDATextBox);
            this.groupBox2.Controls.Add(pRODUTO_UNIDADE_VENDALabel);
            this.groupBox2.Controls.Add(pRODUTO_UNIDADE_COMPRALabel);
            this.groupBox2.Location = new System.Drawing.Point(26, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unidade";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pRODUTO_PESOTextBox);
            this.groupBox3.Controls.Add(this.pRODUTO_NUMERO_SERIETextBox);
            this.groupBox3.Controls.Add(pRODUTO_NUMERO_SERIELabel);
            this.groupBox3.Controls.Add(this.pRODUTO_EANTextBox);
            this.groupBox3.Controls.Add(pRODUTO_EANLabel);
            this.groupBox3.Controls.Add(this.pRODUTO_NUMEROTextBox);
            this.groupBox3.Controls.Add(pRODUTO_NUMEROLabel);
            this.groupBox3.Controls.Add(pRODUTO_PESOLabel);
            this.groupBox3.Location = new System.Drawing.Point(1525, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 223);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Balança";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(pRODUTO_CFOPLabel);
            this.groupBox4.Controls.Add(this.pRODUTO_ORIGEM_MERCADORIATextBox);
            this.groupBox4.Controls.Add(pRODUTO_ORIGEM_MERCADORIALabel);
            this.groupBox4.Controls.Add(this.pRODUTO_SITUACAO_TRIBUTARIATextBox);
            this.groupBox4.Controls.Add(pRODUTO_SITUACAO_TRIBUTARIALabel);
            this.groupBox4.Controls.Add(this.pRODUTO_NCMTextBox);
            this.groupBox4.Controls.Add(pRODUTO_NCMLabel);
            this.groupBox4.Controls.Add(this.pRODUTO_CSOSNTextBox);
            this.groupBox4.Controls.Add(pRODUTO_CSOSNLabel);
            this.groupBox4.Controls.Add(this.pRODUTO_CFOPTextBox);
            this.groupBox4.Location = new System.Drawing.Point(2138, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 237);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Registro";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(pRODUTO_ESTOQUE_MINIMOLabel);
            this.groupBox5.Controls.Add(this.pRODUTO_ESTOQUE_ATUALTextBox);
            this.groupBox5.Controls.Add(pRODUTO_ESTOQUE_ATUALLabel);
            this.groupBox5.Controls.Add(this.pRODUTO_ESTOQUE_MAXIMOTextBox);
            this.groupBox5.Controls.Add(pRODUTO_ESTOQUE_MAXIMOLabel);
            this.groupBox5.Controls.Add(this.pRODUTO_ESTOQUE_MINIMOTextBox);
            this.groupBox5.Location = new System.Drawing.Point(288, 162);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(229, 158);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Estoque";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textVenda);
            this.groupBox6.Controls.Add(this.textCusto);
            this.groupBox6.Controls.Add(this.textCompra);
            this.groupBox6.Controls.Add(pRODUTO_PRECO_COMPRALabel);
            this.groupBox6.Controls.Add(pRODUTO_PRECO_VENDALabel);
            this.groupBox6.Controls.Add(pRODUTO_PRECO_CUSTOLabel);
            this.groupBox6.Location = new System.Drawing.Point(556, 162);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(284, 151);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Preço";
            // 
            // textVenda
            // 
            this.textVenda.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsProduto, "PRODUTO_PRECO_VENDA", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textVenda.Location = new System.Drawing.Point(89, 108);
            this.textVenda.Name = "textVenda";
            this.textVenda.Size = new System.Drawing.Size(150, 33);
            this.textVenda.TabIndex = 41;
            this.textVenda.Text = "R$ 0,00";
            this.textVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textVenda.Valor = 0D;
            // 
            // textCusto
            // 
            this.textCusto.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsProduto, "PRODUTO_PRECO_CUSTO", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textCusto.Location = new System.Drawing.Point(89, 66);
            this.textCusto.Name = "textCusto";
            this.textCusto.Size = new System.Drawing.Size(150, 33);
            this.textCusto.TabIndex = 40;
            this.textCusto.Text = "R$ 0,00";
            this.textCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textCusto.Valor = 0D;
            // 
            // textCompra
            // 
            this.textCompra.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsProduto, "PRODUTO_PRECO_COMPRA", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textCompra.Location = new System.Drawing.Point(89, 25);
            this.textCompra.Name = "textCompra";
            this.textCompra.Size = new System.Drawing.Size(150, 33);
            this.textCompra.TabIndex = 39;
            this.textCompra.Text = "R$ 0,00";
            this.textCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textCompra.Valor = 0D;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2678, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 177);
            this.panel1.TabIndex = 58;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(mARCA_DESCRICAOLabel);
            this.groupBox7.Controls.Add(this.mARCA_DESCRICAOTextBox);
            this.groupBox7.Controls.Add(this.gRUPO_DESCRICAOTextBox);
            this.groupBox7.Controls.Add(gRUPO_DESCRICAOLabel);
            this.groupBox7.Controls.Add(this.sECAO_DESCRICAOTextBox);
            this.groupBox7.Controls.Add(sECAO_DESCRICAOLabel);
            this.groupBox7.Controls.Add(this.fORNECEDOR_FISICO_NOMETextBox);
            this.groupBox7.Controls.Add(this.fORNECEDOR_JURIDICO_FANTASIATextBox);
            this.groupBox7.Controls.Add(fORNECEDOR_JURIDICO_FANTASIALabel);
            this.groupBox7.Location = new System.Drawing.Point(866, 40);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(619, 263);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Organização";
            // 
            // taProduto
            // 
            this.taProduto.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AGENDAMENTOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = null;
            this.tableAdapterManager.CLIENTE_FISICOTableAdapter = null;
            this.tableAdapterManager.CLIENTE_JURIDICOTableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.COMPRATableAdapter = null;
            this.tableAdapterManager.EMPRESATableAdapter = null;
            this.tableAdapterManager.FORNECEDOR_FISICOTableAdapter = this.taFisico;
            this.tableAdapterManager.FORNECEDOR_JURIDICOTableAdapter = this.taJuridico;
            this.tableAdapterManager.FORNECEDORTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOTableAdapter = null;
            this.tableAdapterManager.GRUPOTableAdapter = this.taGrupo;
            this.tableAdapterManager.ITEM_COMPRATableAdapter = null;
            this.tableAdapterManager.MARCATableAdapter = this.taMarca;
            this.tableAdapterManager.ORCAMENTO_ITEMTableAdapter = null;
            this.tableAdapterManager.ORCAMENTO_SERVICOTableAdapter = null;
            this.tableAdapterManager.ORCAMENTOTableAdapter = null;
            this.tableAdapterManager.OS_ITEMTableAdapter = null;
            this.tableAdapterManager.OS_SERVICOTableAdapter = null;
            this.tableAdapterManager.OSTableAdapter = null;
            this.tableAdapterManager.PERMISSAOTableAdapter = null;
            this.tableAdapterManager.PRODUTOTableAdapter = this.taProduto;
            this.tableAdapterManager.SECAOTableAdapter = this.taSecao;
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
            // taGrupo
            // 
            this.taGrupo.ClearBeforeFill = true;
            // 
            // taMarca
            // 
            this.taMarca.ClearBeforeFill = true;
            // 
            // taSecao
            // 
            this.taSecao.ClearBeforeFill = true;
            // 
            // formCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCadastroProduto";
            this.Text = "Produtos";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFisico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJuridico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsProduto;
        private dsFROGIOSTableAdapters.PRODUTOTableAdapter taProduto;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label pRODUTO_CODIGOLabel1;
        private System.Windows.Forms.TextBox pRODUTO_DESCRICAOTextBox;
        private System.Windows.Forms.TextBox pRODUTO_CARACTERISTICATextBox;
        private System.Windows.Forms.TextBox pRODUTO_UNIDADE_COMPRATextBox;
        private System.Windows.Forms.TextBox pRODUTO_UNIDADE_VENDATextBox;
        private System.Windows.Forms.TextBox pRODUTO_PESOTextBox;
        private System.Windows.Forms.TextBox pRODUTO_NUMEROTextBox;
        private System.Windows.Forms.TextBox pRODUTO_EANTextBox;
        private System.Windows.Forms.TextBox pRODUTO_NUMERO_SERIETextBox;
        private System.Windows.Forms.TextBox pRODUTO_CFOPTextBox;
        private System.Windows.Forms.TextBox pRODUTO_CSOSNTextBox;
        private System.Windows.Forms.TextBox pRODUTO_NCMTextBox;
        private System.Windows.Forms.TextBox pRODUTO_SITUACAO_TRIBUTARIATextBox;
        private System.Windows.Forms.TextBox pRODUTO_ORIGEM_MERCADORIATextBox;
        private System.Windows.Forms.TextBox pRODUTO_ESTOQUE_MINIMOTextBox;
        private System.Windows.Forms.TextBox pRODUTO_ESTOQUE_MAXIMOTextBox;
        private System.Windows.Forms.TextBox pRODUTO_ESTOQUE_ATUALTextBox;
        private System.Windows.Forms.Label pRODUTO_DATA_CADASTROLabel1;
        private dsFROGIOSTableAdapters.MARCATableAdapter taMarca;
        private System.Windows.Forms.BindingSource bsMarca;
        private System.Windows.Forms.TextBox mARCA_DESCRICAOTextBox;
        private dsFROGIOSTableAdapters.GRUPOTableAdapter taGrupo;
        private System.Windows.Forms.BindingSource bsGrupo;
        private System.Windows.Forms.TextBox gRUPO_DESCRICAOTextBox;
        private dsFROGIOSTableAdapters.SECAOTableAdapter taSecao;
        private System.Windows.Forms.BindingSource bsSecao;
        private System.Windows.Forms.TextBox sECAO_DESCRICAOTextBox;
        private dsFROGIOSTableAdapters.FORNECEDOR_FISICOTableAdapter taFisico;
        private System.Windows.Forms.BindingSource bsFisico;
        private System.Windows.Forms.TextBox fORNECEDOR_FISICO_NOMETextBox;
        private dsFROGIOSTableAdapters.FORNECEDOR_JURIDICOTableAdapter taJuridico;
        private System.Windows.Forms.BindingSource bsJuridico;
        private System.Windows.Forms.TextBox fORNECEDOR_JURIDICO_FANTASIATextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private WindowsFormsApplication2.Monetario textVenda;
        private WindowsFormsApplication2.Monetario textCusto;
        private WindowsFormsApplication2.Monetario textCompra;


    }
}