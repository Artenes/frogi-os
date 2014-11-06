namespace FROGI_OS
{
    partial class formCadastroFuncionario : formCadastro
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
            System.Windows.Forms.Label fUNCIONARIO_CODIGOLabel;
            System.Windows.Forms.Label fUNCIONARIO_NOMELabel;
            System.Windows.Forms.Label fUNCIONARIO_CPFLabel;
            System.Windows.Forms.Label fUNCIONARIO_RGLabel;
            System.Windows.Forms.Label fUNCIONARIO_NASCIMENTOLabel;
            System.Windows.Forms.Label fUNCIONARIO_PISLabel;
            System.Windows.Forms.Label fUNCIONARIO_TELEFONELabel;
            System.Windows.Forms.Label fUNCIONARIO_EMAILLabel;
            System.Windows.Forms.Label fUNCIONARIO_ENDERECOLabel;
            System.Windows.Forms.Label fUNCIONARIO_BAIRROLabel;
            System.Windows.Forms.Label fUNCIONARIO_CEPLabel;
            System.Windows.Forms.Label fUNCIONARIO_FUNCAOLabel;
            System.Windows.Forms.Label fUNCIONARIO_SETORLabel;
            System.Windows.Forms.Label fUNCIONARIO_SALARIOLabel;
            System.Windows.Forms.Label fUNCIONARIO_ADMISSAOLabel;
            System.Windows.Forms.Label fUNCIONARIO_DATA_CADASTROLabel;
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.bsFuncionario = new System.Windows.Forms.BindingSource(this.components);
            this.taFuncionario = new FROGI_OS.dsFROGIOSTableAdapters.FUNCIONARIOTableAdapter();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.fUNCIONARIO_CODIGOLabel1 = new System.Windows.Forms.Label();
            this.fUNCIONARIO_NOMETextBox = new System.Windows.Forms.TextBox();
            this.fUNCIONARIO_CPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fUNCIONARIO_RGTextBox = new System.Windows.Forms.TextBox();
            this.fUNCIONARIO_NASCIMENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fUNCIONARIO_PISMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fUNCIONARIO_TELEFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fUNCIONARIO_EMAILTextBox = new System.Windows.Forms.TextBox();
            this.fUNCIONARIO_ENDERECOTextBox = new System.Windows.Forms.TextBox();
            this.fUNCIONARIO_BAIRROTextBox = new System.Windows.Forms.TextBox();
            this.fUNCIONARIO_CEPTextBox = new System.Windows.Forms.TextBox();
            this.fUNCIONARIO_FUNCAOTextBox = new System.Windows.Forms.TextBox();
            this.fUNCIONARIO_SETORTextBox = new System.Windows.Forms.TextBox();
            this.fUNCIONARIO_ADMISSAODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fUNCIONARIO_DATA_CADASTROLabel2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textSalario = new WindowsFormsApplication2.Monetario();
            this.panel1 = new System.Windows.Forms.Panel();
            fUNCIONARIO_CODIGOLabel = new System.Windows.Forms.Label();
            fUNCIONARIO_NOMELabel = new System.Windows.Forms.Label();
            fUNCIONARIO_CPFLabel = new System.Windows.Forms.Label();
            fUNCIONARIO_RGLabel = new System.Windows.Forms.Label();
            fUNCIONARIO_NASCIMENTOLabel = new System.Windows.Forms.Label();
            fUNCIONARIO_PISLabel = new System.Windows.Forms.Label();
            fUNCIONARIO_TELEFONELabel = new System.Windows.Forms.Label();
            fUNCIONARIO_EMAILLabel = new System.Windows.Forms.Label();
            fUNCIONARIO_ENDERECOLabel = new System.Windows.Forms.Label();
            fUNCIONARIO_BAIRROLabel = new System.Windows.Forms.Label();
            fUNCIONARIO_CEPLabel = new System.Windows.Forms.Label();
            fUNCIONARIO_FUNCAOLabel = new System.Windows.Forms.Label();
            fUNCIONARIO_SETORLabel = new System.Windows.Forms.Label();
            fUNCIONARIO_SALARIOLabel = new System.Windows.Forms.Label();
            fUNCIONARIO_ADMISSAOLabel = new System.Windows.Forms.Label();
            fUNCIONARIO_DATA_CADASTROLabel = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panelCodigo.SuspendLayout();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCadastro
            // 
            this.labelCadastro.Size = new System.Drawing.Size(293, 72);
            this.labelCadastro.Text = "Funcionário";
            // 
            // panelCodigo
            // 
            this.panelCodigo.Controls.Add(this.fUNCIONARIO_DATA_CADASTROLabel2);
            this.panelCodigo.Controls.Add(this.fUNCIONARIO_CODIGOLabel1);
            this.panelCodigo.Controls.Add(fUNCIONARIO_CODIGOLabel);
            this.panelCodigo.Controls.Add(fUNCIONARIO_DATA_CADASTROLabel);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.panel1);
            this.panelCentro.Controls.Add(this.groupBox5);
            this.panelCentro.Controls.Add(this.groupBox4);
            this.panelCentro.Controls.Add(this.groupBox3);
            this.panelCentro.Controls.Add(this.groupBox2);
            this.panelCentro.Controls.Add(this.groupBox1);
            // 
            // fUNCIONARIO_CODIGOLabel
            // 
            fUNCIONARIO_CODIGOLabel.AutoSize = true;
            fUNCIONARIO_CODIGOLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            fUNCIONARIO_CODIGOLabel.Location = new System.Drawing.Point(29, 8);
            fUNCIONARIO_CODIGOLabel.Name = "fUNCIONARIO_CODIGOLabel";
            fUNCIONARIO_CODIGOLabel.Size = new System.Drawing.Size(72, 25);
            fUNCIONARIO_CODIGOLabel.TabIndex = 0;
            fUNCIONARIO_CODIGOLabel.Text = "Código";
            // 
            // fUNCIONARIO_NOMELabel
            // 
            fUNCIONARIO_NOMELabel.AutoSize = true;
            fUNCIONARIO_NOMELabel.Location = new System.Drawing.Point(15, 35);
            fUNCIONARIO_NOMELabel.Name = "fUNCIONARIO_NOMELabel";
            fUNCIONARIO_NOMELabel.Size = new System.Drawing.Size(62, 25);
            fUNCIONARIO_NOMELabel.TabIndex = 2;
            fUNCIONARIO_NOMELabel.Text = "Nome";
            // 
            // fUNCIONARIO_CPFLabel
            // 
            fUNCIONARIO_CPFLabel.AutoSize = true;
            fUNCIONARIO_CPFLabel.Location = new System.Drawing.Point(6, 105);
            fUNCIONARIO_CPFLabel.Name = "fUNCIONARIO_CPFLabel";
            fUNCIONARIO_CPFLabel.Size = new System.Drawing.Size(43, 25);
            fUNCIONARIO_CPFLabel.TabIndex = 4;
            fUNCIONARIO_CPFLabel.Text = "CPF";
            // 
            // fUNCIONARIO_RGLabel
            // 
            fUNCIONARIO_RGLabel.AutoSize = true;
            fUNCIONARIO_RGLabel.Location = new System.Drawing.Point(9, 160);
            fUNCIONARIO_RGLabel.Name = "fUNCIONARIO_RGLabel";
            fUNCIONARIO_RGLabel.Size = new System.Drawing.Size(36, 25);
            fUNCIONARIO_RGLabel.TabIndex = 6;
            fUNCIONARIO_RGLabel.Text = "RG";
            // 
            // fUNCIONARIO_NASCIMENTOLabel
            // 
            fUNCIONARIO_NASCIMENTOLabel.AutoSize = true;
            fUNCIONARIO_NASCIMENTOLabel.Location = new System.Drawing.Point(15, 75);
            fUNCIONARIO_NASCIMENTOLabel.Name = "fUNCIONARIO_NASCIMENTOLabel";
            fUNCIONARIO_NASCIMENTOLabel.Size = new System.Drawing.Size(171, 25);
            fUNCIONARIO_NASCIMENTOLabel.TabIndex = 8;
            fUNCIONARIO_NASCIMENTOLabel.Text = "Data de nascimento";
            // 
            // fUNCIONARIO_PISLabel
            // 
            fUNCIONARIO_PISLabel.AutoSize = true;
            fUNCIONARIO_PISLabel.Location = new System.Drawing.Point(10, 215);
            fUNCIONARIO_PISLabel.Name = "fUNCIONARIO_PISLabel";
            fUNCIONARIO_PISLabel.Size = new System.Drawing.Size(35, 25);
            fUNCIONARIO_PISLabel.TabIndex = 10;
            fUNCIONARIO_PISLabel.Text = "PIS";
            // 
            // fUNCIONARIO_TELEFONELabel
            // 
            fUNCIONARIO_TELEFONELabel.AutoSize = true;
            fUNCIONARIO_TELEFONELabel.Location = new System.Drawing.Point(15, 36);
            fUNCIONARIO_TELEFONELabel.Name = "fUNCIONARIO_TELEFONELabel";
            fUNCIONARIO_TELEFONELabel.Size = new System.Drawing.Size(82, 25);
            fUNCIONARIO_TELEFONELabel.TabIndex = 12;
            fUNCIONARIO_TELEFONELabel.Text = "Telefone";
            // 
            // fUNCIONARIO_EMAILLabel
            // 
            fUNCIONARIO_EMAILLabel.AutoSize = true;
            fUNCIONARIO_EMAILLabel.Location = new System.Drawing.Point(15, 75);
            fUNCIONARIO_EMAILLabel.Name = "fUNCIONARIO_EMAILLabel";
            fUNCIONARIO_EMAILLabel.Size = new System.Drawing.Size(55, 25);
            fUNCIONARIO_EMAILLabel.TabIndex = 14;
            fUNCIONARIO_EMAILLabel.Text = "Email";
            // 
            // fUNCIONARIO_ENDERECOLabel
            // 
            fUNCIONARIO_ENDERECOLabel.AutoSize = true;
            fUNCIONARIO_ENDERECOLabel.Location = new System.Drawing.Point(19, 114);
            fUNCIONARIO_ENDERECOLabel.Name = "fUNCIONARIO_ENDERECOLabel";
            fUNCIONARIO_ENDERECOLabel.Size = new System.Drawing.Size(88, 25);
            fUNCIONARIO_ENDERECOLabel.TabIndex = 16;
            fUNCIONARIO_ENDERECOLabel.Text = "Endereço";
            // 
            // fUNCIONARIO_BAIRROLabel
            // 
            fUNCIONARIO_BAIRROLabel.AutoSize = true;
            fUNCIONARIO_BAIRROLabel.Location = new System.Drawing.Point(19, 153);
            fUNCIONARIO_BAIRROLabel.Name = "fUNCIONARIO_BAIRROLabel";
            fUNCIONARIO_BAIRROLabel.Size = new System.Drawing.Size(58, 25);
            fUNCIONARIO_BAIRROLabel.TabIndex = 18;
            fUNCIONARIO_BAIRROLabel.Text = "Bairro";
            // 
            // fUNCIONARIO_CEPLabel
            // 
            fUNCIONARIO_CEPLabel.AutoSize = true;
            fUNCIONARIO_CEPLabel.Location = new System.Drawing.Point(19, 192);
            fUNCIONARIO_CEPLabel.Name = "fUNCIONARIO_CEPLabel";
            fUNCIONARIO_CEPLabel.Size = new System.Drawing.Size(44, 25);
            fUNCIONARIO_CEPLabel.TabIndex = 20;
            fUNCIONARIO_CEPLabel.Text = "CEP";
            // 
            // fUNCIONARIO_FUNCAOLabel
            // 
            fUNCIONARIO_FUNCAOLabel.AutoSize = true;
            fUNCIONARIO_FUNCAOLabel.Location = new System.Drawing.Point(20, 72);
            fUNCIONARIO_FUNCAOLabel.Name = "fUNCIONARIO_FUNCAOLabel";
            fUNCIONARIO_FUNCAOLabel.Size = new System.Drawing.Size(69, 25);
            fUNCIONARIO_FUNCAOLabel.TabIndex = 22;
            fUNCIONARIO_FUNCAOLabel.Text = "Função";
            // 
            // fUNCIONARIO_SETORLabel
            // 
            fUNCIONARIO_SETORLabel.AutoSize = true;
            fUNCIONARIO_SETORLabel.Location = new System.Drawing.Point(20, 111);
            fUNCIONARIO_SETORLabel.Name = "fUNCIONARIO_SETORLabel";
            fUNCIONARIO_SETORLabel.Size = new System.Drawing.Size(54, 25);
            fUNCIONARIO_SETORLabel.TabIndex = 24;
            fUNCIONARIO_SETORLabel.Text = "Setor";
            // 
            // fUNCIONARIO_SALARIOLabel
            // 
            fUNCIONARIO_SALARIOLabel.AutoSize = true;
            fUNCIONARIO_SALARIOLabel.Location = new System.Drawing.Point(20, 153);
            fUNCIONARIO_SALARIOLabel.Name = "fUNCIONARIO_SALARIOLabel";
            fUNCIONARIO_SALARIOLabel.Size = new System.Drawing.Size(64, 25);
            fUNCIONARIO_SALARIOLabel.TabIndex = 26;
            fUNCIONARIO_SALARIOLabel.Text = "Salário";
            // 
            // fUNCIONARIO_ADMISSAOLabel
            // 
            fUNCIONARIO_ADMISSAOLabel.AutoSize = true;
            fUNCIONARIO_ADMISSAOLabel.Location = new System.Drawing.Point(20, 197);
            fUNCIONARIO_ADMISSAOLabel.Name = "fUNCIONARIO_ADMISSAOLabel";
            fUNCIONARIO_ADMISSAOLabel.Size = new System.Drawing.Size(154, 25);
            fUNCIONARIO_ADMISSAOLabel.TabIndex = 28;
            fUNCIONARIO_ADMISSAOLabel.Text = "Data de admissão";
            // 
            // fUNCIONARIO_DATA_CADASTROLabel
            // 
            fUNCIONARIO_DATA_CADASTROLabel.AutoSize = true;
            fUNCIONARIO_DATA_CADASTROLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            fUNCIONARIO_DATA_CADASTROLabel.Location = new System.Drawing.Point(29, 41);
            fUNCIONARIO_DATA_CADASTROLabel.Name = "fUNCIONARIO_DATA_CADASTROLabel";
            fUNCIONARIO_DATA_CADASTROLabel.Size = new System.Drawing.Size(49, 25);
            fUNCIONARIO_DATA_CADASTROLabel.TabIndex = 32;
            fUNCIONARIO_DATA_CADASTROLabel.Text = "Data";
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsFuncionario
            // 
            this.bsFuncionario.DataMember = "FUNCIONARIO";
            this.bsFuncionario.DataSource = this.dsFROGIOS;
            // 
            // taFuncionario
            // 
            this.taFuncionario.ClearBeforeFill = true;
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
            this.tableAdapterManager.FORNECEDOR_FISICOTableAdapter = null;
            this.tableAdapterManager.FORNECEDOR_JURIDICOTableAdapter = null;
            this.tableAdapterManager.FORNECEDORTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOTableAdapter = this.taFuncionario;
            this.tableAdapterManager.GRUPOTableAdapter = null;
            this.tableAdapterManager.ITEM_COMPRATableAdapter = null;
            this.tableAdapterManager.MARCATableAdapter = null;
            this.tableAdapterManager.ORCAMENTO_ITEMTableAdapter = null;
            this.tableAdapterManager.ORCAMENTO_SERVICOTableAdapter = null;
            this.tableAdapterManager.ORCAMENTOTableAdapter = null;
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
            // fUNCIONARIO_CODIGOLabel1
            // 
            this.fUNCIONARIO_CODIGOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "FUNCIONARIO_CODIGO", true));
            this.fUNCIONARIO_CODIGOLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fUNCIONARIO_CODIGOLabel1.Location = new System.Drawing.Point(107, 8);
            this.fUNCIONARIO_CODIGOLabel1.Name = "fUNCIONARIO_CODIGOLabel1";
            this.fUNCIONARIO_CODIGOLabel1.Size = new System.Drawing.Size(200, 23);
            this.fUNCIONARIO_CODIGOLabel1.TabIndex = 1;
            this.fUNCIONARIO_CODIGOLabel1.Text = "Código";
            // 
            // fUNCIONARIO_NOMETextBox
            // 
            this.fUNCIONARIO_NOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "FUNCIONARIO_NOME", true));
            this.fUNCIONARIO_NOMETextBox.Location = new System.Drawing.Point(83, 32);
            this.fUNCIONARIO_NOMETextBox.MaxLength = 60;
            this.fUNCIONARIO_NOMETextBox.Name = "fUNCIONARIO_NOMETextBox";
            this.fUNCIONARIO_NOMETextBox.Size = new System.Drawing.Size(495, 33);
            this.fUNCIONARIO_NOMETextBox.TabIndex = 0;
            // 
            // fUNCIONARIO_CPFMaskedTextBox
            // 
            this.fUNCIONARIO_CPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "FUNCIONARIO_CPF", true));
            this.fUNCIONARIO_CPFMaskedTextBox.Location = new System.Drawing.Point(89, 105);
            this.fUNCIONARIO_CPFMaskedTextBox.Mask = "###.###.###-##";
            this.fUNCIONARIO_CPFMaskedTextBox.Name = "fUNCIONARIO_CPFMaskedTextBox";
            this.fUNCIONARIO_CPFMaskedTextBox.Size = new System.Drawing.Size(200, 33);
            this.fUNCIONARIO_CPFMaskedTextBox.TabIndex = 4;
            // 
            // fUNCIONARIO_RGTextBox
            // 
            this.fUNCIONARIO_RGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "FUNCIONARIO_RG", true));
            this.fUNCIONARIO_RGTextBox.Location = new System.Drawing.Point(89, 157);
            this.fUNCIONARIO_RGTextBox.MaxLength = 10;
            this.fUNCIONARIO_RGTextBox.Name = "fUNCIONARIO_RGTextBox";
            this.fUNCIONARIO_RGTextBox.Size = new System.Drawing.Size(200, 33);
            this.fUNCIONARIO_RGTextBox.TabIndex = 5;
            // 
            // fUNCIONARIO_NASCIMENTODateTimePicker
            // 
            this.fUNCIONARIO_NASCIMENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsFuncionario, "FUNCIONARIO_NASCIMENTO", true));
            this.fUNCIONARIO_NASCIMENTODateTimePicker.Location = new System.Drawing.Point(20, 111);
            this.fUNCIONARIO_NASCIMENTODateTimePicker.Name = "fUNCIONARIO_NASCIMENTODateTimePicker";
            this.fUNCIONARIO_NASCIMENTODateTimePicker.Size = new System.Drawing.Size(558, 33);
            this.fUNCIONARIO_NASCIMENTODateTimePicker.TabIndex = 1;
            // 
            // fUNCIONARIO_PISMaskedTextBox
            // 
            this.fUNCIONARIO_PISMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "FUNCIONARIO_PIS", true));
            this.fUNCIONARIO_PISMaskedTextBox.Location = new System.Drawing.Point(89, 212);
            this.fUNCIONARIO_PISMaskedTextBox.Mask = "###.#####.##-#";
            this.fUNCIONARIO_PISMaskedTextBox.Name = "fUNCIONARIO_PISMaskedTextBox";
            this.fUNCIONARIO_PISMaskedTextBox.Size = new System.Drawing.Size(200, 33);
            this.fUNCIONARIO_PISMaskedTextBox.TabIndex = 6;
            // 
            // fUNCIONARIO_TELEFONEMaskedTextBox
            // 
            this.fUNCIONARIO_TELEFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "FUNCIONARIO_TELEFONE", true));
            this.fUNCIONARIO_TELEFONEMaskedTextBox.Location = new System.Drawing.Point(127, 33);
            this.fUNCIONARIO_TELEFONEMaskedTextBox.Mask = "(##)####-####";
            this.fUNCIONARIO_TELEFONEMaskedTextBox.Name = "fUNCIONARIO_TELEFONEMaskedTextBox";
            this.fUNCIONARIO_TELEFONEMaskedTextBox.Size = new System.Drawing.Size(169, 33);
            this.fUNCIONARIO_TELEFONEMaskedTextBox.TabIndex = 2;
            // 
            // fUNCIONARIO_EMAILTextBox
            // 
            this.fUNCIONARIO_EMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "FUNCIONARIO_EMAIL", true));
            this.fUNCIONARIO_EMAILTextBox.Location = new System.Drawing.Point(127, 72);
            this.fUNCIONARIO_EMAILTextBox.MaxLength = 60;
            this.fUNCIONARIO_EMAILTextBox.Name = "fUNCIONARIO_EMAILTextBox";
            this.fUNCIONARIO_EMAILTextBox.Size = new System.Drawing.Size(369, 33);
            this.fUNCIONARIO_EMAILTextBox.TabIndex = 3;
            // 
            // fUNCIONARIO_ENDERECOTextBox
            // 
            this.fUNCIONARIO_ENDERECOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "FUNCIONARIO_ENDERECO", true));
            this.fUNCIONARIO_ENDERECOTextBox.Location = new System.Drawing.Point(132, 111);
            this.fUNCIONARIO_ENDERECOTextBox.MaxLength = 120;
            this.fUNCIONARIO_ENDERECOTextBox.Name = "fUNCIONARIO_ENDERECOTextBox";
            this.fUNCIONARIO_ENDERECOTextBox.Size = new System.Drawing.Size(417, 33);
            this.fUNCIONARIO_ENDERECOTextBox.TabIndex = 7;
            // 
            // fUNCIONARIO_BAIRROTextBox
            // 
            this.fUNCIONARIO_BAIRROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "FUNCIONARIO_BAIRRO", true));
            this.fUNCIONARIO_BAIRROTextBox.Location = new System.Drawing.Point(132, 150);
            this.fUNCIONARIO_BAIRROTextBox.MaxLength = 60;
            this.fUNCIONARIO_BAIRROTextBox.Name = "fUNCIONARIO_BAIRROTextBox";
            this.fUNCIONARIO_BAIRROTextBox.Size = new System.Drawing.Size(417, 33);
            this.fUNCIONARIO_BAIRROTextBox.TabIndex = 8;
            // 
            // fUNCIONARIO_CEPTextBox
            // 
            this.fUNCIONARIO_CEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "FUNCIONARIO_CEP", true));
            this.fUNCIONARIO_CEPTextBox.Location = new System.Drawing.Point(132, 189);
            this.fUNCIONARIO_CEPTextBox.MaxLength = 9;
            this.fUNCIONARIO_CEPTextBox.Name = "fUNCIONARIO_CEPTextBox";
            this.fUNCIONARIO_CEPTextBox.Size = new System.Drawing.Size(245, 33);
            this.fUNCIONARIO_CEPTextBox.TabIndex = 9;
            // 
            // fUNCIONARIO_FUNCAOTextBox
            // 
            this.fUNCIONARIO_FUNCAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "FUNCIONARIO_FUNCAO", true));
            this.fUNCIONARIO_FUNCAOTextBox.Location = new System.Drawing.Point(117, 69);
            this.fUNCIONARIO_FUNCAOTextBox.MaxLength = 60;
            this.fUNCIONARIO_FUNCAOTextBox.Name = "fUNCIONARIO_FUNCAOTextBox";
            this.fUNCIONARIO_FUNCAOTextBox.Size = new System.Drawing.Size(409, 33);
            this.fUNCIONARIO_FUNCAOTextBox.TabIndex = 10;
            // 
            // fUNCIONARIO_SETORTextBox
            // 
            this.fUNCIONARIO_SETORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "FUNCIONARIO_SETOR", true));
            this.fUNCIONARIO_SETORTextBox.Location = new System.Drawing.Point(117, 111);
            this.fUNCIONARIO_SETORTextBox.MaxLength = 60;
            this.fUNCIONARIO_SETORTextBox.Name = "fUNCIONARIO_SETORTextBox";
            this.fUNCIONARIO_SETORTextBox.Size = new System.Drawing.Size(409, 33);
            this.fUNCIONARIO_SETORTextBox.TabIndex = 11;
            // 
            // fUNCIONARIO_ADMISSAODateTimePicker
            // 
            this.fUNCIONARIO_ADMISSAODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsFuncionario, "FUNCIONARIO_ADMISSAO", true));
            this.fUNCIONARIO_ADMISSAODateTimePicker.Location = new System.Drawing.Point(25, 225);
            this.fUNCIONARIO_ADMISSAODateTimePicker.Name = "fUNCIONARIO_ADMISSAODateTimePicker";
            this.fUNCIONARIO_ADMISSAODateTimePicker.Size = new System.Drawing.Size(501, 33);
            this.fUNCIONARIO_ADMISSAODateTimePicker.TabIndex = 13;
            // 
            // fUNCIONARIO_DATA_CADASTROLabel2
            // 
            this.fUNCIONARIO_DATA_CADASTROLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "FUNCIONARIO_DATA_CADASTRO", true));
            this.fUNCIONARIO_DATA_CADASTROLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fUNCIONARIO_DATA_CADASTROLabel2.Location = new System.Drawing.Point(107, 41);
            this.fUNCIONARIO_DATA_CADASTROLabel2.Name = "fUNCIONARIO_DATA_CADASTROLabel2";
            this.fUNCIONARIO_DATA_CADASTROLabel2.Size = new System.Drawing.Size(100, 23);
            this.fUNCIONARIO_DATA_CADASTROLabel2.TabIndex = 34;
            this.fUNCIONARIO_DATA_CADASTROLabel2.Text = "Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fUNCIONARIO_NOMETextBox);
            this.groupBox1.Controls.Add(fUNCIONARIO_NOMELabel);
            this.groupBox1.Controls.Add(this.fUNCIONARIO_NASCIMENTODateTimePicker);
            this.groupBox1.Controls.Add(fUNCIONARIO_NASCIMENTOLabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pessoal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(fUNCIONARIO_CPFLabel);
            this.groupBox2.Controls.Add(this.fUNCIONARIO_PISMaskedTextBox);
            this.groupBox2.Controls.Add(fUNCIONARIO_PISLabel);
            this.groupBox2.Controls.Add(this.fUNCIONARIO_CPFMaskedTextBox);
            this.groupBox2.Controls.Add(this.fUNCIONARIO_RGTextBox);
            this.groupBox2.Controls.Add(fUNCIONARIO_RGLabel);
            this.groupBox2.Location = new System.Drawing.Point(649, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 305);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documentos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fUNCIONARIO_TELEFONEMaskedTextBox);
            this.groupBox3.Controls.Add(this.fUNCIONARIO_EMAILTextBox);
            this.groupBox3.Controls.Add(fUNCIONARIO_EMAILLabel);
            this.groupBox3.Controls.Add(fUNCIONARIO_TELEFONELabel);
            this.groupBox3.Location = new System.Drawing.Point(24, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fUNCIONARIO_ENDERECOTextBox);
            this.groupBox4.Controls.Add(this.fUNCIONARIO_CEPTextBox);
            this.groupBox4.Controls.Add(fUNCIONARIO_CEPLabel);
            this.groupBox4.Controls.Add(this.fUNCIONARIO_BAIRROTextBox);
            this.groupBox4.Controls.Add(fUNCIONARIO_ENDERECOLabel);
            this.groupBox4.Controls.Add(fUNCIONARIO_BAIRROLabel);
            this.groupBox4.Location = new System.Drawing.Point(994, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(565, 302);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Domiciliar";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textSalario);
            this.groupBox5.Controls.Add(this.fUNCIONARIO_ADMISSAODateTimePicker);
            this.groupBox5.Controls.Add(fUNCIONARIO_ADMISSAOLabel);
            this.groupBox5.Controls.Add(fUNCIONARIO_FUNCAOLabel);
            this.groupBox5.Controls.Add(fUNCIONARIO_SALARIOLabel);
            this.groupBox5.Controls.Add(this.fUNCIONARIO_FUNCAOTextBox);
            this.groupBox5.Controls.Add(this.fUNCIONARIO_SETORTextBox);
            this.groupBox5.Controls.Add(fUNCIONARIO_SETORLabel);
            this.groupBox5.Location = new System.Drawing.Point(1583, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(547, 302);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Empresa";
            // 
            // textSalario
            // 
            this.textSalario.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsFuncionario, "FUNCIONARIO_SALARIO", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textSalario.Location = new System.Drawing.Point(117, 153);
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(210, 33);
            this.textSalario.TabIndex = 29;
            this.textSalario.Text = "R$ 0,00";
            this.textSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textSalario.Valor = 0D;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2174, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 100);
            this.panel1.TabIndex = 37;
            // 
            // formCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Name = "formCadastroFuncionario";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsFuncionario;
        private dsFROGIOSTableAdapters.FUNCIONARIOTableAdapter taFuncionario;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label fUNCIONARIO_CODIGOLabel1;
        private System.Windows.Forms.TextBox fUNCIONARIO_NOMETextBox;
        private System.Windows.Forms.MaskedTextBox fUNCIONARIO_CPFMaskedTextBox;
        private System.Windows.Forms.TextBox fUNCIONARIO_RGTextBox;
        private System.Windows.Forms.DateTimePicker fUNCIONARIO_NASCIMENTODateTimePicker;
        private System.Windows.Forms.MaskedTextBox fUNCIONARIO_PISMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox fUNCIONARIO_TELEFONEMaskedTextBox;
        private System.Windows.Forms.TextBox fUNCIONARIO_EMAILTextBox;
        private System.Windows.Forms.TextBox fUNCIONARIO_ENDERECOTextBox;
        private System.Windows.Forms.TextBox fUNCIONARIO_BAIRROTextBox;
        private System.Windows.Forms.TextBox fUNCIONARIO_CEPTextBox;
        private System.Windows.Forms.TextBox fUNCIONARIO_FUNCAOTextBox;
        private System.Windows.Forms.TextBox fUNCIONARIO_SETORTextBox;
        private System.Windows.Forms.DateTimePicker fUNCIONARIO_ADMISSAODateTimePicker;
        private System.Windows.Forms.Label fUNCIONARIO_DATA_CADASTROLabel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private WindowsFormsApplication2.Monetario textSalario;


    }
}