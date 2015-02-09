namespace FROGI_OS.InterfaceGrafica
{
    partial class formCadastroServico
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
            System.Windows.Forms.Label sERVICO_CODIGOLabel;
            System.Windows.Forms.Label sERVICO_DESCRICAOLabel;
            System.Windows.Forms.Label sERVICO_VALORLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroServico));
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.bsServico = new System.Windows.Forms.BindingSource(this.components);
            this.taServico = new FROGI_OS.dsFROGIOSTableAdapters.SERVICOTableAdapter();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.taTipo = new FROGI_OS.dsFROGIOSTableAdapters.TIPOTableAdapter();
            this.sERVICO_CODIGOLabel1 = new System.Windows.Forms.Label();
            this.sERVICO_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textValor = new WindowsFormsApplication2.Monetario();
            this.bsTipo = new System.Windows.Forms.BindingSource(this.components);
            this.tIPODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAdicionarTipo = new System.Windows.Forms.Button();
            sERVICO_CODIGOLabel = new System.Windows.Forms.Label();
            sERVICO_DESCRICAOLabel = new System.Windows.Forms.Label();
            sERVICO_VALORLabel = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panelCodigo.SuspendLayout();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServico)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPODataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCadastro
            // 
            this.labelCadastro.Size = new System.Drawing.Size(191, 72);
            this.labelCadastro.Text = "Serviço";
            // 
            // panelCodigo
            // 
            this.panelCodigo.Controls.Add(sERVICO_CODIGOLabel);
            this.panelCodigo.Controls.Add(this.sERVICO_CODIGOLabel1);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.buttonAdicionarTipo);
            this.panelCentro.Controls.Add(this.groupBox2);
            this.panelCentro.Controls.Add(this.groupBox1);
            // 
            // sERVICO_CODIGOLabel
            // 
            sERVICO_CODIGOLabel.AutoSize = true;
            sERVICO_CODIGOLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            sERVICO_CODIGOLabel.Location = new System.Drawing.Point(23, 17);
            sERVICO_CODIGOLabel.Name = "sERVICO_CODIGOLabel";
            sERVICO_CODIGOLabel.Size = new System.Drawing.Size(72, 25);
            sERVICO_CODIGOLabel.TabIndex = 0;
            sERVICO_CODIGOLabel.Text = "Código";
            // 
            // sERVICO_DESCRICAOLabel
            // 
            sERVICO_DESCRICAOLabel.AutoSize = true;
            sERVICO_DESCRICAOLabel.Location = new System.Drawing.Point(16, 29);
            sERVICO_DESCRICAOLabel.Name = "sERVICO_DESCRICAOLabel";
            sERVICO_DESCRICAOLabel.Size = new System.Drawing.Size(88, 25);
            sERVICO_DESCRICAOLabel.TabIndex = 2;
            sERVICO_DESCRICAOLabel.Text = "Descrição";
            // 
            // sERVICO_VALORLabel
            // 
            sERVICO_VALORLabel.AutoSize = true;
            sERVICO_VALORLabel.Location = new System.Drawing.Point(16, 68);
            sERVICO_VALORLabel.Name = "sERVICO_VALORLabel";
            sERVICO_VALORLabel.Size = new System.Drawing.Size(53, 25);
            sERVICO_VALORLabel.TabIndex = 4;
            sERVICO_VALORLabel.Text = "Valor";
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
            this.tableAdapterManager.SERVICOTableAdapter = this.taServico;
            this.tableAdapterManager.TIPOTableAdapter = this.taTipo;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // taTipo
            // 
            this.taTipo.ClearBeforeFill = true;
            // 
            // sERVICO_CODIGOLabel1
            // 
            this.sERVICO_CODIGOLabel1.AutoSize = true;
            this.sERVICO_CODIGOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsServico, "SERVICO_CODIGO", true));
            this.sERVICO_CODIGOLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sERVICO_CODIGOLabel1.Location = new System.Drawing.Point(101, 17);
            this.sERVICO_CODIGOLabel1.Name = "sERVICO_CODIGOLabel1";
            this.sERVICO_CODIGOLabel1.Size = new System.Drawing.Size(68, 25);
            this.sERVICO_CODIGOLabel1.TabIndex = 1;
            this.sERVICO_CODIGOLabel1.Text = "código";
            // 
            // sERVICO_DESCRICAOTextBox
            // 
            this.sERVICO_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsServico, "SERVICO_DESCRICAO", true));
            this.sERVICO_DESCRICAOTextBox.Location = new System.Drawing.Point(110, 26);
            this.sERVICO_DESCRICAOTextBox.MaxLength = 60;
            this.sERVICO_DESCRICAOTextBox.Name = "sERVICO_DESCRICAOTextBox";
            this.sERVICO_DESCRICAOTextBox.Size = new System.Drawing.Size(401, 33);
            this.sERVICO_DESCRICAOTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textValor);
            this.groupBox1.Controls.Add(sERVICO_DESCRICAOLabel);
            this.groupBox1.Controls.Add(this.sERVICO_DESCRICAOTextBox);
            this.groupBox1.Controls.Add(sERVICO_VALORLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textValor
            // 
            this.textValor.DataBindings.Add(new System.Windows.Forms.Binding("Valor", this.bsServico, "SERVICO_VALOR", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textValor.Location = new System.Drawing.Point(110, 72);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(204, 33);
            this.textValor.TabIndex = 5;
            this.textValor.Text = "R$ 0,00";
            this.textValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textValor.Valor = 0D;
            // 
            // bsTipo
            // 
            this.bsTipo.DataMember = "TIPO";
            this.bsTipo.DataSource = this.dsFROGIOS;
            // 
            // tIPODataGridView
            // 
            this.tIPODataGridView.AllowUserToAddRows = false;
            this.tIPODataGridView.AutoGenerateColumns = false;
            this.tIPODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tIPODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tIPODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tIPODataGridView.DataSource = this.bsTipo;
            this.tIPODataGridView.Location = new System.Drawing.Point(13, 32);
            this.tIPODataGridView.Name = "tIPODataGridView";
            this.tIPODataGridView.ReadOnly = true;
            this.tIPODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tIPODataGridView.Size = new System.Drawing.Size(899, 137);
            this.tIPODataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TIPO_CODIGO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TIPO_DESCRICAO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tIPODataGridView);
            this.groupBox2.Location = new System.Drawing.Point(15, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(929, 183);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipos do serviço";
            // 
            // buttonAdicionarTipo
            // 
            this.buttonAdicionarTipo.AutoSize = true;
            this.buttonAdicionarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarTipo.Location = new System.Drawing.Point(791, 112);
            this.buttonAdicionarTipo.Name = "buttonAdicionarTipo";
            this.buttonAdicionarTipo.Size = new System.Drawing.Size(136, 37);
            this.buttonAdicionarTipo.TabIndex = 2;
            this.buttonAdicionarTipo.Text = "Adicionar tipo";
            this.buttonAdicionarTipo.UseVisualStyleBackColor = true;
            this.buttonAdicionarTipo.Click += new System.EventHandler(this.buttonAdicionarTipo_Click);
            // 
            // formCadastroServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCadastroServico";
            this.ShowInTaskbar = false;
            this.Text = "Serviços";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPODataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsServico;
        private dsFROGIOSTableAdapters.SERVICOTableAdapter taServico;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label sERVICO_CODIGOLabel1;
        private System.Windows.Forms.TextBox sERVICO_DESCRICAOTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private dsFROGIOSTableAdapters.TIPOTableAdapter taTipo;
        private System.Windows.Forms.BindingSource bsTipo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tIPODataGridView;
        private System.Windows.Forms.Button buttonAdicionarTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private WindowsFormsApplication2.Monetario textValor;
    }
}