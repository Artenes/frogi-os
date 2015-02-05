namespace FROGI_OS.InterfaceGrafica
{
    partial class formPesquisaAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPesquisaAgendamento));
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.tablessPai = new FROGI_OS.TablessControl();
            this.tabFisico = new System.Windows.Forms.TabPage();
            this.pESQUISA_AGENDAMENTO_FISICODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFisico = new System.Windows.Forms.BindingSource(this.components);
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.tabJuridico = new System.Windows.Forms.TabPage();
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsJuridico = new System.Windows.Forms.BindingSource(this.components);
            this.taAgendamentoFisico = new FROGI_OS.dsFROGIOSTableAdapters.taAgendamentoFisico();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.taAgendamentoJuridico = new FROGI_OS.dsFROGIOSTableAdapters.taAgendamentoJuridico();
            this.panelCabecalho.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.tablessPai.SuspendLayout();
            this.tabFisico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_AGENDAMENTO_FISICODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFisico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            this.tabJuridico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_AGENDAMENTO_JURIDICODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJuridico)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.Controls.Add(this.comboTipo);
            this.panelCabecalho.Controls.SetChildIndex(this.labelPesquisa, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.comboCampoPesquisa, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.label1, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.textValorPesquisa, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.buttonPesquisar, 0);
            this.panelCabecalho.Controls.SetChildIndex(this.comboTipo, 0);
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.labelPesquisa.Location = new System.Drawing.Point(3, 22);
            this.labelPesquisa.Size = new System.Drawing.Size(178, 37);
            this.labelPesquisa.Text = "Agendamento";
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.tablessPai);
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Físico",
            "Jurídico"});
            this.comboTipo.Location = new System.Drawing.Point(178, 27);
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
            this.tabFisico.Controls.Add(this.pESQUISA_AGENDAMENTO_FISICODataGridView);
            this.tabFisico.Location = new System.Drawing.Point(4, 34);
            this.tabFisico.Name = "tabFisico";
            this.tabFisico.Padding = new System.Windows.Forms.Padding(3);
            this.tabFisico.Size = new System.Drawing.Size(958, 305);
            this.tabFisico.TabIndex = 0;
            this.tabFisico.Text = "fisico";
            // 
            // pESQUISA_AGENDAMENTO_FISICODataGridView
            // 
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.AllowUserToAddRows = false;
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.AllowUserToDeleteRows = false;
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.AutoGenerateColumns = false;
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.DataSource = this.bsFisico;
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.Location = new System.Drawing.Point(3, 3);
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.Name = "pESQUISA_AGENDAMENTO_FISICODataGridView";
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.ReadOnly = true;
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.Size = new System.Drawing.Size(952, 299);
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.TabIndex = 4;
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pESQUISA_AGENDAMENTO_FISICODataGridView_CellDoubleClick);
            this.pESQUISA_AGENDAMENTO_FISICODataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pESQUISA_AGENDAMENTO_FISICODataGridView_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AGEN_CODIGO";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AGEN_DATA";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bsFisico
            // 
            this.bsFisico.DataMember = "PESQUISA_AGENDAMENTO_FISICO";
            this.bsFisico.DataSource = this.dsFROGIOS;
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
            this.tabJuridico.Controls.Add(this.pESQUISA_AGENDAMENTO_JURIDICODataGridView);
            this.tabJuridico.Location = new System.Drawing.Point(4, 34);
            this.tabJuridico.Name = "tabJuridico";
            this.tabJuridico.Padding = new System.Windows.Forms.Padding(3);
            this.tabJuridico.Size = new System.Drawing.Size(958, 305);
            this.tabJuridico.TabIndex = 1;
            this.tabJuridico.Text = "juridico";
            // 
            // pESQUISA_AGENDAMENTO_JURIDICODataGridView
            // 
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.AllowUserToAddRows = false;
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.AllowUserToDeleteRows = false;
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.AutoGenerateColumns = false;
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.DataSource = this.bsJuridico;
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.Location = new System.Drawing.Point(3, 3);
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.Name = "pESQUISA_AGENDAMENTO_JURIDICODataGridView";
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.ReadOnly = true;
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.Size = new System.Drawing.Size(952, 299);
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.TabIndex = 5;
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pESQUISA_AGENDAMENTO_JURIDICODataGridView_CellDoubleClick);
            this.pESQUISA_AGENDAMENTO_JURIDICODataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pESQUISA_AGENDAMENTO_JURIDICODataGridView_KeyDown);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AGEN_CODIGO";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CLIENTE_JURIDICO_FANTASIA";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fantasia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AGEN_DATA";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bsJuridico
            // 
            this.bsJuridico.DataMember = "PESQUISA_AGENDAMENTO_JURIDICO";
            this.bsJuridico.DataSource = this.dsFROGIOS;
            // 
            // taAgendamentoFisico
            // 
            this.taAgendamentoFisico.ClearBeforeFill = true;
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
            // taAgendamentoJuridico
            // 
            this.taAgendamentoJuridico.ClearBeforeFill = true;
            // 
            // formPesquisaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formPesquisaAgendamento";
            this.Text = "Agendamentos";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            this.tablessPai.ResumeLayout(false);
            this.tabFisico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_AGENDAMENTO_FISICODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFisico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            this.tabJuridico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_AGENDAMENTO_JURIDICODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJuridico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTipo;
        private TablessControl tablessPai;
        private System.Windows.Forms.TabPage tabFisico;
        private System.Windows.Forms.TabPage tabJuridico;
        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsFisico;
        private dsFROGIOSTableAdapters.taAgendamentoFisico taAgendamentoFisico;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pESQUISA_AGENDAMENTO_FISICODataGridView;
        private System.Windows.Forms.BindingSource bsJuridico;
        private dsFROGIOSTableAdapters.taAgendamentoJuridico taAgendamentoJuridico;
        private System.Windows.Forms.DataGridView pESQUISA_AGENDAMENTO_JURIDICODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}