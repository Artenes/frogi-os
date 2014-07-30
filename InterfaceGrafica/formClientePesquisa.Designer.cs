namespace FROGI_OS
{
    partial class formClientePesquisa
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
            System.Windows.Forms.Label cLIENTE_UFLabel;
            System.Windows.Forms.Label cLIENTE_TELEFONELabel;
            System.Windows.Forms.Label cLIENTE_CELULARLabel;
            System.Windows.Forms.Label cLIENTE_EMAILLabel;
            System.Windows.Forms.Label cLIENTE_ENDERECOLabel;
            System.Windows.Forms.Label cLIENTE_BAIRROLabel;
            System.Windows.Forms.Label cLIENTE_PERIMETROLabel;
            System.Windows.Forms.Label cLIENTE_CIDADELabel;
            System.Windows.Forms.Label cLIENTE_CEPLabel;
            System.Windows.Forms.Label cLIENTE_FISICO_CPFLabel;
            System.Windows.Forms.Label cLIENTE_FISICO_RGLabel;
            System.Windows.Forms.Label cLIENTE_FISICO_NASCIMENTOLabel;
            System.Windows.Forms.Label cLIENTE_FISICO_SEXOLabel;
            System.Windows.Forms.Label cLIENTE_FISICO_ESTADO_CIVILLabel;
            System.Windows.Forms.Label cLIENTE_FISICO_PROFISSAOLabel;
            System.Windows.Forms.Label cLIENTE_FISICO_SALARIOLabel;
            System.Windows.Forms.Label cLIENTE_FISICO_LIMITELabel;
            System.Windows.Forms.Label cLIENTE_FISICO_LIMITE_ATUALLabel;
            System.Windows.Forms.Label cLIENTE_FISICO_MAELabel;
            System.Windows.Forms.Label cLIENTE_FISICO_PAILabel;
            System.Windows.Forms.Label cLIENTE_FISICO_OBSERVACAOLabel;
            System.Windows.Forms.Label cLIENTE_FISICO_NOMELabel;
            System.Windows.Forms.Label cLIENTE_JURIDICO_RAZAO_SOCIALLabel;
            System.Windows.Forms.Label cLIENTE_JURIDICO_CNPJLabel;
            System.Windows.Forms.Label cLIENTE_JURIDICO_IELabel;
            System.Windows.Forms.Label cLIENTE_JURIDICO_FANTASIALabel;
            System.Windows.Forms.Label cLIENTE_JURIDICO_ATIVIDADELabel;
            System.Windows.Forms.Label cLIENTE_JURIDICO_NOME_CONTATOLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTipoCliente = new System.Windows.Forms.ComboBox();
            this.bsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureEditar = new System.Windows.Forms.PictureBox();
            this.pictureExcluir = new System.Windows.Forms.PictureBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.pictureSalvar = new System.Windows.Forms.PictureBox();
            this.picturePesquisar = new System.Windows.Forms.PictureBox();
            this.pictureNovo = new System.Windows.Forms.PictureBox();
            this.labelDataCadastroLabel = new System.Windows.Forms.Label();
            this.labelCodigoLabel = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabClienteJuridico = new FROGI_OS.TablessControl();
            this.bsUF = new System.Windows.Forms.BindingSource(this.components);
            this.bsClienteFisico = new System.Windows.Forms.BindingSource(this.components);
            this.bsClienteJuridico = new System.Windows.Forms.BindingSource(this.components);
            this.bsClienteFisicoPesquisa = new System.Windows.Forms.BindingSource(this.components);
            this.bsClienteJuridicoPesquisa = new System.Windows.Forms.BindingSource(this.components);
            this.taCliente = new FROGI_OS.dsFROGIOSTableAdapters.CLIENTETableAdapter();
            this.taManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.taClienteFisico = new FROGI_OS.dsFROGIOSTableAdapters.CLIENTE_FISICOTableAdapter();
            this.taClienteJuridico = new FROGI_OS.dsFROGIOSTableAdapters.CLIENTE_JURIDICOTableAdapter();
            this.taClienteFisicoPesquisa = new FROGI_OS.dsFROGIOSTableAdapters.SP_CLIENTE_FISICO_PESQUISATableAdapter();
            this.taClienteJuridicoPesquisa = new FROGI_OS.dsFROGIOSTableAdapters.SP_CLIENTE_JURIDICO_PESQUISATableAdapter();
            this.taUF = new FROGI_OS.dsFROGIOSTableAdapters.UFTableAdapter();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.cLIENTE_CELULARMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cLIENTE_TELEFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cLIENTE_CEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.uF_DESCRICAOComboBox = new System.Windows.Forms.ComboBox();
            this.cLIENTE_EMAILTextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_ENDERECOTextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_BAIRROTextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_PERIMETROTextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_CIDADETextBox = new System.Windows.Forms.TextBox();
            this.tabCadastro = new FROGI_OS.TablessControl();
            this.tabFisica = new System.Windows.Forms.TabPage();
            this.panelFisico = new System.Windows.Forms.Panel();
            this.cLIENTE_FISICO_SALARIOMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cLIENTE_FISICO_CPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cLIENTE_FISICO_OBSERVACAORichTextBox = new System.Windows.Forms.RichTextBox();
            this.cLIENTE_FISICO_RGTextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_FISICO_NASCIMENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cLIENTE_FISICO_SEXOComboBox = new System.Windows.Forms.ComboBox();
            this.cLIENTE_FISICO_ESTADO_CIVILTextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_FISICO_PROFISSAOTextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_FISICO_LIMITETextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_FISICO_LIMITE_ATUALTextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_FISICO_MAETextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_FISICO_PAITextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_FISICO_NOMETextBox = new System.Windows.Forms.TextBox();
            this.tabJuridica = new System.Windows.Forms.TabPage();
            this.panelJuridica = new System.Windows.Forms.Panel();
            this.cLIENTE_JURIDICO_IEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cLIENTE_JURIDICO_CNPJMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cLIENTE_JURIDICO_RAZAO_SOCIALTextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_JURIDICO_FANTASIATextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_JURIDICO_ATIVIDADETextBox = new System.Windows.Forms.TextBox();
            this.cLIENTE_JURIDICO_NOME_CONTATOTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.tabGridPesquisa = new FROGI_OS.TablessControl();
            this.tabFisicoPesquisa = new System.Windows.Forms.TabPage();
            this.sP_CLIENTE_FISICO_PESQUISADataGridView = new System.Windows.Forms.DataGridView();
            this.codigoFisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabJuridicoPesquisa = new System.Windows.Forms.TabPage();
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView = new System.Windows.Forms.DataGridView();
            this.codigoJuridico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label40 = new System.Windows.Forms.Label();
            this.cbTipoCliente = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbCampoPesquisa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCampoPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.tabClienteFisico = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelCodigoData = new System.Windows.Forms.Panel();
            cLIENTE_UFLabel = new System.Windows.Forms.Label();
            cLIENTE_TELEFONELabel = new System.Windows.Forms.Label();
            cLIENTE_CELULARLabel = new System.Windows.Forms.Label();
            cLIENTE_EMAILLabel = new System.Windows.Forms.Label();
            cLIENTE_ENDERECOLabel = new System.Windows.Forms.Label();
            cLIENTE_BAIRROLabel = new System.Windows.Forms.Label();
            cLIENTE_PERIMETROLabel = new System.Windows.Forms.Label();
            cLIENTE_CIDADELabel = new System.Windows.Forms.Label();
            cLIENTE_CEPLabel = new System.Windows.Forms.Label();
            cLIENTE_FISICO_CPFLabel = new System.Windows.Forms.Label();
            cLIENTE_FISICO_RGLabel = new System.Windows.Forms.Label();
            cLIENTE_FISICO_NASCIMENTOLabel = new System.Windows.Forms.Label();
            cLIENTE_FISICO_SEXOLabel = new System.Windows.Forms.Label();
            cLIENTE_FISICO_ESTADO_CIVILLabel = new System.Windows.Forms.Label();
            cLIENTE_FISICO_PROFISSAOLabel = new System.Windows.Forms.Label();
            cLIENTE_FISICO_SALARIOLabel = new System.Windows.Forms.Label();
            cLIENTE_FISICO_LIMITELabel = new System.Windows.Forms.Label();
            cLIENTE_FISICO_LIMITE_ATUALLabel = new System.Windows.Forms.Label();
            cLIENTE_FISICO_MAELabel = new System.Windows.Forms.Label();
            cLIENTE_FISICO_PAILabel = new System.Windows.Forms.Label();
            cLIENTE_FISICO_OBSERVACAOLabel = new System.Windows.Forms.Label();
            cLIENTE_FISICO_NOMELabel = new System.Windows.Forms.Label();
            cLIENTE_JURIDICO_RAZAO_SOCIALLabel = new System.Windows.Forms.Label();
            cLIENTE_JURIDICO_CNPJLabel = new System.Windows.Forms.Label();
            cLIENTE_JURIDICO_IELabel = new System.Windows.Forms.Label();
            cLIENTE_JURIDICO_FANTASIALabel = new System.Windows.Forms.Label();
            cLIENTE_JURIDICO_ATIVIDADELabel = new System.Windows.Forms.Label();
            cLIENTE_JURIDICO_NOME_CONTATOLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovo)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabClienteJuridico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClienteFisico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClienteJuridico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClienteFisicoPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClienteJuridicoPesquisa)).BeginInit();
            this.tabCliente.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.tabFisica.SuspendLayout();
            this.panelFisico.SuspendLayout();
            this.tabJuridica.SuspendLayout();
            this.panelJuridica.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tabGridPesquisa.SuspendLayout();
            this.tabFisicoPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CLIENTE_FISICO_PESQUISADataGridView)).BeginInit();
            this.tabJuridicoPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CLIENTE_JURIDICO_PESQUISADataGridView)).BeginInit();
            this.panelCodigoData.SuspendLayout();
            this.SuspendLayout();
            // 
            // cLIENTE_UFLabel
            // 
            cLIENTE_UFLabel.AutoSize = true;
            cLIENTE_UFLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_UFLabel.Location = new System.Drawing.Point(496, 123);
            cLIENTE_UFLabel.Name = "cLIENTE_UFLabel";
            cLIENTE_UFLabel.Size = new System.Drawing.Size(33, 25);
            cLIENTE_UFLabel.TabIndex = 136;
            cLIENTE_UFLabel.Text = "UF";
            // 
            // cLIENTE_TELEFONELabel
            // 
            cLIENTE_TELEFONELabel.AutoSize = true;
            cLIENTE_TELEFONELabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_TELEFONELabel.Location = new System.Drawing.Point(-1, 225);
            cLIENTE_TELEFONELabel.Name = "cLIENTE_TELEFONELabel";
            cLIENTE_TELEFONELabel.Size = new System.Drawing.Size(82, 25);
            cLIENTE_TELEFONELabel.TabIndex = 120;
            cLIENTE_TELEFONELabel.Text = "Telefone";
            // 
            // cLIENTE_CELULARLabel
            // 
            cLIENTE_CELULARLabel.AutoSize = true;
            cLIENTE_CELULARLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_CELULARLabel.Location = new System.Drawing.Point(346, 225);
            cLIENTE_CELULARLabel.Name = "cLIENTE_CELULARLabel";
            cLIENTE_CELULARLabel.Size = new System.Drawing.Size(67, 25);
            cLIENTE_CELULARLabel.TabIndex = 122;
            cLIENTE_CELULARLabel.Text = "Celular";
            // 
            // cLIENTE_EMAILLabel
            // 
            cLIENTE_EMAILLabel.AutoSize = true;
            cLIENTE_EMAILLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_EMAILLabel.Location = new System.Drawing.Point(-1, 275);
            cLIENTE_EMAILLabel.Name = "cLIENTE_EMAILLabel";
            cLIENTE_EMAILLabel.Size = new System.Drawing.Size(63, 25);
            cLIENTE_EMAILLabel.TabIndex = 124;
            cLIENTE_EMAILLabel.Text = "E-mail";
            // 
            // cLIENTE_ENDERECOLabel
            // 
            cLIENTE_ENDERECOLabel.AutoSize = true;
            cLIENTE_ENDERECOLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_ENDERECOLabel.Location = new System.Drawing.Point(-1, 15);
            cLIENTE_ENDERECOLabel.Name = "cLIENTE_ENDERECOLabel";
            cLIENTE_ENDERECOLabel.Size = new System.Drawing.Size(88, 25);
            cLIENTE_ENDERECOLabel.TabIndex = 126;
            cLIENTE_ENDERECOLabel.Text = "Endereço";
            // 
            // cLIENTE_BAIRROLabel
            // 
            cLIENTE_BAIRROLabel.AutoSize = true;
            cLIENTE_BAIRROLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_BAIRROLabel.Location = new System.Drawing.Point(-1, 123);
            cLIENTE_BAIRROLabel.Name = "cLIENTE_BAIRROLabel";
            cLIENTE_BAIRROLabel.Size = new System.Drawing.Size(58, 25);
            cLIENTE_BAIRROLabel.TabIndex = 128;
            cLIENTE_BAIRROLabel.Text = "Bairro";
            // 
            // cLIENTE_PERIMETROLabel
            // 
            cLIENTE_PERIMETROLabel.AutoSize = true;
            cLIENTE_PERIMETROLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_PERIMETROLabel.Location = new System.Drawing.Point(-1, 68);
            cLIENTE_PERIMETROLabel.Name = "cLIENTE_PERIMETROLabel";
            cLIENTE_PERIMETROLabel.Size = new System.Drawing.Size(91, 25);
            cLIENTE_PERIMETROLabel.TabIndex = 130;
            cLIENTE_PERIMETROLabel.Text = "Perímetro";
            // 
            // cLIENTE_CIDADELabel
            // 
            cLIENTE_CIDADELabel.AutoSize = true;
            cLIENTE_CIDADELabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_CIDADELabel.Location = new System.Drawing.Point(-1, 179);
            cLIENTE_CIDADELabel.Name = "cLIENTE_CIDADELabel";
            cLIENTE_CIDADELabel.Size = new System.Drawing.Size(69, 25);
            cLIENTE_CIDADELabel.TabIndex = 132;
            cLIENTE_CIDADELabel.Text = "Cidade";
            // 
            // cLIENTE_CEPLabel
            // 
            cLIENTE_CEPLabel.AutoSize = true;
            cLIENTE_CEPLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_CEPLabel.Location = new System.Drawing.Point(421, 179);
            cLIENTE_CEPLabel.Name = "cLIENTE_CEPLabel";
            cLIENTE_CEPLabel.Size = new System.Drawing.Size(44, 25);
            cLIENTE_CEPLabel.TabIndex = 134;
            cLIENTE_CEPLabel.Text = "CEP";
            // 
            // cLIENTE_FISICO_CPFLabel
            // 
            cLIENTE_FISICO_CPFLabel.AutoSize = true;
            cLIENTE_FISICO_CPFLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_FISICO_CPFLabel.Location = new System.Drawing.Point(7, 104);
            cLIENTE_FISICO_CPFLabel.Name = "cLIENTE_FISICO_CPFLabel";
            cLIENTE_FISICO_CPFLabel.Size = new System.Drawing.Size(43, 25);
            cLIENTE_FISICO_CPFLabel.TabIndex = 27;
            cLIENTE_FISICO_CPFLabel.Text = "CPF";
            // 
            // cLIENTE_FISICO_RGLabel
            // 
            cLIENTE_FISICO_RGLabel.AutoSize = true;
            cLIENTE_FISICO_RGLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_FISICO_RGLabel.Location = new System.Drawing.Point(308, 104);
            cLIENTE_FISICO_RGLabel.Name = "cLIENTE_FISICO_RGLabel";
            cLIENTE_FISICO_RGLabel.Size = new System.Drawing.Size(36, 25);
            cLIENTE_FISICO_RGLabel.TabIndex = 29;
            cLIENTE_FISICO_RGLabel.Text = "RG";
            // 
            // cLIENTE_FISICO_NASCIMENTOLabel
            // 
            cLIENTE_FISICO_NASCIMENTOLabel.AutoSize = true;
            cLIENTE_FISICO_NASCIMENTOLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_FISICO_NASCIMENTOLabel.Location = new System.Drawing.Point(7, 59);
            cLIENTE_FISICO_NASCIMENTOLabel.Name = "cLIENTE_FISICO_NASCIMENTOLabel";
            cLIENTE_FISICO_NASCIMENTOLabel.Size = new System.Drawing.Size(171, 25);
            cLIENTE_FISICO_NASCIMENTOLabel.TabIndex = 31;
            cLIENTE_FISICO_NASCIMENTOLabel.Text = "Data de nascimento";
            // 
            // cLIENTE_FISICO_SEXOLabel
            // 
            cLIENTE_FISICO_SEXOLabel.AutoSize = true;
            cLIENTE_FISICO_SEXOLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_FISICO_SEXOLabel.Location = new System.Drawing.Point(881, 59);
            cLIENTE_FISICO_SEXOLabel.Name = "cLIENTE_FISICO_SEXOLabel";
            cLIENTE_FISICO_SEXOLabel.Size = new System.Drawing.Size(50, 25);
            cLIENTE_FISICO_SEXOLabel.TabIndex = 33;
            cLIENTE_FISICO_SEXOLabel.Text = "Sexo";
            // 
            // cLIENTE_FISICO_ESTADO_CIVILLabel
            // 
            cLIENTE_FISICO_ESTADO_CIVILLabel.AutoSize = true;
            cLIENTE_FISICO_ESTADO_CIVILLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_FISICO_ESTADO_CIVILLabel.Location = new System.Drawing.Point(477, 56);
            cLIENTE_FISICO_ESTADO_CIVILLabel.Name = "cLIENTE_FISICO_ESTADO_CIVILLabel";
            cLIENTE_FISICO_ESTADO_CIVILLabel.Size = new System.Drawing.Size(100, 25);
            cLIENTE_FISICO_ESTADO_CIVILLabel.TabIndex = 35;
            cLIENTE_FISICO_ESTADO_CIVILLabel.Text = "Estado civil";
            // 
            // cLIENTE_FISICO_PROFISSAOLabel
            // 
            cLIENTE_FISICO_PROFISSAOLabel.AutoSize = true;
            cLIENTE_FISICO_PROFISSAOLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_FISICO_PROFISSAOLabel.Location = new System.Drawing.Point(581, 107);
            cLIENTE_FISICO_PROFISSAOLabel.Name = "cLIENTE_FISICO_PROFISSAOLabel";
            cLIENTE_FISICO_PROFISSAOLabel.Size = new System.Drawing.Size(82, 25);
            cLIENTE_FISICO_PROFISSAOLabel.TabIndex = 37;
            cLIENTE_FISICO_PROFISSAOLabel.Text = "Profissão";
            // 
            // cLIENTE_FISICO_SALARIOLabel
            // 
            cLIENTE_FISICO_SALARIOLabel.AutoSize = true;
            cLIENTE_FISICO_SALARIOLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_FISICO_SALARIOLabel.Location = new System.Drawing.Point(7, 154);
            cLIENTE_FISICO_SALARIOLabel.Name = "cLIENTE_FISICO_SALARIOLabel";
            cLIENTE_FISICO_SALARIOLabel.Size = new System.Drawing.Size(64, 25);
            cLIENTE_FISICO_SALARIOLabel.TabIndex = 39;
            cLIENTE_FISICO_SALARIOLabel.Text = "Salário";
            // 
            // cLIENTE_FISICO_LIMITELabel
            // 
            cLIENTE_FISICO_LIMITELabel.AutoSize = true;
            cLIENTE_FISICO_LIMITELabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_FISICO_LIMITELabel.Location = new System.Drawing.Point(308, 154);
            cLIENTE_FISICO_LIMITELabel.Name = "cLIENTE_FISICO_LIMITELabel";
            cLIENTE_FISICO_LIMITELabel.Size = new System.Drawing.Size(61, 25);
            cLIENTE_FISICO_LIMITELabel.TabIndex = 41;
            cLIENTE_FISICO_LIMITELabel.Text = "Limite";
            // 
            // cLIENTE_FISICO_LIMITE_ATUALLabel
            // 
            cLIENTE_FISICO_LIMITE_ATUALLabel.AutoSize = true;
            cLIENTE_FISICO_LIMITE_ATUALLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_FISICO_LIMITE_ATUALLabel.Location = new System.Drawing.Point(581, 157);
            cLIENTE_FISICO_LIMITE_ATUALLabel.Name = "cLIENTE_FISICO_LIMITE_ATUALLabel";
            cLIENTE_FISICO_LIMITE_ATUALLabel.Size = new System.Drawing.Size(104, 25);
            cLIENTE_FISICO_LIMITE_ATUALLabel.TabIndex = 43;
            cLIENTE_FISICO_LIMITE_ATUALLabel.Text = "Limite atual";
            // 
            // cLIENTE_FISICO_MAELabel
            // 
            cLIENTE_FISICO_MAELabel.AutoSize = true;
            cLIENTE_FISICO_MAELabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_FISICO_MAELabel.Location = new System.Drawing.Point(7, 206);
            cLIENTE_FISICO_MAELabel.Name = "cLIENTE_FISICO_MAELabel";
            cLIENTE_FISICO_MAELabel.Size = new System.Drawing.Size(127, 25);
            cLIENTE_FISICO_MAELabel.TabIndex = 45;
            cLIENTE_FISICO_MAELabel.Text = "Nome da mãe";
            // 
            // cLIENTE_FISICO_PAILabel
            // 
            cLIENTE_FISICO_PAILabel.AutoSize = true;
            cLIENTE_FISICO_PAILabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_FISICO_PAILabel.Location = new System.Drawing.Point(7, 248);
            cLIENTE_FISICO_PAILabel.Name = "cLIENTE_FISICO_PAILabel";
            cLIENTE_FISICO_PAILabel.Size = new System.Drawing.Size(118, 25);
            cLIENTE_FISICO_PAILabel.TabIndex = 47;
            cLIENTE_FISICO_PAILabel.Text = "Nome do pai";
            // 
            // cLIENTE_FISICO_OBSERVACAOLabel
            // 
            cLIENTE_FISICO_OBSERVACAOLabel.AutoSize = true;
            cLIENTE_FISICO_OBSERVACAOLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_FISICO_OBSERVACAOLabel.Location = new System.Drawing.Point(609, 226);
            cLIENTE_FISICO_OBSERVACAOLabel.Name = "cLIENTE_FISICO_OBSERVACAOLabel";
            cLIENTE_FISICO_OBSERVACAOLabel.Size = new System.Drawing.Size(106, 25);
            cLIENTE_FISICO_OBSERVACAOLabel.TabIndex = 49;
            cLIENTE_FISICO_OBSERVACAOLabel.Text = "Observação";
            // 
            // cLIENTE_FISICO_NOMELabel
            // 
            cLIENTE_FISICO_NOMELabel.AutoSize = true;
            cLIENTE_FISICO_NOMELabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLIENTE_FISICO_NOMELabel.Location = new System.Drawing.Point(7, 7);
            cLIENTE_FISICO_NOMELabel.Name = "cLIENTE_FISICO_NOMELabel";
            cLIENTE_FISICO_NOMELabel.Size = new System.Drawing.Size(62, 25);
            cLIENTE_FISICO_NOMELabel.TabIndex = 50;
            cLIENTE_FISICO_NOMELabel.Text = "Nome";
            // 
            // cLIENTE_JURIDICO_RAZAO_SOCIALLabel
            // 
            cLIENTE_JURIDICO_RAZAO_SOCIALLabel.AutoSize = true;
            cLIENTE_JURIDICO_RAZAO_SOCIALLabel.Location = new System.Drawing.Point(-1, 3);
            cLIENTE_JURIDICO_RAZAO_SOCIALLabel.Name = "cLIENTE_JURIDICO_RAZAO_SOCIALLabel";
            cLIENTE_JURIDICO_RAZAO_SOCIALLabel.Size = new System.Drawing.Size(109, 25);
            cLIENTE_JURIDICO_RAZAO_SOCIALLabel.TabIndex = 12;
            cLIENTE_JURIDICO_RAZAO_SOCIALLabel.Text = "Razão social";
            // 
            // cLIENTE_JURIDICO_CNPJLabel
            // 
            cLIENTE_JURIDICO_CNPJLabel.AutoSize = true;
            cLIENTE_JURIDICO_CNPJLabel.Location = new System.Drawing.Point(55, 108);
            cLIENTE_JURIDICO_CNPJLabel.Name = "cLIENTE_JURIDICO_CNPJLabel";
            cLIENTE_JURIDICO_CNPJLabel.Size = new System.Drawing.Size(53, 25);
            cLIENTE_JURIDICO_CNPJLabel.TabIndex = 14;
            cLIENTE_JURIDICO_CNPJLabel.Text = "CNPJ";
            // 
            // cLIENTE_JURIDICO_IELabel
            // 
            cLIENTE_JURIDICO_IELabel.AutoSize = true;
            cLIENTE_JURIDICO_IELabel.Location = new System.Drawing.Point(519, 108);
            cLIENTE_JURIDICO_IELabel.Name = "cLIENTE_JURIDICO_IELabel";
            cLIENTE_JURIDICO_IELabel.Size = new System.Drawing.Size(150, 25);
            cLIENTE_JURIDICO_IELabel.TabIndex = 16;
            cLIENTE_JURIDICO_IELabel.Text = "Inscrição estadual";
            // 
            // cLIENTE_JURIDICO_FANTASIALabel
            // 
            cLIENTE_JURIDICO_FANTASIALabel.AutoSize = true;
            cLIENTE_JURIDICO_FANTASIALabel.Location = new System.Drawing.Point(33, 52);
            cLIENTE_JURIDICO_FANTASIALabel.Name = "cLIENTE_JURIDICO_FANTASIALabel";
            cLIENTE_JURIDICO_FANTASIALabel.Size = new System.Drawing.Size(75, 25);
            cLIENTE_JURIDICO_FANTASIALabel.TabIndex = 18;
            cLIENTE_JURIDICO_FANTASIALabel.Text = "Fantasia";
            // 
            // cLIENTE_JURIDICO_ATIVIDADELabel
            // 
            cLIENTE_JURIDICO_ATIVIDADELabel.AutoSize = true;
            cLIENTE_JURIDICO_ATIVIDADELabel.Location = new System.Drawing.Point(20, 156);
            cLIENTE_JURIDICO_ATIVIDADELabel.Name = "cLIENTE_JURIDICO_ATIVIDADELabel";
            cLIENTE_JURIDICO_ATIVIDADELabel.Size = new System.Drawing.Size(88, 25);
            cLIENTE_JURIDICO_ATIVIDADELabel.TabIndex = 20;
            cLIENTE_JURIDICO_ATIVIDADELabel.Text = "Atividade";
            // 
            // cLIENTE_JURIDICO_NOME_CONTATOLabel
            // 
            cLIENTE_JURIDICO_NOME_CONTATOLabel.AutoSize = true;
            cLIENTE_JURIDICO_NOME_CONTATOLabel.Location = new System.Drawing.Point(541, 156);
            cLIENTE_JURIDICO_NOME_CONTATOLabel.Name = "cLIENTE_JURIDICO_NOME_CONTATOLabel";
            cLIENTE_JURIDICO_NOME_CONTATOLabel.Size = new System.Drawing.Size(128, 25);
            cLIENTE_JURIDICO_NOME_CONTATOLabel.TabIndex = 22;
            cLIENTE_JURIDICO_NOME_CONTATOLabel.Text = "Representante";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 537);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboTipoCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 80);
            this.panel1.TabIndex = 0;
            // 
            // pictureFechar
            // 
            this.pictureFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureFechar.Image = global::FROGI_OS.Properties.Resources.icone_fechar;
            this.pictureFechar.Location = new System.Drawing.Point(976, 12);
            this.pictureFechar.Name = "pictureFechar";
            this.pictureFechar.Size = new System.Drawing.Size(48, 48);
            this.pictureFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFechar.TabIndex = 2;
            this.pictureFechar.TabStop = false;
            this.pictureFechar.Click += new System.EventHandler(this.pictureFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 40F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // comboTipoCliente
            // 
            this.comboTipoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "CLIENTE_TIPO", true));
            this.comboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTipoCliente.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoCliente.FormattingEnabled = true;
            this.comboTipoCliente.Items.AddRange(new object[] {
            "Físico",
            "Jurídico"});
            this.comboTipoCliente.Location = new System.Drawing.Point(215, 27);
            this.comboTipoCliente.Name = "comboTipoCliente";
            this.comboTipoCliente.Size = new System.Drawing.Size(121, 33);
            this.comboTipoCliente.TabIndex = 118;
            this.comboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.comboTipoCliente_SelectedIndexChanged);
            // 
            // bsCliente
            // 
            this.bsCliente.DataMember = "CLIENTE";
            this.bsCliente.DataSource = this.dsFROGIOS;
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panelCodigoData);
            this.panel2.Controls.Add(this.pictureEditar);
            this.panel2.Controls.Add(this.pictureExcluir);
            this.panel2.Controls.Add(this.pictureSalvar);
            this.panel2.Controls.Add(this.picturePesquisar);
            this.panel2.Controls.Add(this.pictureNovo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 455);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 82);
            this.panel2.TabIndex = 1;
            // 
            // pictureEditar
            // 
            this.pictureEditar.Image = global::FROGI_OS.Properties.Resources.icone_editar;
            this.pictureEditar.Location = new System.Drawing.Point(752, 8);
            this.pictureEditar.Name = "pictureEditar";
            this.pictureEditar.Size = new System.Drawing.Size(64, 64);
            this.pictureEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEditar.TabIndex = 10;
            this.pictureEditar.TabStop = false;
            this.pictureEditar.Click += new System.EventHandler(this.pictureEditar_Click);
            // 
            // pictureExcluir
            // 
            this.pictureExcluir.Image = global::FROGI_OS.Properties.Resources.icone_excluir;
            this.pictureExcluir.Location = new System.Drawing.Point(822, 8);
            this.pictureExcluir.Name = "pictureExcluir";
            this.pictureExcluir.Size = new System.Drawing.Size(64, 64);
            this.pictureExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExcluir.TabIndex = 9;
            this.pictureExcluir.TabStop = false;
            this.pictureExcluir.Click += new System.EventHandler(this.pictureExcluir_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.BackColor = System.Drawing.Color.Black;
            this.labelCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "CLIENTE_CODIGO", true));
            this.labelCodigo.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.labelCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCodigo.Location = new System.Drawing.Point(113, 5);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(118, 37);
            this.labelCodigo.TabIndex = 100;
            this.labelCodigo.Text = "CODIGO";
            // 
            // pictureSalvar
            // 
            this.pictureSalvar.Image = global::FROGI_OS.Properties.Resources.icone_salvar;
            this.pictureSalvar.Location = new System.Drawing.Point(892, 8);
            this.pictureSalvar.Name = "pictureSalvar";
            this.pictureSalvar.Size = new System.Drawing.Size(64, 64);
            this.pictureSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSalvar.TabIndex = 8;
            this.pictureSalvar.TabStop = false;
            this.pictureSalvar.Click += new System.EventHandler(this.pictureSalvar_Click);
            // 
            // picturePesquisar
            // 
            this.picturePesquisar.Image = global::FROGI_OS.Properties.Resources.icone_pesquisar;
            this.picturePesquisar.Location = new System.Drawing.Point(962, 8);
            this.picturePesquisar.Name = "picturePesquisar";
            this.picturePesquisar.Size = new System.Drawing.Size(64, 64);
            this.picturePesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePesquisar.TabIndex = 7;
            this.picturePesquisar.TabStop = false;
            this.picturePesquisar.Click += new System.EventHandler(this.picturePesquisar_Click);
            // 
            // pictureNovo
            // 
            this.pictureNovo.Image = global::FROGI_OS.Properties.Resources.icone_novo;
            this.pictureNovo.Location = new System.Drawing.Point(682, 8);
            this.pictureNovo.Name = "pictureNovo";
            this.pictureNovo.Size = new System.Drawing.Size(64, 64);
            this.pictureNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNovo.TabIndex = 6;
            this.pictureNovo.TabStop = false;
            this.pictureNovo.Click += new System.EventHandler(this.pictureNovo_Click);
            // 
            // labelDataCadastroLabel
            // 
            this.labelDataCadastroLabel.AutoSize = true;
            this.labelDataCadastroLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.labelDataCadastroLabel.ForeColor = System.Drawing.Color.White;
            this.labelDataCadastroLabel.Location = new System.Drawing.Point(18, 43);
            this.labelDataCadastroLabel.Name = "labelDataCadastroLabel";
            this.labelDataCadastroLabel.Size = new System.Drawing.Size(158, 28);
            this.labelDataCadastroLabel.TabIndex = 103;
            this.labelDataCadastroLabel.Text = "Data de cadastro:";
            // 
            // labelCodigoLabel
            // 
            this.labelCodigoLabel.AutoSize = true;
            this.labelCodigoLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.labelCodigoLabel.ForeColor = System.Drawing.Color.White;
            this.labelCodigoLabel.Location = new System.Drawing.Point(16, 5);
            this.labelCodigoLabel.Name = "labelCodigoLabel";
            this.labelCodigoLabel.Size = new System.Drawing.Size(106, 37);
            this.labelCodigoLabel.TabIndex = 102;
            this.labelCodigoLabel.Text = "Código:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Black;
            this.labelData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "CLIENTE_DATA_CADASTRO", true));
            this.labelData.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.labelData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelData.Location = new System.Drawing.Point(170, 43);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(61, 28);
            this.labelData.TabIndex = 101;
            this.labelData.Text = "DATA";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.tabClienteJuridico);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1036, 375);
            this.panel3.TabIndex = 2;
            // 
            // tabClienteJuridico
            // 
            this.tabClienteJuridico.Controls.Add(this.tabClienteFisico);
            this.tabClienteJuridico.Controls.Add(this.tabPage2);
            this.tabClienteJuridico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabClienteJuridico.Location = new System.Drawing.Point(0, 0);
            this.tabClienteJuridico.Margin = new System.Windows.Forms.Padding(0);
            this.tabClienteJuridico.Name = "tabClienteJuridico";
            this.tabClienteJuridico.SelectedIndex = 0;
            this.tabClienteJuridico.Size = new System.Drawing.Size(1036, 375);
            this.tabClienteJuridico.TabIndex = 0;
            this.tabClienteJuridico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabPai_KeyDown);
            // 
            // bsUF
            // 
            this.bsUF.DataMember = "UF";
            this.bsUF.DataSource = this.dsFROGIOS;
            // 
            // bsClienteFisico
            // 
            this.bsClienteFisico.DataMember = "CLIENTE_FISICO_CLIENTE_FK";
            this.bsClienteFisico.DataSource = this.bsCliente;
            // 
            // bsClienteJuridico
            // 
            this.bsClienteJuridico.DataMember = "CLIENTE_JURIDICO_CLIENTE_FK";
            this.bsClienteJuridico.DataSource = this.bsCliente;
            // 
            // bsClienteFisicoPesquisa
            // 
            this.bsClienteFisicoPesquisa.DataMember = "SP_CLIENTE_FISICO_PESQUISA";
            this.bsClienteFisicoPesquisa.DataSource = this.dsFROGIOS;
            // 
            // bsClienteJuridicoPesquisa
            // 
            this.bsClienteJuridicoPesquisa.DataMember = "SP_CLIENTE_JURIDICO_PESQUISA";
            this.bsClienteJuridicoPesquisa.DataSource = this.dsFROGIOS;
            // 
            // taCliente
            // 
            this.taCliente.ClearBeforeFill = true;
            // 
            // taManager
            // 
            this.taManager.BackupDataSetBeforeUpdate = false;
            this.taManager.CATEGORIATableAdapter = null;
            this.taManager.CLIENTE_FISICOTableAdapter = this.taClienteFisico;
            this.taManager.CLIENTE_JURIDICOTableAdapter = this.taClienteJuridico;
            this.taManager.CLIENTETableAdapter = this.taCliente;
            this.taManager.COMPRATableAdapter = null;
            this.taManager.EMPRESATableAdapter = null;
            this.taManager.FORNECEDOR_FISICOTableAdapter = null;
            this.taManager.FORNECEDOR_JURIDICOTableAdapter = null;
            this.taManager.FORNECEDORTableAdapter = null;
            this.taManager.FUNCIONARIOTableAdapter = null;
            this.taManager.GRUPOTableAdapter = null;
            this.taManager.ITEM_COMPRATableAdapter = null;
            this.taManager.MARCATableAdapter = null;
            this.taManager.ORCAMENTO_ITEMTableAdapter = null;
            this.taManager.ORCAMENTO_SERVICOTableAdapter = null;
            this.taManager.ORCAMENTOTableAdapter = null;
            this.taManager.OS_ITEMTableAdapter = null;
            this.taManager.OS_SERVICOTableAdapter = null;
            this.taManager.OSTableAdapter = null;
            this.taManager.PERMISSAOTableAdapter = null;
            this.taManager.PRODUTOTableAdapter = null;
            this.taManager.SECAOTableAdapter = null;
            this.taManager.SERVICO_TIPOTableAdapter = null;
            this.taManager.SERVICOTableAdapter = null;
            this.taManager.TIPOTableAdapter = null;
            this.taManager.UFTableAdapter = null;
            this.taManager.UpdateOrder = FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.taManager.USUARIOTableAdapter = null;
            // 
            // taClienteFisico
            // 
            this.taClienteFisico.ClearBeforeFill = true;
            // 
            // taClienteJuridico
            // 
            this.taClienteJuridico.ClearBeforeFill = true;
            // 
            // taClienteFisicoPesquisa
            // 
            this.taClienteFisicoPesquisa.ClearBeforeFill = true;
            // 
            // taClienteJuridicoPesquisa
            // 
            this.taClienteJuridicoPesquisa.ClearBeforeFill = true;
            // 
            // taUF
            // 
            this.taUF.ClearBeforeFill = true;
            // 
            // tabCliente
            // 
            this.tabCliente.AutoScroll = true;
            this.tabCliente.BackColor = System.Drawing.Color.LightBlue;
            this.tabCliente.Controls.Add(this.panelCliente);
            this.tabCliente.Controls.Add(this.tabCadastro);
            this.tabCliente.Controls.Add(this.panel4);
            this.tabCliente.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Margin = new System.Windows.Forms.Padding(0);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(1028, 349);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Cliente";
            // 
            // panelCliente
            // 
            this.panelCliente.Controls.Add(this.cLIENTE_CELULARMaskedTextBox);
            this.panelCliente.Controls.Add(this.cLIENTE_TELEFONEMaskedTextBox);
            this.panelCliente.Controls.Add(this.cLIENTE_CEPMaskedTextBox);
            this.panelCliente.Controls.Add(this.uF_DESCRICAOComboBox);
            this.panelCliente.Controls.Add(cLIENTE_UFLabel);
            this.panelCliente.Controls.Add(cLIENTE_TELEFONELabel);
            this.panelCliente.Controls.Add(cLIENTE_CELULARLabel);
            this.panelCliente.Controls.Add(cLIENTE_EMAILLabel);
            this.panelCliente.Controls.Add(this.cLIENTE_EMAILTextBox);
            this.panelCliente.Controls.Add(cLIENTE_ENDERECOLabel);
            this.panelCliente.Controls.Add(this.cLIENTE_ENDERECOTextBox);
            this.panelCliente.Controls.Add(cLIENTE_BAIRROLabel);
            this.panelCliente.Controls.Add(this.cLIENTE_BAIRROTextBox);
            this.panelCliente.Controls.Add(cLIENTE_PERIMETROLabel);
            this.panelCliente.Controls.Add(this.cLIENTE_PERIMETROTextBox);
            this.panelCliente.Controls.Add(cLIENTE_CIDADELabel);
            this.panelCliente.Controls.Add(this.cLIENTE_CIDADETextBox);
            this.panelCliente.Controls.Add(cLIENTE_CEPLabel);
            this.panelCliente.Location = new System.Drawing.Point(1032, -6);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(679, 332);
            this.panelCliente.TabIndex = 120;
            // 
            // cLIENTE_CELULARMaskedTextBox
            // 
            this.cLIENTE_CELULARMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "CLIENTE_CELULAR", true));
            this.cLIENTE_CELULARMaskedTextBox.Location = new System.Drawing.Point(419, 222);
            this.cLIENTE_CELULARMaskedTextBox.Mask = "(00)0000-0000";
            this.cLIENTE_CELULARMaskedTextBox.Name = "cLIENTE_CELULARMaskedTextBox";
            this.cLIENTE_CELULARMaskedTextBox.Size = new System.Drawing.Size(237, 33);
            this.cLIENTE_CELULARMaskedTextBox.TabIndex = 140;
            // 
            // cLIENTE_TELEFONEMaskedTextBox
            // 
            this.cLIENTE_TELEFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "CLIENTE_TELEFONE", true));
            this.cLIENTE_TELEFONEMaskedTextBox.Location = new System.Drawing.Point(93, 222);
            this.cLIENTE_TELEFONEMaskedTextBox.Mask = "(00)0000-0000";
            this.cLIENTE_TELEFONEMaskedTextBox.Name = "cLIENTE_TELEFONEMaskedTextBox";
            this.cLIENTE_TELEFONEMaskedTextBox.Size = new System.Drawing.Size(247, 33);
            this.cLIENTE_TELEFONEMaskedTextBox.TabIndex = 139;
            // 
            // cLIENTE_CEPMaskedTextBox
            // 
            this.cLIENTE_CEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "CLIENTE_CEP", true));
            this.cLIENTE_CEPMaskedTextBox.Location = new System.Drawing.Point(471, 171);
            this.cLIENTE_CEPMaskedTextBox.Mask = "00000-000";
            this.cLIENTE_CEPMaskedTextBox.Name = "cLIENTE_CEPMaskedTextBox";
            this.cLIENTE_CEPMaskedTextBox.Size = new System.Drawing.Size(185, 33);
            this.cLIENTE_CEPMaskedTextBox.TabIndex = 138;
            // 
            // uF_DESCRICAOComboBox
            // 
            this.uF_DESCRICAOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUF, "UF_DESCRICAO", true));
            this.uF_DESCRICAOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uF_DESCRICAOComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uF_DESCRICAOComboBox.FormattingEnabled = true;
            this.uF_DESCRICAOComboBox.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.uF_DESCRICAOComboBox.Location = new System.Drawing.Point(535, 120);
            this.uF_DESCRICAOComboBox.Name = "uF_DESCRICAOComboBox";
            this.uF_DESCRICAOComboBox.Size = new System.Drawing.Size(121, 33);
            this.uF_DESCRICAOComboBox.TabIndex = 137;
            // 
            // cLIENTE_EMAILTextBox
            // 
            this.cLIENTE_EMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "CLIENTE_EMAIL", true));
            this.cLIENTE_EMAILTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_EMAILTextBox.Location = new System.Drawing.Point(93, 272);
            this.cLIENTE_EMAILTextBox.Name = "cLIENTE_EMAILTextBox";
            this.cLIENTE_EMAILTextBox.Size = new System.Drawing.Size(563, 33);
            this.cLIENTE_EMAILTextBox.TabIndex = 22;
            // 
            // cLIENTE_ENDERECOTextBox
            // 
            this.cLIENTE_ENDERECOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "CLIENTE_ENDERECO", true));
            this.cLIENTE_ENDERECOTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_ENDERECOTextBox.Location = new System.Drawing.Point(93, 15);
            this.cLIENTE_ENDERECOTextBox.MaxLength = 60;
            this.cLIENTE_ENDERECOTextBox.Name = "cLIENTE_ENDERECOTextBox";
            this.cLIENTE_ENDERECOTextBox.Size = new System.Drawing.Size(563, 33);
            this.cLIENTE_ENDERECOTextBox.TabIndex = 14;
            // 
            // cLIENTE_BAIRROTextBox
            // 
            this.cLIENTE_BAIRROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "CLIENTE_BAIRRO", true));
            this.cLIENTE_BAIRROTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_BAIRROTextBox.Location = new System.Drawing.Point(93, 120);
            this.cLIENTE_BAIRROTextBox.MaxLength = 60;
            this.cLIENTE_BAIRROTextBox.Name = "cLIENTE_BAIRROTextBox";
            this.cLIENTE_BAIRROTextBox.Size = new System.Drawing.Size(397, 33);
            this.cLIENTE_BAIRROTextBox.TabIndex = 16;
            // 
            // cLIENTE_PERIMETROTextBox
            // 
            this.cLIENTE_PERIMETROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "CLIENTE_PERIMETRO", true));
            this.cLIENTE_PERIMETROTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_PERIMETROTextBox.Location = new System.Drawing.Point(93, 65);
            this.cLIENTE_PERIMETROTextBox.MaxLength = 60;
            this.cLIENTE_PERIMETROTextBox.Name = "cLIENTE_PERIMETROTextBox";
            this.cLIENTE_PERIMETROTextBox.Size = new System.Drawing.Size(563, 33);
            this.cLIENTE_PERIMETROTextBox.TabIndex = 15;
            // 
            // cLIENTE_CIDADETextBox
            // 
            this.cLIENTE_CIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "CLIENTE_CIDADE", true));
            this.cLIENTE_CIDADETextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_CIDADETextBox.Location = new System.Drawing.Point(93, 171);
            this.cLIENTE_CIDADETextBox.MaxLength = 60;
            this.cLIENTE_CIDADETextBox.Name = "cLIENTE_CIDADETextBox";
            this.cLIENTE_CIDADETextBox.Size = new System.Drawing.Size(320, 33);
            this.cLIENTE_CIDADETextBox.TabIndex = 18;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.tabFisica);
            this.tabCadastro.Controls.Add(this.tabJuridica);
            this.tabCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabCadastro.Location = new System.Drawing.Point(3, 3);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.SelectedIndex = 0;
            this.tabCadastro.Size = new System.Drawing.Size(1023, 326);
            this.tabCadastro.TabIndex = 95;
            // 
            // tabFisica
            // 
            this.tabFisica.AutoScroll = true;
            this.tabFisica.BackColor = System.Drawing.Color.LightBlue;
            this.tabFisica.Controls.Add(this.panelFisico);
            this.tabFisica.Location = new System.Drawing.Point(4, 34);
            this.tabFisica.Margin = new System.Windows.Forms.Padding(0);
            this.tabFisica.Name = "tabFisica";
            this.tabFisica.Padding = new System.Windows.Forms.Padding(3);
            this.tabFisica.Size = new System.Drawing.Size(1015, 288);
            this.tabFisica.TabIndex = 0;
            this.tabFisica.Text = "Fisica";
            // 
            // panelFisico
            // 
            this.panelFisico.AutoScroll = true;
            this.panelFisico.Controls.Add(this.cLIENTE_FISICO_SALARIOMaskedTextBox);
            this.panelFisico.Controls.Add(this.cLIENTE_FISICO_CPFMaskedTextBox);
            this.panelFisico.Controls.Add(this.cLIENTE_FISICO_OBSERVACAORichTextBox);
            this.panelFisico.Controls.Add(cLIENTE_FISICO_CPFLabel);
            this.panelFisico.Controls.Add(cLIENTE_FISICO_RGLabel);
            this.panelFisico.Controls.Add(this.cLIENTE_FISICO_RGTextBox);
            this.panelFisico.Controls.Add(cLIENTE_FISICO_NASCIMENTOLabel);
            this.panelFisico.Controls.Add(this.cLIENTE_FISICO_NASCIMENTODateTimePicker);
            this.panelFisico.Controls.Add(cLIENTE_FISICO_SEXOLabel);
            this.panelFisico.Controls.Add(this.cLIENTE_FISICO_SEXOComboBox);
            this.panelFisico.Controls.Add(cLIENTE_FISICO_ESTADO_CIVILLabel);
            this.panelFisico.Controls.Add(this.cLIENTE_FISICO_ESTADO_CIVILTextBox);
            this.panelFisico.Controls.Add(cLIENTE_FISICO_PROFISSAOLabel);
            this.panelFisico.Controls.Add(this.cLIENTE_FISICO_PROFISSAOTextBox);
            this.panelFisico.Controls.Add(cLIENTE_FISICO_SALARIOLabel);
            this.panelFisico.Controls.Add(cLIENTE_FISICO_LIMITELabel);
            this.panelFisico.Controls.Add(this.cLIENTE_FISICO_LIMITETextBox);
            this.panelFisico.Controls.Add(cLIENTE_FISICO_LIMITE_ATUALLabel);
            this.panelFisico.Controls.Add(this.cLIENTE_FISICO_LIMITE_ATUALTextBox);
            this.panelFisico.Controls.Add(cLIENTE_FISICO_MAELabel);
            this.panelFisico.Controls.Add(this.cLIENTE_FISICO_MAETextBox);
            this.panelFisico.Controls.Add(cLIENTE_FISICO_PAILabel);
            this.panelFisico.Controls.Add(this.cLIENTE_FISICO_PAITextBox);
            this.panelFisico.Controls.Add(cLIENTE_FISICO_OBSERVACAOLabel);
            this.panelFisico.Controls.Add(cLIENTE_FISICO_NOMELabel);
            this.panelFisico.Controls.Add(this.cLIENTE_FISICO_NOMETextBox);
            this.panelFisico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFisico.Location = new System.Drawing.Point(3, 3);
            this.panelFisico.Name = "panelFisico";
            this.panelFisico.Size = new System.Drawing.Size(1009, 282);
            this.panelFisico.TabIndex = 0;
            // 
            // cLIENTE_FISICO_SALARIOMaskedTextBox
            // 
            this.cLIENTE_FISICO_SALARIOMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteFisico, "CLIENTE_FISICO_SALARIO", true));
            this.cLIENTE_FISICO_SALARIOMaskedTextBox.Location = new System.Drawing.Point(75, 154);
            this.cLIENTE_FISICO_SALARIOMaskedTextBox.Name = "cLIENTE_FISICO_SALARIOMaskedTextBox";
            this.cLIENTE_FISICO_SALARIOMaskedTextBox.Size = new System.Drawing.Size(202, 33);
            this.cLIENTE_FISICO_SALARIOMaskedTextBox.TabIndex = 52;
            // 
            // cLIENTE_FISICO_CPFMaskedTextBox
            // 
            this.cLIENTE_FISICO_CPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteFisico, "CLIENTE_FISICO_CPF", true));
            this.cLIENTE_FISICO_CPFMaskedTextBox.Location = new System.Drawing.Point(75, 104);
            this.cLIENTE_FISICO_CPFMaskedTextBox.Mask = "000.000.000-00";
            this.cLIENTE_FISICO_CPFMaskedTextBox.Name = "cLIENTE_FISICO_CPFMaskedTextBox";
            this.cLIENTE_FISICO_CPFMaskedTextBox.Size = new System.Drawing.Size(202, 33);
            this.cLIENTE_FISICO_CPFMaskedTextBox.TabIndex = 51;
            // 
            // cLIENTE_FISICO_OBSERVACAORichTextBox
            // 
            this.cLIENTE_FISICO_OBSERVACAORichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteFisico, "CLIENTE_FISICO_OBSERVACAO", true));
            this.cLIENTE_FISICO_OBSERVACAORichTextBox.Location = new System.Drawing.Point(721, 193);
            this.cLIENTE_FISICO_OBSERVACAORichTextBox.Name = "cLIENTE_FISICO_OBSERVACAORichTextBox";
            this.cLIENTE_FISICO_OBSERVACAORichTextBox.Size = new System.Drawing.Size(280, 86);
            this.cLIENTE_FISICO_OBSERVACAORichTextBox.TabIndex = 13;
            this.cLIENTE_FISICO_OBSERVACAORichTextBox.Text = "";
            // 
            // cLIENTE_FISICO_RGTextBox
            // 
            this.cLIENTE_FISICO_RGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteFisico, "CLIENTE_FISICO_RG", true));
            this.cLIENTE_FISICO_RGTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_FISICO_RGTextBox.Location = new System.Drawing.Point(375, 104);
            this.cLIENTE_FISICO_RGTextBox.MaxLength = 10;
            this.cLIENTE_FISICO_RGTextBox.Name = "cLIENTE_FISICO_RGTextBox";
            this.cLIENTE_FISICO_RGTextBox.Size = new System.Drawing.Size(200, 33);
            this.cLIENTE_FISICO_RGTextBox.TabIndex = 6;
            // 
            // cLIENTE_FISICO_NASCIMENTODateTimePicker
            // 
            this.cLIENTE_FISICO_NASCIMENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsClienteFisico, "CLIENTE_FISICO_NASCIMENTO", true));
            this.cLIENTE_FISICO_NASCIMENTODateTimePicker.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_FISICO_NASCIMENTODateTimePicker.Location = new System.Drawing.Point(184, 53);
            this.cLIENTE_FISICO_NASCIMENTODateTimePicker.Name = "cLIENTE_FISICO_NASCIMENTODateTimePicker";
            this.cLIENTE_FISICO_NASCIMENTODateTimePicker.Size = new System.Drawing.Size(287, 29);
            this.cLIENTE_FISICO_NASCIMENTODateTimePicker.TabIndex = 2;
            // 
            // cLIENTE_FISICO_SEXOComboBox
            // 
            this.cLIENTE_FISICO_SEXOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteFisico, "CLIENTE_FISICO_SEXO", true));
            this.cLIENTE_FISICO_SEXOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cLIENTE_FISICO_SEXOComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cLIENTE_FISICO_SEXOComboBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_FISICO_SEXOComboBox.FormattingEnabled = true;
            this.cLIENTE_FISICO_SEXOComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cLIENTE_FISICO_SEXOComboBox.Location = new System.Drawing.Point(937, 53);
            this.cLIENTE_FISICO_SEXOComboBox.Name = "cLIENTE_FISICO_SEXOComboBox";
            this.cLIENTE_FISICO_SEXOComboBox.Size = new System.Drawing.Size(61, 33);
            this.cLIENTE_FISICO_SEXOComboBox.TabIndex = 4;
            // 
            // cLIENTE_FISICO_ESTADO_CIVILTextBox
            // 
            this.cLIENTE_FISICO_ESTADO_CIVILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteFisico, "CLIENTE_FISICO_ESTADO_CIVIL", true));
            this.cLIENTE_FISICO_ESTADO_CIVILTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_FISICO_ESTADO_CIVILTextBox.Location = new System.Drawing.Point(583, 53);
            this.cLIENTE_FISICO_ESTADO_CIVILTextBox.MaxLength = 60;
            this.cLIENTE_FISICO_ESTADO_CIVILTextBox.Name = "cLIENTE_FISICO_ESTADO_CIVILTextBox";
            this.cLIENTE_FISICO_ESTADO_CIVILTextBox.Size = new System.Drawing.Size(292, 33);
            this.cLIENTE_FISICO_ESTADO_CIVILTextBox.TabIndex = 3;
            // 
            // cLIENTE_FISICO_PROFISSAOTextBox
            // 
            this.cLIENTE_FISICO_PROFISSAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteFisico, "CLIENTE_FISICO_PROFISSAO", true));
            this.cLIENTE_FISICO_PROFISSAOTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_FISICO_PROFISSAOTextBox.Location = new System.Drawing.Point(691, 104);
            this.cLIENTE_FISICO_PROFISSAOTextBox.MaxLength = 60;
            this.cLIENTE_FISICO_PROFISSAOTextBox.Name = "cLIENTE_FISICO_PROFISSAOTextBox";
            this.cLIENTE_FISICO_PROFISSAOTextBox.Size = new System.Drawing.Size(307, 33);
            this.cLIENTE_FISICO_PROFISSAOTextBox.TabIndex = 7;
            // 
            // cLIENTE_FISICO_LIMITETextBox
            // 
            this.cLIENTE_FISICO_LIMITETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteFisico, "CLIENTE_FISICO_LIMITE", true));
            this.cLIENTE_FISICO_LIMITETextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_FISICO_LIMITETextBox.Location = new System.Drawing.Point(375, 151);
            this.cLIENTE_FISICO_LIMITETextBox.Name = "cLIENTE_FISICO_LIMITETextBox";
            this.cLIENTE_FISICO_LIMITETextBox.Size = new System.Drawing.Size(200, 33);
            this.cLIENTE_FISICO_LIMITETextBox.TabIndex = 9;
            // 
            // cLIENTE_FISICO_LIMITE_ATUALTextBox
            // 
            this.cLIENTE_FISICO_LIMITE_ATUALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteFisico, "CLIENTE_FISICO_LIMITE_ATUAL", true));
            this.cLIENTE_FISICO_LIMITE_ATUALTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_FISICO_LIMITE_ATUALTextBox.Location = new System.Drawing.Point(691, 151);
            this.cLIENTE_FISICO_LIMITE_ATUALTextBox.Name = "cLIENTE_FISICO_LIMITE_ATUALTextBox";
            this.cLIENTE_FISICO_LIMITE_ATUALTextBox.Size = new System.Drawing.Size(310, 33);
            this.cLIENTE_FISICO_LIMITE_ATUALTextBox.TabIndex = 10;
            // 
            // cLIENTE_FISICO_MAETextBox
            // 
            this.cLIENTE_FISICO_MAETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteFisico, "CLIENTE_FISICO_MAE", true));
            this.cLIENTE_FISICO_MAETextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_FISICO_MAETextBox.Location = new System.Drawing.Point(140, 203);
            this.cLIENTE_FISICO_MAETextBox.Name = "cLIENTE_FISICO_MAETextBox";
            this.cLIENTE_FISICO_MAETextBox.Size = new System.Drawing.Size(462, 33);
            this.cLIENTE_FISICO_MAETextBox.TabIndex = 11;
            // 
            // cLIENTE_FISICO_PAITextBox
            // 
            this.cLIENTE_FISICO_PAITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteFisico, "CLIENTE_FISICO_PAI", true));
            this.cLIENTE_FISICO_PAITextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_FISICO_PAITextBox.Location = new System.Drawing.Point(140, 245);
            this.cLIENTE_FISICO_PAITextBox.Name = "cLIENTE_FISICO_PAITextBox";
            this.cLIENTE_FISICO_PAITextBox.Size = new System.Drawing.Size(462, 33);
            this.cLIENTE_FISICO_PAITextBox.TabIndex = 12;
            // 
            // cLIENTE_FISICO_NOMETextBox
            // 
            this.cLIENTE_FISICO_NOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteFisico, "CLIENTE_FISICO_NOME", true));
            this.cLIENTE_FISICO_NOMETextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTE_FISICO_NOMETextBox.Location = new System.Drawing.Point(75, 4);
            this.cLIENTE_FISICO_NOMETextBox.MaxLength = 60;
            this.cLIENTE_FISICO_NOMETextBox.Name = "cLIENTE_FISICO_NOMETextBox";
            this.cLIENTE_FISICO_NOMETextBox.Size = new System.Drawing.Size(923, 33);
            this.cLIENTE_FISICO_NOMETextBox.TabIndex = 1;
            // 
            // tabJuridica
            // 
            this.tabJuridica.BackColor = System.Drawing.Color.LightBlue;
            this.tabJuridica.Controls.Add(this.panelJuridica);
            this.tabJuridica.Location = new System.Drawing.Point(4, 34);
            this.tabJuridica.Margin = new System.Windows.Forms.Padding(0);
            this.tabJuridica.Name = "tabJuridica";
            this.tabJuridica.Padding = new System.Windows.Forms.Padding(3);
            this.tabJuridica.Size = new System.Drawing.Size(1015, 288);
            this.tabJuridica.TabIndex = 1;
            this.tabJuridica.Text = "Juridica";
            // 
            // panelJuridica
            // 
            this.panelJuridica.AutoScroll = true;
            this.panelJuridica.Controls.Add(this.cLIENTE_JURIDICO_IEMaskedTextBox);
            this.panelJuridica.Controls.Add(this.cLIENTE_JURIDICO_CNPJMaskedTextBox);
            this.panelJuridica.Controls.Add(cLIENTE_JURIDICO_RAZAO_SOCIALLabel);
            this.panelJuridica.Controls.Add(this.cLIENTE_JURIDICO_RAZAO_SOCIALTextBox);
            this.panelJuridica.Controls.Add(cLIENTE_JURIDICO_CNPJLabel);
            this.panelJuridica.Controls.Add(cLIENTE_JURIDICO_IELabel);
            this.panelJuridica.Controls.Add(cLIENTE_JURIDICO_FANTASIALabel);
            this.panelJuridica.Controls.Add(this.cLIENTE_JURIDICO_FANTASIATextBox);
            this.panelJuridica.Controls.Add(cLIENTE_JURIDICO_ATIVIDADELabel);
            this.panelJuridica.Controls.Add(this.cLIENTE_JURIDICO_ATIVIDADETextBox);
            this.panelJuridica.Controls.Add(cLIENTE_JURIDICO_NOME_CONTATOLabel);
            this.panelJuridica.Controls.Add(this.cLIENTE_JURIDICO_NOME_CONTATOTextBox);
            this.panelJuridica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJuridica.Location = new System.Drawing.Point(3, 3);
            this.panelJuridica.Name = "panelJuridica";
            this.panelJuridica.Size = new System.Drawing.Size(1009, 282);
            this.panelJuridica.TabIndex = 0;
            // 
            // cLIENTE_JURIDICO_IEMaskedTextBox
            // 
            this.cLIENTE_JURIDICO_IEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteJuridico, "CLIENTE_JURIDICO_IE", true));
            this.cLIENTE_JURIDICO_IEMaskedTextBox.Location = new System.Drawing.Point(675, 105);
            this.cLIENTE_JURIDICO_IEMaskedTextBox.Mask = "000.000.000.000";
            this.cLIENTE_JURIDICO_IEMaskedTextBox.Name = "cLIENTE_JURIDICO_IEMaskedTextBox";
            this.cLIENTE_JURIDICO_IEMaskedTextBox.Size = new System.Drawing.Size(317, 33);
            this.cLIENTE_JURIDICO_IEMaskedTextBox.TabIndex = 25;
            // 
            // cLIENTE_JURIDICO_CNPJMaskedTextBox
            // 
            this.cLIENTE_JURIDICO_CNPJMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteJuridico, "CLIENTE_JURIDICO_CNPJ", true));
            this.cLIENTE_JURIDICO_CNPJMaskedTextBox.Location = new System.Drawing.Point(114, 105);
            this.cLIENTE_JURIDICO_CNPJMaskedTextBox.Mask = "00.000.000/0000-00";
            this.cLIENTE_JURIDICO_CNPJMaskedTextBox.Name = "cLIENTE_JURIDICO_CNPJMaskedTextBox";
            this.cLIENTE_JURIDICO_CNPJMaskedTextBox.Size = new System.Drawing.Size(389, 33);
            this.cLIENTE_JURIDICO_CNPJMaskedTextBox.TabIndex = 24;
            // 
            // cLIENTE_JURIDICO_RAZAO_SOCIALTextBox
            // 
            this.cLIENTE_JURIDICO_RAZAO_SOCIALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteJuridico, "CLIENTE_JURIDICO_RAZAO_SOCIAL", true));
            this.cLIENTE_JURIDICO_RAZAO_SOCIALTextBox.Location = new System.Drawing.Point(114, 3);
            this.cLIENTE_JURIDICO_RAZAO_SOCIALTextBox.MaxLength = 60;
            this.cLIENTE_JURIDICO_RAZAO_SOCIALTextBox.Name = "cLIENTE_JURIDICO_RAZAO_SOCIALTextBox";
            this.cLIENTE_JURIDICO_RAZAO_SOCIALTextBox.Size = new System.Drawing.Size(878, 33);
            this.cLIENTE_JURIDICO_RAZAO_SOCIALTextBox.TabIndex = 13;
            // 
            // cLIENTE_JURIDICO_FANTASIATextBox
            // 
            this.cLIENTE_JURIDICO_FANTASIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteJuridico, "CLIENTE_JURIDICO_FANTASIA", true));
            this.cLIENTE_JURIDICO_FANTASIATextBox.Location = new System.Drawing.Point(114, 52);
            this.cLIENTE_JURIDICO_FANTASIATextBox.MaxLength = 60;
            this.cLIENTE_JURIDICO_FANTASIATextBox.Name = "cLIENTE_JURIDICO_FANTASIATextBox";
            this.cLIENTE_JURIDICO_FANTASIATextBox.Size = new System.Drawing.Size(878, 33);
            this.cLIENTE_JURIDICO_FANTASIATextBox.TabIndex = 19;
            // 
            // cLIENTE_JURIDICO_ATIVIDADETextBox
            // 
            this.cLIENTE_JURIDICO_ATIVIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteJuridico, "CLIENTE_JURIDICO_ATIVIDADE", true));
            this.cLIENTE_JURIDICO_ATIVIDADETextBox.Location = new System.Drawing.Point(114, 156);
            this.cLIENTE_JURIDICO_ATIVIDADETextBox.MaxLength = 60;
            this.cLIENTE_JURIDICO_ATIVIDADETextBox.Name = "cLIENTE_JURIDICO_ATIVIDADETextBox";
            this.cLIENTE_JURIDICO_ATIVIDADETextBox.Size = new System.Drawing.Size(389, 33);
            this.cLIENTE_JURIDICO_ATIVIDADETextBox.TabIndex = 21;
            // 
            // cLIENTE_JURIDICO_NOME_CONTATOTextBox
            // 
            this.cLIENTE_JURIDICO_NOME_CONTATOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClienteJuridico, "CLIENTE_JURIDICO_NOME_CONTATO", true));
            this.cLIENTE_JURIDICO_NOME_CONTATOTextBox.Location = new System.Drawing.Point(675, 156);
            this.cLIENTE_JURIDICO_NOME_CONTATOTextBox.MaxLength = 60;
            this.cLIENTE_JURIDICO_NOME_CONTATOTextBox.Name = "cLIENTE_JURIDICO_NOME_CONTATOTextBox";
            this.cLIENTE_JURIDICO_NOME_CONTATOTextBox.Size = new System.Drawing.Size(317, 33);
            this.cLIENTE_JURIDICO_NOME_CONTATOTextBox.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1666, 168);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 100);
            this.panel4.TabIndex = 94;
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.AutoScroll = true;
            this.tabPesquisa.BackColor = System.Drawing.Color.LightBlue;
            this.tabPesquisa.Controls.Add(this.tabGridPesquisa);
            this.tabPesquisa.Controls.Add(this.label40);
            this.tabPesquisa.Controls.Add(this.cbTipoCliente);
            this.tabPesquisa.Controls.Add(this.label19);
            this.tabPesquisa.Controls.Add(this.cbCampoPesquisa);
            this.tabPesquisa.Controls.Add(this.label3);
            this.tabPesquisa.Controls.Add(this.textCampoPesquisa);
            this.tabPesquisa.Controls.Add(this.buttonPesquisar);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Size = new System.Drawing.Size(1028, 349);
            this.tabPesquisa.TabIndex = 2;
            this.tabPesquisa.Text = "Pesquisa";
            // 
            // tabGridPesquisa
            // 
            this.tabGridPesquisa.Controls.Add(this.tabFisicoPesquisa);
            this.tabGridPesquisa.Controls.Add(this.tabJuridicoPesquisa);
            this.tabGridPesquisa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabGridPesquisa.Location = new System.Drawing.Point(0, 96);
            this.tabGridPesquisa.Name = "tabGridPesquisa";
            this.tabGridPesquisa.SelectedIndex = 0;
            this.tabGridPesquisa.Size = new System.Drawing.Size(1028, 253);
            this.tabGridPesquisa.TabIndex = 65;
            // 
            // tabFisicoPesquisa
            // 
            this.tabFisicoPesquisa.AutoScroll = true;
            this.tabFisicoPesquisa.Controls.Add(this.sP_CLIENTE_FISICO_PESQUISADataGridView);
            this.tabFisicoPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabFisicoPesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.tabFisicoPesquisa.Name = "tabFisicoPesquisa";
            this.tabFisicoPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabFisicoPesquisa.Size = new System.Drawing.Size(1020, 227);
            this.tabFisicoPesquisa.TabIndex = 0;
            this.tabFisicoPesquisa.Text = "Fisico";
            this.tabFisicoPesquisa.UseVisualStyleBackColor = true;
            // 
            // sP_CLIENTE_FISICO_PESQUISADataGridView
            // 
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.AllowUserToAddRows = false;
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.AllowUserToDeleteRows = false;
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.AutoGenerateColumns = false;
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoFisico,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.DataSource = this.bsClienteFisicoPesquisa;
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.Location = new System.Drawing.Point(3, 3);
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.Name = "sP_CLIENTE_FISICO_PESQUISADataGridView";
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.ReadOnly = true;
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.Size = new System.Drawing.Size(1014, 221);
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.TabIndex = 4;
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sP_CLIENTE_FISICO_PESQUISADataGridView_CellDoubleClick);
            this.sP_CLIENTE_FISICO_PESQUISADataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sP_CLIENTE_FISICO_PESQUISADataGridView_KeyPress);
            // 
            // codigoFisico
            // 
            this.codigoFisico.DataPropertyName = "CODIGO";
            this.codigoFisico.HeaderText = "CODIGO";
            this.codigoFisico.Name = "codigoFisico";
            this.codigoFisico.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TELEFONE";
            this.dataGridViewTextBoxColumn4.HeaderText = "TELEFONE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CELULAR";
            this.dataGridViewTextBoxColumn5.HeaderText = "CELULAR";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ENDERECO";
            this.dataGridViewTextBoxColumn6.HeaderText = "ENDERECO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BAIRRO";
            this.dataGridViewTextBoxColumn7.HeaderText = "BAIRRO";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CIDADE";
            this.dataGridViewTextBoxColumn8.HeaderText = "CIDADE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tabJuridicoPesquisa
            // 
            this.tabJuridicoPesquisa.AutoScroll = true;
            this.tabJuridicoPesquisa.Controls.Add(this.sP_CLIENTE_JURIDICO_PESQUISADataGridView);
            this.tabJuridicoPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabJuridicoPesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.tabJuridicoPesquisa.Name = "tabJuridicoPesquisa";
            this.tabJuridicoPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabJuridicoPesquisa.Size = new System.Drawing.Size(1020, 227);
            this.tabJuridicoPesquisa.TabIndex = 1;
            this.tabJuridicoPesquisa.Text = "Juridico";
            this.tabJuridicoPesquisa.UseVisualStyleBackColor = true;
            // 
            // sP_CLIENTE_JURIDICO_PESQUISADataGridView
            // 
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.AllowUserToAddRows = false;
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.AllowUserToDeleteRows = false;
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.AutoGenerateColumns = false;
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoJuridico,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.DataSource = this.bsClienteJuridicoPesquisa;
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.Location = new System.Drawing.Point(3, 3);
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.Name = "sP_CLIENTE_JURIDICO_PESQUISADataGridView";
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.ReadOnly = true;
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.Size = new System.Drawing.Size(1014, 221);
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.TabIndex = 5;
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sP_CLIENTE_JURIDICO_PESQUISADataGridView_CellDoubleClick);
            this.sP_CLIENTE_JURIDICO_PESQUISADataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sP_CLIENTE_JURIDICO_PESQUISADataGridView_KeyPress);
            // 
            // codigoJuridico
            // 
            this.codigoJuridico.DataPropertyName = "CODIGO";
            this.codigoJuridico.HeaderText = "CODIGO";
            this.codigoJuridico.Name = "codigoJuridico";
            this.codigoJuridico.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FANTASIA";
            this.dataGridViewTextBoxColumn10.HeaderText = "FANTASIA";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CNPJ";
            this.dataGridViewTextBoxColumn11.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "TELEFONE";
            this.dataGridViewTextBoxColumn12.HeaderText = "TELEFONE";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CELULAR";
            this.dataGridViewTextBoxColumn13.HeaderText = "CELULAR";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ENDERECO";
            this.dataGridViewTextBoxColumn14.HeaderText = "ENDERECO";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "BAIRRO";
            this.dataGridViewTextBoxColumn15.HeaderText = "BAIRRO";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "CIDADE";
            this.dataGridViewTextBoxColumn16.HeaderText = "CIDADE";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(406, 60);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(24, 25);
            this.label40.TabIndex = 64;
            this.label40.Text = "=";
            // 
            // cbTipoCliente
            // 
            this.cbTipoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbTipoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoCliente.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoCliente.Items.AddRange(new object[] {
            "Físico",
            "Jurídico"});
            this.cbTipoCliente.Location = new System.Drawing.Point(143, 12);
            this.cbTipoCliente.MaxLength = 10;
            this.cbTipoCliente.Name = "cbTipoCliente";
            this.cbTipoCliente.Size = new System.Drawing.Size(257, 33);
            this.cbTipoCliente.TabIndex = 0;
            this.cbTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cbTipoCliente_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(6, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 25);
            this.label19.TabIndex = 62;
            this.label19.Text = "Tipo de cliente";
            // 
            // cbCampoPesquisa
            // 
            this.cbCampoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampoPesquisa.Enabled = false;
            this.cbCampoPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCampoPesquisa.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCampoPesquisa.FormattingEnabled = true;
            this.cbCampoPesquisa.Location = new System.Drawing.Point(143, 57);
            this.cbCampoPesquisa.MaxLength = 1;
            this.cbCampoPesquisa.Name = "cbCampoPesquisa";
            this.cbCampoPesquisa.Size = new System.Drawing.Size(257, 33);
            this.cbCampoPesquisa.TabIndex = 1;
            this.cbCampoPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbCampoPesquisa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pesquisar por";
            // 
            // textCampoPesquisa
            // 
            this.textCampoPesquisa.Enabled = false;
            this.textCampoPesquisa.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.textCampoPesquisa.Location = new System.Drawing.Point(436, 58);
            this.textCampoPesquisa.MaxLength = 60;
            this.textCampoPesquisa.Name = "textCampoPesquisa";
            this.textCampoPesquisa.Size = new System.Drawing.Size(410, 32);
            this.textCampoPesquisa.TabIndex = 2;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.AutoSize = true;
            this.buttonPesquisar.Enabled = false;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.Location = new System.Drawing.Point(860, 55);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(98, 37);
            this.buttonPesquisar.TabIndex = 3;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // tabClienteFisico
            // 
            this.tabClienteFisico.BackColor = System.Drawing.Color.LightBlue;
            this.tabClienteFisico.Location = new System.Drawing.Point(4, 22);
            this.tabClienteFisico.Name = "tabClienteFisico";
            this.tabClienteFisico.Size = new System.Drawing.Size(1028, 349);
            this.tabClienteFisico.TabIndex = 0;
            this.tabClienteFisico.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1028, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // panelCodigoData
            // 
            this.panelCodigoData.Controls.Add(this.labelCodigo);
            this.panelCodigoData.Controls.Add(this.labelData);
            this.panelCodigoData.Controls.Add(this.labelCodigoLabel);
            this.panelCodigoData.Controls.Add(this.labelDataCadastroLabel);
            this.panelCodigoData.Location = new System.Drawing.Point(4, 2);
            this.panelCodigoData.Name = "panelCodigoData";
            this.panelCodigoData.Size = new System.Drawing.Size(253, 79);
            this.panelCodigoData.TabIndex = 104;
            // 
            // formCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1036, 537);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formClienteCadastro";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabClienteJuridico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsUF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClienteFisico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClienteJuridico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClienteFisicoPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClienteJuridicoPesquisa)).EndInit();
            this.tabCliente.ResumeLayout(false);
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.tabCadastro.ResumeLayout(false);
            this.tabFisica.ResumeLayout(false);
            this.panelFisico.ResumeLayout(false);
            this.panelFisico.PerformLayout();
            this.tabJuridica.ResumeLayout(false);
            this.panelJuridica.ResumeLayout(false);
            this.panelJuridica.PerformLayout();
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            this.tabGridPesquisa.ResumeLayout(false);
            this.tabFisicoPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_CLIENTE_FISICO_PESQUISADataGridView)).EndInit();
            this.tabJuridicoPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_CLIENTE_JURIDICO_PESQUISADataGridView)).EndInit();
            this.panelCodigoData.ResumeLayout(false);
            this.panelCodigoData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCodigoLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDataCadastroLabel;
        private TablessControl tabClienteJuridico;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.PictureBox pictureEditar;
        private System.Windows.Forms.PictureBox pictureExcluir;
        private System.Windows.Forms.PictureBox pictureSalvar;
        private System.Windows.Forms.PictureBox picturePesquisar;
        private System.Windows.Forms.PictureBox pictureNovo;
        private System.Windows.Forms.PictureBox pictureFechar;
        private System.Windows.Forms.TextBox textCampoPesquisa;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.ComboBox cbCampoPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox cbTipoCliente;
        private System.Windows.Forms.Label label19;
        private TablessControl tabCadastro;
        private System.Windows.Forms.TabPage tabFisica;
        private System.Windows.Forms.TabPage tabJuridica;
        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsCliente;
        private dsFROGIOSTableAdapters.CLIENTETableAdapter taCliente;
        private dsFROGIOSTableAdapters.TableAdapterManager taManager;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.ComboBox comboTipoCliente;
        private dsFROGIOSTableAdapters.CLIENTE_FISICOTableAdapter taClienteFisico;
        private System.Windows.Forms.BindingSource bsClienteFisico;
        private dsFROGIOSTableAdapters.CLIENTE_JURIDICOTableAdapter taClienteJuridico;
        private System.Windows.Forms.BindingSource bsClienteJuridico;
        private TablessControl tabGridPesquisa;
        private System.Windows.Forms.TabPage tabFisicoPesquisa;
        private System.Windows.Forms.TabPage tabJuridicoPesquisa;
        private System.Windows.Forms.BindingSource bsClienteFisicoPesquisa;
        private dsFROGIOSTableAdapters.SP_CLIENTE_FISICO_PESQUISATableAdapter taClienteFisicoPesquisa;
        private System.Windows.Forms.DataGridView sP_CLIENTE_FISICO_PESQUISADataGridView;
        private System.Windows.Forms.BindingSource bsClienteJuridicoPesquisa;
        private dsFROGIOSTableAdapters.SP_CLIENTE_JURIDICO_PESQUISATableAdapter taClienteJuridicoPesquisa;
        private System.Windows.Forms.DataGridView sP_CLIENTE_JURIDICO_PESQUISADataGridView;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.TextBox cLIENTE_EMAILTextBox;
        private System.Windows.Forms.TextBox cLIENTE_ENDERECOTextBox;
        private System.Windows.Forms.TextBox cLIENTE_BAIRROTextBox;
        private System.Windows.Forms.TextBox cLIENTE_PERIMETROTextBox;
        private System.Windows.Forms.TextBox cLIENTE_CIDADETextBox;
        private System.Windows.Forms.Panel panelFisico;
        private System.Windows.Forms.RichTextBox cLIENTE_FISICO_OBSERVACAORichTextBox;
        private System.Windows.Forms.TextBox cLIENTE_FISICO_RGTextBox;
        private System.Windows.Forms.DateTimePicker cLIENTE_FISICO_NASCIMENTODateTimePicker;
        private System.Windows.Forms.ComboBox cLIENTE_FISICO_SEXOComboBox;
        private System.Windows.Forms.TextBox cLIENTE_FISICO_ESTADO_CIVILTextBox;
        private System.Windows.Forms.TextBox cLIENTE_FISICO_PROFISSAOTextBox;
        private System.Windows.Forms.TextBox cLIENTE_FISICO_LIMITETextBox;
        private System.Windows.Forms.TextBox cLIENTE_FISICO_LIMITE_ATUALTextBox;
        private System.Windows.Forms.TextBox cLIENTE_FISICO_MAETextBox;
        private System.Windows.Forms.TextBox cLIENTE_FISICO_PAITextBox;
        private System.Windows.Forms.TextBox cLIENTE_FISICO_NOMETextBox;
        private System.Windows.Forms.Panel panelJuridica;
        private System.Windows.Forms.TextBox cLIENTE_JURIDICO_RAZAO_SOCIALTextBox;
        private System.Windows.Forms.TextBox cLIENTE_JURIDICO_FANTASIATextBox;
        private System.Windows.Forms.TextBox cLIENTE_JURIDICO_ATIVIDADETextBox;
        private System.Windows.Forms.TextBox cLIENTE_JURIDICO_NOME_CONTATOTextBox;
        private dsFROGIOSTableAdapters.UFTableAdapter taUF;
        private System.Windows.Forms.MaskedTextBox cLIENTE_FISICO_CPFMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cLIENTE_CEPMaskedTextBox;
        private System.Windows.Forms.BindingSource bsUF;
        private System.Windows.Forms.MaskedTextBox cLIENTE_CELULARMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cLIENTE_TELEFONEMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cLIENTE_JURIDICO_IEMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cLIENTE_JURIDICO_CNPJMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cLIENTE_FISICO_SALARIOMaskedTextBox;
        private System.Windows.Forms.ComboBox uF_DESCRICAOComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFisico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoJuridico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.TabPage tabClienteFisico;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelCodigoData;

    }
}