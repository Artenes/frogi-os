namespace FROGI_OS.InterfaceGrafica
{
    partial class formPesquisaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPesquisaFornecedor));
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.tablessPai = new FROGI_OS.TablessControl();
            this.tabFisico = new System.Windows.Forms.TabPage();
            this.pESQUISA_FORNECEDOR_FISICODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFornecedorFisico = new System.Windows.Forms.BindingSource(this.components);
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.tabJuridico = new System.Windows.Forms.TabPage();
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFornecedorJuridico = new System.Windows.Forms.BindingSource(this.components);
            this.taPesquisaFornecedorFisico = new FROGI_OS.dsFROGIOSTableAdapters.taPesquisaFornecedorFisico();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.taPesquisaFornecedorJuridico = new FROGI_OS.dsFROGIOSTableAdapters.taPesquisaFornecedorJuridico();
            this.panelCabecalho.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.tablessPai.SuspendLayout();
            this.tabFisico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_FORNECEDOR_FISICODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFornecedorFisico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            this.tabJuridico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_FORNECEDOR_JURIDICODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFornecedorJuridico)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.Controls.Add(this.comboTipo);
            this.panelCabecalho.Controls.SetChildIndex(this.label1, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.labelPesquisa, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.comboCampoPesquisa, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.textValorPesquisa, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.buttonPesquisar, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.comboTipo, 0);
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.labelPesquisa.Location = new System.Drawing.Point(3, 14);
            this.labelPesquisa.Size = new System.Drawing.Size(182, 46);
            this.labelPesquisa.Text = "Fornecedor";
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.tablessPai);
            // 
            // comboCampoPesquisa
            // 
            this.comboCampoPesquisa.Location = new System.Drawing.Point(336, 27);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(801, 23);
            // 
            // textValorPesquisa
            // 
            this.textValorPesquisa.Location = new System.Drawing.Point(569, 27);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(539, 30);
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Físico",
            "Jurídico"});
            this.comboTipo.Location = new System.Drawing.Point(191, 27);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 33);
            this.comboTipo.TabIndex = 0;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // tablessPai
            // 
            this.tablessPai.Controls.Add(this.tabFisico);
            this.tablessPai.Controls.Add(this.tabJuridico);
            this.tablessPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablessPai.Location = new System.Drawing.Point(0, 0);
            this.tablessPai.Name = "tablessPai";
            this.tablessPai.SelectedIndex = 0;
            this.tablessPai.Size = new System.Drawing.Size(966, 343);
            this.tablessPai.TabIndex = 0;
            // 
            // tabFisico
            // 
            this.tabFisico.AutoScroll = true;
            this.tabFisico.BackColor = System.Drawing.Color.LightBlue;
            this.tabFisico.Controls.Add(this.pESQUISA_FORNECEDOR_FISICODataGridView);
            this.tabFisico.Location = new System.Drawing.Point(4, 34);
            this.tabFisico.Name = "tabFisico";
            this.tabFisico.Padding = new System.Windows.Forms.Padding(3);
            this.tabFisico.Size = new System.Drawing.Size(958, 305);
            this.tabFisico.TabIndex = 0;
            this.tabFisico.Text = "fisico";
            // 
            // pESQUISA_FORNECEDOR_FISICODataGridView
            // 
            this.pESQUISA_FORNECEDOR_FISICODataGridView.AllowUserToAddRows = false;
            this.pESQUISA_FORNECEDOR_FISICODataGridView.AllowUserToDeleteRows = false;
            this.pESQUISA_FORNECEDOR_FISICODataGridView.AutoGenerateColumns = false;
            this.pESQUISA_FORNECEDOR_FISICODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pESQUISA_FORNECEDOR_FISICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pESQUISA_FORNECEDOR_FISICODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.pESQUISA_FORNECEDOR_FISICODataGridView.DataSource = this.bsFornecedorFisico;
            this.pESQUISA_FORNECEDOR_FISICODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pESQUISA_FORNECEDOR_FISICODataGridView.Location = new System.Drawing.Point(3, 3);
            this.pESQUISA_FORNECEDOR_FISICODataGridView.Name = "pESQUISA_FORNECEDOR_FISICODataGridView";
            this.pESQUISA_FORNECEDOR_FISICODataGridView.ReadOnly = true;
            this.pESQUISA_FORNECEDOR_FISICODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pESQUISA_FORNECEDOR_FISICODataGridView.Size = new System.Drawing.Size(952, 299);
            this.pESQUISA_FORNECEDOR_FISICODataGridView.TabIndex = 4;
            this.pESQUISA_FORNECEDOR_FISICODataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pESQUISA_FORNECEDOR_FISICODataGridView_CellDoubleClick);
            this.pESQUISA_FORNECEDOR_FISICODataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pESQUISA_FORNECEDOR_FISICODataGridView_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FORNECEDOR_CODIGO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FORNECEDOR_FISICO_NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FORNECEDOR_FISICO_CPF";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FORNECEDOR_TELEFONE";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FORNECEDOR_CELULAR";
            this.dataGridViewTextBoxColumn5.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FORNECEDOR_ENDERECO";
            this.dataGridViewTextBoxColumn6.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FORNECEDOR_BAIRRO";
            this.dataGridViewTextBoxColumn7.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FORNECEDOR_CIDADE";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bsFornecedorFisico
            // 
            this.bsFornecedorFisico.DataMember = "PESQUISA_FORNECEDOR_FISICO";
            this.bsFornecedorFisico.DataSource = this.dsFROGIOS;
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabJuridico
            // 
            this.tabJuridico.AutoScroll = true;
            this.tabJuridico.BackColor = System.Drawing.Color.LightBlue;
            this.tabJuridico.Controls.Add(this.pESQUISA_FORNECEDOR_JURIDICODataGridView);
            this.tabJuridico.Location = new System.Drawing.Point(4, 34);
            this.tabJuridico.Name = "tabJuridico";
            this.tabJuridico.Padding = new System.Windows.Forms.Padding(3);
            this.tabJuridico.Size = new System.Drawing.Size(958, 305);
            this.tabJuridico.TabIndex = 1;
            this.tabJuridico.Text = "juridico";
            // 
            // pESQUISA_FORNECEDOR_JURIDICODataGridView
            // 
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.AllowUserToAddRows = false;
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.AllowUserToDeleteRows = false;
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.AutoGenerateColumns = false;
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.DataSource = this.bsFornecedorJuridico;
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.Location = new System.Drawing.Point(3, 3);
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.Name = "pESQUISA_FORNECEDOR_JURIDICODataGridView";
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.ReadOnly = true;
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.Size = new System.Drawing.Size(952, 299);
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.TabIndex = 5;
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pESQUISA_FORNECEDOR_JURIDICODataGridView_CellDoubleClick);
            this.pESQUISA_FORNECEDOR_JURIDICODataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pESQUISA_FORNECEDOR_JURIDICODataGridView_KeyDown);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FORNECEDOR_CODIGO";
            this.dataGridViewTextBoxColumn9.HeaderText = "Código";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FORNECEDOR_JURIDICO_FANTASIA";
            this.dataGridViewTextBoxColumn10.HeaderText = "Fantasia";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FORNECEDOR_JURIDICO_CNPJ";
            this.dataGridViewTextBoxColumn11.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FORNECEDOR_TELEFONE";
            this.dataGridViewTextBoxColumn12.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "FORNECEDOR_CELULAR";
            this.dataGridViewTextBoxColumn13.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "FORNECEDOR_ENDERECO";
            this.dataGridViewTextBoxColumn14.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "FORNECEDOR_BAIRRO";
            this.dataGridViewTextBoxColumn15.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "FORNECEDOR_CIDADE";
            this.dataGridViewTextBoxColumn16.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bsFornecedorJuridico
            // 
            this.bsFornecedorJuridico.DataMember = "PESQUISA_FORNECEDOR_JURIDICO";
            this.bsFornecedorJuridico.DataSource = this.dsFROGIOS;
            // 
            // taPesquisaFornecedorFisico
            // 
            this.taPesquisaFornecedorFisico.ClearBeforeFill = true;
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
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // taPesquisaFornecedorJuridico
            // 
            this.taPesquisaFornecedorJuridico.ClearBeforeFill = true;
            // 
            // formPesquisaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formPesquisaFornecedor";
            this.ShowInTaskbar = false;
            this.Text = "Fornecedores";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            this.tablessPai.ResumeLayout(false);
            this.tabFisico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_FORNECEDOR_FISICODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFornecedorFisico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            this.tabJuridico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_FORNECEDOR_JURIDICODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFornecedorJuridico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTipo;
        private TablessControl tablessPai;
        private System.Windows.Forms.TabPage tabFisico;
        private System.Windows.Forms.TabPage tabJuridico;
        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsFornecedorFisico;
        private dsFROGIOSTableAdapters.taPesquisaFornecedorFisico taPesquisaFornecedorFisico;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pESQUISA_FORNECEDOR_FISICODataGridView;
        private System.Windows.Forms.BindingSource bsFornecedorJuridico;
        private dsFROGIOSTableAdapters.taPesquisaFornecedorJuridico taPesquisaFornecedorJuridico;
        private System.Windows.Forms.DataGridView pESQUISA_FORNECEDOR_JURIDICODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}