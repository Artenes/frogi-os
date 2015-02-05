namespace FROGI_OS.InterfaceGrafica
{
    partial class formCadastroUsuario : formCadastro
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
            System.Windows.Forms.Label uSUARIO_CODIGOLabel;
            System.Windows.Forms.Label uSUARIO_NOMELabel;
            System.Windows.Forms.Label uSUARIO_SENHALabel;
            System.Windows.Forms.Label uSUARIO_DATA_CADASTROLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroUsuario));
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.bsUsuario = new System.Windows.Forms.BindingSource(this.components);
            this.taUsuario = new FROGI_OS.dsFROGIOSTableAdapters.USUARIOTableAdapter();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.uSUARIO_CODIGOLabel1 = new System.Windows.Forms.Label();
            this.uSUARIO_NOMETextBox = new System.Windows.Forms.TextBox();
            this.uSUARIO_SENHATextBox = new System.Windows.Forms.TextBox();
            this.uSUARIO_DATA_CADASTROLabel1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAdministrador = new System.Windows.Forms.RadioButton();
            this.radioFuncionario = new System.Windows.Forms.RadioButton();
            uSUARIO_CODIGOLabel = new System.Windows.Forms.Label();
            uSUARIO_NOMELabel = new System.Windows.Forms.Label();
            uSUARIO_SENHALabel = new System.Windows.Forms.Label();
            uSUARIO_DATA_CADASTROLabel = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panelCodigo.SuspendLayout();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCadastro
            // 
            this.labelCadastro.Size = new System.Drawing.Size(201, 72);
            this.labelCadastro.Text = "Usuário";
            // 
            // panelCodigo
            // 
            this.panelCodigo.Controls.Add(uSUARIO_CODIGOLabel);
            this.panelCodigo.Controls.Add(this.uSUARIO_CODIGOLabel1);
            this.panelCodigo.Controls.Add(this.uSUARIO_DATA_CADASTROLabel1);
            this.panelCodigo.Controls.Add(uSUARIO_DATA_CADASTROLabel);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.groupBox1);
            // 
            // uSUARIO_CODIGOLabel
            // 
            uSUARIO_CODIGOLabel.AutoSize = true;
            uSUARIO_CODIGOLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            uSUARIO_CODIGOLabel.Location = new System.Drawing.Point(26, 8);
            uSUARIO_CODIGOLabel.Name = "uSUARIO_CODIGOLabel";
            uSUARIO_CODIGOLabel.Size = new System.Drawing.Size(72, 25);
            uSUARIO_CODIGOLabel.TabIndex = 0;
            uSUARIO_CODIGOLabel.Text = "Código";
            // 
            // uSUARIO_NOMELabel
            // 
            uSUARIO_NOMELabel.AutoSize = true;
            uSUARIO_NOMELabel.Location = new System.Drawing.Point(13, 32);
            uSUARIO_NOMELabel.Name = "uSUARIO_NOMELabel";
            uSUARIO_NOMELabel.Size = new System.Drawing.Size(62, 25);
            uSUARIO_NOMELabel.TabIndex = 2;
            uSUARIO_NOMELabel.Text = "Nome";
            // 
            // uSUARIO_SENHALabel
            // 
            uSUARIO_SENHALabel.AutoSize = true;
            uSUARIO_SENHALabel.Location = new System.Drawing.Point(13, 73);
            uSUARIO_SENHALabel.Name = "uSUARIO_SENHALabel";
            uSUARIO_SENHALabel.Size = new System.Drawing.Size(60, 25);
            uSUARIO_SENHALabel.TabIndex = 4;
            uSUARIO_SENHALabel.Text = "Senha";
            // 
            // uSUARIO_DATA_CADASTROLabel
            // 
            uSUARIO_DATA_CADASTROLabel.AutoSize = true;
            uSUARIO_DATA_CADASTROLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            uSUARIO_DATA_CADASTROLabel.Location = new System.Drawing.Point(26, 41);
            uSUARIO_DATA_CADASTROLabel.Name = "uSUARIO_DATA_CADASTROLabel";
            uSUARIO_DATA_CADASTROLabel.Size = new System.Drawing.Size(49, 25);
            uSUARIO_DATA_CADASTROLabel.TabIndex = 6;
            uSUARIO_DATA_CADASTROLabel.Text = "Data";
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsUsuario
            // 
            this.bsUsuario.DataMember = "USUARIO";
            this.bsUsuario.DataSource = this.dsFROGIOS;
            // 
            // taUsuario
            // 
            this.taUsuario.ClearBeforeFill = true;
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
            this.tableAdapterManager.FUNCIONARIOTableAdapter = null;
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
            this.tableAdapterManager.USUARIOTableAdapter = this.taUsuario;
            // 
            // uSUARIO_CODIGOLabel1
            // 
            this.uSUARIO_CODIGOLabel1.AutoSize = true;
            this.uSUARIO_CODIGOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "USUARIO_CODIGO", true));
            this.uSUARIO_CODIGOLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uSUARIO_CODIGOLabel1.Location = new System.Drawing.Point(104, 8);
            this.uSUARIO_CODIGOLabel1.Name = "uSUARIO_CODIGOLabel1";
            this.uSUARIO_CODIGOLabel1.Size = new System.Drawing.Size(68, 25);
            this.uSUARIO_CODIGOLabel1.TabIndex = 1;
            this.uSUARIO_CODIGOLabel1.Text = "código";
            // 
            // uSUARIO_NOMETextBox
            // 
            this.uSUARIO_NOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "USUARIO_NOME", true));
            this.uSUARIO_NOMETextBox.Location = new System.Drawing.Point(89, 29);
            this.uSUARIO_NOMETextBox.MaxLength = 60;
            this.uSUARIO_NOMETextBox.Name = "uSUARIO_NOMETextBox";
            this.uSUARIO_NOMETextBox.Size = new System.Drawing.Size(420, 33);
            this.uSUARIO_NOMETextBox.TabIndex = 0;
            // 
            // uSUARIO_SENHATextBox
            // 
            this.uSUARIO_SENHATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "USUARIO_SENHA", true));
            this.uSUARIO_SENHATextBox.Location = new System.Drawing.Point(89, 70);
            this.uSUARIO_SENHATextBox.MaxLength = 10;
            this.uSUARIO_SENHATextBox.Name = "uSUARIO_SENHATextBox";
            this.uSUARIO_SENHATextBox.PasswordChar = '*';
            this.uSUARIO_SENHATextBox.Size = new System.Drawing.Size(173, 33);
            this.uSUARIO_SENHATextBox.TabIndex = 1;
            // 
            // uSUARIO_DATA_CADASTROLabel1
            // 
            this.uSUARIO_DATA_CADASTROLabel1.AutoSize = true;
            this.uSUARIO_DATA_CADASTROLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "USUARIO_DATA_CADASTRO", true));
            this.uSUARIO_DATA_CADASTROLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uSUARIO_DATA_CADASTROLabel1.Location = new System.Drawing.Point(104, 41);
            this.uSUARIO_DATA_CADASTROLabel1.Name = "uSUARIO_DATA_CADASTROLabel1";
            this.uSUARIO_DATA_CADASTROLabel1.Size = new System.Drawing.Size(47, 25);
            this.uSUARIO_DATA_CADASTROLabel1.TabIndex = 7;
            this.uSUARIO_DATA_CADASTROLabel1.Text = "data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAdministrador);
            this.groupBox1.Controls.Add(this.radioFuncionario);
            this.groupBox1.Controls.Add(uSUARIO_NOMELabel);
            this.groupBox1.Controls.Add(this.uSUARIO_SENHATextBox);
            this.groupBox1.Controls.Add(this.uSUARIO_NOMETextBox);
            this.groupBox1.Controls.Add(uSUARIO_SENHALabel);
            this.groupBox1.Location = new System.Drawing.Point(31, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioAdministrador
            // 
            this.radioAdministrador.AutoSize = true;
            this.radioAdministrador.Location = new System.Drawing.Point(164, 121);
            this.radioAdministrador.Name = "radioAdministrador";
            this.radioAdministrador.Size = new System.Drawing.Size(143, 29);
            this.radioAdministrador.TabIndex = 6;
            this.radioAdministrador.TabStop = true;
            this.radioAdministrador.Text = "Administrador";
            this.radioAdministrador.UseVisualStyleBackColor = true;
            // 
            // radioFuncionario
            // 
            this.radioFuncionario.AutoSize = true;
            this.radioFuncionario.Location = new System.Drawing.Point(18, 121);
            this.radioFuncionario.Name = "radioFuncionario";
            this.radioFuncionario.Size = new System.Drawing.Size(122, 29);
            this.radioFuncionario.TabIndex = 5;
            this.radioFuncionario.TabStop = true;
            this.radioFuncionario.Text = "Funcionário";
            this.radioFuncionario.UseVisualStyleBackColor = true;
            // 
            // formCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCadastroUsuario";
            this.Text = "Usuários";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsUsuario;
        private dsFROGIOSTableAdapters.USUARIOTableAdapter taUsuario;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label uSUARIO_CODIGOLabel1;
        private System.Windows.Forms.TextBox uSUARIO_NOMETextBox;
        private System.Windows.Forms.TextBox uSUARIO_SENHATextBox;
        private System.Windows.Forms.Label uSUARIO_DATA_CADASTROLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioAdministrador;
        private System.Windows.Forms.RadioButton radioFuncionario;
    }
}