namespace FROGI_OS.InterfaceGrafica
{
    partial class formPesquisaOS
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
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.bsFisico = new System.Windows.Forms.BindingSource(this.components);
            this.taPesquisaOSFisico = new FROGI_OS.dsFROGIOSTableAdapters.taPesquisaOSFisico();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.pESQUISA_OS_FISICODataGridView = new System.Windows.Forms.DataGridView();
            this.bsJuridico = new System.Windows.Forms.BindingSource(this.components);
            this.taPesquisaOSJuridico = new FROGI_OS.dsFROGIOSTableAdapters.taPesquisaOSJuridico();
            this.pESQUISA_OS_JURIDICODataGridView = new System.Windows.Forms.DataGridView();
            this.dateFiltro = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCabecalho.SuspendLayout();
            this.panelRodape.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.tablessPai.SuspendLayout();
            this.tabFisico.SuspendLayout();
            this.tabJuridico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFisico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_OS_FISICODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJuridico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_OS_JURIDICODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.Controls.Add(this.dateFiltro);
            this.panelCabecalho.Controls.Add(this.comboStatus);
            this.panelCabecalho.Size = new System.Drawing.Size(784, 131);
            this.panelCabecalho.Controls.SetChildIndex(this.labelPesquisa, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.comboCampoPesquisa, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.label1, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.textValorPesquisa, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.comboTipoCliente, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.buttonPesquisar, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.comboStatus, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.dateFiltro, 0);
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.Location = new System.Drawing.Point(12, 36);
            this.labelPesquisa.Size = new System.Drawing.Size(73, 54);
            this.labelPesquisa.Text = "OS";
            // 
            // comboTipoCliente
            // 
            this.comboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.comboTipoCliente_SelectedIndexChanged);
            // 
            // panelCentro
            // 
            this.panelCentro.Location = new System.Drawing.Point(0, 131);
            this.panelCentro.Size = new System.Drawing.Size(784, 360);
            // 
            // buttonNovoRegistro
            // 
            this.buttonNovoRegistro.Text = "Lançar OS";
            // 
            // tablessPai
            // 
            this.tablessPai.Size = new System.Drawing.Size(784, 360);
            // 
            // tabFisico
            // 
            this.tabFisico.AutoScroll = true;
            this.tabFisico.Controls.Add(this.pESQUISA_OS_FISICODataGridView);
            this.tabFisico.Size = new System.Drawing.Size(776, 322);
            // 
            // tabJuridico
            // 
            this.tabJuridico.AutoScroll = true;
            this.tabJuridico.Controls.Add(this.pESQUISA_OS_JURIDICODataGridView);
            this.tabJuridico.Size = new System.Drawing.Size(776, 322);
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Todos",
            "Lançado",
            "Aberto",
            "Concluido",
            "Cancelado"});
            this.comboStatus.Location = new System.Drawing.Point(474, 42);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(117, 33);
            this.comboStatus.TabIndex = 2;
            this.comboStatus.Visible = false;
            this.comboStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboStatus_KeyDown);
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsFisico
            // 
            this.bsFisico.DataMember = "PESQUISA_OS_FISICO";
            this.bsFisico.DataSource = this.dsFROGIOS;
            // 
            // taPesquisaOSFisico
            // 
            this.taPesquisaOSFisico.ClearBeforeFill = true;
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
            // pESQUISA_OS_FISICODataGridView
            // 
            this.pESQUISA_OS_FISICODataGridView.AllowUserToAddRows = false;
            this.pESQUISA_OS_FISICODataGridView.AllowUserToDeleteRows = false;
            this.pESQUISA_OS_FISICODataGridView.AutoGenerateColumns = false;
            this.pESQUISA_OS_FISICODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pESQUISA_OS_FISICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pESQUISA_OS_FISICODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pESQUISA_OS_FISICODataGridView.DataSource = this.bsFisico;
            this.pESQUISA_OS_FISICODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pESQUISA_OS_FISICODataGridView.Location = new System.Drawing.Point(3, 3);
            this.pESQUISA_OS_FISICODataGridView.Name = "pESQUISA_OS_FISICODataGridView";
            this.pESQUISA_OS_FISICODataGridView.ReadOnly = true;
            this.pESQUISA_OS_FISICODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pESQUISA_OS_FISICODataGridView.Size = new System.Drawing.Size(770, 316);
            this.pESQUISA_OS_FISICODataGridView.TabIndex = 4;
            this.pESQUISA_OS_FISICODataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._CellDoubleClick);
            this.pESQUISA_OS_FISICODataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this._KeyDown);
            // 
            // bsJuridico
            // 
            this.bsJuridico.DataMember = "PESQUISA_OS_JURIDICO";
            this.bsJuridico.DataSource = this.dsFROGIOS;
            // 
            // taPesquisaOSJuridico
            // 
            this.taPesquisaOSJuridico.ClearBeforeFill = true;
            // 
            // pESQUISA_OS_JURIDICODataGridView
            // 
            this.pESQUISA_OS_JURIDICODataGridView.AllowUserToAddRows = false;
            this.pESQUISA_OS_JURIDICODataGridView.AllowUserToDeleteRows = false;
            this.pESQUISA_OS_JURIDICODataGridView.AutoGenerateColumns = false;
            this.pESQUISA_OS_JURIDICODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pESQUISA_OS_JURIDICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pESQUISA_OS_JURIDICODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.pESQUISA_OS_JURIDICODataGridView.DataSource = this.bsJuridico;
            this.pESQUISA_OS_JURIDICODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pESQUISA_OS_JURIDICODataGridView.Location = new System.Drawing.Point(3, 3);
            this.pESQUISA_OS_JURIDICODataGridView.Name = "pESQUISA_OS_JURIDICODataGridView";
            this.pESQUISA_OS_JURIDICODataGridView.ReadOnly = true;
            this.pESQUISA_OS_JURIDICODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pESQUISA_OS_JURIDICODataGridView.Size = new System.Drawing.Size(770, 316);
            this.pESQUISA_OS_JURIDICODataGridView.TabIndex = 5;
            this.pESQUISA_OS_JURIDICODataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._CellDoubleClick);
            this.pESQUISA_OS_JURIDICODataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this._KeyDown);
            // 
            // dateFiltro
            // 
            this.dateFiltro.Location = new System.Drawing.Point(197, 81);
            this.dateFiltro.Name = "dateFiltro";
            this.dateFiltro.Size = new System.Drawing.Size(394, 33);
            this.dateFiltro.TabIndex = 4;
            this.dateFiltro.ValueChanged += new System.EventHandler(this.dateFiltro_ValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OS_CODIGO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CLIENTE_FISICO_NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CLIENTE_TELEFONE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CLIENTE_CELULAR";
            this.dataGridViewTextBoxColumn7.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FUNCIONARIO_NOME";
            this.dataGridViewTextBoxColumn4.HeaderText = "Funcionário";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OS_DATA";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OS_STATUS";
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OS_CODIGO";
            this.dataGridViewTextBoxColumn8.HeaderText = "Código";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CLIENTE_JURIDICO_FANTASIA";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fantasia";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CLIENTE_TELEFONE";
            this.dataGridViewTextBoxColumn10.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CLIENTE_CELULAR";
            this.dataGridViewTextBoxColumn14.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FUNCIONARIO_NOME";
            this.dataGridViewTextBoxColumn11.HeaderText = "Funcionário";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "OS_DATA";
            this.dataGridViewTextBoxColumn12.HeaderText = "Data";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "OS_STATUS";
            this.dataGridViewTextBoxColumn13.HeaderText = "Status";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // formPesquisaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "formPesquisaOS";
            this.Text = "formPesquisaOS";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelRodape.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.tablessPai.ResumeLayout(false);
            this.tabFisico.ResumeLayout(false);
            this.tabJuridico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFisico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_OS_FISICODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJuridico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_OS_JURIDICODataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboStatus;
        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsFisico;
        private dsFROGIOSTableAdapters.taPesquisaOSFisico taPesquisaOSFisico;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pESQUISA_OS_FISICODataGridView;
        private System.Windows.Forms.BindingSource bsJuridico;
        private dsFROGIOSTableAdapters.taPesquisaOSJuridico taPesquisaOSJuridico;
        private System.Windows.Forms.DataGridView pESQUISA_OS_JURIDICODataGridView;
        private System.Windows.Forms.DateTimePicker dateFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}