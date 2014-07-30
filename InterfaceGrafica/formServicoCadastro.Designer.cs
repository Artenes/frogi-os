namespace FROGI_OS
{
    partial class formServicoCadastro
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
            System.Windows.Forms.Label sERVICO_DESCRICAOLabel;
            System.Windows.Forms.Label sERVICO_VALORLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureEditar = new System.Windows.Forms.PictureBox();
            this.pictureExcluir = new System.Windows.Forms.PictureBox();
            this.pictureSalvar = new System.Windows.Forms.PictureBox();
            this.picturePesquisar = new System.Windows.Forms.PictureBox();
            this.pictureNovo = new System.Windows.Forms.PictureBox();
            this.labelCodigoLabel = new System.Windows.Forms.Label();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.bsServico = new System.Windows.Forms.BindingSource(this.components);
            this.taServico = new FROGI_OS.dsFROGIOSTableAdapters.SERVICOTableAdapter();
            this.taManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.sERVICO_CODIGOLabel1 = new System.Windows.Forms.Label();
            this.sERVICO_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.sERVICO_VALORTextBox = new System.Windows.Forms.TextBox();
            this.panelCodigo = new System.Windows.Forms.Panel();
            this.bsTipo = new System.Windows.Forms.BindingSource(this.components);
            this.taTipo = new FROGI_OS.dsFROGIOSTableAdapters.TIPOTableAdapter();
            this.dgvTipo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            sERVICO_DESCRICAOLabel = new System.Windows.Forms.Label();
            sERVICO_VALORLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovo)).BeginInit();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServico)).BeginInit();
            this.panelCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelCampos, 0, 1);
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
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureFechar);
            this.panel1.Controls.Add(this.label1);
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
            this.pictureFechar.Location = new System.Drawing.Point(966, 12);
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
            this.label1.Size = new System.Drawing.Size(212, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serviços";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panelCodigo);
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
            this.pictureEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureEditar.Image = global::FROGI_OS.Properties.Resources.icone_editar;
            this.pictureEditar.Location = new System.Drawing.Point(756, 8);
            this.pictureEditar.Name = "pictureEditar";
            this.pictureEditar.Size = new System.Drawing.Size(64, 64);
            this.pictureEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEditar.TabIndex = 10;
            this.pictureEditar.TabStop = false;
            this.pictureEditar.Click += new System.EventHandler(this.pictureEditar_Click);
            // 
            // pictureExcluir
            // 
            this.pictureExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureExcluir.Image = global::FROGI_OS.Properties.Resources.icone_excluir;
            this.pictureExcluir.Location = new System.Drawing.Point(826, 8);
            this.pictureExcluir.Name = "pictureExcluir";
            this.pictureExcluir.Size = new System.Drawing.Size(64, 64);
            this.pictureExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExcluir.TabIndex = 9;
            this.pictureExcluir.TabStop = false;
            this.pictureExcluir.Click += new System.EventHandler(this.pictureExcluir_Click);
            // 
            // pictureSalvar
            // 
            this.pictureSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureSalvar.Image = global::FROGI_OS.Properties.Resources.icone_salvar;
            this.pictureSalvar.Location = new System.Drawing.Point(896, 8);
            this.pictureSalvar.Name = "pictureSalvar";
            this.pictureSalvar.Size = new System.Drawing.Size(64, 64);
            this.pictureSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSalvar.TabIndex = 8;
            this.pictureSalvar.TabStop = false;
            this.pictureSalvar.Click += new System.EventHandler(this.pictureSalvar_Click);
            // 
            // picturePesquisar
            // 
            this.picturePesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePesquisar.Image = global::FROGI_OS.Properties.Resources.icone_pesquisar;
            this.picturePesquisar.Location = new System.Drawing.Point(966, 8);
            this.picturePesquisar.Name = "picturePesquisar";
            this.picturePesquisar.Size = new System.Drawing.Size(64, 64);
            this.picturePesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePesquisar.TabIndex = 7;
            this.picturePesquisar.TabStop = false;
            this.picturePesquisar.Click += new System.EventHandler(this.picturePesquisar_Click);
            // 
            // pictureNovo
            // 
            this.pictureNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureNovo.Image = global::FROGI_OS.Properties.Resources.icone_novo;
            this.pictureNovo.Location = new System.Drawing.Point(686, 8);
            this.pictureNovo.Name = "pictureNovo";
            this.pictureNovo.Size = new System.Drawing.Size(64, 64);
            this.pictureNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNovo.TabIndex = 6;
            this.pictureNovo.TabStop = false;
            this.pictureNovo.Click += new System.EventHandler(this.pictureNovo_Click);
            // 
            // labelCodigoLabel
            // 
            this.labelCodigoLabel.AutoSize = true;
            this.labelCodigoLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.labelCodigoLabel.ForeColor = System.Drawing.Color.White;
            this.labelCodigoLabel.Location = new System.Drawing.Point(3, 5);
            this.labelCodigoLabel.Name = "labelCodigoLabel";
            this.labelCodigoLabel.Size = new System.Drawing.Size(106, 37);
            this.labelCodigoLabel.TabIndex = 2;
            this.labelCodigoLabel.Text = "Código:";
            // 
            // panelCampos
            // 
            this.panelCampos.AutoScroll = true;
            this.panelCampos.AutoSize = true;
            this.panelCampos.Controls.Add(this.buttonNovo);
            this.panelCampos.Controls.Add(this.buttonAdicionar);
            this.panelCampos.Controls.Add(this.dgvTipo);
            this.panelCampos.Controls.Add(sERVICO_DESCRICAOLabel);
            this.panelCampos.Controls.Add(this.sERVICO_DESCRICAOTextBox);
            this.panelCampos.Controls.Add(sERVICO_VALORLabel);
            this.panelCampos.Controls.Add(this.sERVICO_VALORTextBox);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCampos.Location = new System.Drawing.Point(0, 80);
            this.panelCampos.Margin = new System.Windows.Forms.Padding(0);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(1036, 375);
            this.panelCampos.TabIndex = 2;
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsServico
            // 
            this.bsServico.DataMember = "SERVICO";
            this.bsServico.DataSource = this.dsFROGIOS;
            // 
            // taServico
            // 
            this.taServico.ClearBeforeFill = true;
            // 
            // taManager
            // 
            this.taManager.BackupDataSetBeforeUpdate = false;
            this.taManager.CATEGORIATableAdapter = null;
            this.taManager.CLIENTE_FISICOTableAdapter = null;
            this.taManager.CLIENTE_JURIDICOTableAdapter = null;
            this.taManager.CLIENTETableAdapter = null;
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
            this.taManager.SERVICOTableAdapter = this.taServico;
            this.taManager.TIPOTableAdapter = this.taTipo;
            this.taManager.UFTableAdapter = null;
            this.taManager.UpdateOrder = FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.taManager.USUARIOTableAdapter = null;
            // 
            // sERVICO_CODIGOLabel1
            // 
            this.sERVICO_CODIGOLabel1.AutoSize = true;
            this.sERVICO_CODIGOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsServico, "SERVICO_CODIGO", true));
            this.sERVICO_CODIGOLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sERVICO_CODIGOLabel1.Location = new System.Drawing.Point(112, 15);
            this.sERVICO_CODIGOLabel1.Name = "sERVICO_CODIGOLabel1";
            this.sERVICO_CODIGOLabel1.Size = new System.Drawing.Size(72, 25);
            this.sERVICO_CODIGOLabel1.TabIndex = 1;
            this.sERVICO_CODIGOLabel1.Text = "Código";
            // 
            // sERVICO_DESCRICAOLabel
            // 
            sERVICO_DESCRICAOLabel.AutoSize = true;
            sERVICO_DESCRICAOLabel.Location = new System.Drawing.Point(27, 124);
            sERVICO_DESCRICAOLabel.Name = "sERVICO_DESCRICAOLabel";
            sERVICO_DESCRICAOLabel.Size = new System.Drawing.Size(88, 25);
            sERVICO_DESCRICAOLabel.TabIndex = 2;
            sERVICO_DESCRICAOLabel.Text = "Descrição";
            // 
            // sERVICO_DESCRICAOTextBox
            // 
            this.sERVICO_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsServico, "SERVICO_DESCRICAO", true));
            this.sERVICO_DESCRICAOTextBox.Location = new System.Drawing.Point(32, 152);
            this.sERVICO_DESCRICAOTextBox.Name = "sERVICO_DESCRICAOTextBox";
            this.sERVICO_DESCRICAOTextBox.Size = new System.Drawing.Size(438, 33);
            this.sERVICO_DESCRICAOTextBox.TabIndex = 3;
            // 
            // sERVICO_VALORLabel
            // 
            sERVICO_VALORLabel.AutoSize = true;
            sERVICO_VALORLabel.Location = new System.Drawing.Point(27, 188);
            sERVICO_VALORLabel.Name = "sERVICO_VALORLabel";
            sERVICO_VALORLabel.Size = new System.Drawing.Size(53, 25);
            sERVICO_VALORLabel.TabIndex = 4;
            sERVICO_VALORLabel.Text = "Valor";
            // 
            // sERVICO_VALORTextBox
            // 
            this.sERVICO_VALORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsServico, "SERVICO_VALOR", true));
            this.sERVICO_VALORTextBox.Location = new System.Drawing.Point(32, 216);
            this.sERVICO_VALORTextBox.Name = "sERVICO_VALORTextBox";
            this.sERVICO_VALORTextBox.Size = new System.Drawing.Size(438, 33);
            this.sERVICO_VALORTextBox.TabIndex = 5;
            // 
            // panelCodigo
            // 
            this.panelCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCodigo.Controls.Add(this.labelCodigoLabel);
            this.panelCodigo.Controls.Add(this.sERVICO_CODIGOLabel1);
            this.panelCodigo.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelCodigo.Location = new System.Drawing.Point(3, 3);
            this.panelCodigo.Name = "panelCodigo";
            this.panelCodigo.Size = new System.Drawing.Size(297, 76);
            this.panelCodigo.TabIndex = 11;
            // 
            // bsTipo
            // 
            this.bsTipo.DataMember = "TIPO";
            this.bsTipo.DataSource = this.dsFROGIOS;
            // 
            // taTipo
            // 
            this.taTipo.ClearBeforeFill = true;
            // 
            // dgvTipo
            // 
            this.dgvTipo.AllowUserToAddRows = false;
            this.dgvTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipo.AutoGenerateColumns = false;
            this.dgvTipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvTipo.DataSource = this.bsTipo;
            this.dgvTipo.Location = new System.Drawing.Point(509, 53);
            this.dgvTipo.Name = "dgvTipo";
            this.dgvTipo.ReadOnly = true;
            this.dgvTipo.Size = new System.Drawing.Size(505, 308);
            this.dgvTipo.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TIPO_CODIGO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TIPO_DESCRICAO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdicionar.AutoSize = true;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Location = new System.Drawing.Point(509, 10);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(99, 37);
            this.buttonAdicionar.TabIndex = 6;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNovo.AutoSize = true;
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovo.Location = new System.Drawing.Point(915, 10);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(99, 37);
            this.buttonNovo.TabIndex = 7;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            // 
            // formServicoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1036, 537);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formServicoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formClienteCadastro";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovo)).EndInit();
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServico)).EndInit();
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCodigoLabel;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.PictureBox pictureEditar;
        private System.Windows.Forms.PictureBox pictureExcluir;
        private System.Windows.Forms.PictureBox pictureSalvar;
        private System.Windows.Forms.PictureBox picturePesquisar;
        private System.Windows.Forms.PictureBox pictureNovo;
        private System.Windows.Forms.PictureBox pictureFechar;
        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsServico;
        private dsFROGIOSTableAdapters.SERVICOTableAdapter taServico;
        private dsFROGIOSTableAdapters.TableAdapterManager taManager;
        private System.Windows.Forms.Label sERVICO_CODIGOLabel1;
        private System.Windows.Forms.TextBox sERVICO_DESCRICAOTextBox;
        private System.Windows.Forms.TextBox sERVICO_VALORTextBox;
        private System.Windows.Forms.Panel panelCodigo;
        private dsFROGIOSTableAdapters.TIPOTableAdapter taTipo;
        private System.Windows.Forms.BindingSource bsTipo;
        private System.Windows.Forms.DataGridView dgvTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonAdicionar;

    }
}